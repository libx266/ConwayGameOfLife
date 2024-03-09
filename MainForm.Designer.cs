namespace ConwayGameOfLife
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox1 = new PictureBox();
            argsTextBox = new TextBox();
            buttonStart = new Button();
            buttonPause = new Button();
            buttonStop = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // argsTextBox
            // 
            argsTextBox.BackColor = SystemColors.InactiveCaptionText;
            resources.ApplyResources(argsTextBox, "argsTextBox");
            argsTextBox.ForeColor = SystemColors.ControlLight;
            argsTextBox.Name = "argsTextBox";
            // 
            // buttonStart
            // 
            buttonStart.BackColor = SystemColors.ActiveCaptionText;
            resources.ApplyResources(buttonStart, "buttonStart");
            buttonStart.ForeColor = SystemColors.ControlLight;
            buttonStart.Name = "buttonStart";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStartClick;
            // 
            // buttonPause
            // 
            buttonPause.BackColor = SystemColors.ActiveCaptionText;
            resources.ApplyResources(buttonPause, "buttonPause");
            buttonPause.ForeColor = SystemColors.ControlLight;
            buttonPause.Name = "buttonPause";
            buttonPause.UseVisualStyleBackColor = false;
            buttonPause.Click += buttonPauseClick;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = SystemColors.ActiveCaptionText;
            resources.ApplyResources(buttonStop, "buttonStop");
            buttonStop.ForeColor = SystemColors.ControlLight;
            buttonStop.Name = "buttonStop";
            buttonStop.UseVisualStyleBackColor = false;
            buttonStop.Click += buttonStopClick;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.ForeColor = SystemColors.Control;
            label1.Name = "label1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(label1);
            Controls.Add(buttonStop);
            Controls.Add(buttonPause);
            Controls.Add(buttonStart);
            Controls.Add(argsTextBox);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox argsTextBox;
        private Button buttonStart;
        private Button buttonPause;
        private Button buttonStop;
        private Label label1;
    }
}