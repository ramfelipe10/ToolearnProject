using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TooLearnOfficial
{
    public partial class Dialogue1 : Form
    {
        public Dialogue1()
        {
            InitializeComponent();
        }

        static Dialogue1 MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnOK, string btnCancel)
        {
            MsgBox = new Dialogue1();
            MsgBox.label2.Text = Text;
            MsgBox.bunifuFlatButton1.Text = btnOK;
            MsgBox.bunifuFlatButton2.Text = btnCancel;
            MsgBox.ShowDialog();
            return result;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            MsgBox.Close();
        }
    }
}
