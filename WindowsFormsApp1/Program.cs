using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace WindowsFormsApp1
{
   public static class Program
    {
        static SerialPort _serialPort;
    
       // static string shou;
        
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
       public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new winform());

           _serialPort = new SerialPort();
            
            //  _serialPort.Open();
           
            winform.sign = _serialPort.IsOpen;
                
        }
    }
}
