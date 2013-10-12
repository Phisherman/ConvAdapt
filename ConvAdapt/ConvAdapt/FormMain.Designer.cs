namespace ConvAdapt
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlText = new System.Windows.Forms.TabControl();
            this.tabPageTextBox = new System.Windows.Forms.TabPage();
            this.splitContainerTextBoxes = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReplaced = new System.Windows.Forms.TextBox();
            this.tabPageFiles = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxOpenPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonChangeOpenPath = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonChangeSavePath = new System.Windows.Forms.Button();
            this.radioButtonSaveAtOtherLocation = new System.Windows.Forms.RadioButton();
            this.radioButtonReplaceFiles = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchPattern = new System.Windows.Forms.TextBox();
            this.checkBoxUseSearchFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxInstantApply = new System.Windows.Forms.CheckBox();
            this.buttonApplyConvention = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxLowerText = new System.Windows.Forms.CheckBox();
            this.checkBoxCapitalizeLetterAfterUnderscore = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonIgnoreUnderscoreAtStart = new System.Windows.Forms.RadioButton();
            this.radioButtonInsertUnderscoreAtStart = new System.Windows.Forms.RadioButton();
            this.radioButtonRemoveUnderscoreAtStart = new System.Windows.Forms.RadioButton();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.radioButtonUnderscoreCase = new System.Windows.Forms.RadioButton();
            this.radioButtonCamelCase = new System.Windows.Forms.RadioButton();
            this.radioButtonCapitalizeFirstLetter = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonCapitalizeFirstLetterIgnore = new System.Windows.Forms.RadioButton();
            this.radioButtonLowerFirstLetter = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControlText.SuspendLayout();
            this.tabPageTextBox.SuspendLayout();
            this.splitContainerTextBoxes.Panel1.SuspendLayout();
            this.splitContainerTextBoxes.Panel2.SuspendLayout();
            this.splitContainerTextBoxes.SuspendLayout();
            this.tabPageFiles.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlText
            // 
            this.tabControlText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlText.Controls.Add(this.tabPageTextBox);
            this.tabControlText.Controls.Add(this.tabPageFiles);
            this.tabControlText.Location = new System.Drawing.Point(0, 0);
            this.tabControlText.Name = "tabControlText";
            this.tabControlText.SelectedIndex = 0;
            this.tabControlText.Size = new System.Drawing.Size(568, 264);
            this.tabControlText.TabIndex = 0;
            // 
            // tabPageTextBox
            // 
            this.tabPageTextBox.Controls.Add(this.splitContainerTextBoxes);
            this.tabPageTextBox.Location = new System.Drawing.Point(4, 22);
            this.tabPageTextBox.Name = "tabPageTextBox";
            this.tabPageTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTextBox.Size = new System.Drawing.Size(560, 238);
            this.tabPageTextBox.TabIndex = 0;
            this.tabPageTextBox.Text = "Textbox";
            this.tabPageTextBox.UseVisualStyleBackColor = true;
            // 
            // splitContainerTextBoxes
            // 
            this.splitContainerTextBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTextBoxes.Location = new System.Drawing.Point(3, 3);
            this.splitContainerTextBoxes.Name = "splitContainerTextBoxes";
            // 
            // splitContainerTextBoxes.Panel1
            // 
            this.splitContainerTextBoxes.Panel1.Controls.Add(this.label2);
            this.splitContainerTextBoxes.Panel1.Controls.Add(this.textBoxOriginal);
            // 
            // splitContainerTextBoxes.Panel2
            // 
            this.splitContainerTextBoxes.Panel2.Controls.Add(this.label3);
            this.splitContainerTextBoxes.Panel2.Controls.Add(this.textBoxReplaced);
            this.splitContainerTextBoxes.Size = new System.Drawing.Size(554, 232);
            this.splitContainerTextBoxes.SplitterDistance = 268;
            this.splitContainerTextBoxes.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Original";
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOriginal.Location = new System.Drawing.Point(0, 19);
            this.textBoxOriginal.Multiline = true;
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(271, 213);
            this.textBoxOriginal.TabIndex = 0;
            this.textBoxOriginal.TextChanged += new System.EventHandler(this.textBoxOriginal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ersetzt";
            // 
            // textBoxReplaced
            // 
            this.textBoxReplaced.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReplaced.Location = new System.Drawing.Point(0, 19);
            this.textBoxReplaced.Multiline = true;
            this.textBoxReplaced.Name = "textBoxReplaced";
            this.textBoxReplaced.ReadOnly = true;
            this.textBoxReplaced.Size = new System.Drawing.Size(279, 213);
            this.textBoxReplaced.TabIndex = 1;
            // 
            // tabPageFiles
            // 
            this.tabPageFiles.Controls.Add(this.label6);
            this.tabPageFiles.Controls.Add(this.listBoxFiles);
            this.tabPageFiles.Controls.Add(this.groupBox6);
            this.tabPageFiles.Controls.Add(this.groupBox5);
            this.tabPageFiles.Location = new System.Drawing.Point(4, 22);
            this.tabPageFiles.Name = "tabPageFiles";
            this.tabPageFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFiles.Size = new System.Drawing.Size(560, 238);
            this.tabPageFiles.TabIndex = 1;
            this.tabPageFiles.Text = "Files";
            this.tabPageFiles.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Selected files";
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Items.AddRange(new object[] {
            "-"});
            this.listBoxFiles.Location = new System.Drawing.Point(8, 22);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxFiles.Size = new System.Drawing.Size(260, 208);
            this.listBoxFiles.TabIndex = 9;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxOpenPath);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.buttonChangeOpenPath);
            this.groupBox6.Location = new System.Drawing.Point(299, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(255, 56);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Select files";
            // 
            // textBoxOpenPath
            // 
            this.textBoxOpenPath.Location = new System.Drawing.Point(42, 27);
            this.textBoxOpenPath.Name = "textBoxOpenPath";
            this.textBoxOpenPath.Size = new System.Drawing.Size(168, 20);
            this.textBoxOpenPath.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Path:";
            // 
            // buttonChangeOpenPath
            // 
            this.buttonChangeOpenPath.Location = new System.Drawing.Point(216, 25);
            this.buttonChangeOpenPath.Name = "buttonChangeOpenPath";
            this.buttonChangeOpenPath.Size = new System.Drawing.Size(32, 23);
            this.buttonChangeOpenPath.TabIndex = 5;
            this.buttonChangeOpenPath.Text = "...";
            this.buttonChangeOpenPath.UseVisualStyleBackColor = true;
            this.buttonChangeOpenPath.Click += new System.EventHandler(this.buttonChangeOpenPath_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxSavePath);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.buttonChangeSavePath);
            this.groupBox5.Controls.Add(this.radioButtonSaveAtOtherLocation);
            this.groupBox5.Controls.Add(this.radioButtonReplaceFiles);
            this.groupBox5.Location = new System.Drawing.Point(299, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 95);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Save method";
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Location = new System.Drawing.Point(42, 66);
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.Size = new System.Drawing.Size(168, 20);
            this.textBoxSavePath.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Path:";
            // 
            // buttonChangeSavePath
            // 
            this.buttonChangeSavePath.Location = new System.Drawing.Point(216, 64);
            this.buttonChangeSavePath.Name = "buttonChangeSavePath";
            this.buttonChangeSavePath.Size = new System.Drawing.Size(32, 23);
            this.buttonChangeSavePath.TabIndex = 5;
            this.buttonChangeSavePath.Text = "...";
            this.buttonChangeSavePath.UseVisualStyleBackColor = true;
            this.buttonChangeSavePath.Click += new System.EventHandler(this.buttonChangePath_Click);
            // 
            // radioButtonSaveAtOtherLocation
            // 
            this.radioButtonSaveAtOtherLocation.AutoSize = true;
            this.radioButtonSaveAtOtherLocation.Checked = true;
            this.radioButtonSaveAtOtherLocation.Location = new System.Drawing.Point(6, 42);
            this.radioButtonSaveAtOtherLocation.Name = "radioButtonSaveAtOtherLocation";
            this.radioButtonSaveAtOtherLocation.Size = new System.Drawing.Size(129, 17);
            this.radioButtonSaveAtOtherLocation.TabIndex = 4;
            this.radioButtonSaveAtOtherLocation.TabStop = true;
            this.radioButtonSaveAtOtherLocation.Text = "Save at other location";
            this.radioButtonSaveAtOtherLocation.UseVisualStyleBackColor = true;
            // 
            // radioButtonReplaceFiles
            // 
            this.radioButtonReplaceFiles.AutoSize = true;
            this.radioButtonReplaceFiles.Enabled = false;
            this.radioButtonReplaceFiles.Location = new System.Drawing.Point(6, 19);
            this.radioButtonReplaceFiles.Name = "radioButtonReplaceFiles";
            this.radioButtonReplaceFiles.Size = new System.Drawing.Size(189, 17);
            this.radioButtonReplaceFiles.TabIndex = 3;
            this.radioButtonReplaceFiles.Text = "Replace files (not implemented yet)";
            this.radioButtonReplaceFiles.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxSearchPattern);
            this.groupBox3.Controls.Add(this.checkBoxUseSearchFilter);
            this.groupBox3.Location = new System.Drawing.Point(282, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 165);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "regex pattern:";
            // 
            // textBoxSearchPattern
            // 
            this.textBoxSearchPattern.Location = new System.Drawing.Point(9, 55);
            this.textBoxSearchPattern.Multiline = true;
            this.textBoxSearchPattern.Name = "textBoxSearchPattern";
            this.textBoxSearchPattern.Size = new System.Drawing.Size(264, 103);
            this.textBoxSearchPattern.TabIndex = 4;
            // 
            // checkBoxUseSearchFilter
            // 
            this.checkBoxUseSearchFilter.AutoSize = true;
            this.checkBoxUseSearchFilter.Location = new System.Drawing.Point(6, 19);
            this.checkBoxUseSearchFilter.Name = "checkBoxUseSearchFilter";
            this.checkBoxUseSearchFilter.Size = new System.Drawing.Size(65, 17);
            this.checkBoxUseSearchFilter.TabIndex = 3;
            this.checkBoxUseSearchFilter.Text = "Activate";
            this.checkBoxUseSearchFilter.UseVisualStyleBackColor = true;
            // 
            // checkBoxInstantApply
            // 
            this.checkBoxInstantApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxInstantApply.AutoSize = true;
            this.checkBoxInstantApply.Location = new System.Drawing.Point(346, 454);
            this.checkBoxInstantApply.Name = "checkBoxInstantApply";
            this.checkBoxInstantApply.Size = new System.Drawing.Size(87, 30);
            this.checkBoxInstantApply.TabIndex = 9;
            this.checkBoxInstantApply.Text = "Apply when\r\ntext changes";
            this.checkBoxInstantApply.UseVisualStyleBackColor = true;
            // 
            // buttonApplyConvention
            // 
            this.buttonApplyConvention.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonApplyConvention.Location = new System.Drawing.Point(439, 457);
            this.buttonApplyConvention.Name = "buttonApplyConvention";
            this.buttonApplyConvention.Size = new System.Drawing.Size(116, 23);
            this.buttonApplyConvention.TabIndex = 8;
            this.buttonApplyConvention.Text = "Apply convention";
            this.buttonApplyConvention.UseVisualStyleBackColor = true;
            this.buttonApplyConvention.Click += new System.EventHandler(this.buttonApplyConvention_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.checkBoxLowerText);
            this.groupBox2.Controls.Add(this.checkBoxCapitalizeLetterAfterUnderscore);
            this.groupBox2.Location = new System.Drawing.Point(7, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 66);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Use of letters";
            // 
            // checkBoxLowerText
            // 
            this.checkBoxLowerText.AutoSize = true;
            this.checkBoxLowerText.Location = new System.Drawing.Point(6, 42);
            this.checkBoxLowerText.Name = "checkBoxLowerText";
            this.checkBoxLowerText.Size = new System.Drawing.Size(75, 17);
            this.checkBoxLowerText.TabIndex = 5;
            this.checkBoxLowerText.Text = "Lower text";
            this.checkBoxLowerText.UseVisualStyleBackColor = true;
            // 
            // checkBoxCapitalizeLetterAfterUnderscore
            // 
            this.checkBoxCapitalizeLetterAfterUnderscore.AutoSize = true;
            this.checkBoxCapitalizeLetterAfterUnderscore.Location = new System.Drawing.Point(6, 19);
            this.checkBoxCapitalizeLetterAfterUnderscore.Name = "checkBoxCapitalizeLetterAfterUnderscore";
            this.checkBoxCapitalizeLetterAfterUnderscore.Size = new System.Drawing.Size(177, 17);
            this.checkBoxCapitalizeLetterAfterUnderscore.TabIndex = 4;
            this.checkBoxCapitalizeLetterAfterUnderscore.Text = "Capitalize letter after underscore";
            this.checkBoxCapitalizeLetterAfterUnderscore.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.radioButtonIgnoreUnderscoreAtStart);
            this.groupBox1.Controls.Add(this.radioButtonInsertUnderscoreAtStart);
            this.groupBox1.Controls.Add(this.radioButtonRemoveUnderscoreAtStart);
            this.groupBox1.Location = new System.Drawing.Point(7, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 44);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Underscore at start";
            // 
            // radioButtonIgnoreUnderscoreAtStart
            // 
            this.radioButtonIgnoreUnderscoreAtStart.AutoSize = true;
            this.radioButtonIgnoreUnderscoreAtStart.Checked = true;
            this.radioButtonIgnoreUnderscoreAtStart.Location = new System.Drawing.Point(134, 19);
            this.radioButtonIgnoreUnderscoreAtStart.Name = "radioButtonIgnoreUnderscoreAtStart";
            this.radioButtonIgnoreUnderscoreAtStart.Size = new System.Drawing.Size(55, 17);
            this.radioButtonIgnoreUnderscoreAtStart.TabIndex = 7;
            this.radioButtonIgnoreUnderscoreAtStart.TabStop = true;
            this.radioButtonIgnoreUnderscoreAtStart.Text = "Ignore";
            this.radioButtonIgnoreUnderscoreAtStart.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsertUnderscoreAtStart
            // 
            this.radioButtonInsertUnderscoreAtStart.AutoSize = true;
            this.radioButtonInsertUnderscoreAtStart.Location = new System.Drawing.Point(77, 19);
            this.radioButtonInsertUnderscoreAtStart.Name = "radioButtonInsertUnderscoreAtStart";
            this.radioButtonInsertUnderscoreAtStart.Size = new System.Drawing.Size(51, 17);
            this.radioButtonInsertUnderscoreAtStart.TabIndex = 6;
            this.radioButtonInsertUnderscoreAtStart.Text = "Insert";
            this.radioButtonInsertUnderscoreAtStart.UseVisualStyleBackColor = true;
            // 
            // radioButtonRemoveUnderscoreAtStart
            // 
            this.radioButtonRemoveUnderscoreAtStart.AutoSize = true;
            this.radioButtonRemoveUnderscoreAtStart.Location = new System.Drawing.Point(6, 19);
            this.radioButtonRemoveUnderscoreAtStart.Name = "radioButtonRemoveUnderscoreAtStart";
            this.radioButtonRemoveUnderscoreAtStart.Size = new System.Drawing.Size(65, 17);
            this.radioButtonRemoveUnderscoreAtStart.TabIndex = 5;
            this.radioButtonRemoveUnderscoreAtStart.Text = "Remove";
            this.radioButtonRemoveUnderscoreAtStart.UseVisualStyleBackColor = true;
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxOptions.Controls.Add(this.radioButtonUnderscoreCase);
            this.groupBoxOptions.Controls.Add(this.radioButtonCamelCase);
            this.groupBoxOptions.Location = new System.Drawing.Point(6, 270);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(266, 45);
            this.groupBoxOptions.TabIndex = 2;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Name convention";
            // 
            // radioButtonUnderscoreCase
            // 
            this.radioButtonUnderscoreCase.AutoSize = true;
            this.radioButtonUnderscoreCase.Location = new System.Drawing.Point(93, 19);
            this.radioButtonUnderscoreCase.Name = "radioButtonUnderscoreCase";
            this.radioButtonUnderscoreCase.Size = new System.Drawing.Size(106, 17);
            this.radioButtonUnderscoreCase.TabIndex = 2;
            this.radioButtonUnderscoreCase.Text = "Underscore case";
            this.radioButtonUnderscoreCase.UseVisualStyleBackColor = true;
            // 
            // radioButtonCamelCase
            // 
            this.radioButtonCamelCase.AutoSize = true;
            this.radioButtonCamelCase.Checked = true;
            this.radioButtonCamelCase.Location = new System.Drawing.Point(7, 19);
            this.radioButtonCamelCase.Name = "radioButtonCamelCase";
            this.radioButtonCamelCase.Size = new System.Drawing.Size(80, 17);
            this.radioButtonCamelCase.TabIndex = 1;
            this.radioButtonCamelCase.TabStop = true;
            this.radioButtonCamelCase.Text = "Camel case";
            this.radioButtonCamelCase.UseVisualStyleBackColor = true;
            // 
            // radioButtonCapitalizeFirstLetter
            // 
            this.radioButtonCapitalizeFirstLetter.AutoSize = true;
            this.radioButtonCapitalizeFirstLetter.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCapitalizeFirstLetter.Name = "radioButtonCapitalizeFirstLetter";
            this.radioButtonCapitalizeFirstLetter.Size = new System.Drawing.Size(70, 17);
            this.radioButtonCapitalizeFirstLetter.TabIndex = 7;
            this.radioButtonCapitalizeFirstLetter.Text = "Capitalize";
            this.radioButtonCapitalizeFirstLetter.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.radioButtonCapitalizeFirstLetterIgnore);
            this.groupBox4.Controls.Add(this.radioButtonLowerFirstLetter);
            this.groupBox4.Controls.Add(this.radioButtonCapitalizeFirstLetter);
            this.groupBox4.Location = new System.Drawing.Point(7, 441);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 43);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "First letter";
            // 
            // radioButtonCapitalizeFirstLetterIgnore
            // 
            this.radioButtonCapitalizeFirstLetterIgnore.AutoSize = true;
            this.radioButtonCapitalizeFirstLetterIgnore.Checked = true;
            this.radioButtonCapitalizeFirstLetterIgnore.Location = new System.Drawing.Point(142, 19);
            this.radioButtonCapitalizeFirstLetterIgnore.Name = "radioButtonCapitalizeFirstLetterIgnore";
            this.radioButtonCapitalizeFirstLetterIgnore.Size = new System.Drawing.Size(55, 17);
            this.radioButtonCapitalizeFirstLetterIgnore.TabIndex = 9;
            this.radioButtonCapitalizeFirstLetterIgnore.TabStop = true;
            this.radioButtonCapitalizeFirstLetterIgnore.Text = "Ignore";
            this.radioButtonCapitalizeFirstLetterIgnore.UseVisualStyleBackColor = true;
            // 
            // radioButtonLowerFirstLetter
            // 
            this.radioButtonLowerFirstLetter.AutoSize = true;
            this.radioButtonLowerFirstLetter.Location = new System.Drawing.Point(82, 19);
            this.radioButtonLowerFirstLetter.Name = "radioButtonLowerFirstLetter";
            this.radioButtonLowerFirstLetter.Size = new System.Drawing.Size(54, 17);
            this.radioButtonLowerFirstLetter.TabIndex = 8;
            this.radioButtonLowerFirstLetter.Text = "Lower";
            this.radioButtonLowerFirstLetter.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 496);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControlText);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.checkBoxInstantApply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonApplyConvention);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(584, 376);
            this.Name = "FormMain";
            this.Text = "ConvAdapt";
            this.tabControlText.ResumeLayout(false);
            this.tabPageTextBox.ResumeLayout(false);
            this.splitContainerTextBoxes.Panel1.ResumeLayout(false);
            this.splitContainerTextBoxes.Panel1.PerformLayout();
            this.splitContainerTextBoxes.Panel2.ResumeLayout(false);
            this.splitContainerTextBoxes.Panel2.PerformLayout();
            this.splitContainerTextBoxes.ResumeLayout(false);
            this.tabPageFiles.ResumeLayout(false);
            this.tabPageFiles.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlText;
        private System.Windows.Forms.TabPage tabPageTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxCapitalizeLetterAfterUnderscore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonInsertUnderscoreAtStart;
        private System.Windows.Forms.RadioButton radioButtonRemoveUnderscoreAtStart;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.RadioButton radioButtonUnderscoreCase;
        private System.Windows.Forms.RadioButton radioButtonCamelCase;
        private System.Windows.Forms.SplitContainer splitContainerTextBoxes;
        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.TextBox textBoxReplaced;
        private System.Windows.Forms.TabPage tabPageFiles;
        private System.Windows.Forms.RadioButton radioButtonIgnoreUnderscoreAtStart;
        private System.Windows.Forms.CheckBox checkBoxInstantApply;
        private System.Windows.Forms.Button buttonApplyConvention;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchPattern;
        private System.Windows.Forms.CheckBox checkBoxUseSearchFilter;
        private System.Windows.Forms.CheckBox checkBoxLowerText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonCapitalizeFirstLetterIgnore;
        private System.Windows.Forms.RadioButton radioButtonLowerFirstLetter;
        private System.Windows.Forms.RadioButton radioButtonCapitalizeFirstLetter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonChangeSavePath;
        private System.Windows.Forms.RadioButton radioButtonSaveAtOtherLocation;
        private System.Windows.Forms.RadioButton radioButtonReplaceFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxOpenPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonChangeOpenPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxFiles;

    }
}

