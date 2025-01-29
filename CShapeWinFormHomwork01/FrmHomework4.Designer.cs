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
            this.rdJAVA = new System.Windows.Forms.RadioButton();
            this.rdAndroid = new System.Windows.Forms.RadioButton();
            this.rdiOS = new System.Windows.Forms.RadioButton();
            this.rdPHP = new System.Windows.Forms.RadioButton();
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
            // rdJAVA
            // 
            this.rdJAVA.AutoSize = true;
            this.rdJAVA.Checked = true;
            this.rdJAVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdJAVA.Location = new System.Drawing.Point(109, 82);
            this.rdJAVA.Name = "rdJAVA";
            this.rdJAVA.Size = new System.Drawing.Size(233, 19);
            this.rdJAVA.TabIndex = 3;
            this.rdJAVA.TabStop = true;
            this.rdJAVA.Text = "อบรม JAVA Developer (คนละ 1,000 บาท)";
            this.rdJAVA.UseVisualStyleBackColor = true;
            // 
            // rdAndroid
            // 
            this.rdAndroid.AutoSize = true;
            this.rdAndroid.Checked = true;
            this.rdAndroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdAndroid.Location = new System.Drawing.Point(109, 107);
            this.rdAndroid.Name = "rdAndroid";
            this.rdAndroid.Size = new System.Drawing.Size(248, 19);
            this.rdAndroid.TabIndex = 4;
            this.rdAndroid.TabStop = true;
            this.rdAndroid.Text = "อบรม Android Developer (คนละ 1,200 บาท)";
            this.rdAndroid.UseVisualStyleBackColor = true;
            // 
            // rdiOS
            // 
            this.rdiOS.AutoSize = true;
            this.rdiOS.Checked = true;
            this.rdiOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdiOS.Location = new System.Drawing.Point(109, 132);
            this.rdiOS.Name = "rdiOS";
            this.rdiOS.Size = new System.Drawing.Size(226, 19);
            this.rdiOS.TabIndex = 5;
            this.rdiOS.TabStop = true;
            this.rdiOS.Text = "อบรม iOS Developer (คนละ 1,400 บาท)";
            this.rdiOS.UseVisualStyleBackColor = true;
            // 
            // rdPHP
            // 
            this.rdPHP.AutoSize = true;
            this.rdPHP.Checked = true;
            this.rdPHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdPHP.Location = new System.Drawing.Point(109, 157);
            this.rdPHP.Name = "rdPHP";
            this.rdPHP.Size = new System.Drawing.Size(231, 19);
            this.rdPHP.TabIndex = 6;
            this.rdPHP.TabStop = true;
            this.rdPHP.Text = "อบรม PHP Developer (คนละ 1,600 บาท)";
            this.rdPHP.UseVisualStyleBackColor = true;
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
            this.lbTotalCostResult.AutoSize = true;
            this.lbTotalCostResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTotalCostResult.ForeColor = System.Drawing.Color.Red;
            this.lbTotalCostResult.Location = new System.Drawing.Point(130, 290);
            this.lbTotalCostResult.Name = "lbTotalCostResult";
            this.lbTotalCostResult.Size = new System.Drawing.Size(55, 24);
            this.lbTotalCostResult.TabIndex = 27;
            this.lbTotalCostResult.Text = "XXX";
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
            this.lbAmountResult.AutoSize = true;
            this.lbAmountResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbAmountResult.ForeColor = System.Drawing.Color.Red;
            this.lbAmountResult.Location = new System.Drawing.Point(129, 197);
            this.lbAmountResult.Name = "lbAmountResult";
            this.lbAmountResult.Size = new System.Drawing.Size(55, 24);
            this.lbAmountResult.TabIndex = 25;
            this.lbAmountResult.Text = "XXX";
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
            this.lbTopicResult.AutoSize = true;
            this.lbTopicResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTopicResult.ForeColor = System.Drawing.Color.Red;
            this.lbTopicResult.Location = new System.Drawing.Point(129, 116);
            this.lbTopicResult.Name = "lbTopicResult";
            this.lbTopicResult.Size = new System.Drawing.Size(55, 24);
            this.lbTopicResult.TabIndex = 23;
            this.lbTopicResult.Text = "XXX";
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
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.gbNote);
            this.Controls.Add(this.lbPeople);
            this.Controls.Add(this.tbAmountPeople);
            this.Controls.Add(this.lbAmountPeople);
            this.Controls.Add(this.rdPHP);
            this.Controls.Add(this.rdiOS);
            this.Controls.Add(this.rdAndroid);
            this.Controls.Add(this.rdJAVA);
            this.Controls.Add(this.lbHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHomework4";
            this.Text = "โปรแกรมการบัาน4";
            this.gbNote.ResumeLayout(false);
            this.gbNote.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHead;
        private System.Windows.Forms.RadioButton rdJAVA;
        private System.Windows.Forms.RadioButton rdAndroid;
        private System.Windows.Forms.RadioButton rdiOS;
        private System.Windows.Forms.RadioButton rdPHP;
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