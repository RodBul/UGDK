using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Threading;
using System.Collections.Generic;

namespace Ugadaika
{
    public partial class GameControl : Form
    {
        GameVision gameVision = new GameVision();
        public GameControl()
        {
            InitializeComponent();

        }


        private void GameControl_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\media\interface\stage.jpg");
            setAllLabel();


            foreach (Team tm in TeamList.teamList)
            {
                teamSimCbo.Items.Add(tm.teamName);
            }

            timerMainAnimation.Enabled = true;
            new Thread(startGameVision).Start();
        }
        void startGameVision()
        {
            ControlForm.showFormSecondScreen(gameVision);

            for (int i = 1; i < ApplicationData.currentNumberTeams + 1; i++)
                if (i < 7)
                {
                    try
                    {
                        (gameVision.Controls["pictureTeam" + i.ToString()] as PictureBox).BackgroundImage = Image.FromFile(@"media\interface\team.png");
                        (Controls["pictureTeam" + i.ToString()] as PictureBox).BackgroundImage = Image.FromFile(@"media\interface\team.png");
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        (gameVision.Controls["pictureTeam" + i.ToString()] as PictureBox).BackgroundImage = Image.FromFile(@"media\interface\team_inv.png");
                        (Controls["pictureTeam" + i.ToString()] as PictureBox).BackgroundImage = Image.FromFile(@"media\interface\team_inv.png");
                    }
                    catch { }
                }

            try
            {
                (gameVision.Controls["pictureBoxLogo"] as PictureBox).Image = Image.FromFile(@"media\interface\ugadaikaTopLogo.png");
            }
            catch { }

            gameControlSetCat();
        }
        void setAllLabel()
        {
            for (int i = ApplicationData.currentNumberTeams + 1; i <= ApplicationData.maximumTeams; i++)
            {
                ((this.Controls["pictureTeam" + i]) as PictureBox).Visible = false;
                ((this.Controls["teamNameTxt" + i]) as Label).Visible = false;
                ((this.Controls["pointsTeam" + i]) as Label).Visible = false;
            }
            for (int i = 1; i <= ApplicationData.currentNumberTeams; i++)
            {
                Label teamName = ((this.Controls["teamNameTxt" + i]) as Label);
                teamName.Text = TeamList.teamList[i - 1].teamName;
            }
            upadtePoints(this);
        }
        void upadtePoints(Form form)
        {
            for (int i = 1; i <= ApplicationData.currentNumberTeams; i++)
            {
                Label pointsTeam = ((form.Controls["pointsTeam" + i]) as Label);
                pointsTeam.Text = TeamList.teamList[i - 1].teamPoints.ToString();
            }

        }

