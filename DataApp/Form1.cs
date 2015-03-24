using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuantBox.XAPI.Callback;
using QuantBox.XAPI;
using QuantBox;
using System.Diagnostics;

namespace DataApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private XApi api;

        DataTable tickDataTable = new DataTable();







        /// <summary>
        /// OnConnectionStatus回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="status"></param>
        /// <param name="userLogin"></param>
        /// <param name="size1"></param>
        private void OnConnectionStatus(object sender, ConnectionStatus status, ref RspUserLoginField userLogin, int size1)
        {
            showInfo("showing info inside onConnectionStatus now");
            showInfo("//" + status + userLogin.ErrorMsg());
            
        }

        /// <summary>
        /// 深度行情回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="marketData"></param>

        private void OnRtnDepthMarketData(object sender, ref DepthMarketDataField marketData)
        {
            showInfo("showing info inside depth now");
            showInfo("//" + marketData.InstrumentID);
            showInfo("//" + marketData.ExchangeID);
            showInfo("//" + marketData.LastPrice.ToString());

            var row = tickDataTable.NewRow();

            foreach (var fi in typeof(DepthMarketDataField).GetFields())
            {
                switch (fi.Name)
                {
                    case "InstrumentID" :
                        row[fi.Name] = marketData.InstrumentID;
                        break;
                }
            }

        }

        
        /// <summary>
        /// 连接行情前置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void connectBt_Click(object sender, EventArgs e)
        {
            showInfo("begin");
            showInfo("Initialize api");
            api = new XApi(@"C:\Users\jht\Documents\Visual Studio 2013\Projects\DataApp\DataApp\dll\QuantBox_CTP_Quote.dll");
            showInfo("Initialize server info");
            api.Server.BrokerID = "66666";
            api.Server.Address = "tcp://ctp1-md9.citicsf.com:41213";

            showInfo("set 回调函数");
            api.OnConnectionStatus += OnConnectionStatus;
            api.OnRtnDepthMarketData += OnRtnDepthMarketData;

            showInfo("begin connecting");
            api.Connect();
            

            //Thread.Sleep(3000);
            //showInfo("begin dispose");
            //api.Dispose();

           //Thread.Sleep(5 * 1000);
        }

        /// <summary>
        /// 订阅行情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void getDataBt_Click(object sender, EventArgs e)
        {
            //showInfo("begin subscribe quotes");
            api.Subscribe("IF1504", "");
        }
        
        private void showInfo(string info)
        {
            this.Invoke(new Action(() =>
            {
                this.textBox1.Text += info + System.Environment.NewLine;
                this.textBox1.SelectionStart = this.textBox1.TextLength;
                this.textBox1.ScrollToCaret();
            }));
        }

        /// <summary>
        /// 初始化dataview窗口
        /// </summary>
        private void InitDataView()
        {
            
            Type t = typeof(DepthMarketDataField);
            string keyColumn = "UpdateTime,TradingDay,InstrumentID,ExchangeID";
            if (t == null)
                return;
            foreach (var v in t.GetFields())
            {
                tickDataTable.Columns.Add(v.Name, v.FieldType);
            }
            tickDataTable.PrimaryKey = keyColumn.Split(',').Select(v => tickDataTable.Columns[v]).ToArray();

            this.TickDataGridView.DataSource = tickDataTable;



        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            InitDataView();

        }

        /// <summary>
        /// 停止行情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopBt_Click(object sender, EventArgs e)
        {
            api.Dispose();
        }
        
    }
}
