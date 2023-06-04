namespace Alarm.GUI
{
    partial class frmAdmin
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
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.dgv_User = new System.Windows.Forms.DataGridView();
            this.btnDeleteSound = new System.Windows.Forms.Button();
            this.dgv_Sound = new System.Windows.Forms.DataGridView();
            this.btnAddSound = new System.Windows.Forms.Button();
            this.cbbSortUser = new System.Windows.Forms.ComboBox();
            this.cbbSortSound = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSort1 = new System.Windows.Forms.Button();
            this.btnSort2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sound)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(55, 323);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(131, 51);
            this.btnDeleteUser.TabIndex = 0;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // dgv_User
            // 
            this.dgv_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_User.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_User.Location = new System.Drawing.Point(55, 70);
            this.dgv_User.Name = "dgv_User";
            this.dgv_User.RowHeadersWidth = 51;
            this.dgv_User.RowTemplate.Height = 24;
            this.dgv_User.Size = new System.Drawing.Size(877, 220);
            this.dgv_User.TabIndex = 1;
            // 
            // btnDeleteSound
            // 
            this.btnDeleteSound.Location = new System.Drawing.Point(369, 700);
            this.btnDeleteSound.Name = "btnDeleteSound";
            this.btnDeleteSound.Size = new System.Drawing.Size(131, 51);
            this.btnDeleteSound.TabIndex = 2;
            this.btnDeleteSound.Text = "Delete";
            this.btnDeleteSound.UseVisualStyleBackColor = true;
            // 
            // dgv_Sound
            // 
            this.dgv_Sound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Sound.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv_Sound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sound.Location = new System.Drawing.Point(55, 448);
            this.dgv_Sound.Name = "dgv_Sound";
            this.dgv_Sound.RowHeadersWidth = 51;
            this.dgv_Sound.RowTemplate.Height = 24;
            this.dgv_Sound.Size = new System.Drawing.Size(877, 220);
            this.dgv_Sound.TabIndex = 3;
            // 
            // btnAddSound
            // 
            this.btnAddSound.Location = new System.Drawing.Point(55, 700);
            this.btnAddSound.Name = "btnAddSound";
            this.btnAddSound.Size = new System.Drawing.Size(131, 51);
            this.btnAddSound.TabIndex = 4;
            this.btnAddSound.Text = "Add";
            this.btnAddSound.UseVisualStyleBackColor = true;
            this.btnAddSound.Click += new System.EventHandler(this.btnAddSound_Click);
            // 
            // cbbSortUser
            // 
            this.cbbSortUser.FormattingEnabled = true;
            this.cbbSortUser.ItemHeight = 27;
            this.cbbSortUser.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cbbSortUser.Location = new System.Drawing.Point(686, 323);
            this.cbbSortUser.Name = "cbbSortUser";
            this.cbbSortUser.Size = new System.Drawing.Size(246, 35);
            this.cbbSortUser.TabIndex = 5;
            // 
            // cbbSortSound
            // 
            this.cbbSortSound.FormattingEnabled = true;
            this.cbbSortSound.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cbbSortSound.Location = new System.Drawing.Point(686, 700);
            this.cbbSortSound.Name = "cbbSortSound";
            this.cbbSortSound.Size = new System.Drawing.Size(246, 35);
            this.cbbSortSound.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 700);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSort1
            // 
            this.btnSort1.Location = new System.Drawing.Point(531, 323);
            this.btnSort1.Name = "btnSort1";
            this.btnSort1.Size = new System.Drawing.Size(131, 51);
            this.btnSort1.TabIndex = 8;
            this.btnSort1.Text = "Sort";
            this.btnSort1.UseVisualStyleBackColor = true;
            this.btnSort1.Click += new System.EventHandler(this.btnSort1_Click);
            // 
            // btnSort2
            // 
            this.btnSort2.Location = new System.Drawing.Point(531, 700);
            this.btnSort2.Name = "btnSort2";
            this.btnSort2.Size = new System.Drawing.Size(131, 51);
            this.btnSort2.TabIndex = 9;
            this.btnSort2.Text = "Sort";
            this.btnSort2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "List Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "List Sounds";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(992, 784);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSort2);
            this.Controls.Add(this.btnSort1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbSortSound);
            this.Controls.Add(this.cbbSortUser);
            this.Controls.Add(this.btnAddSound);
            this.Controls.Add(this.dgv_Sound);
            this.Controls.Add(this.btnDeleteSound);
            this.Controls.Add(this.dgv_User);
            this.Controls.Add(this.btnDeleteUser);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.DataGridView dgv_User;
        private System.Windows.Forms.Button btnDeleteSound;
        private System.Windows.Forms.DataGridView dgv_Sound;
        private System.Windows.Forms.Button btnAddSound;
        private System.Windows.Forms.ComboBox cbbSortUser;
        private System.Windows.Forms.ComboBox cbbSortSound;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSort1;
        private System.Windows.Forms.Button btnSort2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}