        int currentCategoryAnimation = 0;
        int currentTrackAnimation = 0;
        private void mainAnimation(object sender, EventArgs e)
        {
            currentCategoryAnimation++;
            if (currentCategoryAnimation > 4)
                currentCategoryAnimation = 1;

            if (Screen.AllScreens.Length > 1)
            {
                for (int i = 1; i < 5; i++)
                {
                    PictureBox pbV = (gameVision.Controls["categoryBtn" + i]) as PictureBox;
                    PictureBox pb = (this.Controls["categoryBtn" + i]) as PictureBox;
                    if (pb.Enabled)
                    {
                        if (i == currentCategoryAnimation)
                        {
                            pbV.Image = Image.FromFile(Application.StartupPath + @"\media\interface\categoryCheck.png");

                        }
                        else
                        {
                            pbV.Image = Image.FromFile(Application.StartupPath + @"\media\interface\category.png");
                        }
                    }
                    else
                    {
                        pbV.Image = Image.FromFile(Application.StartupPath + @"\media\interface\categoryDisable.png");
                    }
                    textOnImage(pbV, Music.categoryName[ApplicationData.currentRound * 4 + i - 1], Brushes.Black);
                    if (!timerMainAnimation.Enabled)
                        pb.Image = pbV.Image;

                }
                for (int j = 1; j < 5; j++)
                    for (int i = 1; i < 5; i++)
                    {
                        PictureBox pbV = ((gameVision.Controls["trackSelectBtn" + j + "c" + i.ToString()]) as PictureBox);
                        PictureBox pb = ((this.Controls["trackSelectBtn" + j + "c" + i.ToString()]) as PictureBox);
                        if (pb.Enabled)
                        {
                            if (j == currentCategoryAnimation)
                            {
                                pbV.Image = Image.FromFile(Application.StartupPath + @"\media\interface\NoteCheck.png");
                            }
                            else
                            {
                                pbV.Image = Image.FromFile(Application.StartupPath + @"\media\interface\Note.png");
                            }
                            textOnImage(pbV, Music.pointMusic[ApplicationData.currentRound * 4 + j - 1].Split(new char[] { ',' })[i - 1], Brushes.White);
                        }
                        else
                        {
                            pbV.Image = Image.FromFile(Application.StartupPath + @"\media\interface\NoteDisable.png");
                            textOnImage(pbV, Music.pointMusic[ApplicationData.currentRound * 4 + j - 1].Split(new char[] { ',' })[i - 1], Brushes.Gray);
                        }
                    }
            }
        }
        void categoryAnimation(object sender, EventArgs e)
        {
            currentTrackAnimation++;
            if (currentTrackAnimation > 4)
                currentTrackAnimation = 1;

            if (Screen.AllScreens.Length > 1)
                for (int i = 1; i < 5; i++)
                {
                    PictureBox pbV = (gameVision.Controls["trackSelectBtn" + currentCategoryAnimation + "c" + i.ToString()]) as PictureBox;
                    PictureBox pb = (this.Controls["trackSelectBtn" + currentCategoryAnimation + "c" + i.ToString()]) as PictureBox;
                    if (pb.Enabled)
                    {
                        if (i == currentTrackAnimation)
                        {
                            pbV.Image = Image.FromFile(Application.StartupPath + @"\media\interface\NoteCheck.png");
                        }
                        else
                        {
                            pbV.Image = Image.FromFile(Application.StartupPath + @"\media\interface\Note.png");
                        }
                        textOnImage(pbV, Music.pointMusic[ApplicationData.currentRound * 4 + currentCategoryAnimation - 1].Split(new char[] { ',' })[i - 1], Brushes.White);
                        if (!timerCateforyAnimation.Enabled)
                            pb.Image = pbV.Image;
                    }
                    else
                    {
                        pbV.Image = Image.FromFile(Application.StartupPath + @"\media\interface\NoteDisable.png");
                        textOnImage(pbV, Music.pointMusic[ApplicationData.currentRound * 4 + currentCategoryAnimation - 1].Split(new char[] { ',' })[i - 1], Brushes.Gray);
                    }
                }
        }
        void gameControlSetCat()
        {
            for (int i = 1; i < 5; i++)
            {
                PictureBox catPb = (this.Controls["categoryBtn" + i] as PictureBox);
                if (catPb.Enabled)
                {
                    catPb.Image = Image.FromFile(Application.StartupPath + @"\media\interface\category.png");
                }
                else
                {
                    catPb.Image = Image.FromFile(Application.StartupPath + @"\media\interface\categoryDisable.png");
                }
                textOnImage(catPb, Music.categoryName[ApplicationData.currentRound * 4 + i - 1], Brushes.Black);


                for (int j = 1; j < 5; j++)
                {
                    PictureBox notePb = ((this.Controls["trackSelectBtn" + i.ToString() + "c" + j.ToString()]) as PictureBox);
                    if (notePb.Enabled)
                    {
                        notePb.Image = Image.FromFile(Application.StartupPath + @"\media\interface\Note.png");
                    }
                    else
                    {
                        notePb.Image = Image.FromFile(Application.StartupPath + @"\media\interface\NoteDisable.png");
                    }
                    textOnImage(notePb, Music.pointMusic[ApplicationData.currentRound * 4 + i - 1].Split(new char[] { ',' })[j - 1], Brushes.White);

                }
            }
        }
        void categoryClick(object sender, EventArgs e)
        {
            if ((sender as PictureBox).Enabled)
            {
                axWindowsMediaPlayer2.Ctlcontrols.stop();
                if (Screen.AllScreens.Length > 1)
                    gameVision.axWindowsMediaPlayer1.Ctlcontrols.stop();

                if (timerMainAnimation.Enabled == true)
                {
                    axWindowsMediaPlayer1.URL = Application.StartupPath + @"\media\sounds\case1.wav";
                    timerMainAnimation.Stop();
                    currentCategoryAnimation = Int32.Parse((sender as PictureBox).Name.Substring(11, 1)) - 1;
                    mainAnimation(sender, e);
                    timerCateforyAnimation.Enabled = true;
                    //(sender as PictureBox).Image = Image.FromFile(@"media\interface\categoryCheck.png");
                }
            }
        }
        void trackSelectClick(object sender, EventArgs e)
        {
            if (timerCateforyAnimation.Enabled == true &&
                Int32.Parse((sender as PictureBox).Name.Substring(14, 1)) == currentCategoryAnimation)
            {
                //(sender as PictureBox).Image = Image.FromFile(@"media\interface\NoteCheck.png");
                axWindowsMediaPlayer1.URL = Application.StartupPath + @"\media\sounds\case2.wav";
                timerCateforyAnimation.Stop();
                currentTrackAnimation = Int32.Parse((sender as PictureBox).Name.Substring(16, 1)) - 1;
                categoryAnimation(sender, e);
                startTrack(sender, e);
            }
        }
        Thread serialThread;
        void startTrack(Object sender, EventArgs e)
        {
            int cat = Int32.Parse((sender as PictureBox).Name.Substring(14, 1));
            int track = Int32.Parse((sender as PictureBox).Name.Substring(16, 1));
            if (!gameVisionPlay(Music.musPath[track - 1, ApplicationData.currentRound * 4 + cat - 1], sender, true))
                return;
            serialThread = new Thread(delegate ()
            {
                startSerial(sender, e);
            });
            serialThread.Start();
        }
        void startSerial(Object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ApplicationData.currentComPort))
                serialPort1.PortName = ApplicationData.currentComPort;

            serialPort1.BaudRate = 115200;
            serialPort1.ReadTimeout = 100;
            serialPort1.WriteTimeout = 100;
            Team team = null;
            string message = null;
            bool isAnswer = false;
            while (!isAnswer)
            {
                try
                {
                    serialPort1.Open();
                }
                catch { }
                if (String.IsNullOrEmpty(message))
                    if (ApplicationData.remoteAnswer != null)
                    {
                        message = ApplicationData.remoteAnswer;
                        ApplicationData.remoteAnswer = null;
                    }
                    else
                    {
                        try
                        {
                            message = serialPort1.ReadLine();
                        }
                        catch { }
                    }
                else
                    foreach (Team tm in TeamList.teamList)
                    {
                        if (tm.teamAdress == message)
                        {
                            team = tm;
                            try
                            {
                                serialPort1.Write(message);
                            }
                            catch { }

                            isAnswer = true;
                            break;
                        }
                    }
            }
            try
            {
                serialPort1.Close();
            }
            catch { }

            if (Screen.AllScreens.Length > 1)
                gameVision.axWindowsMediaPlayer1.Ctlcontrols.stop();
            else
                axWindowsMediaPlayer2.Ctlcontrols.stop();
            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\media\sounds\push.wav";

            Thread tt = new Thread(delegate ()
            {
                try
                {
                    createNotification(team.teamName);
                }
                catch { }
            });
            tt.Start();
            Thread k = new Thread(delegate ()
            {
                checkAnswer(team, sender, e);
            });
            k.Start();
        }
        void checkAnswer(Team team, Object sender, EventArgs e)
        {
            int cat = Int32.Parse((sender as PictureBox).Name.Substring(14, 1));
            int track = Int32.Parse((sender as PictureBox).Name.Substring(16, 1));
            string trackPath = Music.musPath[track - 1, ApplicationData.currentRound * 4 + cat - 1];
            string answPath = Music.musPath[track + 3, ApplicationData.currentRound * 4 + cat - 1];
            if (String.IsNullOrEmpty(answPath))
                answPath = Music.musPath[track - 1, ApplicationData.currentRound * 4 + cat - 1];
            string filename = System.IO.Path.GetFileName(answPath).Substring(3);
            if (String.IsNullOrEmpty(filename))
                filename = "Error Name";
            DialogResult result = MessageBox.Show(
        @"Правильный ответ - " + filename.Remove(filename.Length - 4) + " \nКоманда ответила верно?",
        "Ответ команды " + team.teamName,
        MessageBoxButtons.YesNo,
        MessageBoxIcon.None,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly); ;

            if (result == DialogResult.Yes)
            {
                Thread tt = new Thread(delegate ()
                {
                    createNotification(filename.Remove(filename.Length - 4));
                });
                tt.Start();

                axWindowsMediaPlayer1.URL = Application.StartupPath + @"\media\sounds\true.mp3";
                team.teamPoints += Int32.Parse(Music.pointMusic[ApplicationData.currentRound * 4 + cat - 1].Split(new char[] { ',' })[track - 1]);

                upadtePoints(this);
                if (Screen.AllScreens.Length > 1)
                    upadtePoints(gameVision);
                (sender as PictureBox).Enabled = false;
                for (int i = 1; i < 5; i++)
                {
                    if (this.Controls["trackSelectBtn" + cat + "c" + i].Enabled)
                        break;
                    else if (i == 4)
                    {
                        this.Controls["categoryBtn" + cat].Enabled = false;

                        if (Screen.AllScreens.Length > 1)
                        {
                            gameVision.Controls["categoryBtn" + cat].Enabled = false;
                        }
                    }
                }
                gameControlSetCat();

                if (Screen.AllScreens.Length > 1)
                {
                    gameVision.Controls[(sender as PictureBox).Name].Enabled = false;
                    (gameVision.Controls[(sender as PictureBox).Name] as PictureBox).Image = Image.FromFile(Application.StartupPath + @"\media\interface\NoteDisable.png");
                }

                DialogResult resultPlayAnswer = MessageBox.Show(
       @"Играть ответ? " + filename.Remove(filename.Length - 4),
       "Проигрывание ответа",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.None,
       MessageBoxDefaultButton.Button1,
       MessageBoxOptions.DefaultDesktopOnly);


                this.Invoke(new Action(() =>
            {

                timerMainAnimation.Start();
                string pathAnsw = Music.musPath[track + 3, ApplicationData.currentRound * 4 + cat - 1];
                if (String.IsNullOrEmpty(pathAnsw))
                    gameVisionPlay(trackPath, sender, (resultPlayAnswer == DialogResult.Yes));
                else
                    gameVisionPlay(pathAnsw, sender, (resultPlayAnswer == DialogResult.Yes));
            }));
            }
            else
            {
                axWindowsMediaPlayer1.URL = Application.StartupPath + @"\media\sounds\false.mp3";
                DialogResult _result = MessageBox.Show(
        @"Попробовать ещё (Да) или выбрать другой трек(Нет)?",
        "Ответ команды " + team.teamName,
        MessageBoxButtons.YesNo,
        MessageBoxIcon.None,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
                if (_result == DialogResult.Yes)
                {
                    this.Invoke(new Action(() =>
                    {

                        gameVisionPlay(trackPath, sender, true);
                        Thread k = new Thread(delegate ()
                        {
                            startSerial(sender, e);
                        });
                        k.Start();
                    }));
                }
                else
                {
                    this.Invoke(new Action(() => { timerMainAnimation.Start(); }));
                }
            }
        }
        void createNotification(string text)
        {
            Thread k = new Thread(delegate ()
            {
                foreach (Form form in Application.OpenForms)
                    if (form is Notification)
                    {
                        (form as Notification).timer2.Stop();
                        (form as Notification).timer3.Start();
                    }

                Notification notification = new Notification(text);
                Screen[] sc;
                sc = Screen.AllScreens;
                int currentScreen;
                if (sc.Length > 1)
                    currentScreen = 1;
                else
                    currentScreen = 0;
                notification.Left = sc[currentScreen].Bounds.Width;
                notification.Top = sc[currentScreen].Bounds.Height;
                notification.StartPosition = FormStartPosition.Manual;
                Point p = new Point(sc[currentScreen].Bounds.Location.X + sc[currentScreen].Bounds.Width / 2 - notification.Width / 2, sc[currentScreen].Bounds.Location.Y + sc[currentScreen].Bounds.Height - 100);
                notification.Location = p;
                notification.ShowDialog();
            });
            k.Start();
        }
        void textOnImage(PictureBox pictureBoxCurrent, string text, Brush brushes)
        {
            Graphics G = Graphics.FromImage(pictureBoxCurrent.Image);
            G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            Rectangle Rect = new Rectangle(0, 0, pictureBoxCurrent.Image.Width, pictureBoxCurrent.Image.Height);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            Font newFont = new Font("Arial", 70);
            G.DrawString(text, newFont, brushes, Rect, sf);
            newFont.Dispose();
            sf.Dispose();
        }
        bool gameVisionPlay(string filePath, object sender, bool play)
        {

            if (String.IsNullOrEmpty(filePath) || File.Exists(filePath))
            {
                MessageBox.Show("Этот трек не задан!");
                (sender as PictureBox).Enabled = false;

                int cat = Int32.Parse((sender as PictureBox).Name.Substring(14, 1));
                int track = Int32.Parse((sender as PictureBox).Name.Substring(16, 1));
                for (int i = 1; i < 5; i++)
                {
                    if (this.Controls["trackSelectBtn" + cat + "c" + i].Enabled)
                        break;
                    else if (i == 4)
                    {
                        this.Controls["categoryBtn" + cat].Enabled = false;
                        if (Screen.AllScreens.Length > 1)
                        {
                            gameVision.Controls["categoryBtn" + cat].Enabled = false;
                        }
                    }
                }
                timerMainAnimation.Start();

                gameControlSetCat();
                return false;
            }
            else
            {
                if (Screen.AllScreens.Length > 1)
                {
                    if (play)
                        if (filePath.Substring(1, 1) == ":")
                            gameVision.axWindowsMediaPlayer1.URL = filePath;
                        else
                            gameVision.axWindowsMediaPlayer1.URL = Application.StartupPath + filePath;
                }
                else
                    if (play)
                    if (filePath.Substring(1, 1) == ":")
                        axWindowsMediaPlayer2.URL = filePath;
                    else
                        axWindowsMediaPlayer2.URL = Application.StartupPath + filePath;
                return true;

            }

        }
        private void stopTrackBtn_Click(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length > 1)
                gameVision.axWindowsMediaPlayer1.Ctlcontrols.stop();
            else
                axWindowsMediaPlayer2.Ctlcontrols.stop();
        }
        private void volumeEffectsBar_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = volumeEffectsBar.Value * 10;
        }
        private void sendSimBtn_Click(object sender, EventArgs e)
        {
            if (!timerMainAnimation.Enabled && !timerCateforyAnimation.Enabled)
            {
                try
                {
                    ApplicationData.remoteAnswer = TeamList.teamList.First(tm => tm.teamName.Equals(teamSimCbo.Text)).teamAdress;
                    if (String.IsNullOrEmpty(TeamList.teamList.First(tm => tm.teamName.Equals(teamSimCbo.Text)).teamAdress))
                        MessageBox.Show("Адрес команды пуст!");
                }
                catch
                {
                    MessageBox.Show("Такой команды не найдено!");
                }
            }
        }
        private void trackRepeatBtn_Click(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length > 1)
            {
                gameVision.axWindowsMediaPlayer1.Ctlcontrols.stop();
                gameVision.axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                axWindowsMediaPlayer2.Ctlcontrols.stop();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }

        }
        private void GameControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            gameVision.Close();
        }

        private void resetTrackBtn_Click(object sender, EventArgs e)
        {
            gameControlSetCat();
            serialPort1.Close();
            if (Screen.AllScreens.Length > 1)
                gameVision.axWindowsMediaPlayer1.Ctlcontrols.stop();
            else
                axWindowsMediaPlayer2.Ctlcontrols.stop();
            timerMainAnimation.Start();
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer2.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                string format = axWindowsMediaPlayer2.currentMedia.sourceURL.Substring(axWindowsMediaPlayer2.currentMedia.sourceURL.Length - 3, 3);
                if (format == "mp4" ||
                    format == "wma" ||
                    format == "avi" ||
                    format == "3gp" ||
                    format == "flv" ||
                    format == "m4v" ||
                    format == "mkv" ||
                    format == "mov" ||
                    format == "vob" ||
                    format == "wmv")
                {
                    Screen[] sc;
                    sc = Screen.AllScreens;
                    if (sc.Length > 1)
                        axWindowsMediaPlayer2.fullScreen = true;
                }
            }
            else
            {
                axWindowsMediaPlayer2.fullScreen = false;
            }

        }


    }
}
