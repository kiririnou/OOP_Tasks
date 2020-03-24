using System;
using System.Threading;
using System.Windows.Forms;

namespace Multithreading
{
    public partial class Form1 : Form
    {
        Thread th;
        Thread parametrized;

        public Form1()
        {
            InitializeComponent();
        }

        private static void EvaluateMultiplication()
        {
            int res = 1;

            for (int i = 1; i <= 21; i++)
            {
                if (i % 3 == 0)
                    res *= i;
                Thread.Sleep(1500);
            }

            MessageBox.Show("Thread id = " + Thread.CurrentThread.ManagedThreadId.ToString() + " : res = " + res, "Result");
        }

        private static void EvaluateMultiplicationWithData(object data)
        {
            int res = 1;

            for (int i = 1; i <= 21; i++)
            {
                if (i % 3 == 0)
                    res *= i;
                Thread.Sleep(1500);
            }

            MessageBox.Show("Thread id = " + Thread.CurrentThread.ManagedThreadId.ToString() + " : res = " + res + "\nArgument = " + (string)data, "Result");
        }

        private void btn_startThread_Click(object sender, EventArgs e)
        {
            th = new Thread(new ThreadStart(EvaluateMultiplication));
            th.Priority = ThreadPriority.BelowNormal;
            th.Start();
        }

        private void btn_stopThread_Click(object sender, EventArgs e)
        {
            if (th == null || !th.IsAlive)
            {
                MessageBox.Show("Background thread is not alive!", "Error");
                return;
            }

            int id = th.ManagedThreadId;
            th.Abort();
            MessageBox.Show(string.Format("Thread with id {0} has been stopped!", id), "Info");
        }

        private void btn_CallMethod_Click(object sender, EventArgs e)
        {
            EvaluateMultiplication();
        }

        private void btn_parametrized_Click(object sender, EventArgs e)
        {
            parametrized = new Thread(new ParameterizedThreadStart(EvaluateMultiplicationWithData));
            parametrized.Start("With parameter");
        }
    }
}
