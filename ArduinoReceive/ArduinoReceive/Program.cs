using System;
using System.IO.Ports;

namespace ArduinoReceive
{
    class Program
    {
        static SerialPort _port;
        static int cnt = 2;
        static bool stop = false;
        static void Main(string[] args)
        {
            _port = new SerialPort("COM3",9600,Parity.None,8,StopBits.One);
            _port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            _port.Open();
            while(!stop)
            {

                do
                {
                    if (Console.ReadKey().KeyChar != (char)13)
                    {
                        Console.WriteLine(cnt.ToString());
                        _port.WriteLine(cnt++.ToString());
                    }  
                    else
                    {
                        stop = true;
                    }
                } while (cnt <= 4);
                cnt = 2;
            }
            _port.Close();
        }
        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.Write(indata);
        }
    }
}
