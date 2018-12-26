namespace enova365.Dodatek1.Controls
{
    partial class CommitsDetailsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pathToRepo = new System.Windows.Forms.TextBox();
            this.divider1 = new Soneta.Forms.Controls.Divider();
            this.label2 = new System.Windows.Forms.Label();
            this.urlToRepo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.daysActivity = new System.Windows.Forms.TextBox();
            this.sueBtn = new System.Windows.Forms.Button();
            this.projectActivity = new Soneta.Forms.Controls.DataEdit();
            this.dataGv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ścieżka do repozytorium:";
            // 
            // pathToRepo
            // 
            this.pathToRepo.Location = new System.Drawing.Point(187, 22);
            this.pathToRepo.Name = "pathToRepo";
            this.pathToRepo.Size = new System.Drawing.Size(349, 20);
            this.pathToRepo.TabIndex = 2;
            // 
            // divider1
            // 
            this.divider1.Location = new System.Drawing.Point(6, 3);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(1111, 13);
            this.divider1.TabIndex = 3;
            this.divider1.Text = "Informacje o commitach";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "URL do repozytorium:";
            // 
            // urlToRepo
            // 
            this.urlToRepo.Location = new System.Drawing.Point(738, 21);
            this.urlToRepo.Name = "urlToRepo";
            this.urlToRepo.Size = new System.Drawing.Size(368, 20);
            this.urlToRepo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Okres aktywności projektu (data):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Okres aktywności projektu (dni):";
            // 
            // daysActivity
            // 
            this.daysActivity.Location = new System.Drawing.Point(738, 47);
            this.daysActivity.Name = "daysActivity";
            this.daysActivity.ReadOnly = true;
            this.daysActivity.Size = new System.Drawing.Size(51, 20);
            this.daysActivity.TabIndex = 9;
            // 
            // sueBtn
            // 
            this.sueBtn.Location = new System.Drawing.Point(795, 47);
            this.sueBtn.Name = "sueBtn";
            this.sueBtn.Size = new System.Drawing.Size(311, 20);
            this.sueBtn.TabIndex = 10;
            this.sueBtn.Text = "Procesuj";
            this.sueBtn.UseVisualStyleBackColor = true;
            this.sueBtn.Click += new System.EventHandler(this.SueBtn_Click);
            // 
            // projectActivity
            // 
            this.projectActivity.Location = new System.Drawing.Point(187, 48);
            this.projectActivity.Name = "projectActivity";
            this.projectActivity.Size = new System.Drawing.Size(349, 20);
            this.projectActivity.TabIndex = 11;
            // 
            // dataGv
            // 
            this.dataGv.AllowUserToAddRows = false;
            this.dataGv.AllowUserToDeleteRows = false;
            this.dataGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGv.Location = new System.Drawing.Point(9, 74);
            this.dataGv.Name = "dataGv";
            this.dataGv.ReadOnly = true;
            this.dataGv.Size = new System.Drawing.Size(1097, 506);
            this.dataGv.TabIndex = 12;
            // 
            // CommitsDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGv);
            this.Controls.Add(this.projectActivity);
            this.Controls.Add(this.sueBtn);
            this.Controls.Add(this.daysActivity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.urlToRepo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.divider1);
            this.Controls.Add(this.pathToRepo);
            this.Controls.Add(this.label1);
            this.Name = "CommitsDetailsUserControl";
            this.Size = new System.Drawing.Size(1120, 580);
            ((System.ComponentModel.ISupportInitialize)(this.dataGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathToRepo;
        private Soneta.Forms.Controls.Divider divider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urlToRepo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox daysActivity;
        private System.Windows.Forms.Button sueBtn;
        private Soneta.Forms.Controls.DataEdit projectActivity;
        private System.Windows.Forms.DataGridView dataGv;
    }
}
