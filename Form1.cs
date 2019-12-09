using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Potato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String comName;//com名称
        public int baud;//波特率
        public int status;//状态
        private SerialPort sp;

        private void Form1_Load(object sender, EventArgs e)
        {
            status = 0;//非打开状态
            //找到串口
            foreach (string vPortName in SerialPort.GetPortNames())
            {
                comlist.Items.Add(vPortName);
            }
            //设置找到的第一个为默认串口

            if (comlist.Items.Count > 0)
            {
                comlist.SelectedIndex = 0;
                comName = comlist.SelectedItem.ToString();
            }
            else
            {
                buttonCOM.Enabled = false;
                buttonTx.Enabled = false;
            }
            

            //波特率设置
            string[] bauds = { "9600","19200", "56000", "115200"};
            baudlist.Items.AddRange(bauds);
            //默认选择第一个，波特率为9600
            baudlist.SelectedIndex = 0;
            baud = 9600;

            buttonCOM.Text = "已关闭";
            sp = new SerialPort();
            sp.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                this.Invoke((EventHandler)(delegate
                {
                    textin.AppendText(sp.ReadExisting());
                }));
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void comlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获得选择的COM名称
            comName=comlist.SelectedItem.ToString();
        }

        private void buadlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //设置波特率
            baud = int.Parse(baudlist.SelectedItem.ToString());
        }

        private void buttonCOM_Click(object sender, EventArgs e)
        {
            //打开或关闭
            if (status==0)//关闭状态，则执行打开操作
            {

                OpenSP();
            }
            else//打开状态，执行关闭状态
            {
                buttonCOM.Text = "已关闭";
                sp.Close();
                status = 0;
            }
        }

        private void OpenSP()
        {
            try
            {
                sp.PortName = comName;
                sp.BaudRate = baud;
                sp.DataBits = 8;
                sp.StopBits = (StopBits)1;
                sp.ReadTimeout = 5000;
                sp.Open();
                buttonCOM.Text = "已开启";
                status = 1;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                throw e;
            }
        }

        private void buttonTx_Click(object sender, EventArgs e)
        {
            sp.WriteLine(textout.Text);
            textout.Text = "";
        }
    }
}