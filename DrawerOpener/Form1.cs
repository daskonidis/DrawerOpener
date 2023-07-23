using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawerOpener
{
    public partial class Form1 : Form
    {
        public Form1(string[] args)
        {
            InitializeComponent();

            if(args != null && args.Length > 0)
            {
                string printer = string.Join(" ", args);

                if (!string.IsNullOrEmpty(printer))
                {
                    byte[] esqData = new byte[] { 27, 112, 0, 25, 255 };
                    RawPrinterHelper.SendStringToPrinter(printer, Encoding.Default.GetString(esqData));
                }
            }
            

            Environment.Exit(0);
        }
    }
}
