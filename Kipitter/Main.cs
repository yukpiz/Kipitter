using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KipitterCore;

namespace Kipitter
{
    public partial class Main : Form
    {
        private UserControl activePane;
        private PaneTradeBoard paneTradeBoard;
        private PaneBattleTimer paneBattleTimer;
        private PaneAlarm paneAlarm;
        private PaneKnights paneKnights;
        private PaneSetting paneSetting;

        public Main()
        {
            InitializeComponent();

            //Initialzie Panel Instances.
            paneTradeBoard = new PaneTradeBoard();
            paneBattleTimer = new PaneBattleTimer();
            paneAlarm = new PaneAlarm();
            paneKnights = new PaneKnights();
            paneSetting = new PaneSetting();
        }

        private void disableLink(LinkLabel linkLabel)
        {
            //Set disable if the type is matched.
            linkTradeBoard.Enabled = !linkLabel.Equals(linkTradeBoard);
            linkBattleTimer.Enabled = !linkLabel.Equals(linkBattleTimer);
            linkAlarm.Enabled = !linkLabel.Equals(linkAlarm);
            linkKnights.Enabled = !linkLabel.Equals(linkKnights);
            linkSetting.Enabled = !linkLabel.Equals(linkSetting);
        }

        private void switchPane(UserControl pane)
        {
            pane.Dock = DockStyle.Fill;
            activePane = pane;
            splitContainer2.Panel1.Controls.Clear();
            splitContainer2.Panel1.Controls.Add(activePane);
        }

        private void main_Load(object sender, EventArgs e)
        {
            //HttpRequest req = new HttpRequest();
            //req.Get();

            WeekEffect weekEffect = ErinnTimer.getWeekEffect();

            string title = string.Join(" ", new string[] {
                weekEffect.RealWeekJp,
                weekEffect.ErinnWeekJp,
                weekEffect.ErinnWeekEn,
            });
            toolWeekEffect.ToolTipTitle = title;

            string effects = string.Join("\n  ", weekEffect.Effects);
            string items = string.Join("\n  ", weekEffect.FlcItems);
            string toolTip = 
                "[曜日効果]\n  " + effects +
                "\n\n" +
                "[FLCアイテム]\n  " + items;
            toolWeekEffect.SetToolTip(labelRealTime, toolTip);
            toolWeekEffect.SetToolTip(labelErinnTime, toolTip);
        }

        private void linkTradeBoard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            disableLink((LinkLabel)sender);
            switchPane(paneTradeBoard);
        }

        private void linkBattleTimer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            disableLink((LinkLabel)sender);
            switchPane(paneBattleTimer);
        }

        private void linkAlarm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            disableLink((LinkLabel)sender);
            switchPane(paneAlarm);
        }

        private void linkKnights_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            disableLink((LinkLabel)sender);
            switchPane(paneKnights);
        }

        private void linkSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            disableLink((LinkLabel)sender);
            switchPane(paneSetting);
        }

        private void erinnTimer_Tick(object sender, EventArgs e)
        {
            DateTime erinnTime = ErinnTimer.getErinnTime();
            labelErinnTime.Text = erinnTime.ToString("[ET] H:mm");
        }

        private void realTimer_Tick(object sender, EventArgs e)
        {
            DateTime realTime = DateTime.Now;
            labelRealTime.Text = realTime.ToString("[RT] H:mm");
        }
    }
}
