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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddSound = new System.Windows.Forms.Button();
            this.cbbSortUser = new System.Windows.Forms.ComboBox();
            this.cbbSortSound = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSort1 = new System.Windows.Forms.Button();
            this.btnSort2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(55, 291);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(131, 51);
            this.btnDeleteUser.TabIndex = 0;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // dgv_User
            // 
            this.dgv_User.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_User.Location = new System.Drawing.Point(55, 38);
            this.dgv_User.Name = "dgv_User";
            this.dgv_User.RowHeadersWidth = 51;
            this.dgv_User.RowTemplate.Height = 24;
            this.dgv_User.Size = new System.Drawing.Size(877, 220);
            this.dgv_User.TabIndex = 1;
            // 
            // btnDeleteSound
            // 
            this.btnDeleteSound.Location = new System.Drawing.Point(369, 634);
            this.btnDeleteSound.Name = "btnDeleteSound";
            this.btnDeleteSound.Size = new System.Drawing.Size(131, 51);
            this.btnDeleteSound.TabIndex = 2;
            this.btnDeleteSound.Text = "Delete";
            this.btnDeleteSound.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(877, 220);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnAddSound
            // 
            this.btnAddSound.Location = new System.Drawing.Point(55, 634);
            this.btnAddSound.Name = "btnAddSound";
            this.btnAddSound.Size = new System.Drawing.Size(131, 51);
            this.btnAddSound.TabIndex = 4;
            this.btnAddSound.Text = "Add";
            this.btnAddSound.UseVisualStyleBackColor = true;
            // 
            // cbbSortUser
            // 
            this.cbbSortUser.FormattingEnabled = true;
            this.cbbSortUser.ItemHeight = 27;
            this.cbbSortUser.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cbbSortUser.Location = new System.Drawing.Point(686, 291);
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
            this.cbbSortSound.Location = new System.Drawing.Point(686, 634);
            this.cbbSortSound.Name = "cbbSortSound";
            this.cbbSortSound.Size = new System.Drawing.Size(246, 35);
            this.cbbSortSound.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSort1
            // 
            this.btnSort1.Location = new System.Drawing.Point(531, 291);
            this.btnSort1.Name = "btnSort1";
            this.btnSort1.Size = new System.Drawing.Size(131, 51);
            this.btnSort1.TabIndex = 8;
            this.btnSort1.Text = "Delete";
            this.btnSort1.UseVisualStyleBackColor = true;
            // 
            // btnSort2
            // 
            this.btnSort2.Location = new System.Drawing.Point(531, 634);
            this.btnSort2.Name = "btnSort2";
            this.btnSort2.Size = new System.Drawing.Size(131, 51);
            this.btnSort2.TabIndex = 9;
            this.btnSort2.Text = "Delete";
            this.btnSort2.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(989, 708);
            this.Controls.Add(this.btnSort2);
            this.Controls.Add(this.btnSort1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbSortSound);
            this.Controls.Add(this.cbbSortUser);
            this.Controls.Add(this.btnAddSound);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteSound);
            this.Controls.Add(this.dgv_User);
            this.Controls.Add(this.btnDeleteUser);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.DataGridView dgv_User;
        private System.Windows.Forms.Button btnDeleteSound;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddSound;
        private System.Windows.Forms.ComboBox cbbSortUser;
        private System.Windows.Forms.ComboBox cbbSortSound;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSort1;
        private System.Windows.Forms.Button btnSort2;
    }
}