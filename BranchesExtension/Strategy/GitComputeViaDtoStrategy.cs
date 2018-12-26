using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BranchesExtension.Dto;
using LibGit2Sharp;
using Soneta.Types;

namespace BranchesExtension.Strategy
{
    public class GitComputeViaDtoStrategy : IGitComputeStrategy
    {
        // TODO Optimize algorithm speed
        public List<CommitDto> GetCommits(string pathToRepo, string pathToUrl)
        {
            var probe = Repository.Discover(pathToRepo);
            if (!string.IsNullOrEmpty(probe))
                DeleteDirectory(pathToRepo);
            var repoPath = Repository.Clone(pathToUrl, pathToRepo);
            var commitsResult = new List<CommitDto>();
            var committers = new HashSet<string>();
            using (var repo = new Repository(repoPath))
                foreach (var branch in repo.Branches)
                    if (branch.IsRemote)
                        foreach (var commit in branch.Commits)
                        {
                            if (!committers.Contains(commit.Committer.ToString()))
                                committers.Add(commit.Committer.ToString());
                            commitsResult.Add(
                                new CommitDto
                                {
                                    Committer = commit.Committer.ToString(),
                                    Date = commit.Committer.When.Date
                                }
                            );
                        }
            commitsResult.Sort((e1, e2) => DateTime.Compare(e1.Date, e2.Date));
            var startThresholdDate = commitsResult.First().Date;
            var endThresholdDate = commitsResult.Last().Date;
            var results = new List<CommitDto>();
            foreach (var committer in committers)
                for (var index = startThresholdDate; index <= endThresholdDate; index = index.AddDays(1))
                    results.Add(
                        new CommitDto
                        {
                            Committer = committer,
                            Date = index,
                            CommitsNumber = 
                                commitsResult.Count(e => e.Date == index && e.Committer == committer)
                        }
                    );
            var numberOfDays = Math.Ceiling(((DateTime)endThresholdDate).Subtract(startThresholdDate).TotalDays) + 1;
            foreach (var committer in committers)
            {
                var sum = results.Where(e => e.Committer == committer).Sum(e => e.CommitsNumber);
                var count = (double)results.Count(e => e.Committer == committer && e.CommitsNumber > 0);
                results.Where(
                    e => 
                    e.Committer == committer
                ).ToList().ForEach(
                    e =>
                    {
                        e.CommitsProjectAverage = Math.Round(sum / numberOfDays, 2);
                        e.CommitsPersonalAverage = Math.Round(sum / count, 2);
                    }
                );
            }
            return results;
        }

        private static void DeleteDirectory(string targetDir)
        {
            var files = Directory.GetFiles(targetDir);
            var dirs = Directory.GetDirectories(targetDir);
            Array.ForEach(
                files,
                file =>
                {
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.Delete(file);
                }
            );
            Array.ForEach(
                dirs,
                DeleteDirectory
            );
            Directory.Delete(targetDir, false);
        }

        public ProjectInfoDto GetProjectInfo(List<CommitDto> commits)
        {
            var minDate = commits.Min(e => e.Date);
            var maxDate = commits.Max(e => e.Date);
            return new ProjectInfoDto
            {
                MinDate = minDate,
                MaxDate = maxDate,
                DaysActivity = 
                    Convert.ToInt32(
                        Math.Ceiling(
                            ((DateTime)maxDate).Subtract(minDate).TotalDays
                        ) + 1
                    ),
                ProjectActivity = new FromTo(minDate, maxDate)
            };
        }
    }
}
