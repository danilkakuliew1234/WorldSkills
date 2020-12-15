
namespace WorldSkills
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.login_text = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.TextBox();
            this.Sign_In = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_text
            // 
            this.login_text.Location = new System.Drawing.Point(60, 12);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(268, 20);
            this.login_text.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(60, 47);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(268, 20);
            this.password_text.TabIndex = 3;
            // 
            // Sign_In
            // 
            this.Sign_In.Location = new System.Drawing.Point(60, 73);
            this.Sign_In.Name = "Sign_In";
            this.Sign_In.Size = new System.Drawing.Size(272, 34);
            this.Sign_In.TabIndex = 5;
            this.Sign_In.Text = "Войти в аккаунт";
            this.Sign_In.UseVisualStyleBackColor = true;
            this.Sign_In.Click += new System.EventHandler(this.Sign_In_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 119);
            this.Controls.Add(this.Sign_In);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Вход в аккаунт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_text;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Button Sign_In;
    }
}

