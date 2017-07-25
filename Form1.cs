using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace BladeTracker
{
    public partial class Form1 : Form
    {
        double total = 0;
        int SoulstoneSum;

        public Form1()
        {
            InitializeComponent();
        }

        public void Update()
        {
            double CopperTotal = 0;
            double SilverTotal = 0;
            double GoldTotal = 0;
            int count = 0;
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox && (c as CheckBox).Checked)
                {
                    count++;
                }
            }

            string stringCount = count.ToString();
            QuestOutput.Text = stringCount;
            string stringTemp = total.ToString();


            GoldTotal = Math.Floor(total / 10000);
            SilverTotal = Math.Floor((total % 10000) / 100);
            CopperTotal = Math.Floor(((total % 10000) % 100));

            string stringSoulstone = SoulstoneSum.ToString();
            string stringCopper = CopperTotal.ToString();
            string stringSilver = SilverTotal.ToString();
            string stringGold = GoldTotal.ToString();
            CopperOutput.Text = stringCopper;
            SilverOutput.Text = stringSilver;
            GoldOutput.Text = stringGold;
            SoulstoneOutput.Text = stringSoulstone;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }
        public void PingCheck()
        {
            Ping pingClass = new Ping();
            PingReply pingReply = pingClass.Send("64.25.39.1");
            PingOutput.Text = (pingReply.RoundtripTime.ToString() + "ms");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PingCheck();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void QuestOutput_Click(object sender, EventArgs e)
        {

        }

        private void ServeTheCerulean_CheckedChanged(object sender, EventArgs e)
        {
            if (ServeTheCerulean.Checked == true)
            {
                total += 552;
                SoulstoneSum += 1;
            }
            else
            {
                total -= 552;
                SoulstoneSum -= 1;
            }
            Update();
        }

        private void ShockAndAutomation_CheckedChanged(object sender, EventArgs e)
        {
            if (ShockAndAutomation.Checked == true)
            {
                total += 552;
                SoulstoneSum += 2;
            }
            else
            {
                total -= 552;
                SoulstoneSum -= 2;
            }
            Update();
        }

        private void WyrmTurner_CheckedChanged(object sender, EventArgs e)
        {
            if (WyrmTurner.Checked == true)
                total += 1560;
            else
                total -= 1560;
            Update();
        }

        private void CrimsonRage_CheckedChanged(object sender, EventArgs e)
        {
            if (CrimsonRage.Checked == true)
            {
                total += 1440;
                SoulstoneSum += 2;
            }
            else
            {
                total -= 1440;
                SoulstoneSum += 2;
            }
            Update();
        }

        private void DrawingALine_CheckedChanged(object sender, EventArgs e)
        {
            if (DrawingALine.Checked == true)
            {
                total += 1020;
                SoulstoneSum += 4;
            }
            else
            {
                total -= 1020;
                SoulstoneSum -= 4;
            }
            Update();
        }

        private void SoulstoneProvider_CheckedChanged(object sender, EventArgs e)
        {
            if (SoulstoneProvider.Checked == true)
            {
                total += 1020;
                SoulstoneSum += 2;
            }
            else
            {
                total -= 1020;
                SoulstoneSum -= 2;
            }
            Update();
        }

        private void NoRightsForVillians_CheckedChanged(object sender, EventArgs e)
        {
            if (NoRightsForVillians.Checked == true)
            {
                total += 1020;
                SoulstoneSum += 4;
            }
            else
            {
                SoulstoneSum -= 4;
                total -= 1020;
            }
            Update();
        }

        private void UnlawfulAssemblage_CheckedChanged(object sender, EventArgs e)
        {
            if (UnlawfulAssemblage.Checked == true)
            {
                total += 1020;
                SoulstoneSum += 2;
            }
            else
            {
                total -= 1020;
                SoulstoneSum -= 2;
            }
            Update();
        }

        private void SuppliesAndDemand_CheckedChanged(object sender, EventArgs e)
        {
            if (SuppliesAndDemand.Checked == true)
            {
                total += 1020;
                SoulstoneSum += 2;
            }
            else
            {
                total -= 1020;
                SoulstoneSum += 2;
            }
            Update();
        }

        private void TripleTagMatch_CheckedChanged(object sender, EventArgs e)
        {
            if (TripleTagMatch.Checked == true)
                total += 3600;
            else
                total -= 3600;
            Update();
        }

        private void TagMatchWin_CheckedChanged(object sender, EventArgs e)
        {
            if (TripleTagMatch.Checked == true)
                total += 1800;
            else
                total -= 1800;
            Update();
        }

        private void RiledHunt_CheckedChanged(object sender, EventArgs e)
        {
            if (RiledHunt.Checked == true)
                total += 1440;
            else
                total -= 1440;
            Update();
        }

        private void FarThingsWorse_CheckedChanged(object sender, EventArgs e)
        {
            if (FarThingsWorse.Checked == true)
                total += 1560;
            else
                total -= 1560;
            Update();
        }

        private void RisingTide_CheckedChanged(object sender, EventArgs e)
        {
            if (RisingTide.Checked == true)
                total += 1440;
            else
                total -= 1440;
            Update();
        }

        private void UngsumHero_CheckedChanged(object sender, EventArgs e)
        {
            if (UngsumHero.Checked == true)
                total += 1800;
            else
                total -= 1800;
            Update();
        }

        private void ShinyonLegacy_CheckedChanged(object sender, EventArgs e)
        {
            if (ShinyonLegacy.Checked == true)
                total += 1920;
            else
                total -= 1920;
            Update();
        }

        private void HardCorpsRaiding_CheckedChanged(object sender, EventArgs e)
        {
            if (HardCorpsRaiding.Checked == true)
                total += 2280;
            else
                total -= 2280;
            Update();
        }

        private void BastionFall_CheckedChanged(object sender, EventArgs e)
        {
            if (BastionFall.Checked == true)
                total += 1800;
            else
                total -= 1800;
            Update();
        }

        private void MerryMonkeyDrink_CheckedChanged(object sender, EventArgs e)
        {
            if (MerryMonkeyDrink.Checked == true)
                total += 1560;
            else
                total -= 1560;
            Update();
        }

        private void Durlock_CheckedChanged(object sender, EventArgs e)
        {
            if (Durlock.Checked == true)
                total += 1800;
            else
                total -= 1800;
            Update();
        }

        private void MightAndMane_CheckedChanged(object sender, EventArgs e)
        {
            if (MightAndMane.Checked == true)
                total += 3480;
            else
                total -= 3480;
            Update();
        }

        private void AShadyAlliance_CheckedChanged(object sender, EventArgs e)
        {
            if (AShadyAlliance.Checked == true)
                total += 5280;
            else
                total -= 5280;
            Update();
        }

        private void DeadReckoning_CheckedChanged(object sender, EventArgs e)
        {
            if (DeadReckoning.Checked == true)
                total += 4560;
            else
                total -= 4560;
            Update();
        }

        private void BashingBuccaneers_CheckedChanged(object sender, EventArgs e)
        {
            if (BashingBuccaneers.Checked == true)
                total += 4560;
            else
                total -= 4560;
            Update();
        }

        private void Poaching_CheckedChanged(object sender, EventArgs e)
        {
            if (Poaching.Checked == true)
                total += 4800;
            else
                total -= 4800;
            Update();
        }

        private void DarkIsDeepest_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkIsDeepest.Checked == true)
                total += 5280;
            else
                total -= 5280;
            Update();
        }

        private void MysteryMan_CheckedChanged(object sender, EventArgs e)
        {
            if (MysteryMan.Checked == true)
                total += 6300;
            else
                total -= 6300;
            Update();
        }

        private void OfficersOfBlackram_CheckedChanged(object sender, EventArgs e)
        {
            if (OfficersOfBlackram.Checked == true)
                total += 5640;
            else
                total -= 5640;
            Update();
        }

        private void ChainOfCommand_CheckedChanged(object sender, EventArgs e)
        {
            if (ChainOfCommand.Checked == true)
                total += 5280;
            else
                total -= 5280;
            Update();
        }

        private void BrethrenCoast_CheckedChanged(object sender, EventArgs e)
        {
            if (BrethrenCoast.Checked == true)
                total += 4560;
            else
                total -= 4560;
            Update();
        }

        private void CapsizeTheCaptains_CheckedChanged(object sender, EventArgs e)
        {
            if (CapsizeTheCaptains.Checked == true)
                total += 5280;
            else
                total -= 5280;
            Update();
        }

        private void Broadside_CheckedChanged(object sender, EventArgs e)
        {
            if (Broadside.Checked == true)
                total += 4560;
            else
                total -= 4560;
            Update();
        }

        private void ItsTheLittleThings_CheckedChanged(object sender, EventArgs e)
        {
            if (ItsTheLittleThings.Checked == true)
                total += 5760;
            else
                total -= 5760;
            Update();
        }

        private void AlliesOfBlackram_CheckedChanged(object sender, EventArgs e)
        {
            if (AlliesOfBlackram.Checked == true)
                total += 4560;
            else
                total -= 4560;
            Update();
        }

        private void IntoTheTomb_CheckedChanged(object sender, EventArgs e)
        {
            if (IntoTheTomb.Checked == true)
            {
                SoulstoneSum += 2;
                total += 876;
            }
            else
            {
                SoulstoneSum -= 2;
                total -= 876;
            }
            Update();
        }

        private void LordsofRuin_CheckedChanged(object sender, EventArgs e)
        {
            if (LordsofRuin.Checked == true)
                total += 3480;
            else
                total -= 3480;
            Update();
        }

        private void BloodInWater_CheckedChanged(object sender, EventArgs e)
        {
            if (BloodInWater.Checked == true)
                total += 10440;
            else
                total -= 10440;
            Update();
        }

        private void BreakingTheChain_CheckedChanged(object sender, EventArgs e)
        {
            if (BreakingTheChain.Checked == true)
                total += 9720;
            else
                total -= 9720;
            Update();
        }

        private void QueenOfSpider_CheckedChanged(object sender, EventArgs e)
        {
            if (QueenOfSpider.Checked == true)
                total += 4440;
            else
                total -= 4440;
            Update();
        }

        private void ComeAtKing_CheckedChanged(object sender, EventArgs e)
        {
            if (ComeAtKing.Checked == true)
                total += 3480;
            else
                total -= 3480;
            Update();
        }

        private void NegoWithHog_CheckedChanged(object sender, EventArgs e)
        {
            if (NegoWithHog.Checked == true)
                total += 3240;
            else
                total -= 3240;
            Update();
        }

        private void FinalTraining_CheckedChanged(object sender, EventArgs e)
        {
            if (FinalTraining.Checked == true)
                total += 13800;
            else
                total -= 13800;
            Update();
        }

        private void MonsterMayhem_CheckedChanged(object sender, EventArgs e)
        {
            if (MonsterMayhem.Checked == true)
                total += 8040;
            else
                total -= 8040;
            Update();
        }

        private void TrialOfTower_CheckedChanged(object sender, EventArgs e)
        {
            if (TrialOfTower.Checked == true)
                total += 6919;
            else
                total -= 6919;
            Update();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }





    }
}
