namespace WinFormsApp4
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            insert = new Button();
            search = new Button();
            delete = new Button();
            update = new Button();
            claer = new Button();
            exit = new Button();
            browse = new Button();
            first = new Button();
            previous = new Button();
            next = new Button();
            last = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 22);
            label1.Name = "label1";
            label1.Size = new Size(195, 41);
            label1.TabIndex = 0;
            label1.Text = "Student Info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 111);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 1;
            label2.Text = "Student Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 151);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "Student Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 191);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Course";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(196, 188);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(224, 27);
            textBox3.TabIndex = 7;
            // 
            // insert
            // 
            insert.BackColor = SystemColors.ControlLightLight;
            insert.ForeColor = SystemColors.ControlText;
            insert.Location = new Point(48, 304);
            insert.Name = "insert";
            insert.Size = new Size(94, 29);
            insert.TabIndex = 8;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = false;
            insert.Click += insert_Click;
            // 
            // search
            // 
            search.BackColor = SystemColors.ControlLightLight;
            search.Location = new Point(148, 304);
            search.Name = "search";
            search.Size = new Size(94, 29);
            search.TabIndex = 9;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // delete
            // 
            delete.BackColor = SystemColors.ControlLightLight;
            delete.Location = new Point(348, 304);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 10;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.BackColor = SystemColors.ControlLightLight;
            update.Location = new Point(248, 304);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 11;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // claer
            // 
            claer.BackColor = SystemColors.ControlLightLight;
            claer.Location = new Point(448, 304);
            claer.Name = "claer";
            claer.Size = new Size(94, 29);
            claer.TabIndex = 12;
            claer.Text = "Clear";
            claer.UseVisualStyleBackColor = false;
            claer.Click += claer_Click;
            // 
            // exit
            // 
            exit.BackColor = SystemColors.ControlLightLight;
            exit.Location = new Point(548, 304);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 13;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // browse
            // 
            browse.BackColor = SystemColors.ControlLightLight;
            browse.Location = new Point(502, 254);
            browse.Name = "browse";
            browse.Size = new Size(94, 29);
            browse.TabIndex = 14;
            browse.Text = "Browse";
            browse.UseVisualStyleBackColor = false;
            browse.Click += browse_Click;
            // 
            // first
            // 
            first.Location = new Point(48, 254);
            first.Name = "first";
            first.Size = new Size(94, 29);
            first.TabIndex = 15;
            first.Text = "|<<";
            first.UseVisualStyleBackColor = true;
            first.Click += first_Click;
            // 
            // previous
            // 
            previous.Location = new Point(148, 254);
            previous.Name = "previous";
            previous.Size = new Size(94, 29);
            previous.TabIndex = 16;
            previous.Text = "<<";
            previous.UseVisualStyleBackColor = true;
            previous.Click += previous_Click;
            // 
            // next
            // 
            next.Location = new Point(248, 254);
            next.Name = "next";
            next.Size = new Size(94, 29);
            next.TabIndex = 17;
            next.Text = ">>";
            next.UseVisualStyleBackColor = true;
            next.Click += next_Click;
            // 
            // last
            // 
            last.Location = new Point(348, 254);
            last.Name = "last";
            last.Size = new Size(94, 29);
            last.TabIndex = 18;
            last.Text = ">>|";
            last.UseVisualStyleBackColor = true;
            last.Click += last_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(479, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 372);
            Controls.Add(pictureBox1);
            Controls.Add(last);
            Controls.Add(next);
            Controls.Add(previous);
            Controls.Add(first);
            Controls.Add(browse);
            Controls.Add(exit);
            Controls.Add(claer);
            Controls.Add(update);
            Controls.Add(delete);
            Controls.Add(search);
            Controls.Add(insert);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button insert;
        private Button search;
        private Button delete;
        private Button update;
        private Button claer;
        private Button exit;
        private Button browse;
        private Button first;
        private Button previous;
        private Button next;
        private Button last;
        private PictureBox pictureBox1;
    }
}
