namespace ffmpegGUI
{


    partial class FFmpegGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFmpegGUI));
            this.boxQualitySlider = new System.Windows.Forms.TrackBar();
            this.boxQualityNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusOutput = new System.Windows.Forms.StatusStrip();
            this.StatusOutputLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelQuality = new System.Windows.Forms.Label();
            this.boxOutputformat = new System.Windows.Forms.ComboBox();
            this.labelOutputFormat = new System.Windows.Forms.Label();
            this.boxOutputAudiobitrate = new System.Windows.Forms.ComboBox();
            this.labelOutputAudiobitrate = new System.Windows.Forms.Label();
            this.boxOutputFilename = new System.Windows.Forms.TextBox();
            this.labelOutputFilename = new System.Windows.Forms.Label();
            this.boxOutputResolution = new System.Windows.Forms.ComboBox();
            this.labelOutputResolution = new System.Windows.Forms.Label();
            this.labelPreset = new System.Windows.Forms.Label();
            this.boxSpeed = new System.Windows.Forms.ComboBox();
            this.boxFilter = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelFilter = new System.Windows.Forms.Label();
            this.openInputFile = new System.Windows.Forms.OpenFileDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.boxInputFilepath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boxQualitySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxQualityNumeric)).BeginInit();
            this.statusOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxQualitySlider
            // 
            this.boxQualitySlider.Location = new System.Drawing.Point(636, 89);
            this.boxQualitySlider.Maximum = 32;
            this.boxQualitySlider.Minimum = 19;
            this.boxQualitySlider.Name = "boxQualitySlider";
            this.boxQualitySlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.boxQualitySlider.Size = new System.Drawing.Size(56, 209);
            this.boxQualitySlider.TabIndex = 10;
            this.boxQualitySlider.TabStop = false;
            this.boxQualitySlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.boxQualitySlider.Value = 19;
            this.boxQualitySlider.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // boxQualityNumeric
            // 
            this.boxQualityNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxQualityNumeric.Location = new System.Drawing.Point(681, 174);
            this.boxQualityNumeric.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.boxQualityNumeric.Minimum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.boxQualityNumeric.Name = "boxQualityNumeric";
            this.boxQualityNumeric.Size = new System.Drawing.Size(55, 22);
            this.boxQualityNumeric.TabIndex = 6;
            this.boxQualityNumeric.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.boxQualityNumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(677, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hi";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(677, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Low";
            // 
            // statusOutput
            // 
            this.statusOutput.AccessibleName = "";
            this.statusOutput.BackColor = System.Drawing.Color.DarkGray;
            this.statusOutput.Font = new System.Drawing.Font("Segoe UI", 7.7F);
            this.statusOutput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusOutputLabel});
            this.statusOutput.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusOutput.Location = new System.Drawing.Point(0, 383);
            this.statusOutput.Name = "statusOutput";
            this.statusOutput.Size = new System.Drawing.Size(764, 22);
            this.statusOutput.SizingGrip = false;
            this.statusOutput.TabIndex = 1;
            this.statusOutput.Text = "statusStrip1";
            // 
            // StatusOutputLabel
            // 
            this.StatusOutputLabel.Font = new System.Drawing.Font("Segoe UI", 7.7F);
            this.StatusOutputLabel.ForeColor = System.Drawing.Color.White;
            this.StatusOutputLabel.Name = "StatusOutputLabel";
            this.StatusOutputLabel.Size = new System.Drawing.Size(44, 17);
            this.StatusOutputLabel.Text = "Ready";
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuality.Location = new System.Drawing.Point(627, 69);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(52, 17);
            this.labelQuality.TabIndex = 14;
            this.labelQuality.Text = "Quality";
            // 
            // boxOutputformat
            // 
            this.boxOutputformat.FormattingEnabled = true;
            this.boxOutputformat.Items.AddRange(new object[] {
            ""});
            this.boxOutputformat.Location = new System.Drawing.Point(14, 274);
            this.boxOutputformat.Name = "boxOutputformat";
            this.boxOutputformat.Size = new System.Drawing.Size(289, 24);
            this.boxOutputformat.TabIndex = 4;
            // 
            // labelOutputFormat
            // 
            this.labelOutputFormat.AutoSize = true;
            this.labelOutputFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutputFormat.Location = new System.Drawing.Point(10, 249);
            this.labelOutputFormat.Name = "labelOutputFormat";
            this.labelOutputFormat.Size = new System.Drawing.Size(99, 17);
            this.labelOutputFormat.TabIndex = 16;
            this.labelOutputFormat.Text = "Output Format";
            // 
            // boxOutputAudiobitrate
            // 
            this.boxOutputAudiobitrate.FormattingEnabled = true;
            this.boxOutputAudiobitrate.Location = new System.Drawing.Point(13, 209);
            this.boxOutputAudiobitrate.Name = "boxOutputAudiobitrate";
            this.boxOutputAudiobitrate.Size = new System.Drawing.Size(290, 24);
            this.boxOutputAudiobitrate.TabIndex = 3;
            // 
            // labelOutputAudiobitrate
            // 
            this.labelOutputAudiobitrate.AutoSize = true;
            this.labelOutputAudiobitrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutputAudiobitrate.Location = new System.Drawing.Point(14, 186);
            this.labelOutputAudiobitrate.Name = "labelOutputAudiobitrate";
            this.labelOutputAudiobitrate.Size = new System.Drawing.Size(131, 17);
            this.labelOutputAudiobitrate.TabIndex = 18;
            this.labelOutputAudiobitrate.Text = "Output Audiobitrate";
            // 
            // boxOutputFilename
            // 
            this.boxOutputFilename.Location = new System.Drawing.Point(14, 332);
            this.boxOutputFilename.Name = "boxOutputFilename";
            this.boxOutputFilename.Size = new System.Drawing.Size(574, 22);
            this.boxOutputFilename.TabIndex = 5;
            // 
            // labelOutputFilename
            // 
            this.labelOutputFilename.AutoSize = true;
            this.labelOutputFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutputFilename.Location = new System.Drawing.Point(11, 311);
            this.labelOutputFilename.Name = "labelOutputFilename";
            this.labelOutputFilename.Size = new System.Drawing.Size(112, 17);
            this.labelOutputFilename.TabIndex = 20;
            this.labelOutputFilename.Text = "Output Filename";
            // 
            // boxOutputResolution
            // 
            this.boxOutputResolution.FormattingEnabled = true;
            this.boxOutputResolution.Location = new System.Drawing.Point(14, 150);
            this.boxOutputResolution.Name = "boxOutputResolution";
            this.boxOutputResolution.Size = new System.Drawing.Size(289, 24);
            this.boxOutputResolution.TabIndex = 2;
            // 
            // labelOutputResolution
            // 
            this.labelOutputResolution.AutoSize = true;
            this.labelOutputResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutputResolution.Location = new System.Drawing.Point(13, 130);
            this.labelOutputResolution.Name = "labelOutputResolution";
            this.labelOutputResolution.Size = new System.Drawing.Size(122, 17);
            this.labelOutputResolution.TabIndex = 22;
            this.labelOutputResolution.Text = "Output Resolution";
            // 
            // labelPreset
            // 
            this.labelPreset.AutoSize = true;
            this.labelPreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreset.Location = new System.Drawing.Point(627, 310);
            this.labelPreset.Name = "labelPreset";
            this.labelPreset.Size = new System.Drawing.Size(49, 17);
            this.labelPreset.TabIndex = 23;
            this.labelPreset.Text = "Speed";
            // 
            // boxSpeed
            // 
            this.boxSpeed.FormattingEnabled = true;
            this.boxSpeed.Items.AddRange(new object[] {
            "ultrafast",
            "superfast",
            "veryfast",
            "faster",
            "fast",
            "medium",
            "slow",
            "slower",
            "veryslow",
            "placebo"});
            this.boxSpeed.Location = new System.Drawing.Point(629, 330);
            this.boxSpeed.Name = "boxSpeed";
            this.boxSpeed.Size = new System.Drawing.Size(117, 24);
            this.boxSpeed.TabIndex = 7;
            // 
            // boxFilter
            // 
            this.boxFilter.FormattingEnabled = true;
            this.boxFilter.Items.AddRange(new object[] {
            ""});
            this.boxFilter.Location = new System.Drawing.Point(13, 89);
            this.boxFilter.Name = "boxFilter";
            this.boxFilter.Size = new System.Drawing.Size(290, 24);
            this.boxFilter.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(330, 89);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(258, 212);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Convert";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(12, 69);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(86, 17);
            this.labelFilter.TabIndex = 27;
            this.labelFilter.Text = "Output Filter";
            // 
            // openInputFile
            // 
            this.openInputFile.FileName = "openFileDialog";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(704, 28);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(41, 26);
            this.buttonBrowse.TabIndex = 28;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // boxInputFilepath
            // 
            this.boxInputFilepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxInputFilepath.Location = new System.Drawing.Point(13, 31);
            this.boxInputFilepath.Name = "boxInputFilepath";
            this.boxInputFilepath.Size = new System.Drawing.Size(686, 22);
            this.boxInputFilepath.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Input File";
            // 
            // FFmpegGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 405);
            this.Controls.Add(this.boxQualityNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxInputFilepath);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.boxFilter);
            this.Controls.Add(this.boxSpeed);
            this.Controls.Add(this.labelPreset);
            this.Controls.Add(this.labelOutputResolution);
            this.Controls.Add(this.boxOutputResolution);
            this.Controls.Add(this.labelOutputFilename);
            this.Controls.Add(this.boxOutputFilename);
            this.Controls.Add(this.labelOutputAudiobitrate);
            this.Controls.Add(this.boxOutputAudiobitrate);
            this.Controls.Add(this.labelOutputFormat);
            this.Controls.Add(this.boxOutputformat);
            this.Controls.Add(this.labelQuality);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxQualitySlider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FFmpegGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple FFmpeg GUI v. 0.2 by Tommy Andersen";
            ((System.ComponentModel.ISupportInitialize)(this.boxQualitySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxQualityNumeric)).EndInit();
            this.statusOutput.ResumeLayout(false);
            this.statusOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TrackBar boxQualitySlider;
        private System.Windows.Forms.NumericUpDown boxQualityNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusOutput;
        private System.Windows.Forms.ToolStripStatusLabel StatusOutputLabel;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.ComboBox boxOutputformat;
        private System.Windows.Forms.Label labelOutputFormat;
        private System.Windows.Forms.ComboBox boxOutputAudiobitrate;
        private System.Windows.Forms.Label labelOutputAudiobitrate;
        private System.Windows.Forms.TextBox boxOutputFilename;
        private System.Windows.Forms.Label labelOutputFilename;
        private System.Windows.Forms.ComboBox boxOutputResolution;
        private System.Windows.Forms.Label labelOutputResolution;
        private System.Windows.Forms.Label labelPreset;
        private System.Windows.Forms.ComboBox boxSpeed;
        private System.Windows.Forms.ComboBox boxFilter;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.OpenFileDialog openInputFile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox boxInputFilepath;
        private System.Windows.Forms.Label label3;

    }
}

