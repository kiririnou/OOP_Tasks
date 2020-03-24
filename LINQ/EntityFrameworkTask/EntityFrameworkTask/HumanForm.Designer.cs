namespace EntityFrameworkTask
{
    partial class HumanForm
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
            this.lb_firstname = new System.Windows.Forms.Label();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.lb_lastname = new System.Windows.Forms.Label();
            this.tb_gender = new System.Windows.Forms.TextBox();
            this.lb_gender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_firstname
            // 
            this.lb_firstname.Location = new System.Drawing.Point(12, 9);
            this.lb_firstname.Name = "lb_firstname";
            this.lb_firstname.Size = new System.Drawing.Size(75, 23);
            this.lb_firstname.TabIndex = 0;
            this.lb_firstname.Text = "Firstname:";
            this.lb_firstname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(93, 11);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(179, 20);
            this.tb_firstname.TabIndex = 1;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(93, 51);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(179, 20);
            this.tb_lastname.TabIndex = 3;
            // 
            // lb_lastname
            // 
            this.lb_lastname.Location = new System.Drawing.Point(12, 49);
            this.lb_lastname.Name = "lb_lastname";
            this.lb_lastname.Size = new System.Drawing.Size(75, 23);
            this.lb_lastname.TabIndex = 2;
            this.lb_lastname.Text = "Lastname:";
            this.lb_lastname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_gender
            // 
            this.tb_gender.Location = new System.Drawing.Point(93, 91);
            this.tb_gender.Name = "tb_gender";
            this.tb_gender.Size = new System.Drawing.Size(179, 20);
            this.tb_gender.TabIndex = 5;
            // 
            // lb_gender
            // 
            this.lb_gender.Location = new System.Drawing.Point(12, 89);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(75, 23);
            this.lb_gender.TabIndex = 4;
            this.lb_gender.Text = "Gender:";
            this.lb_gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birthday:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.CustomFormat = "";
            this.dtp_birthday.Location = new System.Drawing.Point(93, 131);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(179, 20);
            this.dtp_birthday.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(15, 209);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(257, 40);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add human";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // HumanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dtp_birthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_gender);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.tb_lastname);
            this.Controls.Add(this.lb_lastname);
            this.Controls.Add(this.tb_firstname);
            this.Controls.Add(this.lb_firstname);
            this.Name = "HumanForm";
            this.Text = "HumanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_firstname;
        private System.Windows.Forms.Label lb_lastname;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.TextBox tb_firstname;
        protected internal System.Windows.Forms.TextBox tb_lastname;
        protected internal System.Windows.Forms.TextBox tb_gender;
        protected internal System.Windows.Forms.DateTimePicker dtp_birthday;
        protected internal System.Windows.Forms.Button btn_add;
    }
}