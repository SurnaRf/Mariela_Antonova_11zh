using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
	public partial class GameWorld : Form
	{
		public GameWorld()
		{
			InitializeComponent();
		}

		private void gameBtn_Click(object sender, EventArgs e)
		{
			GameForm gameForm = new GameForm();
			gameForm.ShowDialog();
		}

		private void genreBtn_Click(object sender, EventArgs e)
		{
			GenreForm genreForm = new GenreForm();
			genreForm.ShowDialog();
		}

		private void userBtn_Click(object sender, EventArgs e)
		{
			UserForm userForm = new UserForm();
			userForm.ShowDialog();
		}
	}
}
