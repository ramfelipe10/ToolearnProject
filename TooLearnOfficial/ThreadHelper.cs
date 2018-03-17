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
        delegate void AddLabelCallback(Form frm, Label lbl, string text);
        delegate void AddTxtBtnCallback(Form frm, Bunifu.Framework.UI.BunifuFlatButton btn, string text);
        delegate void PanelOutCallback(Form frm, Control ctrl, bool text);
        delegate void FormCloseCallback(Form frm);
        delegate void BunifuBox(Form frm, Bunifu.Framework.UI.BunifuMetroTextbox ctrl, bool text);
        delegate void ControlOUt(Form frm, Bunifu.Framework.UI.BunifuFlatButton ctrl, bool text);
        delegate void imgbuttonin(Form frm, Bunifu.Framework.UI.BunifuImageButton ctrl, bool text);
        delegate void settextmetro(Form frm, Bunifu.Framework.UI.BunifuMetroTextbox ctrl, string text);
        delegate void lvadd(Form frm, ListView lv, ListViewItem text);
        delegate void lvremove(Form frm, ListView lv, int position);
        delegate void lvinsert(Form frm, ListView lv, ListViewItem item, int position);







        public static void lvInsertItem(Form frm, ListView lv, ListViewItem item, int position)
        {
            if (lv.InvokeRequired)
            {
                lvinsert d = new lvinsert(lvInsertItem);
                frm.Invoke(d, new object[] { frm, lv, item, position });
            }
            else
            {
                lv.Items.Insert(position,item);
            }
        }


        public static void lvRemoveItem(Form frm, ListView lv, int position)
        {
            if (lv.InvokeRequired)
            {
                lvremove d = new lvremove(lvRemoveItem);
                frm.Invoke(d, new object[] { frm, lv, position });
            }
            else
            {
                lv.Items.RemoveAt(position);
            }
        }

        public static void lvAddItem(Form frm, ListView lv, ListViewItem text)
        {
            if (lv.InvokeRequired)
            {
                lvadd d = new lvadd(lvAddItem);
                frm.Invoke(d, new object[] { frm, lv, text });
            }
            else
            {
                lv.Items.Add(text);
            }
        }

        public static void metrotext(Form frm, Bunifu.Framework.UI.BunifuMetroTextbox ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                settextmetro d = new settextmetro(metrotext);
                frm.Invoke(d, new object[] { frm, ctrl, text });
            }
            else
            {
                ctrl.Text=text;
            }
        }



        public static void imgbtnIN(Form frm, Bunifu.Framework.UI.BunifuImageButton ctrl, bool text)
        {
            if (frm.InvokeRequired)
            {
                imgbuttonin d = new imgbuttonin(imgbtnIN);
                frm.Invoke(d, new object[] { frm, ctrl, text });
            }
            else
            {
                ctrl.Visible = text;
            }
        }




        public static void ControlHide(Form frm, Bunifu.Framework.UI.BunifuFlatButton ctrl, bool text)
        {
            if (frm.InvokeRequired)
            {
                ControlOUt d = new ControlOUt(ControlHide);
                frm.Invoke(d, new object[] { frm, ctrl, text });
            }
            else
            {
                ctrl.Visible = text;
            }
        }


        public static void BunifuBoxHide(Form frm, Bunifu.Framework.UI.BunifuMetroTextbox ctrl, bool text)
        {
            if (frm.InvokeRequired)
            {
                BunifuBox d = new BunifuBox(BunifuBoxHide);
                frm.Invoke(d, new object[] { frm, ctrl, text });
            }
            else
            {
                ctrl.Visible = text;
            }
        }





        public static void Hide(Form frm)
        {
            if (frm.InvokeRequired)
            {
                FormCloseCallback d = new FormCloseCallback(Hide);
                frm.Invoke(d, new object[] { frm });
            }
            else
            {
                frm.Close();
            }
        }


        public static void PanelOut(Form frm, Control ctrl, bool text)
        {
            if (ctrl.InvokeRequired)
            {
                PanelOutCallback d = new PanelOutCallback(PanelOut);
                frm.Invoke(d, new object[] { frm, ctrl, text });
            }
            else
            {
                ctrl.Visible = text;
            }
        }


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

       public static void lblAddLabel(Form frm, Label lbl, string text)
        {
            if (lbl.InvokeRequired)
            {
                AddLabelCallback d = new AddLabelCallback(lblAddLabel);
                frm.Invoke(d, new object[] { frm, lbl, text });
            }
            else
            {
                lbl.Text = text;
            }
        }

        public static void btnAddTxtButton(Form frm, Bunifu.Framework.UI.BunifuFlatButton btn, string text)
        {
            if (btn.InvokeRequired)
            {
                AddTxtBtnCallback d = new AddTxtBtnCallback(btnAddTxtButton);
                frm.Invoke(d, new object[] { frm, btn, text });
            }
            else
            {
                btn.Text = text;
            }
        }


    }
}
