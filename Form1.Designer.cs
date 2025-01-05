namespace TrevorGridThingy
{
    partial class MainWindow
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            nop = new Label();
            speedUpDown = new NumericUpDown();
            label1 = new Label();
            yellowSpeedUpDown = new NumericUpDown();
            whiteButton = new Button();
            orangeButton = new Button();
            purpleButton = new Button();
            blueButton = new Button();
            greenButton = new Button();
            redButton = new Button();
            yellowButton = new Button();
            trackBar1 = new TrackBar();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            copyButton = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)speedUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yellowSpeedUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(967, 534);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Map";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nop);
            groupBox2.Controls.Add(speedUpDown);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(yellowSpeedUpDown);
            groupBox2.Controls.Add(whiteButton);
            groupBox2.Controls.Add(orangeButton);
            groupBox2.Controls.Add(purpleButton);
            groupBox2.Controls.Add(blueButton);
            groupBox2.Controls.Add(greenButton);
            groupBox2.Controls.Add(redButton);
            groupBox2.Controls.Add(yellowButton);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(843, 68);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selected Tile Control";
            // 
            // nop
            // 
            nop.AutoSize = true;
            nop.Location = new Point(700, 11);
            nop.Name = "nop";
            nop.Size = new Size(39, 15);
            nop.TabIndex = 10;
            nop.Text = "Speed";
            // 
            // speedUpDown
            // 
            speedUpDown.Location = new Point(700, 29);
            speedUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            speedUpDown.Name = "speedUpDown";
            speedUpDown.Size = new Size(49, 23);
            speedUpDown.TabIndex = 9;
            speedUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            speedUpDown.ValueChanged += speedUpDown_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(761, 11);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 8;
            label1.Text = "Yellow Speed";
            // 
            // yellowSpeedUpDown
            // 
            yellowSpeedUpDown.Location = new Point(788, 29);
            yellowSpeedUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            yellowSpeedUpDown.Name = "yellowSpeedUpDown";
            yellowSpeedUpDown.Size = new Size(49, 23);
            yellowSpeedUpDown.TabIndex = 7;
            yellowSpeedUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            yellowSpeedUpDown.ValueChanged += yellowSpeedUpDown_ValueChanged;
            // 
            // whiteButton
            // 
            whiteButton.Location = new Point(495, 29);
            whiteButton.Name = "whiteButton";
            whiteButton.Size = new Size(75, 23);
            whiteButton.TabIndex = 6;
            whiteButton.Text = "None";
            whiteButton.UseVisualStyleBackColor = true;
            whiteButton.Click += whiteButton_Click;
            // 
            // orangeButton
            // 
            orangeButton.Location = new Point(414, 29);
            orangeButton.Name = "orangeButton";
            orangeButton.Size = new Size(75, 23);
            orangeButton.TabIndex = 5;
            orangeButton.Text = "Orange";
            orangeButton.UseVisualStyleBackColor = true;
            orangeButton.Click += orangeButton_Click;
            // 
            // purpleButton
            // 
            purpleButton.Location = new Point(333, 29);
            purpleButton.Name = "purpleButton";
            purpleButton.Size = new Size(75, 23);
            purpleButton.TabIndex = 4;
            purpleButton.Text = "Purple";
            purpleButton.UseVisualStyleBackColor = true;
            purpleButton.Click += purpleButton_Click;
            // 
            // blueButton
            // 
            blueButton.Location = new Point(252, 29);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(75, 23);
            blueButton.TabIndex = 3;
            blueButton.Text = "Blue";
            blueButton.UseVisualStyleBackColor = true;
            blueButton.Click += blueButton_Click;
            // 
            // greenButton
            // 
            greenButton.Location = new Point(171, 29);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(75, 23);
            greenButton.TabIndex = 2;
            greenButton.Text = "Green";
            greenButton.UseVisualStyleBackColor = true;
            greenButton.Click += greenButton_Click;
            // 
            // redButton
            // 
            redButton.Location = new Point(90, 29);
            redButton.Name = "redButton";
            redButton.Size = new Size(75, 23);
            redButton.TabIndex = 1;
            redButton.Text = "Red";
            redButton.UseVisualStyleBackColor = true;
            redButton.Click += redButton_Click;
            // 
            // yellowButton
            // 
            yellowButton.Location = new Point(9, 29);
            yellowButton.Name = "yellowButton";
            yellowButton.Size = new Size(75, 23);
            yellowButton.TabIndex = 0;
            yellowButton.Text = "Yellow";
            yellowButton.UseVisualStyleBackColor = true;
            yellowButton.Click += yellowButton_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(985, 15);
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(45, 605);
            trackBar1.TabIndex = 2;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 629);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1017, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // copyButton
            // 
            copyButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            copyButton.Location = new Point(866, 21);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(113, 59);
            copyButton.TabIndex = 4;
            copyButton.Text = "COPY";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 651);
            Controls.Add(copyButton);
            Controls.Add(statusStrip1);
            Controls.Add(trackBar1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainWindow";
            Text = "Trevor Grid Thing";
            Load += MainWindow_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)speedUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)yellowSpeedUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button blueButton;
        private Button greenButton;
        private Button redButton;
        private Button yellowButton;
        private TrackBar trackBar1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button orangeButton;
        private Button purpleButton;
        private Button copyButton;
        private Button whiteButton;
        private Label nop;
        private NumericUpDown speedUpDown;
        private Label label1;
        private NumericUpDown yellowSpeedUpDown;
    }
}
