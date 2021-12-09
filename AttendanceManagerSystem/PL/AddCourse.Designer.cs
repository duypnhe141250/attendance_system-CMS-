
namespace AttendanceManagerSystem
{
    partial class AddCourse
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubjectID = new System.Windows.Forms.TextBox();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teacher ID:";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(200, 46);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(193, 20);
            this.txtCourseID.TabIndex = 3;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(200, 101);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(193, 20);
            this.txtClass.TabIndex = 4;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(226, 266);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(75, 23);
            this.btnAddCourse.TabIndex = 6;
            this.btnAddCourse.Text = "Add";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subject ID:";
            // 
            // txtSubjectID
            // 
            this.txtSubjectID.Location = new System.Drawing.Point(200, 142);
            this.txtSubjectID.Name = "txtSubjectID";
            this.txtSubjectID.Size = new System.Drawing.Size(193, 20);
            this.txtSubjectID.TabIndex = 8;
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Location = new System.Drawing.Point(200, 189);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(193, 20);
            this.txtTeacherID.TabIndex = 9;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 310);
            this.Controls.Add(this.txtTeacherID);
            this.Controls.Add(this.txtSubjectID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCourse";
            this.Text = "Add course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubjectID;
        private System.Windows.Forms.TextBox txtTeacherID;
    }
}