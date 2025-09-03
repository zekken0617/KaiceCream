namespace Activity3
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pricetb = new TextBox();
            discounttb = new TextBox();
            label5 = new Label();
            DisplayPictureBox = new PictureBox();
            label6 = new Label();
            minion = new GroupBox();
            m3 = new CheckBox();
            m2 = new CheckBox();
            m1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            minionrbt = new RadioButton();
            berryrbt = new RadioButton();
            berry = new GroupBox();
            b4 = new CheckBox();
            b3 = new CheckBox();
            b2 = new CheckBox();
            b1 = new CheckBox();
            girlrbt = new RadioButton();
            girl = new GroupBox();
            g3 = new CheckBox();
            g2 = new CheckBox();
            g1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            minion.SuspendLayout();
            berry.SuspendLayout();
            girl.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 28);
            label1.Name = "label1";
            label1.Size = new Size(268, 24);
            label1.TabIndex = 0;
            label1.Text = "ZEKKE Food Ordering Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 86);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 1;
            label2.Text = "Food order choices:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 188);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(77, 15);
            label3.TabIndex = 4;
            label3.Text = "Order Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 220);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 5;
            label4.Text = "Price:";
            // 
            // pricetb
            // 
            pricetb.Location = new Point(120, 217);
            pricetb.Name = "pricetb";
            pricetb.Size = new Size(161, 23);
            pricetb.TabIndex = 6;
            // 
            // discounttb
            // 
            discounttb.Location = new Point(120, 246);
            discounttb.Name = "discounttb";
            discounttb.Size = new Size(161, 23);
            discounttb.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(60, 249);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 7;
            label5.Text = "Discount:";
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Image = Properties.Resources.white;
            DisplayPictureBox.Location = new Point(120, 285);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(161, 163);
            DisplayPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            DisplayPictureBox.TabIndex = 9;
            DisplayPictureBox.TabStop = false;
            DisplayPictureBox.Click += DisplayPictureBox_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(60, 347);
            label6.Name = "label6";
            label6.Size = new Size(38, 30);
            label6.TabIndex = 10;
            label6.Text = "Order \r\nImage:";
            // 
            // minion
            // 
            minion.BackgroundImageLayout = ImageLayout.None;
            minion.Controls.Add(m3);
            minion.Controls.Add(m2);
            minion.Controls.Add(m1);
            minion.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minion.Location = new Point(375, 86);
            minion.Name = "minion";
            minion.RightToLeft = RightToLeft.No;
            minion.Size = new Size(200, 117);
            minion.TabIndex = 11;
            minion.TabStop = false;
            minion.Text = "MINION SEASONAL";
            // 
            // m3
            // 
            m3.AutoSize = true;
            m3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            m3.Location = new Point(20, 82);
            m3.Name = "m3";
            m3.Size = new Size(96, 19);
            m3.TabIndex = 2;
            m3.Text = "Birthday Cake";
            m3.UseVisualStyleBackColor = true;
            // 
            // m2
            // 
            m2.AutoSize = true;
            m2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            m2.Location = new Point(20, 57);
            m2.Name = "m2";
            m2.Size = new Size(124, 19);
            m2.TabIndex = 1;
            m2.Text = "Nutella and Bananas";
            m2.UseVisualStyleBackColor = true;
            // 
            // m1
            // 
            m1.AutoSize = true;
            m1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            m1.Location = new Point(20, 31);
            m1.Name = "m1";
            m1.Size = new Size(124, 19);
            m1.TabIndex = 0;
            m1.Text = "Reese's and Bananas";
            m1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(49, 466);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 12;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(165, 466);
            button2.Name = "button2";
            button2.Size = new Size(116, 40);
            button2.TabIndex = 13;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // minionrbt
            // 
            minionrbt.AutoSize = true;
            minionrbt.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minionrbt.Location = new Point(78, 104);
            minionrbt.Name = "minionrbt";
            minionrbt.Size = new Size(137, 19);
            minionrbt.TabIndex = 14;
            minionrbt.TabStop = true;
            minionrbt.Text = "MINION SEASONAL";
            minionrbt.UseVisualStyleBackColor = true;
            minionrbt.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // berryrbt
            // 
            berryrbt.AutoSize = true;
            berryrbt.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            berryrbt.Location = new Point(78, 129);
            berryrbt.Name = "berryrbt";
            berryrbt.Size = new Size(131, 19);
            berryrbt.TabIndex = 15;
            berryrbt.TabStop = true;
            berryrbt.Text = "I Love U Berry Much";
            berryrbt.UseVisualStyleBackColor = true;
            berryrbt.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // berry
            // 
            berry.BackgroundImageLayout = ImageLayout.None;
            berry.Controls.Add(b4);
            berry.Controls.Add(b3);
            berry.Controls.Add(b2);
            berry.Controls.Add(b1);
            berry.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            berry.Location = new Point(375, 220);
            berry.Name = "berry";
            berry.RightToLeft = RightToLeft.No;
            berry.Size = new Size(200, 137);
            berry.TabIndex = 12;
            berry.TabStop = false;
            berry.Text = "I Love U Berry Much";
            // 
            // b4
            // 
            b4.AutoSize = true;
            b4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b4.Location = new Point(20, 107);
            b4.Name = "b4";
            b4.Size = new Size(94, 19);
            b4.TabIndex = 3;
            b4.Text = "Matcha Berry";
            b4.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            b3.AutoSize = true;
            b3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b3.Location = new Point(20, 82);
            b3.Name = "b3";
            b3.Size = new Size(79, 19);
            b3.TabIndex = 2;
            b3.Text = "Taro Berry";
            b3.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            b2.AutoSize = true;
            b2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b2.Location = new Point(20, 57);
            b2.Name = "b2";
            b2.Size = new Size(96, 19);
            b2.TabIndex = 1;
            b2.Text = "Blended Berry";
            b2.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            b1.AutoSize = true;
            b1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b1.Location = new Point(20, 31);
            b1.Name = "b1";
            b1.RightToLeft = RightToLeft.No;
            b1.Size = new Size(108, 19);
            b1.TabIndex = 0;
            b1.Text = "Raspberry Berry";
            b1.UseVisualStyleBackColor = true;
            // 
            // girlrbt
            // 
            girlrbt.AutoSize = true;
            girlrbt.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            girlrbt.Location = new Point(78, 154);
            girlrbt.Name = "girlrbt";
            girlrbt.Size = new Size(93, 19);
            girlrbt.TabIndex = 16;
            girlrbt.TabStop = true;
            girlrbt.Text = "I'm Just a Girl";
            girlrbt.UseVisualStyleBackColor = true;
            // 
            // girl
            // 
            girl.BackgroundImageLayout = ImageLayout.None;
            girl.Controls.Add(g3);
            girl.Controls.Add(g2);
            girl.Controls.Add(g1);
            girl.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            girl.Location = new Point(375, 375);
            girl.Name = "girl";
            girl.RightToLeft = RightToLeft.No;
            girl.Size = new Size(200, 117);
            girl.TabIndex = 13;
            girl.TabStop = false;
            girl.Text = "I'm Just a Girl";
            girl.Enter += girl_Enter;
            // 
            // g3
            // 
            g3.AutoSize = true;
            g3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            g3.Location = new Point(20, 82);
            g3.Name = "g3";
            g3.Size = new Size(94, 19);
            g3.TabIndex = 2;
            g3.Text = "Matcha Berry";
            g3.UseVisualStyleBackColor = true;
            // 
            // g2
            // 
            g2.AutoSize = true;
            g2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            g2.Location = new Point(20, 57);
            g2.Name = "g2";
            g2.Size = new Size(97, 19);
            g2.TabIndex = 1;
            g2.Text = "Lucky Charms";
            g2.UseVisualStyleBackColor = true;
            // 
            // g1
            // 
            g1.AutoSize = true;
            g1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            g1.Location = new Point(20, 31);
            g1.Name = "g1";
            g1.RightToLeft = RightToLeft.No;
            g1.Size = new Size(138, 19);
            g1.TabIndex = 0;
            g1.Text = "Strawberry Cheesecake";
            g1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 553);
            Controls.Add(girl);
            Controls.Add(girlrbt);
            Controls.Add(berry);
            Controls.Add(berryrbt);
            Controls.Add(minionrbt);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(minion);
            Controls.Add(label6);
            Controls.Add(DisplayPictureBox);
            Controls.Add(discounttb);
            Controls.Add(label5);
            Controls.Add(pricetb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            minion.ResumeLayout(false);
            minion.PerformLayout();
            berry.ResumeLayout(false);
            berry.PerformLayout();
            girl.ResumeLayout(false);
            girl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox pricetb;
        private TextBox discounttb;
        private Label label5;
        private PictureBox DisplayPictureBox;
        private Label label6;
        private GroupBox minion;
        private Button button1;
        private Button button2;
        private RadioButton minionrbt;
        private RadioButton berryrbt;
        private CheckBox m3;
        private CheckBox m2;
        private CheckBox m1;
        private GroupBox berry;
        private CheckBox b3;
        private CheckBox b2;
        private CheckBox b1;
        private RadioButton girlrbt;
        private GroupBox girl;
        private CheckBox g3;
        private CheckBox g2;
        private CheckBox g1;
        private CheckBox b4;
    }
}
