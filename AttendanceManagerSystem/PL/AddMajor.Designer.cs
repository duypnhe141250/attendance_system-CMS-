
namespace AttendanceManagerSystem.PL
{
    partial class AddMajor
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
            this.txtMajorID = new System.Windows.Forms.TextBox();
            this.txtMajorName = new System.Windows.Forms.TextBox();
            this.btnAddMajor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD MAJOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Major ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Major Name:";
            // 
            // txtMajorID
            // 
            this.txtMajorID.Location = new System.Drawing.Point(105, 67);
            this.txtMajorID.Name = "txtMajorID";
            this.txtMajorID.Size = new System.Drawing.Size(160, 20);
            this.txtMajorID.TabIndex = 3;
            // 
            // txtMajorName
            // 
            this.txtMajorName.Location = new System.Drawing.Point(105, 106);
            this.txtMajorName.Name = "txtMajorName";
            this.txtMajorName.Size = new System.Drawing.Size(160, 20);
            this.txtMajorName.TabIndex = 4;
            // 
            // btnAddMajor
            // 
            this.btnAddMajor.Location = new System.Drawing.Point(129, 149);
            this.btnAddMajor.Name = "btnAddMajor";
            this.btnAddMajor.Size = new System.Drawing.Size(75, 23);
            this.btnAddMajor.TabIndex = 5;
            this.btnAddMajor.Text = "Add";
            this.btnAddMajor.UseVisualStyleBackColor = true;
            this.btnAddMajor.Click += new System.EventHandler(this.btnAddMajor_Click);
            // 
            // AddMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 207);
            this.Controls.Add(this.btnAddMajor);
            this.Controls.Add(this.txtMajorName);
            this.Controls.Add(this.txtMajorID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMajor";
            this.Text = "AddMajor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMajorID;
        private System.Windows.Forms.TextBox txtMajorName;
        private System.Windows.Forms.Button btnAddMajor;
    }
}