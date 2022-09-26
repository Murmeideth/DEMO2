
namespace DemoExam
{
    partial class ItemsForm
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
            this.items_panel = new System.Windows.Forms.Panel();
            this.product_panel = new System.Windows.Forms.Panel();
            this.add_btn = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.costBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.manBox = new System.Windows.Forms.ComboBox();
            this.count_label = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.items_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // items_panel
            // 
            this.items_panel.Controls.Add(this.back_btn);
            this.items_panel.Controls.Add(this.count_label);
            this.items_panel.Controls.Add(this.manBox);
            this.items_panel.Controls.Add(this.label3);
            this.items_panel.Controls.Add(this.costBox);
            this.items_panel.Controls.Add(this.label2);
            this.items_panel.Controls.Add(this.label1);
            this.items_panel.Controls.Add(this.search_box);
            this.items_panel.Controls.Add(this.add_btn);
            this.items_panel.Controls.Add(this.product_panel);
            this.items_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.items_panel.Location = new System.Drawing.Point(0, 0);
            this.items_panel.Name = "items_panel";
            this.items_panel.Size = new System.Drawing.Size(800, 450);
            this.items_panel.TabIndex = 0;
            // 
            // product_panel
            // 
            this.product_panel.AutoScroll = true;
            this.product_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.product_panel.Location = new System.Drawing.Point(24, 70);
            this.product_panel.Name = "product_panel";
            this.product_panel.Size = new System.Drawing.Size(764, 344);
            this.product_panel.TabIndex = 0;
            // 
            // add_btn
            // 
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Location = new System.Drawing.Point(486, 33);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(149, 26);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(24, 37);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(150, 20);
            this.search_box.TabIndex = 2;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск";
            // 
            // costBox
            // 
            this.costBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.costBox.FormattingEnabled = true;
            this.costBox.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.costBox.Location = new System.Drawing.Point(181, 37);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(142, 21);
            this.costBox.TabIndex = 4;
            this.costBox.SelectedIndexChanged += new System.EventHandler(this.costBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Производитель";
            // 
            // manBox
            // 
            this.manBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manBox.FormattingEnabled = true;
            this.manBox.Items.AddRange(new object[] {
            "Все производители",
            "БТК Текстиль",
            "Империя ткани",
            "Май Фабрик",
            "Комильфо"});
            this.manBox.Location = new System.Drawing.Point(329, 37);
            this.manBox.Name = "manBox";
            this.manBox.Size = new System.Drawing.Size(142, 21);
            this.manBox.TabIndex = 4;
            this.manBox.SelectedIndexChanged += new System.EventHandler(this.manBox_SelectedIndexChanged);
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(641, 40);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(35, 13);
            this.count_label.TabIndex = 5;
            this.count_label.Text = "label4";
            // 
            // back_btn
            // 
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Location = new System.Drawing.Point(24, 420);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(127, 23);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.items_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemsForm";
            this.Text = "ItemsForm";
            this.items_panel.ResumeLayout(false);
            this.items_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel items_panel;
        private System.Windows.Forms.Panel product_panel;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox costBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox manBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.Button back_btn;
    }
}