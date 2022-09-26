
namespace DemoExam
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.auth_panel = new System.Windows.Forms.Panel();
            this.guest_log = new System.Windows.Forms.Button();
            this.log_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.log_box = new System.Windows.Forms.TextBox();
            this.auth_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // auth_panel
            // 
            this.auth_panel.Controls.Add(this.guest_log);
            this.auth_panel.Controls.Add(this.log_btn);
            this.auth_panel.Controls.Add(this.label2);
            this.auth_panel.Controls.Add(this.label1);
            this.auth_panel.Controls.Add(this.pictureBox1);
            this.auth_panel.Controls.Add(this.pass_box);
            this.auth_panel.Controls.Add(this.log_box);
            this.auth_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auth_panel.Location = new System.Drawing.Point(0, 0);
            this.auth_panel.Name = "auth_panel";
            this.auth_panel.Size = new System.Drawing.Size(800, 450);
            this.auth_panel.TabIndex = 0;
            // 
            // guest_log
            // 
            this.guest_log.FlatAppearance.BorderSize = 0;
            this.guest_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guest_log.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guest_log.Location = new System.Drawing.Point(265, 317);
            this.guest_log.Name = "guest_log";
            this.guest_log.Size = new System.Drawing.Size(129, 34);
            this.guest_log.TabIndex = 3;
            this.guest_log.Text = "Войти как гость";
            this.guest_log.UseVisualStyleBackColor = true;
            this.guest_log.Click += new System.EventHandler(this.guest_log_Click);
            // 
            // log_btn
            // 
            this.log_btn.FlatAppearance.BorderSize = 0;
            this.log_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_btn.Location = new System.Drawing.Point(423, 317);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(100, 34);
            this.log_btn.TabIndex = 3;
            this.log_btn.Text = "Вход";
            this.log_btn.UseVisualStyleBackColor = true;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(261, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(261, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pass_box
            // 
            this.pass_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_box.Location = new System.Drawing.Point(265, 275);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(258, 26);
            this.pass_box.TabIndex = 0;
            // 
            // log_box
            // 
            this.log_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_box.Location = new System.Drawing.Point(265, 223);
            this.log_box.Name = "log_box";
            this.log_box.Size = new System.Drawing.Size(258, 26);
            this.log_box.TabIndex = 0;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.auth_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthForm";
            this.Text = "Ткани";
            this.auth_panel.ResumeLayout(false);
            this.auth_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel auth_panel;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.TextBox log_box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guest_log;
        private System.Windows.Forms.Button log_btn;
    }
}

