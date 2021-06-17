
namespace question1_36
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStuNo = new System.Windows.Forms.TextBox();
            this.txtDM = new System.Windows.Forms.TextBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.lblAvg = new System.Windows.Forms.RichTextBox();
            this.txtRAD = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnOverall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Discreate Mathematics";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "RAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "OS";
            // 
            // txtStuNo
            // 
            this.txtStuNo.Location = new System.Drawing.Point(230, 78);
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.Size = new System.Drawing.Size(100, 22);
            this.txtStuNo.TabIndex = 1;
            // 
            // txtDM
            // 
            this.txtDM.Location = new System.Drawing.Point(230, 124);
            this.txtDM.Name = "txtDM";
            this.txtDM.Size = new System.Drawing.Size(100, 22);
            this.txtDM.TabIndex = 1;
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(230, 205);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(100, 22);
            this.txtOS.TabIndex = 1;
            // 
            // lblAvg
            // 
            this.lblAvg.Location = new System.Drawing.Point(94, 316);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(265, 96);
            this.lblAvg.TabIndex = 2;
            this.lblAvg.Text = "";
            // 
            // txtRAD
            // 
            this.txtRAD.Location = new System.Drawing.Point(230, 163);
            this.txtRAD.Name = "txtRAD";
            this.txtRAD.Size = new System.Drawing.Size(100, 22);
            this.txtRAD.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(30, 259);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(135, 36);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert Record";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnOverall
            // 
            this.btnOverall.Location = new System.Drawing.Point(230, 259);
            this.btnOverall.Name = "btnOverall";
            this.btnOverall.Size = new System.Drawing.Size(171, 36);
            this.btnOverall.TabIndex = 3;
            this.btnOverall.Text = "Overall Performace";
            this.btnOverall.UseVisualStyleBackColor = true;
            this.btnOverall.Click += new System.EventHandler(this.btnOverall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 436);
            this.Controls.Add(this.btnOverall);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.txtRAD);
            this.Controls.Add(this.txtDM);
            this.Controls.Add(this.txtStuNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Batch Performance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStuNo;
        private System.Windows.Forms.TextBox txtDM;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.RichTextBox lblAvg;
        private System.Windows.Forms.TextBox txtRAD;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnOverall;
    }
}

