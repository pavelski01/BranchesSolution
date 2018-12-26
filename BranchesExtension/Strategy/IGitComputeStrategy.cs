using System.Collections.Generic;
using enova365.Dodatek1.Dto;

namespace enova365.Dodatek1.Strategy
{
    public interface IGitComputeStrategy
    {
        List<CommitDto> GetCommits(string pathToRepo, string pathToUrl);
        ProjectInfoDto GetProjectInfo(List<CommitDto> commits);
    }
}
