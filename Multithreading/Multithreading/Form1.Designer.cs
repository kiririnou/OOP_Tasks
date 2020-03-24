namespace Multithreading
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_startThread = new System.Windows.Forms.Button();
            this.btn_stopThread = new System.Windows.Forms.Button();
            this.btn_CallMethod = new System.Windows.Forms.Button();
            this.btn_parametrized = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_parametrized);
            this.panel2.Controls.Add(this.btn_CallMethod);
            this.panel2.Controls.Add(this.btn_stopThread);
            this.panel2.Controls.Add(this.btn_startThread);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 237);
            this.panel2.TabIndex = 1;
            // 
            // btn_startThread
            // 
            this.btn_startThread.Location = new System.Drawing.Point(77, 3);
            this.btn_startThread.Name = "btn_startThread";
            this.btn_startThread.Size = new System.Drawing.Size(102, 23);
            this.btn_startThread.TabIndex = 0;
            this.btn_startThread.Text = "Start thread";
            this.btn_startThread.UseVisualStyleBackColor = true;
            this.btn_startThread.Click += new System.EventHandler(this.btn_startThread_Click);
            // 
            // btn_stopThread
            // 
            this.btn_stopThread.Location = new System.Drawing.Point(77, 67);
            this.btn_stopThread.Name = "btn_stopThread";
            this.btn_stopThread.Size = new System.Drawing.Size(102, 23);
            this.btn_stopThread.TabIndex = 1;
            this.btn_stopThread.Text = "Stop thread";
            this.btn_stopThread.UseVisualStyleBackColor = true;
            this.btn_stopThread.Click += new System.EventHandler(this.btn_stopThread_Click);
            // 
            // btn_CallMethod
            // 
            this.btn_CallMethod.Location = new System.Drawing.Point(77, 131);
            this.btn_CallMethod.Name = "btn_CallMethod";
            this.btn_CallMethod.Size = new System.Drawing.Size(102, 23);
            this.btn_CallMethod.TabIndex = 2;
            this.btn_CallMethod.Text = "Call method";
            this.btn_CallMethod.UseVisualStyleBackColor = true;
            this.btn_CallMethod.Click += new System.EventHandler(this.btn_CallMethod_Click);
            // 
            // btn_parametrized
            // 
            this.btn_parametrized.Location = new System.Drawing.Point(77, 195);
            this.btn_parametrized.Name = "btn_parametrized";
            this.btn_parametrized.Size = new System.Drawing.Size(102, 23);
            this.btn_parametrized.TabIndex = 3;
            this.btn_parametrized.Text = "Parametrized";
            this.btn_parametrized.UseVisualStyleBackColor = true;
            this.btn_parametrized.Click += new System.EventHandler(this.btn_parametrized_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_CallMethod;
        private System.Windows.Forms.Button btn_stopThread;
        private System.Windows.Forms.Button btn_startThread;
        private System.Windows.Forms.Button btn_parametrized;
    }
}

