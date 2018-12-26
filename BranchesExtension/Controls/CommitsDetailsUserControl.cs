using System.Collections.Generic;
using System.Linq;
using BranchesExtension;
using BranchesExtension.Strategy;
using Soneta.Business.Forms.Folders;
using Soneta.Types;

namespace enova365.Dodatek1.Controls
{
    public partial class CommitsDetailsUserControl : CustomView
    {
        public CommitsDetailsUserControl()
        {
            InitializeComponent();
        }

        public void InitControls()
        {
            pathToRepo.Text = 
                Strings.ResourceManager.GetString("PathToRepo");
            urlToRepo.Text =
                Strings.ResourceManager.GetString("UrlToRepo");
            projectActivity.EditValue = FromTo.Empty.ToString();
            projectActivity.ReadOnly = true;
            daysActivity.Text = 0.ToString();
        }

        private void SueBtn_Click(object sender, System.EventArgs e)
        {
            var gitStrategy = new GitComputeViaDtoStrategy();
            var gitContext = new GitComputeContext(gitStrategy);
            var commits = gitContext.CommitsComputation(pathToRepo.Text, urlToRepo.Text);
            var projectInfo = gitContext.ProjectComputation(commits);
            daysActivity.Text = projectInfo.DaysActivity.ToString();
            projectActivity.EditValue = projectInfo.ProjectActivity.ToString();
            commits = commits.OrderBy(d => d.Date).ToList();
            dataGv.DataSource = commits;
            var propTranslDict = new Dictionary<string, string>
            {
                {"Committer", "Sparwca"},
                {"Date", "Data"},
                {"CommitsNumber", "Suma (dzienna)"},
                {"CommitsPersonalAverage", "Średnia (indywidualna)"},
                {"CommitsProjectAverage", "Średnia (okresowa)"}
            };
            var columns = dataGv.Columns;
            var index = 0;
            foreach (var key in propTranslDict.Keys)
            {
                var col = columns[key];
                if (col == null) continue;
                col.DisplayIndex = index++;
                col.HeaderText = propTranslDict[key];
            }
            dataGv.AutoResizeColumns();
        }
    }
}