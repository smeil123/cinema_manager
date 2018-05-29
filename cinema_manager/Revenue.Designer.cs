namespace cinema_manager
{
    partial class Revenue
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartMovieYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartMovieMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartMovieYear)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMovieMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMovieYear
            // 
            chartArea3.Name = "ChartArea1";
            this.chartMovieYear.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartMovieYear.Legends.Add(legend3);
            this.chartMovieYear.Location = new System.Drawing.Point(638, 92);
            this.chartMovieYear.Name = "chartMovieYear";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "관객 수";
            this.chartMovieYear.Series.Add(series3);
            this.chartMovieYear.Size = new System.Drawing.Size(613, 492);
            this.chartMovieYear.TabIndex = 0;
            this.chartMovieYear.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "이번주 관객 수";
            this.chartMovieYear.Titles.Add(title3);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("NanumGothicExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(1232, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 68;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NanumGothicExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "영화별 관객 통계량";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 70);
            this.panel1.TabIndex = 59;
            // 
            // chartMovieMonth
            // 
            chartArea4.Name = "ChartArea1";
            this.chartMovieMonth.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartMovieMonth.Legends.Add(legend4);
            this.chartMovieMonth.Location = new System.Drawing.Point(9, 92);
            this.chartMovieMonth.Name = "chartMovieMonth";
            this.chartMovieMonth.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "관객 수";
            this.chartMovieMonth.Series.Add(series4);
            this.chartMovieMonth.Size = new System.Drawing.Size(613, 492);
            this.chartMovieMonth.TabIndex = 60;
            this.chartMovieMonth.Text = "chart1";
            title4.Name = "일년간 누적 관객 수";
            title4.Text = "일년간 누적 관객 수";
            this.chartMovieMonth.Titles.Add(title4);
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartMovieMonth);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartMovieYear);
            this.Name = "Revenue";
            this.Size = new System.Drawing.Size(1282, 655);
            this.Load += new System.EventHandler(this.Revenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMovieYear)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMovieMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMovieYear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMovieMonth;
    }
}
