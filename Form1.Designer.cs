namespace MovieMania
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.lblReleaseYr = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtbxProducer = new System.Windows.Forms.TextBox();
            this.lblProducer = new System.Windows.Forms.Label();
            this.txtbxWriter = new System.Windows.Forms.TextBox();
            this.lblWriter = new System.Windows.Forms.Label();
            this.txtbxDirector = new System.Windows.Forms.TextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.dgvMovieList = new System.Windows.Forms.DataGridView();
            this.cmbxGenre = new System.Windows.Forms.ComboBox();
            this.cmbxRating = new System.Windows.Forms.ComboBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtbxReleaseYr = new System.Windows.Forms.TextBox();
            this.txtbxTitle = new System.Windows.Forms.TextBox();
            this.txtbxMovieID = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(58, 155);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(84, 20);
            this.lblMovieID.TabIndex = 1;
            this.lblMovieID.Text = "Movie ID";
            // 
            // lblReleaseYr
            // 
            this.lblReleaseYr.AutoSize = true;
            this.lblReleaseYr.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseYr.Location = new System.Drawing.Point(58, 248);
            this.lblReleaseYr.Name = "lblReleaseYr";
            this.lblReleaseYr.Size = new System.Drawing.Size(107, 20);
            this.lblReleaseYr.TabIndex = 5;
            this.lblReleaseYr.Text = "Release Year";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(58, 201);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(44, 20);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(58, 296);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(55, 20);
            this.lblGenre.TabIndex = 7;
            this.lblGenre.Text = "Genre";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(557, 296);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(60, 20);
            this.lblRating.TabIndex = 15;
            this.lblRating.Text = "Rating";
            // 
            // txtbxProducer
            // 
            this.txtbxProducer.BackColor = System.Drawing.Color.LightGray;
            this.txtbxProducer.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxProducer.Location = new System.Drawing.Point(664, 192);
            this.txtbxProducer.Name = "txtbxProducer";
            this.txtbxProducer.Size = new System.Drawing.Size(306, 29);
            this.txtbxProducer.TabIndex = 12;
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducer.Location = new System.Drawing.Point(557, 201);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(78, 20);
            this.lblProducer.TabIndex = 11;
            this.lblProducer.Text = "Producer";
            // 
            // txtbxWriter
            // 
            this.txtbxWriter.BackColor = System.Drawing.Color.LightGray;
            this.txtbxWriter.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxWriter.Location = new System.Drawing.Point(664, 239);
            this.txtbxWriter.Name = "txtbxWriter";
            this.txtbxWriter.Size = new System.Drawing.Size(306, 29);
            this.txtbxWriter.TabIndex = 14;
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriter.Location = new System.Drawing.Point(557, 248);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(57, 20);
            this.lblWriter.TabIndex = 13;
            this.lblWriter.Text = "Writer";
            // 
            // txtbxDirector
            // 
            this.txtbxDirector.BackColor = System.Drawing.Color.LightGray;
            this.txtbxDirector.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDirector.Location = new System.Drawing.Point(664, 146);
            this.txtbxDirector.Name = "txtbxDirector";
            this.txtbxDirector.Size = new System.Drawing.Size(306, 29);
            this.txtbxDirector.TabIndex = 10;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(557, 151);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(71, 20);
            this.lblDirector.TabIndex = 9;
            this.lblDirector.Text = "Director";
            // 
            // dgvMovieList
            // 
            this.dgvMovieList.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvMovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovieList.Location = new System.Drawing.Point(62, 439);
            this.dgvMovieList.Name = "dgvMovieList";
            this.dgvMovieList.Size = new System.Drawing.Size(908, 210);
            this.dgvMovieList.TabIndex = 23;
            this.dgvMovieList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMovieList_RowHeaderMouseClick);
            // 
            // cmbxGenre
            // 
            this.cmbxGenre.BackColor = System.Drawing.Color.LightGray;
            this.cmbxGenre.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxGenre.FormattingEnabled = true;
            this.cmbxGenre.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Biographical",
            "Christian",
            "Comedy",
            "Crime",
            "Drama",
            "Documentary",
            "Fantasy",
            "Historical",
            "Historical Fiction",
            "Horror",
            "Magical Realism",
            "Musical",
            "Mystery",
            "Political",
            "Religious",
            "Romance",
            "Science Fiction",
            "Sports",
            "Thriller",
            "Urban",
            "Western"});
            this.cmbxGenre.Location = new System.Drawing.Point(165, 288);
            this.cmbxGenre.Name = "cmbxGenre";
            this.cmbxGenre.Size = new System.Drawing.Size(306, 28);
            this.cmbxGenre.TabIndex = 8;
            // 
            // cmbxRating
            // 
            this.cmbxRating.BackColor = System.Drawing.Color.LightGray;
            this.cmbxRating.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxRating.FormattingEnabled = true;
            this.cmbxRating.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R",
            "NC-17",
            "N/A"});
            this.cmbxRating.Location = new System.Drawing.Point(664, 288);
            this.cmbxRating.Name = "cmbxRating";
            this.cmbxRating.Size = new System.Drawing.Size(306, 28);
            this.cmbxRating.TabIndex = 16;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.Silver;
            this.btnAddMovie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddMovie.BackgroundImage")));
            this.btnAddMovie.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.ForeColor = System.Drawing.Color.Indigo;
            this.btnAddMovie.Location = new System.Drawing.Point(234, 343);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(110, 30);
            this.btnAddMovie.TabIndex = 17;
            this.btnAddMovie.Text = "Add";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Indigo;
            this.btnUpdate.Location = new System.Drawing.Point(382, 343);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 30);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Indigo;
            this.btnDelete.Location = new System.Drawing.Point(533, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 30);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Indigo;
            this.btnClear.Location = new System.Drawing.Point(687, 343);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 30);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtbxReleaseYr
            // 
            this.txtbxReleaseYr.BackColor = System.Drawing.Color.LightGray;
            this.txtbxReleaseYr.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxReleaseYr.Location = new System.Drawing.Point(165, 239);
            this.txtbxReleaseYr.Name = "txtbxReleaseYr";
            this.txtbxReleaseYr.Size = new System.Drawing.Size(306, 29);
            this.txtbxReleaseYr.TabIndex = 6;
            // 
            // txtbxTitle
            // 
            this.txtbxTitle.BackColor = System.Drawing.Color.LightGray;
            this.txtbxTitle.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTitle.Location = new System.Drawing.Point(165, 192);
            this.txtbxTitle.Name = "txtbxTitle";
            this.txtbxTitle.Size = new System.Drawing.Size(306, 29);
            this.txtbxTitle.TabIndex = 4;
            // 
            // txtbxMovieID
            // 
            this.txtbxMovieID.BackColor = System.Drawing.Color.LightGray;
            this.txtbxMovieID.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMovieID.Location = new System.Drawing.Point(165, 146);
            this.txtbxMovieID.Name = "txtbxMovieID";
            this.txtbxMovieID.ReadOnly = true;
            this.txtbxMovieID.Size = new System.Drawing.Size(306, 29);
            this.txtbxMovieID.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(992, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.BackColor = System.Drawing.Color.LightGray;
            this.txtbxSearch.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSearch.Location = new System.Drawing.Point(413, 390);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(306, 29);
            this.txtbxSearch.TabIndex = 22;
            this.txtbxSearch.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(306, 399);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 20);
            this.lblSearch.TabIndex = 21;
            this.lblSearch.Text = "Search";
            this.lblSearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1028, 661);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtbxMovieID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.cmbxRating);
            this.Controls.Add(this.cmbxGenre);
            this.Controls.Add(this.dgvMovieList);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.txtbxProducer);
            this.Controls.Add(this.lblProducer);
            this.Controls.Add(this.txtbxWriter);
            this.Controls.Add(this.lblWriter);
            this.Controls.Add(this.txtbxDirector);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtbxTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtbxReleaseYr);
            this.Controls.Add(this.lblReleaseYr);
            this.Controls.Add(this.lblMovieID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.Label lblReleaseYr;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtbxProducer;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.TextBox txtbxWriter;
        private System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.TextBox txtbxDirector;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.DataGridView dgvMovieList;
        private System.Windows.Forms.ComboBox cmbxGenre;
        private System.Windows.Forms.ComboBox cmbxRating;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtbxReleaseYr;
        private System.Windows.Forms.TextBox txtbxTitle;
        private System.Windows.Forms.TextBox txtbxMovieID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}

