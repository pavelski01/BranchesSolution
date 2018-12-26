using Soneta.Types;

// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace enova365.Dodatek1.Dto
{
    public class CommitDto
    {
        public string Committer { get; set; }
        public Date Date { get; set; }
        public int CommitsNumber { get; set; }
        public double CommitsPersonalAverage { get; set; }
        public double CommitsProjectAverage { get; set; }
    }
}
