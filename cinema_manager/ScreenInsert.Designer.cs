namespace cinema_manager
{
    partial class ScreenInsert
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ScrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrIntro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screenNM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.screenIntro = new System.Windows.Forms.RichTextBox();
            this.seatNO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MoreButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.button2.Location = new System.Drawing.Point(1228, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 71;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NanumGothicExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "SCREEN INSERT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScrNo,
            this.ScrNM,
            this.ScrCnt,
            this.ScrIntro});
            this.dataGridView1.Location = new System.Drawing.Point(3, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 264);
            this.dataGridView1.TabIndex = 60;
            // 
            // ScrNo
            // 
            this.ScrNo.HeaderText = "상영관번호";
            this.ScrNo.Name = "ScrNo";
            // 
            // ScrNM
            // 
            this.ScrNM.HeaderText = "상영관이름";
            this.ScrNM.Name = "ScrNM";
            this.ScrNM.Width = 250;
            // 
            // ScrCnt
            // 
            this.ScrCnt.HeaderText = "좌석 수";
            this.ScrCnt.Name = "ScrCnt";
            // 
            // ScrIntro
            // 
            this.ScrIntro.HeaderText = "소개";
            this.ScrIntro.Name = "ScrIntro";
            this.ScrIntro.Width = 550;
            // 
            // screenNM
            // 
            this.screenNM.Location = new System.Drawing.Point(124, 405);
            this.screenNM.Name = "screenNM";
            this.screenNM.Size = new System.Drawing.Size(167, 25);
            this.screenNM.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "상영관 이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 63;
            this.label3.Text = "좌석 수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 64;
            this.label4.Text = "소개";
            // 
            // screenIntro
            // 
            this.screenIntro.Location = new System.Drawing.Point(124, 489);
            this.screenIntro.Name = "screenIntro";
            this.screenIntro.Size = new System.Drawing.Size(584, 96);
            this.screenIntro.TabIndex = 65;
            this.screenIntro.Text = "";
            // 
            // seatNO
            // 
            this.seatNO.Location = new System.Drawing.Point(124, 447);
            this.seatNO.Name = "seatNO";
            this.seatNO.Size = new System.Drawing.Size(94, 25);
            this.seatNO.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 67;
            this.label5.Text = "개";
            // 
            // MoreButton
            // 
            this.MoreButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoreButton.Font = new System.Drawing.Font("NanumGothicExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MoreButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MoreButton.Location = new System.Drawing.Point(1126, 561);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.Size = new System.Drawing.Size(113, 55);
            this.MoreButton.TabIndex = 69;
            this.MoreButton.Text = "MORE";
            this.MoreButton.UseVisualStyleBackColor = false;
            this.MoreButton.Click += new System.EventHandler(this.MoreButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitButton.Font = new System.Drawing.Font("NanumGothicExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitButton.Location = new System.Drawing.Point(871, 561);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(237, 55);
            this.SubmitButton.TabIndex = 68;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(872, 510);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 15);
            this.error.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(18, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 23);
            this.label6.TabIndex = 71;
            this.label6.Text = "상영관 정보 추가하기";
            // 
            // ScreenInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.error);
            this.Controls.Add(this.MoreButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seatNO);
            this.Controls.Add(this.screenIntro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.screenNM);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ScreenInsert";
            this.Size = new System.Drawing.Size(1282, 655);
            this.Load += new System.EventHandler(this.ScreenInsert_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox screenNM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox screenIntro;
        private System.Windows.Forms.TextBox seatNO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button MoreButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrCnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrIntro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}
