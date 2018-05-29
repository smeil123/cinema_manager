namespace cinema_manager
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
            this.MovieButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RevenueButton = new System.Windows.Forms.Button();
            this.BookingButton = new System.Windows.Forms.Button();
            this.SeatButton = new System.Windows.Forms.Button();
            this.ScreenInsertButton = new System.Windows.Forms.Button();
            this.MovieSearchButton = new System.Windows.Forms.Button();
            this.PhotoButton = new System.Windows.Forms.Button();
            this.MovieInsertButton = new System.Windows.Forms.Button();
            this.CustButton = new System.Windows.Forms.Button();
            this.MemButton = new System.Windows.Forms.Button();
            this.SCHEButton = new System.Windows.Forms.Button();
            this.ScreenButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.movie_control1 = new cinema_manager.MovieInsert();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovieButton
            // 
            this.MovieButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MovieButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MovieButton.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieButton.ForeColor = System.Drawing.Color.Black;
            this.MovieButton.Location = new System.Drawing.Point(3, 3);
            this.MovieButton.Name = "MovieButton";
            this.MovieButton.Size = new System.Drawing.Size(267, 31);
            this.MovieButton.TabIndex = 0;
            this.MovieButton.Text = "영화 관리";
            this.MovieButton.UseVisualStyleBackColor = false;
            this.MovieButton.Click += new System.EventHandler(this.MovieButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.RevenueButton);
            this.panel1.Controls.Add(this.BookingButton);
            this.panel1.Controls.Add(this.SeatButton);
            this.panel1.Controls.Add(this.ScreenInsertButton);
            this.panel1.Controls.Add(this.MovieSearchButton);
            this.panel1.Controls.Add(this.MovieButton);
            this.panel1.Controls.Add(this.PhotoButton);
            this.panel1.Controls.Add(this.MovieInsertButton);
            this.panel1.Controls.Add(this.CustButton);
            this.panel1.Controls.Add(this.MemButton);
            this.panel1.Controls.Add(this.SCHEButton);
            this.panel1.Controls.Add(this.ScreenButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 72);
            this.panel1.TabIndex = 0;
            // 
            // RevenueButton
            // 
            this.RevenueButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.RevenueButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RevenueButton.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RevenueButton.ForeColor = System.Drawing.Color.Black;
            this.RevenueButton.Location = new System.Drawing.Point(1112, 3);
            this.RevenueButton.Name = "RevenueButton";
            this.RevenueButton.Size = new System.Drawing.Size(160, 65);
            this.RevenueButton.TabIndex = 10;
            this.RevenueButton.Text = "매출 관리";
            this.RevenueButton.UseVisualStyleBackColor = false;
            this.RevenueButton.Click += new System.EventHandler(this.RevenueButton_Click);
            // 
            // BookingButton
            // 
            this.BookingButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BookingButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BookingButton.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BookingButton.ForeColor = System.Drawing.Color.Black;
            this.BookingButton.Location = new System.Drawing.Point(624, 3);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(160, 65);
            this.BookingButton.TabIndex = 9;
            this.BookingButton.Text = "예매 관리";
            this.BookingButton.UseVisualStyleBackColor = false;
            // 
            // SeatButton
            // 
            this.SeatButton.BackColor = System.Drawing.Color.Gainsboro;
            this.SeatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SeatButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SeatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeatButton.Font = new System.Drawing.Font("NanumGothicExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SeatButton.ForeColor = System.Drawing.Color.Black;
            this.SeatButton.Location = new System.Drawing.Point(371, 36);
            this.SeatButton.Name = "SeatButton";
            this.SeatButton.Size = new System.Drawing.Size(88, 32);
            this.SeatButton.TabIndex = 8;
            this.SeatButton.Text = "좌석관리";
            this.SeatButton.UseVisualStyleBackColor = false;
            this.SeatButton.Click += new System.EventHandler(this.SeatButton_Click);
            // 
            // ScreenInsertButton
            // 
            this.ScreenInsertButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ScreenInsertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ScreenInsertButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ScreenInsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScreenInsertButton.Font = new System.Drawing.Font("NanumGothicExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScreenInsertButton.ForeColor = System.Drawing.Color.Black;
            this.ScreenInsertButton.Location = new System.Drawing.Point(276, 36);
            this.ScreenInsertButton.Name = "ScreenInsertButton";
            this.ScreenInsertButton.Size = new System.Drawing.Size(95, 32);
            this.ScreenInsertButton.TabIndex = 7;
            this.ScreenInsertButton.Text = "상영관 추가";
            this.ScreenInsertButton.UseVisualStyleBackColor = false;
            this.ScreenInsertButton.Click += new System.EventHandler(this.ScreenInsertButton_Click);
            // 
            // MovieSearchButton
            // 
            this.MovieSearchButton.BackColor = System.Drawing.Color.Gainsboro;
            this.MovieSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MovieSearchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MovieSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MovieSearchButton.Font = new System.Drawing.Font("NanumGothicExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieSearchButton.ForeColor = System.Drawing.Color.Black;
            this.MovieSearchButton.Location = new System.Drawing.Point(182, 36);
            this.MovieSearchButton.Name = "MovieSearchButton";
            this.MovieSearchButton.Size = new System.Drawing.Size(88, 32);
            this.MovieSearchButton.TabIndex = 6;
            this.MovieSearchButton.Text = "영화검색";
            this.MovieSearchButton.UseVisualStyleBackColor = false;
            this.MovieSearchButton.Click += new System.EventHandler(this.MovieSearchButton_Click);
            // 
            // PhotoButton
            // 
            this.PhotoButton.BackColor = System.Drawing.Color.Gainsboro;
            this.PhotoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PhotoButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhotoButton.Font = new System.Drawing.Font("NanumGothicExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PhotoButton.ForeColor = System.Drawing.Color.Black;
            this.PhotoButton.Location = new System.Drawing.Point(93, 36);
            this.PhotoButton.Name = "PhotoButton";
            this.PhotoButton.Size = new System.Drawing.Size(88, 32);
            this.PhotoButton.TabIndex = 5;
            this.PhotoButton.Text = "영화사진";
            this.PhotoButton.UseVisualStyleBackColor = false;
            this.PhotoButton.Click += new System.EventHandler(this.PhotoButton_Click);
            // 
            // MovieInsertButton
            // 
            this.MovieInsertButton.BackColor = System.Drawing.Color.Gainsboro;
            this.MovieInsertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MovieInsertButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MovieInsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MovieInsertButton.Font = new System.Drawing.Font("NanumGothicExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieInsertButton.ForeColor = System.Drawing.Color.Black;
            this.MovieInsertButton.Location = new System.Drawing.Point(3, 36);
            this.MovieInsertButton.Name = "MovieInsertButton";
            this.MovieInsertButton.Size = new System.Drawing.Size(88, 32);
            this.MovieInsertButton.TabIndex = 1;
            this.MovieInsertButton.Text = "영화추가";
            this.MovieInsertButton.UseVisualStyleBackColor = false;
            this.MovieInsertButton.Click += new System.EventHandler(this.MovieInsertButton_Click);
            // 
            // CustButton
            // 
            this.CustButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CustButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CustButton.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CustButton.ForeColor = System.Drawing.Color.Black;
            this.CustButton.Location = new System.Drawing.Point(949, 3);
            this.CustButton.Name = "CustButton";
            this.CustButton.Size = new System.Drawing.Size(160, 65);
            this.CustButton.TabIndex = 4;
            this.CustButton.Text = "비회원 관리";
            this.CustButton.UseVisualStyleBackColor = false;
            // 
            // MemButton
            // 
            this.MemButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MemButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MemButton.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemButton.ForeColor = System.Drawing.Color.Black;
            this.MemButton.Location = new System.Drawing.Point(787, 3);
            this.MemButton.Name = "MemButton";
            this.MemButton.Size = new System.Drawing.Size(160, 65);
            this.MemButton.TabIndex = 3;
            this.MemButton.Text = "회원 관리";
            this.MemButton.UseVisualStyleBackColor = false;
            // 
            // SCHEButton
            // 
            this.SCHEButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SCHEButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SCHEButton.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SCHEButton.ForeColor = System.Drawing.Color.Black;
            this.SCHEButton.Location = new System.Drawing.Point(462, 3);
            this.SCHEButton.Name = "SCHEButton";
            this.SCHEButton.Size = new System.Drawing.Size(160, 65);
            this.SCHEButton.TabIndex = 2;
            this.SCHEButton.Text = "상영일정 관리";
            this.SCHEButton.UseVisualStyleBackColor = false;
            // 
            // ScreenButton
            // 
            this.ScreenButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ScreenButton.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScreenButton.ForeColor = System.Drawing.Color.Black;
            this.ScreenButton.Location = new System.Drawing.Point(276, 3);
            this.ScreenButton.Name = "ScreenButton";
            this.ScreenButton.Size = new System.Drawing.Size(182, 31);
            this.ScreenButton.TabIndex = 1;
            this.ScreenButton.Text = "상영관 관리";
            this.ScreenButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 661);
            this.panel2.TabIndex = 1;
            // 
            // movie_control1
            // 
            this.movie_control1.Location = new System.Drawing.Point(0, 0);
            this.movie_control1.Name = "movie_control1";
            this.movie_control1.Size = new System.Drawing.Size(980, 550);
            this.movie_control1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1282, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "영화 관리자 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MovieButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CustButton;
        private System.Windows.Forms.Button MemButton;
        private System.Windows.Forms.Button SCHEButton;
        private System.Windows.Forms.Button ScreenButton;
        private MovieInsert movie_control1;
        private System.Windows.Forms.Button MovieSearchButton;
        private System.Windows.Forms.Button PhotoButton;
        private System.Windows.Forms.Button MovieInsertButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SeatButton;
        private System.Windows.Forms.Button ScreenInsertButton;
        private System.Windows.Forms.Button RevenueButton;
        private System.Windows.Forms.Button BookingButton;
    }
}

