namespace PresentationLayer
{
	partial class UserForm
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
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			textBox1 = new System.Windows.Forms.TextBox();
			textBox2 = new System.Windows.Forms.TextBox();
			textBox3 = new System.Windows.Forms.TextBox();
			numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			textBox4 = new System.Windows.Forms.TextBox();
			textBox5 = new System.Windows.Forms.TextBox();
			Users = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			userDataGridView = new System.Windows.Forms.DataGridView();
			gamesDataGridView = new System.Windows.Forms.DataGridView();
			createBtn = new System.Windows.Forms.Button();
			updateBtn = new System.Windows.Forms.Button();
			deleteBtn = new System.Windows.Forms.Button();
			closeBtn = new System.Windows.Forms.Button();
			clearBtn = new System.Windows.Forms.Button();
			friendsDataGridView = new System.Windows.Forms.DataGridView();
			label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)gamesDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)friendsDataGridView).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(23, 9);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(77, 20);
			label1.TabIndex = 0;
			label1.Text = "First name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(22, 77);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(76, 20);
			label2.TabIndex = 1;
			label2.Text = "Last name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(22, 144);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(75, 20);
			label3.TabIndex = 2;
			label3.Text = "Username";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(22, 211);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(36, 20);
			label4.TabIndex = 3;
			label4.Text = "Age";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(22, 275);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(70, 20);
			label5.TabIndex = 4;
			label5.Text = "Password";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(22, 349);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(46, 20);
			label6.TabIndex = 5;
			label6.Text = "Email";
			// 
			// textBox1
			// 
			textBox1.Location = new System.Drawing.Point(23, 32);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(150, 27);
			textBox1.TabIndex = 6;
			// 
			// textBox2
			// 
			textBox2.Location = new System.Drawing.Point(22, 100);
			textBox2.Name = "textBox2";
			textBox2.Size = new System.Drawing.Size(151, 27);
			textBox2.TabIndex = 7;
			// 
			// textBox3
			// 
			textBox3.Location = new System.Drawing.Point(22, 167);
			textBox3.Name = "textBox3";
			textBox3.Size = new System.Drawing.Size(151, 27);
			textBox3.TabIndex = 8;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new System.Drawing.Point(23, 234);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new System.Drawing.Size(150, 27);
			numericUpDown1.TabIndex = 9;
			// 
			// textBox4
			// 
			textBox4.Location = new System.Drawing.Point(22, 298);
			textBox4.Name = "textBox4";
			textBox4.Size = new System.Drawing.Size(151, 27);
			textBox4.TabIndex = 10;
			// 
			// textBox5
			// 
			textBox5.Location = new System.Drawing.Point(23, 385);
			textBox5.Name = "textBox5";
			textBox5.Size = new System.Drawing.Size(150, 27);
			textBox5.TabIndex = 11;
			// 
			// Users
			// 
			Users.AutoSize = true;
			Users.Location = new System.Drawing.Point(215, 9);
			Users.Name = "Users";
			Users.Size = new System.Drawing.Size(44, 20);
			Users.TabIndex = 12;
			Users.Text = "Users";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(215, 240);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(54, 20);
			label8.TabIndex = 13;
			label8.Text = "Games";
			// 
			// userDataGridView
			// 
			userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			userDataGridView.Location = new System.Drawing.Point(215, 32);
			userDataGridView.Name = "userDataGridView";
			userDataGridView.RowHeadersWidth = 51;
			userDataGridView.RowTemplate.Height = 29;
			userDataGridView.Size = new System.Drawing.Size(277, 151);
			userDataGridView.TabIndex = 14;
			// 
			// gamesDataGridView
			// 
			gamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gamesDataGridView.Location = new System.Drawing.Point(215, 263);
			gamesDataGridView.Name = "gamesDataGridView";
			gamesDataGridView.RowHeadersWidth = 51;
			gamesDataGridView.RowTemplate.Height = 29;
			gamesDataGridView.Size = new System.Drawing.Size(277, 149);
			gamesDataGridView.TabIndex = 15;
			// 
			// createBtn
			// 
			createBtn.Location = new System.Drawing.Point(498, 316);
			createBtn.Name = "createBtn";
			createBtn.Size = new System.Drawing.Size(94, 29);
			createBtn.TabIndex = 16;
			createBtn.Text = "Create";
			createBtn.UseVisualStyleBackColor = true;
			// 
			// updateBtn
			// 
			updateBtn.Location = new System.Drawing.Point(598, 316);
			updateBtn.Name = "updateBtn";
			updateBtn.Size = new System.Drawing.Size(94, 29);
			updateBtn.TabIndex = 17;
			updateBtn.Text = "Update";
			updateBtn.UseVisualStyleBackColor = true;
			// 
			// deleteBtn
			// 
			deleteBtn.Location = new System.Drawing.Point(698, 316);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new System.Drawing.Size(94, 29);
			deleteBtn.TabIndex = 18;
			deleteBtn.Text = "Delete";
			deleteBtn.UseVisualStyleBackColor = true;
			// 
			// closeBtn
			// 
			closeBtn.Location = new System.Drawing.Point(698, 370);
			closeBtn.Name = "closeBtn";
			closeBtn.Size = new System.Drawing.Size(94, 29);
			closeBtn.TabIndex = 19;
			closeBtn.Text = "Close";
			closeBtn.UseVisualStyleBackColor = true;
			// 
			// clearBtn
			// 
			clearBtn.Location = new System.Drawing.Point(598, 370);
			clearBtn.Name = "clearBtn";
			clearBtn.Size = new System.Drawing.Size(94, 29);
			clearBtn.TabIndex = 20;
			clearBtn.Text = "Clear";
			clearBtn.UseVisualStyleBackColor = true;
			// 
			// friendsDataGridView
			// 
			friendsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			friendsDataGridView.Location = new System.Drawing.Point(511, 122);
			friendsDataGridView.Name = "friendsDataGridView";
			friendsDataGridView.RowHeadersWidth = 51;
			friendsDataGridView.RowTemplate.Height = 29;
			friendsDataGridView.Size = new System.Drawing.Size(277, 188);
			friendsDataGridView.TabIndex = 21;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(511, 94);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(56, 20);
			label7.TabIndex = 22;
			label7.Text = "Friends";
			// 
			// UserForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(label7);
			Controls.Add(friendsDataGridView);
			Controls.Add(clearBtn);
			Controls.Add(closeBtn);
			Controls.Add(deleteBtn);
			Controls.Add(updateBtn);
			Controls.Add(createBtn);
			Controls.Add(gamesDataGridView);
			Controls.Add(userDataGridView);
			Controls.Add(label8);
			Controls.Add(Users);
			Controls.Add(textBox5);
			Controls.Add(textBox4);
			Controls.Add(numericUpDown1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "UserForm";
			Text = "UserForm";
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)gamesDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)friendsDataGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label Users;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView userDataGridView;
		private System.Windows.Forms.DataGridView gamesDataGridView;
		private System.Windows.Forms.Button createBtn;
		private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Button clearBtn;
		private System.Windows.Forms.DataGridView friendsDataGridView;
		private System.Windows.Forms.Label label7;
	}
}