using Soneta.Types;

namespace enova365.Dodatek1.Dto
{
    public class ProjectInfoDto
    {
        public Date MinDate { get; set; }
        public Date MaxDate { get; set; }
        public int DaysActivity { get; set; }
        public FromTo ProjectActivity { get; set; }
    }
}
