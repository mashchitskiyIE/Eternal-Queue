using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Eternal_Queue
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ClDnstTB.Text = ClDnstTrB.Value.ToString();
            ClDen = ClDnstTrB.Value;
            ClDnstTrB.ValueChanged += new EventHandler((object s, EventArgs e) => { ClDnstTB.Text = ClDnstTrB.Value.ToString(); ClDen = ClDnstTrB.Value; });
            ArFreq = Convert.ToInt32(ArFreqNU.Value);
            ArFreqNU.ValueChanged += new EventHandler((object s, EventArgs e) => ArFreq = Convert.ToInt32(ArFreqNU.Value));
            CheckForIllegalCrossThreadCalls = false;
        }

        List<CashRegister> CRs = new List<CashRegister>();
        List<Thread> Threads = new List<Thread>();
        Thread TimeThread;
        bool isRunning = false;

        int MainQueue = 0, Served_General = 0, ClDen, ArFreq;
        static object MainLocker = new object();

        private void St_P_Button_Click(object sender, EventArgs e)
        {
            if (TimeThread == null)
            {
                isRunning = true;
                TimeThread = new Thread(() => StartTimer());
                TimeThread.Start();
                foreach (Thread T in Threads) T.Start();
            }
            else isRunning = !isRunning;
        }

        public void StartTimer()
        {
            Random rnd = new Random();
            while (true)
            {
                if (isRunning)
                {
                    int nC = rnd.Next(0, ClDen + 1);
                    lock (MainLocker)
                    {
                        MainQueue += nC;
                        MainQTB.Text = MainQueue.ToString();
                    }
                    if (CRs.Count > 0)
                    {
                        for (int i = 1; i <= nC; i++)
                        {
                            int n = rnd.Next(0, CRs.Count);
                            lock (CRs[n].Locker)
                            {
                                CRs[n].Queue++;
                                CashRegisterDGV.Rows[n].Cells[1].Value = CRs[n].Queue;
                            }
                        }
                    }
                }
                Thread.Sleep(ArFreq * 1000);
            }
        }

        public void StartWorkingCR(CashRegister CR)
        {
            while (true)
            {
                Thread.Sleep(CR.ServeTime);
                if (isRunning)
                {
                    lock (CR.Locker)
                    {
                        if (CR.Queue > 0)
                        {
                            lock (MainLocker)
                            {
                                MainQueue--;
                                MainQTB.Text = MainQueue.ToString();
                                Served_General++;
                                Served_GenTB.Text = Served_General.ToString();
                            }
                            int n = CRs.IndexOf(CR);
                            CR.Queue--;
                            CR.Served++;
                            if (n != -1)
                            {
                                CashRegisterDGV.Rows[n].Cells[1].Value = CR.Queue;
                                CashRegisterDGV.Rows[n].Cells[3].Value = CR.Served;
                            }
                        }
                    }
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Threads != null) foreach (Thread T in Threads) T.Abort();
            if (TimeThread != null) TimeThread.Abort();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (CRs.Count > 0) n = CRs.Last().Number + 1;
            CashRegister CR = new CashRegister(n, (int)ServeTimeNU.Value);
            if (CRs.Count == 0) lock(MainLocker) { CR.Queue = MainQueue; }
            CRs.Add(CR); 
            n = CashRegisterDGV.RowCount;
            CashRegisterDGV.RowCount++;
            CashRegisterDGV.Rows[n].Cells[0].Value = CRs[n].Number;
            CashRegisterDGV.Rows[n].Cells[1].Value = CR.Queue;
            CashRegisterDGV.Rows[n].Cells[2].Value = CRs[n].ServeTime / 1000;
            CashRegisterDGV.Rows[n].Cells[3].Value = 0;
            Thread T = new Thread(() => StartWorkingCR(CR));
            Threads.Add(T);
            if (TimeThread != null) T.Start();

        }

        private void CashRegisterDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int n = e.RowIndex;
                if (Threads != null) 
                {
                    Threads[n].Abort(); 
                    Threads.RemoveAt(n); 
                }
                CashRegister CR = CRs[n];
                lock (CR.Locker)
                {
                    CashRegisterDGV.Rows.RemoveAt(n);
                    CRs.RemoveAt(n);
                }
                Random rnd = new Random();
                while(CRs.Count > 0 && CR.Queue > 0)
                {
                    n = rnd.Next(0, CRs.Count);
                    lock (CRs[n].Locker) { CRs[n].Queue++; CashRegisterDGV.Rows[n].Cells[1].Value = CRs[n].Queue; }
                    CR.Queue--;
                }
            }
        }
    }
}
