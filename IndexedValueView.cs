using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseSim2021
{
    class IndexedValueView
    {
        public IndexedValue Value { get; set; }
        //carré du haut
        public List<IndexedValueView> Perks { get; set; }
        public List<IndexedValueView> Crisis { get; set; }
        //carré du milieu
        public List<IndexedValueView> Groups { get; set; }
        public List<IndexedValueView> Indicators { get; set; }
        //carré du bas
        public List<IndexedValueView> Exepenses { get; set; }
        public List<IndexedValueView> Taxes => WorldState.Taxes;
        public List<IndexedValueView> Quests { get; set; }
        public Point point { get; set; }
        Size size { get; set; }
        Color color { get; set; }

        static public void Draw(PaintEventArgs e, int Width, int Height)
        {

            //rajouter le draw des indexed values

            //test draw values
            //benef et pb
            for (int i = 0; i <= 11; i++)//Bénéfice/perks
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point((Width / 11) * i, Height / 20), new Size(Width / 11, Height / 6 - Height / 40)));
            }
            for (int i = 0; i <= 6; i++) //Crise/crisis
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point((Width / 6) * i, Height / 6 + Height / 40), new Size(Width / 6, Height / 6 - Height / 40)));
            }

            //indicateur
            for (int i = 0; i <= 1; i++)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point((Width / 6) * i, (Height / 3)), new Size(Width / 6, Height / 6 - Height / 40)));
                e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point((Width / 6) * (4 + i), (Height / 3)), new Size(Width / 6, Height / 6 - Height / 40)));
            }
            e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point(0, (Height / 3) + (Height / 6) - Height / 40), new Size(Width / 3, Height / 6 - Height / 40)));
            e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point((Width / 3) * 2, (Height / 3) + (Height / 6) - Height / 40), new Size(Width / 3, Height / 6 - Height / 40)));

            //groupes
            for (int i = 0; i <= 1; i++)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point((Width / 6) * (2 + i), (Height / 3)), new Size(Width / 6, Height / 6 - Height / 40)));
            }
            e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point(Width / 3, (Height / 3) + (Height / 6) - Height / 40), new Size(Width / 3, Height / 6 - Height / 40)));

            //politiques
            for (int i = 0; i <= 9; i++)//Depenses/expenses
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point((Width / 9) * i, (Height / 3) * 2 - Height / 20), new Size(Width / 9, Height / 9)));
            }
            for (int i = 0; i <= 5; i++)//Taxes/taxes
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point((Width / 5) * i, (Height / 3) * 2 + Height / 9 - Height / 20), new Size(Width / 5, Height / 9)));
            }
            for (int i = 0; i <= 7; i++)//Quetes/Quests
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point((Width / 7) * i, (Height / 3) * 2 + (Height / 9)*2 - Height / 20), new Size(Width / 7, Height / 9)));
            }
        }


    }
}
