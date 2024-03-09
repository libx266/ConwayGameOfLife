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
            pictureBox1.Location = new Point(12, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1024, 720);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // argsTextBox
            // 
            argsTextBox.BackColor = SystemColors.InactiveCaptionText;
            argsTextBox.ForeColor = SystemColors.ControlLight;
            argsTextBox.Location = new Point(12, 13);
            argsTextBox.Name = "argsTextBox";
            argsTextBox.Size = new Size(628, 23);
            argsTextBox.TabIndex = 1;
            argsTextBox.Text = "render_fps=25 compute_fps=200 first_gen_alive=25% spawn=3-3 live=2-3 scope=3x3 seed=0";
            // 
            // buttonStart
            // 
            buttonStart.BackColor = SystemColors.ActiveCaptionText;
            buttonStart.ForeColor = SystemColors.ControlLight;
            buttonStart.Location = new Point(799, 11);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 25);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStartClick;
            // 
            // buttonPause
            // 
            buttonPause.BackColor = SystemColors.ActiveCaptionText;
            buttonPause.ForeColor = SystemColors.ControlLight;
            buttonPause.Location = new Point(880, 11);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(75, 25);
            buttonPause.TabIndex = 3;
            buttonPause.Text = "pause";
            buttonPause.UseVisualStyleBackColor = false;
            buttonPause.Click += buttonPauseClick;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = SystemColors.ActiveCaptionText;
            buttonStop.ForeColor = SystemColors.ControlLight;
            buttonStop.Location = new Point(961, 11);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(75, 25);
            buttonStop.TabIndex = 4;
            buttonStop.Text = "stop";
            buttonStop.UseVisualStyleBackColor = false;
            buttonStop.Click += buttonStopClick;
            // 
            // label
            // 
            label.BackColor = SystemColors.InactiveCaptionText;
            label.ForeColor = SystemColors.ControlLight;
            label.Location = new Point(646, 13);
            label.Name = "label";
            label.ReadOnly = true;
            label.Size = new Size(147, 23);
            label.TabIndex = 5;
            label.Text = "seed: ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1041, 769);
            Controls.Add(label);
            Controls.Add(buttonStop);
            Controls.Add(buttonPause);
            Controls.Add(buttonStart);
            Controls.Add(argsTextBox);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainForm";
            Text = "ConwayGameOfLife";
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