using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYN_FIN
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void scanIP_Click(object sender, EventArgs e)
        {
            string startIP = startIPAddr.Text.Trim();
            string endIP = endIPAddr.Text.Trim();

            if (!System.Net.IPAddress.TryParse(startIP, out _))
            {
                MessageBox.Show("请输入有效的起始IP地址。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.Net.IPAddress.TryParse(endIP, out _))
            {
                MessageBox.Show("请输入有效的结束IP地址。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(threads.Text, out int threadCount) || threadCount <= 0 || threadCount > 100)
            {
                MessageBox.Show("线程数必须在1到100之间。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(delayTime.Text, out int delay) || delay < 0)
            {
                MessageBox.Show("请输入有效的延迟时间（毫秒）。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<int> specificPorts = null;

            if (partPortRadio.Checked)
            {
                specificPorts = ParseSpecificPorts(SpecificPorts.Text);
                if (specificPorts == null || specificPorts.Count == 0)
                {
                    MessageBox.Show("请输入有效的端口列表（例如: 80,443,8080）。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // 清空 DataGridView
            Invoke(new Action(() => dataGridView1.Rows.Clear()));

            var ipRange = GenerateIPRange(startIP, endIP);

            Task.Run(() =>
            {
                int serialNumber = 1;

                foreach (var ip in ipRange)
                {
                    UpdateStatus($"正在扫描 IP: {ip}");

                    PortScanner scanner = (specificPorts == null)
                        ? new PortScanner(ip, 0, 65535, threadCount, delay)
                        : new PortScanner(ip, specificPorts, threadCount, delay);

                    scanner.StartScan((port, status) =>
                    {
                        AddScanResult(serialNumber++, ip, port, status);
                    });
                }

                UpdateStatus("扫描完成！");
            });
        }

        private void AddScanResult(int serialNumber, string ip, int port, string status)
        {
            Invoke(new Action(() =>
            {
                dataGridView1.Rows.Add(serialNumber, ip, port, status);
                UpdateRowSerialNumbers();
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            }));
        }
        private void UpdateRowSerialNumbers()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private IEnumerable<string> GenerateIPRange(string startIP, string endIP)
        {
            byte[] startBytes = System.Net.IPAddress.Parse(startIP).GetAddressBytes();
            byte[] endBytes = System.Net.IPAddress.Parse(endIP).GetAddressBytes();

            while (true)
            {
                yield return string.Join(".", startBytes);

                if (startBytes.SequenceEqual(endBytes))
                    break;

                IncrementIP(startBytes);
            }
        }

        private void IncrementIP(byte[] bytes)
        {
            for (int i = 3; i >= 0; i--)
            {
                bytes[i]++;
                if (bytes[i] <= 255) break;
                bytes[i] = 0;
            }
        }

        private List<int> ParseSpecificPorts(string ports)
        {
            try
            {
                List<int> portList = new List<int>();
                string[] portStrings = ports.Split(',');

                foreach (var port in portStrings)
                {
                    if (int.TryParse(port.Trim(), out int parsedPort) && parsedPort > 0 && parsedPort <= 65535)
                    {
                        portList.Add(parsedPort);
                    }
                    else
                    {
                        return null;
                    }
                }

                return portList;
            }
            catch
            {
                return null;
            }
        }

        private void UpdateStatus(string message)
        {
            Invoke(new Action(() => statusLabel.Text = message));
        }

        private void allPortRadio_CheckedChanged(object sender, EventArgs e)
        {
            SpecificPorts.Enabled = !allPortRadio.Checked;
        }

        private void partPortRadio_CheckedChanged(object sender, EventArgs e)
        {
            SpecificPorts.Enabled = partPortRadio.Checked;
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }

    public class PortScanner
    {
        private string targetIP;
        private int startPort;
        private int endPort;
        private List<int> specificPorts;
        private int threadCount;
        private int delay;

        public PortScanner(string targetIP, int startPort, int endPort, int threadCount, int delay)
        {
            this.targetIP = targetIP;
            this.startPort = startPort;
            this.endPort = endPort;
            this.threadCount = threadCount;
            this.delay = delay;
        }

        public PortScanner(string targetIP, List<int> specificPorts, int threadCount, int delay)
        {
            this.targetIP = targetIP;
            this.specificPorts = specificPorts;
            this.threadCount = threadCount;
            this.delay = delay;
        }

        public void StartScan(Action<int, string> handleResult)
        {
            var tasks = new List<Task>();

            if (specificPorts == null)
            {
                int totalPorts = endPort - startPort + 1;
                int portsPerThread = totalPorts / threadCount;

                for (int i = 0; i < threadCount; i++)
                {
                    int threadStartPort = startPort + i * portsPerThread;
                    int threadEndPort = (i == threadCount - 1) ? endPort : threadStartPort + portsPerThread - 1;

                    tasks.Add(Task.Run(() =>
                    {
                        for (int port = threadStartPort; port <= threadEndPort; port++)
                        {
                            Thread.Sleep(delay);
                            bool isOpen = SendSYN(port);
                            handleResult(port, isOpen ? "打开" : "关闭");
                        }
                    }));
                }
            }
            else
            {
                foreach (int port in specificPorts)
                {
                    tasks.Add(Task.Run(() =>
                    {
                        Thread.Sleep(delay);
                        bool isOpen = SendSYN(port);
                        handleResult(port, isOpen ? "打开" : "关闭");
                    }));
                }
            }

            Task.WaitAll(tasks.ToArray());
        }

        private bool SendSYN(int port)
        {
            try
            {
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    socket.SendTimeout = 1000;
                    socket.ReceiveTimeout = 1000;
                    socket.Connect(new IPEndPoint(IPAddress.Parse(targetIP), port));
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
