using System.Collections.Generic;
using BranchesExtension.Dto;
using BranchesExtension.Strategy;
using Soneta.Business;
using Soneta.Types;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global

namespace BranchesExtension.Extender
{
    public class CommitDetailsExtender
    {
        public static bool IsVisible() => true;
        [Context]
        public Context Context { get; set; }
        public string PathToRepo { get; set; } = Strings.ResourceManager.GetString("PathToRepo");
        public string UrlToRepo { get; set; } = Strings.ResourceManager.GetString("UrlToRepo");
        public FromTo ProjectActivity { get; set; } = FromTo.Empty;
        public int DaysActivity { get; set; }
        public IEnumerable<CommitDto> DetailedInfos => _commits;

        private List<CommitDto> _commits = new List<CommitDto>();

        public void ProccessRepo()
        {
            _commits?.Clear();
            var gitStrategy = new GitComputeViaDtoStrategy();
            var gitContext = new GitComputeContext(gitStrategy);
            _commits = gitContext.CommitsComputation(PathToRepo, UrlToRepo);
            var projectInfo = gitContext.ProjectComputation(_commits);
            DaysActivity = projectInfo.DaysActivity;
            ProjectActivity = projectInfo.ProjectActivity;
            Context.Session.InvokeChanged();
        }
    }
}
