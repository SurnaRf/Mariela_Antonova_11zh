namespace PresentationLayer
{
	partial class GenreForm
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
			nameTxtBox = new System.Windows.Forms.TextBox();
			usersDataGridView = new System.Windows.Forms.DataGridView();
			gamesDataGridView = new System.Windows.Forms.DataGridView();
			createBtn = new System.Windows.Forms.Button();
			updateBtn = new System.Windows.Forms.Button();
			deleteBtn = new System.Windows.Forms.Button();
			clearBtn = new System.Windows.Forms.Button();
			closeBtn = new System.Windows.Forms.Button();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			genreDataGridView = new System.Windows.Forms.DataGridView();
			label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)gamesDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)genreDataGridView).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(38, 44);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(49, 20);
			label1.TabIndex = 0;
			label1.Text = "Name";
			// 
			// nameTxtBox
			// 
			nameTxtBox.Location = new System.Drawing.Point(38, 67);
			nameTxtBox.Name = "nameTxtBox";
			nameTxtBox.Size = new System.Drawing.Size(125, 27);
			nameTxtBox.TabIndex = 1;
			// 
			// usersDataGridView
			// 
			usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			usersDataGridView.Location = new System.Drawing.Point(426, 44);
			usersDataGridView.Name = "usersDataGridView";
			usersDataGridView.RowHeadersWidth = 51;
			usersDataGridView.RowTemplate.Height = 29;
			usersDataGridView.Size = new System.Drawing.Size(300, 147);
			usersDataGridView.TabIndex = 2;
			// 
			// gamesDataGridView
			// 
			gamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gamesDataGridView.Location = new System.Drawing.Point(426, 247);
			gamesDataGridView.Name = "gamesDataGridView";
			gamesDataGridView.RowHeadersWidth = 51;
			gamesDataGridView.RowTemplate.Height = 29;
			gamesDataGridView.Size = new System.Drawing.Size(300, 155);
			gamesDataGridView.TabIndex = 3;
			// 
			// createBtn
			// 
			createBtn.Location = new System.Drawing.Point(38, 332);
			createBtn.Name = "createBtn";
			createBtn.Size = new System.Drawing.Size(94, 29);
			createBtn.TabIndex = 4;
			createBtn.Text = "Create";
			createBtn.UseVisualStyleBackColor = true;
			createBtn.Click += createBtn_Click;
			// 
			// updateBtn
			// 
			updateBtn.Location = new System.Drawing.Point(152, 332);
			updateBtn.Name = "updateBtn";
			updateBtn.Size = new System.Drawing.Size(94, 29);
			updateBtn.TabIndex = 5;
			updateBtn.Text = "Update";
			updateBtn.UseVisualStyleBackColor = true;
			updateBtn.Click += updateBtn_Click;
			// 
			// deleteBtn
			// 
			deleteBtn.Location = new System.Drawing.Point(38, 385);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new System.Drawing.Size(94, 29);
			deleteBtn.TabIndex = 6;
			deleteBtn.Text = "Delete";
			deleteBtn.UseVisualStyleBackColor = true;
			deleteBtn.Click += deleteBtn_Click;
			// 
			// clearBtn
			// 
			clearBtn.Location = new System.Drawing.Point(152, 385);
			clearBtn.Name = "clearBtn";
			clearBtn.Size = new System.Drawing.Size(94, 29);
			clearBtn.TabIndex = 7;
			clearBtn.Text = "Clear";
			clearBtn.UseVisualStyleBackColor = true;
			clearBtn.Click += clearBtn_Click;
			// 
			// closeBtn
			// 
			closeBtn.Location = new System.Drawing.Point(270, 385);
			closeBtn.Name = "closeBtn";
			closeBtn.Size = new System.Drawing.Size(94, 29);
			closeBtn.TabIndex = 8;
			closeBtn.Text = "Close";
			closeBtn.UseVisualStyleBackColor = true;
			closeBtn.Click += closeBtn_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(427, 12);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(44, 20);
			label2.TabIndex = 9;
			label2.Text = "Users";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(427, 221);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(54, 20);
			label3.TabIndex = 10;
			label3.Text = "Games";
			// 
			// genreDataGridView
			// 
			genreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			genreDataGridView.Location = new System.Drawing.Point(38, 147);
			genreDataGridView.Name = "genreDataGridView";
			genreDataGridView.RowHeadersWidth = 51;
			genreDataGridView.RowTemplate.Height = 29;
			genreDataGridView.Size = new System.Drawing.Size(300, 156);
			genreDataGridView.TabIndex = 11;
			genreDataGridView.CellClick += genreDataGridView_CellClick;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(38, 115);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(54, 20);
			label4.TabIndex = 12;
			label4.Text = "Genres";
			// 
			// GenreForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(label4);
			Controls.Add(genreDataGridView);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(closeBtn);
			Controls.Add(clearBtn);
			Controls.Add(deleteBtn);
			Controls.Add(updateBtn);
			Controls.Add(createBtn);
			Controls.Add(gamesDataGridView);
			Controls.Add(usersDataGridView);
			Controls.Add(nameTxtBox);
			Controls.Add(label1);
			Name = "GenreForm";
			Text = "GenreForm";
			Shown += GenreForm_Shown;
			((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)gamesDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)genreDataGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nameTxtBox;
		private System.Windows.Forms.DataGridView usersDataGridView;
		private System.Windows.Forms.DataGridView gamesDataGridView;
		private System.Windows.Forms.Button createBtn;
		private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button clearBtn;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView genreDataGridView;
		private System.Windows.Forms.Label label4;
	}
}