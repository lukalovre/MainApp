using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MainApp
{
	internal static class GridViewExtension
	{
		public static void CenterColumn(this DataGridViewColumn dataGridViewColumn)
		{
			dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
		}

		public static T GetSelected<T>(this DataGridView dataGridView) where T : class
		{
			int rowIndex = dataGridView.SelectedCells[0].RowIndex;
			return dataGridView.Rows[rowIndex].DataBoundItem as T;
		}

		public static void SelectLastRow(this DataGridView dataGridView)
		{
			if (dataGridView.RowCount > 0)
			{
				DataGridViewCell firstVisibleCell = null;

				foreach (DataGridViewCell cell in dataGridView.Rows[dataGridView.RowCount - 1].Cells)
				{
					if (cell.Visible)
					{
						firstVisibleCell = cell;
						break;
					}
				}

				dataGridView.CurrentCell = firstVisibleCell;
			}
		}

		internal static void AddCoundOfRowsToHeader(this DataGridView dataGridView)
		{
			void Paint(object sender, PaintEventArgs e)
			{
				var grid = sender as DataGridView;

				if (e == null)
				{
					return;
				}

				var rows = grid.SelectedRows.Count > 1
					? grid.SelectedRows.Count
					: grid.RowCount;

				if (grid.SelectedRows.Count > 1)
				{
				}

				using (SolidBrush solidBrush = new SolidBrush(grid.RowHeadersDefaultCellStyle.ForeColor))
				{
					e.Graphics.DrawString(rows.ToString(), grid.Font, solidBrush, 3, 5);
				}
			}

			void InvalidateForDraw(object sender, EventArgs e)
			{
				(sender as DataGridView).Invalidate();
			}

			dataGridView.Paint -= Paint;
			dataGridView.Paint += Paint;

			dataGridView.SelectionChanged -= InvalidateForDraw;
			dataGridView.SelectionChanged += InvalidateForDraw;
		}

		internal static T GetRowObject<T>(this DataGridView dataGridView, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return default;
			}

			return (T)dataGridView.Rows[e.RowIndex].DataBoundItem;
		}

		internal static T GetRowObject<T>(this DataGridView dataGridView)
		{
			if (dataGridView.SelectedCells.Count == 0)
			{
				return default;
			}

			return (T)dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].DataBoundItem;
		}

		internal static void SetColumns(this DataGridView dataGridView, string[] columns)
		{
			dataGridView.Columns.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false);

			for (int i = 0; i < columns.Length; i++)
			{
				dataGridView.Columns[columns[i]].Visible = true;
				dataGridView.Columns[columns[i]].DisplayIndex = i;
			}
		}

		internal static void SetGrid(this DataGridView dataGridView, bool setLocation = true)
		{
			if (setLocation)
			{
				dataGridView.Width = 500;
				dataGridView.Height = 610;
				dataGridView.Location = new Point(0, 0);
			}

			dataGridView.MultiSelect = true;
			dataGridView.RowHeadersWidth = 25;
			dataGridView.AutoGenerateColumns = false;
			dataGridView.AllowUserToAddRows = false;
			dataGridView.AllowUserToDeleteRows = false;
			dataGridView.AllowUserToResizeRows = false;
			dataGridView.ReadOnly = true;
			dataGridView.AddCoundOfRowsToHeader();
		}
	}
}