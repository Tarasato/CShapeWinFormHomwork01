namespace CShapeWinFormHomwork01
{
    partial class FrmHomework2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomework2));
            this.gbStuData = new System.Windows.Forms.GroupBox();
            this.lbTest = new System.Windows.Forms.Label();
            this.lbFinal = new System.Windows.Forms.Label();
            this.lbMidterm = new System.Windows.Forms.Label();
            this.tbTest = new System.Windows.Forms.TextBox();
            this.tbFinal = new System.Windows.Forms.TextBox();
            this.tbMidterm = new System.Windows.Forms.TextBox();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.lbFullname = new System.Windows.Forms.Label();
            this.tbIdStu = new System.Windows.Forms.TextBox();
            this.lbIdStu = new System.Windows.Forms.Label();
            this.lbIdStu2 = new System.Windows.Forms.Label();
            this.lbFullname2 = new System.Windows.Forms.Label();
            this.lbPointTotal = new System.Windows.Forms.Label();
            this.lbIdResult = new System.Windows.Forms.Label();
            this.lbFullnameResult = new System.Windows.Forms.Label();
            this.lbPointTotalResult = new System.Windows.Forms.Label();
            this.lbHead = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.lbGradeResult = new System.Windows.Forms.Label();
            this.lbGrade = new System.Windows.Forms.Label();
            this.gbStuData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStuData
            // 
            this.gbStuData.Controls.Add(this.lbTest);
            this.gbStuData.Controls.Add(this.lbFinal);
            this.gbStuData.Controls.Add(this.lbMidterm);
            this.gbStuData.Controls.Add(this.tbTest);
            this.gbStuData.Controls.Add(this.tbFinal);
            this.gbStuData.Controls.Add(this.tbMidterm);
            this.gbStuData.Controls.Add(this.tbFullname);
            this.gbStuData.Controls.Add(this.lbFullname);
            this.gbStuData.Controls.Add(this.tbIdStu);
            this.gbStuData.Controls.Add(this.lbIdStu);
            this.gbStuData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gbStuData.Location = new System.Drawing.Point(46, 47);
            this.gbStuData.Name = "gbStuData";
            this.gbStuData.Size = new System.Drawing.Size(408, 241);
            this.gbStuData.TabIndex = 0;
            this.gbStuData.TabStop = false;
            this.gbStuData.Text = "ข้อมูลนักศึกษา";
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Location = new System.Drawing.Point(41, 191);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(70, 15);
            this.lbTest.TabIndex = 9;
            this.lbTest.Text = "คะแนนเก็บ";
            // 
            // lbFinal
            // 
            this.lbFinal.AutoSize = true;
            this.lbFinal.Location = new System.Drawing.Point(6, 156);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(99, 15);
            this.lbFinal.TabIndex = 8;
            this.lbFinal.Text = "คะแนนปลายภาค";
            this.lbFinal.Click += new System.EventHandler(this.lbFinal_Click);
            // 
            // lbMidterm
            // 
            this.lbMidterm.AutoSize = true;
            this.lbMidterm.Location = new System.Drawing.Point(12, 115);
            this.lbMidterm.Name = "lbMidterm";
            this.lbMidterm.Size = new System.Drawing.Size(97, 15);
            this.lbMidterm.TabIndex = 7;
            this.lbMidterm.Text = "คะแนนกลางภาค";
            // 
            // tbTest
            // 
            this.tbTest.Location = new System.Drawing.Point(153, 191);
            this.tbTest.Name = "tbTest";
            this.tbTest.Size = new System.Drawing.Size(186, 21);
            this.tbTest.TabIndex = 6;
            // 
            // tbFinal
            // 
            this.tbFinal.Location = new System.Drawing.Point(153, 153);
            this.tbFinal.Name = "tbFinal";
            this.tbFinal.Size = new System.Drawing.Size(186, 21);
            this.tbFinal.TabIndex = 5;
            // 
            // tbMidterm
            // 
            this.tbMidterm.Location = new System.Drawing.Point(153, 115);
            this.tbMidterm.Name = "tbMidterm";
            this.tbMidterm.Size = new System.Drawing.Size(186, 21);
            this.tbMidterm.TabIndex = 4;
            // 
            // tbFullname
            // 
            this.tbFullname.Location = new System.Drawing.Point(153, 77);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(186, 21);
            this.tbFullname.TabIndex = 3;
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Location = new System.Drawing.Point(60, 77);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(49, 15);
            this.lbFullname.TabIndex = 2;
            this.lbFullname.Text = "ชื่อ-สกุล";
            // 
            // tbIdStu
            // 
            this.tbIdStu.Location = new System.Drawing.Point(153, 39);
            this.tbIdStu.Name = "tbIdStu";
            this.tbIdStu.Size = new System.Drawing.Size(186, 21);
            this.tbIdStu.TabIndex = 1;
            // 
            // lbIdStu
            // 
            this.lbIdStu.AutoSize = true;
            this.lbIdStu.Location = new System.Drawing.Point(31, 39);
            this.lbIdStu.Name = "lbIdStu";
            this.lbIdStu.Size = new System.Drawing.Size(78, 15);
            this.lbIdStu.TabIndex = 0;
            this.lbIdStu.Text = "รหัสนักศึกษา";
            this.lbIdStu.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbIdStu2
            // 
            this.lbIdStu2.AutoSize = true;
            this.lbIdStu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbIdStu2.Location = new System.Drawing.Point(78, 413);
            this.lbIdStu2.Name = "lbIdStu2";
            this.lbIdStu2.Size = new System.Drawing.Size(78, 15);
            this.lbIdStu2.TabIndex = 4;
            this.lbIdStu2.Text = "รหัสนักศึกษา";
            // 
            // lbFullname2
            // 
            this.lbFullname2.AutoSize = true;
            this.lbFullname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbFullname2.Location = new System.Drawing.Point(107, 444);
            this.lbFullname2.Name = "lbFullname2";
            this.lbFullname2.Size = new System.Drawing.Size(49, 15);
            this.lbFullname2.TabIndex = 5;
            this.lbFullname2.Text = "ชื่อ-สกุล";
            // 
            // lbPointTotal
            // 
            this.lbPointTotal.AutoSize = true;
            this.lbPointTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbPointTotal.Location = new System.Drawing.Point(85, 483);
            this.lbPointTotal.Name = "lbPointTotal";
            this.lbPointTotal.Size = new System.Drawing.Size(70, 15);
            this.lbPointTotal.TabIndex = 6;
            this.lbPointTotal.Text = "คะแนนรวม";
            this.lbPointTotal.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbIdResult
            // 
            this.lbIdResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbIdResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbIdResult.ForeColor = System.Drawing.Color.Green;
            this.lbIdResult.Location = new System.Drawing.Point(196, 413);
            this.lbIdResult.Name = "lbIdResult";
            this.lbIdResult.Size = new System.Drawing.Size(219, 23);
            this.lbIdResult.TabIndex = 9;
            this.lbIdResult.Text = "XXXXXXXX";
            this.lbIdResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFullnameResult
            // 
            this.lbFullnameResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbFullnameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbFullnameResult.ForeColor = System.Drawing.Color.Green;
            this.lbFullnameResult.Location = new System.Drawing.Point(196, 444);
            this.lbFullnameResult.Name = "lbFullnameResult";
            this.lbFullnameResult.Size = new System.Drawing.Size(219, 23);
            this.lbFullnameResult.TabIndex = 10;
            this.lbFullnameResult.Text = "XXXXXXXX";
            this.lbFullnameResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPointTotalResult
            // 
            this.lbPointTotalResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbPointTotalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbPointTotalResult.ForeColor = System.Drawing.Color.Green;
            this.lbPointTotalResult.Location = new System.Drawing.Point(196, 475);
            this.lbPointTotalResult.Name = "lbPointTotalResult";
            this.lbPointTotalResult.Size = new System.Drawing.Size(219, 23);
            this.lbPointTotalResult.TabIndex = 11;
            this.lbPointTotalResult.Text = "XXXXXXXX";
            this.lbPointTotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbHead.ForeColor = System.Drawing.Color.Blue;
            this.lbHead.Location = new System.Drawing.Point(137, 9);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(248, 31);
            this.lbHead.TabIndex = 14;
            this.lbHead.Text = "โปรแกรมผลการเรียน";
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btClose.Image = global::CShapeWinFormHomwork01.Properties.Resources.exit3;
            this.btClose.Location = new System.Drawing.Point(346, 312);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(82, 78);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "ปิดหน้าจอ";
            this.btClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btClose.UseVisualStyleBackColor = false;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btCancel.Image = global::CShapeWinFormHomwork01.Properties.Resources.cancel;
            this.btCancel.Location = new System.Drawing.Point(213, 312);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(82, 78);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // btCal
            // 
            this.btCal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCal.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btCal.Image = global::CShapeWinFormHomwork01.Properties.Resources.calculator2;
            this.btCal.Location = new System.Drawing.Point(80, 312);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(82, 78);
            this.btCal.TabIndex = 1;
            this.btCal.Text = "คำนวณ";
            this.btCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCal.UseVisualStyleBackColor = false;
            // 
            // lbGradeResult
            // 
            this.lbGradeResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbGradeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbGradeResult.ForeColor = System.Drawing.Color.Green;
            this.lbGradeResult.Location = new System.Drawing.Point(196, 510);
            this.lbGradeResult.Name = "lbGradeResult";
            this.lbGradeResult.Size = new System.Drawing.Size(219, 23);
            this.lbGradeResult.TabIndex = 16;
            this.lbGradeResult.Text = "XXXXXXXX";
            this.lbGradeResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbGrade.Location = new System.Drawing.Point(115, 514);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(36, 15);
            this.lbGrade.TabIndex = 15;
            this.lbGrade.Text = "เกรด";
            // 
            // FrmHomework2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 602);
            this.Controls.Add(this.lbGradeResult);
            this.Controls.Add(this.lbGrade);
            this.Controls.Add(this.lbHead);
            this.Controls.Add(this.lbPointTotalResult);
            this.Controls.Add(this.lbFullnameResult);
            this.Controls.Add(this.lbIdResult);
            this.Controls.Add(this.lbPointTotal);
            this.Controls.Add(this.lbFullname2);
            this.Controls.Add(this.lbIdStu2);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.gbStuData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHomework2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "โปรแกรมการบัาน2";
            this.Load += new System.EventHandler(this.FrmHomework2_Load);
            this.gbStuData.ResumeLayout(false);
            this.gbStuData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStuData;
        private System.Windows.Forms.TextBox tbIdStu;
        private System.Windows.Forms.Label lbIdStu;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.Label lbFinal;
        private System.Windows.Forms.Label lbMidterm;
        private System.Windows.Forms.TextBox tbTest;
        private System.Windows.Forms.TextBox tbFinal;
        private System.Windows.Forms.TextBox tbMidterm;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbIdStu2;
        private System.Windows.Forms.Label lbFullname2;
        private System.Windows.Forms.Label lbPointTotal;
        private System.Windows.Forms.Label lbIdResult;
        private System.Windows.Forms.Label lbFullnameResult;
        private System.Windows.Forms.Label lbPointTotalResult;
        private System.Windows.Forms.Label lbHead;
        private System.Windows.Forms.Label lbGradeResult;
        private System.Windows.Forms.Label lbGrade;
    }
}