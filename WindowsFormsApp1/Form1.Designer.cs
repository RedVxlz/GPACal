namespace WindowsFormsApp1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInputGPA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGPAx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInputStd = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(332, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 72);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Go";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ใส่คะแนน GPA";
            // 
            // tbInputGPA
            // 
            this.tbInputGPA.Location = new System.Drawing.Point(127, 71);
            this.tbInputGPA.Name = "tbInputGPA";
            this.tbInputGPA.Size = new System.Drawing.Size(150, 20);
            this.tbInputGPA.TabIndex = 2;
            this.tbInputGPA.TextChanged += new System.EventHandler(this.tbInputGPA_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ใส่คะแนน GPAX";
            // 
            // tbGPAx
            // 
            this.tbGPAx.Location = new System.Drawing.Point(127, 97);
            this.tbGPAx.Name = "tbGPAx";
            this.tbGPAx.Size = new System.Drawing.Size(150, 20);
            this.tbGPAx.TabIndex = 5;
            this.tbGPAx.TextChanged += new System.EventHandler(this.tbGPAx_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // tbInputStd
            // 
            this.tbInputStd.Location = new System.Drawing.Point(127, 45);
            this.tbInputStd.Name = "tbInputStd";
            this.tbInputStd.Size = new System.Drawing.Size(150, 20);
            this.tbInputStd.TabIndex = 7;
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(127, 156);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(150, 20);
            this.tbMax.TabIndex = 8;
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(127, 182);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(150, 20);
            this.tbMin.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "คะแนนสูงสุด";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "คะแนนต่ำสุด";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "คนที่";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 243);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbInputStd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGPAx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInputGPA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInputGPA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGPAx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbInputStd;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

