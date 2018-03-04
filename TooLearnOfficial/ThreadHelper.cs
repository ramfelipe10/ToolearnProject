﻿using System;
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
        delegate void AddTxtBtnCallback(Form frm, Button btn, string text);

        delegate void PanelOutCallback(Form frm, Control ctrl, bool text);


        delegate void FormCloseCallback(Form frm);




        public static void Hide(Form frm)
        {
            if (frm.InvokeRequired)
            {
                FormCloseCallback d = new FormCloseCallback(Hide);
                frm.Invoke(d, new object[] { frm });
            }
            else
            {
                frm.Hide();
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

        public static void btnAddTxtButton(Form frm, Button btn, string text)
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
