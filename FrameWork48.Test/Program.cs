using Masuit.Tools.Hardware;
using Masuit.Tools.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrameWork48.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int i = 0;
                var xn = SystemInfo.GetMemoryVData();
                var wl = SystemInfo.GetMemoryPData();
                Console.WriteLine($"\r\n物理内存：{wl}");
                Console.WriteLine("\r\n点击任意键开始清理内存。");
                Console.ReadLine();
                Console.WriteLine("清理内存中,请等待。\r\n");                
                Task.Run(() =>
                {
                    while (i == 0)
                    {
                        Console.Write(".");
                        Thread.Sleep(TimeSpan.FromMilliseconds(300));
                    }
                });

                var dd = Windows.ClearMemory();
                i++;
                Console.WriteLine($"\r\n\r\n内存清理完成，当前内存使用率为：{dd}%");
            }
        }
    }
}
