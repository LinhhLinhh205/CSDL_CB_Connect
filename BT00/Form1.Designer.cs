
namespace BT00
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
            this.btnAccess2003 = new System.Windows.Forms.Button();
            this.btnAccess2019 = new System.Windows.Forms.Button();
            this.btnSqlWin = new System.Windows.Forms.Button();
            this.btnSqlsa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccess2003
            // 
            this.btnAccess2003.Location = new System.Drawing.Point(31, 27);
            this.btnAccess2003.Name = "btnAccess2003";
            this.btnAccess2003.Size = new System.Drawing.Size(100, 40);
            this.btnAccess2003.TabIndex = 0;
            this.btnAccess2003.Text = "Access 2003";
            this.btnAccess2003.UseVisualStyleBackColor = true;
            this.btnAccess2003.Click += new System.EventHandler(this.btnAccess2003_Click);
            // 
            // btnAccess2019
            // 
            this.btnAccess2019.Location = new System.Drawing.Point(136, 27);
            this.btnAccess2019.Name = "btnAccess2019";
            this.btnAccess2019.Size = new System.Drawing.Size(100, 40);
            this.btnAccess2019.TabIndex = 1;
            this.btnAccess2019.Text = "Access 2019";
            this.btnAccess2019.UseVisualStyleBackColor = true;
            this.btnAccess2019.Click += new System.EventHandler(this.btnAccess2019_Click);
            // 
            // btnSqlWin
            // 
            this.btnSqlWin.Location = new System.Drawing.Point(241, 27);
            this.btnSqlWin.Name = "btnSqlWin";
            this.btnSqlWin.Size = new System.Drawing.Size(100, 40);
            this.btnSqlWin.TabIndex = 2;
            this.btnSqlWin.Text = "SQL Windows";
            this.btnSqlWin.UseVisualStyleBackColor = true;
            this.btnSqlWin.Click += new System.EventHandler(this.btnSqlWin_Click);
            // 
            // btnSqlsa
            // 
            this.btnSqlsa.Location = new System.Drawing.Point(346, 27);
            this.btnSqlsa.Name = "btnSqlsa";
            this.btnSqlsa.Size = new System.Drawing.Size(100, 40);
            this.btnSqlsa.TabIndex = 3;
            this.btnSqlsa.Text = "SQL sa";
            this.btnSqlsa.UseVisualStyleBackColor = true;
            this.btnSqlsa.Click += new System.EventHandler(this.btnSqlsa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 100);
            this.Controls.Add(this.btnSqlsa);
            this.Controls.Add(this.btnSqlWin);
            this.Controls.Add(this.btnAccess2019);
            this.Controls.Add(this.btnAccess2003);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Kết nối CSDL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccess2003;
        private System.Windows.Forms.Button btnAccess2019;
        private System.Windows.Forms.Button btnSqlWin;
        private System.Windows.Forms.Button btnSqlsa;
    }
}

