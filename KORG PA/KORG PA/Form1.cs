using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;


namespace KORG_PA
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();

        }
        string ses;

        private void button1_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "sesler//" + ses + "//00.wav";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "sesler//" + ses + "//01.wav";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "sesler//" + ses + "//02.wav";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "sesler//" + ses + "//03.wav";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "sesler//" + ses + "//04.wav";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "sesler//" + ses + "//05.wav";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "sesler//" + ses + "//06.wav";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "sesler//" + ses + "//07.wav";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "sesler//" + ses + "//08.wav";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "sesler//" + ses + "//09.wav";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "sesler//" + ses + "//10.wav";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "sesler//" + ses + "//12.wav";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "sesler//" + ses + "//11.wav";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ses = "zurna";
            yaz(" Klavye Ses " + simpleButton1.Text + " ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            digitalGauge1.Text = "     HOSGELDINIZ   ";
            if (ses == "")
            {
                ses = "balaban";
            }
            
        }
        private void yaz(string metin)
        {
            digitalGauge1.Text = metin;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ses = "balaban";
            yaz(" Klavye Ses " + simpleButton2.Text + " ");

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ses = "baglama";
            yaz(" Klavye Ses " + simpleButton3.Text + " ");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = " 2-4-1 RItIm AcIldI ";
            axWindowsMediaPlayer2.URL = "sesler//2-4 1.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            ses = "4 telli";
            yaz(" Klavye Ses " + simpleButton5.Text + " ");
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            ses = "4Telli Tavir";
            yaz(" Klavye Ses " + simpleButton6.Text + " ");
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            ses = "4telli_e";
            yaz(" Klavye Ses " + simpleButton7.Text + " ");
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            ses = "akordiyon";
            yaz(" Klavye Ses " + simpleButton8.Text + " ");
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            ses = "akordiyon2";
            yaz(" Klavye Ses " + simpleButton10.Text + " ");
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            ses = "BAGLAMA-1";
            yaz(" Klavye Ses " + simpleButton11.Text + " ");
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            ses = "duduk";
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            ses = "Girnata";
            yaz(" Klavye Ses " + simpleButton14.Text + " ");
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            ses = "kanun 1";
            yaz(" Klavye Ses " + simpleButton15.Text + " ");
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            ses = "KAVAL ince";
            yaz(" Klavye Ses " + simpleButton16.Text + " ");
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            ses = "kaval kalın";
            yaz(" Klavye Ses " + simpleButton17.Text + " ");
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            ses = "keman kalin";
            yaz(" Klavye Ses " + simpleButton19.Text + " ");
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            ses = "keman";
            yaz(" Klavye Ses " + simpleButton18.Text + " ");
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            ses = "klarnet";
            yaz(" Klavye Ses " + simpleButton20.Text + " ");
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            ses = "mey";
            yaz(" Klavye Ses " + simpleButton21.Text + " ");
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            ses = "ney komali";
            yaz(" Klavye Ses " + simpleButton23.Text + " ");
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            ses = "ney";
            yaz(" Klavye Ses " + simpleButton22.Text + " ");
        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {
            ses = "Mellotron";
            yaz(" Klavye Ses " + simpleButton24.Text + " ");
        }

        private void simpleButton25_Click(object sender, EventArgs e)
        {
            ses = "ud";
            yaz(" Klavye Ses " + simpleButton25.Text + " ");
        }

        private void simpleButton26_Click(object sender, EventArgs e)
        {
            ses = "zurna ince";
            yaz(" Klavye Ses " + simpleButton26.Text + " ");
        }

        private void simpleButton27_Click(object sender, EventArgs e)
        {
            ses = "zurna kalin";
            yaz(" Klavye Ses " + simpleButton27.Text + " ");
        }

        private void simpleButton28_Click(object sender, EventArgs e)
        {
            ses = "zurna komali";
            yaz(" Klavye Ses " + simpleButton28.Text + " ");
        }

        private void simpleButton29_Click(object sender, EventArgs e)
        {
            ses = "balaban 2";
            yaz(" Klavye Ses " + simpleButton29.Text + " ");
        }

        private void simpleButton30_Click(object sender, EventArgs e)
        {
            ses = "balaban 2 komali";
            yaz(" Klavye Ses " + simpleButton30.Text + " ");
        }

        private void simpleButton31_Click(object sender, EventArgs e)
        {
            ses = "balaban komali";
            yaz(" Klavye Ses " + simpleButton31.Text + " ");
        }

        private void simpleButton32_Click(object sender, EventArgs e)
        {
            ses = "elektro";
            yaz(" Klavye Ses " + simpleButton32.Text + " ");
        }

        private void simpleButton33_Click(object sender, EventArgs e)
        {
            ses = "elektro komali";
            yaz(" Klavye Ses " + simpleButton33.Text + " ");
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.URL = "sesler//fon//00.wav";
            yaz(" Fon Eklendi Calnyor ");
        }

        private void simpleButton34_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.URL = "sesler//fon//01.wav";
            yaz(" Fon 2 Eklendi Calnyor ");
        }

        private void simpleButton35_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.URL = "sesler//fon//02.wav";
            yaz(" Fon 3 Eklendi Calnyor ");
        }

        private void simpleButton36_Click(object sender, EventArgs e)
        {
            yaz(" Haa Haa CalInIyor  ");
            axWindowsMediaPlayer4.settings.setMode("Loop", false);
            axWindowsMediaPlayer4.URL = "sesler//HAA.wav";
        }

        private void simpleButton37_Click(object sender, EventArgs e)
        {
            yaz(" Hey Hey CalInIyor  ");
            axWindowsMediaPlayer4.settings.setMode("Loop", false);
            axWindowsMediaPlayer4.URL = "sesler//HEYY.wav";
        }

        private void simpleButton38_Click(object sender, EventArgs e)
        {
            yaz(" Zılgıt  CalInIyor  ");
            axWindowsMediaPlayer4.settings.setMode("Loop", false);
            axWindowsMediaPlayer4.URL = "sesler//zılgıt.wav";
        }

        private void simpleButton39_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = " 2-4-2 RItIm AcIldI ";
            axWindowsMediaPlayer2.URL = "sesler//2-4 2.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton40_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = " 2-4-3 RItIm AcIldI ";
            axWindowsMediaPlayer2.URL = "sesler//2-4 3.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButt0_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = " 2-4-4 RItIm AcIldI ";
            axWindowsMediaPlayer2.URL = "sesler//2-4 4.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simplton40_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = " 2-4-5 RItIm AcIldI ";

            axWindowsMediaPlayer2.URL = "sesler//2-4 5.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton43_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = " 4-4-1 RItIm AcIldI ";
            axWindowsMediaPlayer2.URL = "sesler//4-4 1.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton44_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = " 4-4-2 RItIm AcIldI ";
            axWindowsMediaPlayer2.URL = "sesler//4-4 2.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton45_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = " 4-4-3 RItIm AcIldI ";
            axWindowsMediaPlayer2.URL = "sesler//4-4 3.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton46_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = "  6 - 8 - 1 RItIm   ";
            axWindowsMediaPlayer2.URL = "sesler//6-8 1.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton47_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = "  6 - 8 - 2 RItIm   "; 
            axWindowsMediaPlayer2.URL = "sesler//6-8 2.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void fg_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = "  6 - 8 - 3 RItIm   ";
            axWindowsMediaPlayer2.URL = "sesler//6-8 3.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton49_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = "  9 - 8 - 1 RItIm   "; 
            axWindowsMediaPlayer2.URL = "sesler//9-8 1.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton50_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = "  9 - 8 - 2 RItIm   "; 
            axWindowsMediaPlayer2.URL = "sesler//9-8 2.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton51_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = "  FIRAYDA RItIm   "; 
            axWindowsMediaPlayer2.URL = "sesler//fidayda.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton52_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = " CIFTETELLI RItIm   "; 
            axWindowsMediaPlayer2.URL = "sesler//ciftetelli.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton53_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = " oryantal RItIm   "; 
            axWindowsMediaPlayer2.URL = "sesler//oryantal 1.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton54_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = " oryantal (2) RItIm   ";
            axWindowsMediaPlayer2.URL = "sesler//oryantal 2.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton55_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = " vahde RItIm   "; 
            axWindowsMediaPlayer2.URL = "sesler//vahde 1.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton56_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = " vahde 2 RItIm   ";
            axWindowsMediaPlayer2.URL = "sesler//vahde 2.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton57_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = " atak RItIm   ";
            axWindowsMediaPlayer2.URL = "sesler//atak1.wav";
            axWindowsMediaPlayer2.settings.setMode("Loop", true);
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            digitalGauge1.Text = " atak 2 RItIm   ";
             axWindowsMediaPlayer4.settings.setMode("Loop", false);
             axWindowsMediaPlayer4.URL = "sesler//atac.wav";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.settings.volume = trackBar1.Value;
            lblritim.Text = trackBar1.Value.ToString();
            yaz(" Ritim Ses %"+trackBar1.Value+"");
            digitalGauge2.Text = trackBar1.Value.ToString();
        }

        private void simpleButton58_Click(object sender, EventArgs e)
        {
            trackBar1.Value++;
            axWindowsMediaPlayer2.settings.volume = trackBar1.Value;
            lblritim.Text = trackBar1.Value.ToString();
        }

        private void simpleButton59_Click(object sender, EventArgs e)
        {
            trackBar1.Value--;
            axWindowsMediaPlayer2.settings.volume = trackBar1.Value;
            lblritim.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar2.Value;
            lblklayvye.Text = trackBar2.Value.ToString();
            yaz(" Klavye Ses %" + trackBar2.Value + " ");
            digitalGauge3.Text = trackBar2.Value.ToString();

        }

        private void simpleButton61_Click(object sender, EventArgs e)
        {
            trackBar2.Value++;
            axWindowsMediaPlayer1.settings.volume = trackBar2.Value;
            lblklayvye.Text = trackBar2.Value.ToString();
        }

        private void simpleButton60_Click(object sender, EventArgs e)
        {
            trackBar2.Value--;
            axWindowsMediaPlayer1.settings.volume = trackBar2.Value;
            lblklayvye.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.settings.volume = trackBar3.Value;
            lblfon.Text = trackBar3.Value.ToString();
            yaz(" Fon Ses %" + trackBar3.Value + "  ");
            digitalGauge4.Text = trackBar3.Value.ToString();
        }

        private void simpleButton63_Click(object sender, EventArgs e)
        {
            trackBar3.Value++;
            axWindowsMediaPlayer3.settings.volume = trackBar3.Value;
            lblfon.Text = trackBar3.Value.ToString();
        }

        private void simpleButton62_Click(object sender, EventArgs e)
        {
            trackBar3.Value--;
            axWindowsMediaPlayer3.settings.volume = trackBar3.Value;
            lblfon.Text = trackBar3.Value.ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer4.settings.volume = trackBar4.Value;
            lblatak.Text = trackBar4.Value.ToString();
            yaz(" Atak Ses %" + trackBar4.Value + "  ");

        }

        private void simpleButton64_Click(object sender, EventArgs e)
        {
            trackBar4.Value--;
            axWindowsMediaPlayer4.settings.volume = trackBar4.Value;
            lblatak.Text = trackBar4.Value.ToString();
        }

        private void simpleButton65_Click(object sender, EventArgs e)
        {
            trackBar4.Value++;
            axWindowsMediaPlayer4.settings.volume = trackBar4.Value;
            lblatak.Text = trackBar4.Value.ToString();
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            yaz(" Bütün Ses %" + trackBar5.Value + "  ");
            arcScaleComponent1.Value = trackBar5.Value;
            digitalGauge7.Text = trackBar5.Value.ToString();
            trackBar1.Value = trackBar5.Value;
            trackBar2.Value = trackBar5.Value;
            trackBar3.Value = trackBar5.Value;
            trackBar4.Value = trackBar5.Value;
            lblBütünSes.Text = trackBar5.Value.ToString();
            //*******tr1**************
            axWindowsMediaPlayer2.settings.volume = trackBar1.Value;
            lblritim.Text = trackBar1.Value.ToString();
            //********tr2**************
            axWindowsMediaPlayer1.settings.volume = trackBar2.Value;
            lblklayvye.Text = trackBar2.Value.ToString();
            //*********tr3************
            axWindowsMediaPlayer3.settings.volume = trackBar3.Value;
            lblfon.Text = trackBar3.Value.ToString();
            //**********tr4**********
            axWindowsMediaPlayer4.settings.volume = trackBar4.Value;
            lblatak.Text = trackBar4.Value.ToString();
        }

        private void simpleButton67_Click(object sender, EventArgs e)
        {
            trackBar5.Value++;
            lblBütünSes.Text = trackBar5.Value.ToString();
            trackBar1.Value = trackBar5.Value;
            trackBar2.Value = trackBar5.Value;
            trackBar3.Value = trackBar5.Value;
            trackBar4.Value = trackBar5.Value;
            axWindowsMediaPlayer1.settings.volume = trackBar2.Value;
            lblklayvye.Text = trackBar2.Value.ToString();
            axWindowsMediaPlayer2.settings.volume = trackBar1.Value;
            lblritim.Text = trackBar1.Value.ToString();
            axWindowsMediaPlayer3.settings.volume = trackBar3.Value;
            lblfon.Text = trackBar3.Value.ToString();
            axWindowsMediaPlayer4.settings.volume = trackBar4.Value;
            lblatak.Text = trackBar4.Value.ToString();
        }

        private void simpleButton66_Click(object sender, EventArgs e)
        {
            trackBar5.Value--;
            lblBütünSes.Text = trackBar5.Value.ToString();
            trackBar1.Value = trackBar5.Value;
            trackBar2.Value = trackBar5.Value;
            trackBar3.Value = trackBar5.Value;
            trackBar4.Value = trackBar5.Value;
            axWindowsMediaPlayer1.settings.volume = trackBar2.Value;
            lblklayvye.Text = trackBar2.Value.ToString();
            axWindowsMediaPlayer2.settings.volume = trackBar1.Value;
            lblritim.Text = trackBar1.Value.ToString();
            axWindowsMediaPlayer3.settings.volume = trackBar3.Value;
            lblfon.Text = trackBar3.Value.ToString();
            axWindowsMediaPlayer4.settings.volume = trackBar4.Value;
            lblatak.Text = trackBar4.Value.ToString();
        }

        private void simpleButton68_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.play();
            yaz(" RItIm Devam  ");
        }

        private void simpleButton69_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.stop();
            yaz(" RItIm Durdu  ");
        }

        private void simpleButton70_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.pause();
            yaz(" RItIm Bekletiliyor  ");
        }

        private void simpleButton73_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer4.Ctlcontrols.play();
            yaz(" Atak Basla  ");
        }

        private void simpleButton72_Click(object sender, EventArgs e)
        {
            yaz(" Atak Durdur  "); 
            axWindowsMediaPlayer2.Ctlcontrols.stop();
        }

        private void simpleButton71_Click(object sender, EventArgs e)
        {
            yaz(" Atak Beklet  "); 
            axWindowsMediaPlayer2.Ctlcontrols.pause();
        }

        private void simpleButton76_Click(object sender, EventArgs e)
        {

            yaz(" Fon Müzik Basla  "); 
            axWindowsMediaPlayer3.Ctlcontrols.play();
        }

        private void simpleButton75_Click(object sender, EventArgs e)
        {
            yaz(" Fon Müzik dur  "); 
            axWindowsMediaPlayer3.Ctlcontrols.stop();
        }

        private void simpleButton74_Click(object sender, EventArgs e)
        {
            yaz(" Fon Müzik Beklet  "); 
            axWindowsMediaPlayer3.Ctlcontrols.pause();
        }

        private void simpleButton77_Click(object sender, EventArgs e)
        {
            for (; ; )
            {
                if (simpleButton77.Text == "Dur")
                {
                    simpleButton77.Text = "Devam";
                    yaz(" Tüm Sesler Durdu   ");
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer2.Ctlcontrols.stop();
                    axWindowsMediaPlayer3.Ctlcontrols.stop();
                    axWindowsMediaPlayer4.Ctlcontrols.stop();
                    break;
                }
                if (simpleButton77.Text == "Devam")
                {
                    simpleButton77.Text = "Dur";
                    yaz(" Tüm Sesler Devam   ");
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    axWindowsMediaPlayer2.Ctlcontrols.play();
                    axWindowsMediaPlayer3.Ctlcontrols.play();
                    axWindowsMediaPlayer4.Ctlcontrols.play();
                    break;
                }
            }

        }

        private void button79_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
            //groupControl29.Text = groupControl29.Text.Substring(1) + groupControl29.Text.Substring(0, 1);
            digitalGauge1.Text = digitalGauge1.Text.Substring(1) + digitalGauge1.Text.Substring(0, 1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.FileName = "lisance.txt";

            DialogResult cvp;
            cvp = MessageBox.Show("Bu Uygulama Bayram Studio Tarafından Yazılmıştır Lütfen Lisans Alarak Full Sürüme Geçiniz!, Lisansı Şimdi Almak İstiyormusnuz ?", "Lisans", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cvp == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("www.bayramstudio.com/korgpa/lisans");
            }
        }
       

    }
}