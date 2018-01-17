using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VoicemailApp
{
    public partial class Voicemail : Form
    {

        public Voicemail()
        {
            InitializeComponent();
        }

        public Pronexus.VBVoice.VBVFrame VBVFrame
        {
            get
            {
                return vbvFrame1;
            }
        }

        private void SetReception_EnterEvent(object sender, AxVBVoiceLib._DUserEvents_EnterEvent e)
        {
            MainMenu.Digits[e.channel] = "100";
            SetReception.GotoNode[e.channel] = 0;
        }


        private void ReenterPW_Condition(object sender, AxVBVoiceLib._DGetdgEvents_ConditionEvent e)
        {
            if (ReenterPW.Digits[e.channel] == GetNewPW.Digits[e.channel])
                e.decided = -1;
            else
                e.decided = 0;

        }
    }
}
