namespace ariuka
{
    partial class movieForm
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
            dgvMovie = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            txtTitle = new TextBox();
            txtYear = new TextBox();
            txtDirector = new TextBox();
            btnUptade = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            picMovie = new PictureBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            button1 = new Button();
            txtUrll = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // dgvMovie
            // 
            dgvMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovie.Location = new Point(12, 12);
            dgvMovie.Name = "dgvMovie";
            dgvMovie.ReadOnly = true;
            dgvMovie.Size = new Size(1003, 150);
            dgvMovie.TabIndex = 0;
            dgvMovie.CellClick += dgvMovie_CellContentClick;
            dgvMovie.CellContentClick += dgvMovie_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 190);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "ID ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 190);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Movie Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 190);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 3;
            label3.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(447, 190);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 4;
            label4.Text = "Director";
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 208);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(145, 208);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(180, 23);
            txtTitle.TabIndex = 6;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(352, 208);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(59, 23);
            txtYear.TabIndex = 7;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(447, 208);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(138, 23);
            txtDirector.TabIndex = 8;
            txtDirector.TextChanged += txtDirector_TextChanged;
            // 
            // btnUptade
            // 
            btnUptade.Location = new Point(608, 194);
            btnUptade.Name = "btnUptade";
            btnUptade.Size = new Size(71, 49);
            btnUptade.TabIndex = 9;
            btnUptade.Text = "UPDATE";
            btnUptade.UseVisualStyleBackColor = true;
            btnUptade.Click += btnUptade_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(685, 194);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 49);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(766, 194);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(71, 50);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // picMovie
            // 
            picMovie.Location = new Point(12, 273);
            picMovie.Name = "picMovie";
            picMovie.Size = new Size(282, 350);
            picMovie.TabIndex = 12;
            picMovie.TabStop = false;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(324, 273);
            webView21.Name = "webView21";
            webView21.Size = new Size(513, 350);
            webView21.TabIndex = 13;
            webView21.ZoomFactor = 1D;
            // 
            // button1
            // 
            button1.Location = new Point(843, 581);
            button1.Name = "button1";
            button1.Size = new Size(75, 42);
            button1.TabIndex = 14;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtUrll
            // 
            txtUrll.Location = new Point(56, 244);
            txtUrll.Name = "txtUrll";
            txtUrll.Size = new Size(100, 23);
            txtUrll.TabIndex = 15;
            txtUrll.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 244);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 16;
            label5.Text = "urll";
            label5.Visible = false;
            // 
            // movieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 635);
            Controls.Add(label5);
            Controls.Add(txtUrll);
            Controls.Add(button1);
            Controls.Add(webView21);
            Controls.Add(picMovie);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUptade);
            Controls.Add(txtDirector);
            Controls.Add(txtYear);
            Controls.Add(txtTitle);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMovie);
            Name = "movieForm";
            Text = "MOVIE FORM";
            Load += movieForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovie).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMovie).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMovie;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtTitle;
        private TextBox txtYear;
        private TextBox txtDirector;
        private Button btnUptade;
        private Button btnDelete;
        private Button btnAdd;
        private PictureBox pictureBox1;
        private PictureBox picMovie;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button button1;
        private TextBox txtUrll;
        private Label label5;
    }
}