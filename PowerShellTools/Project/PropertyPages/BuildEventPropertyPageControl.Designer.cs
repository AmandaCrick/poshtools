namespace PowerShellTools.Project.PropertyPages
{
    partial class BuildEventPropertyPageControl
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
            this.cmoExecutionPolicy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrebuild = new System.Windows.Forms.TextBox();
            this.txtPostbuild = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmoExecutionPolicy
            // 
            this.cmoExecutionPolicy.FormattingEnabled = true;
            this.cmoExecutionPolicy.Items.AddRange(new object[] {
            "AllSigned",
            "Bypass",
            "Default",
            "RemoteSigned",
            "Restricted",
            "Undefined",
            "Unrestricted"});
            this.cmoExecutionPolicy.Location = new System.Drawing.Point(114, 28);
            this.cmoExecutionPolicy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmoExecutionPolicy.Name = "cmoExecutionPolicy";
            this.cmoExecutionPolicy.Size = new System.Drawing.Size(250, 21);
            this.cmoExecutionPolicy.TabIndex = 0;
            this.cmoExecutionPolicy.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Execution Policy";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pre-build event PowerShell Script";
            // 
            // txtPrebuild
            // 
            this.txtPrebuild.Location = new System.Drawing.Point(22, 90);
            this.txtPrebuild.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrebuild.Multiline = true;
            this.txtPrebuild.Name = "txtPrebuild";
            this.txtPrebuild.Size = new System.Drawing.Size(342, 145);
            this.txtPrebuild.TabIndex = 3;
            // 
            // txtPostbuild
            // 
            this.txtPostbuild.Location = new System.Drawing.Point(22, 276);
            this.txtPostbuild.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPostbuild.Multiline = true;
            this.txtPostbuild.Name = "txtPostbuild";
            this.txtPostbuild.Size = new System.Drawing.Size(342, 145);
            this.txtPostbuild.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Post-build event PowerShell Script";
            // 
            // BuildEventPropertyPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPostbuild);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrebuild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmoExecutionPolicy);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuildEventPropertyPageControl";
            this.Size = new System.Drawing.Size(557, 493);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmoExecutionPolicy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrebuild;
        private System.Windows.Forms.TextBox txtPostbuild;
        private System.Windows.Forms.Label label3;
    }
}
