namespace Music_App
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            txt_albumDescription = new TextBox();
            label5 = new Label();
            txt_ImageURL = new TextBox();
            label1 = new Label();
            txt_albumYear = new TextBox();
            txt_albumArtist = new TextBox();
            txt_albumName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            button4 = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(286, 11);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 0;
            button1.Text = "Load Albums";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(286, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(600, 211);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(697, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(411, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 23);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(892, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txt_albumDescription);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_ImageURL);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_albumYear);
            groupBox1.Controls.Add(txt_albumArtist);
            groupBox1.Controls.Add(txt_albumName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 211);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add album";
            // 
            // button3
            // 
            button3.Location = new Point(9, 162);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_albumDescription
            // 
            txt_albumDescription.Location = new Point(100, 127);
            txt_albumDescription.Name = "txt_albumDescription";
            txt_albumDescription.Size = new Size(162, 23);
            txt_albumDescription.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 131);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 10;
            label5.Text = "Description";
            // 
            // txt_ImageURL
            // 
            txt_ImageURL.Location = new Point(100, 98);
            txt_ImageURL.Name = "txt_ImageURL";
            txt_ImageURL.Size = new Size(162, 23);
            txt_ImageURL.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 6;
            label1.Text = "Album Name";
            // 
            // txt_albumYear
            // 
            txt_albumYear.Location = new Point(100, 69);
            txt_albumYear.Name = "txt_albumYear";
            txt_albumYear.Size = new Size(162, 23);
            txt_albumYear.TabIndex = 6;
            // 
            // txt_albumArtist
            // 
            txt_albumArtist.Location = new Point(100, 40);
            txt_albumArtist.Name = "txt_albumArtist";
            txt_albumArtist.Size = new Size(162, 23);
            txt_albumArtist.TabIndex = 7;
            // 
            // txt_albumName
            // 
            txt_albumName.Location = new Point(100, 11);
            txt_albumName.Name = "txt_albumName";
            txt_albumName.Size = new Size(162, 23);
            txt_albumName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 103);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 9;
            label4.Text = "ImageURL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 47);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 7;
            label2.Text = "Artist";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 75);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 8;
            label3.Text = "Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(286, 274);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 6;
            label6.Text = "Tracks";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(286, 292);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(486, 150);
            dataGridView2.TabIndex = 7;
            dataGridView2.Click += dataGridView2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(286, 448);
            button4.Name = "button4";
            button4.Size = new Size(93, 23);
            button4.TabIndex = 8;
            button4.Text = "Delete Track";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(892, 274);
            webView21.Name = "webView21";
            webView21.Size = new Size(674, 347);
            webView21.TabIndex = 9;
            webView21.ZoomFactor = 1D;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1658, 633);
            Controls.Add(webView21);
            Controls.Add(button4);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += button1_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_albumDescription;
        private TextBox txt_ImageURL;
        private TextBox txt_albumYear;
        private TextBox txt_albumArtist;
        private TextBox txt_albumName;
        private Button button3;
        private Label label6;
        private DataGridView dataGridView2;
        private Button button4;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
