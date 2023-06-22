namespace PresentationLayer
{
	partial class GameForm
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
			label3 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			closeBtn = new System.Windows.Forms.Button();
			clearBtn = new System.Windows.Forms.Button();
			deleteBtn = new System.Windows.Forms.Button();
			updateBtn = new System.Windows.Forms.Button();
			createBtn = new System.Windows.Forms.Button();
			usersDataGridView = new System.Windows.Forms.DataGridView();
			gamesDataGridView = new System.Windows.Forms.DataGridView();
			nameTxtBox = new System.Windows.Forms.TextBox();
			label1 = new System.Windows.Forms.Label();
			Genre = new System.Windows.Forms.Label();
			addBtn = new System.Windows.Forms.Button();
			genreDataGridView = new System.Windows.Forms.DataGridView();
			genreComboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)gamesDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)genreDataGridView).BeginInit();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(445, 233);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(44, 20);
			label3.TabIndex = 21;
			label3.Text = "Users";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(445, 24);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(54, 20);
			label2.TabIndex = 20;
			label2.Text = "Games";
			// 
			// closeBtn
			// 
			closeBtn.Location = new System.Drawing.Point(274, 409);
			closeBtn.Name = "closeBtn";
			closeBtn.Size = new System.Drawing.Size(94, 29);
			closeBtn.TabIndex = 19;
			closeBtn.Text = "Close";
			closeBtn.UseVisualStyleBackColor = true;
			closeBtn.Click += closeBtn_Click;
			// 
			// clearBtn
			// 
			clearBtn.Location = new System.Drawing.Point(158, 409);
			clearBtn.Name = "clearBtn";
			clearBtn.Size = new System.Drawing.Size(94, 29);
			clearBtn.TabIndex = 18;
			clearBtn.Text = "Clear";
			clearBtn.UseVisualStyleBackColor = true;
			clearBtn.Click += clearBtn_Click;
			// 
			// deleteBtn
			// 
			deleteBtn.Location = new System.Drawing.Point(44, 409);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new System.Drawing.Size(94, 29);
			deleteBtn.TabIndex = 17;
			deleteBtn.Text = "Delete";
			deleteBtn.UseVisualStyleBackColor = true;
			deleteBtn.Click += deleteBtn_Click;
			// 
			// updateBtn
			// 
			updateBtn.Location = new System.Drawing.Point(158, 357);
			updateBtn.Name = "updateBtn";
			updateBtn.Size = new System.Drawing.Size(94, 29);
			updateBtn.TabIndex = 16;
			updateBtn.Text = "Update";
			updateBtn.UseVisualStyleBackColor = true;
			updateBtn.Click += updateBtn_Click;
			// 
			// createBtn
			// 
			createBtn.Location = new System.Drawing.Point(44, 357);
			createBtn.Name = "createBtn";
			createBtn.Size = new System.Drawing.Size(94, 29);
			createBtn.TabIndex = 15;
			createBtn.Text = "Create";
			createBtn.UseVisualStyleBackColor = true;
			createBtn.Click += createBtn_Click;
			// 
			// usersDataGridView
			// 
			usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			usersDataGridView.Location = new System.Drawing.Point(444, 259);
			usersDataGridView.Name = "usersDataGridView";
			usersDataGridView.RowHeadersWidth = 51;
			usersDataGridView.RowTemplate.Height = 29;
			usersDataGridView.Size = new System.Drawing.Size(300, 155);
			usersDataGridView.TabIndex = 14;
			// 
			// gamesDataGridView
			// 
			gamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gamesDataGridView.Location = new System.Drawing.Point(444, 56);
			gamesDataGridView.Name = "gamesDataGridView";
			gamesDataGridView.RowHeadersWidth = 51;
			gamesDataGridView.RowTemplate.Height = 29;
			gamesDataGridView.Size = new System.Drawing.Size(300, 147);
			gamesDataGridView.TabIndex = 13;
			gamesDataGridView.CellClick += gamesDataGridView_CellClick;
			// 
			// nameTxtBox
			// 
			nameTxtBox.Location = new System.Drawing.Point(44, 76);
			nameTxtBox.Name = "nameTxtBox";
			nameTxtBox.Size = new System.Drawing.Size(125, 27);
			nameTxtBox.TabIndex = 12;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(44, 43);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(49, 20);
			label1.TabIndex = 11;
			label1.Text = "Name";
			// 
			// Genre
			// 
			Genre.AutoSize = true;
			Genre.Location = new System.Drawing.Point(44, 119);
			Genre.Name = "Genre";
			Genre.Size = new System.Drawing.Size(48, 20);
			Genre.TabIndex = 23;
			Genre.Text = "Genre";
			// 
			// addBtn
			// 
			addBtn.Location = new System.Drawing.Point(192, 144);
			addBtn.Name = "addBtn";
			addBtn.Size = new System.Drawing.Size(94, 29);
			addBtn.TabIndex = 24;
			addBtn.Text = "Add";
			addBtn.UseVisualStyleBackColor = true;
			addBtn.Click += addBtn_Click;
			// 
			// genreDataGridView
			// 
			genreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			genreDataGridView.Location = new System.Drawing.Point(44, 195);
			genreDataGridView.Name = "genreDataGridView";
			genreDataGridView.RowHeadersWidth = 51;
			genreDataGridView.RowTemplate.Height = 29;
			genreDataGridView.Size = new System.Drawing.Size(300, 135);
			genreDataGridView.TabIndex = 25;
			// 
			// genreComboBox
			// 
			genreComboBox.FormattingEnabled = true;
			genreComboBox.Location = new System.Drawing.Point(44, 145);
			genreComboBox.Name = "genreComboBox";
			genreComboBox.Size = new System.Drawing.Size(134, 28);
			genreComboBox.TabIndex = 26;
			// 
			// GameForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(genreComboBox);
			Controls.Add(genreDataGridView);
			Controls.Add(addBtn);
			Controls.Add(Genre);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(closeBtn);
			Controls.Add(clearBtn);
			Controls.Add(deleteBtn);
			Controls.Add(updateBtn);
			Controls.Add(createBtn);
			Controls.Add(usersDataGridView);
			Controls.Add(gamesDataGridView);
			Controls.Add(nameTxtBox);
			Controls.Add(label1);
			Name = "GameForm";
			Text = "GameForm";
			Shown += GameForm_Shown;
			((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)gamesDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)genreDataGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Button clearBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.Button createBtn;
		private System.Windows.Forms.DataGridView usersDataGridView;
		private System.Windows.Forms.DataGridView gamesDataGridView;
		private System.Windows.Forms.TextBox nameTxtBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Genre;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.DataGridView genreDataGridView;
		private System.Windows.Forms.ComboBox genreComboBox;
	}
}