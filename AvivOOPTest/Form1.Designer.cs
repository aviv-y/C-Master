namespace AvivOOPTest
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAns1 = new System.Windows.Forms.Button();
            this.btnAns2 = new System.Windows.Forms.Button();
            this.btnAns3 = new System.Windows.Forms.Button();
            this.btnAns4 = new System.Windows.Forms.Button();
            this.btnAns6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.Location = new System.Drawing.Point(42, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "OOP Test - Answers";
            // 
            // btnAns1
            // 
            this.btnAns1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAns1.Location = new System.Drawing.Point(42, 98);
            this.btnAns1.Name = "btnAns1";
            this.btnAns1.Size = new System.Drawing.Size(109, 53);
            this.btnAns1.TabIndex = 1;
            this.btnAns1.Text = "Answer #1";
            this.btnAns1.UseVisualStyleBackColor = false;
            this.btnAns1.Click += new System.EventHandler(this.btnAns1_Click);
            // 
            // btnAns2
            // 
            this.btnAns2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAns2.Location = new System.Drawing.Point(42, 193);
            this.btnAns2.Name = "btnAns2";
            this.btnAns2.Size = new System.Drawing.Size(109, 53);
            this.btnAns2.TabIndex = 2;
            this.btnAns2.Text = "Answer #2";
            this.btnAns2.UseVisualStyleBackColor = false;
            this.btnAns2.Click += new System.EventHandler(this.btnAns2_Click);
            // 
            // btnAns3
            // 
            this.btnAns3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAns3.Location = new System.Drawing.Point(42, 292);
            this.btnAns3.Name = "btnAns3";
            this.btnAns3.Size = new System.Drawing.Size(109, 53);
            this.btnAns3.TabIndex = 3;
            this.btnAns3.Text = "Answer #3";
            this.btnAns3.UseVisualStyleBackColor = false;
            this.btnAns3.Click += new System.EventHandler(this.btnAns3_Click);
            // 
            // btnAns4
            // 
            this.btnAns4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAns4.Location = new System.Drawing.Point(198, 98);
            this.btnAns4.Name = "btnAns4";
            this.btnAns4.Size = new System.Drawing.Size(109, 53);
            this.btnAns4.TabIndex = 4;
            this.btnAns4.Text = "Answer #4";
            this.btnAns4.UseVisualStyleBackColor = false;
            this.btnAns4.Click += new System.EventHandler(this.btnAns4_Click);
            // 
            // btnAns6
            // 
            this.btnAns6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAns6.Location = new System.Drawing.Point(198, 193);
            this.btnAns6.Name = "btnAns6";
            this.btnAns6.Size = new System.Drawing.Size(109, 53);
            this.btnAns6.TabIndex = 5;
            this.btnAns6.Text = "Answer #6";
            this.btnAns6.UseVisualStyleBackColor = false;
            this.btnAns6.Click += new System.EventHandler(this.btnAns6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.btnAns6);
            this.Controls.Add(this.btnAns4);
            this.Controls.Add(this.btnAns3);
            this.Controls.Add(this.btnAns2);
            this.Controls.Add(this.btnAns1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAns1;
        private System.Windows.Forms.Button btnAns2;
        private System.Windows.Forms.Button btnAns3;
        private System.Windows.Forms.Button btnAns4;
        private System.Windows.Forms.Button btnAns6;
    }
}

