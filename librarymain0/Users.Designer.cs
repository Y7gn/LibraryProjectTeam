
namespace librarymain0
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.UserGdv = new Guna.UI.WinForms.GunaDataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.ResetBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SaveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UPassTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UAddressTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UPhoneTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UnameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserGdv)).BeginInit();
            this.SuspendLayout();
            // 
            // UserGdv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.UserGdv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserGdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserGdv.BackgroundColor = System.Drawing.Color.White;
            this.UserGdv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserGdv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserGdv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserGdv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserGdv.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserGdv.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserGdv.EnableHeadersVisualStyles = false;
            this.UserGdv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserGdv.Location = new System.Drawing.Point(9, 211);
            this.UserGdv.Name = "UserGdv";
            this.UserGdv.RowHeadersVisible = false;
            this.UserGdv.RowHeadersWidth = 51;
            this.UserGdv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserGdv.Size = new System.Drawing.Size(782, 216);
            this.UserGdv.TabIndex = 55;
            this.UserGdv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.UserGdv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.UserGdv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UserGdv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UserGdv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UserGdv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UserGdv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UserGdv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserGdv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UserGdv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UserGdv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.UserGdv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UserGdv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UserGdv.ThemeStyle.HeaderStyle.Height = 4;
            this.UserGdv.ThemeStyle.ReadOnly = false;
            this.UserGdv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UserGdv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserGdv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.UserGdv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UserGdv.ThemeStyle.RowsStyle.Height = 22;
            this.UserGdv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserGdv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UserGdv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserGdv_CellClick);
            this.UserGdv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserGdv_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label7.Location = new System.Drawing.Point(339, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Users List";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.ActiveBorderThickness = 1;
            this.ResetBtn.ActiveCornerRadius = 20;
            this.ResetBtn.ActiveFillColor = System.Drawing.SystemColors.Control;
            this.ResetBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.ResetBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.ResetBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ResetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetBtn.BackgroundImage")));
            this.ResetBtn.ButtonText = "Reset";
            this.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.ResetBtn.IdleBorderThickness = 1;
            this.ResetBtn.IdleCornerRadius = 30;
            this.ResetBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.ResetBtn.IdleForecolor = System.Drawing.SystemColors.Control;
            this.ResetBtn.IdleLineColor = System.Drawing.SystemColors.Control;
            this.ResetBtn.Location = new System.Drawing.Point(454, 110);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(88, 41);
            this.ResetBtn.TabIndex = 51;
            this.ResetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.ActiveBorderThickness = 1;
            this.DeleteBtn.ActiveCornerRadius = 20;
            this.DeleteBtn.ActiveFillColor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.DeleteBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.ButtonText = "Delete";
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.DeleteBtn.IdleBorderThickness = 1;
            this.DeleteBtn.IdleCornerRadius = 30;
            this.DeleteBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.DeleteBtn.IdleForecolor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.IdleLineColor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.Location = new System.Drawing.Point(360, 110);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(88, 41);
            this.DeleteBtn.TabIndex = 50;
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.ActiveBorderThickness = 1;
            this.EditBtn.ActiveCornerRadius = 20;
            this.EditBtn.ActiveFillColor = System.Drawing.SystemColors.Control;
            this.EditBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.EditBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.EditBtn.BackColor = System.Drawing.SystemColors.Control;
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.ButtonText = "Edit";
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.EditBtn.IdleBorderThickness = 1;
            this.EditBtn.IdleCornerRadius = 30;
            this.EditBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.EditBtn.IdleForecolor = System.Drawing.SystemColors.Control;
            this.EditBtn.IdleLineColor = System.Drawing.SystemColors.Control;
            this.EditBtn.Location = new System.Drawing.Point(265, 110);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(88, 41);
            this.EditBtn.TabIndex = 49;
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.ActiveBorderThickness = 1;
            this.SaveBtn.ActiveCornerRadius = 20;
            this.SaveBtn.ActiveFillColor = System.Drawing.SystemColors.Control;
            this.SaveBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.SaveBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.SaveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.ButtonText = "Save";
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.SaveBtn.IdleBorderThickness = 1;
            this.SaveBtn.IdleCornerRadius = 30;
            this.SaveBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.SaveBtn.IdleForecolor = System.Drawing.SystemColors.Control;
            this.SaveBtn.IdleLineColor = System.Drawing.SystemColors.Control;
            this.SaveBtn.Location = new System.Drawing.Point(171, 110);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(88, 41);
            this.SaveBtn.TabIndex = 48;
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UPassTb
            // 
            this.UPassTb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPassTb.Location = new System.Drawing.Point(629, 43);
            this.UPassTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UPassTb.Multiline = true;
            this.UPassTb.Name = "UPassTb";
            this.UPassTb.Size = new System.Drawing.Size(138, 25);
            this.UPassTb.TabIndex = 47;
            this.UPassTb.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(627, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Password";
            // 
            // UAddressTb
            // 
            this.UAddressTb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UAddressTb.Location = new System.Drawing.Point(476, 43);
            this.UAddressTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UAddressTb.Multiline = true;
            this.UAddressTb.Name = "UAddressTb";
            this.UAddressTb.Size = new System.Drawing.Size(138, 25);
            this.UAddressTb.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(472, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Address";
            // 
            // UPhoneTb
            // 
            this.UPhoneTb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPhoneTb.Location = new System.Drawing.Point(169, 43);
            this.UPhoneTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UPhoneTb.Multiline = true;
            this.UPhoneTb.Name = "UPhoneTb";
            this.UPhoneTb.Size = new System.Drawing.Size(138, 25);
            this.UPhoneTb.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Phone";
            // 
            // UnameTb
            // 
            this.UnameTb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnameTb.Location = new System.Drawing.Point(17, 43);
            this.UnameTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnameTb.Multiline = true;
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.Size = new System.Drawing.Size(138, 25);
            this.UnameTb.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Username";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserGdv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.UPassTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UAddressTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UPhoneTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UnameTb);
            this.Controls.Add(this.label2);
            this.Name = "Users";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.UserGdv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView UserGdv;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveBtn;
        private System.Windows.Forms.TextBox UPassTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UAddressTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UPhoneTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UnameTb;
        private System.Windows.Forms.Label label2;
    }
}