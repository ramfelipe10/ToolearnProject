using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TooLearnOfficial.User_Control_Facilitator
{
    public partial class Score : UserControl
    {
        public Score()
        {
            if (!this.DesignMode)
            {

                InitializeComponent();

                additem("Ram", "Science", "PICTUREPUZZLE", "10");
                additem("Anna", "Math", "QUIZBEE", "11");
                

            }
        }




        Random r = new Random();
        void additem(string _name, string _quiz, string _format, string _score)
        {
            bunifuCustomDataGrid1.Rows.Add();
            bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[0].Value = _name;
            bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[1].Value = _quiz;
            bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[2].Value = _format;
            bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[3].Value = _score;
            bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.Rows.Count - 1].Cells[4].Value = generate_pp(r.Next(0, 100));



        }
        public Image generate_pp(double pass)
        {
            double dg = double.Parse(dgpp.Width.ToString());
            double x = 0;
            x = (pass * dg) / 100;
            pictureBox3.Width = (int)Math.Round(x, 0);


            return PanelToBitmap(dgpp);

        }

        private static Image PanelToBitmap(Control pnl)
        {
            var bmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }
    }
}
