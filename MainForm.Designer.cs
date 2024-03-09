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
            label = new TextBox();
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
            argsTextBox.ForeColor = SystemColors.ControlLight;
            resources.ApplyResources(argsTextBox, "argsTextBox");
            argsTextBox.Name = "argsTextBox";
            // 
            // buttonStart
            // 
            buttonStart.BackColor = SystemColors.ActiveCaptionText;
            buttonStart.ForeColor = SystemColors.ControlLight;
            resources.ApplyResources(buttonStart, "buttonStart");
            buttonStart.Name = "buttonStart";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStartClick;
            // 
            // buttonPause
            // 
            buttonPause.BackColor = SystemColors.ActiveCaptionText;
            buttonPause.ForeColor = SystemColors.ControlLight;
            resources.ApplyResources(buttonPause, "buttonPause");
            buttonPause.Name = "buttonPause";
            buttonPause.UseVisualStyleBackColor = false;
            buttonPause.Click += buttonPauseClick;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = SystemColors.ActiveCaptionText;
            buttonStop.ForeColor = SystemColors.ControlLight;
            resources.ApplyResources(buttonStop, "buttonStop");
            buttonStop.Name = "buttonStop";
            buttonStop.UseVisualStyleBackColor = false;
            buttonStop.Click += buttonStopClick;
            // 
            // label
            // 
            label.BackColor = SystemColors.InactiveCaptionText;
            label.ForeColor = SystemColors.ControlLight;
            resources.ApplyResources(label, "label");
            label.Name = "label";
            label.ReadOnly = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(label);
            Controls.Add(buttonStop);
            Controls.Add(buttonPause);
            Controls.Add(buttonStart);
            Controls.Add(argsTextBox);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainForm";
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
        private TextBox label;
    }
}