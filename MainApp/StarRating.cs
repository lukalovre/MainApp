using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MainApp
{
	public partial class StarRating : UserControl
	{
		protected int m_bottomMargin = 2;

		protected Color m_hoverColor = Color.RoyalBlue;

		protected bool m_hovering = false;

		protected int m_hoverStar = 0;

		protected int m_leftMargin = 2;

		protected Color m_outlineColor = Color.DarkGray;

		protected int m_outlineThickness = 1;

		protected int m_rightMargin = 2;

		protected Color m_selectedColor = Color.Yellow;

		protected int m_selectedStar = 0;

		protected Rectangle[] m_starAreas;

		protected int m_starCount = 5;

		protected int m_starSpacing = 8;

		protected int m_topMargin = 2;

		private List<string> m_ratingDescription = new List<string>
		{
			"did not like it",
			"it was ok",
			"liked it",
			"really liked it",
			"it was amazing"
		};

		private int m_starAreaHeight;
		private int m_starAreaWidth;

		public StarRating()
		{
			InitializeComponent();

			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, true);
			SetStyle(ControlStyles.ResizeRedraw, true);

			m_starAreaWidth = 145;
			m_starAreaHeight = 35;

			m_starAreas = new Rectangle[m_starCount];
		}

		public int SelectedStar
		{
			get => m_selectedStar;
			set
			{
				if(value == 0)
				{
					value++;
				}

				m_selectedStar = value;
				labelRatingDescription.Text = m_ratingDescription[value - 1];
				Invalidate();
			}
		}

		protected void DrawStar(Graphics g, Rectangle rect, int starAreaIndex)
		{
			Brush fillBrush;
			Pen outlinePen = new Pen(m_outlineColor, m_outlineThickness);

			if(m_hovering && m_hoverStar > starAreaIndex)
			{
				fillBrush = new LinearGradientBrush(rect, m_hoverColor, BackColor, LinearGradientMode.ForwardDiagonal);
			}
			else if((!m_hovering) && m_selectedStar > starAreaIndex)
			{
				fillBrush = new LinearGradientBrush(rect, m_selectedColor, BackColor, LinearGradientMode.ForwardDiagonal);
			}
			else
			{
				fillBrush = new SolidBrush(BackColor);
			}

			PointF[] p = new PointF[10];
			p[0].X = rect.X + (rect.Width / 2);
			p[0].Y = rect.Y;
			p[1].X = rect.X + (42 * rect.Width / 64);
			p[1].Y = rect.Y + (19 * rect.Height / 64);
			p[2].X = rect.X + rect.Width;
			p[2].Y = rect.Y + (22 * rect.Height / 64);
			p[3].X = rect.X + (48 * rect.Width / 64);
			p[3].Y = rect.Y + (38 * rect.Height / 64);
			p[4].X = rect.X + (52 * rect.Width / 64);
			p[4].Y = rect.Y + rect.Height;
			p[5].X = rect.X + (rect.Width / 2);
			p[5].Y = rect.Y + (52 * rect.Height / 64);
			p[6].X = rect.X + (12 * rect.Width / 64);
			p[6].Y = rect.Y + rect.Height;
			p[7].X = rect.X + rect.Width / 4;
			p[7].Y = rect.Y + (38 * rect.Height / 64);
			p[8].X = rect.X;
			p[8].Y = rect.Y + (22 * rect.Height / 64);
			p[9].X = rect.X + (22 * rect.Width / 64);
			p[9].Y = rect.Y + (19 * rect.Height / 64);

			g.FillPolygon(fillBrush, p);
			g.DrawPolygon(outlinePen, p);
		}

		protected override void OnClick(System.EventArgs args)
		{
			Point p = PointToClient(MousePosition);

			for(int i = 0; i < m_starCount; ++i)
			{
				if(m_starAreas[i].Contains(p))
				{
					m_hoverStar = i + 1;
					m_selectedStar = i + 1;
					Invalidate();
					break;
				}
			}

			base.OnClick(args);
		}

		protected override void OnMouseEnter(System.EventArgs ea)
		{
			m_hovering = true;
			Invalidate();
			base.OnMouseEnter(ea);
		}

		protected override void OnMouseLeave(System.EventArgs ea)
		{
			m_hovering = false;
			labelRatingDescription.Text = m_ratingDescription[SelectedStar - 1];
			Invalidate();
			base.OnMouseLeave(ea);
		}

		protected override void OnMouseMove(MouseEventArgs args)
		{
			for(int i = 0; i < m_starCount; ++i)
			{
				if(m_starAreas[i].Contains(args.X, args.Y))
				{
					m_hoverStar = i + 1;
					labelRatingDescription.Text = m_ratingDescription[i];
					Invalidate();
					break;
				}
			}

			base.OnMouseMove(args);
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			pe.Graphics.Clear(Color.White);

			int starWidth = (m_starAreaWidth - (m_leftMargin + m_rightMargin + (m_starSpacing * (m_starCount - 1)))) / m_starCount;
			int starHeight = m_starAreaHeight - (m_topMargin + m_bottomMargin);

			Rectangle drawArea = new Rectangle(m_leftMargin, m_topMargin, starWidth, starHeight);

			for(int i = 0; i < m_starCount; ++i)
			{
				m_starAreas[i].X = drawArea.X - m_starSpacing / 2;
				m_starAreas[i].Y = drawArea.Y;
				m_starAreas[i].Width = drawArea.Width + m_starSpacing / 2;
				m_starAreas[i].Height = drawArea.Height;

				DrawStar(pe.Graphics, drawArea, i);

				drawArea.X += drawArea.Width + m_starSpacing;
			}

			base.OnPaint(pe);
		}
	}
}