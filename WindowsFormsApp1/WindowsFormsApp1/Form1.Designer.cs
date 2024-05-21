
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLottery = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.txtBox5 = new System.Windows.Forms.TextBox();
            this.txtBox6 = new System.Windows.Forms.TextBox();
            this.btnHold1 = new System.Windows.Forms.Button();
            this.btnHold2 = new System.Windows.Forms.Button();
            this.btnHold3 = new System.Windows.Forms.Button();
            this.btnHold4 = new System.Windows.Forms.Button();
            this.btnHold5 = new System.Windows.Forms.Button();
            this.btnHold6 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblnMin = new System.Windows.Forms.Label();
            this.lblnMax = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPathSearch = new System.Windows.Forms.Button();
            this.txtExclude1 = new System.Windows.Forms.TextBox();
            this.lblnExclude = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLottery
            // 
            this.btnLottery.Enabled = false;
            this.btnLottery.Location = new System.Drawing.Point(12, 67);
            this.btnLottery.Name = "btnLottery";
            this.btnLottery.Size = new System.Drawing.Size(776, 23);
            this.btnLottery.TabIndex = 0;
            this.btnLottery.Text = "추첨";
            this.btnLottery.UseVisualStyleBackColor = true;
            this.btnLottery.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(84, 96);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(100, 21);
            this.txtBox1.TabIndex = 1;
            this.txtBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(190, 96);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(100, 21);
            this.txtBox2.TabIndex = 2;
            this.txtBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(296, 96);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(100, 21);
            this.txtBox3.TabIndex = 3;
            this.txtBox3.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtBox4
            // 
            this.txtBox4.Location = new System.Drawing.Point(402, 96);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(100, 21);
            this.txtBox4.TabIndex = 4;
            this.txtBox4.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtBox5
            // 
            this.txtBox5.Location = new System.Drawing.Point(508, 96);
            this.txtBox5.Name = "txtBox5";
            this.txtBox5.Size = new System.Drawing.Size(100, 21);
            this.txtBox5.TabIndex = 5;
            this.txtBox5.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtBox6
            // 
            this.txtBox6.Location = new System.Drawing.Point(614, 96);
            this.txtBox6.Name = "txtBox6";
            this.txtBox6.Size = new System.Drawing.Size(100, 21);
            this.txtBox6.TabIndex = 6;
            this.txtBox6.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnHold1
            // 
            this.btnHold1.Enabled = false;
            this.btnHold1.Location = new System.Drawing.Point(84, 123);
            this.btnHold1.Name = "btnHold1";
            this.btnHold1.Size = new System.Drawing.Size(100, 23);
            this.btnHold1.TabIndex = 7;
            this.btnHold1.Text = "Hold";
            this.btnHold1.UseVisualStyleBackColor = true;
            this.btnHold1.Click += new System.EventHandler(this.btnHold1_Click);
            // 
            // btnHold2
            // 
            this.btnHold2.Enabled = false;
            this.btnHold2.Location = new System.Drawing.Point(190, 123);
            this.btnHold2.Name = "btnHold2";
            this.btnHold2.Size = new System.Drawing.Size(100, 23);
            this.btnHold2.TabIndex = 8;
            this.btnHold2.Text = "Hold";
            this.btnHold2.UseVisualStyleBackColor = true;
            this.btnHold2.Click += new System.EventHandler(this.btnHold1_Click);
            // 
            // btnHold3
            // 
            this.btnHold3.Enabled = false;
            this.btnHold3.Location = new System.Drawing.Point(296, 123);
            this.btnHold3.Name = "btnHold3";
            this.btnHold3.Size = new System.Drawing.Size(100, 23);
            this.btnHold3.TabIndex = 9;
            this.btnHold3.Text = "Hold";
            this.btnHold3.UseVisualStyleBackColor = true;
            this.btnHold3.Click += new System.EventHandler(this.btnHold1_Click);
            // 
            // btnHold4
            // 
            this.btnHold4.Enabled = false;
            this.btnHold4.Location = new System.Drawing.Point(402, 123);
            this.btnHold4.Name = "btnHold4";
            this.btnHold4.Size = new System.Drawing.Size(100, 23);
            this.btnHold4.TabIndex = 10;
            this.btnHold4.Text = "Hold";
            this.btnHold4.UseVisualStyleBackColor = true;
            this.btnHold4.Click += new System.EventHandler(this.btnHold1_Click);
            // 
            // btnHold5
            // 
            this.btnHold5.Enabled = false;
            this.btnHold5.Location = new System.Drawing.Point(508, 123);
            this.btnHold5.Name = "btnHold5";
            this.btnHold5.Size = new System.Drawing.Size(100, 23);
            this.btnHold5.TabIndex = 11;
            this.btnHold5.Text = "Hold";
            this.btnHold5.UseVisualStyleBackColor = true;
            this.btnHold5.Click += new System.EventHandler(this.btnHold1_Click);
            // 
            // btnHold6
            // 
            this.btnHold6.Enabled = false;
            this.btnHold6.Location = new System.Drawing.Point(614, 123);
            this.btnHold6.Name = "btnHold6";
            this.btnHold6.Size = new System.Drawing.Size(100, 23);
            this.btnHold6.TabIndex = 12;
            this.btnHold6.Text = "Hold";
            this.btnHold6.UseVisualStyleBackColor = true;
            this.btnHold6.Click += new System.EventHandler(this.btnHold1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(12, 335);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 21);
            this.txtMin.TabIndex = 13;
            this.txtMin.TextChanged += new System.EventHandler(this.textMin_TextChanged);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(12, 388);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 21);
            this.txtMax.TabIndex = 14;
            this.txtMax.TextChanged += new System.EventHandler(this.textMax_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(118, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblnMin
            // 
            this.lblnMin.AutoSize = true;
            this.lblnMin.Location = new System.Drawing.Point(13, 317);
            this.lblnMin.Name = "lblnMin";
            this.lblnMin.Size = new System.Drawing.Size(29, 12);
            this.lblnMin.TabIndex = 16;
            this.lblnMin.Text = "최소";
            // 
            // lblnMax
            // 
            this.lblnMax.AutoSize = true;
            this.lblnMax.Location = new System.Drawing.Point(13, 373);
            this.lblnMax.Name = "lblnMax";
            this.lblnMax.Size = new System.Drawing.Size(29, 12);
            this.lblnMax.TabIndex = 17;
            this.lblnMax.Text = "최대";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(118, 388);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Reload";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtPath
            // 
            this.txtPath.ForeColor = System.Drawing.Color.Black;
            this.txtPath.Location = new System.Drawing.Point(12, 417);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(181, 21);
            this.txtPath.TabIndex = 19;
            this.txtPath.Text = "D:\\ROOT\\_data001.txt";
            // 
            // btnPathSearch
            // 
            this.btnPathSearch.Location = new System.Drawing.Point(200, 417);
            this.btnPathSearch.Name = "btnPathSearch";
            this.btnPathSearch.Size = new System.Drawing.Size(90, 23);
            this.btnPathSearch.TabIndex = 21;
            this.btnPathSearch.Text = "PathSearch";
            this.btnPathSearch.UseVisualStyleBackColor = true;
            this.btnPathSearch.Click += new System.EventHandler(this.btnPathSearch_Click);
            // 
            // txtExclude1
            // 
            this.txtExclude1.Location = new System.Drawing.Point(84, 168);
            this.txtExclude1.Multiline = true;
            this.txtExclude1.Name = "txtExclude1";
            this.txtExclude1.Size = new System.Drawing.Size(100, 69);
            this.txtExclude1.TabIndex = 22;
            this.txtExclude1.TextChanged += new System.EventHandler(this.textExclude1_TextChanged);
            // 
            // lblnExclude
            // 
            this.lblnExclude.AutoSize = true;
            this.lblnExclude.Location = new System.Drawing.Point(87, 154);
            this.lblnExclude.Name = "lblnExclude";
            this.lblnExclude.Size = new System.Drawing.Size(57, 12);
            this.lblnExclude.TabIndex = 28;
            this.lblnExclude.Text = "제외 숫자";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnExclude);
            this.Controls.Add(this.txtExclude1);
            this.Controls.Add(this.btnPathSearch);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblnMax);
            this.Controls.Add(this.lblnMin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.btnHold6);
            this.Controls.Add(this.btnHold5);
            this.Controls.Add(this.btnHold4);
            this.Controls.Add(this.btnHold3);
            this.Controls.Add(this.btnHold2);
            this.Controls.Add(this.btnHold1);
            this.Controls.Add(this.txtBox6);
            this.Controls.Add(this.txtBox5);
            this.Controls.Add(this.txtBox4);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btnLottery);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLottery;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.TextBox txtBox5;
        private System.Windows.Forms.TextBox txtBox6;
        private System.Windows.Forms.Button btnHold1;
        private System.Windows.Forms.Button btnHold2;
        private System.Windows.Forms.Button btnHold3;
        private System.Windows.Forms.Button btnHold4;
        private System.Windows.Forms.Button btnHold5;
        private System.Windows.Forms.Button btnHold6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblnMin;
        private System.Windows.Forms.Label lblnMax;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPathSearch;
        private System.Windows.Forms.TextBox txtExclude1;
        private System.Windows.Forms.Label lblnExclude;
    }
}

