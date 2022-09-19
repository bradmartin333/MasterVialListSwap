using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MasterVialListSwap
{
    public partial class Form1 : Form
    {
        private string DestPath, APath, BPath;

        public Form1()
        {
            InitializeComponent();
            EnablePaths();
        }

        private void EnablePaths()
        {
            DestPath = Properties.Settings.Default.UserDestPath;
            APath = Properties.Settings.Default.UserAPath;
            BPath = Properties.Settings.Default.UserBPath;

            TxtDest.Text = DestPath;
            TxtA.Text = APath;
            TxtB.Text = BPath;

            BtnPushA.Enabled = false;
            BtnPushB.Enabled = false;

            foreach (TextBox text in TableLayoutPanel.Controls.OfType<TextBox>())
                text.BackColor = SystemColors.Control;

            if (!string.IsNullOrEmpty(DestPath))
            {
                FileInfo fileInfo = new FileInfo(DestPath);
                string ext = fileInfo.Extension;

                foreach (TextBox text in TableLayoutPanel.Controls.OfType<TextBox>())
                    text.BackColor = string.IsNullOrEmpty(text.Text) ? Color.Firebrick : (File.Exists(text.Text) ? Color.LawnGreen : Color.Firebrick);

                if (TxtDest.BackColor == Color.LawnGreen)
                {
                    if (!TxtA.Text.EndsWith(ext) && (TxtA.Text == TxtDest.Text || TxtA.Text == TxtB.Text))
                        TxtA.BackColor = Color.Firebrick;
                    else if (TxtA.BackColor == Color.LawnGreen)
                        BtnPushA.Enabled = true;

                    if (!TxtB.Text.EndsWith(ext) && (TxtB.Text == TxtDest.Text || TxtB.Text == TxtA.Text))
                        TxtB.BackColor = Color.Firebrick;
                    else if (TxtB.BackColor == Color.LawnGreen)
                        BtnPushB.Enabled = true;
                }
            }
        }

        private void BtnSelFile(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string tag = ((Button)sender).Tag.ToString();
                    switch (tag)
                    {
                        case "D":
                            Properties.Settings.Default.UserDestPath = filePath;
                            break;
                        case "A":
                            Properties.Settings.Default.UserAPath = filePath;
                            break;
                        case "B":
                            Properties.Settings.Default.UserBPath = filePath;
                            break;
                    }
                    Properties.Settings.Default.Save();
                    EnablePaths();
                }
            }
        }

        private void BtnPushA_Click(object sender, EventArgs e)
        {
            File.Copy(APath, DestPath, true);
            StartTimer();
        }

        private void BtnPushB_Click(object sender, EventArgs e)
        {
            File.Copy(BPath, DestPath, true);
            StartTimer();
        }

        private void StartTimer()
        {
            BtnPushA.Enabled = false;
            BtnPushB.Enabled = false;
            LblStatus.Visible = true;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Stop();
            LblStatus.Visible = false;
            EnablePaths();
        }
    }
}
