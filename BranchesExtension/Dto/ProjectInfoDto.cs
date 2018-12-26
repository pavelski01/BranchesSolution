using Soneta.Types;

namespace BranchesExtension.Dto
{
    public class ProjectInfoDto
    {
        public Date MinDate { get; set; }
        public Date MaxDate { get; set; }
        public int DaysActivity { get; set; }
        public FromTo ProjectActivity { get; set; }
    }
}
