namespace DBImplementation
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
			this.password = new System.Windows.Forms.TextBox();
			this.name = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Login = new System.Windows.Forms.Button();
			this.loginUser = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(26, 106);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(120, 20);
			this.password.TabIndex = 1;
			this.password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// name
			// 
			this.name.AutoSize = true;
			this.name.Location = new System.Drawing.Point(23, 40);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(33, 13);
			this.name.TabIndex = 2;
			this.name.Text = "Login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(92, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "label1";
			// 
			// Login
			// 
			this.Login.Location = new System.Drawing.Point(35, 143);
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(92, 22);
			this.Login.TabIndex = 6;
			this.Login.Text = "Login";
			this.Login.UseVisualStyleBackColor = true;
			this.Login.Click += new System.EventHandler(this.Login_Click);
			// 
			// loginUser
			// 
			this.loginUser.Location = new System.Drawing.Point(26, 56);
			this.loginUser.Name = "loginUser";
			this.loginUser.Size = new System.Drawing.Size(120, 20);
			this.loginUser.TabIndex = 7;
			this.loginUser.TextChanged += new System.EventHandler(this.loginUser_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(174, 177);
			this.Controls.Add(this.loginUser);
			this.Controls.Add(this.Login);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.name);
			this.Controls.Add(this.password);
			this.Name = "Form1";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Label name;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Login;
		private System.Windows.Forms.TextBox loginUser;
	}
}

