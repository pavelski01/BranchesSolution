﻿using Soneta.Types;

namespace BranchesExtension.Dto
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
