using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace SerialLCD
{
    public class Program
    {
        // initialise the LCD display
        static LCD mylcd = new LCD("COM1");

        public static void Main()
        {
            while (true)
            {
                mylcd.backlight();
                mylcd.SetCursor(0, 0); // column, row
                byte[] message = System.Text.Encoding.UTF8.GetBytes("Hello World");
                mylcd.print(message);
                mylcd.SetCursor(15, 1); // column, row
                //mylcd.rightToLeft();
                mylcd.scrollDisplayLeft();
                mylcd.print(message);
                Thread.Sleep(500);
            }
        }

    }
}