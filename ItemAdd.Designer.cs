
namespace DemoExam
{
    partial class ItemAdd
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
            this.panel_add = new System.Windows.Forms.Panel();
            this.done_btn = new System.Windows.Forms.Button();
            this.item_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.arrticle_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.desc_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.manBox = new System.Windows.Forms.ComboBox();
            this.status_box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.count_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.amount_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cost_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_add.SuspendLayout();
            this.item_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_add
            // 
            this.panel_add.Controls.Add(this.item_panel);
            this.panel_add.Controls.Add(this.done_btn);
            this.panel_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_add.Location = new System.Drawing.Point(0, 0);
            this.panel_add.Name = "panel_add";
            this.panel_add.Size = new System.Drawing.Size(477, 476);
            this.panel_add.TabIndex = 0;
            // 
            // done_btn
            // 
            this.done_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.done_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.done_btn.Location = new System.Drawing.Point(0, 446);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(477, 30);
            this.done_btn.TabIndex = 0;
            this.done_btn.Text = "Готово";
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // item_panel
            // 
            this.item_panel.AutoScroll = true;
            this.item_panel.Controls.Add(this.status_box);
            this.item_panel.Controls.Add(this.label10);
            this.item_panel.Controls.Add(this.count_box);
            this.item_panel.Controls.Add(this.label9);
            this.item_panel.Controls.Add(this.amount_box);
            this.item_panel.Controls.Add(this.label8);
            this.item_panel.Controls.Add(this.cost_box);
            this.item_panel.Controls.Add(this.label7);
            this.item_panel.Controls.Add(this.manBox);
            this.item_panel.Controls.Add(this.label6);
            this.item_panel.Controls.Add(this.button1);
            this.item_panel.Controls.Add(this.label5);
            this.item_panel.Controls.Add(this.comboBox1);
            this.item_panel.Controls.Add(this.label4);
            this.item_panel.Controls.Add(this.desc_box);
            this.item_panel.Controls.Add(this.label3);
            this.item_panel.Controls.Add(this.name_box);
            this.item_panel.Controls.Add(this.label2);
            this.item_panel.Controls.Add(this.arrticle_box);
            this.item_panel.Controls.Add(this.label1);
            this.item_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_panel.Location = new System.Drawing.Point(0, 0);
            this.item_panel.Name = "item_panel";
            this.item_panel.Size = new System.Drawing.Size(477, 446);
            this.item_panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Артикул";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrticle_box
            // 
            this.arrticle_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.arrticle_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrticle_box.Location = new System.Drawing.Point(0, 35);
            this.arrticle_box.Name = "arrticle_box";
            this.arrticle_box.Size = new System.Drawing.Size(460, 26);
            this.arrticle_box.TabIndex = 3;
            // 
            // name_box
            // 
            this.name_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_box.Location = new System.Drawing.Point(0, 96);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(460, 26);
            this.name_box.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Наименование";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desc_box
            // 
            this.desc_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.desc_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.desc_box.Location = new System.Drawing.Point(0, 157);
            this.desc_box.Multiline = true;
            this.desc_box.Name = "desc_box";
            this.desc_box.Size = new System.Drawing.Size(460, 20);
            this.desc_box.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Описание";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(460, 35);
            this.label4.TabIndex = 23;
            this.label4.Text = "Категория";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Детские ткани",
            "Постельные ткани",
            "Ткани для изделий"});
            this.comboBox1.Location = new System.Drawing.Point(0, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(460, 28);
            this.comboBox1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(460, 35);
            this.label5.TabIndex = 49;
            this.label5.Text = "Фотография";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(460, 30);
            this.button1.TabIndex = 50;
            this.button1.Text = "Выбрать фотографию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(0, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(460, 35);
            this.label6.TabIndex = 51;
            this.label6.Text = "Производитель";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // manBox
            // 
            this.manBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.manBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manBox.FormattingEnabled = true;
            this.manBox.Items.AddRange(new object[] {
            "БТК Текстиль",
            "Империя ткани",
            "Май Фабрик",
            "Комильфо"});
            this.manBox.Location = new System.Drawing.Point(0, 340);
            this.manBox.Name = "manBox";
            this.manBox.Size = new System.Drawing.Size(460, 21);
            this.manBox.TabIndex = 61;
            // 
            // status_box
            // 
            this.status_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.status_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_box.Location = new System.Drawing.Point(0, 579);
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(460, 26);
            this.status_box.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(0, 544);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(460, 35);
            this.label10.TabIndex = 68;
            this.label10.Text = "Статус";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // count_box
            // 
            this.count_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.count_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_box.Location = new System.Drawing.Point(0, 518);
            this.count_box.Name = "count_box";
            this.count_box.Size = new System.Drawing.Size(460, 26);
            this.count_box.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(0, 483);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(460, 35);
            this.label9.TabIndex = 66;
            this.label9.Text = "Количество на складе";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amount_box
            // 
            this.amount_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.amount_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amount_box.Location = new System.Drawing.Point(0, 457);
            this.amount_box.Name = "amount_box";
            this.amount_box.Size = new System.Drawing.Size(460, 26);
            this.amount_box.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(0, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(460, 35);
            this.label8.TabIndex = 64;
            this.label8.Text = "Действующая скидка";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cost_box
            // 
            this.cost_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.cost_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost_box.Location = new System.Drawing.Point(0, 396);
            this.cost_box.Name = "cost_box";
            this.cost_box.Size = new System.Drawing.Size(460, 26);
            this.cost_box.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(0, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(460, 35);
            this.label7.TabIndex = 62;
            this.label7.Text = "Стоимость";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 476);
            this.Controls.Add(this.panel_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ItemAdd";
            this.Text = "ItemAdd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemAdd_FormClosing);
            this.panel_add.ResumeLayout(false);
            this.item_panel.ResumeLayout(false);
            this.item_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_add;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.Panel item_panel;
        private System.Windows.Forms.TextBox desc_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arrticle_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox status_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox count_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox amount_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cost_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox manBox;
    }
}