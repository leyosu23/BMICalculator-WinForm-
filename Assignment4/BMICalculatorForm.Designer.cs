namespace Assignment4
{
    partial class BMICalculatorForm
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
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ResultMultiLineTextBox = new System.Windows.Forms.TextBox();
            this.CalculateResultButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BMIProgressBar = new System.Windows.Forms.ProgressBar();
            this.ToggleAndSwitchUnitBox = new System.Windows.Forms.GroupBox();
            this.MetricUnitRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialUnitRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricUnitBox = new System.Windows.Forms.GroupBox();
            this.KilogramLabel = new System.Windows.Forms.Label();
            this.MeterLabel = new System.Windows.Forms.Label();
            this.UserInputTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.TouchLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ImperialUnitBox = new System.Windows.Forms.GroupBox();
            this.LbLabel = new System.Windows.Forms.Label();
            this.InchLabel = new System.Windows.Forms.Label();
            this.HealthIndexPicture = new System.Windows.Forms.PictureBox();
            this.ToggleAndSwitchUnitBox.SuspendLayout();
            this.MetricUnitBox.SuspendLayout();
            this.UserInputTableLayoutPanel.SuspendLayout();
            this.TouchLayoutPanel.SuspendLayout();
            this.ImperialUnitBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealthIndexPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WeightLabel.Location = new System.Drawing.Point(7, 53);
            this.WeightLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(98, 54);
            this.WeightLabel.TabIndex = 0;
            this.WeightLabel.Text = "Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HeightLabel.Location = new System.Drawing.Point(7, 0);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(98, 53);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Font = new System.Drawing.Font("Gulim", 20F);
            this.HeightTextBox.Location = new System.Drawing.Point(119, 7);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(7);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(92, 38);
            this.HeightTextBox.TabIndex = 3;
            this.HeightTextBox.TabStop = false;
            this.HeightTextBox.Text = "My Height";
            this.HeightTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.HeightTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeightTextBox_MouseDown);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTextBox.BackColor = System.Drawing.Color.Gold;
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("Gulim", 20F);
            this.ResultTextBox.ForeColor = System.Drawing.Color.Black;
            this.ResultTextBox.Location = new System.Drawing.Point(3, 117);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(7);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(112, 38);
            this.ResultTextBox.TabIndex = 5;
            this.ResultTextBox.Text = "result";
            // 
            // ResultMultiLineTextBox
            // 
            this.ResultMultiLineTextBox.BackColor = System.Drawing.Color.Yellow;
            this.ResultMultiLineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultMultiLineTextBox.Enabled = false;
            this.ResultMultiLineTextBox.Font = new System.Drawing.Font("Gulim", 20F);
            this.ResultMultiLineTextBox.Location = new System.Drawing.Point(119, 117);
            this.ResultMultiLineTextBox.Margin = new System.Windows.Forms.Padding(7);
            this.ResultMultiLineTextBox.Multiline = true;
            this.ResultMultiLineTextBox.Name = "ResultMultiLineTextBox";
            this.ResultMultiLineTextBox.Size = new System.Drawing.Size(180, 88);
            this.ResultMultiLineTextBox.TabIndex = 6;
            this.ResultMultiLineTextBox.Text = "results";
            // 
            // CalculateResultButton
            // 
            this.CalculateResultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateResultButton.BackColor = System.Drawing.Color.Chartreuse;
            this.CalculateResultButton.Font = new System.Drawing.Font("Gulim", 20F);
            this.CalculateResultButton.Location = new System.Drawing.Point(139, 187);
            this.CalculateResultButton.Margin = new System.Windows.Forms.Padding(7);
            this.CalculateResultButton.Name = "CalculateResultButton";
            this.CalculateResultButton.Size = new System.Drawing.Size(153, 33);
            this.CalculateResultButton.TabIndex = 7;
            this.CalculateResultButton.Tag = "calculate";
            this.CalculateResultButton.Text = "Calculate BMI";
            this.CalculateResultButton.UseVisualStyleBackColor = false;
            this.CalculateResultButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ResetButton.Font = new System.Drawing.Font("Gulim", 20F);
            this.ResetButton.Location = new System.Drawing.Point(139, 142);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(7);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(153, 31);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Tag = "clear";
            this.ResetButton.Text = "Clear";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // BMIProgressBar
            // 
            this.BMIProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMIProgressBar.BackColor = System.Drawing.Color.White;
            this.TouchLayoutPanel.SetColumnSpan(this.BMIProgressBar, 3);
            this.BMIProgressBar.ForeColor = System.Drawing.Color.White;
            this.BMIProgressBar.Location = new System.Drawing.Point(7, 7);
            this.BMIProgressBar.Margin = new System.Windows.Forms.Padding(7);
            this.BMIProgressBar.Name = "BMIProgressBar";
            this.BMIProgressBar.Size = new System.Drawing.Size(118, 31);
            this.BMIProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BMIProgressBar.TabIndex = 10;
            // 
            // ToggleAndSwitchUnitBox
            // 
            this.ToggleAndSwitchUnitBox.Controls.Add(this.MetricUnitRadioButton);
            this.ToggleAndSwitchUnitBox.Controls.Add(this.ImperialUnitRadioButton);
            this.ToggleAndSwitchUnitBox.Location = new System.Drawing.Point(139, 7);
            this.ToggleAndSwitchUnitBox.Margin = new System.Windows.Forms.Padding(7);
            this.ToggleAndSwitchUnitBox.Name = "ToggleAndSwitchUnitBox";
            this.ToggleAndSwitchUnitBox.Padding = new System.Windows.Forms.Padding(7);
            this.TouchLayoutPanel.SetRowSpan(this.ToggleAndSwitchUnitBox, 2);
            this.ToggleAndSwitchUnitBox.Size = new System.Drawing.Size(153, 76);
            this.ToggleAndSwitchUnitBox.TabIndex = 12;
            this.ToggleAndSwitchUnitBox.TabStop = false;
            // 
            // MetricUnitRadioButton
            // 
            this.MetricUnitRadioButton.AutoSize = true;
            this.MetricUnitRadioButton.Location = new System.Drawing.Point(14, 42);
            this.MetricUnitRadioButton.Margin = new System.Windows.Forms.Padding(7);
            this.MetricUnitRadioButton.Name = "MetricUnitRadioButton";
            this.MetricUnitRadioButton.Size = new System.Drawing.Size(106, 31);
            this.MetricUnitRadioButton.TabIndex = 1;
            this.MetricUnitRadioButton.Text = "Metric";
            this.MetricUnitRadioButton.UseVisualStyleBackColor = true;
            this.MetricUnitRadioButton.CheckedChanged += new System.EventHandler(this.MetricUnitRadioButton_CheckedChanged);
            // 
            // ImperialUnitRadioButton
            // 
            this.ImperialUnitRadioButton.AutoSize = true;
            this.ImperialUnitRadioButton.Checked = true;
            this.ImperialUnitRadioButton.Location = new System.Drawing.Point(14, 15);
            this.ImperialUnitRadioButton.Margin = new System.Windows.Forms.Padding(7);
            this.ImperialUnitRadioButton.Name = "ImperialUnitRadioButton";
            this.ImperialUnitRadioButton.Size = new System.Drawing.Size(128, 31);
            this.ImperialUnitRadioButton.TabIndex = 0;
            this.ImperialUnitRadioButton.TabStop = true;
            this.ImperialUnitRadioButton.Text = "Imperial";
            this.ImperialUnitRadioButton.UseVisualStyleBackColor = true;
            this.ImperialUnitRadioButton.CheckedChanged += new System.EventHandler(this.ImperialUnitRadioButton_CheckedChanged);
            // 
            // MetricUnitBox
            // 
            this.MetricUnitBox.Controls.Add(this.KilogramLabel);
            this.MetricUnitBox.Controls.Add(this.MeterLabel);
            this.MetricUnitBox.Location = new System.Drawing.Point(220, 0);
            this.MetricUnitBox.Margin = new System.Windows.Forms.Padding(7);
            this.MetricUnitBox.Name = "MetricUnitBox";
            this.MetricUnitBox.Padding = new System.Windows.Forms.Padding(7);
            this.MetricUnitBox.Size = new System.Drawing.Size(79, 107);
            this.MetricUnitBox.TabIndex = 15;
            this.MetricUnitBox.TabStop = false;
            this.MetricUnitBox.Visible = false;
            // 
            // KilogramLabel
            // 
            this.KilogramLabel.AutoSize = true;
            this.KilogramLabel.Location = new System.Drawing.Point(8, 60);
            this.KilogramLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.KilogramLabel.Name = "KilogramLabel";
            this.KilogramLabel.Size = new System.Drawing.Size(42, 27);
            this.KilogramLabel.TabIndex = 1;
            this.KilogramLabel.Text = "kg";
            // 
            // MeterLabel
            // 
            this.MeterLabel.AutoSize = true;
            this.MeterLabel.Location = new System.Drawing.Point(8, 18);
            this.MeterLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.MeterLabel.Name = "MeterLabel";
            this.MeterLabel.Size = new System.Drawing.Size(35, 27);
            this.MeterLabel.TabIndex = 0;
            this.MeterLabel.Text = "m";
            // 
            // UserInputTableLayoutPanel
            // 
            this.UserInputTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputTableLayoutPanel.ColumnCount = 2;
            this.UserInputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.37615F));
            this.UserInputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.62385F));
            this.UserInputTableLayoutPanel.Controls.Add(this.WeightLabel, 0, 1);
            this.UserInputTableLayoutPanel.Controls.Add(this.HeightLabel, 0, 0);
            this.UserInputTableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 1);
            this.UserInputTableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 0);
            this.UserInputTableLayoutPanel.Location = new System.Drawing.Point(0, 5);
            this.UserInputTableLayoutPanel.Name = "UserInputTableLayoutPanel";
            this.UserInputTableLayoutPanel.RowCount = 2;
            this.UserInputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UserInputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UserInputTableLayoutPanel.Size = new System.Drawing.Size(218, 107);
            this.UserInputTableLayoutPanel.TabIndex = 16;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Font = new System.Drawing.Font("Gulim", 20F);
            this.WeightTextBox.Location = new System.Drawing.Point(119, 60);
            this.WeightTextBox.Margin = new System.Windows.Forms.Padding(7);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(92, 38);
            this.WeightTextBox.TabIndex = 2;
            this.WeightTextBox.TabStop = false;
            this.WeightTextBox.Text = "My Weight";
            this.WeightTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.WeightTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WeightTextBox_MouseDown);
            // 
            // TouchLayoutPanel
            // 
            this.TouchLayoutPanel.ColumnCount = 4;
            this.TouchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TouchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TouchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TouchLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.TouchLayoutPanel.Controls.Add(this.DecimalButton, 0, 4);
            this.TouchLayoutPanel.Controls.Add(this.ZeroButton, 0, 4);
            this.TouchLayoutPanel.Controls.Add(this.ResetButton, 3, 3);
            this.TouchLayoutPanel.Controls.Add(this.CalculateResultButton, 3, 4);
            this.TouchLayoutPanel.Controls.Add(this.NineButton, 2, 1);
            this.TouchLayoutPanel.Controls.Add(this.EightButton, 1, 1);
            this.TouchLayoutPanel.Controls.Add(this.SevenButton, 0, 1);
            this.TouchLayoutPanel.Controls.Add(this.FourButton, 0, 2);
            this.TouchLayoutPanel.Controls.Add(this.FiveButton, 1, 2);
            this.TouchLayoutPanel.Controls.Add(this.SixButton, 2, 2);
            this.TouchLayoutPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.TouchLayoutPanel.Controls.Add(this.TwoButton, 1, 3);
            this.TouchLayoutPanel.Controls.Add(this.OneButton, 0, 3);
            this.TouchLayoutPanel.Controls.Add(this.BackButton, 3, 2);
            this.TouchLayoutPanel.Controls.Add(this.ToggleAndSwitchUnitBox, 3, 0);
            this.TouchLayoutPanel.Controls.Add(this.BMIProgressBar, 0, 0);
            this.TouchLayoutPanel.Location = new System.Drawing.Point(0, 210);
            this.TouchLayoutPanel.Name = "TouchLayoutPanel";
            this.TouchLayoutPanel.RowCount = 5;
            this.TouchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TouchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TouchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TouchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TouchLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TouchLayoutPanel.Size = new System.Drawing.Size(299, 227);
            this.TouchLayoutPanel.TabIndex = 17;
            // 
            // DecimalButton
            // 
            this.DecimalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalButton.Location = new System.Drawing.Point(91, 183);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(38, 41);
            this.DecimalButton.TabIndex = 24;
            this.DecimalButton.Tag = "decimal";
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TouchLayoutPanel.SetColumnSpan(this.ZeroButton, 2);
            this.ZeroButton.Location = new System.Drawing.Point(3, 183);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(82, 41);
            this.ZeroButton.TabIndex = 23;
            this.ZeroButton.Tag = "0";
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NineButton
            // 
            this.NineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NineButton.Location = new System.Drawing.Point(91, 48);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(38, 39);
            this.NineButton.TabIndex = 18;
            this.NineButton.Tag = "9";
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightButton.Location = new System.Drawing.Point(47, 48);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(38, 39);
            this.EightButton.TabIndex = 17;
            this.EightButton.Tag = "8";
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenButton.Location = new System.Drawing.Point(3, 48);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(38, 39);
            this.SevenButton.TabIndex = 16;
            this.SevenButton.Tag = "7";
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // FourButton
            // 
            this.FourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourButton.Location = new System.Drawing.Point(3, 93);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(38, 39);
            this.FourButton.TabIndex = 19;
            this.FourButton.Tag = "4";
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // FiveButton
            // 
            this.FiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiveButton.Location = new System.Drawing.Point(47, 93);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(38, 39);
            this.FiveButton.TabIndex = 20;
            this.FiveButton.Tag = "5";
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // SixButton
            // 
            this.SixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixButton.Location = new System.Drawing.Point(91, 93);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(38, 39);
            this.SixButton.TabIndex = 21;
            this.SixButton.Tag = "6";
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreeButton.Location = new System.Drawing.Point(91, 138);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(38, 39);
            this.ThreeButton.TabIndex = 15;
            this.ThreeButton.Tag = "3";
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // TwoButton
            // 
            this.TwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoButton.Location = new System.Drawing.Point(47, 138);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(38, 39);
            this.TwoButton.TabIndex = 14;
            this.TwoButton.Tag = "2";
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // OneButton
            // 
            this.OneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneButton.Location = new System.Drawing.Point(3, 138);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(38, 39);
            this.OneButton.TabIndex = 13;
            this.OneButton.Tag = "1";
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.Color.MediumBlue;
            this.BackButton.BackgroundImage = global::Assignment4.Properties.Resources.back;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.Location = new System.Drawing.Point(135, 93);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(161, 39);
            this.BackButton.TabIndex = 22;
            this.BackButton.Tag = "back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ImperialUnitBox
            // 
            this.ImperialUnitBox.Controls.Add(this.LbLabel);
            this.ImperialUnitBox.Controls.Add(this.InchLabel);
            this.ImperialUnitBox.Location = new System.Drawing.Point(220, 0);
            this.ImperialUnitBox.Margin = new System.Windows.Forms.Padding(7);
            this.ImperialUnitBox.Name = "ImperialUnitBox";
            this.ImperialUnitBox.Padding = new System.Windows.Forms.Padding(7);
            this.ImperialUnitBox.Size = new System.Drawing.Size(79, 107);
            this.ImperialUnitBox.TabIndex = 16;
            this.ImperialUnitBox.TabStop = false;
            // 
            // LbLabel
            // 
            this.LbLabel.AutoSize = true;
            this.LbLabel.Location = new System.Drawing.Point(8, 63);
            this.LbLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LbLabel.Name = "LbLabel";
            this.LbLabel.Size = new System.Drawing.Size(34, 27);
            this.LbLabel.TabIndex = 1;
            this.LbLabel.Text = "lb";
            // 
            // InchLabel
            // 
            this.InchLabel.AutoSize = true;
            this.InchLabel.Location = new System.Drawing.Point(8, 25);
            this.InchLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.InchLabel.Name = "InchLabel";
            this.InchLabel.Size = new System.Drawing.Size(65, 27);
            this.InchLabel.TabIndex = 0;
            this.InchLabel.Text = "inch";
            // 
            // HealthIndexPicture
            // 
            this.HealthIndexPicture.BackgroundImage = global::Assignment4.Properties.Resources.HealthIndexImage1;
            this.HealthIndexPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HealthIndexPicture.Location = new System.Drawing.Point(3, 165);
            this.HealthIndexPicture.Name = "HealthIndexPicture";
            this.HealthIndexPicture.Size = new System.Drawing.Size(112, 39);
            this.HealthIndexPicture.TabIndex = 18;
            this.HealthIndexPicture.TabStop = false;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.HealthIndexPicture);
            this.Controls.Add(this.ImperialUnitBox);
            this.Controls.Add(this.TouchLayoutPanel);
            this.Controls.Add(this.UserInputTableLayoutPanel);
            this.Controls.Add(this.MetricUnitBox);
            this.Controls.Add(this.ResultMultiLineTextBox);
            this.Controls.Add(this.ResultTextBox);
            this.Font = new System.Drawing.Font("Gulim", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculatorForm_FormClosing);
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.ToggleAndSwitchUnitBox.ResumeLayout(false);
            this.ToggleAndSwitchUnitBox.PerformLayout();
            this.MetricUnitBox.ResumeLayout(false);
            this.MetricUnitBox.PerformLayout();
            this.UserInputTableLayoutPanel.ResumeLayout(false);
            this.UserInputTableLayoutPanel.PerformLayout();
            this.TouchLayoutPanel.ResumeLayout(false);
            this.ImperialUnitBox.ResumeLayout(false);
            this.ImperialUnitBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealthIndexPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox ResultMultiLineTextBox;
        private System.Windows.Forms.Button CalculateResultButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ProgressBar BMIProgressBar;
        private System.Windows.Forms.GroupBox ToggleAndSwitchUnitBox;
        private System.Windows.Forms.RadioButton MetricUnitRadioButton;
        private System.Windows.Forms.RadioButton ImperialUnitRadioButton;
        private System.Windows.Forms.GroupBox MetricUnitBox;
        private System.Windows.Forms.Label KilogramLabel;
        private System.Windows.Forms.Label MeterLabel;
        private System.Windows.Forms.TableLayoutPanel UserInputTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel TouchLayoutPanel;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.GroupBox ImperialUnitBox;
        private System.Windows.Forms.Label LbLabel;
        private System.Windows.Forms.Label InchLabel;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.PictureBox HealthIndexPicture;
    }
}

