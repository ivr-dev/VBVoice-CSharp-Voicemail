namespace VoicemailApp
{
    partial class Voicemail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voicemail));
            this.vbvFrame1 = new Pronexus.VBVoice.VBVFrame();
            this.DonePW = new Pronexus.VBVoice.Outcon();
            this.PWChanged = new Pronexus.VBVoice.PlayGreeting();
            this.SetNewPW = new Pronexus.VBVoice.DataChange();
            this.ReenterPW = new Pronexus.VBVoice.GetDigits();
            this.PWNoChg = new Pronexus.VBVoice.PlayGreeting();
            this.GetNewPW = new Pronexus.VBVoice.GetDigits();
            this.RecNewGreet = new Pronexus.VBVoice.Record();
            this.GreetOpts = new Pronexus.VBVoice.GetDigits();
            this.RecNewName = new Pronexus.VBVoice.Record();
            this.playMsgs1 = new Pronexus.VBVoice.PlayMsgs();
            this.SubscriberMenu = new Pronexus.VBVoice.GetDigits();
            this.CheckPW = new Pronexus.VBVoice.GetDigits();
            this.CheckBox = new Pronexus.VBVoice.DataFind();
            this.NameOpts = new Pronexus.VBVoice.GetDigits();
            this.GetMailbox = new Pronexus.VBVoice.GetDigits();
            this.WaitBusy = new Pronexus.VBVoice.Delay();
            this.TakeMessage = new Pronexus.VBVoice.Record();
            this.AskHold = new Pronexus.VBVoice.GetDigits();
            this.Goodbye = new Pronexus.VBVoice.OnHook();
            this.NoGoodBye = new Pronexus.VBVoice.OnHook();
            this.Flash = new Pronexus.VBVoice.Dial();
            this.Announce = new Pronexus.VBVoice.GetDigits();
            this.TransferCall = new Pronexus.VBVoice.Dial();
            this.CallerName = new Pronexus.VBVoice.Record();
            this.NoMoreNames = new Pronexus.VBVoice.PlayGreeting();
            this.NoNames = new Pronexus.VBVoice.PlayGreeting();
            this.SayExtension = new Pronexus.VBVoice.PlayGreeting();
            this.CheckName = new Pronexus.VBVoice.GetDigits();
            this.FindName = new Pronexus.VBVoice.DataFind();
            this.GetName = new Pronexus.VBVoice.GetDigits();
            this.TimeRoute = new Pronexus.VBVoice.TimeSwitch();
            this.SetReception = new Pronexus.VBVoice.User();
            this.ValidateXfer = new Pronexus.VBVoice.DataFind();
            this.MainMenu = new Pronexus.VBVoice.GetDigits();
            this.Greeting1 = new Pronexus.VBVoice.PlayGreeting();
            this.NewCall = new Pronexus.VBVoice.LineGroup();
            ((System.ComponentModel.ISupportInitialize)(this.vbvFrame1)).BeginInit();
            this.vbvFrame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonePW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWChanged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetNewPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReenterPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWNoChg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetNewPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecNewGreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreetOpts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecNewName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playMsgs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubscriberMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameOpts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetMailbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitBusy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TakeMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AskHold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goodbye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoGoodBye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Announce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CallerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoMoreNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SayExtension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetReception)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidateXfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greeting1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewCall)).BeginInit();
            this.SuspendLayout();
            // 
            // vbvFrame1
            // 
            this.vbvFrame1.Controls.Add(this.DonePW);
            this.vbvFrame1.Controls.Add(this.PWChanged);
            this.vbvFrame1.Controls.Add(this.SetNewPW);
            this.vbvFrame1.Controls.Add(this.ReenterPW);
            this.vbvFrame1.Controls.Add(this.PWNoChg);
            this.vbvFrame1.Controls.Add(this.GetNewPW);
            this.vbvFrame1.Controls.Add(this.RecNewGreet);
            this.vbvFrame1.Controls.Add(this.GreetOpts);
            this.vbvFrame1.Controls.Add(this.RecNewName);
            this.vbvFrame1.Controls.Add(this.playMsgs1);
            this.vbvFrame1.Controls.Add(this.SubscriberMenu);
            this.vbvFrame1.Controls.Add(this.CheckPW);
            this.vbvFrame1.Controls.Add(this.CheckBox);
            this.vbvFrame1.Controls.Add(this.NameOpts);
            this.vbvFrame1.Controls.Add(this.GetMailbox);
            this.vbvFrame1.Controls.Add(this.WaitBusy);
            this.vbvFrame1.Controls.Add(this.TakeMessage);
            this.vbvFrame1.Controls.Add(this.AskHold);
            this.vbvFrame1.Controls.Add(this.Goodbye);
            this.vbvFrame1.Controls.Add(this.NoGoodBye);
            this.vbvFrame1.Controls.Add(this.Flash);
            this.vbvFrame1.Controls.Add(this.Announce);
            this.vbvFrame1.Controls.Add(this.TransferCall);
            this.vbvFrame1.Controls.Add(this.CallerName);
            this.vbvFrame1.Controls.Add(this.NoMoreNames);
            this.vbvFrame1.Controls.Add(this.NoNames);
            this.vbvFrame1.Controls.Add(this.SayExtension);
            this.vbvFrame1.Controls.Add(this.CheckName);
            this.vbvFrame1.Controls.Add(this.FindName);
            this.vbvFrame1.Controls.Add(this.GetName);
            this.vbvFrame1.Controls.Add(this.TimeRoute);
            this.vbvFrame1.Controls.Add(this.SetReception);
            this.vbvFrame1.Controls.Add(this.ValidateXfer);
            this.vbvFrame1.Controls.Add(this.MainMenu);
            this.vbvFrame1.Controls.Add(this.Greeting1);
            this.vbvFrame1.Controls.Add(this.NewCall);
            this.vbvFrame1.Location = new System.Drawing.Point(0, 2);
            this.vbvFrame1.Name = "vbvFrame1";
            this.vbvFrame1.PropertyBag = resources.GetString("vbvFrame1.PropertyBag");
            this.vbvFrame1.Size = new System.Drawing.Size(698, 346);
            this.vbvFrame1.TabIndex = 0;
            // 
            // DonePW
            // 
            this.DonePW.Location = new System.Drawing.Point(376, 2227);
            this.DonePW.Name = "DonePW";
            this.DonePW.PropertyBag = resources.GetString("DonePW.PropertyBag");
            this.DonePW.TabIndex = 35;
            // 
            // PWChanged
            // 
            this.PWChanged.Location = new System.Drawing.Point(495, 2114);
            this.PWChanged.Name = "PWChanged";
            this.PWChanged.PropertyBag = resources.GetString("PWChanged.PropertyBag");
            this.PWChanged.TabIndex = 34;
            // 
            // SetNewPW
            // 
            this.SetNewPW.Location = new System.Drawing.Point(399, 2114);
            this.SetNewPW.Name = "SetNewPW";
            this.SetNewPW.PropertyBag = resources.GetString("SetNewPW.PropertyBag");
            this.SetNewPW.TabIndex = 33;
            // 
            // ReenterPW
            // 
            this.ReenterPW.Location = new System.Drawing.Point(236, 2043);
            this.ReenterPW.Name = "ReenterPW";
            this.ReenterPW.PropertyBag = resources.GetString("ReenterPW.PropertyBag");
            this.ReenterPW.TabIndex = 32;
            this.ReenterPW.Condition += new AxVBVoiceLib._DGetdgEvents_ConditionEventHandler(this.ReenterPW_Condition);
            // 
            // PWNoChg
            // 
            this.PWNoChg.Location = new System.Drawing.Point(223, 2189);
            this.PWNoChg.Name = "PWNoChg";
            this.PWNoChg.PropertyBag = resources.GetString("PWNoChg.PropertyBag");
            this.PWNoChg.TabIndex = 31;
            // 
            // GetNewPW
            // 
            this.GetNewPW.Location = new System.Drawing.Point(84, 2073);
            this.GetNewPW.Name = "GetNewPW";
            this.GetNewPW.PropertyBag = resources.GetString("GetNewPW.PropertyBag");
            this.GetNewPW.TabIndex = 30;
            // 
            // RecNewGreet
            // 
            this.RecNewGreet.Location = new System.Drawing.Point(332, 204);
            this.RecNewGreet.Name = "RecNewGreet";
            this.RecNewGreet.PropertyBag = resources.GetString("RecNewGreet.PropertyBag");
            this.RecNewGreet.TabIndex = 29;
            // 
            // GreetOpts
            // 
            this.GreetOpts.Location = new System.Drawing.Point(109, 186);
            this.GreetOpts.Name = "GreetOpts";
            this.GreetOpts.PropertyBag = resources.GetString("GreetOpts.PropertyBag");
            this.GreetOpts.TabIndex = 28;
            // 
            // RecNewName
            // 
            this.RecNewName.Location = new System.Drawing.Point(319, 57);
            this.RecNewName.Name = "RecNewName";
            this.RecNewName.PropertyBag = resources.GetString("RecNewName.PropertyBag");
            this.RecNewName.TabIndex = 27;
            // 
            // playMsgs1
            // 
            this.playMsgs1.Location = new System.Drawing.Point(420, 2196);
            this.playMsgs1.Name = "playMsgs1";
            this.playMsgs1.PropertyBag = resources.GetString("playMsgs1.PropertyBag");
            this.playMsgs1.TabIndex = 26;
            // 
            // SubscriberMenu
            // 
            this.SubscriberMenu.Location = new System.Drawing.Point(226, 2205);
            this.SubscriberMenu.Name = "SubscriberMenu";
            this.SubscriberMenu.PropertyBag = resources.GetString("SubscriberMenu.PropertyBag");
            this.SubscriberMenu.TabIndex = 25;
            // 
            // CheckPW
            // 
            this.CheckPW.Location = new System.Drawing.Point(448, 2082);
            this.CheckPW.Name = "CheckPW";
            this.CheckPW.PropertyBag = resources.GetString("CheckPW.PropertyBag");
            this.CheckPW.TabIndex = 24;
            // 
            // CheckBox
            // 
            this.CheckBox.Location = new System.Drawing.Point(226, 2078);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.PropertyBag = resources.GetString("CheckBox.PropertyBag");
            this.CheckBox.TabIndex = 23;
            // 
            // NameOpts
            // 
            this.NameOpts.Location = new System.Drawing.Point(108, 49);
            this.NameOpts.Name = "NameOpts";
            this.NameOpts.PropertyBag = resources.GetString("NameOpts.PropertyBag");
            this.NameOpts.TabIndex = 22;
            // 
            // GetMailbox
            // 
            this.GetMailbox.Location = new System.Drawing.Point(85, 2078);
            this.GetMailbox.Name = "GetMailbox";
            this.GetMailbox.PropertyBag = resources.GetString("GetMailbox.PropertyBag");
            this.GetMailbox.TabIndex = 21;
            // 
            // WaitBusy
            // 
            this.WaitBusy.Location = new System.Drawing.Point(427, 2268);
            this.WaitBusy.Name = "WaitBusy";
            this.WaitBusy.PropertyBag = resources.GetString("WaitBusy.PropertyBag");
            this.WaitBusy.TabIndex = 20;
            // 
            // TakeMessage
            // 
            this.TakeMessage.Location = new System.Drawing.Point(427, 2182);
            this.TakeMessage.Name = "TakeMessage";
            this.TakeMessage.PropertyBag = resources.GetString("TakeMessage.PropertyBag");
            this.TakeMessage.TabIndex = 19;
            // 
            // AskHold
            // 
            this.AskHold.Location = new System.Drawing.Point(280, 2221);
            this.AskHold.Name = "AskHold";
            this.AskHold.PropertyBag = resources.GetString("AskHold.PropertyBag");
            this.AskHold.TabIndex = 18;
            // 
            // Goodbye
            // 
            this.Goodbye.Location = new System.Drawing.Point(547, 2195);
            this.Goodbye.Name = "Goodbye";
            this.Goodbye.PropertyBag = resources.GetString("Goodbye.PropertyBag");
            this.Goodbye.TabIndex = 17;
            // 
            // NoGoodBye
            // 
            this.NoGoodBye.Location = new System.Drawing.Point(541, 2058);
            this.NoGoodBye.Name = "NoGoodBye";
            this.NoGoodBye.PropertyBag = resources.GetString("NoGoodBye.PropertyBag");
            this.NoGoodBye.TabIndex = 16;
            // 
            // Flash
            // 
            this.Flash.Location = new System.Drawing.Point(359, 2096);
            this.Flash.Name = "Flash";
            this.Flash.PropertyBag = resources.GetString("Flash.PropertyBag");
            this.Flash.TabIndex = 15;
            // 
            // Announce
            // 
            this.Announce.Location = new System.Drawing.Point(246, 2052);
            this.Announce.Name = "Announce";
            this.Announce.PropertyBag = resources.GetString("Announce.PropertyBag");
            this.Announce.TabIndex = 14;
            // 
            // TransferCall
            // 
            this.TransferCall.Location = new System.Drawing.Point(98, 2146);
            this.TransferCall.Name = "TransferCall";
            this.TransferCall.PropertyBag = resources.GetString("TransferCall.PropertyBag");
            this.TransferCall.TabIndex = 13;
            // 
            // CallerName
            // 
            this.CallerName.Location = new System.Drawing.Point(87, 2034);
            this.CallerName.Name = "CallerName";
            this.CallerName.PropertyBag = resources.GetString("CallerName.PropertyBag");
            this.CallerName.TabIndex = 12;
            // 
            // NoMoreNames
            // 
            this.NoMoreNames.Location = new System.Drawing.Point(296, 2252);
            this.NoMoreNames.Name = "NoMoreNames";
            this.NoMoreNames.PropertyBag = resources.GetString("NoMoreNames.PropertyBag");
            this.NoMoreNames.TabIndex = 11;
            // 
            // NoNames
            // 
            this.NoNames.Location = new System.Drawing.Point(296, 2163);
            this.NoNames.Name = "NoNames";
            this.NoNames.PropertyBag = resources.GetString("NoNames.PropertyBag");
            this.NoNames.TabIndex = 10;
            // 
            // SayExtension
            // 
            this.SayExtension.Location = new System.Drawing.Point(427, 2066);
            this.SayExtension.Name = "SayExtension";
            this.SayExtension.PropertyBag = resources.GetString("SayExtension.PropertyBag");
            this.SayExtension.TabIndex = 9;
            // 
            // CheckName
            // 
            this.CheckName.Location = new System.Drawing.Point(296, 2058);
            this.CheckName.Name = "CheckName";
            this.CheckName.PropertyBag = resources.GetString("CheckName.PropertyBag");
            this.CheckName.TabIndex = 8;
            // 
            // FindName
            // 
            this.FindName.Location = new System.Drawing.Point(192, 2058);
            this.FindName.Name = "FindName";
            this.FindName.PropertyBag = resources.GetString("FindName.PropertyBag");
            this.FindName.TabIndex = 7;
            // 
            // GetName
            // 
            this.GetName.Location = new System.Drawing.Point(65, 2030);
            this.GetName.Name = "GetName";
            this.GetName.PropertyBag = resources.GetString("GetName.PropertyBag");
            this.GetName.TabIndex = 6;
            // 
            // TimeRoute
            // 
            this.TimeRoute.Location = new System.Drawing.Point(370, 2165);
            this.TimeRoute.Name = "TimeRoute";
            this.TimeRoute.PropertyBag = resources.GetString("TimeRoute.PropertyBag");
            this.TimeRoute.TabIndex = 5;
            // 
            // SetReception
            // 
            this.SetReception.Location = new System.Drawing.Point(507, 2241);
            this.SetReception.Name = "SetReception";
            this.SetReception.PropertyBag = resources.GetString("SetReception.PropertyBag");
            this.SetReception.TabIndex = 4;
            this.SetReception.EnterEvent += new AxVBVoiceLib._DUserEvents_EnterEventHandler(this.SetReception_EnterEvent);
            // 
            // ValidateXfer
            // 
            this.ValidateXfer.Location = new System.Drawing.Point(121, 2222);
            this.ValidateXfer.Name = "ValidateXfer";
            this.ValidateXfer.PropertyBag = resources.GetString("ValidateXfer.PropertyBag");
            this.ValidateXfer.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(223, 2042);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.PropertyBag = resources.GetString("MainMenu.PropertyBag");
            this.MainMenu.TabIndex = 2;
            // 
            // Greeting1
            // 
            this.Greeting1.Location = new System.Drawing.Point(101, 2042);
            this.Greeting1.Name = "Greeting1";
            this.Greeting1.PropertyBag = resources.GetString("Greeting1.PropertyBag");
            this.Greeting1.TabIndex = 1;
            // 
            // NewCall
            // 
            this.NewCall.Location = new System.Drawing.Point(11, 2032);
            this.NewCall.Name = "NewCall";
            this.NewCall.PropertyBag = resources.GetString("NewCall.PropertyBag");
            this.NewCall.TabIndex = 0;
            // 
            // Voicemail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 347);
            this.Controls.Add(this.vbvFrame1);
            this.Name = "Voicemail";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vbvFrame1)).EndInit();
            this.vbvFrame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DonePW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWChanged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetNewPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReenterPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWNoChg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetNewPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecNewGreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreetOpts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecNewName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playMsgs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubscriberMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameOpts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetMailbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaitBusy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TakeMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AskHold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goodbye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoGoodBye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Announce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CallerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoMoreNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SayExtension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetReception)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidateXfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greeting1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewCall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Pronexus.VBVoice.VBVFrame vbvFrame1;
        private Pronexus.VBVoice.LineGroup NewCall;
        private Pronexus.VBVoice.GetDigits MainMenu;
        private Pronexus.VBVoice.PlayGreeting Greeting1;
        private Pronexus.VBVoice.PlayGreeting NoMoreNames;
        private Pronexus.VBVoice.PlayGreeting NoNames;
        private Pronexus.VBVoice.PlayGreeting SayExtension;
        private Pronexus.VBVoice.GetDigits CheckName;
        private Pronexus.VBVoice.DataFind FindName;
        private Pronexus.VBVoice.GetDigits GetName;
        private Pronexus.VBVoice.TimeSwitch TimeRoute;
        private Pronexus.VBVoice.User SetReception;
        private Pronexus.VBVoice.DataFind ValidateXfer;
        private Pronexus.VBVoice.Dial TransferCall;
        private Pronexus.VBVoice.Record CallerName;
        private Pronexus.VBVoice.GetDigits Announce;
        private Pronexus.VBVoice.Dial Flash;
        private Pronexus.VBVoice.Delay WaitBusy;
        private Pronexus.VBVoice.Record TakeMessage;
        private Pronexus.VBVoice.GetDigits AskHold;
        private Pronexus.VBVoice.OnHook Goodbye;
        private Pronexus.VBVoice.OnHook NoGoodBye;
        private Pronexus.VBVoice.GetDigits GetMailbox;
        private Pronexus.VBVoice.GetDigits NameOpts;
        private Pronexus.VBVoice.GetDigits SubscriberMenu;
        private Pronexus.VBVoice.GetDigits CheckPW;
        private Pronexus.VBVoice.DataFind CheckBox;
        private Pronexus.VBVoice.Record RecNewGreet;
        private Pronexus.VBVoice.GetDigits GreetOpts;
        private Pronexus.VBVoice.Record RecNewName;
        private Pronexus.VBVoice.PlayMsgs playMsgs1;
        private Pronexus.VBVoice.GetDigits GetNewPW;
        private Pronexus.VBVoice.Outcon DonePW;
        private Pronexus.VBVoice.PlayGreeting PWChanged;
        private Pronexus.VBVoice.DataChange SetNewPW;
        private Pronexus.VBVoice.GetDigits ReenterPW;
        private Pronexus.VBVoice.PlayGreeting PWNoChg;
    }
}

