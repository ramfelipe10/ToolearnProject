using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TooLearnOfficial
{
    public static class ThreadHelper
    {
        delegate void SetTextCallback(Form frm, Control ctrl, string text);
        delegate void AddItemCallback(Form frm, ListBox lsb, string text);

        public static void SetText(Form frm, Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                frm.Invoke(d, new object[] { frm, ctrl, text });
            }
            else
            {
                ctrl.Text = text;
            }
        }

        public static void lsbAddItem(Form frm, ListBox lsb, string text)
        {
            if (lsb.InvokeRequired)
            {
                AddItemCallback d = new AddItemCallback(lsbAddItem);
                frm.Invoke(d, new object[] { frm, lsb, text });
            }
            else
            {
                lsb.Items.Add(text);
            }
        }
    }
}
