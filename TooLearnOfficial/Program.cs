﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TooLearnOfficial
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static String Session_id, PSession_id; // For Facilitator
        public static int user_id, par_id=0; // For Participant
        public static int group_id=0; // For Group
        public static String serverIP;
        public static String source, db, id, password;// For Participant& G
        



        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());

         







        }
    }
}
