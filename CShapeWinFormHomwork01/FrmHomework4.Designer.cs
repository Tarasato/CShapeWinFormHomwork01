namespace CShapeWinFormHomwork01
{
    partial class FrmHomework4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomework4));
            this.lbHead = new System.Windows.Forms.Label();
            this.rbJAVA = new System.Windows.Forms.RadioButton();
            this.rbAndroid = new System.Windows.Forms.RadioButton();
            this.rbiOS = new System.Windows.Forms.RadioButton();
            this.rbPHP = new System.Windows.Forms.RadioButton();
            this.lbAmountPeople = new System.Windows.Forms.Label();
            this.tbAmountPeople = new System.Windows.Forms.TextBox();
            this.lbPeople = new System.Windows.Forms.Label();
            this.gbNote = new System.Windows.Forms.GroupBox();
            this.lbNote2 = new System.Windows.Forms.Label();
            this.lbNote1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotalCostResult = new System.Windows.Forms.Label();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.lbAmountResult = new System.Windows.Forms.Label();
            this.lbAmountPeople2 = new System.Windows.Forms.Label();
            this.lbTopicResult = new System.Windows.Forms.Label();
            this.lbTopic = new System.Windows.Forms.Label();
            this.lbResultHead = new System.Windows.Forms.Label();
            this.gbNote.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbHead.ForeColor = System.Drawing.Color.Blue;
            this.lbHead.Location = new System.Drawing.Point(217, 20);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(380, 31);
            this.lbHead.TabIndex = 2;
            this.lbHead.Text = "โปรแกรมคำนวณค่าอบรม สัมมนา";
            // 
            // rbJAVA
            // 
            this.rbJAVA.AutoSize = true;
            this.rbJAVA.Checked = true;
            this.rbJAVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rbJAVA.Location = new System.Drawing.Point(109, 82);
            this.rbJAVA.Name = "rbJAVA";
            this.rbJAVA.Size = new System.Drawing.Size(233, 19);
            this.rbJAVA.TabIndex = 3;
            this.rbJAVA.TabStop = true;
            this.rbJAVA.Text = "อบรม JAVA Developer (คนละ 1,000 บาท)";
            this.rbJAVA.UseVisualStyleBackColor = true;
            // 
            // rbAndroid
            // 
            this.rbAndroid.AutoSize = true;
            this.rbAndroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rbAndroid.Location = new System.Drawing.Point(109, 107);
            this.rbAndroid.Name = "rbAndroid";
            this.rbAndroid.Size = new System.Drawing.Size(248, 19);
            this.rbAndroid.TabIndex = 4;
            this.rbAndroid.Text = "อบรม Android Developer (คนละ 1,200 บาท)";
            this.rbAndroid.UseVisualStyleBackColor = true;
            // 
            // rbiOS
            // 
            this.rbiOS.AutoSize = true;
            this.rbiOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rbiOS.Location = new System.Drawing.Point(109, 132);
            this.rbiOS.Name = "rbiOS";
            this.rbiOS.Size = new System.Drawing.Size(226, 19);
            this.rbiOS.TabIndex = 5;
            this.rbiOS.Text = "อบรม iOS Developer (คนละ 1,400 บาท)";
            this.rbiOS.UseVisualStyleBackColor = true;
            // 
            // rbPHP
            // 
            this.rbPHP.AutoSize = true;
            this.rbPHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rbPHP.Location = new System.Drawing.Point(109, 157);
            this.rbPHP.Name = "rbPHP";
            this.rbPHP.Size = new System.Drawing.Size(231, 19);
            this.rbPHP.TabIndex = 6;
            this.rbPHP.Text = "อบรม PHP Developer (คนละ 1,600 บาท)";
            this.rbPHP.UseVisualStyleBackColor = true;
            // 
            // lbAmountPeople
            // 
            this.lbAmountPeople.AutoSize = true;
            this.lbAmountPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbAmountPeople.Location = new System.Drawing.Point(26, 209);
            this.lbAmountPeople.Name = "lbAmountPeople";
            this.lbAmountPeople.Size = new System.Drawing.Size(120, 15);
            this.lbAmountPeople.TabIndex = 7;
            this.lbAmountPeople.Text = "จํานวนคนที่เข้าอบรม";
            // 
            // tbAmountPeople
            // 
            this.tbAmountPeople.Location = new System.Drawing.Point(167, 208);
            this.tbAmountPeople.Name = "tbAmountPeople";
            this.tbAmountPeople.Size = new System.Drawing.Size(134, 20);
            this.tbAmountPeople.TabIndex = 8;
            this.tbAmountPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmountPeople_KeyPress);
            // 
            // lbPeople
            // 
            this.lbPeople.AutoSize = true;
            this.lbPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbPeople.Location = new System.Drawing.Point(331, 209);
            this.lbPeople.Name = "lbPeople";
            this.lbPeople.Size = new System.Drawing.Size(24, 15);
            this.lbPeople.TabIndex = 9;
            this.lbPeople.Text = "คน";
            // 
            // gbNote
            // 
            this.gbNote.Controls.Add(this.lbNote2);
            this.gbNote.Controls.Add(this.lbNote1);
            this.gbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gbNote.Location = new System.Drawing.Point(129, 249);
            this.gbNote.Name = "gbNote";
            this.gbNote.Size = new System.Drawing.Size(200, 85);
            this.gbNote.TabIndex = 10;
            this.gbNote.TabStop = false;
            this.gbNote.Text = "หมายเหตุ";
            // 
            // lbNote2
            // 
            this.lbNote2.AutoSize = true;
            this.lbNote2.Location = new System.Drawing.Point(9, 47);
            this.lbNote2.Name = "lbNote2";
            this.lbNote2.Size = new System.Drawing.Size(176, 15);
            this.lbNote2.TabIndex = 1;
            this.lbNote2.Text = "- กรณีเข้าอบรม 5 คนขึ้นไปลด 10%";
            // 
            // lbNote1
            // 
            this.lbNote1.AutoSize = true;
            this.lbNote1.Location = new System.Drawing.Point(9, 22);
            this.lbNote1.Name = "lbNote1";
            this.lbNote1.Size = new System.Drawing.Size(155, 15);
            this.lbNote1.TabIndex = 0;
            this.lbNote1.Text = "- กรณีเข้าอบรม 2-4 คน ลด 5%";
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btClose.Image = global::CShapeWinFormHomwork01.Properties.Resources.exit3;
            this.btClose.Location = new System.Drawing.Point(315, 340);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(82, 78);
            this.btClose.TabIndex = 13;
            this.btClose.Text = "ปิดหน้าจอ";
            this.btClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btCancel.Image = global::CShapeWinFormHomwork01.Properties.Resources.cancel;
            this.btCancel.Location = new System.Drawing.Point(182, 340);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(82, 78);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCal
            // 
            this.btCal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCal.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btCal.Image = global::CShapeWinFormHomwork01.Properties.Resources.calculator2;
            this.btCal.Location = new System.Drawing.Point(49, 340);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(82, 78);
            this.btCal.TabIndex = 11;
            this.btCal.Text = "คำนวณ";
            this.btCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCal.UseVisualStyleBackColor = false;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lbTotalCostResult);
            this.panel1.Controls.Add(this.lbTotalCost);
            this.panel1.Controls.Add(this.lbAmountResult);
            this.panel1.Controls.Add(this.lbAmountPeople2);
            this.panel1.Controls.Add(this.lbTopicResult);
            this.panel1.Controls.Add(this.lbTopic);
            this.panel1.Controls.Add(this.lbResultHead);
            this.panel1.Location = new System.Drawing.Point(447, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 349);
            this.panel1.TabIndex = 15;
            // 
            // lbTotalCostResult
            // 
            this.lbTotalCostResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTotalCostResult.ForeColor = System.Drawing.Color.Red;
            this.lbTotalCostResult.Location = new System.Drawing.Point(87, 287);
            this.lbTotalCostResult.Name = "lbTotalCostResult";
            this.lbTotalCostResult.Size = new System.Drawing.Size(129, 24);
            this.lbTotalCostResult.TabIndex = 27;
            this.lbTotalCostResult.Text = "XXX";
            this.lbTotalCostResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.AutoSize = true;
            this.lbTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTotalCost.Location = new System.Drawing.Point(97, 246);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(107, 15);
            this.lbTotalCost.TabIndex = 26;
            this.lbTotalCost.Text = "ค่าอบรมที่ต้องชำระ";
            // 
            // lbAmountResult
            // 
            this.lbAmountResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbAmountResult.ForeColor = System.Drawing.Color.Red;
            this.lbAmountResult.Location = new System.Drawing.Point(87, 193);
            this.lbAmountResult.Name = "lbAmountResult";
            this.lbAmountResult.Size = new System.Drawing.Size(129, 24);
            this.lbAmountResult.TabIndex = 25;
            this.lbAmountResult.Text = "XXX";
            this.lbAmountResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAmountPeople2
            // 
            this.lbAmountPeople2.AutoSize = true;
            this.lbAmountPeople2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbAmountPeople2.Location = new System.Drawing.Point(112, 159);
            this.lbAmountPeople2.Name = "lbAmountPeople2";
            this.lbAmountPeople2.Size = new System.Drawing.Size(73, 15);
            this.lbAmountPeople2.TabIndex = 24;
            this.lbAmountPeople2.Text = "จำนวนผู้เข้า";
            // 
            // lbTopicResult
            // 
            this.lbTopicResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTopicResult.ForeColor = System.Drawing.Color.Red;
            this.lbTopicResult.Location = new System.Drawing.Point(47, 113);
            this.lbTopicResult.Name = "lbTopicResult";
            this.lbTopicResult.Size = new System.Drawing.Size(203, 24);
            this.lbTopicResult.TabIndex = 23;
            this.lbTopicResult.Text = "XXX";
            this.lbTopicResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTopic
            // 
            this.lbTopic.AutoSize = true;
            this.lbTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTopic.Location = new System.Drawing.Point(112, 82);
            this.lbTopic.Name = "lbTopic";
            this.lbTopic.Size = new System.Drawing.Size(87, 15);
            this.lbTopic.TabIndex = 21;
            this.lbTopic.Text = "เข้าอบรมหัวข้อ";
            // 
            // lbResultHead
            // 
            this.lbResultHead.AutoSize = true;
            this.lbResultHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbResultHead.ForeColor = System.Drawing.Color.Blue;
            this.lbResultHead.Location = new System.Drawing.Point(94, 35);
            this.lbResultHead.Name = "lbResultHead";
            this.lbResultHead.Size = new System.Drawing.Size(122, 31);
            this.lbResultHead.TabIndex = 22;
            this.lbResultHead.Text = "สรุปข้อมูล";
            // 
            // FrmHomework4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.gbNote);
            this.Controls.Add(this.lbPeople);
            this.Controls.Add(this.tbAmountPeople);
            this.Controls.Add(this.lbAmountPeople);
            this.Controls.Add(this.rbPHP);
            this.Controls.Add(this.rbiOS);
            this.Controls.Add(this.rbAndroid);
            this.Controls.Add(this.rbJAVA);
            this.Controls.Add(this.lbHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHomework4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมการบัาน4";
            this.Load += new System.EventHandler(this.FrmHomework4_Load);
            this.Click += new System.EventHandler(this.FrmHomework4_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmHomework4_KeyPress);
            this.gbNote.ResumeLayout(false);
            this.gbNote.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHead;
        private System.Windows.Forms.RadioButton rbJAVA;
        private System.Windows.Forms.RadioButton rbAndroid;
        private System.Windows.Forms.RadioButton rbiOS;
        private System.Windows.Forms.RadioButton rbPHP;
        private System.Windows.Forms.Label lbAmountPeople;
        private System.Windows.Forms.TextBox tbAmountPeople;
        private System.Windows.Forms.Label lbPeople;
        private System.Windows.Forms.GroupBox gbNote;
        private System.Windows.Forms.Label lbNote2;
        private System.Windows.Forms.Label lbNote1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTotalCostResult;
        private System.Windows.Forms.Label lbTotalCost;
        private System.Windows.Forms.Label lbAmountResult;
        private System.Windows.Forms.Label lbAmountPeople2;
        private System.Windows.Forms.Label lbTopicResult;
        private System.Windows.Forms.Label lbTopic;
        private System.Windows.Forms.Label lbResultHead;
    }
}