﻿using System;
using System.IO;


namespace Hearthstone_Counter
{
    class Rogue
    {
        WinWriter ww = new WinWriter();
        LossWriter lw = new LossWriter();
        WinReader wr = new WinReader();
        LossReader lr = new LossReader();
        public bool selected;
        public int roguewins;
        public int roguelosses;
        string eMessage;
        public void WriteWins(int T)
        {
            ww.WriteRogueWins(T);
        }
        public void WriteLosses(int T)
        {
            lw.WriteRogueLosses(T);
        }
        public void ReadLosses()
        {
            lr.ReadRogueLosses(ref roguelosses);
        }
        public void ReadWins()
        {
            wr.ReadRogueWins(ref roguewins);
        }
        public void rogueButtonCLICKED(HSCounter hsc)
        {            
            rogueButtonIsSelected(hsc);
            DeselectOthers(hsc);
            ShowandHideButtons(hsc);
            ShowandHideResetButtons(hsc);
            ChangeBG(hsc);
            ReadWins();
            hsc.label1.Text = "Won: " + roguewins;
            WriteWins(roguewins);
            ReadLosses();
            hsc.lostLabel.Text = "Lost: " + roguelosses;
            WriteLosses(roguelosses);
        }
        public void rogueLoseButtonCLICKED(HSCounter hsc)
        {
            roguelosses++;
            hsc.lostLabel.Text = "Lost: " + roguelosses;
            WriteLosses(roguelosses);
            hsc.otherlosebutton();
        }
        public void rogueWinButtonCLICKED(HSCounter hsc)
        {
            roguewins++;
            hsc.label1.Text = "Won: " + roguewins;
            WriteWins(roguewins);
            hsc.otherwinbutton();
        }
        public void rogueResetButtonCLICKED(HSCounter hsc)
        {
            DefaultCounter dfc = new DefaultCounter();
            dfc.ReadWins();
            dfc.ReadLosses();
            dfc.WriteWins(dfc.wins - roguewins);
            dfc.WriteLosses(dfc.losses - roguelosses);
            WriteWins(0);
            WriteLosses(0);
            rogueButtonCLICKED(hsc);
        }
        public void rogueButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.roguebutton.Image = global::Hearthstone_Counter.Icons.RogueIconSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.roguebutton.Image = global::Hearthstone_Counter.Icons.RogueIcon;
        }
        public void DeselectOthers(HSCounter hsc)
        {
            hsc.DeselectMage();
            hsc.DeselectDefault();
            hsc.DeselectDruid();
            hsc.DeselectHunter();
            hsc.DeselectPriest();
            hsc.DeselectShaman();
            hsc.DeselectWarlock();
            hsc.DeselectPaladin();
            hsc.DeselectWarrior();
        }
        private void ChangeBG(HSCounter hsc)
        {
            hsc.BackgroundImage = Background.rogueBG;
        }
        public void ShowandHideButtons(HSCounter hsc)
        {
            hsc.rogueWinButton.Show();
            hsc.rogueLoseButton.Show();
            hsc.paladinWinButton.Hide();
            hsc.paladinLoseButton.Hide();
            hsc.priestLoseButton.Hide();
            hsc.priestWinButton.Hide();
            hsc.druidWinButton.Hide();
            hsc.druidLoseButton.Hide();
            hsc.shamanWinButton.Hide();
            hsc.shamanLoseButton.Hide();
            hsc.warlockWinButton.Hide();
            hsc.warlockLoseButton.Hide();
            hsc.hunterWinButton.Hide();
            hsc.hunterLoseButton.Hide();
            hsc.mageWinButton.Hide();
            hsc.mageLoseButton.Hide();
            hsc.warriorWinButton.Hide();
            hsc.warriorLoseButton.Hide();
            hsc.winButton.Hide();
            hsc.loseButton.Hide();
        }
        public void ShowandHideResetButtons(HSCounter hsc)
        {
            hsc.rogueResetButton.Show();           
            hsc.resetbutton.Hide();
            hsc.druidResetButton.Hide();
            hsc.mageResetButton.Hide();
            hsc.paladinResetButton.Hide();
            hsc.shamanResetButton.Hide();
            hsc.warlockResetButton.Hide();
            hsc.priestResetButton.Hide();
            hsc.hunterResetButton.Hide();           
            hsc.warriorResetButton.Hide();
        }

    }
}