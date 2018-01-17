namespace Voicemail
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vbvFrame1 = new Pronexus.VBVoice.VBVFrame();
            this.NewCall = new Pronexus.VBVoice.LineGroup();
            this.Greeting1 = new Pronexus.VBVoice.PlayGreeting();
            this.MainMenu = new Pronexus.VBVoice.GetDigits();
            this.ValidateXfer = new Pronexus.VBVoice.DataFind();
            this.SetReception = new Pronexus.VBVoice.User();
            this.TimeRoute = new Pronexus.VBVoice.TimeSwitch();
            this.GetName = new Pronexus.VBVoice.GetDigits();
            this.FindName = new Pronexus.VBVoice.DataFind();
            this.CheckName = new Pronexus.VBVoice.GetDigits();
            this.SayExtension = new Pronexus.VBVoice.PlayGreeting();
            this.NoNames = new Pronexus.VBVoice.PlayGreeting();
            this.NoMoreNames = new Pronexus.VBVoice.PlayGreeting();
            this.CallerName = new Pronexus.VBVoice.Record();
            this.TransferCall = new Pronexus.VBVoice.Dial();
            this.Announce = new Pronexus.VBVoice.GetDigits();
            this.Flash = new Pronexus.VBVoice.Dial();
            ((System.ComponentModel.ISupportInitialize)(this.vbvFrame1)).BeginInit();
            this.vbvFrame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greeting1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidateXfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetReception)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SayExtension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoMoreNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CallerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Announce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flash)).BeginInit();
            this.SuspendLayout();
            // 
            // vbvFrame1
            // 
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
            // NewCall
            // 
            this.NewCall.Location = new System.Drawing.Point(11, 2032);
            this.NewCall.Name = "NewCall";
            this.NewCall.PropertyBag = resources.GetString("NewCall.PropertyBag");
            this.NewCall.TabIndex = 0;
            // 
            // Greeting1
            // 
            this.Greeting1.Location = new System.Drawing.Point(101, 2042);
            this.Greeting1.Name = "Greeting1";
            this.Greeting1.PropertyBag = resources.GetString("Greeting1.PropertyBag");
            this.Greeting1.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(223, 2042);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.PropertyBag = resources.GetString("MainMenu.PropertyBag");
            this.MainMenu.TabIndex = 2;
            // 
            // ValidateXfer
            // 
            this.ValidateXfer.Location = new System.Drawing.Point(121, 2222);
            this.ValidateXfer.Name = "ValidateXfer";
            this.ValidateXfer.PropertyBag = resources.GetString("ValidateXfer.PropertyBag");
            this.ValidateXfer.TabIndex = 3;
            // 
            // SetReception
            // 
            this.SetReception.Location = new System.Drawing.Point(462, 2097);
            this.SetReception.Name = "SetReception";
            this.SetReception.PropertyBag = resources.GetString("SetReception.PropertyBag");
            this.SetReception.TabIndex = 4;
            // 
            // TimeRoute
            // 
            this.TimeRoute.Location = new System.Drawing.Point(328, 2222);
            this.TimeRoute.Name = "TimeRoute";
            this.TimeRoute.PropertyBag = resources.GetString("TimeRoute.PropertyBag");
            this.TimeRoute.TabIndex = 5;
            // 
            // GetName
            // 
            this.GetName.Location = new System.Drawing.Point(65, 2030);
            this.GetName.Name = "GetName";
            this.GetName.PropertyBag = resources.GetString("GetName.PropertyBag");
            this.GetName.TabIndex = 6;
            // 
            // FindName
            // 
            this.FindName.Location = new System.Drawing.Point(192, 2058);
            this.FindName.Name = "FindName";
            this.FindName.PropertyBag = resources.GetString("FindName.PropertyBag");
            this.FindName.TabIndex = 7;
            // 
            // CheckName
            // 
            this.CheckName.Location = new System.Drawing.Point(296, 2058);
            this.CheckName.Name = "CheckName";
            this.CheckName.PropertyBag = resources.GetString("CheckName.PropertyBag");
            this.CheckName.TabIndex = 8;
            // 
            // SayExtension
            // 
            this.SayExtension.Location = new System.Drawing.Point(427, 2066);
            this.SayExtension.Name = "SayExtension";
            this.SayExtension.PropertyBag = resources.GetString("SayExtension.PropertyBag");
            this.SayExtension.TabIndex = 9;
            // 
            // NoNames
            // 
            this.NoNames.Location = new System.Drawing.Point(296, 2163);
            this.NoNames.Name = "NoNames";
            this.NoNames.PropertyBag = resources.GetString("NoNames.PropertyBag");
            this.NoNames.TabIndex = 10;
            // 
            // NoMoreNames
            // 
            this.NoMoreNames.Location = new System.Drawing.Point(296, 2252);
            this.NoMoreNames.Name = "NoMoreNames";
            this.NoMoreNames.PropertyBag = resources.GetString("NoMoreNames.PropertyBag");
            this.NoMoreNames.TabIndex = 11;
            // 
            // CallerName
            // 
            this.CallerName.Location = new System.Drawing.Point(43, 36);
            this.CallerName.Name = "CallerName";
            this.CallerName.PropertyBag = resources.GetString("CallerName.PropertyBag");
            this.CallerName.TabIndex = 12;
            // 
            // TransferCall
            // 
            this.TransferCall.Location = new System.Drawing.Point(98, 146);
            this.TransferCall.Name = "TransferCall";
            this.TransferCall.PropertyBag = resources.GetString("TransferCall.PropertyBag");
            this.TransferCall.TabIndex = 13;
            // 
            // Announce
            // 
            this.Announce.Location = new System.Drawing.Point(246, 52);
            this.Announce.Name = "Announce";
            this.Announce.PropertyBag = resources.GetString("Announce.PropertyBag");
            this.Announce.TabIndex = 14;
            // 
            // Flash
            // 
            this.Flash.Location = new System.Drawing.Point(398, 109);
            this.Flash.Name = "Flash";
            this.Flash.PropertyBag = resources.GetString("Flash.PropertyBag");
            this.Flash.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 347);
            this.Controls.Add(this.vbvFrame1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vbvFrame1)).EndInit();
            this.vbvFrame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NewCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greeting1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidateXfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetReception)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SayExtension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoMoreNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CallerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Announce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flash)).EndInit();
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
    }
}

