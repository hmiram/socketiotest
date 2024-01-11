using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocketIOClient;
using Newtonsoft.Json;



namespace socketiotest
{
    public partial class Form1 : Form
    {

        //const domain = "rsmh.inrs.cz";

        private delegate void SafeCallDelegate(string text);


        private delegate void SafeCallDelegateLbl(string text);
        private delegate void SafeCallDelegateLbl2(string text);

        SocketIOClient.SocketIO client = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conect();
        }

        private void WriteTextSafe(string text)
        {
            if (rtLog.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                rtLog.Invoke(d, new object[] { text });
            }
            else
            {
                rtLog.Text += text + "\n";
            }
        }


        private DataEmit GetDataEmit(string text)
        {

            DataEmit dataEmit = new DataEmit { Rele_no = 0, Cas_jede = 0, Cas_priprava = 0 };


           
                               

            Dictionary<string, string> atr = JsonConvert.DeserializeObject<Dictionary<string, string>>(text);

            if (atr.ContainsKey("rele_no"))
            {
                try
                {
                    dataEmit.Rele_no = Int32.Parse(atr["rele_no"]);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{atr["rele_no"]}'");
                }
            }
            else
            {
                throw new Exception("V JSON neni rele_no");
            }

            if (atr.ContainsKey("cas_priprava"))
            {

                try
                {
                    dataEmit.Cas_priprava = Int32.Parse(atr["cas_priprava"]);
                }
                catch (FormatException)
                {
                        
                    Console.WriteLine($"Unable to parse '{atr["cas_priprava"]}'");
                }

            }

            if (atr.ContainsKey("cas_jede"))
            {

                try
                {
                    dataEmit.Cas_jede = Int32.Parse(atr["cas_jede"]);
                }
                catch (FormatException)
                {                        
                    Console.WriteLine($"Unable to parse '{atr["cas_jede"]}'");
                }

            }
            else
            {
                throw new Exception("V JSON neni cas_jede");
            }

            // SPOSTIM RELE 
            //data = $"SPOSTIM RELE: Rele_no = '{atr["rele_no"]}', cas_priprava ='{cas_priprava}' , cas_jede = '{cas_jede}'";

                

            
            return dataEmit;

        }

        private void StartDelegateInfo(string text)
        {
            if (lblDelegate.InvokeRequired)
            {
                var d = new SafeCallDelegateLbl(StartDelegateInfo);
                lblDelegate.Invoke(d, new object[] { text });
            }
            else
            {
                rtLog.Text += "Receive: " + text + "\n";

                
                

                try
                {

                    DataEmit de = GetDataEmit(text);

                    string data = "Spoustim " + de.ToString();

                    if (de.Rele_no > 0)
                    {

                        if (de.Rele_no == 1)
                        {
                            lblS1Info.Text = data;
                        }
                        else if (de.Rele_no == 2)
                        {
                            lblS2Info.Text = data;
                        }

                    }

                }
                catch (Exception ex)
                {                    
                    WriteTextSafe(ex.Message);
                }

                //lbl.Text = ex.Message;

                


                

            }
        }


        private void StopDelegateInfo(string text)
        {
            if (lblDelegate.InvokeRequired)
            {
                var d = new SafeCallDelegateLbl(StopDelegateInfo);
                lblDelegate.Invoke(d, new object[] { text });
            }
            else
            {
                rtLog.Text += text + "\n";




                try
                {

                    DataEmit de = GetDataEmit(text);

                    string data = "Zastavuju " + de.ToString();

                    if (de.Rele_no > 0)
                    {

                        if (de.Rele_no == 1)
                        {
                            lblS1Info.Text = data;
                        }
                        else if (de.Rele_no == 2)
                        {
                            lblS2Info.Text = data;
                        }

                    }

                }
                catch (Exception ex)
                {
                    WriteTextSafe(ex.Message);
                }

                //lbl.Text = ex.Message;






            }
        }

        public async void Conect()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;


                //socketio.inrs.cz:2020176.98.244.77:

                client = new SocketIOClient.SocketIO("https://socketio.inrs.cz:2020/", new SocketIOOptions
                //client = new SocketIOClient.SocketIO("http://127.0.0.1:2020/", new SocketIOOptions
                {
                    EIO = SocketIO.Core.EngineIO.V3
                });

