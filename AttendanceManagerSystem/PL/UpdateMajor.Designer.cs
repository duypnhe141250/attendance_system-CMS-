
namespace AttendanceManagerSystem.PL
{
    partial class UpdateMajor
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
            this.txtMajorID1 = new System.Windows.Forms.TextBox();
            this.txtMajorName1 = new System.Windows.Forms.TextBox();
            this.btnUpdateMajor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATE MAJOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Major ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Major Name:";
            // 
            // txtMajorID1
            // 
            this.txtMajorID1.Location = new System.Drawing.Point(140, 52);
            this.txtMajorID1.Name = "txtMajorID1";
            this.txtMajorID1.Size = new System.Drawing.Size(190, 20);
            this.txtMajorID1.TabIndex = 3;
            this.txtMajorID1.TextChanged += new System.EventHandler(this.txtMajorID_TextChanged);
            // 
            // txtMajorName1
            // 
            this.txtMajorName1.Location = new System.Drawing.Point(140, 92);
            this.txtMajorName1.Name = "txtMajorName1";
            this.txtMajorName1.Size = new System.Drawing.Size(190, 20);
            this.txtMajorName1.TabIndex = 4;
            // 
            // btnUpdateMajor
            // 
            this.btnUpdateMajor.Location = new System.Drawing.Point(180, 158);
            this.btnUpdateMajor.Name = "btnUpdateMajor";
            this.btnUpdateMajor.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMajor.TabIndex = 5;
            this.btnUpdateMajor.Text = "Update";
            this.btnUpdateMajor.UseVisualStyleBackColor = true;
            this.btnUpdateMajor.Click += new System.EventHandler(this.btnUpdateMajor_Click);
            // 
            // UpdateMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 229);
            this.Controls.Add(this.btnUpdateMajor);
            this.Controls.Add(this.txtMajorName1);
            this.Controls.Add(this.txtMajorID1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateMajor";
            this.Text = "UpdateMajor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMajorID1;
        private System.Windows.Forms.TextBox txtMajorName1;
        private System.Windows.Forms.Button btnUpdateMajor;
    }
}