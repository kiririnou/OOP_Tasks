namespace EntityFrameworkTask
{
    partial class SortSelectionForm
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
            this.rbtn_fullname = new System.Windows.Forms.RadioButton();
            this.lb_sortBy = new System.Windows.Forms.Label();
            this.rbtn_gender = new System.Windows.Forms.RadioButton();
            this.rbtn_birthday = new System.Windows.Forms.RadioButton();
            this.btn_sort = new System.Windows.Forms.Button();
            this.rbtn_none = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbtn_fullname
            // 
            this.rbtn_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_fullname.Location = new System.Drawing.Point(16, 35);
            this.rbtn_fullname.Name = "rbtn_fullname";
            this.rbtn_fullname.Size = new System.Drawing.Size(104, 24);
            this.rbtn_fullname.TabIndex = 0;
            this.rbtn_fullname.TabStop = true;
            this.rbtn_fullname.Text = "Fullname";
            this.rbtn_fullname.UseVisualStyleBackColor = true;
            // 
            // lb_sortBy
            // 
            this.lb_sortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sortBy.Location = new System.Drawing.Point(12, 9);
            this.lb_sortBy.Name = "lb_sortBy";
            this.lb_sortBy.Size = new System.Drawing.Size(84, 23);
            this.lb_sortBy.TabIndex = 1;
            this.lb_sortBy.Text = "Sort by:";
            this.lb_sortBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbtn_gender
            // 
            this.rbtn_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_gender.Location = new System.Drawing.Point(16, 65);
            this.rbtn_gender.Name = "rbtn_gender";
            this.rbtn_gender.Size = new System.Drawing.Size(104, 24);
            this.rbtn_gender.TabIndex = 2;
            this.rbtn_gender.TabStop = true;
            this.rbtn_gender.Text = "Gender";
            this.rbtn_gender.UseVisualStyleBackColor = true;
            // 
            // rbtn_birthday
            // 
            this.rbtn_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_birthday.Location = new System.Drawing.Point(16, 95);
            this.rbtn_birthday.Name = "rbtn_birthday";
            this.rbtn_birthday.Size = new System.Drawing.Size(104, 24);
            this.rbtn_birthday.TabIndex = 3;
            this.rbtn_birthday.TabStop = true;
            this.rbtn_birthday.Text = "Birthday";
            this.rbtn_birthday.UseVisualStyleBackColor = true;
            // 
            // btn_sort
            // 
            this.btn_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sort.Location = new System.Drawing.Point(12, 159);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(210, 40);
            this.btn_sort.TabIndex = 9;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // rbtn_none
            // 
            this.rbtn_none.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_none.Location = new System.Drawing.Point(16, 125);
            this.rbtn_none.Name = "rbtn_none";
            this.rbtn_none.Size = new System.Drawing.Size(104, 24);
            this.rbtn_none.TabIndex = 10;
            this.rbtn_none.TabStop = true;
            this.rbtn_none.Text = "None";
            this.rbtn_none.UseVisualStyleBackColor = true;
            // 
            // SortSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.rbtn_none);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.rbtn_birthday);
            this.Controls.Add(this.rbtn_gender);
            this.Controls.Add(this.lb_sortBy);
            this.Controls.Add(this.rbtn_fullname);
            this.Name = "SortSelectionForm";
            this.Text = "SortSelectionForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_sortBy;
        protected internal System.Windows.Forms.Button btn_sort;
        protected internal System.Windows.Forms.RadioButton rbtn_fullname;
        protected internal System.Windows.Forms.RadioButton rbtn_gender;
        protected internal System.Windows.Forms.RadioButton rbtn_birthday;
        protected internal System.Windows.Forms.RadioButton rbtn_none;
    }
}