using MainApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MainApp
{
	public sealed class DataGridCustom : DataGridView
	{
		public string RowFilterValue;

		private Dictionary<string, string> m_filterDictionary = new Dictionary<string, string>();

		private List<GridColumn> m_gridColumsList;

		private string m_query;

		private ListSortDirection sortDirection;

		private string sortedColumnName;

		private int VerticalScrollBarPosition;

		public DataGridCustom()
		{
			MultiSelect = true;
			AllowUserToAddRows = false;
			AllowUserToDeleteRows = false;
			ReadOnly = true;
			AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			AllowUserToResizeRows = false;
			Dock = DockStyle.Left;
			RowHeadersVisible = true;
			Size = new Size(693, 550);

			Paint += DataGridCustomPaint;
			SelectionChanged += DataGridCustomSelectionChanged;
			CellClick += DataGridCustomCellClick;
		}

		public int CurrentRowIndex { get; set; }

		public object DataSourceCustom
		{
			get => DataSource;
			set
			{
				BeforeDataSourceCustomChanged(value);

				DataSource = value;
			}
		}

		public string RowFilter
		{
			get => (DataSourceCustom as DataTable).DefaultView.RowFilter;
			set
			{
				var key = value?.Split(' ').FirstOrDefault();

				if(string.IsNullOrEmpty(key))
				{
					return;
				}

				if(!m_filterDictionary.ContainsKey(key))
				{
					m_filterDictionary.Add(key, value);
				}
				else
				{
					m_filterDictionary[key] = value;

					if(value.Contains("reset"))
					{
						m_filterDictionary.Remove(key);
					}
				}

				RowFilterValue = string.Join(" AND ", m_filterDictionary.Values.ToArray());

				if(RowFilterValue == null)
				{
					return;
				}

				if(DataSourceCustom != null)
				{
					(DataSourceCustom as DataTable).DefaultView.RowFilter = RowFilterValue;

					OnDataSourceChanged(null);
				}
			}
		}

		public string SelectedID
		{
			get
			{
				int rowIndex = SelectedCells[0].RowIndex;
				DataGridViewRow selectedRow = Rows[rowIndex];

				string columnName = string.Empty;

				if(Columns.Contains("ID"))
				{
					columnName = "ID";
				}
				else if(Columns.Contains("ItemID"))
				{
					columnName = "ItemID";
				}

				return selectedRow.Cells[columnName].Value.ToString();
			}
		}

		public void FillGrid(string query, List<GridColumn> gridColumnList)
		{
			m_query = query;
			m_gridColumsList = gridColumnList;

			var sqlConnection1 = new SqlConnection(Resources.MainConnectionString);
			var cmd = new SqlCommand
			{
				CommandText = query,
				Connection = sqlConnection1
			};

			sqlConnection1.Open();

			DataSourceCustom = null;

			using(SqlDataReader reader = cmd.ExecuteReader())
			{
				var table = new DataTable();

				foreach(var gridColumn in gridColumnList)
				{
					table.Columns.Add(new DataColumn(gridColumn.Name, gridColumn.Type));
				}

				while(reader.Read())
				{
					List<object> columnList = new List<object>();

					foreach(var gridColumn in gridColumnList)
					{
						object value = GetValueByType(reader, gridColumn);
						columnList.Add(value);
					}

					table.Rows.Add(columnList.ToArray());
				}

				DataSourceCustom = table;

				foreach(var gridColumn in gridColumnList)
				{
					Columns[gridColumn.Name].Visible = gridColumn.Visible;
				}

				HideIdColumns();
				SelectLastRow();
				Focus();
				sqlConnection1.Close();
			}
		}

		internal void SelectLastRow()
		{
			if(RowCount > 0)
			{
				CurrentCell = Rows[RowCount - 1].Cells[1];
			}
		}

		protected override void OnDataSourceChanged(EventArgs e)
		{
			base.OnDataSourceChanged(e);

			if(DataSourceCustom == null)
			{
				return;
			}

			(DataSourceCustom as DataTable).DefaultView.RowFilter = RowFilterValue;

			if(Columns["Last"] != null)
			{
				(DataSourceCustom as DataTable).DefaultView.Sort = "Last asc";
			}

			HideIdColumns();

			foreach(DataGridViewColumn column in Columns)
			{
				if(column.ValueType != typeof(string))
				{
					column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
					column.MinimumWidth = 40;
					column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
				}
				else
				{
					column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				}

				if(column.ValueType == typeof(bool))
				{
					column.SortMode = DataGridViewColumnSortMode.Automatic;
				}
			}

			LoadColumnSorting();
			LoadScrollPosition();
		}

		private static object GetValueByType(SqlDataReader reader, GridColumn gridColumn)
		{
			if(gridColumn.Type == typeof(bool))
			{
				return reader[gridColumn.Name].ToString() == "True";
			}

			if(gridColumn.Type == typeof(float) || gridColumn.Type == typeof(int))
			{
				return reader[gridColumn.Name].ToString() == string.Empty ? "0" : reader[gridColumn.Name].ToString();
			}

			return reader[gridColumn.Name];
		}

		private void BeforeDataSourceCustomChanged(object value)
		{
			SaveRowFilter();

			if(value == null)
			{
				SaveScrollPosition();
			}

			SaveColumnSortring();
		}

		//TODO: Filter column that hyperlinks from here, put goodreads link and imdb in it
		private void DataGridCustomCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == -1 && e.RowIndex == -1)
			{
				ReFillGrid();
			}
		}

		private void DataGridCustomPaint(object sender, PaintEventArgs e)
		{
			if(e == null)
			{
				return;
			}

			var rows = SelectedRows.Count > 1 ? SelectedRows.Count : RowCount;

			using(SolidBrush solidBrush = new SolidBrush(RowHeadersDefaultCellStyle.ForeColor))
			{
				e.Graphics.DrawString((rows).ToString(), DefaultFont, solidBrush, 10, 5);
			}
		}

		private void DataGridCustomSelectionChanged(object sender, EventArgs e)
		{
			Invalidate();
		}

		private void HideIdColumns()
		{
			if(Columns["ID"] != null)
			{
				Columns["ID"].Visible = false;
			}

			if(Columns["ItemID"] != null)
			{
				Columns["ItemID"].Visible = false;
			}

			if(Columns["GoodreadsID"] != null)
			{
				Columns["GoodreadsID"].Visible = false;
			}

			if(Columns["Imdb"] != null)
			{
				Columns["Imdb"].Visible = false;
			}
		}

		private void LoadColumnSorting()
		{
			if(sortedColumnName == null || !Columns.Contains(sortedColumnName))
			{
				return;
			}

			Sort(Columns[sortedColumnName], sortDirection);
		}

		private void LoadScrollPosition()
		{
			try
			{
				VerticalScrollBar.Value = VerticalScrollBarPosition;
			}
			catch(Exception)
			{
			}
		}

		private void ReFillGrid()
		{
			FillGrid(m_query, m_gridColumsList);
		}

		private void SaveColumnSortring()
		{
			if(SortedColumn == null)
			{
				return;
			}

			sortedColumnName = SortedColumn.Name;
			sortDirection = SortedColumn.HeaderCell.SortGlyphDirection == System.Windows.Forms.SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending;
		}

		private void SaveRowFilter()
		{
			if(DataSourceCustom != null)
			{
				RowFilterValue = RowFilter;
			}
		}

		private void SaveScrollPosition()
		{
			VerticalScrollBarPosition = VerticalScrollBar.Value;
		}

		public struct GridColumn
		{
			public string Name;
			public Type Type;
			public bool Visible;

			public GridColumn(string name, Type type = null, bool visible = true)
			{
				Name = name;
				Type = type ?? typeof(string);
				Visible = visible;
			}
		}
	}
}