using BranchesExtension.Dto;
using System.Collections.Generic;

namespace BranchesExtension.Strategy
{
    public interface IGitComputeStrategy
    {
        List<CommitDto> GetCommits(string pathToRepo, string pathToUrl);
        ProjectInfoDto GetProjectInfo(List<CommitDto> commits);
    }
}
