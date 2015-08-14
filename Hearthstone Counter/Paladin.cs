﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hearthstone_Counter
{
    class Paladin
    {
        public bool selected;
        public int paladinwins;
        public int paladinlosses;
        string eMessage;
        public void WritePaladinWins(int T)
        {
            using (StreamWriter paladinwinsWriter = new StreamWriter("PaladinWins.txt", false))
            {
                paladinwinsWriter.Write(T);
                paladinwinsWriter.Flush();
            }
        }
        public void WritePaladinLosses(int T)
        {
            using (StreamWriter paladinlossesWriter = new StreamWriter("PaladinLosses.txt", false))
            {
                paladinlossesWriter.Write(T);
                paladinlossesWriter.Flush();
            }
        }
        public void ReadPaladinLosses()
        {
            try
            {
                using (StreamReader readpaladinLosses = new StreamReader("PaladinLosses.txt"))
                {
                    paladinlosses = int.Parse(readpaladinLosses.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }

            finally
            {
                WritePaladinLosses(0);
            }
        }
        public void ReadPaladinWins()
        {
            try
            {
                using (StreamReader readpaladinWins = new StreamReader("PaladinWins.txt"))
                {
                    paladinwins = int.Parse(readpaladinWins.ReadLine());
                }
            }
            catch (Exception e)
            {
                eMessage = e.Message;
                Console.WriteLine(eMessage);
            }
            finally
            {
                WritePaladinWins(0);
            }
        }
        public void paladinButtonCLICKED(HSCounter hsc)
        {
            paladinButtonIsSelected(hsc);
            DeselectOthers(hsc);
            ShowandHideButtons(hsc);
            ReadPaladinWins();
            hsc.label1.Text = "Won: " + paladinwins;
            WritePaladinWins(paladinwins);
            ReadPaladinLosses();
            hsc.lostLabel.Text = "Lost: " + paladinlosses;
            WritePaladinLosses(paladinlosses);
        }
        public void paladinLoseButtonCLICKED(HSCounter hsc)
        {
            paladinlosses++;
            hsc.lostLabel.Text = "Lost: " + paladinlosses;
            WritePaladinLosses(paladinlosses);
            hsc.otherlosebutton();
        }
        public void paladinWinButtonCLICKED(HSCounter hsc)
        {
            paladinwins++;
            hsc.label1.Text = "Won: " + paladinwins;
            WritePaladinWins(paladinwins);
            hsc.otherwinbutton();
        }
        public void paladinButtonIsSelected(HSCounter hsc)
        {
            selected = true;
            hsc.paladinbutton.Image = global::Hearthstone_Counter.Icons.PaladinIconSelected;
            DeselectOthers(hsc);
        }
        public void IsDeselected(HSCounter hsc)
        {
            selected = false;
            hsc.paladinbutton.Image = global::Hearthstone_Counter.Icons.PaladinIcon;
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
            hsc.DeselectRogue();
            hsc.DeselectWarrior();
        }
        public void ShowandHideButtons(HSCounter hsc)
        {
            hsc.paladinWinButton.Show();
            hsc.paladinLoseButton.Show();
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
            hsc.rogueWinButton.Hide();
            hsc.rogueLoseButton.Hide();
            hsc.warriorWinButton.Hide();
            hsc.warriorLoseButton.Hide();
            hsc.winButton.Hide();
            hsc.loseButton.Hide();           
        }
    }
}
