namespace InventoriApp
{
    partial class Reporting
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvviewdata = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnlclosereport = new System.Windows.Forms.Panel();
            this.bntclose = new System.Windows.Forms.Button();
            this.btnmini = new System.Windows.Forms.Button();
            this.btnhide = new System.Windows.Forms.Button();
            this.pnlclosereport.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvviewdata
            // 
            this.crvviewdata.ActiveViewIndex = -1;
            this.crvviewdata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvviewdata.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvviewdata.Location = new System.Drawing.Point(0, 30);
            this.crvviewdata.Name = "crvviewdata";
            this.crvviewdata.ShowCloseButton = false;
            this.crvviewdata.ShowGroupTreeButton = false;
            this.crvviewdata.ShowParameterPanelButton = false;
            this.crvviewdata.Size = new System.Drawing.Size(1295, 621);
            this.crvviewdata.TabIndex = 1;
            this.crvviewdata.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // pnlclosereport
            // 
            this.pnlclosereport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.pnlclosereport.Controls.Add(this.btnhide);
            this.pnlclosereport.Controls.Add(this.btnmini);
            this.pnlclosereport.Controls.Add(this.bntclose);
            this.pnlclosereport.Location = new System.Drawing.Point(0, 0);
            this.pnlclosereport.Name = "pnlclosereport";
            this.pnlclosereport.Size = new System.Drawing.Size(1295, 32);
            this.pnlclosereport.TabIndex = 2;
            // 
            // bntclose
            // 
            this.bntclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(86)))), ((int)(((byte)(84)))));
            this.bntclose.FlatAppearance.BorderSize = 0;
            this.bntclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntclose.Location = new System.Drawing.Point(1246, 0);
            this.bntclose.Name = "bntclose";
            this.bntclose.Size = new System.Drawing.Size(26, 24);
            this.bntclose.TabIndex = 1;
            this.bntclose.UseVisualStyleBackColor = false;
            this.bntclose.Click += new System.EventHandler(this.bntclose_Click);
            // 
            // btnmini
            // 
            this.btnmini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.btnmini.FlatAppearance.BorderSize = 0;
            this.btnmini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmini.Location = new System.Drawing.Point(1220, 0);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(26, 24);
            this.btnmini.TabIndex = 2;
            this.btnmini.UseVisualStyleBackColor = false;
            // 
            // btnhide
            // 
            this.btnhide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(92)))), ((int)(((byte)(161)))));
            this.btnhide.FlatAppearance.BorderSize = 0;
            this.btnhide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhide.Location = new System.Drawing.Point(1194, 0);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(26, 24);
            this.btnhide.TabIndex = 3;
            this.btnhide.UseVisualStyleBackColor = false;
            // 
            // Reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 653);
            this.Controls.Add(this.pnlclosereport);
            this.Controls.Add(this.crvviewdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporting";
            this.Load += new System.EventHandler(this.Reporting_Load);
            this.pnlclosereport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvviewdata;
        private System.Windows.Forms.Panel pnlclosereport;
        private System.Windows.Forms.Button bntclose;
        private System.Windows.Forms.Button btnmini;
        private System.Windows.Forms.Button btnhide;

    }
}