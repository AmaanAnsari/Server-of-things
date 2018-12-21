namespace Server_of_things
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lab_Konsole = new System.Windows.Forms.Label();
            this.txt_command = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.grp_server = new System.Windows.Forms.GroupBox();
            this.btn_restart = new System.Windows.Forms.Button();
            this.grp_anzeige = new System.Windows.Forms.GroupBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_speed = new System.Windows.Forms.TextBox();
            this.grp_tickspeed = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_tick16 = new System.Windows.Forms.RadioButton();
            this.rdb_tick08 = new System.Windows.Forms.RadioButton();
            this.rdb_tick04 = new System.Windows.Forms.RadioButton();
            this.rdb_tick01 = new System.Windows.Forms.RadioButton();
            this.rdb_tick60 = new System.Windows.Forms.RadioButton();
            this.rdb_tick25 = new System.Windows.Forms.RadioButton();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.lbl_help = new System.Windows.Forms.Label();
            this.lbl_clear = new System.Windows.Forms.Label();
            this.lbl_apply = new System.Windows.Forms.Label();
            this.lbl_stop = new System.Windows.Forms.Label();
            this.TM_Tickspeed = new System.Windows.Forms.Timer(this.components);
            this.btn_path = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TM_ChatPlugin = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.grp_server.SuspendLayout();
            this.grp_anzeige.SuspendLayout();
            this.grp_tickspeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_Konsole
            // 
            this.lab_Konsole.AutoSize = true;
            this.lab_Konsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Konsole.Location = new System.Drawing.Point(12, 468);
            this.lab_Konsole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Konsole.Name = "lab_Konsole";
            this.lab_Konsole.Size = new System.Drawing.Size(67, 17);
            this.lab_Konsole.TabIndex = 0;
            this.lab_Konsole.Text = "Konsole: ";
            // 
            // txt_command
            // 
            this.txt_command.Location = new System.Drawing.Point(93, 464);
            this.txt_command.Margin = new System.Windows.Forms.Padding(4);
            this.txt_command.Name = "txt_command";
            this.txt_command.Size = new System.Drawing.Size(671, 22);
            this.txt_command.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(779, 462);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(100, 28);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_continue
            // 
            this.btn_continue.Location = new System.Drawing.Point(116, 23);
            this.btn_continue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(100, 28);
            this.btn_continue.TabIndex = 3;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_weiter_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(8, 23);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(100, 28);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(224, 23);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(100, 28);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // grp_server
            // 
            this.grp_server.Controls.Add(this.btn_restart);
            this.grp_server.Controls.Add(this.btn_stop);
            this.grp_server.Controls.Add(this.btn_close);
            this.grp_server.Controls.Add(this.btn_continue);
            this.grp_server.Location = new System.Drawing.Point(16, 15);
            this.grp_server.Margin = new System.Windows.Forms.Padding(4);
            this.grp_server.Name = "grp_server";
            this.grp_server.Padding = new System.Windows.Forms.Padding(4);
            this.grp_server.Size = new System.Drawing.Size(447, 63);
            this.grp_server.TabIndex = 6;
            this.grp_server.TabStop = false;
            this.grp_server.Text = "Hardware";
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(332, 23);
            this.btn_restart.Margin = new System.Windows.Forms.Padding(4);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(100, 28);
            this.btn_restart.TabIndex = 6;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // grp_anzeige
            // 
            this.grp_anzeige.Controls.Add(this.btn_path);
            this.grp_anzeige.Controls.Add(this.btn_apply);
            this.grp_anzeige.Controls.Add(this.btn_clear);
            this.grp_anzeige.Location = new System.Drawing.Point(512, 16);
            this.grp_anzeige.Margin = new System.Windows.Forms.Padding(4);
            this.grp_anzeige.Name = "grp_anzeige";
            this.grp_anzeige.Padding = new System.Windows.Forms.Padding(4);
            this.grp_anzeige.Size = new System.Drawing.Size(335, 63);
            this.grp_anzeige.TabIndex = 7;
            this.grp_anzeige.TabStop = false;
            this.grp_anzeige.Text = "Software";
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(113, 25);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(100, 28);
            this.btn_apply.TabIndex = 1;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(9, 25);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 28);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_speed
            // 
            this.txt_speed.Location = new System.Drawing.Point(8, 31);
            this.txt_speed.Margin = new System.Windows.Forms.Padding(4);
            this.txt_speed.Multiline = true;
            this.txt_speed.Name = "txt_speed";
            this.txt_speed.ReadOnly = true;
            this.txt_speed.Size = new System.Drawing.Size(302, 24);
            this.txt_speed.TabIndex = 9;
            // 
            // grp_tickspeed
            // 
            this.grp_tickspeed.Controls.Add(this.label1);
            this.grp_tickspeed.Controls.Add(this.rdb_tick16);
            this.grp_tickspeed.Controls.Add(this.rdb_tick08);
            this.grp_tickspeed.Controls.Add(this.rdb_tick04);
            this.grp_tickspeed.Controls.Add(this.rdb_tick01);
            this.grp_tickspeed.Controls.Add(this.rdb_tick60);
            this.grp_tickspeed.Controls.Add(this.txt_speed);
            this.grp_tickspeed.Controls.Add(this.rdb_tick25);
            this.grp_tickspeed.Location = new System.Drawing.Point(16, 86);
            this.grp_tickspeed.Margin = new System.Windows.Forms.Padding(4);
            this.grp_tickspeed.Name = "grp_tickspeed";
            this.grp_tickspeed.Padding = new System.Windows.Forms.Padding(4);
            this.grp_tickspeed.Size = new System.Drawing.Size(863, 63);
            this.grp_tickspeed.TabIndex = 10;
            this.grp_tickspeed.TabStop = false;
            this.grp_tickspeed.Text = "Tickspeed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "in Seconds";
            // 
            // rdb_tick16
            // 
            this.rdb_tick16.AutoSize = true;
            this.rdb_tick16.Location = new System.Drawing.Point(448, 32);
            this.rdb_tick16.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_tick16.Name = "rdb_tick16";
            this.rdb_tick16.Size = new System.Drawing.Size(45, 21);
            this.rdb_tick16.TabIndex = 16;
            this.rdb_tick16.TabStop = true;
            this.rdb_tick16.Text = "16";
            this.rdb_tick16.UseVisualStyleBackColor = true;
            // 
            // rdb_tick08
            // 
            this.rdb_tick08.AutoSize = true;
            this.rdb_tick08.Location = new System.Drawing.Point(412, 32);
            this.rdb_tick08.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_tick08.Name = "rdb_tick08";
            this.rdb_tick08.Size = new System.Drawing.Size(37, 21);
            this.rdb_tick08.TabIndex = 15;
            this.rdb_tick08.TabStop = true;
            this.rdb_tick08.Text = "8";
            this.rdb_tick08.UseVisualStyleBackColor = true;
            // 
            // rdb_tick04
            // 
            this.rdb_tick04.AutoSize = true;
            this.rdb_tick04.Location = new System.Drawing.Point(367, 32);
            this.rdb_tick04.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_tick04.Name = "rdb_tick04";
            this.rdb_tick04.Size = new System.Drawing.Size(37, 21);
            this.rdb_tick04.TabIndex = 14;
            this.rdb_tick04.TabStop = true;
            this.rdb_tick04.Text = "4";
            this.rdb_tick04.UseVisualStyleBackColor = true;
            // 
            // rdb_tick01
            // 
            this.rdb_tick01.AutoSize = true;
            this.rdb_tick01.Location = new System.Drawing.Point(318, 32);
            this.rdb_tick01.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_tick01.Name = "rdb_tick01";
            this.rdb_tick01.Size = new System.Drawing.Size(41, 21);
            this.rdb_tick01.TabIndex = 13;
            this.rdb_tick01.TabStop = true;
            this.rdb_tick01.Text = "1 ";
            this.rdb_tick01.UseVisualStyleBackColor = true;
            // 
            // rdb_tick60
            // 
            this.rdb_tick60.AutoSize = true;
            this.rdb_tick60.Location = new System.Drawing.Point(549, 32);
            this.rdb_tick60.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_tick60.Name = "rdb_tick60";
            this.rdb_tick60.Size = new System.Drawing.Size(45, 21);
            this.rdb_tick60.TabIndex = 11;
            this.rdb_tick60.TabStop = true;
            this.rdb_tick60.Text = "60";
            this.rdb_tick60.UseVisualStyleBackColor = true;
            // 
            // rdb_tick25
            // 
            this.rdb_tick25.AutoSize = true;
            this.rdb_tick25.Location = new System.Drawing.Point(496, 32);
            this.rdb_tick25.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_tick25.Name = "rdb_tick25";
            this.rdb_tick25.Size = new System.Drawing.Size(45, 21);
            this.rdb_tick25.TabIndex = 12;
            this.rdb_tick25.TabStop = true;
            this.rdb_tick25.Text = "25";
            this.rdb_tick25.UseVisualStyleBackColor = true;
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(24, 156);
            this.txt_output.Margin = new System.Windows.Forms.Padding(4);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_output.Size = new System.Drawing.Size(491, 299);
            this.txt_output.TabIndex = 11;
            // 
            // lbl_help
            // 
            this.lbl_help.AutoSize = true;
            this.lbl_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_help.Location = new System.Drawing.Point(631, 157);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(41, 17);
            this.lbl_help.TabIndex = 12;
            this.lbl_help.Text = "Help:";
            // 
            // lbl_clear
            // 
            this.lbl_clear.AutoSize = true;
            this.lbl_clear.Location = new System.Drawing.Point(523, 189);
            this.lbl_clear.Name = "lbl_clear";
            this.lbl_clear.Size = new System.Drawing.Size(294, 17);
            this.lbl_clear.TabIndex = 13;
            this.lbl_clear.Text = "If you want to clear the TextBox click --> Clear";
            // 
            // lbl_apply
            // 
            this.lbl_apply.AutoSize = true;
            this.lbl_apply.Location = new System.Drawing.Point(523, 210);
            this.lbl_apply.Name = "lbl_apply";
            this.lbl_apply.Size = new System.Drawing.Size(307, 17);
            this.lbl_apply.TabIndex = 14;
            this.lbl_apply.Text = "To Apply the Tickspeed changes click --> Apply";
            // 
            // lbl_stop
            // 
            this.lbl_stop.AutoSize = true;
            this.lbl_stop.Location = new System.Drawing.Point(523, 231);
            this.lbl_stop.Name = "lbl_stop";
            this.lbl_stop.Size = new System.Drawing.Size(278, 17);
            this.lbl_stop.TabIndex = 15;
            this.lbl_stop.Text = "If you want to stop the Server click --> Stop";
            // 
            // TM_Tickspeed
            // 
            this.TM_Tickspeed.Enabled = true;
            this.TM_Tickspeed.Interval = 10000;
            this.TM_Tickspeed.Tick += new System.EventHandler(this.TM_Tickspeed_Tick);
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(220, 26);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(100, 28);
            this.btn_path.TabIndex = 2;
            this.btn_path.Text = "Path ...";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "To chose a Path click --> Path...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(523, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Buttons:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Commands:";
            // 
            // TM_ChatPlugin
            // 
            this.TM_ChatPlugin.Interval = 1000;
            this.TM_ChatPlugin.Tick += new System.EventHandler(this.TM_ChatPlugin_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "/Chat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_stop);
            this.Controls.Add(this.lbl_apply);
            this.Controls.Add(this.lbl_clear);
            this.Controls.Add(this.lbl_help);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.grp_tickspeed);
            this.Controls.Add(this.grp_anzeige);
            this.Controls.Add(this.grp_server);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_command);
            this.Controls.Add(this.lab_Konsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Server of things";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_server.ResumeLayout(false);
            this.grp_anzeige.ResumeLayout(false);
            this.grp_tickspeed.ResumeLayout(false);
            this.grp_tickspeed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Konsole;
        private System.Windows.Forms.TextBox txt_command;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox grp_server;
        private System.Windows.Forms.GroupBox grp_anzeige;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_speed;
        private System.Windows.Forms.GroupBox grp_tickspeed;
        private System.Windows.Forms.RadioButton rdb_tick01;
        private System.Windows.Forms.RadioButton rdb_tick25;
        private System.Windows.Forms.RadioButton rdb_tick60;
        private System.Windows.Forms.RadioButton rdb_tick16;
        private System.Windows.Forms.RadioButton rdb_tick08;
        private System.Windows.Forms.RadioButton rdb_tick04;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label lbl_help;
        private System.Windows.Forms.Label lbl_clear;
        private System.Windows.Forms.Label lbl_apply;
        private System.Windows.Forms.Label lbl_stop;
        private System.Windows.Forms.Timer TM_Tickspeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer TM_ChatPlugin;
        private System.Windows.Forms.Label label5;
    }
}

