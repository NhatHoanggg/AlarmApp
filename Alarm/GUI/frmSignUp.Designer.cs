namespace Alarm.GUI
{
    partial class frmSignUp
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
            this.txtUsername_reg = new System.Windows.Forms.TextBox();
            this.txtPw_res = new System.Windows.Forms.TextBox();
            this.txtValidate = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Validate Password";
            // 
            // txtUsername_reg
            // 
            this.txtUsername_reg.Location = new System.Drawing.Point(341, 91);
            this.txtUsername_reg.Name = "txtUsername_reg";
            this.txtUsername_reg.Size = new System.Drawing.Size(349, 36);
            this.txtUsername_reg.TabIndex = 3;
            this.txtUsername_reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUsername_reg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_reg_KeyDown);
            // 
            // txtPw_res
            // 
            this.txtPw_res.Location = new System.Drawing.Point(341, 178);
            this.txtPw_res.Name = "txtPw_res";
            this.txtPw_res.PasswordChar = '•';
            this.txtPw_res.Size = new System.Drawing.Size(349, 36);
            this.txtPw_res.TabIndex = 4;
            this.txtPw_res.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPw_res.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPw_res_KeyDown);
            // 
            // txtValidate
            // 
            this.txtValidate.Location = new System.Drawing.Point(341, 286);
            this.txtValidate.Name = "txtValidate";
            this.txtValidate.PasswordChar = '•';
            this.txtValidate.Size = new System.Drawing.Size(349, 36);
            this.txtValidate.TabIndex = 5;
            this.txtValidate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValidate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValidate_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(132, 384);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(190, 57);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(426, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 57);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(744, 499);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtValidate);
            this.Controls.Add(this.txtPw_res);
            this.Controls.Add(this.txtUsername_reg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmSignUp";
            this.Text = "frmSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername_reg;
        private System.Windows.Forms.TextBox txtPw_res;
        private System.Windows.Forms.TextBox txtValidate;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}