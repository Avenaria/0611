using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Threading;

namespace _0611
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        List<Process> processes = new List<Process>();
         private Process process;
        DispatcherTimer timer;  
        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void loadPricessor(object sendor , EventArgs e) {
            List<Process> processers = Process.GetProcesses().ToList();
            foreach (var process in processers) {
                string prName = process.ProcessName;
                string procID = process.Id.ToString();

                
               
            }
        }
        private void startTime()
        {
            timer=new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += loadPricessor ;
            timer.Start();
        }
         private void Calc()
        {
            process.StartInfo = new ProcessStartInfo("calc.exe");
            process.Start();
        }
        private void calcCtop()
        {
             process.Close();
        }

        

        //        ■ Идентификатор процесса;
        //■ Время старта;
        //■ Общее количество процессорного времени, потраченного на этот процесс;
        //■ Количество потоков;
        //■ Количество копий процесса такого вида(если у вас
        //запущено пять блокнотов, должно появиться число
        //пять)

    }
}
