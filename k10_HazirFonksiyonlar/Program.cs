﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k10_HazirFonksiyonlar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new matematik_fonksiyonlar());
            //Application.Run(new sfonksiyonlar());
            Application.Run(new DatetimrFonksiyonlar());

        }
    }
}