                /*client = new SocketIOClient.SocketIO("http://46.28.111.31:2021/", new SocketIOOptions
                {                    
                    EIO = 3                    
                });*/


                /*client = new SocketIOClient.SocketIO("http://127.0.0.1:2021/", new SocketIOOptions
                {
                    EIO = 3
                });*/

                //client = new SocketIOClient.SocketIO("http://46.28.111.31:3001/");

                //client.Options.ConnectionTimeout = new TimeSpan(0, 0, 0, 5);


                client.On("solarko_start_" + Config.Domain, response =>
                {
                    // You can print the returned data first to decide what to do next.                   
                    Console.WriteLine(response);
                    StartDelegateInfo(response.GetValue<string>());
                  
                });


                client.On("solarko_stop_" + Config.Domain, response =>
                {
                    // You can print the returned data first to decide what to do next.                   
                    Console.WriteLine(response);
                    StopDelegateInfo(response.GetValue<string>());

                });

                client.On("chat message", response =>
                {
                    // You can print the returned data first to decide what to do next.                   
                    Console.WriteLine(response);
                    //StopDelegateInfo(response.GetValue<string>());

                });
                



                string s = client.HttpClient.ToString();

                await client.ConnectAsync();

                rtLog.Text += "Pripojeni OK\n";


                bool connetOk = true;
            }
            
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                rtLog.Text = ex.Message;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }


        /*public async void Odeslat()
        {

            if ((client == null) || (!client.Connected))
                throw new Exception("Nejsu pripojeny k socket IO!");


            Dictionary<string, string> points = new Dictionary<string, string>
                {
                    { "id", "YzdrcmZ0blZUcWNlemJWNVRFeHdrdz09" },
                    { "token", "_xtokenOC9sU3A0TTFsaWFSa1BPdjh2ZlhZdz09" },
                    { "solarko_id", "1" },
                    { "domain", Config.Domain }
                };


            await client.EmitAsync("solarko_started", JsonConvert.SerializeObject(points, Formatting.Indented));
        }*/

        private void btnSend_Click(object sender, EventArgs e)
        {
            /*if (client == null)
            {
                rtLog.Text += "Neni pripojeno k serveru\n";
                return; 
            }

            if (!client.Connected)
            {
                rtLog.Text += "Neni pripojeno k serveru\n";
                return;
            }

            Odeslat();
            */

        }

        public bool isConnect()
        {
            return ((client != null) && (client.Connected));
        }


        public async void Start(int i)
        {

            
            Dictionary<string, string> points = new Dictionary<string, string>
                {
                    { "id", Config.Id },
                    { "token", Config.Token },
                    { "rele_no", i.ToString() },
                    { "domain", Config.Domain }
                };


            rtLog.Text += "Send solarko_started: " + JsonConvert.SerializeObject(points, Formatting.Indented) + "\n";

            await client.EmitAsync("solarko_started", JsonConvert.SerializeObject(points, Formatting.Indented));

            //Console.WriteLine("END");

            //return true;
        }


        public async void Stop(int i)
        {


            Dictionary<string, string> points = new Dictionary<string, string>
                {
                    { "id", Config.Id },
                    { "token", Config.Token },
                    { "rele_no", i.ToString() },
                    { "domain", Config.Domain }
                };


            rtLog.Text += "Send solarko_stopped: " + JsonConvert.SerializeObject(points, Formatting.Indented) + "\n";

            await client.EmitAsync("solarko_stopped", JsonConvert.SerializeObject(points, Formatting.Indented));

            //Console.WriteLine("END");

            //return true;
        }


        private void btnS1Start_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConnect())
                    throw new Exception("Nepripojeni");

                Start(1);
                
            }
            catch (Exception ex)
            {
                rtLog.Text += ex.Message + "\n";
            }
            
        }

        private void btnS2Start_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConnect())
                    throw new Exception("Nepripojeni");

                Start(2);
                
            }
            catch (Exception ex)
            {
                rtLog.Text += ex.Message + "\n";
            }
            
        }

        private void btnS1Stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConnect())
                    throw new Exception("Nepripojeni");

                Stop(1);

            }
            catch (Exception ex)
            {
                rtLog.Text += ex.Message + "\n";
            }

        }

        private void btnS2Stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConnect())
                    throw new Exception("Nepripojeni");

                Stop(2);

            }
            catch (Exception ex)
            {
                rtLog.Text += ex.Message + "\n";
            }

        }
    }
}
