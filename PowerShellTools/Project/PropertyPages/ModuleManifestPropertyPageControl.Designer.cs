namespace PowerShellTools.Project.PropertyPages
{
    partial class ModuleManifestPropertyPageControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabModule = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.txtHelpInfoUri = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtRootModule = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNestedModules = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.tabAuthor = new System.Windows.Forms.TabPage();
            this.txtCopyright = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabComponents = new System.Windows.Forms.TabPage();
            this.cmoScriptsToProcess = new System.Windows.Forms.ComboBox();
            this.txtTypesToProcess = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtModuleToProcess = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtModuleList = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFunctionsToProcess = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFormatsToProcess = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabExports = new System.Windows.Forms.TabPage();
            this.txtFunctionsToExport = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtAlisesToExport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVariablesToExport = new System.Windows.Forms.TextBox();
            this.txtCmdletsToExport = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tabRequirements = new System.Windows.Forms.TabPage();
            this.txtClrVersion = new System.Windows.Forms.TextBox();
            this.txtPowerShellVersion = new System.Windows.Forms.TextBox();
            this.txtRequiredAssemblies = new System.Windows.Forms.TextBox();
            this.txtRequiredModules = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmoProcessorArchitecture = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPowerShellHostVersion = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkGenerateModuleManifest = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabModule.SuspendLayout();
            this.tabAuthor.SuspendLayout();
            this.tabComponents.SuspendLayout();
            this.tabExports.SuspendLayout();
            this.tabRequirements.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabModule);
            this.tabControl1.Controls.Add(this.tabAuthor);
            this.tabControl1.Controls.Add(this.tabComponents);
            this.tabControl1.Controls.Add(this.tabExports);
            this.tabControl1.Controls.Add(this.tabRequirements);
            this.tabControl1.Location = new System.Drawing.Point(19, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 434);
            this.tabControl1.TabIndex = 73;
            // 
            // tabModule
            // 
            this.tabModule.Controls.Add(this.chkGenerateModuleManifest);
            this.tabModule.Controls.Add(this.label26);
            this.tabModule.Controls.Add(this.txtHelpInfoUri);
            this.tabModule.Controls.Add(this.label24);
            this.tabModule.Controls.Add(this.txtRootModule);
            this.tabModule.Controls.Add(this.txtDescription);
            this.tabModule.Controls.Add(this.label8);
            this.tabModule.Controls.Add(this.txtVersion);
            this.tabModule.Controls.Add(this.label23);
            this.tabModule.Controls.Add(this.txtGuid);
            this.tabModule.Controls.Add(this.label11);
            this.tabModule.Controls.Add(this.txtNestedModules);
            this.tabModule.Controls.Add(this.label14);
            this.tabModule.Controls.Add(this.label1);
            this.tabModule.Controls.Add(this.txtPath);
            this.tabModule.Location = new System.Drawing.Point(4, 25);
            this.tabModule.Name = "tabModule";
            this.tabModule.Padding = new System.Windows.Forms.Padding(3);
            this.tabModule.Size = new System.Drawing.Size(923, 405);
            this.tabModule.TabIndex = 4;
            this.tabModule.Text = "Module";
            this.tabModule.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(28, 316);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(91, 17);
            this.label26.TabIndex = 94;
            this.label26.Text = "Help Info URI";
            // 
            // txtHelpInfoUri
            // 
            this.txtHelpInfoUri.Location = new System.Drawing.Point(153, 316);
            this.txtHelpInfoUri.Name = "txtHelpInfoUri";
            this.txtHelpInfoUri.Size = new System.Drawing.Size(392, 22);
            this.txtHelpInfoUri.TabIndex = 93;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(28, 110);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 17);
            this.label24.TabIndex = 92;
            this.label24.Text = "Root Module";
            // 
            // txtRootModule
            // 
            this.txtRootModule.Location = new System.Drawing.Point(153, 105);
            this.txtRootModule.Name = "txtRootModule";
            this.txtRootModule.Size = new System.Drawing.Size(392, 22);
            this.txtRootModule.TabIndex = 91;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(153, 210);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(392, 58);
            this.txtDescription.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 87;
            this.label8.Text = "Description:";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(153, 281);
            this.txtVersion.Margin = new System.Windows.Forms.Padding(4);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(392, 22);
            this.txtVersion.TabIndex = 90;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(28, 281);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 17);
            this.label23.TabIndex = 89;
            this.label23.Text = "Version:";
            // 
            // txtGuid
            // 
            this.txtGuid.Location = new System.Drawing.Point(153, 175);
            this.txtGuid.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(392, 22);
            this.txtGuid.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 175);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 85;
            this.label11.Text = "GUID:";
            // 
            // txtNestedModules
            // 
            this.txtNestedModules.Location = new System.Drawing.Point(153, 140);
            this.txtNestedModules.Margin = new System.Windows.Forms.Padding(4);
            this.txtNestedModules.Name = "txtNestedModules";
            this.txtNestedModules.Size = new System.Drawing.Size(392, 22);
            this.txtNestedModules.TabIndex = 84;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 143);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 17);
            this.label14.TabIndex = 83;
            this.label14.Text = "Nested Modules";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(153, 70);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(392, 22);
            this.txtPath.TabIndex = 0;
            // 
            // tabAuthor
            // 
            this.tabAuthor.Controls.Add(this.txtCopyright);
            this.tabAuthor.Controls.Add(this.label7);
            this.tabAuthor.Controls.Add(this.txtCompany);
            this.tabAuthor.Controls.Add(this.label6);
            this.tabAuthor.Controls.Add(this.txtAuthor);
            this.tabAuthor.Controls.Add(this.label3);
            this.tabAuthor.Location = new System.Drawing.Point(4, 25);
            this.tabAuthor.Name = "tabAuthor";
            this.tabAuthor.Size = new System.Drawing.Size(923, 405);
            this.tabAuthor.TabIndex = 2;
            this.tabAuthor.Text = "Author";
            this.tabAuthor.UseVisualStyleBackColor = true;
            // 
            // txtCopyright
            // 
            this.txtCopyright.Location = new System.Drawing.Point(132, 108);
            this.txtCopyright.Margin = new System.Windows.Forms.Padding(4);
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.Size = new System.Drawing.Size(307, 22);
            this.txtCopyright.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 63;
            this.label7.Text = "Copyright:";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(132, 64);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(307, 22);
            this.txtCompany.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 61;
            this.label6.Text = "Company:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(132, 27);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(307, 22);
            this.txtAuthor.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Author:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabComponents
            // 
            this.tabComponents.Controls.Add(this.cmoScriptsToProcess);
            this.tabComponents.Controls.Add(this.txtTypesToProcess);
            this.tabComponents.Controls.Add(this.label21);
            this.tabComponents.Controls.Add(this.label20);
            this.tabComponents.Controls.Add(this.txtModuleToProcess);
            this.tabComponents.Controls.Add(this.label13);
            this.tabComponents.Controls.Add(this.txtModuleList);
            this.tabComponents.Controls.Add(this.label12);
            this.tabComponents.Controls.Add(this.txtFunctionsToProcess);
            this.tabComponents.Controls.Add(this.label10);
            this.tabComponents.Controls.Add(this.txtFormatsToProcess);
            this.tabComponents.Controls.Add(this.label9);
            this.tabComponents.Location = new System.Drawing.Point(4, 25);
            this.tabComponents.Name = "tabComponents";
            this.tabComponents.Padding = new System.Windows.Forms.Padding(3);
            this.tabComponents.Size = new System.Drawing.Size(923, 405);
            this.tabComponents.TabIndex = 0;
            this.tabComponents.Text = "Components";
            this.tabComponents.UseVisualStyleBackColor = true;
            // 
            // cmoScriptsToProcess
            // 
            this.cmoScriptsToProcess.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmoScriptsToProcess.DropDownHeight = 1;
            this.cmoScriptsToProcess.FormattingEnabled = true;
            this.cmoScriptsToProcess.IntegralHeight = false;
            this.cmoScriptsToProcess.Location = new System.Drawing.Point(197, 186);
            this.cmoScriptsToProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmoScriptsToProcess.Name = "cmoScriptsToProcess";
            this.cmoScriptsToProcess.Size = new System.Drawing.Size(239, 23);
            this.cmoScriptsToProcess.TabIndex = 86;
            // 
            // txtTypesToProcess
            // 
            this.txtTypesToProcess.Location = new System.Drawing.Point(197, 225);
            this.txtTypesToProcess.Margin = new System.Windows.Forms.Padding(4);
            this.txtTypesToProcess.Name = "txtTypesToProcess";
            this.txtTypesToProcess.Size = new System.Drawing.Size(239, 22);
            this.txtTypesToProcess.TabIndex = 85;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 225);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(118, 17);
            this.label21.TabIndex = 84;
            this.label21.Text = "Types to Process";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 186);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(122, 17);
            this.label20.TabIndex = 83;
            this.label20.Text = "Scripts to Process";
            // 
            // txtModuleToProcess
            // 
            this.txtModuleToProcess.Location = new System.Drawing.Point(197, 146);
            this.txtModuleToProcess.Margin = new System.Windows.Forms.Padding(4);
            this.txtModuleToProcess.Name = "txtModuleToProcess";
            this.txtModuleToProcess.Size = new System.Drawing.Size(239, 22);
            this.txtModuleToProcess.TabIndex = 80;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 146);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 17);
            this.label13.TabIndex = 79;
            this.label13.Text = "Module to Process";
            // 
            // txtModuleList
            // 
            this.txtModuleList.Location = new System.Drawing.Point(197, 107);
            this.txtModuleList.Margin = new System.Windows.Forms.Padding(4);
            this.txtModuleList.Name = "txtModuleList";
            this.txtModuleList.Size = new System.Drawing.Size(239, 22);
            this.txtModuleList.TabIndex = 78;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 107);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 77;
            this.label12.Text = "Module List";
            // 
            // txtFunctionsToProcess
            // 
            this.txtFunctionsToProcess.Location = new System.Drawing.Point(197, 67);
            this.txtFunctionsToProcess.Margin = new System.Windows.Forms.Padding(4);
            this.txtFunctionsToProcess.Name = "txtFunctionsToProcess";
            this.txtFunctionsToProcess.Size = new System.Drawing.Size(239, 22);
            this.txtFunctionsToProcess.TabIndex = 76;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 17);
            this.label10.TabIndex = 75;
            this.label10.Text = "Functions to Process";
            // 
            // txtFormatsToProcess
            // 
            this.txtFormatsToProcess.Location = new System.Drawing.Point(197, 28);
            this.txtFormatsToProcess.Margin = new System.Windows.Forms.Padding(4);
            this.txtFormatsToProcess.Name = "txtFormatsToProcess";
            this.txtFormatsToProcess.Size = new System.Drawing.Size(239, 22);
            this.txtFormatsToProcess.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 17);
            this.label9.TabIndex = 73;
            this.label9.Text = "Formats to Process";
            // 
            // tabExports
            // 
            this.tabExports.Controls.Add(this.txtFunctionsToExport);
            this.tabExports.Controls.Add(this.label25);
            this.tabExports.Controls.Add(this.txtAlisesToExport);
            this.tabExports.Controls.Add(this.label2);
            this.tabExports.Controls.Add(this.label5);
            this.tabExports.Controls.Add(this.txtVariablesToExport);
            this.tabExports.Controls.Add(this.txtCmdletsToExport);
            this.tabExports.Controls.Add(this.label22);
            this.tabExports.Location = new System.Drawing.Point(4, 25);
            this.tabExports.Name = "tabExports";
            this.tabExports.Padding = new System.Windows.Forms.Padding(3);
            this.tabExports.Size = new System.Drawing.Size(923, 405);
            this.tabExports.TabIndex = 1;
            this.tabExports.Text = "Exports";
            this.tabExports.UseVisualStyleBackColor = true;
            // 
            // txtFunctionsToExport
            // 
            this.txtFunctionsToExport.Location = new System.Drawing.Point(195, 124);
            this.txtFunctionsToExport.Margin = new System.Windows.Forms.Padding(4);
            this.txtFunctionsToExport.Name = "txtFunctionsToExport";
            this.txtFunctionsToExport.Size = new System.Drawing.Size(241, 22);
            this.txtFunctionsToExport.TabIndex = 58;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(19, 124);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(129, 17);
            this.label25.TabIndex = 57;
            this.label25.Text = "Functions to Export";
            // 
            // txtAlisesToExport
            // 
            this.txtAlisesToExport.Location = new System.Drawing.Point(195, 25);
            this.txtAlisesToExport.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlisesToExport.Name = "txtAlisesToExport";
            this.txtAlisesToExport.Size = new System.Drawing.Size(241, 22);
            this.txtAlisesToExport.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Aliases to Export";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Cmdlets to Export";
            // 
            // txtVariablesToExport
            // 
            this.txtVariablesToExport.Location = new System.Drawing.Point(195, 91);
            this.txtVariablesToExport.Margin = new System.Windows.Forms.Padding(4);
            this.txtVariablesToExport.Name = "txtVariablesToExport";
            this.txtVariablesToExport.Size = new System.Drawing.Size(241, 22);
            this.txtVariablesToExport.TabIndex = 56;
            // 
            // txtCmdletsToExport
            // 
            this.txtCmdletsToExport.Location = new System.Drawing.Point(195, 58);
            this.txtCmdletsToExport.Margin = new System.Windows.Forms.Padding(4);
            this.txtCmdletsToExport.Name = "txtCmdletsToExport";
            this.txtCmdletsToExport.Size = new System.Drawing.Size(241, 22);
            this.txtCmdletsToExport.TabIndex = 54;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 91);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(127, 17);
            this.label22.TabIndex = 55;
            this.label22.Text = "Variables to Export";
            // 
            // tabRequirements
            // 
            this.tabRequirements.Controls.Add(this.txtClrVersion);
            this.tabRequirements.Controls.Add(this.txtPowerShellVersion);
            this.tabRequirements.Controls.Add(this.txtRequiredAssemblies);
            this.tabRequirements.Controls.Add(this.txtRequiredModules);
            this.tabRequirements.Controls.Add(this.label19);
            this.tabRequirements.Controls.Add(this.label18);
            this.tabRequirements.Controls.Add(this.cmoProcessorArchitecture);
            this.tabRequirements.Controls.Add(this.label17);
            this.tabRequirements.Controls.Add(this.label16);
            this.tabRequirements.Controls.Add(this.txtPowerShellHostVersion);
            this.tabRequirements.Controls.Add(this.label15);
            this.tabRequirements.Controls.Add(this.label4);
            this.tabRequirements.Location = new System.Drawing.Point(4, 25);
            this.tabRequirements.Name = "tabRequirements";
            this.tabRequirements.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequirements.Size = new System.Drawing.Size(923, 405);
            this.tabRequirements.TabIndex = 3;
            this.tabRequirements.Text = "Requirements";
            this.tabRequirements.UseVisualStyleBackColor = true;
            // 
            // txtClrVersion
            // 
            this.txtClrVersion.Location = new System.Drawing.Point(194, 58);
            this.txtClrVersion.Name = "txtClrVersion";
            this.txtClrVersion.Size = new System.Drawing.Size(297, 22);
            this.txtClrVersion.TabIndex = 83;
            // 
            // txtPowerShellVersion
            // 
            this.txtPowerShellVersion.Location = new System.Drawing.Point(194, 134);
            this.txtPowerShellVersion.Name = "txtPowerShellVersion";
            this.txtPowerShellVersion.Size = new System.Drawing.Size(297, 22);
            this.txtPowerShellVersion.TabIndex = 82;
            // 
            // txtRequiredAssemblies
            // 
            this.txtRequiredAssemblies.Location = new System.Drawing.Point(194, 176);
            this.txtRequiredAssemblies.Name = "txtRequiredAssemblies";
            this.txtRequiredAssemblies.Size = new System.Drawing.Size(297, 22);
            this.txtRequiredAssemblies.TabIndex = 81;
            // 
            // txtRequiredModules
            // 
            this.txtRequiredModules.Location = new System.Drawing.Point(194, 216);
            this.txtRequiredModules.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequiredModules.Name = "txtRequiredModules";
            this.txtRequiredModules.Size = new System.Drawing.Size(297, 22);
            this.txtRequiredModules.TabIndex = 80;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 216);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 17);
            this.label19.TabIndex = 79;
            this.label19.Text = "Required Modules:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 176);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 17);
            this.label18.TabIndex = 78;
            this.label18.Text = "Required Assemblies:";
            // 
            // cmoProcessorArchitecture
            // 
            this.cmoProcessorArchitecture.FormattingEnabled = true;
            this.cmoProcessorArchitecture.Items.AddRange(new object[] {
            "x86",
            "x64"});
            this.cmoProcessorArchitecture.Location = new System.Drawing.Point(194, 19);
            this.cmoProcessorArchitecture.Margin = new System.Windows.Forms.Padding(4);
            this.cmoProcessorArchitecture.Name = "cmoProcessorArchitecture";
            this.cmoProcessorArchitecture.Size = new System.Drawing.Size(297, 24);
            this.cmoProcessorArchitecture.TabIndex = 77;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 29);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 17);
            this.label17.TabIndex = 76;
            this.label17.Text = "Architecture:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 137);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 17);
            this.label16.TabIndex = 74;
            this.label16.Text = "PowerShell Version:";
            // 
            // txtPowerShellHostVersion
            // 
            this.txtPowerShellHostVersion.Location = new System.Drawing.Point(194, 98);
            this.txtPowerShellHostVersion.Margin = new System.Windows.Forms.Padding(4);
            this.txtPowerShellHostVersion.Name = "txtPowerShellHostVersion";
            this.txtPowerShellHostVersion.Size = new System.Drawing.Size(297, 22);
            this.txtPowerShellHostVersion.TabIndex = 73;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 98);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 17);
            this.label15.TabIndex = 72;
            this.label15.Text = "Host Version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "CLR Version:";
            // 
            // chkGenerateModuleManifest
            // 
            this.chkGenerateModuleManifest.AutoSize = true;
            this.chkGenerateModuleManifest.Location = new System.Drawing.Point(31, 27);
            this.chkGenerateModuleManifest.Name = "chkGenerateModuleManifest";
            this.chkGenerateModuleManifest.Size = new System.Drawing.Size(197, 21);
            this.chkGenerateModuleManifest.TabIndex = 95;
            this.chkGenerateModuleManifest.Text = "Generate Module Manifest";
            this.chkGenerateModuleManifest.UseVisualStyleBackColor = true;
            // 
            // ModuleManifestPropertyPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModuleManifestPropertyPageControl";
            this.Size = new System.Drawing.Size(967, 466);
            this.tabControl1.ResumeLayout(false);
            this.tabModule.ResumeLayout(false);
            this.tabModule.PerformLayout();
            this.tabAuthor.ResumeLayout(false);
            this.tabAuthor.PerformLayout();
            this.tabComponents.ResumeLayout(false);
            this.tabComponents.PerformLayout();
            this.tabExports.ResumeLayout(false);
            this.tabExports.PerformLayout();
            this.tabRequirements.ResumeLayout(false);
            this.tabRequirements.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabComponents;
        private System.Windows.Forms.ComboBox cmoScriptsToProcess;
        private System.Windows.Forms.TextBox txtTypesToProcess;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtModuleToProcess;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtModuleList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFunctionsToProcess;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFormatsToProcess;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabExports;
        private System.Windows.Forms.TabPage tabAuthor;
        private System.Windows.Forms.TextBox txtAlisesToExport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVariablesToExport;
        private System.Windows.Forms.TextBox txtCmdletsToExport;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCopyright;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabRequirements;
        private System.Windows.Forms.TabPage tabModule;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtVersion;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtGuid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNestedModules;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtRequiredModules;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmoProcessorArchitecture;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtPowerShellHostVersion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtRootModule;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtHelpInfoUri;
        private System.Windows.Forms.TextBox txtFunctionsToExport;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtRequiredAssemblies;
        private System.Windows.Forms.TextBox txtClrVersion;
        private System.Windows.Forms.TextBox txtPowerShellVersion;
        private System.Windows.Forms.CheckBox chkGenerateModuleManifest;
    }
}
