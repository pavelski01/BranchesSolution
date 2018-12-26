using System.Collections.Generic;
using enova365.Dodatek1.Dto;

// ReSharper disable AutoPropertyCanBeMadeGetOnly.Local

namespace enova365.Dodatek1.Strategy
{
    public class GitComputeContext
    {
        private IGitComputeStrategy Strategy { get; set; }

        public GitComputeContext(IGitComputeStrategy strategy)
        {
            Strategy = strategy;
        }

        public List<CommitDto> CommitsComputation(
            string pathToRepo, string pathToUrl
        )
        {
            return Strategy?.GetCommits(pathToRepo, pathToUrl);
        }

        public ProjectInfoDto ProjectComputation(
            List<CommitDto> commits
        )
        {
            return Strategy?.GetProjectInfo(commits);
        }
    }
}
