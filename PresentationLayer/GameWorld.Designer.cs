namespace PresentationLayer
{
	partial class GameWorld
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
			gameBtn = new System.Windows.Forms.Button();
			genreBtn = new System.Windows.Forms.Button();
			userBtn = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// gameBtn
			// 
			gameBtn.Location = new System.Drawing.Point(124, 211);
			gameBtn.Name = "gameBtn";
			gameBtn.Size = new System.Drawing.Size(94, 29);
			gameBtn.TabIndex = 0;
			gameBtn.Text = "Game";
			gameBtn.UseVisualStyleBackColor = true;
			gameBtn.Click += gameBtn_Click;
			// 
			// genreBtn
			// 
			genreBtn.Location = new System.Drawing.Point(341, 211);
			genreBtn.Name = "genreBtn";
			genreBtn.Size = new System.Drawing.Size(94, 29);
			genreBtn.TabIndex = 1;
			genreBtn.Text = "Genre";
			genreBtn.UseVisualStyleBackColor = true;
			genreBtn.Click += genreBtn_Click;
			// 
			// userBtn
			// 
			userBtn.Location = new System.Drawing.Point(553, 211);
			userBtn.Name = "userBtn";
			userBtn.Size = new System.Drawing.Size(94, 29);
			userBtn.TabIndex = 2;
			userBtn.Text = "User";
			userBtn.UseVisualStyleBackColor = true;
			userBtn.Click += userBtn_Click;
			// 
			// GameWorld
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(userBtn);
			Controls.Add(genreBtn);
			Controls.Add(gameBtn);
			Name = "GameWorld";
			Text = "GameWorld";
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Button gameBtn;
		private System.Windows.Forms.Button genreBtn;
		private System.Windows.Forms.Button userBtn;
	}
}