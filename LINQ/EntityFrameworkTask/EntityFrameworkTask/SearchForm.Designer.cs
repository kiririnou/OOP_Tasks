namespace EntityFrameworkTask
{
    partial class SearchForm
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
            this.lb_searchBy = new System.Windows.Forms.Label();
            this.cb_fullname = new System.Windows.Forms.CheckBox();
            this.cb_gender = new System.Windows.Forms.CheckBox();
            this.cb_birthday = new System.Windows.Forms.CheckBox();
            this.tb_fullname = new System.Windows.Forms.TextBox();
            this.tb_gender = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.cb_match = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lb_searchBy
            // 
            this.lb_searchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_searchBy.Location = new System.Drawing.Point(12, 9);
            this.lb_searchBy.Name = "lb_searchBy";
            this.lb_searchBy.Size = new System.Drawing.Size(80, 23);
            this.lb_searchBy.TabIndex = 0;
            this.lb_searchBy.Text = "Search by:";
            this.lb_searchBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_fullname
            // 
            this.cb_fullname.AutoSize = true;
            this.cb_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_fullname.Location = new System.Drawing.Point(15, 35);
            this.cb_fullname.Name = "cb_fullname";
            this.cb_fullname.Size = new System.Drawing.Size(78, 19);
            this.cb_fullname.TabIndex = 1;
            this.cb_fullname.Text = "Fullname";
            this.cb_fullname.UseVisualStyleBackColor = true;
            // 
            // cb_gender
            // 
            this.cb_gender.AutoSize = true;
            this.cb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gender.Location = new System.Drawing.Point(15, 72);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(67, 19);
            this.cb_gender.TabIndex = 2;
            this.cb_gender.Text = "Gender";
            this.cb_gender.UseVisualStyleBackColor = true;
            // 
            // cb_birthday
            // 
            this.cb_birthday.AutoSize = true;
            this.cb_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_birthday.Location = new System.Drawing.Point(15, 112);
            this.cb_birthday.Name = "cb_birthday";
            this.cb_birthday.Size = new System.Drawing.Size(70, 19);
            this.cb_birthday.TabIndex = 3;
            this.cb_birthday.Text = "Birthday";
            this.cb_birthday.UseVisualStyleBackColor = true;
            // 
            // tb_fullname
            // 
            this.tb_fullname.Location = new System.Drawing.Point(100, 35);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(172, 20);
            this.tb_fullname.TabIndex = 4;
            // 
            // tb_gender
            // 
            this.tb_gender.Location = new System.Drawing.Point(100, 72);
            this.tb_gender.Name = "tb_gender";
            this.tb_gender.Size = new System.Drawing.Size(172, 20);
            this.tb_gender.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(12, 209);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(260, 40);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Location = new System.Drawing.Point(100, 109);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(172, 20);
            this.dtp_birthday.TabIndex = 10;
            // 
            // cb_match
            // 
            this.cb_match.AutoSize = true;
            this.cb_match.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_match.Location = new System.Drawing.Point(15, 150);
            this.cb_match.Name = "cb_match";
            this.cb_match.Size = new System.Drawing.Size(101, 19);
            this.cb_match.TabIndex = 11;
            this.cb_match.Text = "Exactly match";
            this.cb_match.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cb_match);
            this.Controls.Add(this.dtp_birthday);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_gender);
            this.Controls.Add(this.tb_fullname);
            this.Controls.Add(this.cb_birthday);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.cb_fullname);
            this.Controls.Add(this.lb_searchBy);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_searchBy;
        private System.Windows.Forms.CheckBox cb_fullname;
        private System.Windows.Forms.CheckBox cb_gender;
        private System.Windows.Forms.CheckBox cb_birthday;
        private System.Windows.Forms.TextBox tb_fullname;
        private System.Windows.Forms.TextBox tb_gender;
        protected internal System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.CheckBox cb_match;
    }
}