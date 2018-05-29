namespace cinema_manager
{
    partial class MovieUpdate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.allButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.movieNmText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.movieNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distributor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.release = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.show_stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.movienameText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.showtimeText = new System.Windows.Forms.TextBox();
            this.directorText = new System.Windows.Forms.TextBox();
            this.actorText = new System.Windows.Forms.TextBox();
            this.distributorText = new System.Windows.Forms.TextBox();
            this.release3 = new System.Windows.Forms.ComboBox();
            this.release2 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.release1 = new System.Windows.Forms.TextBox();
            this.ratingbox = new System.Windows.Forms.ComboBox();
            this.genreText = new System.Windows.Forms.TextBox();
            this.countryText = new System.Windows.Forms.TextBox();
            this.posterText = new System.Windows.Forms.TextBox();
            this.showstatBox = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NanumGothicExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "MOVIE UPDATE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 70);
            this.panel1.TabIndex = 59;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("NanumGothicExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(1226, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 80;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(947, 85);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(104, 25);
            this.allButton.TabIndex = 67;
            this.allButton.Text = "모두보기";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(834, 85);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 25);
            this.searchButton.TabIndex = 66;
            this.searchButton.Text = "검색하기";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 65;
            this.label2.Text = "영화명";
            // 
            // movieNmText
            // 
            this.movieNmText.Location = new System.Drawing.Point(78, 85);
            this.movieNmText.Name = "movieNmText";
            this.movieNmText.Size = new System.Drawing.Size(279, 25);
            this.movieNmText.TabIndex = 64;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieNo,
            this.movieNM,
            this.showTime,
            this.director,
            this.actor,
            this.distributor,
            this.release,
            this.rating,
            this.genre,
            this.country,
            this.poster,
            this.show_stat,
            this.intro});
            this.dataGridView1.Location = new System.Drawing.Point(3, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1267, 266);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // movieNo
            // 
            this.movieNo.HeaderText = "영화번호";
            this.movieNo.Name = "movieNo";
            // 
            // movieNM
            // 
            this.movieNM.HeaderText = "영화명";
            this.movieNM.Name = "movieNM";
            this.movieNM.Width = 300;
            // 
            // showTime
            // 
            this.showTime.HeaderText = "상영시간";
            this.showTime.Name = "showTime";
            // 
            // director
            // 
            this.director.HeaderText = "감독명";
            this.director.Name = "director";
            this.director.Width = 250;
            // 
            // actor
            // 
            this.actor.HeaderText = "배우명";
            this.actor.Name = "actor";
            this.actor.Width = 300;
            // 
            // distributor
            // 
            this.distributor.HeaderText = "배급사";
            this.distributor.Name = "distributor";
            // 
            // release
            // 
            this.release.HeaderText = "개봉일";
            this.release.Name = "release";
            // 
            // rating
            // 
            this.rating.HeaderText = "등급";
            this.rating.Name = "rating";
            this.rating.Width = 50;
            // 
            // genre
            // 
            this.genre.HeaderText = "장르";
            this.genre.Name = "genre";
            this.genre.Width = 50;
            // 
            // country
            // 
            this.country.HeaderText = "국가";
            this.country.Name = "country";
            this.country.Width = 50;
            // 
            // poster
            // 
            this.poster.HeaderText = "포스터";
            this.poster.Name = "poster";
            // 
            // show_stat
            // 
            this.show_stat.HeaderText = "상영상태";
            this.show_stat.Name = "show_stat";
            this.show_stat.Width = 30;
            // 
            // intro
            // 
            this.intro.HeaderText = "영화소개";
            this.intro.Name = "intro";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(413, 532);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 15);
            this.label13.TabIndex = 79;
            this.label13.Text = "포스터 경로*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(413, 572);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 78;
            this.label12.Text = "상영상태";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 77;
            this.label11.Text = "국가*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(413, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 76;
            this.label10.Text = "장르";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 75;
            this.label9.Text = "등급*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 612);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 74;
            this.label8.Text = "개봉일*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 73;
            this.label3.Text = "배급사*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 72;
            this.label6.Text = "배우명*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 71;
            this.label5.Text = "감독명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 70;
            this.label4.Text = "상영시간";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 69;
            this.label7.Text = "영화이름";
            // 
            // movienameText
            // 
            this.movienameText.Location = new System.Drawing.Point(116, 407);
            this.movienameText.Name = "movienameText";
            this.movienameText.Size = new System.Drawing.Size(274, 25);
            this.movienameText.TabIndex = 80;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(211, 452);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 15);
            this.label14.TabIndex = 82;
            this.label14.Text = "분";
            // 
            // showtimeText
            // 
            this.showtimeText.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.showtimeText.Location = new System.Drawing.Point(116, 447);
            this.showtimeText.Name = "showtimeText";
            this.showtimeText.Size = new System.Drawing.Size(89, 25);
            this.showtimeText.TabIndex = 81;
            // 
            // directorText
            // 
            this.directorText.Location = new System.Drawing.Point(116, 486);
            this.directorText.Name = "directorText";
            this.directorText.Size = new System.Drawing.Size(274, 25);
            this.directorText.TabIndex = 83;
            // 
            // actorText
            // 
            this.actorText.Location = new System.Drawing.Point(116, 526);
            this.actorText.Name = "actorText";
            this.actorText.Size = new System.Drawing.Size(274, 25);
            this.actorText.TabIndex = 84;
            // 
            // distributorText
            // 
            this.distributorText.Location = new System.Drawing.Point(116, 567);
            this.distributorText.Name = "distributorText";
            this.distributorText.Size = new System.Drawing.Size(274, 25);
            this.distributorText.TabIndex = 85;
            // 
            // release3
            // 
            this.release3.FormattingEnabled = true;
            this.release3.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.release3.Location = new System.Drawing.Point(310, 609);
            this.release3.Name = "release3";
            this.release3.Size = new System.Drawing.Size(59, 23);
            this.release3.TabIndex = 91;
            // 
            // release2
            // 
            this.release2.FormattingEnabled = true;
            this.release2.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.release2.Location = new System.Drawing.Point(217, 609);
            this.release2.Name = "release2";
            this.release2.Size = new System.Drawing.Size(59, 23);
            this.release2.TabIndex = 90;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(375, 613);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 15);
            this.label23.TabIndex = 89;
            this.label23.Text = "일";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(189, 613);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 15);
            this.label21.TabIndex = 88;
            this.label21.Text = "년";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(282, 613);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 15);
            this.label20.TabIndex = 87;
            this.label20.Text = "월";
            // 
            // release1
            // 
            this.release1.Location = new System.Drawing.Point(116, 608);
            this.release1.Name = "release1";
            this.release1.Size = new System.Drawing.Size(67, 25);
            this.release1.TabIndex = 86;
            // 
            // ratingbox
            // 
            this.ratingbox.FormattingEnabled = true;
            this.ratingbox.Items.AddRange(new object[] {
            "전체 관람가",
            "12세 관람가",
            "15세 관람가",
            "청소년 관람불가",
            "제한 상영가",
            "미정"});
            this.ratingbox.Location = new System.Drawing.Point(524, 409);
            this.ratingbox.Name = "ratingbox";
            this.ratingbox.Size = new System.Drawing.Size(144, 23);
            this.ratingbox.TabIndex = 92;
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(524, 447);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(100, 25);
            this.genreText.TabIndex = 93;
            // 
            // countryText
            // 
            this.countryText.Location = new System.Drawing.Point(524, 487);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(100, 25);
            this.countryText.TabIndex = 94;
            // 
            // posterText
            // 
            this.posterText.Location = new System.Drawing.Point(524, 528);
            this.posterText.Name = "posterText";
            this.posterText.Size = new System.Drawing.Size(274, 25);
            this.posterText.TabIndex = 95;
            // 
            // showstatBox
            // 
            this.showstatBox.FormattingEnabled = true;
            this.showstatBox.Items.AddRange(new object[] {
            "N",
            "Y",
            "E"});
            this.showstatBox.Location = new System.Drawing.Point(524, 569);
            this.showstatBox.Name = "showstatBox";
            this.showstatBox.Size = new System.Drawing.Size(59, 23);
            this.showstatBox.TabIndex = 59;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitButton.Font = new System.Drawing.Font("NanumGothicExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitButton.Location = new System.Drawing.Point(1007, 572);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(237, 55);
            this.SubmitButton.TabIndex = 96;
            this.SubmitButton.Text = "UPDATE";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("NanumGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(986, 528);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 17);
            this.error.TabIndex = 97;
            // 
            // MovieUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.error);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.showstatBox);
            this.Controls.Add(this.posterText);
            this.Controls.Add(this.countryText);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.ratingbox);
            this.Controls.Add(this.release3);
            this.Controls.Add(this.release2);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.release1);
            this.Controls.Add(this.distributorText);
            this.Controls.Add(this.actorText);
            this.Controls.Add(this.directorText);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.showtimeText);
            this.Controls.Add(this.movienameText);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.movieNmText);
            this.Controls.Add(this.panel1);
            this.Name = "MovieUpdate";
            this.Size = new System.Drawing.Size(1282, 655);
            this.Load += new System.EventHandler(this.MovieUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox movieNmText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn showTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn director;
        private System.Windows.Forms.DataGridViewTextBoxColumn actor;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributor;
        private System.Windows.Forms.DataGridViewTextBoxColumn release;
        private System.Windows.Forms.DataGridViewTextBoxColumn rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn poster;
        private System.Windows.Forms.DataGridViewTextBoxColumn show_stat;
        private System.Windows.Forms.DataGridViewTextBoxColumn intro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox movienameText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox showtimeText;
        private System.Windows.Forms.TextBox directorText;
        private System.Windows.Forms.TextBox actorText;
        private System.Windows.Forms.TextBox distributorText;
        private System.Windows.Forms.ComboBox release3;
        private System.Windows.Forms.ComboBox release2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox release1;
        private System.Windows.Forms.ComboBox ratingbox;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.TextBox countryText;
        private System.Windows.Forms.TextBox posterText;
        private System.Windows.Forms.ComboBox showstatBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label error;
    }
}
