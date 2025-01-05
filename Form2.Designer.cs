namespace TrevorGridThingy
{
    partial class Form2
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
            label1 = new Label();
            button1 = new Button();
            widthUpDown = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            heightUpDown = new NumericUpDown();
            ticksabel = new Label();
            tickUpDown = new NumericUpDown();
            speedUpDown = new NumericUpDown();
            label4 = new Label();
            yellowSpeedUpDown = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)widthUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heightUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tickUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)speedUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yellowSpeedUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(180, 50);
            label1.TabIndex = 0;
            label1.Text = "New Map";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(9, 219);
            button1.Name = "button1";
            button1.Size = new Size(221, 64);
            button1.TabIndex = 1;
            button1.Text = "CREATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // widthUpDown
            // 
            widthUpDown.Location = new Point(73, 74);
            widthUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            widthUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            widthUpDown.Name = "widthUpDown";
            widthUpDown.Size = new Size(120, 23);
            widthUpDown.TabIndex = 2;
            widthUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Width";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Height";
            // 
            // heightUpDown
            // 
            heightUpDown.Location = new Point(73, 103);
            heightUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            heightUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            heightUpDown.Name = "heightUpDown";
            heightUpDown.Size = new Size(120, 23);
            heightUpDown.TabIndex = 5;
            heightUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // ticksabel
            // 
            ticksabel.AutoSize = true;
            ticksabel.Location = new Point(12, 134);
            ticksabel.Name = "ticksabel";
            ticksabel.Size = new Size(35, 15);
            ticksabel.TabIndex = 6;
            ticksabel.Text = "Ticks";
            // 
            // tickUpDown
            // 
            tickUpDown.Location = new Point(73, 132);
            tickUpDown.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            tickUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            tickUpDown.Name = "tickUpDown";
            tickUpDown.Size = new Size(120, 23);
            tickUpDown.TabIndex = 7;
            tickUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            tickUpDown.ValueChanged += tickUpDown_ValueChanged;
            // 
            // speedUpDown
            // 
            speedUpDown.Location = new Point(73, 161);
            speedUpDown.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            speedUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            speedUpDown.Name = "speedUpDown";
            speedUpDown.Size = new Size(120, 23);
            speedUpDown.TabIndex = 9;
            speedUpDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 163);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "Speed";
            // 
            // yellowSpeedUpDown
            // 
            yellowSpeedUpDown.Location = new Point(73, 190);
            yellowSpeedUpDown.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            yellowSpeedUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            yellowSpeedUpDown.Name = "yellowSpeedUpDown";
            yellowSpeedUpDown.Size = new Size(120, 23);
            yellowSpeedUpDown.TabIndex = 11;
            yellowSpeedUpDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 192);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 10;
            label5.Text = "YellowS";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 286);
            Controls.Add(yellowSpeedUpDown);
            Controls.Add(label5);
            Controls.Add(speedUpDown);
            Controls.Add(label4);
            Controls.Add(tickUpDown);
            Controls.Add(ticksabel);
            Controls.Add(heightUpDown);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(widthUpDown);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form2";
            Text = "Create new map";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)widthUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)heightUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)tickUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)speedUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)yellowSpeedUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private NumericUpDown widthUpDown;
        private Label label2;
        private Label label3;
        private NumericUpDown heightUpDown;
        private Label ticksabel;
        private NumericUpDown tickUpDown;
        private NumericUpDown speedUpDown;
        private Label label4;
        private NumericUpDown yellowSpeedUpDown;
        private Label label5;
    }
}