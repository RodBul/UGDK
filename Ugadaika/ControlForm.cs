using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Globalization;
using System.Diagnostics;
using System.Threading;

namespace Ugadaika
{
    public partial class ControlForm : Form
    {
        public ControlForm(string[] args)
        {
            InitializeComponent();
            if (args != null && args.Length > 0)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    readPreset(File.ReadAllText(args[0]));
                }
            }
        }

        private void numberOfTeamsCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberTeam = Int32.Parse(numberOfTeamsCbo.Text);
            setNumberTeams(numberTeam);
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            int numberTeam = Int32.Parse(numberOfTeamsCbo.Text);
            setNumberTeams(numberTeam);

            string[] ports = SerialPort.GetPortNames();
            comPortSelectorCbo.Items.Clear();
            comPortSelectorCbo.Items.AddRange(ports);
            ApplicationData.currentComPort = comPortSelectorCbo.Text;
            updateAllPresetSettingsToStatic();
        }

        void readAdressTeamComPort(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ApplicationData.currentComPort))
            {
                MessageBox.Show("Сom-port не выбран!");
            }
            else
            {
                (sender as PictureBox).Enabled = false;
                Thread t = new Thread(delegate ()
                {
                    PictureBox pb = (sender as PictureBox);
                    pb.BackgroundImage = Image.FromFile(Application.StartupPath + @"\media\yellowBtn.png");
                    serialPort1.PortName = ApplicationData.currentComPort;
                    serialPort1.BaudRate = 115200;
                    serialPort1.ReadTimeout = 5000;
                    serialPort1.WriteTimeout = 5000;
                    serialPort1.Open();
                    if (serialPort1.IsOpen)
                    {
                        try
                        {
                            string message = serialPort1.ReadLine();

                            foreach (Control tb in this.Controls)
                            {
                                if (tb is TextBox)
                                    if (tb.Name == "adressTeamTxt" + pb.Name.Remove(0, 7))
                                    {

                                        tb.Invoke(new Action(() => { tb.Text = message; }));
                                        pb.BackgroundImage = Image.FromFile(Application.StartupPath + @"\media\picBtnOk.png");
                                        serialPort1.Write(message);
                                    }
                            }
                        }
                        catch (TimeoutException)
                        {
                            pb.BackgroundImage = Image.FromFile(Application.StartupPath + @"\media\redBtn.png");
                            MessageBox.Show("Слишком долгое ожидание нажатия!\nВозможно выбран не тот COM-порт");
                            serialPort1.Close();
                        }
                    }
                    serialPort1.Close();

                    pb.Invoke(new Action(() => { pb.Enabled = true; }));
                    
                });
                t.Start();
            }
        }
        void setNumberTeams(int numberTeams)
        {
            ApplicationData.currentNumberTeams = numberTeams;
            foreach (Control tb in this.Controls)
            {
                if (tb.Name.Length > 9)
                    if (tb is TextBox)
                    {
                        if (tb.Name.Substring(0, 10) == "nameTeamTx" ||
                            tb.Name.Substring(0, 10) == "pointsTeam")
                        {

                            for (int i = 1; i <= ApplicationData.maximumTeams; i++)
                            {
                                if (i <= numberTeams)
                                {
                                    if (tb.Name == "nameTeamTxt" + i.ToString() ||
                                        tb.Name == "pointsTeamTxt" + i.ToString())
                                    {
                                        tb.Visible = true;
                                    }
                                }
                                else
                                {
                                    if (tb.Name == "nameTeamTxt" + i.ToString() ||
                                        tb.Name == "pointsTeamTxt" + i.ToString())
                                    {
                                        tb.Visible = false;
                                    }
                                }
                            }
                        }
                    }
                if (tb is PictureBox)
                {
                    if (tb.Name.Substring(0, 7) == "teamBtn")
                    {
                        for (int i = 1; i <= ApplicationData.maximumTeams; i++)
                        {
                            if (i <= numberTeams)
                            {
                                if (tb.Name == "teamBtn" + i.ToString())
                                {
                                    tb.Visible = true;
                                }
                            }
                            else
                            {
                                if (tb.Name == "teamBtn" + i.ToString())
                                {
                                    tb.Visible = false;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void comPortSelectorCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplicationData.currentComPort = comPortSelectorCbo.Text;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            showResults.Enabled = true;
            Random rnd = new Random(DateTime.Now.Second);
            for (int i = 1; i <= ApplicationData.currentNumberTeams; i++)
            {
                TextBox adressTeamTxt = (Controls["adressTeamTxt" + i] as TextBox);
                if (string.IsNullOrEmpty(adressTeamTxt.Text))
                    adressTeamTxt.Text = rnd.Next().ToString();
            }


            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == "GameControl")
                    Application.OpenForms[i].Close();
            }

            if (ApplicationData.currentRound < 2)
            {
                for (int i = TeamList.teamList.Count + 1; i <= ApplicationData.currentNumberTeams; i++)
                {
                    TextBox teamName = ((this.Controls["nameTeamTxt" + i]) as TextBox);
                    TextBox adressTeam = ((this.Controls["adressTeamTxt" + i]) as TextBox);
                    TextBox pointsTeam = ((this.Controls["pointsTeamTxt" + i]) as TextBox);

                    Team team = new Team(teamName.Text, adressTeam.Text, Int32.Parse(pointsTeam.Text));

                    TeamList.teamList.Add(team);
                }

                RoundNotific roundNotific = new RoundNotific(ApplicationData.currentRound + 2);

                showFormSecondScreen(roundNotific);

                this.Focus();
                MessageBox.Show("Начать раунд " + (ApplicationData.currentRound + 2).ToString() + "?");

                if (ApplicationData.currentRound < 1)
                    startBtn.Text = @"Старт раунда " + (ApplicationData.currentRound + 3).ToString();
                else if (ApplicationData.currentRound == 1)
                {
                    startBtn.Text = @"Показать победителей";
                }
                GameControl formControl = new GameControl();
                formControl.Show();
                roundNotific.Close();
            }

            if (ApplicationData.currentRound == 2)
            {
                List<Team> tmList = new List<Team>();
                tmList = TeamList.teamList;
                tmList.Sort((y, x) => x.teamPoints.CompareTo(y.teamPoints));
                foreach (Form formControl in Application.OpenForms.OfType<GameControl>().ToArray())
                {
                    formControl.Close();
                }
                startBtn.Text = @"Выход";
                congratulationForm congratulationForm = new congratulationForm();
                showFormSecondScreen(congratulationForm);

                this.Focus();

                for (int i = 2; i >= 0; i--)
                {
                    congratulationForm.label1.Text = (i + 1).ToString() + " место";
                    congratulationForm.label2.Text = tmList[i].teamName;
                    MessageBox.Show((i + 1).ToString() + " место - " + tmList[i].teamName);
                    congratulationForm.label2.Visible = true;
                    if (i > 0)
                    {
                        MessageBox.Show("Перейти к следующему победителю?");
                        congratulationForm.label2.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Показать общие результаты?");
                        congratulationForm.Close();
                        showResult(tmList);
                    }
                }
            }
            else if (ApplicationData.currentRound == 3)
                Process.GetCurrentProcess().Kill();
            ApplicationData.currentRound++;
        }



        private void selectMusic(object sender, EventArgs e)
        {
            Button pb = (sender as Button);
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Media files (audio & video)|*.mp3;*.wav;*.wave;*.ogg;*.flac;*.mp4;*.m4r;*.wma;*.midi;*.mid;*.avi;*.3gp;*.flv;*.m4v; *.mkv;*.mov;*.vob;*.wmv|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;
                openFileDialog.Title = "Выберите файлы";


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    int trackNumber = (Int32.Parse(pb.Name.Substring(12, 1)) - 1) * 4 + (Int32.Parse(pb.Name.Substring(14, 1)) - 1);

                    if (pb.Text == "Quest")
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            string pathFile = openFileDialog.FileNames[i];
                            if (pathFile.Length > Application.StartupPath.Length)
                            {
                                if (Application.StartupPath == pathFile.Substring(0, Application.StartupPath.Length))
                                    Music.musPath[i, trackNumber] = pathFile.Remove(0, Application.StartupPath.Length);
                                else
                                    Music.musPath[i, trackNumber] = pathFile;
                            }
                            else
                                Music.musPath[i, trackNumber] = pathFile;

                        }
                        foreach (Control rb in this.Controls)
                        {
                            if (rb is RadioButton)
                                if (rb.Name == "isSelectQuest" + pb.Name.Substring(12, 3))
                                {
                                    rb.Visible = true;
                                    break;
                                }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 4; i++)
                        {

                            string pathFile = openFileDialog.FileNames[i];
                            if (pathFile.Length > Application.StartupPath.Length)
                            {
                                if (Application.StartupPath == pathFile.Substring(0, Application.StartupPath.Length))
                                    Music.musPath[i + 4, trackNumber] = pathFile.Remove(0, Application.StartupPath.Length);
                                else
                                    Music.musPath[i, trackNumber] = pathFile;
                            }
                            else
                                Music.musPath[i + 4, trackNumber] = pathFile;

                        }
                        foreach (Control rb in this.Controls)
                        {
                            if (rb is RadioButton)
                                if (rb.Name == "isSelectAnsw" + pb.Name.Substring(12, 3))
                                {
                                    rb.Visible = true;
                                    break;
                                }
                        }
                    }
                }
            }
        }

        private void openPresetBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Ugadaika preset files|*.UGDK|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Title = "Выберите файл";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;
                    readPreset(File.ReadAllText(filename));
                }
            }
        }
        private void savePresetBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Ugadaika preset files|*.UGDK|All files (*.*)|*.*";
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Title = "Выберите файл";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFileDialog.FileName;
                    File.WriteAllText(filename, safePreset());
                }
            }
        }

        void readPreset(string presetStr)
        {
            String[] words = presetStr.Split(new char[] { '\n' });

            int k = 0;
            for (int i = 0; i < 12; i++) //категории
            {
                Music.categoryName[i] = words[k++];
            }
            for (int j = 0; j < 12; j++)
                for (int i = 0; i < 8; i++)
                    Music.musPath[i, j] = words[k++];
            for (int i = 0; i < 12; i++) //очки
            {
                Music.pointMusic[i] = words[k++];
            }
            updateAllPresetSettingsFromStatic();
        }
        string safePreset()
        {
            string safeString = null;
            for (int i = 0; i < 12; i++)
                safeString += Music.categoryName[i] + "\n";
            for (int j = 0; j < 12; j++)
                for (int i = 0; i < 8; i++)
                    safeString += Music.musPath[i, j] + "\n";
            for (int i = 0; i < 12; i++)
                safeString += Music.pointMusic[i] + "\n";
            return safeString;
        }

        private void categoryChanged(object sender, EventArgs e)
        {
            int index = (Int32.Parse((sender as TextBox).Name.Substring(3, 1)) - 1) * 4 + Int32.Parse((sender as TextBox).Name.Substring(5, 1)) - 1;
            Music.categoryName[index] = (sender as TextBox).Text;
        }

        private void pointsMusciChanged(object sender, EventArgs e)
        {
            int index = (Int32.Parse((sender as TextBox).Name.Substring(6, 1)) - 1) * 4 + Int32.Parse((sender as TextBox).Name.Substring(8, 1)) - 1;
            if (!String.IsNullOrEmpty((sender as TextBox).Text))
                Music.pointMusic[index] = (sender as TextBox).Text;

        }

        void updateAllPresetSettingsFromStatic()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Name.Substring(0, 3) == "cat") // очки
                {
                    for (int i = 1; i < 4; i++)
                        for (int j = 1; j < 5; j++)
                            (this.Controls["cat" + i.ToString() + "r" + j.ToString()] as TextBox).Text = Music.categoryName[(i - 1) * 4 + j - 1];
                }
                else if (tb.Name.Substring(0, 6) == "points")
                {
                    for (int i = 1; i < 4; i++)
                        for (int j = 1; j < 5; j++)
                            (this.Controls["points" + i.ToString() + "r" + j.ToString()] as TextBox).Text = Music.pointMusic[(i - 1) * 4 + j - 1];
                }
            }


            for (int i = 1; i < 4; i++)
                for (int j = 1; j < 5; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (!String.IsNullOrEmpty(Music.musPath[k, (i - 1) * 4 + j - 1]))
                        {
                            (this.Controls["isSelectQuest" + i.ToString() + "r" + j.ToString()] as RadioButton).Visible = true;
                        }
                        if (!String.IsNullOrEmpty(Music.musPath[k + 4, (i - 1) * 4 + j - 1]))
                        {
                            (this.Controls["isSelectAnsw" + i.ToString() + "r" + j.ToString()] as RadioButton).Visible = true;
                        }
                    }
                }
        }

        void updateAllPresetSettingsToStatic()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Name.Substring(0, 3) == "cat") // очки
                {
                    for (int i = 1; i < 4; i++)
                        for (int j = 1; j < 5; j++)
                            Music.categoryName[(i - 1) * 4 + j - 1] = (this.Controls["cat" + i.ToString() + "r" + j.ToString()] as TextBox).Text;
                }
                else if (tb.Name.Substring(0, 6) == "points")
                {
                    for (int i = 1; i < 4; i++)
                        for (int j = 1; j < 5; j++)
                            Music.pointMusic[(i - 1) * 4 + j - 1] = (this.Controls["points" + i.ToString() + "r" + j.ToString()] as TextBox).Text;
                }
            }

        }

        private void ControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                System.Environment.Exit(0); //todo при закрытии остальных форм
            }
            catch { }
        }

        private void comPortSelectorCbo_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comPortSelectorCbo.Items.Clear();
            comPortSelectorCbo.Items.AddRange(ports);
            ApplicationData.currentComPort = comPortSelectorCbo.Text;
        }

        ResultsVision resultsVision;
        private void showResults_Click(object sender, EventArgs e)
        {

            List<Team> tmList = new List<Team>();
            tmList = TeamList.teamList;
            tmList.Sort((y, x) => x.teamPoints.CompareTo(y.teamPoints));


            if ((sender as Button).Text == "Показать результаты")
            {
                showResult(tmList);


                (sender as Button).Text = "Скрыть результаты";
            }
            else
            {
                (sender as Button).Text = "Показать результаты";
                resultsVision.Close();
            }
        }

        private void showResult(List<Team> tmList)
        {
            resultsVision = new ResultsVision(tmList);
            showFormSecondScreen(resultsVision);
        }

        public static void showFormSecondScreen(Form form)
        {
            Screen[] sc;
            sc = Screen.AllScreens;
            if (sc.Length > 1)
            {
                form.FormBorderStyle = FormBorderStyle.None;
                form.Left = sc[1].Bounds.Width;
                form.Top = sc[1].Bounds.Height;
                form.StartPosition = FormStartPosition.Manual;
                Point p = new Point(sc[1].Bounds.Location.X, sc[1].Bounds.Location.Y);
                form.Location = p;
                form.WindowState = FormWindowState.Maximized;
                form.SetBounds(sc[0].Bounds.Width, 0, sc[1].Bounds.Width, sc[1].Bounds.Height);
                form.Show();
            }
            else
            {
                MessageBox.Show("Второй монитор не найден!");
            }
        }

        private void pointsTeamTxt1_TextChanged(object sender, EventArgs e)
        {
                try
                {
                    int a = Int32.Parse((sender as TextBox).Text);
                }

                catch
                {
                    MessageBox.Show("В поле 'Очки команды' требуется ввести целое число");
                    (sender as TextBox).Text = "0";
                }
        }
    }
}
