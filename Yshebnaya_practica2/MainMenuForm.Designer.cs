namespace Yshebnaya_practica2
{
    partial class MainMenuForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbPrice = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChangeAdmin = new System.Windows.Forms.Button();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.btnAddDishAdmin = new System.Windows.Forms.Button();
            this.FLPdishes = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.cbFilter);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 124);
            this.panel1.TabIndex = 0;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(18, 86);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(194, 24);
            this.cbFilter.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.rbPrice);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(545, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 63);
            this.panel3.TabIndex = 10;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(144, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 20);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Времени";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbPrice
            // 
            this.rbPrice.AutoSize = true;
            this.rbPrice.Location = new System.Drawing.Point(26, 30);
            this.rbPrice.Name = "rbPrice";
            this.rbPrice.Size = new System.Drawing.Size(61, 20);
            this.rbPrice.TabIndex = 5;
            this.rbPrice.TabStop = true;
            this.rbPrice.Text = "Цене";
            this.rbPrice.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сортировка по:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Фильтр по категории:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Cursor = System.Windows.Forms.Cursors.No;
            this.lblRole.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRole.Location = new System.Drawing.Point(12, 9);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(355, 35);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Здравствуйте, \"имя\" (роль)";
            this.lblRole.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(541, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(608, 86);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(141, 23);
            this.txtSearch.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(232)))));
            this.panel2.Controls.Add(this.btnChangeAdmin);
            this.panel2.Controls.Add(this.btnDeleteAdmin);
            this.panel2.Controls.Add(this.btnAddDishAdmin);
            this.panel2.Location = new System.Drawing.Point(0, 448);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 123);
            this.panel2.TabIndex = 1;
            // 
            // btnChangeAdmin
            // 
            this.btnChangeAdmin.Location = new System.Drawing.Point(176, 66);
            this.btnChangeAdmin.Name = "btnChangeAdmin";
            this.btnChangeAdmin.Size = new System.Drawing.Size(147, 44);
            this.btnChangeAdmin.TabIndex = 2;
            this.btnChangeAdmin.Text = "Изменить блюдо";
            this.btnChangeAdmin.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.Location = new System.Drawing.Point(372, 66);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(147, 44);
            this.btnDeleteAdmin.TabIndex = 1;
            this.btnDeleteAdmin.Text = "Удалить блюдо";
            this.btnDeleteAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAddDishAdmin
            // 
            this.btnAddDishAdmin.Location = new System.Drawing.Point(12, 66);
            this.btnAddDishAdmin.Name = "btnAddDishAdmin";
            this.btnAddDishAdmin.Size = new System.Drawing.Size(147, 44);
            this.btnAddDishAdmin.TabIndex = 0;
            this.btnAddDishAdmin.Text = "Добавить блюдо";
            this.btnAddDishAdmin.UseVisualStyleBackColor = true;
            this.btnAddDishAdmin.Click += new System.EventHandler(this.btnAddDishAdmin_Click);
            // 
            // FLPdishes
            // 
            this.FLPdishes.AutoScroll = true;
            this.FLPdishes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(190)))), ((int)(((byte)(207)))));
            this.FLPdishes.Location = new System.Drawing.Point(0, 130);
            this.FLPdishes.Name = "FLPdishes";
            this.FLPdishes.Size = new System.Drawing.Size(783, 312);
            this.FLPdishes.TabIndex = 2;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(784, 570);
            this.Controls.Add(this.FLPdishes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel FLPdishes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnAddDishAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChangeAdmin;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbPrice;
    }
}