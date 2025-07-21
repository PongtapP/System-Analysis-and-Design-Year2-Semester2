namespace WinFormsApp3
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(195, 26);
            label1.Name = "label1";
            label1.Size = new Size(239, 32);
            label1.TabIndex = 0;
            label1.Text = "กรอกแบบฟอร์มติดต่อเรา";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 70);
            label2.Name = "label2";
            label2.Size = new Size(290, 20);
            label2.TabIndex = 1;
            label2.Text = "กรุณากรอกคำถามหรือแจ้งข้อมูลเพื่อต่ดต่อกลับค่ะ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 128);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "ชื่อ นามสกุล";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 188);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 3;
            label4.Text = "อีเมล";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 248);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "เบอร์โทรศัพท์";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(100, 308);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 5;
            label6.Text = "หัวข้อ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 368);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 6;
            label7.Text = "รายระเอียด/สอบถาม";
            // 
            // button1
            // 
            button1.BackColor = Color.DeepPink;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(246, 473);
            button1.Name = "button1";
            button1.Size = new Size(115, 46);
            button1.TabIndex = 7;
            button1.Text = "Send Now";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(290, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(169, 245);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(290, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(169, 305);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(290, 27);
            textBox4.TabIndex = 11;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(169, 365);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(290, 84);
            listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(621, 554);
            Controls.Add(listBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ListBox listBox1;
    }
}
