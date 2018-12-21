using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Server_of_things
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        // [
        // Klassenvariablen  --> Anfang
        string wTM;
        int i = 0;
        int zahler = 0;
        string RunPath = Environment.CurrentDirectory;
        private FolderBrowserDialog folderBrowserDialog1;
            // -path's
            string BefehlInputPath;
            string TickPath;
            string ChatPluginNamePath;
            string InstalationPath;
            string OutputPath;
            string ChatChatverlaufPath;
            string TempPathPath;
            string ChatInputPath;
            string ChatTickspeedPath;
            string ChatRunPath;

        // Klassenvariablen  --> Ende  
        // ]

        // ---------------------------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------------------------

        public void PathIni()
        {
            // Path's der Dateien ... --> Anfang
            BefehlInputPath = RunPath + @"\BefehlInput.serv";
            TickPath = RunPath + @"\Tick.serv";
            ChatPluginNamePath = RunPath + @"\PluginName.serv"; 
            InstalationPath = RunPath + @"\Instalation.serv";
            OutputPath = RunPath + @"\Output.serv"; 
            ChatChatverlaufPath = RunPath + @"\Chat\Chatverlauf.serv";
            TempPathPath = Path.GetTempPath() + @"\ServerPath.serv";
            ChatInputPath = RunPath + @"\Chat\Input.serv";
            ChatTickspeedPath = RunPath + @"\Chat\Tickspeed.serv";
            ChatRunPath = RunPath + @"\Chat\Run.serv";
            // Path's der Dateien ... --> Ende
        }

        private void InstallFiles()
        {
            // Dateien erzeugen ... ---> Anfang
            txt_output.Text += ("\r\n<Server>: Server is instaling");
            File.WriteAllText(TickPath, "");
            File.WriteAllText(BefehlInputPath, "");
            File.WriteAllText(InstalationPath, "true");
            File.WriteAllText(OutputPath, "");
            File.WriteAllText(ChatPluginNamePath, "");
            File.WriteAllText(TempPathPath, RunPath);
            File.WriteAllText(ChatRunPath, "");
            txt_output.Text += ("\r\n<Server>: Server is installed");
            txt_output.Text += ("\r\n<Server>: Server is running");
            txt_output.Text += ("\r\n<Server>: Selected Folder : " + RunPath);
            // Dateien erzeugen ... ---> Ende
        }

        public void Befehle()
        {
            if (File.ReadAllText(BefehlInputPath) != "")
            {
                if (File.ReadAllText(BefehlInputPath) == "/Chat") Chat();
                else if (File.ReadAllText(BefehlInputPath) == "/Server")
                { Tick(); FormLoad(); }
                else txt_output.Text += ("\r\n<Server>: That isn't a right command."); 
            }
            File.WriteAllText(BefehlInputPath, "");

        }

        public Form1()
        {
            InitializeComponent();

        }

        public int Tick()
        {
            // Methode Tick : RDB uberprufen und in Datei schreiben --> Anfang
            DateTime Before = DateTime.Now;
            int TickSpeed = 2000;
            if (rdb_tick01.Checked) TickSpeed = 1 * 1000;
            else if (rdb_tick04.Checked) TickSpeed = 4 * 1000;
            else if (rdb_tick08.Checked) TickSpeed = 8 * 1000;
            else if (rdb_tick16.Checked) TickSpeed = 16 * 1000;
            else if (rdb_tick25.Checked) TickSpeed = 25 * 1000;
            else if (rdb_tick60.Checked) TickSpeed = 60 * 1000;
            else if (File.ReadAllText(TickPath) != "") TickSpeed = Convert.ToInt32(File.ReadAllText(TickPath)) ;

            DateTime After = DateTime.Now;
            TimeSpan Millisecond = After.Subtract(Before);
            double UseTime = Millisecond.TotalMilliseconds;

            txt_speed.Text = ("Need: " + UseTime + " mSec");
            File.WriteAllText(TickPath, Convert.ToString(TickSpeed));
            txt_output.Text += ("\r\n<Server>: Set Tickspeed to: " + TickSpeed/1000 + " sec.");
            TM_Tickspeed.Interval = TickSpeed;
            TM_ChatPlugin.Interval = TickSpeed;
            return TickSpeed;
            // Methode Tick : RDB uberprufen und in Datei schreiben --> Ende
        }

        private void TM_Tickspeed_Tick(object sender, EventArgs e)
        {
            // Timer fur den Server nomal , also die Server Engine --> Anfang
            DateTime Before = DateTime.Now;

            string Request = File.ReadAllText(BefehlInputPath);
            zahler++;
            Befehle();

            DateTime After = DateTime.Now;
            TimeSpan Millisecond = After.Subtract(Before);
            double UseTime = Millisecond.TotalMilliseconds;
            txt_speed.Text = ("Tack: " + zahler + " , UseTime: " + UseTime);
            // Timer fur den Server nomal , also die Server Engine --> Ende 

        }
        private void FormLoad()
        {
            // Methode Form Load wird zum Loaden benutz --> Anfang
            txt_output.Text = ("<Server>: Server is starting up.");
            txt_command.Text = "";
            if (File.Exists(TempPathPath) == true)
            {
                RunPath = File.ReadAllText(TempPathPath);
                if (File.Exists(InstalationPath))
                {
                    txt_output.Text = ("<Server>: Server is running.");
                    txt_output.Text += ("\r\n<Server>: Selected Folder : " + RunPath);

                }
                else
                {
                    InstallFiles();

                }
            }
            else
            {
                InstallFiles();
            }
            TM_Tickspeed.Enabled = true;
            TM_ChatPlugin.Enabled = false;
            // Methode Form Load wird zum Loaden benutz --> Ende
        }


        private void Chat()
        {
            // Methode Chat wir aufgerufen durch /Chat in der COmand Box --> Anfang
            File.WriteAllText(BefehlInputPath, "");
            Tick();
            TM_Tickspeed.Enabled = false;
            Directory.CreateDirectory(RunPath + @"\Chat");
            File.WriteAllText(ChatChatverlaufPath, "");
            File.WriteAllText(ChatInputPath, "");
            File.WriteAllText(ChatTickspeedPath, "");

            TM_ChatPlugin.Enabled = true;
            // Methode Chat wir aufgerufen durch /Chat in der COmand Box --> Anfang
        }

        private void TM_ChatPlugin_Tick(object sender, EventArgs e)
        {
            // Timer fur das ChatPlugin --> Anfang
            DateTime Before = DateTime.Now;
            string Input = File.ReadAllText(ChatInputPath);
            zahler++;

                if (File.ReadAllText(ChatRunPath) == "Run")
                {
                    if (Input != "")
                    {
                        File.AppendAllText(ChatChatverlaufPath, Input + "\r\n");
                        File.WriteAllText(ChatInputPath, "");
                    }
                    if (File.ReadAllText(BefehlInputPath) == "/Back")
                    {
                        Tick();
                        TM_ChatPlugin.Enabled = false;
                        TM_Tickspeed.Enabled = true;
                    }
                    if (i == 0)
                    {
                        if (File.ReadAllText(ChatRunPath) == "Run")
                        {
                            txt_output.Text = ("<Server>: Chat plugin is running.");
                            i = 1;
                        }                                          
                    }
                 }

                DateTime After = DateTime.Now;
            TimeSpan Millisecond = After.Subtract(Before);
            double UseTime = Millisecond.TotalMilliseconds;
            txt_speed.Text = ("Tack: " + zahler + " , UseTime: " + UseTime);
            // Timer fur das ChatPlugin --> Ende  


        }


        // ---------------------------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------------------------


        private void btn_close_Click_1(object sender, EventArgs e)
        {
            txt_output.Text = ("Server is shuting down.");
            this.Close();
        }

        public void btn_apply_Click(object sender, EventArgs e)
        {
            Tick();
        }

        private void btn_weiter_Click(object sender, EventArgs e)
        {
            if (wTM == "normal") TM_Tickspeed.Enabled = true;
            else if (wTM == "ChatPlugin") TM_ChatPlugin.Enabled = true;
            else
            {
                MessageBox.Show("Please Restart");
                Application.Restart();
            }
            txt_output.Text += ("\r\n<Server>: Server is continuing.");

        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (TM_Tickspeed.Enabled == true) wTM = "normal";
            else if (TM_ChatPlugin.Enabled == true) wTM = "ChatPlugin";
            TM_Tickspeed.Enabled = false;
            TM_ChatPlugin.Enabled = false;
            txt_output.Text += ("\r\n<Server>: Server stoped ... Click Continue to Continue ...");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

            txt_output.Text = ("<Server>: Server is running");
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            File.WriteAllText(BefehlInputPath, txt_command.Text);

        }

        private void btn_path_Click(object sender, EventArgs e)
        {
            TM_Tickspeed.Enabled = false;
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog1.Description = "Select the directory that you want to use as the default.";
            this.folderBrowserDialog1.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            string folderName = folderBrowserDialog1.SelectedPath;
            txt_output.Text += ("\r\n<Server>: Selected Folder :" + folderName);
            RunPath = folderName;
            //
            File.WriteAllText(TempPathPath, RunPath);
 //           File.
            Application.Restart();

        }

        // Buttons ende ... 

        public void Form1_Load(object sender, EventArgs e)
        {
            i = 0;
            PathIni();
            FormLoad();
            Tick();
            
        }

        // ----------------------------------------------------------------------------------------------------------


    }
}

// Das Problem besteht darin , dass die Garphik wärend der While Schleife nicht ausgeführt wird ... , weil die GPU nicht interher kommt
