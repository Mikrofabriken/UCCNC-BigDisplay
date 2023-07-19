namespace Plugins
{
    partial class PluginForm
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
            this.LabelX = new System.Windows.Forms.Label();
            this.LabelY = new System.Windows.Forms.Label();
            this.LabelZ = new System.Windows.Forms.Label();
            this.DisplayX = new System.Windows.Forms.Label();
            this.DisplayY = new System.Windows.Forms.Label();
            this.DisplayZ = new System.Windows.Forms.Label();
            this.LabelF = new System.Windows.Forms.Label();
            this.DisplayF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // LabelX
            //
            this.LabelX.AutoSize =  true;
            this.LabelX.Text =  "X";
            this.LabelX.BackColor = System.Drawing.SystemColors.WindowText;
            this.LabelX.Font = new System.Drawing.Font("Consolas", 144F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelX.ForeColor = System.Drawing.SystemColors.Info;
            this.LabelX.Location = new System.Drawing.Point(12,8);
            this.LabelX.Size = new System.Drawing.Size(201,225);
            //
            // LabelY
            //
            this.LabelY.AutoSize =  true;
            this.LabelY.Text =  "Y";
            this.LabelY.BackColor = System.Drawing.SystemColors.WindowText;
            this.LabelY.Font = new System.Drawing.Font("Consolas", 144F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelY.ForeColor = System.Drawing.SystemColors.Info;
            this.LabelY.Location = new System.Drawing.Point(12,248);
            this.LabelY.Size = new System.Drawing.Size(201,225);
            this.LabelY.TabIndex = 1;
            //
            // LabelZ
            //
            this.LabelZ.AutoSize =  true;
            this.LabelZ.Text =  "Z";
            this.LabelZ.BackColor = System.Drawing.SystemColors.WindowText;
            this.LabelZ.Font = new System.Drawing.Font("Consolas", 144F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelZ.ForeColor = System.Drawing.SystemColors.Info;
            this.LabelZ.Location = new System.Drawing.Point(12,488);
            this.LabelZ.Size = new System.Drawing.Size(201,225);
            this.LabelZ.TabIndex = 2;
            //
            // DisplayX
            //
            this.DisplayX.AutoSize =  true;
            this.DisplayX.Text =  "0";
            this.DisplayX.BackColor = System.Drawing.SystemColors.WindowText;
            this.DisplayX.Font = new System.Drawing.Font("Consolas", 144F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisplayX.ForeColor = System.Drawing.SystemColors.Info;
            this.DisplayX.Location = new System.Drawing.Point(204,8);
            this.DisplayX.Size = new System.Drawing.Size(201,225);
            this.DisplayX.TabIndex = 3;
            //
            // DisplayY
            //
            this.DisplayY.AutoSize =  true;
            this.DisplayY.Text =  "0";
            this.DisplayY.BackColor = System.Drawing.SystemColors.WindowText;
            this.DisplayY.Font = new System.Drawing.Font("Consolas", 144F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisplayY.ForeColor = System.Drawing.SystemColors.Info;
            this.DisplayY.Location = new System.Drawing.Point(204,244);
            this.DisplayY.Size = new System.Drawing.Size(201,225);
            this.DisplayY.TabIndex = 4;
            //
            // DisplayZ
            //
            this.DisplayZ.AutoSize =  true;
            this.DisplayZ.Text =  "0";
            this.DisplayZ.BackColor = System.Drawing.SystemColors.WindowText;
            this.DisplayZ.Font = new System.Drawing.Font("Consolas", 144F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisplayZ.ForeColor = System.Drawing.SystemColors.Info;
            this.DisplayZ.Location = new System.Drawing.Point(204,488);
            this.DisplayZ.Size = new System.Drawing.Size(201,225);
            this.DisplayZ.TabIndex = 5;
            //
            // LabelF
            //
            this.LabelF.AutoSize =  true;
            this.LabelF.Text =  "F";
            this.LabelF.BackColor = System.Drawing.SystemColors.WindowText;
            this.LabelF.Font = new System.Drawing.Font("Consolas", 144F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelF.ForeColor = System.Drawing.SystemColors.Info;
            this.LabelF.Location = new System.Drawing.Point(12,736);
            this.LabelF.Size = new System.Drawing.Size(201,225);
            this.LabelF.TabIndex = 6;
            //
            // DisplayF
            //
            this.DisplayF.AutoSize =  true;
            this.DisplayF.Text =  "0";
            this.DisplayF.BackColor = System.Drawing.SystemColors.WindowText;
            this.DisplayF.Font = new System.Drawing.Font("Consolas", 144F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisplayF.ForeColor = System.Drawing.SystemColors.Info;
            this.DisplayF.Location = new System.Drawing.Point(204,732);
            this.DisplayF.Size = new System.Drawing.Size(201,225);
            this.DisplayF.TabIndex = 7;
         //
         // form
         //
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.Size = new System.Drawing.Size(1464,1024);
            this.Text =  "Big Display";
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.LabelY);
            this.Controls.Add(this.LabelZ);
            this.Controls.Add(this.DisplayX);
            this.Controls.Add(this.DisplayY);
            this.Controls.Add(this.DisplayZ);
            this.Controls.Add(this.LabelF);
            this.Controls.Add(this.DisplayF);
            this.ResumeLayout(false);
        } 

        #endregion 

        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.Label LabelY;
        private System.Windows.Forms.Label LabelZ;
        private System.Windows.Forms.Label LabelF;
        public System.Windows.Forms.Label DisplayX;
        public System.Windows.Forms.Label DisplayY;
        public System.Windows.Forms.Label DisplayZ;
        public System.Windows.Forms.Label DisplayF;
    }
}