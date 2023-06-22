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
	public partial class GenreForm : Form
	{
		private DbManager<Genre, int> dbManager = new(ContextGenerator.GetGenreContext());

		private SortedDictionary<int, Genre>? trackedGenres;

		private Genre? selectedGenre = null;

		private List<Game> games = new();

		public GenreForm()
		{
			InitializeComponent();

			trackedGenres = new(dbManager.ReadAll(true)
					.ToDictionary(g => g.Id));
		}

		#region Methods
		private void SetCreation(bool unlock = true)
		{
			createBtn.Enabled = unlock;

			updateBtn.Enabled =
			deleteBtn.Enabled = !unlock;
		}

		private void ClearInputs()
		{
			SetCreation();

			selectedGenre = null;

			nameTxtBox.Text = string.Empty;
			nameTxtBox.Focus();

			genreDataGridView.DataSource = null;
			genreDataGridView.DataSource = trackedGenres?.Values.ToList();


			usersDataGridView.DataSource = null;
			gamesDataGridView.DataSource = null;
			games.Clear();
		}

		private void FillInputs()
		{
			if (selectedGenre == null) { return; }

			try
			{
				nameTxtBox.Text = selectedGenre.Name;

				games.Clear();

				foreach (Game game in selectedGenre.Games)
				{
					games.Add(game);
				}
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion
		#region Events
		private void GenreForm_Shown(object sender, EventArgs e)
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

				Genre genre = new(name);

				genre.Games = games.ToList();

				dbManager.Create(genre);

				trackedGenres?.Add(genre.Id, genre);

				ClearInputs();

				MessageBox.Show(
					"Genre created successfully.",
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
					&& selectedGenre != null)
				{
					selectedGenre.Name = nameTxtBox.Text;

					selectedGenre.Games = games.ToList();

					dbManager.Update(selectedGenre, true);

					MessageBox.Show("Genre updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

					ClearInputs();

					nameTxtBox.Focus();
				}
				else
				{
					MessageBox.Show("A genre must be selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				if (selectedGenre != null)
				{
					trackedGenres?.Remove(selectedGenre.Id);
					dbManager.Delete(selectedGenre.Id);
					MessageBox.Show("Genre deleted successfully!", "Successful operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearInputs();
				}
				else
				{
					MessageBox.Show("A genre must be selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				while (ex.InnerException != null) ex = ex.InnerException;
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void genreDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

				selectedGenre = genreDataGridView.Rows[e.RowIndex].DataBoundItem as Genre;
				SetCreation(false);
				FillInputs();
				gamesDataGridView.DataSource = games.ToList();
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
		#endregion

	}
}
