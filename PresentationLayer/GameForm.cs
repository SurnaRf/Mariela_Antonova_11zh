using BusinessLayer;
using ServiceLayer;
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
	public partial class GameForm : Form
	{
		private DbManager<Game, int> dbManager = new(ContextGenerator.GetGameContext());

		private DbManager<Genre, int> genreManager = new(ContextGenerator.GetGenreContext());

		private SortedDictionary<int, Game>? trackedGames;

		private Game? selectedGame = null;
		private Genre? selectedGenre = null;
		private List<Genre> genres = new();
		public GameForm()
		{
			InitializeComponent();

			trackedGames = new(dbManager.ReadAll(true)
					.ToDictionary(g => g.Id));

			genreComboBox.DisplayMember = "Name";

			foreach (Genre genre in genreManager.ReadAll())
				genreComboBox.Items.Add(genre);

		}

		#region Methods
		private void ClearInputs()
		{
			SetCreation();

			selectedGame = null;

			nameTxtBox.Text = string.Empty;
			nameTxtBox.Focus();

			gamesDataGridView.DataSource = null;
			gamesDataGridView.DataSource = trackedGames?.Values.ToList();


			usersDataGridView.DataSource = null;
			genreDataGridView.DataSource = null;
			genres.Clear();
		}

		private void FillInputs()
		{
			if (selectedGame == null) { return; }

			try
			{
				nameTxtBox.Text = selectedGame.Name;
				genreComboBox.SelectedItem = selectedGame.Genres;

				genres.Clear();

				foreach (Genre genre in selectedGame.Genres)
				{
					genres.Add(genre);
				}
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SetCreation(bool unlock = true)
		{
			createBtn.Enabled = unlock;

			updateBtn.Enabled =
			deleteBtn.Enabled = !unlock;
		}
		#endregion
		#region Events
		private void GameForm_Shown(object sender, EventArgs e)
		{
			try
			{
				ClearInputs();
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void createBtn_Click(object sender, EventArgs e)
		{
			try
			{
				string name = nameTxtBox.Text;

				Game game = new(name);

				game.Genres = genres.ToList();

				dbManager.Create(game);

				trackedGames?.Add(game.Id, game);

				ClearInputs();

				MessageBox.Show(
					"Game created successfully.",
					"Success", MessageBoxButtons.OK,
					MessageBoxIcon.Information);

			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void updateBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (ValidationManager.IsValidString(nameTxtBox.Text)
					&& selectedGame != null)
				{
					selectedGame.Name = nameTxtBox.Text;

					selectedGame.Genres = genres.ToList();

					dbManager.Update(selectedGame, true);

					MessageBox.Show("Game updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

					ClearInputs();

					nameTxtBox.Focus();
				}
				else
				{
					MessageBox.Show("A game must be selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (selectedGame != null)
				{
					trackedGames?.Remove(selectedGame.Id);
					dbManager.Delete(selectedGame.Id);
					MessageBox.Show("Game deleted successfully!", "Successful operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearInputs();
				}
				else
				{
					MessageBox.Show("A game must be selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			ClearInputs();
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			try
			{
				selectedGenre = genreComboBox.SelectedItem as Genre;

				genres.Add(selectedGenre);

				genreDataGridView.DataSource = genres.ToList();
				MessageBox.Show("Genre added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void gamesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

				selectedGame = gamesDataGridView.Rows[e.RowIndex].DataBoundItem as Game;
				SetCreation(false);
				FillInputs();
				genreDataGridView.DataSource = genres.ToList();
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion
	}
}
