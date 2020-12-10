using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ugadaika
{
    public partial class GameVision : Form
    {
        public GameVision()
        {

            Control.CheckForIllegalCrossThreadCalls = false;
            //InitializeComponent();
            Screen[] sc;
            sc = Screen.AllScreens;
            if (sc.Length > 1)
            {
                int width = sc[1].Bounds.Size.Width;
                int height = sc[1].Bounds.Size.Height;
                if (width == 1366 && height == 768)
                    resolution1366x768();
                else if (width == 1920 && height == 1080)
                    resolution1920x1080();
                else if (width == 1280 && height == 1024)
                    resolution1280x1024();
                else if (width == 1024 && height == 768)
                    resolution1024x768();
                else if (width == 1600 && height == 900)
                    resolution1600x900();
                else 
                    resolution1366x768();
            }

        }
        private void GameVision_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\media\interface\stage.jpg");
            setAllLabel();
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
            upadtePoints();
        }
        public void upadtePoints()
        {
            for (int i = 1; i <= ApplicationData.currentNumberTeams; i++)
            {
                Label pointsTeam = ((this.Controls["pointsTeam" + i]) as Label);
                pointsTeam.Text = TeamList.teamList[i - 1].teamPoints.ToString();
            }
        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                string format = axWindowsMediaPlayer1.currentMedia.sourceURL.Substring(axWindowsMediaPlayer1.currentMedia.sourceURL.Length - 3, 3);
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
                        axWindowsMediaPlayer1.fullScreen = true;
                }
            }
            else
            {
                axWindowsMediaPlayer1.fullScreen = false;
            }

        }

        private void resolution800x600()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameVision));
            this.pointsTeam4 = new System.Windows.Forms.Label();
            this.pointsTeam3 = new System.Windows.Forms.Label();
            this.pointsTeam2 = new System.Windows.Forms.Label();
            this.pointsTeam1 = new System.Windows.Forms.Label();
            this.pointsTeam5 = new System.Windows.Forms.Label();
            this.pointsTeam6 = new System.Windows.Forms.Label();
            this.pointsTeam12 = new System.Windows.Forms.Label();
            this.pointsTeam11 = new System.Windows.Forms.Label();
            this.pointsTeam10 = new System.Windows.Forms.Label();
            this.pointsTeam9 = new System.Windows.Forms.Label();
            this.pointsTeam8 = new System.Windows.Forms.Label();
            this.pointsTeam7 = new System.Windows.Forms.Label();
            this.teamNameTxt12 = new System.Windows.Forms.Label();
            this.teamNameTxt11 = new System.Windows.Forms.Label();
            this.teamNameTxt10 = new System.Windows.Forms.Label();
            this.teamNameTxt9 = new System.Windows.Forms.Label();
            this.teamNameTxt8 = new System.Windows.Forms.Label();
            this.teamNameTxt7 = new System.Windows.Forms.Label();
            this.teamNameTxt4 = new System.Windows.Forms.Label();
            this.teamNameTxt3 = new System.Windows.Forms.Label();
            this.teamNameTxt2 = new System.Windows.Forms.Label();
            this.teamNameTxt1 = new System.Windows.Forms.Label();
            this.teamNameTxt5 = new System.Windows.Forms.Label();
            this.teamNameTxt6 = new System.Windows.Forms.Label();
            this.pictureTeam4 = new System.Windows.Forms.PictureBox();
            this.pictureTeam3 = new System.Windows.Forms.PictureBox();
            this.pictureTeam2 = new System.Windows.Forms.PictureBox();
            this.pictureTeam1 = new System.Windows.Forms.PictureBox();
            this.pictureTeam5 = new System.Windows.Forms.PictureBox();
            this.pictureTeam6 = new System.Windows.Forms.PictureBox();
            this.pictureTeam12 = new System.Windows.Forms.PictureBox();
            this.pictureTeam11 = new System.Windows.Forms.PictureBox();
            this.pictureTeam10 = new System.Windows.Forms.PictureBox();
            this.pictureTeam9 = new System.Windows.Forms.PictureBox();
            this.pictureTeam8 = new System.Windows.Forms.PictureBox();
            this.pictureTeam7 = new System.Windows.Forms.PictureBox();
            this.categoryBtn1 = new System.Windows.Forms.PictureBox();
            this.categoryBtn2 = new System.Windows.Forms.PictureBox();
            this.categoryBtn3 = new System.Windows.Forms.PictureBox();
            this.categoryBtn4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsTeam4
            // 
            this.pointsTeam4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam4.AutoSize = true;
            this.pointsTeam4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam4.ForeColor = System.Drawing.Color.White;
            this.pointsTeam4.Location = new System.Drawing.Point(688, 471);
            this.pointsTeam4.Name = "pointsTeam4";
            this.pointsTeam4.Size = new System.Drawing.Size(46, 20);
            this.pointsTeam4.TabIndex = 115;
            this.pointsTeam4.Text = "label1";
            this.pointsTeam4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam3
            // 
            this.pointsTeam3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam3.AutoSize = true;
            this.pointsTeam3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam3.ForeColor = System.Drawing.Color.White;
            this.pointsTeam3.Location = new System.Drawing.Point(688, 384);
            this.pointsTeam3.Name = "pointsTeam3";
            this.pointsTeam3.Size = new System.Drawing.Size(46, 20);
            this.pointsTeam3.TabIndex = 114;
            this.pointsTeam3.Text = "label4";
            this.pointsTeam3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam2
            // 
            this.pointsTeam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam2.AutoSize = true;
            this.pointsTeam2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam2.ForeColor = System.Drawing.Color.White;
            this.pointsTeam2.Location = new System.Drawing.Point(688, 299);
            this.pointsTeam2.Name = "pointsTeam2";
            this.pointsTeam2.Size = new System.Drawing.Size(46, 20);
            this.pointsTeam2.TabIndex = 113;
            this.pointsTeam2.Text = "label1";
            this.pointsTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam1
            // 
            this.pointsTeam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam1.AutoSize = true;
            this.pointsTeam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam1.ForeColor = System.Drawing.Color.White;
            this.pointsTeam1.Location = new System.Drawing.Point(688, 212);
            this.pointsTeam1.Name = "pointsTeam1";
            this.pointsTeam1.Size = new System.Drawing.Size(46, 20);
            this.pointsTeam1.TabIndex = 112;
            this.pointsTeam1.Text = "label1";
            this.pointsTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam5
            // 
            this.pointsTeam5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam5.AutoSize = true;
            this.pointsTeam5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam5.ForeColor = System.Drawing.Color.White;
            this.pointsTeam5.Location = new System.Drawing.Point(688, 126);
            this.pointsTeam5.Name = "pointsTeam5";
            this.pointsTeam5.Size = new System.Drawing.Size(46, 20);
            this.pointsTeam5.TabIndex = 111;
            this.pointsTeam5.Text = "label1";
            this.pointsTeam5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam6
            // 
            this.pointsTeam6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam6.AutoSize = true;
            this.pointsTeam6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam6.ForeColor = System.Drawing.Color.White;
            this.pointsTeam6.Location = new System.Drawing.Point(688, 40);
            this.pointsTeam6.Name = "pointsTeam6";
            this.pointsTeam6.Size = new System.Drawing.Size(46, 20);
            this.pointsTeam6.TabIndex = 110;
            this.pointsTeam6.Text = "label1";
            this.pointsTeam6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam12
            // 
            this.pointsTeam12.AutoSize = true;
            this.pointsTeam12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam12.ForeColor = System.Drawing.Color.White;
            this.pointsTeam12.Location = new System.Drawing.Point(51, 471);
            this.pointsTeam12.Name = "pointsTeam12";
            this.pointsTeam12.Size = new System.Drawing.Size(46, 20);
            this.pointsTeam12.TabIndex = 109;
            this.pointsTeam12.Text = "label6";
            this.pointsTeam12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam11
            // 
            this.pointsTeam11.AutoSize = true;
            this.pointsTeam11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam11.ForeColor = System.Drawing.Color.White;
            this.pointsTeam11.Location = new System.Drawing.Point(51, 384);
            this.pointsTeam11.Name = "pointsTeam11";
            this.pointsTeam11.Size = new System.Drawing.Size(46, 20);
            this.pointsTeam11.TabIndex = 108;
            this.pointsTeam11.Text = "label5";
            this.pointsTeam11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam10
            // 
            this.pointsTeam10.AutoSize = true;
            this.pointsTeam10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam10.ForeColor = System.Drawing.Color.White;
            this.pointsTeam10.Location = new System.Drawing.Point(51, 299);
            this.pointsTeam10.Name = "pointsTeam10";
            this.pointsTeam10.Size = new System.Drawing.Size(46, 20);
            this.pointsTeam10.TabIndex = 107;
            this.pointsTeam10.Text = "label4";
            this.pointsTeam10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam9
            // 
            this.pointsTeam9.AutoSize = true;
            this.pointsTeam9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam9.ForeColor = System.Drawing.Color.White;
            this.pointsTeam9.Location = new System.Drawing.Point(51, 212);
            this.pointsTeam9.Name = "pointsTeam9";
            this.pointsTeam9.Size = new System.Drawing.Size(46, 20);
            this.pointsTeam9.TabIndex = 106;
            this.pointsTeam9.Text = "label3";
            this.pointsTeam9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam8
            // 
            this.pointsTeam8.AutoSize = true;
            this.pointsTeam8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam8.ForeColor = System.Drawing.Color.White;
            this.pointsTeam8.Location = new System.Drawing.Point(51, 126);
            this.pointsTeam8.Name = "pointsTeam8";
            this.pointsTeam8.Size = new System.Drawing.Size(46, 20);
            this.pointsTeam8.TabIndex = 105;
            this.pointsTeam8.Text = "label2";
            this.pointsTeam8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam7
            // 
            this.pointsTeam7.AutoSize = true;
            this.pointsTeam7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam7.ForeColor = System.Drawing.Color.White;
            this.pointsTeam7.Location = new System.Drawing.Point(51, 40);
            this.pointsTeam7.Name = "pointsTeam7";
            this.pointsTeam7.Size = new System.Drawing.Size(46, 20);
            this.pointsTeam7.TabIndex = 104;
            this.pointsTeam7.Text = "label1";
            this.pointsTeam7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt12
            // 
            this.teamNameTxt12.AutoSize = true;
            this.teamNameTxt12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt12.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt12.Location = new System.Drawing.Point(23, 493);
            this.teamNameTxt12.Name = "teamNameTxt12";
            this.teamNameTxt12.Size = new System.Drawing.Size(16, 20);
            this.teamNameTxt12.TabIndex = 103;
            this.teamNameTxt12.Text = "0";
            this.teamNameTxt12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt11
            // 
            this.teamNameTxt11.AutoSize = true;
            this.teamNameTxt11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt11.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt11.Location = new System.Drawing.Point(23, 407);
            this.teamNameTxt11.Name = "teamNameTxt11";
            this.teamNameTxt11.Size = new System.Drawing.Size(16, 20);
            this.teamNameTxt11.TabIndex = 102;
            this.teamNameTxt11.Text = "0";
            this.teamNameTxt11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt10
            // 
            this.teamNameTxt10.AutoSize = true;
            this.teamNameTxt10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt10.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt10.Location = new System.Drawing.Point(23, 321);
            this.teamNameTxt10.Name = "teamNameTxt10";
            this.teamNameTxt10.Size = new System.Drawing.Size(16, 20);
            this.teamNameTxt10.TabIndex = 101;
            this.teamNameTxt10.Text = "0";
            this.teamNameTxt10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt9
            // 
            this.teamNameTxt9.AutoSize = true;
            this.teamNameTxt9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt9.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt9.Location = new System.Drawing.Point(23, 235);
            this.teamNameTxt9.Name = "teamNameTxt9";
            this.teamNameTxt9.Size = new System.Drawing.Size(16, 20);
            this.teamNameTxt9.TabIndex = 100;
            this.teamNameTxt9.Text = "0";
            this.teamNameTxt9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt8
            // 
            this.teamNameTxt8.AutoSize = true;
            this.teamNameTxt8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt8.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt8.Location = new System.Drawing.Point(23, 149);
            this.teamNameTxt8.Name = "teamNameTxt8";
            this.teamNameTxt8.Size = new System.Drawing.Size(16, 20);
            this.teamNameTxt8.TabIndex = 99;
            this.teamNameTxt8.Text = "0";
            this.teamNameTxt8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt7
            // 
            this.teamNameTxt7.AutoSize = true;
            this.teamNameTxt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt7.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt7.Location = new System.Drawing.Point(23, 63);
            this.teamNameTxt7.Name = "teamNameTxt7";
            this.teamNameTxt7.Size = new System.Drawing.Size(16, 20);
            this.teamNameTxt7.TabIndex = 98;
            this.teamNameTxt7.Text = "0";
            this.teamNameTxt7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt4
            // 
            this.teamNameTxt4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt4.AutoSize = true;
            this.teamNameTxt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt4.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt4.Location = new System.Drawing.Point(670, 494);
            this.teamNameTxt4.Name = "teamNameTxt4";
            this.teamNameTxt4.Size = new System.Drawing.Size(16, 20);
            this.teamNameTxt4.TabIndex = 97;
            this.teamNameTxt4.Text = "0";
            this.teamNameTxt4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt3
            // 
            this.teamNameTxt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt3.AutoSize = true;
            this.teamNameTxt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt3.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt3.Location = new System.Drawing.Point(670, 407);
            this.teamNameTxt3.Name = "teamNameTxt3";
            this.teamNameTxt3.Size = new System.Drawing.Size(16, 20);
            this.teamNameTxt3.TabIndex = 96;
            this.teamNameTxt3.Text = "0";
            this.teamNameTxt3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt2
            // 
            this.teamNameTxt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt2.AutoSize = true;
            this.teamNameTxt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt2.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt2.Location = new System.Drawing.Point(670, 321);
            this.teamNameTxt2.Name = "teamNameTxt2";
            this.teamNameTxt2.Size = new System.Drawing.Size(16, 20);
            this.teamNameTxt2.TabIndex = 95;
            this.teamNameTxt2.Text = "0";
            this.teamNameTxt2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt1
            // 
            this.teamNameTxt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt1.AutoSize = true;
            this.teamNameTxt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt1.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt1.Location = new System.Drawing.Point(670, 235);
            this.teamNameTxt1.Name = "teamNameTxt1";
            this.teamNameTxt1.Size = new System.Drawing.Size(16, 20);
            this.teamNameTxt1.TabIndex = 94;
            this.teamNameTxt1.Text = "0";
            this.teamNameTxt1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt5
            // 
            this.teamNameTxt5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt5.AutoSize = true;
            this.teamNameTxt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt5.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt5.Location = new System.Drawing.Point(670, 149);
            this.teamNameTxt5.Name = "teamNameTxt5";
            this.teamNameTxt5.Size = new System.Drawing.Size(16, 20);
            this.teamNameTxt5.TabIndex = 93;
            this.teamNameTxt5.Text = "0";
            this.teamNameTxt5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt6
            // 
            this.teamNameTxt6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt6.AutoSize = true;
            this.teamNameTxt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt6.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt6.Location = new System.Drawing.Point(670, 63);
            this.teamNameTxt6.Name = "teamNameTxt6";
            this.teamNameTxt6.Size = new System.Drawing.Size(16, 20);
            this.teamNameTxt6.TabIndex = 92;
            this.teamNameTxt6.Text = "0";
            this.teamNameTxt6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureTeam4
            // 
            this.pictureTeam4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam4.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam4.BackgroundImage")));
            this.pictureTeam4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam4.Location = new System.Drawing.Point(667, 442);
            this.pictureTeam4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam4.Name = "pictureTeam4";
            this.pictureTeam4.Size = new System.Drawing.Size(120, 80);
            this.pictureTeam4.TabIndex = 71;
            this.pictureTeam4.TabStop = false;
            // 
            // pictureTeam3
            // 
            this.pictureTeam3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam3.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam3.BackgroundImage")));
            this.pictureTeam3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam3.Location = new System.Drawing.Point(667, 356);
            this.pictureTeam3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam3.Name = "pictureTeam3";
            this.pictureTeam3.Size = new System.Drawing.Size(120, 80);
            this.pictureTeam3.TabIndex = 70;
            this.pictureTeam3.TabStop = false;
            // 
            // pictureTeam2
            // 
            this.pictureTeam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam2.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam2.BackgroundImage")));
            this.pictureTeam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam2.Location = new System.Drawing.Point(667, 270);
            this.pictureTeam2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam2.Name = "pictureTeam2";
            this.pictureTeam2.Size = new System.Drawing.Size(120, 80);
            this.pictureTeam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTeam2.TabIndex = 69;
            this.pictureTeam2.TabStop = false;
            // 
            // pictureTeam1
            // 
            this.pictureTeam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam1.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam1.BackgroundImage")));
            this.pictureTeam1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam1.Location = new System.Drawing.Point(667, 184);
            this.pictureTeam1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam1.Name = "pictureTeam1";
            this.pictureTeam1.Size = new System.Drawing.Size(120, 80);
            this.pictureTeam1.TabIndex = 68;
            this.pictureTeam1.TabStop = false;
            // 
            // pictureTeam5
            // 
            this.pictureTeam5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam5.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam5.BackgroundImage")));
            this.pictureTeam5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam5.Location = new System.Drawing.Point(667, 98);
            this.pictureTeam5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam5.Name = "pictureTeam5";
            this.pictureTeam5.Size = new System.Drawing.Size(120, 80);
            this.pictureTeam5.TabIndex = 67;
            this.pictureTeam5.TabStop = false;
            // 
            // pictureTeam6
            // 
            this.pictureTeam6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam6.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam6.BackgroundImage")));
            this.pictureTeam6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam6.Location = new System.Drawing.Point(667, 12);
            this.pictureTeam6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam6.Name = "pictureTeam6";
            this.pictureTeam6.Size = new System.Drawing.Size(120, 80);
            this.pictureTeam6.TabIndex = 66;
            this.pictureTeam6.TabStop = false;
            // 
            // pictureTeam12
            // 
            this.pictureTeam12.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam12.BackgroundImage")));
            this.pictureTeam12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam12.Location = new System.Drawing.Point(0, 442);
            this.pictureTeam12.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam12.Name = "pictureTeam12";
            this.pictureTeam12.Size = new System.Drawing.Size(120, 80);
            this.pictureTeam12.TabIndex = 65;
            this.pictureTeam12.TabStop = false;
            // 
            // pictureTeam11
            // 
            this.pictureTeam11.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam11.BackgroundImage")));
            this.pictureTeam11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam11.Location = new System.Drawing.Point(0, 356);
            this.pictureTeam11.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam11.Name = "pictureTeam11";
            this.pictureTeam11.Size = new System.Drawing.Size(120, 80);
            this.pictureTeam11.TabIndex = 64;
            this.pictureTeam11.TabStop = false;
            // 
            // pictureTeam10
            // 
            this.pictureTeam10.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam10.BackgroundImage")));
            this.pictureTeam10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam10.Location = new System.Drawing.Point(0, 270);
            this.pictureTeam10.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam10.Name = "pictureTeam10";
            this.pictureTeam10.Size = new System.Drawing.Size(120, 80);
            this.pictureTeam10.TabIndex = 63;
            this.pictureTeam10.TabStop = false;
            // 
            // pictureTeam9
            // 
            this.pictureTeam9.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam9.BackgroundImage")));
            this.pictureTeam9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam9.Location = new System.Drawing.Point(0, 184);
            this.pictureTeam9.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam9.Name = "pictureTeam9";
            this.pictureTeam9.Size = new System.Drawing.Size(120, 80);
            this.pictureTeam9.TabIndex = 62;
            this.pictureTeam9.TabStop = false;
            // 
            // pictureTeam8
            // 
            this.pictureTeam8.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam8.BackgroundImage")));
            this.pictureTeam8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam8.Location = new System.Drawing.Point(0, 98);
            this.pictureTeam8.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam8.Name = "pictureTeam8";
            this.pictureTeam8.Size = new System.Drawing.Size(120, 80);
            this.pictureTeam8.TabIndex = 61;
            this.pictureTeam8.TabStop = false;
            // 
            // pictureTeam7
            // 
            this.pictureTeam7.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam7.Image = ((System.Drawing.Image)(resources.GetObject("pictureTeam7.Image")));
            this.pictureTeam7.Location = new System.Drawing.Point(0, 12);
            this.pictureTeam7.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam7.Name = "pictureTeam7";
            this.pictureTeam7.Size = new System.Drawing.Size(120, 80);
            this.pictureTeam7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTeam7.TabIndex = 60;
            this.pictureTeam7.TabStop = false;
            // 
            // categoryBtn1
            // 
            this.categoryBtn1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn1.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn1.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn1.Image")));
            this.categoryBtn1.Location = new System.Drawing.Point(198, 252);
            this.categoryBtn1.Name = "categoryBtn1";
            this.categoryBtn1.Size = new System.Drawing.Size(137, 50);
            this.categoryBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn1.TabIndex = 72;
            this.categoryBtn1.TabStop = false;
            // 
            // categoryBtn2
            // 
            this.categoryBtn2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn2.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn2.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn2.Image")));
            this.categoryBtn2.Location = new System.Drawing.Point(198, 305);
            this.categoryBtn2.Name = "categoryBtn2";
            this.categoryBtn2.Size = new System.Drawing.Size(137, 50);
            this.categoryBtn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn2.TabIndex = 73;
            this.categoryBtn2.TabStop = false;
            // 
            // categoryBtn3
            // 
            this.categoryBtn3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn3.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn3.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn3.Image")));
            this.categoryBtn3.Location = new System.Drawing.Point(198, 361);
            this.categoryBtn3.Name = "categoryBtn3";
            this.categoryBtn3.Size = new System.Drawing.Size(137, 50);
            this.categoryBtn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn3.TabIndex = 74;
            this.categoryBtn3.TabStop = false;
            // 
            // categoryBtn4
            // 
            this.categoryBtn4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn4.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn4.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn4.Image")));
            this.categoryBtn4.Location = new System.Drawing.Point(198, 417);
            this.categoryBtn4.Name = "categoryBtn4";
            this.categoryBtn4.Size = new System.Drawing.Size(137, 50);
            this.categoryBtn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn4.TabIndex = 75;
            this.categoryBtn4.TabStop = false;
            // 
            // trackSelectBtn1c1
            // 
            this.trackSelectBtn1c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c1.Image")));
            this.trackSelectBtn1c1.Location = new System.Drawing.Point(341, 252);
            this.trackSelectBtn1c1.Name = "trackSelectBtn1c1";
            this.trackSelectBtn1c1.Size = new System.Drawing.Size(62, 50);
            this.trackSelectBtn1c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c1.TabIndex = 76;
            this.trackSelectBtn1c1.TabStop = false;
            // 
            // trackSelectBtn1c2
            // 
            this.trackSelectBtn1c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c2.Image")));
            this.trackSelectBtn1c2.Location = new System.Drawing.Point(409, 252);
            this.trackSelectBtn1c2.Name = "trackSelectBtn1c2";
            this.trackSelectBtn1c2.Size = new System.Drawing.Size(62, 50);
            this.trackSelectBtn1c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c2.TabIndex = 77;
            this.trackSelectBtn1c2.TabStop = false;
            // 
            // trackSelectBtn1c3
            // 
            this.trackSelectBtn1c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c3.Image")));
            this.trackSelectBtn1c3.Location = new System.Drawing.Point(477, 252);
            this.trackSelectBtn1c3.Name = "trackSelectBtn1c3";
            this.trackSelectBtn1c3.Size = new System.Drawing.Size(62, 50);
            this.trackSelectBtn1c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c3.TabIndex = 78;
            this.trackSelectBtn1c3.TabStop = false;
            // 
            // trackSelectBtn1c4
            // 
            this.trackSelectBtn1c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c4.Image")));
            this.trackSelectBtn1c4.Location = new System.Drawing.Point(545, 252);
            this.trackSelectBtn1c4.Name = "trackSelectBtn1c4";
            this.trackSelectBtn1c4.Size = new System.Drawing.Size(62, 50);
            this.trackSelectBtn1c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c4.TabIndex = 79;
            this.trackSelectBtn1c4.TabStop = false;
            // 
            // trackSelectBtn2c1
            // 
            this.trackSelectBtn2c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c1.Image")));
            this.trackSelectBtn2c1.Location = new System.Drawing.Point(341, 305);
            this.trackSelectBtn2c1.Name = "trackSelectBtn2c1";
            this.trackSelectBtn2c1.Size = new System.Drawing.Size(62, 50);
            this.trackSelectBtn2c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c1.TabIndex = 80;
            this.trackSelectBtn2c1.TabStop = false;
            // 
            // trackSelectBtn2c2
            // 
            this.trackSelectBtn2c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c2.Image")));
            this.trackSelectBtn2c2.Location = new System.Drawing.Point(409, 305);
            this.trackSelectBtn2c2.Name = "trackSelectBtn2c2";
            this.trackSelectBtn2c2.Size = new System.Drawing.Size(62, 50);
            this.trackSelectBtn2c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c2.TabIndex = 81;
            this.trackSelectBtn2c2.TabStop = false;
            // 
            // trackSelectBtn2c3
            // 
            this.trackSelectBtn2c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c3.Image")));
            this.trackSelectBtn2c3.Location = new System.Drawing.Point(477, 305);
            this.trackSelectBtn2c3.Name = "trackSelectBtn2c3";
            this.trackSelectBtn2c3.Size = new System.Drawing.Size(62, 50);
            this.trackSelectBtn2c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c3.TabIndex = 82;
            this.trackSelectBtn2c3.TabStop = false;
            // 
            // trackSelectBtn2c4
            // 
            this.trackSelectBtn2c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c4.Image")));
            this.trackSelectBtn2c4.Location = new System.Drawing.Point(545, 305);
            this.trackSelectBtn2c4.Name = "trackSelectBtn2c4";
            this.trackSelectBtn2c4.Size = new System.Drawing.Size(62, 50);
            this.trackSelectBtn2c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c4.TabIndex = 83;
            this.trackSelectBtn2c4.TabStop = false;
            // 
            // trackSelectBtn3c1
            // 
            this.trackSelectBtn3c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c1.Image")));
            this.trackSelectBtn3c1.Location = new System.Drawing.Point(341, 361);
            this.trackSelectBtn3c1.Name = "trackSelectBtn3c1";
            this.trackSelectBtn3c1.Size = new System.Drawing.Size(62, 50);
            this.trackSelectBtn3c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c1.TabIndex = 84;
            this.trackSelectBtn3c1.TabStop = false;
            // 
            // trackSelectBtn3c2
            // 
            this.trackSelectBtn3c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c2.Image")));
            this.trackSelectBtn3c2.Location = new System.Drawing.Point(409, 361);
            this.trackSelectBtn3c2.Name = "trackSelectBtn3c2";
            this.trackSelectBtn3c2.Size = new System.Drawing.Size(62, 50);
            this.trackSelectBtn3c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c2.TabIndex = 85;
            this.trackSelectBtn3c2.TabStop = false;
            // 
            // trackSelectBtn3c3
            // 
            this.trackSelectBtn3c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c3.Image")));
            this.trackSelectBtn3c3.Location = new System.Drawing.Point(477, 361);
            this.trackSelectBtn3c3.Name = "trackSelectBtn3c3";
            this.trackSelectBtn3c3.Size = new System.Drawing.Size(62, 50);
            this.trackSelectBtn3c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c3.TabIndex = 86;
            this.trackSelectBtn3c3.TabStop = false;
            // 
            // trackSelectBtn3c4
            // 
            this.trackSelectBtn3c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c4.Image")));
            this.trackSelectBtn3c4.Location = new System.Drawing.Point(545, 361);
            this.trackSelectBtn3c4.Name = "trackSelectBtn3c4";
            this.trackSelectBtn3c4.Size = new System.Drawing.Size(62, 50);
            this.trackSelectBtn3c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c4.TabIndex = 87;
            this.trackSelectBtn3c4.TabStop = false;
            // 
            // trackSelectBtn4c1
            // 
            this.trackSelectBtn4c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c1.Image")));
            this.trackSelectBtn4c1.Location = new System.Drawing.Point(341, 417);
            this.trackSelectBtn4c1.Name = "trackSelectBtn4c1";
            this.trackSelectBtn4c1.Size = new System.Drawing.Size(62, 50);
            this.trackSelectBtn4c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c1.TabIndex = 88;
            this.trackSelectBtn4c1.TabStop = false;
            // 
            // trackSelectBtn4c2
            // 
            this.trackSelectBtn4c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c2.Image")));
            this.trackSelectBtn4c2.Location = new System.Drawing.Point(409, 417);
            this.trackSelectBtn4c2.Name = "trackSelectBtn4c2";
            this.trackSelectBtn4c2.Size = new System.Drawing.Size(62, 50);
            this.trackSelectBtn4c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c2.TabIndex = 89;
            this.trackSelectBtn4c2.TabStop = false;
            // 
            // trackSelectBtn4c3
            // 
            this.trackSelectBtn4c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c3.Image")));
            this.trackSelectBtn4c3.Location = new System.Drawing.Point(477, 417);
            this.trackSelectBtn4c3.Name = "trackSelectBtn4c3";
            this.trackSelectBtn4c3.Size = new System.Drawing.Size(62, 50);
            this.trackSelectBtn4c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c3.TabIndex = 90;
            this.trackSelectBtn4c3.TabStop = false;
            // 
            // trackSelectBtn4c4
            // 
            this.trackSelectBtn4c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c4.Image")));
            this.trackSelectBtn4c4.Location = new System.Drawing.Point(545, 417);
            this.trackSelectBtn4c4.Name = "trackSelectBtn4c4";
            this.trackSelectBtn4c4.Size = new System.Drawing.Size(62, 50);
            this.trackSelectBtn4c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c4.TabIndex = 91;
            this.trackSelectBtn4c4.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(193, 13);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(425, 202);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 116;
            this.pictureBoxLogo.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(341, 40);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(111, 61);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // GameVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pointsTeam4);
            this.Controls.Add(this.pointsTeam3);
            this.Controls.Add(this.pointsTeam2);
            this.Controls.Add(this.pointsTeam1);
            this.Controls.Add(this.pointsTeam5);
            this.Controls.Add(this.pointsTeam6);
            this.Controls.Add(this.pointsTeam12);
            this.Controls.Add(this.pointsTeam11);
            this.Controls.Add(this.pointsTeam10);
            this.Controls.Add(this.pointsTeam9);
            this.Controls.Add(this.pointsTeam8);
            this.Controls.Add(this.pointsTeam7);
            this.Controls.Add(this.teamNameTxt12);
            this.Controls.Add(this.teamNameTxt11);
            this.Controls.Add(this.teamNameTxt10);
            this.Controls.Add(this.teamNameTxt9);
            this.Controls.Add(this.teamNameTxt8);
            this.Controls.Add(this.teamNameTxt7);
            this.Controls.Add(this.teamNameTxt4);
            this.Controls.Add(this.teamNameTxt3);
            this.Controls.Add(this.teamNameTxt2);
            this.Controls.Add(this.teamNameTxt1);
            this.Controls.Add(this.teamNameTxt5);
            this.Controls.Add(this.teamNameTxt6);
            this.Controls.Add(this.trackSelectBtn4c4);
            this.Controls.Add(this.trackSelectBtn4c3);
            this.Controls.Add(this.trackSelectBtn4c2);
            this.Controls.Add(this.trackSelectBtn4c1);
            this.Controls.Add(this.trackSelectBtn3c4);
            this.Controls.Add(this.trackSelectBtn3c3);
            this.Controls.Add(this.trackSelectBtn3c2);
            this.Controls.Add(this.trackSelectBtn3c1);
            this.Controls.Add(this.trackSelectBtn2c4);
            this.Controls.Add(this.trackSelectBtn2c3);
            this.Controls.Add(this.trackSelectBtn2c2);
            this.Controls.Add(this.trackSelectBtn2c1);
            this.Controls.Add(this.trackSelectBtn1c4);
            this.Controls.Add(this.trackSelectBtn1c3);
            this.Controls.Add(this.trackSelectBtn1c2);
            this.Controls.Add(this.trackSelectBtn1c1);
            this.Controls.Add(this.categoryBtn4);
            this.Controls.Add(this.categoryBtn3);
            this.Controls.Add(this.categoryBtn2);
            this.Controls.Add(this.categoryBtn1);
            this.Controls.Add(this.pictureTeam4);
            this.Controls.Add(this.pictureTeam3);
            this.Controls.Add(this.pictureTeam2);
            this.Controls.Add(this.pictureTeam1);
            this.Controls.Add(this.pictureTeam5);
            this.Controls.Add(this.pictureTeam6);
            this.Controls.Add(this.pictureTeam12);
            this.Controls.Add(this.pictureTeam11);
            this.Controls.Add(this.pictureTeam10);
            this.Controls.Add(this.pictureTeam9);
            this.Controls.Add(this.pictureTeam8);
            this.Controls.Add(this.pictureTeam7);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "GameVision";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GameVision";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GameVision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void resolution1024x768()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameVision));
            this.pointsTeam4 = new System.Windows.Forms.Label();
            this.pointsTeam3 = new System.Windows.Forms.Label();
            this.pointsTeam2 = new System.Windows.Forms.Label();
            this.pointsTeam1 = new System.Windows.Forms.Label();
            this.pointsTeam5 = new System.Windows.Forms.Label();
            this.pointsTeam6 = new System.Windows.Forms.Label();
            this.pointsTeam12 = new System.Windows.Forms.Label();
            this.pointsTeam11 = new System.Windows.Forms.Label();
            this.pointsTeam10 = new System.Windows.Forms.Label();
            this.pointsTeam9 = new System.Windows.Forms.Label();
            this.pointsTeam8 = new System.Windows.Forms.Label();
            this.pointsTeam7 = new System.Windows.Forms.Label();
            this.teamNameTxt12 = new System.Windows.Forms.Label();
            this.teamNameTxt11 = new System.Windows.Forms.Label();
            this.teamNameTxt10 = new System.Windows.Forms.Label();
            this.teamNameTxt9 = new System.Windows.Forms.Label();
            this.teamNameTxt8 = new System.Windows.Forms.Label();
            this.teamNameTxt7 = new System.Windows.Forms.Label();
            this.teamNameTxt4 = new System.Windows.Forms.Label();
            this.teamNameTxt3 = new System.Windows.Forms.Label();
            this.teamNameTxt2 = new System.Windows.Forms.Label();
            this.teamNameTxt1 = new System.Windows.Forms.Label();
            this.teamNameTxt5 = new System.Windows.Forms.Label();
            this.teamNameTxt6 = new System.Windows.Forms.Label();
            this.pictureTeam4 = new System.Windows.Forms.PictureBox();
            this.pictureTeam3 = new System.Windows.Forms.PictureBox();
            this.pictureTeam2 = new System.Windows.Forms.PictureBox();
            this.pictureTeam1 = new System.Windows.Forms.PictureBox();
            this.pictureTeam5 = new System.Windows.Forms.PictureBox();
            this.pictureTeam6 = new System.Windows.Forms.PictureBox();
            this.pictureTeam12 = new System.Windows.Forms.PictureBox();
            this.pictureTeam11 = new System.Windows.Forms.PictureBox();
            this.pictureTeam10 = new System.Windows.Forms.PictureBox();
            this.pictureTeam9 = new System.Windows.Forms.PictureBox();
            this.pictureTeam8 = new System.Windows.Forms.PictureBox();
            this.pictureTeam7 = new System.Windows.Forms.PictureBox();
            this.categoryBtn1 = new System.Windows.Forms.PictureBox();
            this.categoryBtn2 = new System.Windows.Forms.PictureBox();
            this.categoryBtn3 = new System.Windows.Forms.PictureBox();
            this.categoryBtn4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsTeam4
            // 
            this.pointsTeam4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam4.AutoSize = true;
            this.pointsTeam4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam4.ForeColor = System.Drawing.Color.White;
            this.pointsTeam4.Location = new System.Drawing.Point(871, 652);
            this.pointsTeam4.Name = "pointsTeam4";
            this.pointsTeam4.Size = new System.Drawing.Size(63, 25);
            this.pointsTeam4.TabIndex = 115;
            this.pointsTeam4.Text = "label1";
            this.pointsTeam4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam3
            // 
            this.pointsTeam3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam3.AutoSize = true;
            this.pointsTeam3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam3.ForeColor = System.Drawing.Color.White;
            this.pointsTeam3.Location = new System.Drawing.Point(871, 532);
            this.pointsTeam3.Name = "pointsTeam3";
            this.pointsTeam3.Size = new System.Drawing.Size(63, 25);
            this.pointsTeam3.TabIndex = 114;
            this.pointsTeam3.Text = "label4";
            this.pointsTeam3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam2
            // 
            this.pointsTeam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam2.AutoSize = true;
            this.pointsTeam2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam2.ForeColor = System.Drawing.Color.White;
            this.pointsTeam2.Location = new System.Drawing.Point(871, 410);
            this.pointsTeam2.Name = "pointsTeam2";
            this.pointsTeam2.Size = new System.Drawing.Size(63, 25);
            this.pointsTeam2.TabIndex = 113;
            this.pointsTeam2.Text = "label1";
            this.pointsTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam1
            // 
            this.pointsTeam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam1.AutoSize = true;
            this.pointsTeam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam1.ForeColor = System.Drawing.Color.White;
            this.pointsTeam1.Location = new System.Drawing.Point(871, 291);
            this.pointsTeam1.Name = "pointsTeam1";
            this.pointsTeam1.Size = new System.Drawing.Size(63, 25);
            this.pointsTeam1.TabIndex = 112;
            this.pointsTeam1.Text = "label1";
            this.pointsTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam5
            // 
            this.pointsTeam5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam5.AutoSize = true;
            this.pointsTeam5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam5.ForeColor = System.Drawing.Color.White;
            this.pointsTeam5.Location = new System.Drawing.Point(871, 171);
            this.pointsTeam5.Name = "pointsTeam5";
            this.pointsTeam5.Size = new System.Drawing.Size(63, 25);
            this.pointsTeam5.TabIndex = 111;
            this.pointsTeam5.Text = "label1";
            this.pointsTeam5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam6
            // 
            this.pointsTeam6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam6.AutoSize = true;
            this.pointsTeam6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam6.ForeColor = System.Drawing.Color.White;
            this.pointsTeam6.Location = new System.Drawing.Point(871, 49);
            this.pointsTeam6.Name = "pointsTeam6";
            this.pointsTeam6.Size = new System.Drawing.Size(63, 25);
            this.pointsTeam6.TabIndex = 110;
            this.pointsTeam6.Text = "label1";
            this.pointsTeam6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam12
            // 
            this.pointsTeam12.AutoSize = true;
            this.pointsTeam12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam12.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam12.ForeColor = System.Drawing.Color.White;
            this.pointsTeam12.Location = new System.Drawing.Point(78, 653);
            this.pointsTeam12.Name = "pointsTeam12";
            this.pointsTeam12.Size = new System.Drawing.Size(63, 25);
            this.pointsTeam12.TabIndex = 109;
            this.pointsTeam12.Text = "label6";
            this.pointsTeam12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam11
            // 
            this.pointsTeam11.AutoSize = true;
            this.pointsTeam11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam11.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam11.ForeColor = System.Drawing.Color.White;
            this.pointsTeam11.Location = new System.Drawing.Point(78, 532);
            this.pointsTeam11.Name = "pointsTeam11";
            this.pointsTeam11.Size = new System.Drawing.Size(63, 25);
            this.pointsTeam11.TabIndex = 108;
            this.pointsTeam11.Text = "label5";
            this.pointsTeam11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam10
            // 
            this.pointsTeam10.AutoSize = true;
            this.pointsTeam10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam10.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam10.ForeColor = System.Drawing.Color.White;
            this.pointsTeam10.Location = new System.Drawing.Point(78, 410);
            this.pointsTeam10.Name = "pointsTeam10";
            this.pointsTeam10.Size = new System.Drawing.Size(63, 25);
            this.pointsTeam10.TabIndex = 107;
            this.pointsTeam10.Text = "label4";
            this.pointsTeam10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam9
            // 
            this.pointsTeam9.AutoSize = true;
            this.pointsTeam9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam9.ForeColor = System.Drawing.Color.White;
            this.pointsTeam9.Location = new System.Drawing.Point(78, 291);
            this.pointsTeam9.Name = "pointsTeam9";
            this.pointsTeam9.Size = new System.Drawing.Size(63, 25);
            this.pointsTeam9.TabIndex = 106;
            this.pointsTeam9.Text = "label3";
            this.pointsTeam9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam8
            // 
            this.pointsTeam8.AutoSize = true;
            this.pointsTeam8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam8.ForeColor = System.Drawing.Color.White;
            this.pointsTeam8.Location = new System.Drawing.Point(78, 171);
            this.pointsTeam8.Name = "pointsTeam8";
            this.pointsTeam8.Size = new System.Drawing.Size(63, 25);
            this.pointsTeam8.TabIndex = 105;
            this.pointsTeam8.Text = "label2";
            this.pointsTeam8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam7
            // 
            this.pointsTeam7.AutoSize = true;
            this.pointsTeam7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam7.ForeColor = System.Drawing.Color.White;
            this.pointsTeam7.Location = new System.Drawing.Point(78, 49);
            this.pointsTeam7.Name = "pointsTeam7";
            this.pointsTeam7.Size = new System.Drawing.Size(63, 25);
            this.pointsTeam7.TabIndex = 104;
            this.pointsTeam7.Text = "label1";
            this.pointsTeam7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt12
            // 
            this.teamNameTxt12.AutoSize = true;
            this.teamNameTxt12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt12.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt12.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt12.Location = new System.Drawing.Point(23, 687);
            this.teamNameTxt12.Name = "teamNameTxt12";
            this.teamNameTxt12.Size = new System.Drawing.Size(22, 25);
            this.teamNameTxt12.TabIndex = 103;
            this.teamNameTxt12.Text = "0";
            this.teamNameTxt12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt11
            // 
            this.teamNameTxt11.AutoSize = true;
            this.teamNameTxt11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt11.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt11.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt11.Location = new System.Drawing.Point(23, 565);
            this.teamNameTxt11.Name = "teamNameTxt11";
            this.teamNameTxt11.Size = new System.Drawing.Size(22, 25);
            this.teamNameTxt11.TabIndex = 102;
            this.teamNameTxt11.Text = "0";
            this.teamNameTxt11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt10
            // 
            this.teamNameTxt10.AutoSize = true;
            this.teamNameTxt10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt10.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt10.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt10.Location = new System.Drawing.Point(23, 444);
            this.teamNameTxt10.Name = "teamNameTxt10";
            this.teamNameTxt10.Size = new System.Drawing.Size(22, 25);
            this.teamNameTxt10.TabIndex = 101;
            this.teamNameTxt10.Text = "0";
            this.teamNameTxt10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt9
            // 
            this.teamNameTxt9.AutoSize = true;
            this.teamNameTxt9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt9.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt9.Location = new System.Drawing.Point(23, 324);
            this.teamNameTxt9.Name = "teamNameTxt9";
            this.teamNameTxt9.Size = new System.Drawing.Size(22, 25);
            this.teamNameTxt9.TabIndex = 100;
            this.teamNameTxt9.Text = "0";
            this.teamNameTxt9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt8
            // 
            this.teamNameTxt8.AutoSize = true;
            this.teamNameTxt8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt8.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt8.Location = new System.Drawing.Point(23, 203);
            this.teamNameTxt8.Name = "teamNameTxt8";
            this.teamNameTxt8.Size = new System.Drawing.Size(22, 25);
            this.teamNameTxt8.TabIndex = 99;
            this.teamNameTxt8.Text = "0";
            this.teamNameTxt8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt7
            // 
            this.teamNameTxt7.AutoSize = true;
            this.teamNameTxt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt7.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt7.Location = new System.Drawing.Point(23, 82);
            this.teamNameTxt7.Name = "teamNameTxt7";
            this.teamNameTxt7.Size = new System.Drawing.Size(22, 25);
            this.teamNameTxt7.TabIndex = 98;
            this.teamNameTxt7.Text = "0";
            this.teamNameTxt7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt4
            // 
            this.teamNameTxt4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt4.AutoSize = true;
            this.teamNameTxt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt4.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt4.Location = new System.Drawing.Point(840, 687);
            this.teamNameTxt4.Name = "teamNameTxt4";
            this.teamNameTxt4.Size = new System.Drawing.Size(22, 25);
            this.teamNameTxt4.TabIndex = 97;
            this.teamNameTxt4.Text = "0";
            this.teamNameTxt4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt3
            // 
            this.teamNameTxt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt3.AutoSize = true;
            this.teamNameTxt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt3.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt3.Location = new System.Drawing.Point(840, 565);
            this.teamNameTxt3.Name = "teamNameTxt3";
            this.teamNameTxt3.Size = new System.Drawing.Size(22, 25);
            this.teamNameTxt3.TabIndex = 96;
            this.teamNameTxt3.Text = "0";
            this.teamNameTxt3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt2
            // 
            this.teamNameTxt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt2.AutoSize = true;
            this.teamNameTxt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt2.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt2.Location = new System.Drawing.Point(840, 444);
            this.teamNameTxt2.Name = "teamNameTxt2";
            this.teamNameTxt2.Size = new System.Drawing.Size(22, 25);
            this.teamNameTxt2.TabIndex = 95;
            this.teamNameTxt2.Text = "0";
            this.teamNameTxt2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt1
            // 
            this.teamNameTxt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt1.AutoSize = true;
            this.teamNameTxt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt1.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt1.Location = new System.Drawing.Point(840, 324);
            this.teamNameTxt1.Name = "teamNameTxt1";
            this.teamNameTxt1.Size = new System.Drawing.Size(22, 25);
            this.teamNameTxt1.TabIndex = 94;
            this.teamNameTxt1.Text = "0";
            this.teamNameTxt1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt5
            // 
            this.teamNameTxt5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt5.AutoSize = true;
            this.teamNameTxt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt5.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt5.Location = new System.Drawing.Point(840, 203);
            this.teamNameTxt5.Name = "teamNameTxt5";
            this.teamNameTxt5.Size = new System.Drawing.Size(22, 25);
            this.teamNameTxt5.TabIndex = 93;
            this.teamNameTxt5.Text = "0";
            this.teamNameTxt5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt6
            // 
            this.teamNameTxt6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt6.AutoSize = true;
            this.teamNameTxt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt6.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt6.Location = new System.Drawing.Point(840, 82);
            this.teamNameTxt6.Name = "teamNameTxt6";
            this.teamNameTxt6.Size = new System.Drawing.Size(22, 25);
            this.teamNameTxt6.TabIndex = 92;
            this.teamNameTxt6.Text = "0";
            this.teamNameTxt6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureTeam4
            // 
            this.pictureTeam4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam4.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam4.BackgroundImage")));
            this.pictureTeam4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam4.Location = new System.Drawing.Point(835, 610);
            this.pictureTeam4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam4.Name = "pictureTeam4";
            this.pictureTeam4.Size = new System.Drawing.Size(172, 115);
            this.pictureTeam4.TabIndex = 71;
            this.pictureTeam4.TabStop = false;
            // 
            // pictureTeam3
            // 
            this.pictureTeam3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam3.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam3.BackgroundImage")));
            this.pictureTeam3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam3.Location = new System.Drawing.Point(835, 489);
            this.pictureTeam3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam3.Name = "pictureTeam3";
            this.pictureTeam3.Size = new System.Drawing.Size(172, 115);
            this.pictureTeam3.TabIndex = 70;
            this.pictureTeam3.TabStop = false;
            // 
            // pictureTeam2
            // 
            this.pictureTeam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam2.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam2.BackgroundImage")));
            this.pictureTeam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam2.Location = new System.Drawing.Point(835, 368);
            this.pictureTeam2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam2.Name = "pictureTeam2";
            this.pictureTeam2.Size = new System.Drawing.Size(172, 115);
            this.pictureTeam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTeam2.TabIndex = 69;
            this.pictureTeam2.TabStop = false;
            // 
            // pictureTeam1
            // 
            this.pictureTeam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam1.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam1.BackgroundImage")));
            this.pictureTeam1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam1.Location = new System.Drawing.Point(835, 248);
            this.pictureTeam1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam1.Name = "pictureTeam1";
            this.pictureTeam1.Size = new System.Drawing.Size(172, 115);
            this.pictureTeam1.TabIndex = 68;
            this.pictureTeam1.TabStop = false;
            // 
            // pictureTeam5
            // 
            this.pictureTeam5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam5.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam5.BackgroundImage")));
            this.pictureTeam5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam5.Location = new System.Drawing.Point(835, 127);
            this.pictureTeam5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam5.Name = "pictureTeam5";
            this.pictureTeam5.Size = new System.Drawing.Size(172, 115);
            this.pictureTeam5.TabIndex = 67;
            this.pictureTeam5.TabStop = false;
            // 
            // pictureTeam6
            // 
            this.pictureTeam6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam6.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam6.BackgroundImage")));
            this.pictureTeam6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam6.Location = new System.Drawing.Point(835, 6);
            this.pictureTeam6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam6.Name = "pictureTeam6";
            this.pictureTeam6.Size = new System.Drawing.Size(172, 115);
            this.pictureTeam6.TabIndex = 66;
            this.pictureTeam6.TabStop = false;
            // 
            // pictureTeam12
            // 
            this.pictureTeam12.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam12.BackgroundImage")));
            this.pictureTeam12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam12.Location = new System.Drawing.Point(0, 610);
            this.pictureTeam12.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam12.Name = "pictureTeam12";
            this.pictureTeam12.Size = new System.Drawing.Size(172, 115);
            this.pictureTeam12.TabIndex = 65;
            this.pictureTeam12.TabStop = false;
            // 
            // pictureTeam11
            // 
            this.pictureTeam11.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam11.BackgroundImage")));
            this.pictureTeam11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam11.Location = new System.Drawing.Point(0, 489);
            this.pictureTeam11.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam11.Name = "pictureTeam11";
            this.pictureTeam11.Size = new System.Drawing.Size(172, 115);
            this.pictureTeam11.TabIndex = 64;
            this.pictureTeam11.TabStop = false;
            // 
            // pictureTeam10
            // 
            this.pictureTeam10.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam10.BackgroundImage")));
            this.pictureTeam10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam10.Location = new System.Drawing.Point(0, 368);
            this.pictureTeam10.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam10.Name = "pictureTeam10";
            this.pictureTeam10.Size = new System.Drawing.Size(172, 115);
            this.pictureTeam10.TabIndex = 63;
            this.pictureTeam10.TabStop = false;
            // 
            // pictureTeam9
            // 
            this.pictureTeam9.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam9.BackgroundImage")));
            this.pictureTeam9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam9.Location = new System.Drawing.Point(0, 248);
            this.pictureTeam9.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam9.Name = "pictureTeam9";
            this.pictureTeam9.Size = new System.Drawing.Size(172, 115);
            this.pictureTeam9.TabIndex = 62;
            this.pictureTeam9.TabStop = false;
            // 
            // pictureTeam8
            // 
            this.pictureTeam8.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam8.BackgroundImage")));
            this.pictureTeam8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam8.Location = new System.Drawing.Point(0, 127);
            this.pictureTeam8.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam8.Name = "pictureTeam8";
            this.pictureTeam8.Size = new System.Drawing.Size(172, 115);
            this.pictureTeam8.TabIndex = 61;
            this.pictureTeam8.TabStop = false;
            // 
            // pictureTeam7
            // 
            this.pictureTeam7.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam7.Image = ((System.Drawing.Image)(resources.GetObject("pictureTeam7.Image")));
            this.pictureTeam7.Location = new System.Drawing.Point(0, 6);
            this.pictureTeam7.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam7.Name = "pictureTeam7";
            this.pictureTeam7.Size = new System.Drawing.Size(172, 115);
            this.pictureTeam7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTeam7.TabIndex = 60;
            this.pictureTeam7.TabStop = false;
            // 
            // categoryBtn1
            // 
            this.categoryBtn1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn1.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn1.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn1.Image")));
            this.categoryBtn1.Location = new System.Drawing.Point(181, 248);
            this.categoryBtn1.Name = "categoryBtn1";
            this.categoryBtn1.Size = new System.Drawing.Size(220, 80);
            this.categoryBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn1.TabIndex = 72;
            this.categoryBtn1.TabStop = false;
            // 
            // categoryBtn2
            // 
            this.categoryBtn2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn2.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn2.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn2.Image")));
            this.categoryBtn2.Location = new System.Drawing.Point(181, 334);
            this.categoryBtn2.Name = "categoryBtn2";
            this.categoryBtn2.Size = new System.Drawing.Size(220, 80);
            this.categoryBtn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn2.TabIndex = 73;
            this.categoryBtn2.TabStop = false;
            // 
            // categoryBtn3
            // 
            this.categoryBtn3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn3.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn3.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn3.Image")));
            this.categoryBtn3.Location = new System.Drawing.Point(181, 420);
            this.categoryBtn3.Name = "categoryBtn3";
            this.categoryBtn3.Size = new System.Drawing.Size(220, 80);
            this.categoryBtn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn3.TabIndex = 74;
            this.categoryBtn3.TabStop = false;
            // 
            // categoryBtn4
            // 
            this.categoryBtn4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn4.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn4.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn4.Image")));
            this.categoryBtn4.Location = new System.Drawing.Point(181, 506);
            this.categoryBtn4.Name = "categoryBtn4";
            this.categoryBtn4.Size = new System.Drawing.Size(220, 80);
            this.categoryBtn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn4.TabIndex = 75;
            this.categoryBtn4.TabStop = false;
            // 
            // trackSelectBtn1c1
            // 
            this.trackSelectBtn1c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c1.Image")));
            this.trackSelectBtn1c1.Location = new System.Drawing.Point(407, 248);
            this.trackSelectBtn1c1.Name = "trackSelectBtn1c1";
            this.trackSelectBtn1c1.Size = new System.Drawing.Size(100, 80);
            this.trackSelectBtn1c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c1.TabIndex = 76;
            this.trackSelectBtn1c1.TabStop = false;
            // 
            // trackSelectBtn1c2
            // 
            this.trackSelectBtn1c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c2.Image")));
            this.trackSelectBtn1c2.Location = new System.Drawing.Point(513, 248);
            this.trackSelectBtn1c2.Name = "trackSelectBtn1c2";
            this.trackSelectBtn1c2.Size = new System.Drawing.Size(100, 80);
            this.trackSelectBtn1c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c2.TabIndex = 77;
            this.trackSelectBtn1c2.TabStop = false;
            // 
            // trackSelectBtn1c3
            // 
            this.trackSelectBtn1c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c3.Image")));
            this.trackSelectBtn1c3.Location = new System.Drawing.Point(619, 248);
            this.trackSelectBtn1c3.Name = "trackSelectBtn1c3";
            this.trackSelectBtn1c3.Size = new System.Drawing.Size(100, 80);
            this.trackSelectBtn1c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c3.TabIndex = 78;
            this.trackSelectBtn1c3.TabStop = false;
            // 
            // trackSelectBtn1c4
            // 
            this.trackSelectBtn1c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c4.Image")));
            this.trackSelectBtn1c4.Location = new System.Drawing.Point(725, 248);
            this.trackSelectBtn1c4.Name = "trackSelectBtn1c4";
            this.trackSelectBtn1c4.Size = new System.Drawing.Size(100, 80);
            this.trackSelectBtn1c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c4.TabIndex = 79;
            this.trackSelectBtn1c4.TabStop = false;
            // 
            // trackSelectBtn2c1
            // 
            this.trackSelectBtn2c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c1.Image")));
            this.trackSelectBtn2c1.Location = new System.Drawing.Point(407, 334);
            this.trackSelectBtn2c1.Name = "trackSelectBtn2c1";
            this.trackSelectBtn2c1.Size = new System.Drawing.Size(100, 80);
            this.trackSelectBtn2c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c1.TabIndex = 80;
            this.trackSelectBtn2c1.TabStop = false;
            // 
            // trackSelectBtn2c2
            // 
            this.trackSelectBtn2c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c2.Image")));
            this.trackSelectBtn2c2.Location = new System.Drawing.Point(513, 334);
            this.trackSelectBtn2c2.Name = "trackSelectBtn2c2";
            this.trackSelectBtn2c2.Size = new System.Drawing.Size(100, 80);
            this.trackSelectBtn2c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c2.TabIndex = 81;
            this.trackSelectBtn2c2.TabStop = false;
            // 
            // trackSelectBtn2c3
            // 
            this.trackSelectBtn2c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c3.Image")));
            this.trackSelectBtn2c3.Location = new System.Drawing.Point(619, 334);
            this.trackSelectBtn2c3.Name = "trackSelectBtn2c3";
            this.trackSelectBtn2c3.Size = new System.Drawing.Size(100, 80);
            this.trackSelectBtn2c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c3.TabIndex = 82;
            this.trackSelectBtn2c3.TabStop = false;
            // 
            // trackSelectBtn2c4
            // 
            this.trackSelectBtn2c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c4.Image")));
            this.trackSelectBtn2c4.Location = new System.Drawing.Point(725, 334);
            this.trackSelectBtn2c4.Name = "trackSelectBtn2c4";
            this.trackSelectBtn2c4.Size = new System.Drawing.Size(100, 80);
            this.trackSelectBtn2c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c4.TabIndex = 83;
            this.trackSelectBtn2c4.TabStop = false;
            // 
            // trackSelectBtn3c1
            // 
            this.trackSelectBtn3c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c1.Image")));
            this.trackSelectBtn3c1.Location = new System.Drawing.Point(407, 420);
            this.trackSelectBtn3c1.Name = "trackSelectBtn3c1";
            this.trackSelectBtn3c1.Size = new System.Drawing.Size(100, 80);
            this.trackSelectBtn3c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c1.TabIndex = 84;
            this.trackSelectBtn3c1.TabStop = false;
            // 
            // trackSelectBtn3c2
            // 
            this.trackSelectBtn3c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c2.Image")));
            this.trackSelectBtn3c2.Location = new System.Drawing.Point(513, 420);
            this.trackSelectBtn3c2.Name = "trackSelectBtn3c2";
            this.trackSelectBtn3c2.Size = new System.Drawing.Size(100, 80);
            this.trackSelectBtn3c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c2.TabIndex = 85;
            this.trackSelectBtn3c2.TabStop = false;
            // 
            // trackSelectBtn3c3
            // 
            this.trackSelectBtn3c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c3.Image")));
            this.trackSelectBtn3c3.Location = new System.Drawing.Point(619, 420);
            this.trackSelectBtn3c3.Name = "trackSelectBtn3c3";
            this.trackSelectBtn3c3.Size = new System.Drawing.Size(100, 80);
            this.trackSelectBtn3c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c3.TabIndex = 86;
            this.trackSelectBtn3c3.TabStop = false;
            // 
            // trackSelectBtn3c4
            // 
            this.trackSelectBtn3c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c4.Image")));
            this.trackSelectBtn3c4.Location = new System.Drawing.Point(725, 420);
            this.trackSelectBtn3c4.Name = "trackSelectBtn3c4";
            this.trackSelectBtn3c4.Size = new System.Drawing.Size(100, 80);
            this.trackSelectBtn3c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c4.TabIndex = 87;
            this.trackSelectBtn3c4.TabStop = false;
            // 
            // trackSelectBtn4c1
            // 
            this.trackSelectBtn4c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c1.Image")));
            this.trackSelectBtn4c1.Location = new System.Drawing.Point(407, 506);
            this.trackSelectBtn4c1.Name = "trackSelectBtn4c1";
            this.trackSelectBtn4c1.Size = new System.Drawing.Size(100, 80);
            this.trackSelectBtn4c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c1.TabIndex = 88;
            this.trackSelectBtn4c1.TabStop = false;
            // 
            // trackSelectBtn4c2
            // 
            this.trackSelectBtn4c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c2.Image")));
            this.trackSelectBtn4c2.Location = new System.Drawing.Point(513, 506);
            this.trackSelectBtn4c2.Name = "trackSelectBtn4c2";
            this.trackSelectBtn4c2.Size = new System.Drawing.Size(100, 80);
            this.trackSelectBtn4c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c2.TabIndex = 89;
            this.trackSelectBtn4c2.TabStop = false;
            // 
            // trackSelectBtn4c3
            // 
            this.trackSelectBtn4c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c3.Image")));
            this.trackSelectBtn4c3.Location = new System.Drawing.Point(619, 506);
            this.trackSelectBtn4c3.Name = "trackSelectBtn4c3";
            this.trackSelectBtn4c3.Size = new System.Drawing.Size(100, 80);
            this.trackSelectBtn4c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c3.TabIndex = 90;
            this.trackSelectBtn4c3.TabStop = false;
            // 
            // trackSelectBtn4c4
            // 
            this.trackSelectBtn4c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c4.Image")));
            this.trackSelectBtn4c4.Location = new System.Drawing.Point(725, 506);
            this.trackSelectBtn4c4.Name = "trackSelectBtn4c4";
            this.trackSelectBtn4c4.Size = new System.Drawing.Size(100, 80);
            this.trackSelectBtn4c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c4.TabIndex = 91;
            this.trackSelectBtn4c4.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(305, 13);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(425, 202);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 116;
            this.pictureBoxLogo.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(453, 40);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(111, 61);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // GameVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pointsTeam4);
            this.Controls.Add(this.pointsTeam3);
            this.Controls.Add(this.pointsTeam2);
            this.Controls.Add(this.pointsTeam1);
            this.Controls.Add(this.pointsTeam5);
            this.Controls.Add(this.pointsTeam6);
            this.Controls.Add(this.pointsTeam12);
            this.Controls.Add(this.pointsTeam11);
            this.Controls.Add(this.pointsTeam10);
            this.Controls.Add(this.pointsTeam9);
            this.Controls.Add(this.pointsTeam8);
            this.Controls.Add(this.pointsTeam7);
            this.Controls.Add(this.teamNameTxt12);
            this.Controls.Add(this.teamNameTxt11);
            this.Controls.Add(this.teamNameTxt10);
            this.Controls.Add(this.teamNameTxt9);
            this.Controls.Add(this.teamNameTxt8);
            this.Controls.Add(this.teamNameTxt7);
            this.Controls.Add(this.teamNameTxt4);
            this.Controls.Add(this.teamNameTxt3);
            this.Controls.Add(this.teamNameTxt2);
            this.Controls.Add(this.teamNameTxt1);
            this.Controls.Add(this.teamNameTxt5);
            this.Controls.Add(this.teamNameTxt6);
            this.Controls.Add(this.trackSelectBtn4c4);
            this.Controls.Add(this.trackSelectBtn4c3);
            this.Controls.Add(this.trackSelectBtn4c2);
            this.Controls.Add(this.trackSelectBtn4c1);
            this.Controls.Add(this.trackSelectBtn3c4);
            this.Controls.Add(this.trackSelectBtn3c3);
            this.Controls.Add(this.trackSelectBtn3c2);
            this.Controls.Add(this.trackSelectBtn3c1);
            this.Controls.Add(this.trackSelectBtn2c4);
            this.Controls.Add(this.trackSelectBtn2c3);
            this.Controls.Add(this.trackSelectBtn2c2);
            this.Controls.Add(this.trackSelectBtn2c1);
            this.Controls.Add(this.trackSelectBtn1c4);
            this.Controls.Add(this.trackSelectBtn1c3);
            this.Controls.Add(this.trackSelectBtn1c2);
            this.Controls.Add(this.trackSelectBtn1c1);
            this.Controls.Add(this.categoryBtn4);
            this.Controls.Add(this.categoryBtn3);
            this.Controls.Add(this.categoryBtn2);
            this.Controls.Add(this.categoryBtn1);
            this.Controls.Add(this.pictureTeam4);
            this.Controls.Add(this.pictureTeam3);
            this.Controls.Add(this.pictureTeam2);
            this.Controls.Add(this.pictureTeam1);
            this.Controls.Add(this.pictureTeam5);
            this.Controls.Add(this.pictureTeam6);
            this.Controls.Add(this.pictureTeam12);
            this.Controls.Add(this.pictureTeam11);
            this.Controls.Add(this.pictureTeam10);
            this.Controls.Add(this.pictureTeam9);
            this.Controls.Add(this.pictureTeam8);
            this.Controls.Add(this.pictureTeam7);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "GameVision";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GameVision";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GameVision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void resolution1280x1024()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameVision));
            this.pointsTeam4 = new System.Windows.Forms.Label();
            this.pointsTeam3 = new System.Windows.Forms.Label();
            this.pointsTeam2 = new System.Windows.Forms.Label();
            this.pointsTeam1 = new System.Windows.Forms.Label();
            this.pointsTeam5 = new System.Windows.Forms.Label();
            this.pointsTeam6 = new System.Windows.Forms.Label();
            this.pointsTeam12 = new System.Windows.Forms.Label();
            this.pointsTeam11 = new System.Windows.Forms.Label();
            this.pointsTeam10 = new System.Windows.Forms.Label();
            this.pointsTeam9 = new System.Windows.Forms.Label();
            this.pointsTeam8 = new System.Windows.Forms.Label();
            this.pointsTeam7 = new System.Windows.Forms.Label();
            this.teamNameTxt12 = new System.Windows.Forms.Label();
            this.teamNameTxt11 = new System.Windows.Forms.Label();
            this.teamNameTxt10 = new System.Windows.Forms.Label();
            this.teamNameTxt9 = new System.Windows.Forms.Label();
            this.teamNameTxt8 = new System.Windows.Forms.Label();
            this.teamNameTxt7 = new System.Windows.Forms.Label();
            this.teamNameTxt4 = new System.Windows.Forms.Label();
            this.teamNameTxt3 = new System.Windows.Forms.Label();
            this.teamNameTxt2 = new System.Windows.Forms.Label();
            this.teamNameTxt1 = new System.Windows.Forms.Label();
            this.teamNameTxt5 = new System.Windows.Forms.Label();
            this.teamNameTxt6 = new System.Windows.Forms.Label();
            this.pictureTeam4 = new System.Windows.Forms.PictureBox();
            this.pictureTeam3 = new System.Windows.Forms.PictureBox();
            this.pictureTeam2 = new System.Windows.Forms.PictureBox();
            this.pictureTeam1 = new System.Windows.Forms.PictureBox();
            this.pictureTeam5 = new System.Windows.Forms.PictureBox();
            this.pictureTeam6 = new System.Windows.Forms.PictureBox();
            this.pictureTeam12 = new System.Windows.Forms.PictureBox();
            this.pictureTeam11 = new System.Windows.Forms.PictureBox();
            this.pictureTeam10 = new System.Windows.Forms.PictureBox();
            this.pictureTeam9 = new System.Windows.Forms.PictureBox();
            this.pictureTeam8 = new System.Windows.Forms.PictureBox();
            this.pictureTeam7 = new System.Windows.Forms.PictureBox();
            this.categoryBtn1 = new System.Windows.Forms.PictureBox();
            this.categoryBtn2 = new System.Windows.Forms.PictureBox();
            this.categoryBtn3 = new System.Windows.Forms.PictureBox();
            this.categoryBtn4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsTeam4
            // 
            this.pointsTeam4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam4.AutoSize = true;
            this.pointsTeam4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam4.ForeColor = System.Drawing.Color.White;
            this.pointsTeam4.Location = new System.Drawing.Point(1086, 849);
            this.pointsTeam4.Name = "pointsTeam4";
            this.pointsTeam4.Size = new System.Drawing.Size(76, 31);
            this.pointsTeam4.TabIndex = 115;
            this.pointsTeam4.Text = "label1";
            this.pointsTeam4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam3
            // 
            this.pointsTeam3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam3.AutoSize = true;
            this.pointsTeam3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam3.ForeColor = System.Drawing.Color.White;
            this.pointsTeam3.Location = new System.Drawing.Point(1086, 694);
            this.pointsTeam3.Name = "pointsTeam3";
            this.pointsTeam3.Size = new System.Drawing.Size(76, 31);
            this.pointsTeam3.TabIndex = 114;
            this.pointsTeam3.Text = "label4";
            this.pointsTeam3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam2
            // 
            this.pointsTeam2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam2.AutoSize = true;
            this.pointsTeam2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam2.ForeColor = System.Drawing.Color.White;
            this.pointsTeam2.Location = new System.Drawing.Point(1086, 538);
            this.pointsTeam2.Name = "pointsTeam2";
            this.pointsTeam2.Size = new System.Drawing.Size(76, 31);
            this.pointsTeam2.TabIndex = 113;
            this.pointsTeam2.Text = "label1";
            this.pointsTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam1
            // 
            this.pointsTeam1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam1.AutoSize = true;
            this.pointsTeam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam1.ForeColor = System.Drawing.Color.White;
            this.pointsTeam1.Location = new System.Drawing.Point(1086, 381);
            this.pointsTeam1.Name = "pointsTeam1";
            this.pointsTeam1.Size = new System.Drawing.Size(76, 31);
            this.pointsTeam1.TabIndex = 112;
            this.pointsTeam1.Text = "label1";
            this.pointsTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam5
            // 
            this.pointsTeam5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam5.AutoSize = true;
            this.pointsTeam5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam5.ForeColor = System.Drawing.Color.White;
            this.pointsTeam5.Location = new System.Drawing.Point(1086, 225);
            this.pointsTeam5.Name = "pointsTeam5";
            this.pointsTeam5.Size = new System.Drawing.Size(76, 31);
            this.pointsTeam5.TabIndex = 111;
            this.pointsTeam5.Text = "label1";
            this.pointsTeam5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam6
            // 
            this.pointsTeam6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam6.AutoSize = true;
            this.pointsTeam6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam6.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam6.ForeColor = System.Drawing.Color.White;
            this.pointsTeam6.Location = new System.Drawing.Point(1086, 69);
            this.pointsTeam6.Name = "pointsTeam6";
            this.pointsTeam6.Size = new System.Drawing.Size(76, 31);
            this.pointsTeam6.TabIndex = 110;
            this.pointsTeam6.Text = "label1";
            this.pointsTeam6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam12
            // 
            this.pointsTeam12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam12.AutoSize = true;
            this.pointsTeam12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam12.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam12.ForeColor = System.Drawing.Color.White;
            this.pointsTeam12.Location = new System.Drawing.Point(104, 849);
            this.pointsTeam12.Name = "pointsTeam12";
            this.pointsTeam12.Size = new System.Drawing.Size(76, 31);
            this.pointsTeam12.TabIndex = 109;
            this.pointsTeam12.Text = "label6";
            this.pointsTeam12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam11
            // 
            this.pointsTeam11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam11.AutoSize = true;
            this.pointsTeam11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam11.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam11.ForeColor = System.Drawing.Color.White;
            this.pointsTeam11.Location = new System.Drawing.Point(104, 694);
            this.pointsTeam11.Name = "pointsTeam11";
            this.pointsTeam11.Size = new System.Drawing.Size(76, 31);
            this.pointsTeam11.TabIndex = 108;
            this.pointsTeam11.Text = "label5";
            this.pointsTeam11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam10
            // 
            this.pointsTeam10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam10.AutoSize = true;
            this.pointsTeam10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam10.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam10.ForeColor = System.Drawing.Color.White;
            this.pointsTeam10.Location = new System.Drawing.Point(104, 538);
            this.pointsTeam10.Name = "pointsTeam10";
            this.pointsTeam10.Size = new System.Drawing.Size(76, 31);
            this.pointsTeam10.TabIndex = 107;
            this.pointsTeam10.Text = "label4";
            this.pointsTeam10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam9
            // 
            this.pointsTeam9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam9.AutoSize = true;
            this.pointsTeam9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam9.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam9.ForeColor = System.Drawing.Color.White;
            this.pointsTeam9.Location = new System.Drawing.Point(104, 381);
            this.pointsTeam9.Name = "pointsTeam9";
            this.pointsTeam9.Size = new System.Drawing.Size(76, 31);
            this.pointsTeam9.TabIndex = 106;
            this.pointsTeam9.Text = "label3";
            this.pointsTeam9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam8
            // 
            this.pointsTeam8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam8.AutoSize = true;
            this.pointsTeam8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam8.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam8.ForeColor = System.Drawing.Color.White;
            this.pointsTeam8.Location = new System.Drawing.Point(104, 225);
            this.pointsTeam8.Name = "pointsTeam8";
            this.pointsTeam8.Size = new System.Drawing.Size(76, 31);
            this.pointsTeam8.TabIndex = 105;
            this.pointsTeam8.Text = "label2";
            this.pointsTeam8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam7
            // 
            this.pointsTeam7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam7.AutoSize = true;
            this.pointsTeam7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam7.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam7.ForeColor = System.Drawing.Color.White;
            this.pointsTeam7.Location = new System.Drawing.Point(104, 69);
            this.pointsTeam7.Name = "pointsTeam7";
            this.pointsTeam7.Size = new System.Drawing.Size(76, 31);
            this.pointsTeam7.TabIndex = 104;
            this.pointsTeam7.Text = "label1";
            this.pointsTeam7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt12
            // 
            this.teamNameTxt12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt12.AutoSize = true;
            this.teamNameTxt12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt12.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt12.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt12.Location = new System.Drawing.Point(48, 893);
            this.teamNameTxt12.Name = "teamNameTxt12";
            this.teamNameTxt12.Size = new System.Drawing.Size(26, 31);
            this.teamNameTxt12.TabIndex = 103;
            this.teamNameTxt12.Text = "0";
            this.teamNameTxt12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt11
            // 
            this.teamNameTxt11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt11.AutoSize = true;
            this.teamNameTxt11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt11.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt11.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt11.Location = new System.Drawing.Point(48, 738);
            this.teamNameTxt11.Name = "teamNameTxt11";
            this.teamNameTxt11.Size = new System.Drawing.Size(26, 31);
            this.teamNameTxt11.TabIndex = 102;
            this.teamNameTxt11.Text = "0";
            this.teamNameTxt11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt10
            // 
            this.teamNameTxt10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt10.AutoSize = true;
            this.teamNameTxt10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt10.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt10.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt10.Location = new System.Drawing.Point(48, 581);
            this.teamNameTxt10.Name = "teamNameTxt10";
            this.teamNameTxt10.Size = new System.Drawing.Size(26, 31);
            this.teamNameTxt10.TabIndex = 101;
            this.teamNameTxt10.Text = "0";
            this.teamNameTxt10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt9
            // 
            this.teamNameTxt9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt9.AutoSize = true;
            this.teamNameTxt9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt9.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt9.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt9.Location = new System.Drawing.Point(48, 425);
            this.teamNameTxt9.Name = "teamNameTxt9";
            this.teamNameTxt9.Size = new System.Drawing.Size(26, 31);
            this.teamNameTxt9.TabIndex = 100;
            this.teamNameTxt9.Text = "0";
            this.teamNameTxt9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt8
            // 
            this.teamNameTxt8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt8.AutoSize = true;
            this.teamNameTxt8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt8.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt8.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt8.Location = new System.Drawing.Point(48, 267);
            this.teamNameTxt8.Name = "teamNameTxt8";
            this.teamNameTxt8.Size = new System.Drawing.Size(26, 31);
            this.teamNameTxt8.TabIndex = 99;
            this.teamNameTxt8.Text = "0";
            this.teamNameTxt8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt7
            // 
            this.teamNameTxt7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt7.AutoSize = true;
            this.teamNameTxt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt7.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt7.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt7.Location = new System.Drawing.Point(48, 112);
            this.teamNameTxt7.Name = "teamNameTxt7";
            this.teamNameTxt7.Size = new System.Drawing.Size(26, 31);
            this.teamNameTxt7.TabIndex = 98;
            this.teamNameTxt7.Text = "0";
            this.teamNameTxt7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt4
            // 
            this.teamNameTxt4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt4.AutoSize = true;
            this.teamNameTxt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt4.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt4.Location = new System.Drawing.Point(1055, 893);
            this.teamNameTxt4.Name = "teamNameTxt4";
            this.teamNameTxt4.Size = new System.Drawing.Size(26, 31);
            this.teamNameTxt4.TabIndex = 97;
            this.teamNameTxt4.Text = "0";
            this.teamNameTxt4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt3
            // 
            this.teamNameTxt3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt3.AutoSize = true;
            this.teamNameTxt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt3.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt3.Location = new System.Drawing.Point(1055, 738);
            this.teamNameTxt3.Name = "teamNameTxt3";
            this.teamNameTxt3.Size = new System.Drawing.Size(26, 31);
            this.teamNameTxt3.TabIndex = 96;
            this.teamNameTxt3.Text = "0";
            this.teamNameTxt3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt2
            // 
            this.teamNameTxt2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt2.AutoSize = true;
            this.teamNameTxt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt2.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt2.Location = new System.Drawing.Point(1055, 581);
            this.teamNameTxt2.Name = "teamNameTxt2";
            this.teamNameTxt2.Size = new System.Drawing.Size(26, 31);
            this.teamNameTxt2.TabIndex = 95;
            this.teamNameTxt2.Text = "0";
            this.teamNameTxt2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt1
            // 
            this.teamNameTxt1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt1.AutoSize = true;
            this.teamNameTxt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt1.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt1.Location = new System.Drawing.Point(1055, 425);
            this.teamNameTxt1.Name = "teamNameTxt1";
            this.teamNameTxt1.Size = new System.Drawing.Size(26, 31);
            this.teamNameTxt1.TabIndex = 94;
            this.teamNameTxt1.Text = "0";
            this.teamNameTxt1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt5
            // 
            this.teamNameTxt5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt5.AutoSize = true;
            this.teamNameTxt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt5.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt5.Location = new System.Drawing.Point(1055, 267);
            this.teamNameTxt5.Name = "teamNameTxt5";
            this.teamNameTxt5.Size = new System.Drawing.Size(26, 31);
            this.teamNameTxt5.TabIndex = 93;
            this.teamNameTxt5.Text = "0";
            this.teamNameTxt5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt6
            // 
            this.teamNameTxt6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt6.AutoSize = true;
            this.teamNameTxt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt6.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt6.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt6.Location = new System.Drawing.Point(1055, 112);
            this.teamNameTxt6.Name = "teamNameTxt6";
            this.teamNameTxt6.Size = new System.Drawing.Size(26, 31);
            this.teamNameTxt6.TabIndex = 92;
            this.teamNameTxt6.Text = "0";
            this.teamNameTxt6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureTeam4
            // 
            this.pictureTeam4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam4.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam4.BackgroundImage")));
            this.pictureTeam4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam4.Location = new System.Drawing.Point(1038, 792);
            this.pictureTeam4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam4.Name = "pictureTeam4";
            this.pictureTeam4.Size = new System.Drawing.Size(225, 150);
            this.pictureTeam4.TabIndex = 71;
            this.pictureTeam4.TabStop = false;
            // 
            // pictureTeam3
            // 
            this.pictureTeam3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam3.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam3.BackgroundImage")));
            this.pictureTeam3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam3.Location = new System.Drawing.Point(1040, 636);
            this.pictureTeam3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam3.Name = "pictureTeam3";
            this.pictureTeam3.Size = new System.Drawing.Size(225, 150);
            this.pictureTeam3.TabIndex = 70;
            this.pictureTeam3.TabStop = false;
            // 
            // pictureTeam2
            // 
            this.pictureTeam2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam2.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam2.BackgroundImage")));
            this.pictureTeam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam2.Location = new System.Drawing.Point(1038, 480);
            this.pictureTeam2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam2.Name = "pictureTeam2";
            this.pictureTeam2.Size = new System.Drawing.Size(225, 150);
            this.pictureTeam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTeam2.TabIndex = 69;
            this.pictureTeam2.TabStop = false;
            // 
            // pictureTeam1
            // 
            this.pictureTeam1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam1.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam1.BackgroundImage")));
            this.pictureTeam1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam1.Location = new System.Drawing.Point(1038, 324);
            this.pictureTeam1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam1.Name = "pictureTeam1";
            this.pictureTeam1.Size = new System.Drawing.Size(225, 150);
            this.pictureTeam1.TabIndex = 68;
            this.pictureTeam1.TabStop = false;
            // 
            // pictureTeam5
            // 
            this.pictureTeam5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam5.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam5.BackgroundImage")));
            this.pictureTeam5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam5.Location = new System.Drawing.Point(1038, 168);
            this.pictureTeam5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam5.Name = "pictureTeam5";
            this.pictureTeam5.Size = new System.Drawing.Size(225, 150);
            this.pictureTeam5.TabIndex = 67;
            this.pictureTeam5.TabStop = false;
            // 
            // pictureTeam6
            // 
            this.pictureTeam6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam6.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam6.BackgroundImage")));
            this.pictureTeam6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam6.Location = new System.Drawing.Point(1038, 12);
            this.pictureTeam6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam6.Name = "pictureTeam6";
            this.pictureTeam6.Size = new System.Drawing.Size(225, 150);
            this.pictureTeam6.TabIndex = 66;
            this.pictureTeam6.TabStop = false;
            // 
            // pictureTeam12
            // 
            this.pictureTeam12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam12.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam12.BackgroundImage")));
            this.pictureTeam12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam12.Location = new System.Drawing.Point(0, 792);
            this.pictureTeam12.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam12.Name = "pictureTeam12";
            this.pictureTeam12.Size = new System.Drawing.Size(225, 150);
            this.pictureTeam12.TabIndex = 65;
            this.pictureTeam12.TabStop = false;
            // 
            // pictureTeam11
            // 
            this.pictureTeam11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam11.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam11.BackgroundImage")));
            this.pictureTeam11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam11.Location = new System.Drawing.Point(0, 636);
            this.pictureTeam11.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam11.Name = "pictureTeam11";
            this.pictureTeam11.Size = new System.Drawing.Size(225, 150);
            this.pictureTeam11.TabIndex = 64;
            this.pictureTeam11.TabStop = false;
            // 
            // pictureTeam10
            // 
            this.pictureTeam10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam10.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam10.BackgroundImage")));
            this.pictureTeam10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam10.Location = new System.Drawing.Point(0, 480);
            this.pictureTeam10.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam10.Name = "pictureTeam10";
            this.pictureTeam10.Size = new System.Drawing.Size(225, 150);
            this.pictureTeam10.TabIndex = 63;
            this.pictureTeam10.TabStop = false;
            // 
            // pictureTeam9
            // 
            this.pictureTeam9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam9.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam9.BackgroundImage")));
            this.pictureTeam9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam9.Location = new System.Drawing.Point(0, 324);
            this.pictureTeam9.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam9.Name = "pictureTeam9";
            this.pictureTeam9.Size = new System.Drawing.Size(225, 150);
            this.pictureTeam9.TabIndex = 62;
            this.pictureTeam9.TabStop = false;
            // 
            // pictureTeam8
            // 
            this.pictureTeam8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam8.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam8.BackgroundImage")));
            this.pictureTeam8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam8.Location = new System.Drawing.Point(0, 168);
            this.pictureTeam8.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam8.Name = "pictureTeam8";
            this.pictureTeam8.Size = new System.Drawing.Size(225, 150);
            this.pictureTeam8.TabIndex = 61;
            this.pictureTeam8.TabStop = false;
            // 
            // pictureTeam7
            // 
            this.pictureTeam7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam7.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam7.Image = ((System.Drawing.Image)(resources.GetObject("pictureTeam7.Image")));
            this.pictureTeam7.Location = new System.Drawing.Point(0, 12);
            this.pictureTeam7.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam7.Name = "pictureTeam7";
            this.pictureTeam7.Size = new System.Drawing.Size(225, 150);
            this.pictureTeam7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTeam7.TabIndex = 60;
            this.pictureTeam7.TabStop = false;
            // 
            // categoryBtn1
            // 
            this.categoryBtn1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn1.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn1.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn1.Image")));
            this.categoryBtn1.Location = new System.Drawing.Point(227, 417);
            this.categoryBtn1.Name = "categoryBtn1";
            this.categoryBtn1.Size = new System.Drawing.Size(275, 100);
            this.categoryBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn1.TabIndex = 72;
            this.categoryBtn1.TabStop = false;
            // 
            // categoryBtn2
            // 
            this.categoryBtn2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn2.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn2.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn2.Image")));
            this.categoryBtn2.Location = new System.Drawing.Point(227, 523);
            this.categoryBtn2.Name = "categoryBtn2";
            this.categoryBtn2.Size = new System.Drawing.Size(275, 100);
            this.categoryBtn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn2.TabIndex = 73;
            this.categoryBtn2.TabStop = false;
            // 
            // categoryBtn3
            // 
            this.categoryBtn3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn3.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn3.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn3.Image")));
            this.categoryBtn3.Location = new System.Drawing.Point(227, 629);
            this.categoryBtn3.Name = "categoryBtn3";
            this.categoryBtn3.Size = new System.Drawing.Size(275, 100);
            this.categoryBtn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn3.TabIndex = 74;
            this.categoryBtn3.TabStop = false;
            // 
            // categoryBtn4
            // 
            this.categoryBtn4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn4.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn4.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn4.Image")));
            this.categoryBtn4.Location = new System.Drawing.Point(227, 735);
            this.categoryBtn4.Name = "categoryBtn4";
            this.categoryBtn4.Size = new System.Drawing.Size(275, 100);
            this.categoryBtn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn4.TabIndex = 75;
            this.categoryBtn4.TabStop = false;
            // 
            // trackSelectBtn1c1
            // 
            this.trackSelectBtn1c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c1.Image")));
            this.trackSelectBtn1c1.Location = new System.Drawing.Point(516, 417);
            this.trackSelectBtn1c1.Name = "trackSelectBtn1c1";
            this.trackSelectBtn1c1.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn1c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c1.TabIndex = 76;
            this.trackSelectBtn1c1.TabStop = false;
            // 
            // trackSelectBtn1c2
            // 
            this.trackSelectBtn1c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c2.Image")));
            this.trackSelectBtn1c2.Location = new System.Drawing.Point(647, 417);
            this.trackSelectBtn1c2.Name = "trackSelectBtn1c2";
            this.trackSelectBtn1c2.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn1c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c2.TabIndex = 77;
            this.trackSelectBtn1c2.TabStop = false;
            // 
            // trackSelectBtn1c3
            // 
            this.trackSelectBtn1c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c3.Image")));
            this.trackSelectBtn1c3.Location = new System.Drawing.Point(778, 417);
            this.trackSelectBtn1c3.Name = "trackSelectBtn1c3";
            this.trackSelectBtn1c3.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn1c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c3.TabIndex = 78;
            this.trackSelectBtn1c3.TabStop = false;
            // 
            // trackSelectBtn1c4
            // 
            this.trackSelectBtn1c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c4.Image")));
            this.trackSelectBtn1c4.Location = new System.Drawing.Point(909, 417);
            this.trackSelectBtn1c4.Name = "trackSelectBtn1c4";
            this.trackSelectBtn1c4.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn1c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c4.TabIndex = 79;
            this.trackSelectBtn1c4.TabStop = false;
            // 
            // trackSelectBtn2c1
            // 
            this.trackSelectBtn2c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c1.Image")));
            this.trackSelectBtn2c1.Location = new System.Drawing.Point(516, 523);
            this.trackSelectBtn2c1.Name = "trackSelectBtn2c1";
            this.trackSelectBtn2c1.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn2c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c1.TabIndex = 80;
            this.trackSelectBtn2c1.TabStop = false;
            // 
            // trackSelectBtn2c2
            // 
            this.trackSelectBtn2c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c2.Image")));
            this.trackSelectBtn2c2.Location = new System.Drawing.Point(647, 523);
            this.trackSelectBtn2c2.Name = "trackSelectBtn2c2";
            this.trackSelectBtn2c2.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn2c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c2.TabIndex = 81;
            this.trackSelectBtn2c2.TabStop = false;
            // 
            // trackSelectBtn2c3
            // 
            this.trackSelectBtn2c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c3.Image")));
            this.trackSelectBtn2c3.Location = new System.Drawing.Point(778, 523);
            this.trackSelectBtn2c3.Name = "trackSelectBtn2c3";
            this.trackSelectBtn2c3.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn2c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c3.TabIndex = 82;
            this.trackSelectBtn2c3.TabStop = false;
            // 
            // trackSelectBtn2c4
            // 
            this.trackSelectBtn2c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c4.Image")));
            this.trackSelectBtn2c4.Location = new System.Drawing.Point(909, 523);
            this.trackSelectBtn2c4.Name = "trackSelectBtn2c4";
            this.trackSelectBtn2c4.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn2c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c4.TabIndex = 83;
            this.trackSelectBtn2c4.TabStop = false;
            // 
            // trackSelectBtn3c1
            // 
            this.trackSelectBtn3c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c1.Image")));
            this.trackSelectBtn3c1.Location = new System.Drawing.Point(516, 629);
            this.trackSelectBtn3c1.Name = "trackSelectBtn3c1";
            this.trackSelectBtn3c1.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn3c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c1.TabIndex = 84;
            this.trackSelectBtn3c1.TabStop = false;
            // 
            // trackSelectBtn3c2
            // 
            this.trackSelectBtn3c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c2.Image")));
            this.trackSelectBtn3c2.Location = new System.Drawing.Point(647, 629);
            this.trackSelectBtn3c2.Name = "trackSelectBtn3c2";
            this.trackSelectBtn3c2.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn3c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c2.TabIndex = 85;
            this.trackSelectBtn3c2.TabStop = false;
            // 
            // trackSelectBtn3c3
            // 
            this.trackSelectBtn3c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c3.Image")));
            this.trackSelectBtn3c3.Location = new System.Drawing.Point(778, 629);
            this.trackSelectBtn3c3.Name = "trackSelectBtn3c3";
            this.trackSelectBtn3c3.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn3c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c3.TabIndex = 86;
            this.trackSelectBtn3c3.TabStop = false;
            // 
            // trackSelectBtn3c4
            // 
            this.trackSelectBtn3c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c4.Image")));
            this.trackSelectBtn3c4.Location = new System.Drawing.Point(909, 629);
            this.trackSelectBtn3c4.Name = "trackSelectBtn3c4";
            this.trackSelectBtn3c4.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn3c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c4.TabIndex = 87;
            this.trackSelectBtn3c4.TabStop = false;
            // 
            // trackSelectBtn4c1
            // 
            this.trackSelectBtn4c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c1.Image")));
            this.trackSelectBtn4c1.Location = new System.Drawing.Point(516, 735);
            this.trackSelectBtn4c1.Name = "trackSelectBtn4c1";
            this.trackSelectBtn4c1.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn4c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c1.TabIndex = 88;
            this.trackSelectBtn4c1.TabStop = false;
            // 
            // trackSelectBtn4c2
            // 
            this.trackSelectBtn4c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c2.Image")));
            this.trackSelectBtn4c2.Location = new System.Drawing.Point(647, 735);
            this.trackSelectBtn4c2.Name = "trackSelectBtn4c2";
            this.trackSelectBtn4c2.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn4c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c2.TabIndex = 89;
            this.trackSelectBtn4c2.TabStop = false;
            // 
            // trackSelectBtn4c3
            // 
            this.trackSelectBtn4c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c3.Image")));
            this.trackSelectBtn4c3.Location = new System.Drawing.Point(778, 735);
            this.trackSelectBtn4c3.Name = "trackSelectBtn4c3";
            this.trackSelectBtn4c3.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn4c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c3.TabIndex = 90;
            this.trackSelectBtn4c3.TabStop = false;
            // 
            // trackSelectBtn4c4
            // 
            this.trackSelectBtn4c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c4.Image")));
            this.trackSelectBtn4c4.Location = new System.Drawing.Point(909, 735);
            this.trackSelectBtn4c4.Name = "trackSelectBtn4c4";
            this.trackSelectBtn4c4.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn4c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c4.TabIndex = 91;
            this.trackSelectBtn4c4.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(231, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(801, 363);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 116;
            this.pictureBoxLogo.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(642, 122);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(111, 61);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // GameVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pointsTeam4);
            this.Controls.Add(this.pointsTeam3);
            this.Controls.Add(this.pointsTeam2);
            this.Controls.Add(this.pointsTeam1);
            this.Controls.Add(this.pointsTeam5);
            this.Controls.Add(this.pointsTeam6);
            this.Controls.Add(this.pointsTeam12);
            this.Controls.Add(this.pointsTeam11);
            this.Controls.Add(this.pointsTeam10);
            this.Controls.Add(this.pointsTeam9);
            this.Controls.Add(this.pointsTeam8);
            this.Controls.Add(this.pointsTeam7);
            this.Controls.Add(this.teamNameTxt12);
            this.Controls.Add(this.teamNameTxt11);
            this.Controls.Add(this.teamNameTxt10);
            this.Controls.Add(this.teamNameTxt9);
            this.Controls.Add(this.teamNameTxt8);
            this.Controls.Add(this.teamNameTxt7);
            this.Controls.Add(this.teamNameTxt4);
            this.Controls.Add(this.teamNameTxt3);
            this.Controls.Add(this.teamNameTxt2);
            this.Controls.Add(this.teamNameTxt1);
            this.Controls.Add(this.teamNameTxt5);
            this.Controls.Add(this.teamNameTxt6);
            this.Controls.Add(this.trackSelectBtn4c4);
            this.Controls.Add(this.trackSelectBtn4c3);
            this.Controls.Add(this.trackSelectBtn4c2);
            this.Controls.Add(this.trackSelectBtn4c1);
            this.Controls.Add(this.trackSelectBtn3c4);
            this.Controls.Add(this.trackSelectBtn3c3);
            this.Controls.Add(this.trackSelectBtn3c2);
            this.Controls.Add(this.trackSelectBtn3c1);
            this.Controls.Add(this.trackSelectBtn2c4);
            this.Controls.Add(this.trackSelectBtn2c3);
            this.Controls.Add(this.trackSelectBtn2c2);
            this.Controls.Add(this.trackSelectBtn2c1);
            this.Controls.Add(this.trackSelectBtn1c4);
            this.Controls.Add(this.trackSelectBtn1c3);
            this.Controls.Add(this.trackSelectBtn1c2);
            this.Controls.Add(this.trackSelectBtn1c1);
            this.Controls.Add(this.categoryBtn4);
            this.Controls.Add(this.categoryBtn3);
            this.Controls.Add(this.categoryBtn2);
            this.Controls.Add(this.categoryBtn1);
            this.Controls.Add(this.pictureTeam4);
            this.Controls.Add(this.pictureTeam3);
            this.Controls.Add(this.pictureTeam2);
            this.Controls.Add(this.pictureTeam1);
            this.Controls.Add(this.pictureTeam5);
            this.Controls.Add(this.pictureTeam6);
            this.Controls.Add(this.pictureTeam12);
            this.Controls.Add(this.pictureTeam11);
            this.Controls.Add(this.pictureTeam10);
            this.Controls.Add(this.pictureTeam9);
            this.Controls.Add(this.pictureTeam8);
            this.Controls.Add(this.pictureTeam7);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "GameVision";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GameVision";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GameVision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void resolution1366x768()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameVision));
            this.pointsTeam4 = new System.Windows.Forms.Label();
            this.pointsTeam3 = new System.Windows.Forms.Label();
            this.pointsTeam2 = new System.Windows.Forms.Label();
            this.pointsTeam1 = new System.Windows.Forms.Label();
            this.pointsTeam5 = new System.Windows.Forms.Label();
            this.pointsTeam6 = new System.Windows.Forms.Label();
            this.pointsTeam12 = new System.Windows.Forms.Label();
            this.pointsTeam11 = new System.Windows.Forms.Label();
            this.pointsTeam10 = new System.Windows.Forms.Label();
            this.pointsTeam9 = new System.Windows.Forms.Label();
            this.pointsTeam8 = new System.Windows.Forms.Label();
            this.pointsTeam7 = new System.Windows.Forms.Label();
            this.teamNameTxt12 = new System.Windows.Forms.Label();
            this.teamNameTxt11 = new System.Windows.Forms.Label();
            this.teamNameTxt10 = new System.Windows.Forms.Label();
            this.teamNameTxt9 = new System.Windows.Forms.Label();
            this.teamNameTxt8 = new System.Windows.Forms.Label();
            this.teamNameTxt7 = new System.Windows.Forms.Label();
            this.teamNameTxt4 = new System.Windows.Forms.Label();
            this.teamNameTxt3 = new System.Windows.Forms.Label();
            this.teamNameTxt2 = new System.Windows.Forms.Label();
            this.teamNameTxt1 = new System.Windows.Forms.Label();
            this.teamNameTxt5 = new System.Windows.Forms.Label();
            this.teamNameTxt6 = new System.Windows.Forms.Label();
            this.pictureTeam4 = new System.Windows.Forms.PictureBox();
            this.pictureTeam3 = new System.Windows.Forms.PictureBox();
            this.pictureTeam2 = new System.Windows.Forms.PictureBox();
            this.pictureTeam1 = new System.Windows.Forms.PictureBox();
            this.pictureTeam5 = new System.Windows.Forms.PictureBox();
            this.pictureTeam6 = new System.Windows.Forms.PictureBox();
            this.pictureTeam12 = new System.Windows.Forms.PictureBox();
            this.pictureTeam11 = new System.Windows.Forms.PictureBox();
            this.pictureTeam10 = new System.Windows.Forms.PictureBox();
            this.pictureTeam9 = new System.Windows.Forms.PictureBox();
            this.pictureTeam8 = new System.Windows.Forms.PictureBox();
            this.pictureTeam7 = new System.Windows.Forms.PictureBox();
            this.categoryBtn1 = new System.Windows.Forms.PictureBox();
            this.categoryBtn2 = new System.Windows.Forms.PictureBox();
            this.categoryBtn3 = new System.Windows.Forms.PictureBox();
            this.categoryBtn4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsTeam4
            // 
            this.pointsTeam4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam4.AutoSize = true;
            this.pointsTeam4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam4.ForeColor = System.Drawing.Color.White;
            this.pointsTeam4.Location = new System.Drawing.Point(1221, 607);
            this.pointsTeam4.Name = "pointsTeam4";
            this.pointsTeam4.Size = new System.Drawing.Size(70, 25);
            this.pointsTeam4.TabIndex = 115;
            this.pointsTeam4.Text = "label1";
            this.pointsTeam4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam3
            // 
            this.pointsTeam3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam3.AutoSize = true;
            this.pointsTeam3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam3.ForeColor = System.Drawing.Color.White;
            this.pointsTeam3.Location = new System.Drawing.Point(1222, 501);
            this.pointsTeam3.Name = "pointsTeam3";
            this.pointsTeam3.Size = new System.Drawing.Size(70, 25);
            this.pointsTeam3.TabIndex = 114;
            this.pointsTeam3.Text = "label4";
            this.pointsTeam3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam2
            // 
            this.pointsTeam2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam2.AutoSize = true;
            this.pointsTeam2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam2.ForeColor = System.Drawing.Color.White;
            this.pointsTeam2.Location = new System.Drawing.Point(1222, 394);
            this.pointsTeam2.Name = "pointsTeam2";
            this.pointsTeam2.Size = new System.Drawing.Size(70, 25);
            this.pointsTeam2.TabIndex = 113;
            this.pointsTeam2.Text = "label1";
            this.pointsTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam1
            // 
            this.pointsTeam1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam1.AutoSize = true;
            this.pointsTeam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam1.ForeColor = System.Drawing.Color.White;
            this.pointsTeam1.Location = new System.Drawing.Point(1223, 288);
            this.pointsTeam1.Name = "pointsTeam1";
            this.pointsTeam1.Size = new System.Drawing.Size(70, 25);
            this.pointsTeam1.TabIndex = 112;
            this.pointsTeam1.Text = "label1";
            this.pointsTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam5
            // 
            this.pointsTeam5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam5.AutoSize = true;
            this.pointsTeam5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam5.ForeColor = System.Drawing.Color.White;
            this.pointsTeam5.Location = new System.Drawing.Point(1223, 182);
            this.pointsTeam5.Name = "pointsTeam5";
            this.pointsTeam5.Size = new System.Drawing.Size(70, 25);
            this.pointsTeam5.TabIndex = 111;
            this.pointsTeam5.Text = "label1";
            this.pointsTeam5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam6
            // 
            this.pointsTeam6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam6.AutoSize = true;
            this.pointsTeam6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam6.ForeColor = System.Drawing.Color.White;
            this.pointsTeam6.Location = new System.Drawing.Point(1222, 76);
            this.pointsTeam6.Name = "pointsTeam6";
            this.pointsTeam6.Size = new System.Drawing.Size(70, 25);
            this.pointsTeam6.TabIndex = 110;
            this.pointsTeam6.Text = "label1";
            this.pointsTeam6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam12
            // 
            this.pointsTeam12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam12.AutoSize = true;
            this.pointsTeam12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam12.ForeColor = System.Drawing.Color.White;
            this.pointsTeam12.Location = new System.Drawing.Point(58, 607);
            this.pointsTeam12.Name = "pointsTeam12";
            this.pointsTeam12.Size = new System.Drawing.Size(70, 25);
            this.pointsTeam12.TabIndex = 109;
            this.pointsTeam12.Text = "label6";
            this.pointsTeam12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam11
            // 
            this.pointsTeam11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam11.AutoSize = true;
            this.pointsTeam11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam11.ForeColor = System.Drawing.Color.White;
            this.pointsTeam11.Location = new System.Drawing.Point(58, 501);
            this.pointsTeam11.Name = "pointsTeam11";
            this.pointsTeam11.Size = new System.Drawing.Size(70, 25);
            this.pointsTeam11.TabIndex = 108;
            this.pointsTeam11.Text = "label5";
            this.pointsTeam11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam10
            // 
            this.pointsTeam10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam10.AutoSize = true;
            this.pointsTeam10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam10.ForeColor = System.Drawing.Color.White;
            this.pointsTeam10.Location = new System.Drawing.Point(58, 394);
            this.pointsTeam10.Name = "pointsTeam10";
            this.pointsTeam10.Size = new System.Drawing.Size(70, 25);
            this.pointsTeam10.TabIndex = 107;
            this.pointsTeam10.Text = "label4";
            this.pointsTeam10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam9
            // 
            this.pointsTeam9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam9.AutoSize = true;
            this.pointsTeam9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam9.ForeColor = System.Drawing.Color.White;
            this.pointsTeam9.Location = new System.Drawing.Point(58, 288);
            this.pointsTeam9.Name = "pointsTeam9";
            this.pointsTeam9.Size = new System.Drawing.Size(70, 25);
            this.pointsTeam9.TabIndex = 106;
            this.pointsTeam9.Text = "label3";
            this.pointsTeam9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam8
            // 
            this.pointsTeam8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam8.AutoSize = true;
            this.pointsTeam8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam8.ForeColor = System.Drawing.Color.White;
            this.pointsTeam8.Location = new System.Drawing.Point(58, 182);
            this.pointsTeam8.Name = "pointsTeam8";
            this.pointsTeam8.Size = new System.Drawing.Size(70, 25);
            this.pointsTeam8.TabIndex = 105;
            this.pointsTeam8.Text = "label2";
            this.pointsTeam8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam7
            // 
            this.pointsTeam7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam7.AutoSize = true;
            this.pointsTeam7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam7.ForeColor = System.Drawing.Color.White;
            this.pointsTeam7.Location = new System.Drawing.Point(58, 76);
            this.pointsTeam7.Name = "pointsTeam7";
            this.pointsTeam7.Size = new System.Drawing.Size(70, 25);
            this.pointsTeam7.TabIndex = 104;
            this.pointsTeam7.Text = "label1";
            this.pointsTeam7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt12
            // 
            this.teamNameTxt12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt12.AutoSize = true;
            this.teamNameTxt12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt12.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt12.Location = new System.Drawing.Point(12, 635);
            this.teamNameTxt12.Name = "teamNameTxt12";
            this.teamNameTxt12.Size = new System.Drawing.Size(24, 25);
            this.teamNameTxt12.TabIndex = 103;
            this.teamNameTxt12.Text = "0";
            this.teamNameTxt12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt11
            // 
            this.teamNameTxt11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt11.AutoSize = true;
            this.teamNameTxt11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt11.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt11.Location = new System.Drawing.Point(12, 530);
            this.teamNameTxt11.Name = "teamNameTxt11";
            this.teamNameTxt11.Size = new System.Drawing.Size(24, 25);
            this.teamNameTxt11.TabIndex = 102;
            this.teamNameTxt11.Text = "0";
            this.teamNameTxt11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt10
            // 
            this.teamNameTxt10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt10.AutoSize = true;
            this.teamNameTxt10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt10.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt10.Location = new System.Drawing.Point(12, 424);
            this.teamNameTxt10.Name = "teamNameTxt10";
            this.teamNameTxt10.Size = new System.Drawing.Size(24, 25);
            this.teamNameTxt10.TabIndex = 101;
            this.teamNameTxt10.Text = "0";
            this.teamNameTxt10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt9
            // 
            this.teamNameTxt9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt9.AutoSize = true;
            this.teamNameTxt9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt9.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt9.Location = new System.Drawing.Point(12, 318);
            this.teamNameTxt9.Name = "teamNameTxt9";
            this.teamNameTxt9.Size = new System.Drawing.Size(24, 25);
            this.teamNameTxt9.TabIndex = 100;
            this.teamNameTxt9.Text = "0";
            this.teamNameTxt9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt8
            // 
            this.teamNameTxt8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt8.AutoSize = true;
            this.teamNameTxt8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt8.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt8.Location = new System.Drawing.Point(12, 213);
            this.teamNameTxt8.Name = "teamNameTxt8";
            this.teamNameTxt8.Size = new System.Drawing.Size(24, 25);
            this.teamNameTxt8.TabIndex = 99;
            this.teamNameTxt8.Text = "0";
            this.teamNameTxt8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt7
            // 
            this.teamNameTxt7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt7.AutoSize = true;
            this.teamNameTxt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt7.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt7.Location = new System.Drawing.Point(12, 106);
            this.teamNameTxt7.Name = "teamNameTxt7";
            this.teamNameTxt7.Size = new System.Drawing.Size(24, 25);
            this.teamNameTxt7.TabIndex = 98;
            this.teamNameTxt7.Text = "0";
            this.teamNameTxt7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt4
            // 
            this.teamNameTxt4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt4.AutoSize = true;
            this.teamNameTxt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt4.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt4.Location = new System.Drawing.Point(1201, 635);
            this.teamNameTxt4.Name = "teamNameTxt4";
            this.teamNameTxt4.Size = new System.Drawing.Size(24, 25);
            this.teamNameTxt4.TabIndex = 97;
            this.teamNameTxt4.Text = "0";
            this.teamNameTxt4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt3
            // 
            this.teamNameTxt3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt3.AutoSize = true;
            this.teamNameTxt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt3.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt3.Location = new System.Drawing.Point(1200, 530);
            this.teamNameTxt3.Name = "teamNameTxt3";
            this.teamNameTxt3.Size = new System.Drawing.Size(24, 25);
            this.teamNameTxt3.TabIndex = 96;
            this.teamNameTxt3.Text = "0";
            this.teamNameTxt3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt2
            // 
            this.teamNameTxt2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt2.AutoSize = true;
            this.teamNameTxt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt2.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt2.Location = new System.Drawing.Point(1200, 424);
            this.teamNameTxt2.Name = "teamNameTxt2";
            this.teamNameTxt2.Size = new System.Drawing.Size(24, 25);
            this.teamNameTxt2.TabIndex = 95;
            this.teamNameTxt2.Text = "0";
            this.teamNameTxt2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt1
            // 
            this.teamNameTxt1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt1.AutoSize = true;
            this.teamNameTxt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt1.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt1.Location = new System.Drawing.Point(1201, 318);
            this.teamNameTxt1.Name = "teamNameTxt1";
            this.teamNameTxt1.Size = new System.Drawing.Size(24, 25);
            this.teamNameTxt1.TabIndex = 94;
            this.teamNameTxt1.Text = "0";
            this.teamNameTxt1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt5
            // 
            this.teamNameTxt5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt5.AutoSize = true;
            this.teamNameTxt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt5.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt5.Location = new System.Drawing.Point(1201, 211);
            this.teamNameTxt5.Name = "teamNameTxt5";
            this.teamNameTxt5.Size = new System.Drawing.Size(24, 25);
            this.teamNameTxt5.TabIndex = 93;
            this.teamNameTxt5.Text = "0";
            this.teamNameTxt5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt6
            // 
            this.teamNameTxt6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt6.AutoSize = true;
            this.teamNameTxt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt6.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt6.Location = new System.Drawing.Point(1202, 106);
            this.teamNameTxt6.Name = "teamNameTxt6";
            this.teamNameTxt6.Size = new System.Drawing.Size(24, 25);
            this.teamNameTxt6.TabIndex = 92;
            this.teamNameTxt6.Text = "0";
            this.teamNameTxt6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureTeam4
            // 
            this.pictureTeam4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam4.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam4.BackgroundImage")));
            this.pictureTeam4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam4.Location = new System.Drawing.Point(1199, 571);
            this.pictureTeam4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam4.Name = "pictureTeam4";
            this.pictureTeam4.Size = new System.Drawing.Size(150, 100);
            this.pictureTeam4.TabIndex = 71;
            this.pictureTeam4.TabStop = false;
            // 
            // pictureTeam3
            // 
            this.pictureTeam3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam3.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam3.BackgroundImage")));
            this.pictureTeam3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam3.Location = new System.Drawing.Point(1199, 465);
            this.pictureTeam3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam3.Name = "pictureTeam3";
            this.pictureTeam3.Size = new System.Drawing.Size(150, 100);
            this.pictureTeam3.TabIndex = 70;
            this.pictureTeam3.TabStop = false;
            // 
            // pictureTeam2
            // 
            this.pictureTeam2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam2.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam2.BackgroundImage")));
            this.pictureTeam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam2.Location = new System.Drawing.Point(1199, 359);
            this.pictureTeam2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam2.Name = "pictureTeam2";
            this.pictureTeam2.Size = new System.Drawing.Size(150, 100);
            this.pictureTeam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTeam2.TabIndex = 69;
            this.pictureTeam2.TabStop = false;
            // 
            // pictureTeam1
            // 
            this.pictureTeam1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam1.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam1.BackgroundImage")));
            this.pictureTeam1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam1.Location = new System.Drawing.Point(1199, 253);
            this.pictureTeam1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam1.Name = "pictureTeam1";
            this.pictureTeam1.Size = new System.Drawing.Size(150, 100);
            this.pictureTeam1.TabIndex = 68;
            this.pictureTeam1.TabStop = false;
            // 
            // pictureTeam5
            // 
            this.pictureTeam5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam5.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam5.BackgroundImage")));
            this.pictureTeam5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam5.Location = new System.Drawing.Point(1199, 147);
            this.pictureTeam5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam5.Name = "pictureTeam5";
            this.pictureTeam5.Size = new System.Drawing.Size(150, 100);
            this.pictureTeam5.TabIndex = 67;
            this.pictureTeam5.TabStop = false;
            // 
            // pictureTeam6
            // 
            this.pictureTeam6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam6.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam6.BackgroundImage")));
            this.pictureTeam6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam6.Location = new System.Drawing.Point(1199, 41);
            this.pictureTeam6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam6.Name = "pictureTeam6";
            this.pictureTeam6.Size = new System.Drawing.Size(150, 100);
            this.pictureTeam6.TabIndex = 66;
            this.pictureTeam6.TabStop = false;
            // 
            // pictureTeam12
            // 
            this.pictureTeam12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam12.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam12.BackgroundImage")));
            this.pictureTeam12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam12.Location = new System.Drawing.Point(0, 571);
            this.pictureTeam12.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam12.Name = "pictureTeam12";
            this.pictureTeam12.Size = new System.Drawing.Size(150, 100);
            this.pictureTeam12.TabIndex = 65;
            this.pictureTeam12.TabStop = false;
            // 
            // pictureTeam11
            // 
            this.pictureTeam11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam11.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam11.BackgroundImage")));
            this.pictureTeam11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam11.Location = new System.Drawing.Point(0, 465);
            this.pictureTeam11.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam11.Name = "pictureTeam11";
            this.pictureTeam11.Size = new System.Drawing.Size(150, 100);
            this.pictureTeam11.TabIndex = 64;
            this.pictureTeam11.TabStop = false;
            // 
            // pictureTeam10
            // 
            this.pictureTeam10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam10.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam10.BackgroundImage")));
            this.pictureTeam10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam10.Location = new System.Drawing.Point(0, 359);
            this.pictureTeam10.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam10.Name = "pictureTeam10";
            this.pictureTeam10.Size = new System.Drawing.Size(150, 100);
            this.pictureTeam10.TabIndex = 63;
            this.pictureTeam10.TabStop = false;
            // 
            // pictureTeam9
            // 
            this.pictureTeam9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam9.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam9.BackgroundImage")));
            this.pictureTeam9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam9.Location = new System.Drawing.Point(0, 253);
            this.pictureTeam9.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam9.Name = "pictureTeam9";
            this.pictureTeam9.Size = new System.Drawing.Size(150, 100);
            this.pictureTeam9.TabIndex = 62;
            this.pictureTeam9.TabStop = false;
            // 
            // pictureTeam8
            // 
            this.pictureTeam8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam8.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam8.BackgroundImage")));
            this.pictureTeam8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam8.Location = new System.Drawing.Point(0, 147);
            this.pictureTeam8.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam8.Name = "pictureTeam8";
            this.pictureTeam8.Size = new System.Drawing.Size(150, 100);
            this.pictureTeam8.TabIndex = 61;
            this.pictureTeam8.TabStop = false;
            // 
            // pictureTeam7
            // 
            this.pictureTeam7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam7.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam7.Image = ((System.Drawing.Image)(resources.GetObject("pictureTeam7.Image")));
            this.pictureTeam7.Location = new System.Drawing.Point(0, 41);
            this.pictureTeam7.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam7.Name = "pictureTeam7";
            this.pictureTeam7.Size = new System.Drawing.Size(150, 100);
            this.pictureTeam7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTeam7.TabIndex = 60;
            this.pictureTeam7.TabStop = false;
            // 
            // categoryBtn1
            // 
            this.categoryBtn1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn1.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn1.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn1.Image")));
            this.categoryBtn1.Location = new System.Drawing.Point(265, 254);
            this.categoryBtn1.Name = "categoryBtn1";
            this.categoryBtn1.Size = new System.Drawing.Size(275, 100);
            this.categoryBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn1.TabIndex = 72;
            this.categoryBtn1.TabStop = false;
            // 
            // categoryBtn2
            // 
            this.categoryBtn2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn2.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn2.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn2.Image")));
            this.categoryBtn2.Location = new System.Drawing.Point(265, 360);
            this.categoryBtn2.Name = "categoryBtn2";
            this.categoryBtn2.Size = new System.Drawing.Size(275, 100);
            this.categoryBtn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn2.TabIndex = 73;
            this.categoryBtn2.TabStop = false;
            // 
            // categoryBtn3
            // 
            this.categoryBtn3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn3.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn3.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn3.Image")));
            this.categoryBtn3.Location = new System.Drawing.Point(265, 466);
            this.categoryBtn3.Name = "categoryBtn3";
            this.categoryBtn3.Size = new System.Drawing.Size(275, 100);
            this.categoryBtn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn3.TabIndex = 74;
            this.categoryBtn3.TabStop = false;
            // 
            // categoryBtn4
            // 
            this.categoryBtn4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn4.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn4.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn4.Image")));
            this.categoryBtn4.Location = new System.Drawing.Point(265, 572);
            this.categoryBtn4.Name = "categoryBtn4";
            this.categoryBtn4.Size = new System.Drawing.Size(275, 100);
            this.categoryBtn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn4.TabIndex = 75;
            this.categoryBtn4.TabStop = false;
            // 
            // trackSelectBtn1c1
            // 
            this.trackSelectBtn1c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c1.Image")));
            this.trackSelectBtn1c1.Location = new System.Drawing.Point(554, 254);
            this.trackSelectBtn1c1.Name = "trackSelectBtn1c1";
            this.trackSelectBtn1c1.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn1c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c1.TabIndex = 76;
            this.trackSelectBtn1c1.TabStop = false;
            // 
            // trackSelectBtn1c2
            // 
            this.trackSelectBtn1c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c2.Image")));
            this.trackSelectBtn1c2.Location = new System.Drawing.Point(685, 254);
            this.trackSelectBtn1c2.Name = "trackSelectBtn1c2";
            this.trackSelectBtn1c2.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn1c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c2.TabIndex = 77;
            this.trackSelectBtn1c2.TabStop = false;
            // 
            // trackSelectBtn1c3
            // 
            this.trackSelectBtn1c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c3.Image")));
            this.trackSelectBtn1c3.Location = new System.Drawing.Point(816, 254);
            this.trackSelectBtn1c3.Name = "trackSelectBtn1c3";
            this.trackSelectBtn1c3.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn1c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c3.TabIndex = 78;
            this.trackSelectBtn1c3.TabStop = false;
            // 
            // trackSelectBtn1c4
            // 
            this.trackSelectBtn1c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c4.Image")));
            this.trackSelectBtn1c4.Location = new System.Drawing.Point(947, 254);
            this.trackSelectBtn1c4.Name = "trackSelectBtn1c4";
            this.trackSelectBtn1c4.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn1c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c4.TabIndex = 79;
            this.trackSelectBtn1c4.TabStop = false;
            // 
            // trackSelectBtn2c1
            // 
            this.trackSelectBtn2c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c1.Image")));
            this.trackSelectBtn2c1.Location = new System.Drawing.Point(554, 360);
            this.trackSelectBtn2c1.Name = "trackSelectBtn2c1";
            this.trackSelectBtn2c1.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn2c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c1.TabIndex = 80;
            this.trackSelectBtn2c1.TabStop = false;
            // 
            // trackSelectBtn2c2
            // 
            this.trackSelectBtn2c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c2.Image")));
            this.trackSelectBtn2c2.Location = new System.Drawing.Point(685, 360);
            this.trackSelectBtn2c2.Name = "trackSelectBtn2c2";
            this.trackSelectBtn2c2.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn2c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c2.TabIndex = 81;
            this.trackSelectBtn2c2.TabStop = false;
            // 
            // trackSelectBtn2c3
            // 
            this.trackSelectBtn2c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c3.Image")));
            this.trackSelectBtn2c3.Location = new System.Drawing.Point(816, 360);
            this.trackSelectBtn2c3.Name = "trackSelectBtn2c3";
            this.trackSelectBtn2c3.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn2c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c3.TabIndex = 82;
            this.trackSelectBtn2c3.TabStop = false;
            // 
            // trackSelectBtn2c4
            // 
            this.trackSelectBtn2c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c4.Image")));
            this.trackSelectBtn2c4.Location = new System.Drawing.Point(947, 360);
            this.trackSelectBtn2c4.Name = "trackSelectBtn2c4";
            this.trackSelectBtn2c4.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn2c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c4.TabIndex = 83;
            this.trackSelectBtn2c4.TabStop = false;
            // 
            // trackSelectBtn3c1
            // 
            this.trackSelectBtn3c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c1.BackgroundImage")));
            this.trackSelectBtn3c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c1.Image")));
            this.trackSelectBtn3c1.Location = new System.Drawing.Point(554, 466);
            this.trackSelectBtn3c1.Name = "trackSelectBtn3c1";
            this.trackSelectBtn3c1.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn3c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c1.TabIndex = 84;
            this.trackSelectBtn3c1.TabStop = false;
            // 
            // trackSelectBtn3c2
            // 
            this.trackSelectBtn3c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c2.Image")));
            this.trackSelectBtn3c2.Location = new System.Drawing.Point(685, 466);
            this.trackSelectBtn3c2.Name = "trackSelectBtn3c2";
            this.trackSelectBtn3c2.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn3c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c2.TabIndex = 85;
            this.trackSelectBtn3c2.TabStop = false;
            // 
            // trackSelectBtn3c3
            // 
            this.trackSelectBtn3c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c3.Image")));
            this.trackSelectBtn3c3.Location = new System.Drawing.Point(816, 466);
            this.trackSelectBtn3c3.Name = "trackSelectBtn3c3";
            this.trackSelectBtn3c3.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn3c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c3.TabIndex = 86;
            this.trackSelectBtn3c3.TabStop = false;
            // 
            // trackSelectBtn3c4
            // 
            this.trackSelectBtn3c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c4.Image")));
            this.trackSelectBtn3c4.Location = new System.Drawing.Point(947, 466);
            this.trackSelectBtn3c4.Name = "trackSelectBtn3c4";
            this.trackSelectBtn3c4.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn3c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c4.TabIndex = 87;
            this.trackSelectBtn3c4.TabStop = false;
            // 
            // trackSelectBtn4c1
            // 
            this.trackSelectBtn4c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c1.Image")));
            this.trackSelectBtn4c1.Location = new System.Drawing.Point(554, 572);
            this.trackSelectBtn4c1.Name = "trackSelectBtn4c1";
            this.trackSelectBtn4c1.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn4c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c1.TabIndex = 88;
            this.trackSelectBtn4c1.TabStop = false;
            // 
            // trackSelectBtn4c2
            // 
            this.trackSelectBtn4c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c2.Image")));
            this.trackSelectBtn4c2.Location = new System.Drawing.Point(685, 572);
            this.trackSelectBtn4c2.Name = "trackSelectBtn4c2";
            this.trackSelectBtn4c2.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn4c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c2.TabIndex = 89;
            this.trackSelectBtn4c2.TabStop = false;
            // 
            // trackSelectBtn4c3
            // 
            this.trackSelectBtn4c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c3.Image")));
            this.trackSelectBtn4c3.Location = new System.Drawing.Point(816, 572);
            this.trackSelectBtn4c3.Name = "trackSelectBtn4c3";
            this.trackSelectBtn4c3.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn4c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c3.TabIndex = 90;
            this.trackSelectBtn4c3.TabStop = false;
            // 
            // trackSelectBtn4c4
            // 
            this.trackSelectBtn4c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c4.Image")));
            this.trackSelectBtn4c4.Location = new System.Drawing.Point(947, 572);
            this.trackSelectBtn4c4.Name = "trackSelectBtn4c4";
            this.trackSelectBtn4c4.Size = new System.Drawing.Size(125, 100);
            this.trackSelectBtn4c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c4.TabIndex = 91;
            this.trackSelectBtn4c4.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(434, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(497, 206);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 116;
            this.pictureBoxLogo.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(685, 122);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(111, 61);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // GameVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pointsTeam4);
            this.Controls.Add(this.pointsTeam3);
            this.Controls.Add(this.pointsTeam2);
            this.Controls.Add(this.pointsTeam1);
            this.Controls.Add(this.pointsTeam5);
            this.Controls.Add(this.pointsTeam6);
            this.Controls.Add(this.pointsTeam12);
            this.Controls.Add(this.pointsTeam11);
            this.Controls.Add(this.pointsTeam10);
            this.Controls.Add(this.pointsTeam9);
            this.Controls.Add(this.pointsTeam8);
            this.Controls.Add(this.pointsTeam7);
            this.Controls.Add(this.teamNameTxt12);
            this.Controls.Add(this.teamNameTxt11);
            this.Controls.Add(this.teamNameTxt10);
            this.Controls.Add(this.teamNameTxt9);
            this.Controls.Add(this.teamNameTxt8);
            this.Controls.Add(this.teamNameTxt7);
            this.Controls.Add(this.teamNameTxt4);
            this.Controls.Add(this.teamNameTxt3);
            this.Controls.Add(this.teamNameTxt2);
            this.Controls.Add(this.teamNameTxt1);
            this.Controls.Add(this.teamNameTxt5);
            this.Controls.Add(this.teamNameTxt6);
            this.Controls.Add(this.trackSelectBtn4c4);
            this.Controls.Add(this.trackSelectBtn4c3);
            this.Controls.Add(this.trackSelectBtn4c2);
            this.Controls.Add(this.trackSelectBtn4c1);
            this.Controls.Add(this.trackSelectBtn3c4);
            this.Controls.Add(this.trackSelectBtn3c3);
            this.Controls.Add(this.trackSelectBtn3c2);
            this.Controls.Add(this.trackSelectBtn3c1);
            this.Controls.Add(this.trackSelectBtn2c4);
            this.Controls.Add(this.trackSelectBtn2c3);
            this.Controls.Add(this.trackSelectBtn2c2);
            this.Controls.Add(this.trackSelectBtn2c1);
            this.Controls.Add(this.trackSelectBtn1c4);
            this.Controls.Add(this.trackSelectBtn1c3);
            this.Controls.Add(this.trackSelectBtn1c2);
            this.Controls.Add(this.trackSelectBtn1c1);
            this.Controls.Add(this.categoryBtn4);
            this.Controls.Add(this.categoryBtn3);
            this.Controls.Add(this.categoryBtn2);
            this.Controls.Add(this.categoryBtn1);
            this.Controls.Add(this.pictureTeam4);
            this.Controls.Add(this.pictureTeam3);
            this.Controls.Add(this.pictureTeam2);
            this.Controls.Add(this.pictureTeam1);
            this.Controls.Add(this.pictureTeam5);
            this.Controls.Add(this.pictureTeam6);
            this.Controls.Add(this.pictureTeam12);
            this.Controls.Add(this.pictureTeam11);
            this.Controls.Add(this.pictureTeam10);
            this.Controls.Add(this.pictureTeam9);
            this.Controls.Add(this.pictureTeam8);
            this.Controls.Add(this.pictureTeam7);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "GameVision";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GameVision";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GameVision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void resolution1600x900()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameVision));
            this.pointsTeam4 = new System.Windows.Forms.Label();
            this.pointsTeam3 = new System.Windows.Forms.Label();
            this.pointsTeam2 = new System.Windows.Forms.Label();
            this.pointsTeam1 = new System.Windows.Forms.Label();
            this.pointsTeam5 = new System.Windows.Forms.Label();
            this.pointsTeam6 = new System.Windows.Forms.Label();
            this.pointsTeam12 = new System.Windows.Forms.Label();
            this.pointsTeam11 = new System.Windows.Forms.Label();
            this.pointsTeam10 = new System.Windows.Forms.Label();
            this.pointsTeam9 = new System.Windows.Forms.Label();
            this.pointsTeam8 = new System.Windows.Forms.Label();
            this.pointsTeam7 = new System.Windows.Forms.Label();
            this.teamNameTxt12 = new System.Windows.Forms.Label();
            this.teamNameTxt11 = new System.Windows.Forms.Label();
            this.teamNameTxt10 = new System.Windows.Forms.Label();
            this.teamNameTxt9 = new System.Windows.Forms.Label();
            this.teamNameTxt8 = new System.Windows.Forms.Label();
            this.teamNameTxt7 = new System.Windows.Forms.Label();
            this.teamNameTxt4 = new System.Windows.Forms.Label();
            this.teamNameTxt3 = new System.Windows.Forms.Label();
            this.teamNameTxt2 = new System.Windows.Forms.Label();
            this.teamNameTxt1 = new System.Windows.Forms.Label();
            this.teamNameTxt5 = new System.Windows.Forms.Label();
            this.teamNameTxt6 = new System.Windows.Forms.Label();
            this.pictureTeam4 = new System.Windows.Forms.PictureBox();
            this.pictureTeam3 = new System.Windows.Forms.PictureBox();
            this.pictureTeam2 = new System.Windows.Forms.PictureBox();
            this.pictureTeam1 = new System.Windows.Forms.PictureBox();
            this.pictureTeam5 = new System.Windows.Forms.PictureBox();
            this.pictureTeam6 = new System.Windows.Forms.PictureBox();
            this.pictureTeam12 = new System.Windows.Forms.PictureBox();
            this.pictureTeam11 = new System.Windows.Forms.PictureBox();
            this.pictureTeam10 = new System.Windows.Forms.PictureBox();
            this.pictureTeam9 = new System.Windows.Forms.PictureBox();
            this.pictureTeam8 = new System.Windows.Forms.PictureBox();
            this.pictureTeam7 = new System.Windows.Forms.PictureBox();
            this.categoryBtn1 = new System.Windows.Forms.PictureBox();
            this.categoryBtn2 = new System.Windows.Forms.PictureBox();
            this.categoryBtn3 = new System.Windows.Forms.PictureBox();
            this.categoryBtn4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsTeam4
            // 
            this.pointsTeam4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam4.AutoSize = true;
            this.pointsTeam4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam4.ForeColor = System.Drawing.Color.White;
            this.pointsTeam4.Location = new System.Drawing.Point(1426, 751);
            this.pointsTeam4.Name = "pointsTeam4";
            this.pointsTeam4.Size = new System.Drawing.Size(68, 29);
            this.pointsTeam4.TabIndex = 115;
            this.pointsTeam4.Text = "label1";
            this.pointsTeam4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam3
            // 
            this.pointsTeam3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam3.AutoSize = true;
            this.pointsTeam3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam3.ForeColor = System.Drawing.Color.White;
            this.pointsTeam3.Location = new System.Drawing.Point(1426, 614);
            this.pointsTeam3.Name = "pointsTeam3";
            this.pointsTeam3.Size = new System.Drawing.Size(68, 29);
            this.pointsTeam3.TabIndex = 114;
            this.pointsTeam3.Text = "label4";
            this.pointsTeam3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam2
            // 
            this.pointsTeam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam2.AutoSize = true;
            this.pointsTeam2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam2.ForeColor = System.Drawing.Color.White;
            this.pointsTeam2.Location = new System.Drawing.Point(1426, 479);
            this.pointsTeam2.Name = "pointsTeam2";
            this.pointsTeam2.Size = new System.Drawing.Size(68, 29);
            this.pointsTeam2.TabIndex = 113;
            this.pointsTeam2.Text = "label1";
            this.pointsTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam1
            // 
            this.pointsTeam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam1.AutoSize = true;
            this.pointsTeam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam1.ForeColor = System.Drawing.Color.White;
            this.pointsTeam1.Location = new System.Drawing.Point(1426, 343);
            this.pointsTeam1.Name = "pointsTeam1";
            this.pointsTeam1.Size = new System.Drawing.Size(68, 29);
            this.pointsTeam1.TabIndex = 112;
            this.pointsTeam1.Text = "label1";
            this.pointsTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam5
            // 
            this.pointsTeam5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam5.AutoSize = true;
            this.pointsTeam5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam5.ForeColor = System.Drawing.Color.White;
            this.pointsTeam5.Location = new System.Drawing.Point(1426, 207);
            this.pointsTeam5.Name = "pointsTeam5";
            this.pointsTeam5.Size = new System.Drawing.Size(68, 29);
            this.pointsTeam5.TabIndex = 111;
            this.pointsTeam5.Text = "label1";
            this.pointsTeam5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam6
            // 
            this.pointsTeam6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsTeam6.AutoSize = true;
            this.pointsTeam6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam6.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam6.ForeColor = System.Drawing.Color.White;
            this.pointsTeam6.Location = new System.Drawing.Point(1426, 70);
            this.pointsTeam6.Name = "pointsTeam6";
            this.pointsTeam6.Size = new System.Drawing.Size(68, 29);
            this.pointsTeam6.TabIndex = 110;
            this.pointsTeam6.Text = "label1";
            this.pointsTeam6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam12
            // 
            this.pointsTeam12.AutoSize = true;
            this.pointsTeam12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam12.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam12.ForeColor = System.Drawing.Color.White;
            this.pointsTeam12.Location = new System.Drawing.Point(85, 751);
            this.pointsTeam12.Name = "pointsTeam12";
            this.pointsTeam12.Size = new System.Drawing.Size(68, 29);
            this.pointsTeam12.TabIndex = 109;
            this.pointsTeam12.Text = "label6";
            this.pointsTeam12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam11
            // 
            this.pointsTeam11.AutoSize = true;
            this.pointsTeam11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam11.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam11.ForeColor = System.Drawing.Color.White;
            this.pointsTeam11.Location = new System.Drawing.Point(85, 614);
            this.pointsTeam11.Name = "pointsTeam11";
            this.pointsTeam11.Size = new System.Drawing.Size(68, 29);
            this.pointsTeam11.TabIndex = 108;
            this.pointsTeam11.Text = "label5";
            this.pointsTeam11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam10
            // 
            this.pointsTeam10.AutoSize = true;
            this.pointsTeam10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam10.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam10.ForeColor = System.Drawing.Color.White;
            this.pointsTeam10.Location = new System.Drawing.Point(85, 479);
            this.pointsTeam10.Name = "pointsTeam10";
            this.pointsTeam10.Size = new System.Drawing.Size(68, 29);
            this.pointsTeam10.TabIndex = 107;
            this.pointsTeam10.Text = "label4";
            this.pointsTeam10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam9
            // 
            this.pointsTeam9.AutoSize = true;
            this.pointsTeam9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam9.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam9.ForeColor = System.Drawing.Color.White;
            this.pointsTeam9.Location = new System.Drawing.Point(85, 343);
            this.pointsTeam9.Name = "pointsTeam9";
            this.pointsTeam9.Size = new System.Drawing.Size(68, 29);
            this.pointsTeam9.TabIndex = 106;
            this.pointsTeam9.Text = "label3";
            this.pointsTeam9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam8
            // 
            this.pointsTeam8.AutoSize = true;
            this.pointsTeam8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam8.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam8.ForeColor = System.Drawing.Color.White;
            this.pointsTeam8.Location = new System.Drawing.Point(85, 207);
            this.pointsTeam8.Name = "pointsTeam8";
            this.pointsTeam8.Size = new System.Drawing.Size(68, 29);
            this.pointsTeam8.TabIndex = 105;
            this.pointsTeam8.Text = "label2";
            this.pointsTeam8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam7
            // 
            this.pointsTeam7.AutoSize = true;
            this.pointsTeam7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam7.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam7.ForeColor = System.Drawing.Color.White;
            this.pointsTeam7.Location = new System.Drawing.Point(85, 70);
            this.pointsTeam7.Name = "pointsTeam7";
            this.pointsTeam7.Size = new System.Drawing.Size(68, 29);
            this.pointsTeam7.TabIndex = 104;
            this.pointsTeam7.Text = "label1";
            this.pointsTeam7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt12
            // 
            this.teamNameTxt12.AutoSize = true;
            this.teamNameTxt12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt12.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt12.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt12.Location = new System.Drawing.Point(23, 789);
            this.teamNameTxt12.Name = "teamNameTxt12";
            this.teamNameTxt12.Size = new System.Drawing.Size(24, 29);
            this.teamNameTxt12.TabIndex = 103;
            this.teamNameTxt12.Text = "0";
            this.teamNameTxt12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt11
            // 
            this.teamNameTxt11.AutoSize = true;
            this.teamNameTxt11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt11.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt11.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt11.Location = new System.Drawing.Point(23, 651);
            this.teamNameTxt11.Name = "teamNameTxt11";
            this.teamNameTxt11.Size = new System.Drawing.Size(24, 29);
            this.teamNameTxt11.TabIndex = 102;
            this.teamNameTxt11.Text = "0";
            this.teamNameTxt11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt10
            // 
            this.teamNameTxt10.AutoSize = true;
            this.teamNameTxt10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt10.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt10.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt10.Location = new System.Drawing.Point(23, 515);
            this.teamNameTxt10.Name = "teamNameTxt10";
            this.teamNameTxt10.Size = new System.Drawing.Size(24, 29);
            this.teamNameTxt10.TabIndex = 101;
            this.teamNameTxt10.Text = "0";
            this.teamNameTxt10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt9
            // 
            this.teamNameTxt9.AutoSize = true;
            this.teamNameTxt9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt9.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt9.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt9.Location = new System.Drawing.Point(23, 379);
            this.teamNameTxt9.Name = "teamNameTxt9";
            this.teamNameTxt9.Size = new System.Drawing.Size(24, 29);
            this.teamNameTxt9.TabIndex = 100;
            this.teamNameTxt9.Text = "0";
            this.teamNameTxt9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt8
            // 
            this.teamNameTxt8.AutoSize = true;
            this.teamNameTxt8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt8.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt8.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt8.Location = new System.Drawing.Point(23, 243);
            this.teamNameTxt8.Name = "teamNameTxt8";
            this.teamNameTxt8.Size = new System.Drawing.Size(24, 29);
            this.teamNameTxt8.TabIndex = 99;
            this.teamNameTxt8.Text = "0";
            this.teamNameTxt8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt7
            // 
            this.teamNameTxt7.AutoSize = true;
            this.teamNameTxt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt7.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt7.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt7.Location = new System.Drawing.Point(23, 108);
            this.teamNameTxt7.Name = "teamNameTxt7";
            this.teamNameTxt7.Size = new System.Drawing.Size(24, 29);
            this.teamNameTxt7.TabIndex = 98;
            this.teamNameTxt7.Text = "0";
            this.teamNameTxt7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt4
            // 
            this.teamNameTxt4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt4.AutoSize = true;
            this.teamNameTxt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt4.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt4.Location = new System.Drawing.Point(1393, 789);
            this.teamNameTxt4.Name = "teamNameTxt4";
            this.teamNameTxt4.Size = new System.Drawing.Size(24, 29);
            this.teamNameTxt4.TabIndex = 97;
            this.teamNameTxt4.Text = "0";
            this.teamNameTxt4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt3
            // 
            this.teamNameTxt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt3.AutoSize = true;
            this.teamNameTxt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt3.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt3.Location = new System.Drawing.Point(1393, 651);
            this.teamNameTxt3.Name = "teamNameTxt3";
            this.teamNameTxt3.Size = new System.Drawing.Size(24, 29);
            this.teamNameTxt3.TabIndex = 96;
            this.teamNameTxt3.Text = "0";
            this.teamNameTxt3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt2
            // 
            this.teamNameTxt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt2.AutoSize = true;
            this.teamNameTxt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt2.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt2.Location = new System.Drawing.Point(1393, 515);
            this.teamNameTxt2.Name = "teamNameTxt2";
            this.teamNameTxt2.Size = new System.Drawing.Size(24, 29);
            this.teamNameTxt2.TabIndex = 95;
            this.teamNameTxt2.Text = "0";
            this.teamNameTxt2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt1
            // 
            this.teamNameTxt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt1.AutoSize = true;
            this.teamNameTxt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt1.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt1.Location = new System.Drawing.Point(1393, 379);
            this.teamNameTxt1.Name = "teamNameTxt1";
            this.teamNameTxt1.Size = new System.Drawing.Size(24, 29);
            this.teamNameTxt1.TabIndex = 94;
            this.teamNameTxt1.Text = "0";
            this.teamNameTxt1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt5
            // 
            this.teamNameTxt5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt5.AutoSize = true;
            this.teamNameTxt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt5.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt5.Location = new System.Drawing.Point(1393, 243);
            this.teamNameTxt5.Name = "teamNameTxt5";
            this.teamNameTxt5.Size = new System.Drawing.Size(24, 29);
            this.teamNameTxt5.TabIndex = 93;
            this.teamNameTxt5.Text = "0";
            this.teamNameTxt5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt6
            // 
            this.teamNameTxt6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamNameTxt6.AutoSize = true;
            this.teamNameTxt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt6.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt6.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt6.Location = new System.Drawing.Point(1393, 108);
            this.teamNameTxt6.Name = "teamNameTxt6";
            this.teamNameTxt6.Size = new System.Drawing.Size(24, 29);
            this.teamNameTxt6.TabIndex = 92;
            this.teamNameTxt6.Text = "0";
            this.teamNameTxt6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureTeam4
            // 
            this.pictureTeam4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam4.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam4.BackgroundImage")));
            this.pictureTeam4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam4.Location = new System.Drawing.Point(1388, 702);
            this.pictureTeam4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam4.Name = "pictureTeam4";
            this.pictureTeam4.Size = new System.Drawing.Size(195, 130);
            this.pictureTeam4.TabIndex = 71;
            this.pictureTeam4.TabStop = false;
            // 
            // pictureTeam3
            // 
            this.pictureTeam3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam3.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam3.BackgroundImage")));
            this.pictureTeam3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam3.Location = new System.Drawing.Point(1388, 566);
            this.pictureTeam3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam3.Name = "pictureTeam3";
            this.pictureTeam3.Size = new System.Drawing.Size(195, 130);
            this.pictureTeam3.TabIndex = 70;
            this.pictureTeam3.TabStop = false;
            // 
            // pictureTeam2
            // 
            this.pictureTeam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam2.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam2.BackgroundImage")));
            this.pictureTeam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam2.Location = new System.Drawing.Point(1388, 430);
            this.pictureTeam2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam2.Name = "pictureTeam2";
            this.pictureTeam2.Size = new System.Drawing.Size(195, 130);
            this.pictureTeam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTeam2.TabIndex = 69;
            this.pictureTeam2.TabStop = false;
            // 
            // pictureTeam1
            // 
            this.pictureTeam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam1.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam1.BackgroundImage")));
            this.pictureTeam1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam1.Location = new System.Drawing.Point(1388, 294);
            this.pictureTeam1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam1.Name = "pictureTeam1";
            this.pictureTeam1.Size = new System.Drawing.Size(195, 130);
            this.pictureTeam1.TabIndex = 68;
            this.pictureTeam1.TabStop = false;
            // 
            // pictureTeam5
            // 
            this.pictureTeam5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam5.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam5.BackgroundImage")));
            this.pictureTeam5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam5.Location = new System.Drawing.Point(1388, 158);
            this.pictureTeam5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam5.Name = "pictureTeam5";
            this.pictureTeam5.Size = new System.Drawing.Size(195, 130);
            this.pictureTeam5.TabIndex = 67;
            this.pictureTeam5.TabStop = false;
            // 
            // pictureTeam6
            // 
            this.pictureTeam6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureTeam6.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam6.BackgroundImage")));
            this.pictureTeam6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam6.Location = new System.Drawing.Point(1388, 22);
            this.pictureTeam6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam6.Name = "pictureTeam6";
            this.pictureTeam6.Size = new System.Drawing.Size(195, 130);
            this.pictureTeam6.TabIndex = 66;
            this.pictureTeam6.TabStop = false;
            // 
            // pictureTeam12
            // 
            this.pictureTeam12.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam12.BackgroundImage")));
            this.pictureTeam12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam12.Location = new System.Drawing.Point(0, 702);
            this.pictureTeam12.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam12.Name = "pictureTeam12";
            this.pictureTeam12.Size = new System.Drawing.Size(195, 130);
            this.pictureTeam12.TabIndex = 65;
            this.pictureTeam12.TabStop = false;
            // 
            // pictureTeam11
            // 
            this.pictureTeam11.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam11.BackgroundImage")));
            this.pictureTeam11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam11.Location = new System.Drawing.Point(0, 566);
            this.pictureTeam11.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam11.Name = "pictureTeam11";
            this.pictureTeam11.Size = new System.Drawing.Size(195, 130);
            this.pictureTeam11.TabIndex = 64;
            this.pictureTeam11.TabStop = false;
            // 
            // pictureTeam10
            // 
            this.pictureTeam10.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam10.BackgroundImage")));
            this.pictureTeam10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam10.Location = new System.Drawing.Point(0, 430);
            this.pictureTeam10.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam10.Name = "pictureTeam10";
            this.pictureTeam10.Size = new System.Drawing.Size(195, 130);
            this.pictureTeam10.TabIndex = 63;
            this.pictureTeam10.TabStop = false;
            // 
            // pictureTeam9
            // 
            this.pictureTeam9.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam9.BackgroundImage")));
            this.pictureTeam9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam9.Location = new System.Drawing.Point(0, 294);
            this.pictureTeam9.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam9.Name = "pictureTeam9";
            this.pictureTeam9.Size = new System.Drawing.Size(195, 130);
            this.pictureTeam9.TabIndex = 62;
            this.pictureTeam9.TabStop = false;
            // 
            // pictureTeam8
            // 
            this.pictureTeam8.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam8.BackgroundImage")));
            this.pictureTeam8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam8.Location = new System.Drawing.Point(0, 158);
            this.pictureTeam8.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam8.Name = "pictureTeam8";
            this.pictureTeam8.Size = new System.Drawing.Size(195, 130);
            this.pictureTeam8.TabIndex = 61;
            this.pictureTeam8.TabStop = false;
            // 
            // pictureTeam7
            // 
            this.pictureTeam7.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam7.Image = ((System.Drawing.Image)(resources.GetObject("pictureTeam7.Image")));
            this.pictureTeam7.Location = new System.Drawing.Point(0, 22);
            this.pictureTeam7.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pictureTeam7.Name = "pictureTeam7";
            this.pictureTeam7.Size = new System.Drawing.Size(195, 130);
            this.pictureTeam7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTeam7.TabIndex = 60;
            this.pictureTeam7.TabStop = false;
            // 
            // categoryBtn1
            // 
            this.categoryBtn1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn1.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn1.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn1.Image")));
            this.categoryBtn1.Location = new System.Drawing.Point(306, 324);
            this.categoryBtn1.Name = "categoryBtn1";
            this.categoryBtn1.Size = new System.Drawing.Size(330, 120);
            this.categoryBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn1.TabIndex = 72;
            this.categoryBtn1.TabStop = false;
            // 
            // categoryBtn2
            // 
            this.categoryBtn2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn2.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn2.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn2.Image")));
            this.categoryBtn2.Location = new System.Drawing.Point(306, 450);
            this.categoryBtn2.Name = "categoryBtn2";
            this.categoryBtn2.Size = new System.Drawing.Size(330, 120);
            this.categoryBtn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn2.TabIndex = 73;
            this.categoryBtn2.TabStop = false;
            // 
            // categoryBtn3
            // 
            this.categoryBtn3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn3.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn3.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn3.Image")));
            this.categoryBtn3.Location = new System.Drawing.Point(306, 576);
            this.categoryBtn3.Name = "categoryBtn3";
            this.categoryBtn3.Size = new System.Drawing.Size(330, 120);
            this.categoryBtn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn3.TabIndex = 74;
            this.categoryBtn3.TabStop = false;
            // 
            // categoryBtn4
            // 
            this.categoryBtn4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn4.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn4.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn4.Image")));
            this.categoryBtn4.Location = new System.Drawing.Point(306, 702);
            this.categoryBtn4.Name = "categoryBtn4";
            this.categoryBtn4.Size = new System.Drawing.Size(330, 120);
            this.categoryBtn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn4.TabIndex = 75;
            this.categoryBtn4.TabStop = false;
            // 
            // trackSelectBtn1c1
            // 
            this.trackSelectBtn1c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c1.Image")));
            this.trackSelectBtn1c1.Location = new System.Drawing.Point(650, 324);
            this.trackSelectBtn1c1.Name = "trackSelectBtn1c1";
            this.trackSelectBtn1c1.Size = new System.Drawing.Size(150, 120);
            this.trackSelectBtn1c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c1.TabIndex = 76;
            this.trackSelectBtn1c1.TabStop = false;
            // 
            // trackSelectBtn1c2
            // 
            this.trackSelectBtn1c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c2.Image")));
            this.trackSelectBtn1c2.Location = new System.Drawing.Point(806, 324);
            this.trackSelectBtn1c2.Name = "trackSelectBtn1c2";
            this.trackSelectBtn1c2.Size = new System.Drawing.Size(150, 120);
            this.trackSelectBtn1c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c2.TabIndex = 77;
            this.trackSelectBtn1c2.TabStop = false;
            // 
            // trackSelectBtn1c3
            // 
            this.trackSelectBtn1c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c3.Image")));
            this.trackSelectBtn1c3.Location = new System.Drawing.Point(962, 324);
            this.trackSelectBtn1c3.Name = "trackSelectBtn1c3";
            this.trackSelectBtn1c3.Size = new System.Drawing.Size(150, 120);
            this.trackSelectBtn1c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c3.TabIndex = 78;
            this.trackSelectBtn1c3.TabStop = false;
            // 
            // trackSelectBtn1c4
            // 
            this.trackSelectBtn1c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c4.Image")));
            this.trackSelectBtn1c4.Location = new System.Drawing.Point(1118, 324);
            this.trackSelectBtn1c4.Name = "trackSelectBtn1c4";
            this.trackSelectBtn1c4.Size = new System.Drawing.Size(150, 120);
            this.trackSelectBtn1c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c4.TabIndex = 79;
            this.trackSelectBtn1c4.TabStop = false;
            // 
            // trackSelectBtn2c1
            // 
            this.trackSelectBtn2c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c1.Image")));
            this.trackSelectBtn2c1.Location = new System.Drawing.Point(650, 450);
            this.trackSelectBtn2c1.Name = "trackSelectBtn2c1";
            this.trackSelectBtn2c1.Size = new System.Drawing.Size(150, 120);
            this.trackSelectBtn2c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c1.TabIndex = 80;
            this.trackSelectBtn2c1.TabStop = false;
            // 
            // trackSelectBtn2c2
            // 
            this.trackSelectBtn2c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c2.Image")));
            this.trackSelectBtn2c2.Location = new System.Drawing.Point(806, 450);
            this.trackSelectBtn2c2.Name = "trackSelectBtn2c2";
            this.trackSelectBtn2c2.Size = new System.Drawing.Size(150, 120);
            this.trackSelectBtn2c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c2.TabIndex = 81;
            this.trackSelectBtn2c2.TabStop = false;
            // 
            // trackSelectBtn2c3
            // 
            this.trackSelectBtn2c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c3.Image")));
            this.trackSelectBtn2c3.Location = new System.Drawing.Point(962, 450);
            this.trackSelectBtn2c3.Name = "trackSelectBtn2c3";
            this.trackSelectBtn2c3.Size = new System.Drawing.Size(150, 120);
            this.trackSelectBtn2c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c3.TabIndex = 82;
            this.trackSelectBtn2c3.TabStop = false;
            // 
            // trackSelectBtn2c4
            // 
            this.trackSelectBtn2c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c4.Image")));
            this.trackSelectBtn2c4.Location = new System.Drawing.Point(1118, 450);
            this.trackSelectBtn2c4.Name = "trackSelectBtn2c4";
            this.trackSelectBtn2c4.Size = new System.Drawing.Size(150, 120);
            this.trackSelectBtn2c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c4.TabIndex = 83;
            this.trackSelectBtn2c4.TabStop = false;
            // 
            // trackSelectBtn3c1
            // 
            this.trackSelectBtn3c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c1.Image")));
            this.trackSelectBtn3c1.Location = new System.Drawing.Point(650, 576);
            this.trackSelectBtn3c1.Name = "trackSelectBtn3c1";
            this.trackSelectBtn3c1.Size = new System.Drawing.Size(150, 120);
            this.trackSelectBtn3c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c1.TabIndex = 84;
            this.trackSelectBtn3c1.TabStop = false;
            // 
            // trackSelectBtn3c2
            // 
            this.trackSelectBtn3c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c2.Image")));
            this.trackSelectBtn3c2.Location = new System.Drawing.Point(806, 576);
            this.trackSelectBtn3c2.Name = "trackSelectBtn3c2";
            this.trackSelectBtn3c2.Size = new System.Drawing.Size(150, 120);
            this.trackSelectBtn3c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c2.TabIndex = 85;
            this.trackSelectBtn3c2.TabStop = false;
            // 
            // trackSelectBtn3c3
            // 
            this.trackSelectBtn3c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c3.Image")));
            this.trackSelectBtn3c3.Location = new System.Drawing.Point(962, 576);
            this.trackSelectBtn3c3.Name = "trackSelectBtn3c3";
            this.trackSelectBtn3c3.Size = new System.Drawing.Size(150, 120);
            this.trackSelectBtn3c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c3.TabIndex = 86;
            this.trackSelectBtn3c3.TabStop = false;
            // 
            // trackSelectBtn3c4
            // 
            this.trackSelectBtn3c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c4.Image")));
            this.trackSelectBtn3c4.Location = new System.Drawing.Point(1118, 576);
            this.trackSelectBtn3c4.Name = "trackSelectBtn3c4";
            this.trackSelectBtn3c4.Size = new System.Drawing.Size(150, 120);
            this.trackSelectBtn3c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c4.TabIndex = 87;
            this.trackSelectBtn3c4.TabStop = false;
            // 
            // trackSelectBtn4c1
            // 
            this.trackSelectBtn4c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c1.Image")));
            this.trackSelectBtn4c1.Location = new System.Drawing.Point(650, 702);
            this.trackSelectBtn4c1.Name = "trackSelectBtn4c1";
            this.trackSelectBtn4c1.Size = new System.Drawing.Size(150, 120);
            this.trackSelectBtn4c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c1.TabIndex = 88;
            this.trackSelectBtn4c1.TabStop = false;
            // 
            // trackSelectBtn4c2
            // 
            this.trackSelectBtn4c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c2.Image")));
            this.trackSelectBtn4c2.Location = new System.Drawing.Point(806, 702);
            this.trackSelectBtn4c2.Name = "trackSelectBtn4c2";
            this.trackSelectBtn4c2.Size = new System.Drawing.Size(150, 120);
            this.trackSelectBtn4c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c2.TabIndex = 89;
            this.trackSelectBtn4c2.TabStop = false;
            // 
            // trackSelectBtn4c3
            // 
            this.trackSelectBtn4c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c3.Image")));
            this.trackSelectBtn4c3.Location = new System.Drawing.Point(962, 702);
            this.trackSelectBtn4c3.Name = "trackSelectBtn4c3";
            this.trackSelectBtn4c3.Size = new System.Drawing.Size(150, 120);
            this.trackSelectBtn4c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c3.TabIndex = 90;
            this.trackSelectBtn4c3.TabStop = false;
            // 
            // trackSelectBtn4c4
            // 
            this.trackSelectBtn4c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c4.Image")));
            this.trackSelectBtn4c4.Location = new System.Drawing.Point(1118, 702);
            this.trackSelectBtn4c4.Name = "trackSelectBtn4c4";
            this.trackSelectBtn4c4.Size = new System.Drawing.Size(150, 120);
            this.trackSelectBtn4c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c4.TabIndex = 91;
            this.trackSelectBtn4c4.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(437, 22);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(675, 295);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 116;
            this.pictureBoxLogo.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(741, 40);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(111, 61);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // GameVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pointsTeam4);
            this.Controls.Add(this.pointsTeam3);
            this.Controls.Add(this.pointsTeam2);
            this.Controls.Add(this.pointsTeam1);
            this.Controls.Add(this.pointsTeam5);
            this.Controls.Add(this.pointsTeam6);
            this.Controls.Add(this.pointsTeam12);
            this.Controls.Add(this.pointsTeam11);
            this.Controls.Add(this.pointsTeam10);
            this.Controls.Add(this.pointsTeam9);
            this.Controls.Add(this.pointsTeam8);
            this.Controls.Add(this.pointsTeam7);
            this.Controls.Add(this.teamNameTxt12);
            this.Controls.Add(this.teamNameTxt11);
            this.Controls.Add(this.teamNameTxt10);
            this.Controls.Add(this.teamNameTxt9);
            this.Controls.Add(this.teamNameTxt8);
            this.Controls.Add(this.teamNameTxt7);
            this.Controls.Add(this.teamNameTxt4);
            this.Controls.Add(this.teamNameTxt3);
            this.Controls.Add(this.teamNameTxt2);
            this.Controls.Add(this.teamNameTxt1);
            this.Controls.Add(this.teamNameTxt5);
            this.Controls.Add(this.teamNameTxt6);
            this.Controls.Add(this.trackSelectBtn4c4);
            this.Controls.Add(this.trackSelectBtn4c3);
            this.Controls.Add(this.trackSelectBtn4c2);
            this.Controls.Add(this.trackSelectBtn4c1);
            this.Controls.Add(this.trackSelectBtn3c4);
            this.Controls.Add(this.trackSelectBtn3c3);
            this.Controls.Add(this.trackSelectBtn3c2);
            this.Controls.Add(this.trackSelectBtn3c1);
            this.Controls.Add(this.trackSelectBtn2c4);
            this.Controls.Add(this.trackSelectBtn2c3);
            this.Controls.Add(this.trackSelectBtn2c2);
            this.Controls.Add(this.trackSelectBtn2c1);
            this.Controls.Add(this.trackSelectBtn1c4);
            this.Controls.Add(this.trackSelectBtn1c3);
            this.Controls.Add(this.trackSelectBtn1c2);
            this.Controls.Add(this.trackSelectBtn1c1);
            this.Controls.Add(this.categoryBtn4);
            this.Controls.Add(this.categoryBtn3);
            this.Controls.Add(this.categoryBtn2);
            this.Controls.Add(this.categoryBtn1);
            this.Controls.Add(this.pictureTeam4);
            this.Controls.Add(this.pictureTeam3);
            this.Controls.Add(this.pictureTeam2);
            this.Controls.Add(this.pictureTeam1);
            this.Controls.Add(this.pictureTeam5);
            this.Controls.Add(this.pictureTeam6);
            this.Controls.Add(this.pictureTeam12);
            this.Controls.Add(this.pictureTeam11);
            this.Controls.Add(this.pictureTeam10);
            this.Controls.Add(this.pictureTeam9);
            this.Controls.Add(this.pictureTeam8);
            this.Controls.Add(this.pictureTeam7);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "GameVision";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GameVision";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GameVision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void resolution1920x1080()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameVision));
            this.pointsTeam4 = new System.Windows.Forms.Label();
            this.pointsTeam3 = new System.Windows.Forms.Label();
            this.pointsTeam2 = new System.Windows.Forms.Label();
            this.pointsTeam1 = new System.Windows.Forms.Label();
            this.pointsTeam5 = new System.Windows.Forms.Label();
            this.pointsTeam6 = new System.Windows.Forms.Label();
            this.pointsTeam12 = new System.Windows.Forms.Label();
            this.pointsTeam11 = new System.Windows.Forms.Label();
            this.pointsTeam10 = new System.Windows.Forms.Label();
            this.pointsTeam9 = new System.Windows.Forms.Label();
            this.pointsTeam8 = new System.Windows.Forms.Label();
            this.pointsTeam7 = new System.Windows.Forms.Label();
            this.teamNameTxt12 = new System.Windows.Forms.Label();
            this.teamNameTxt11 = new System.Windows.Forms.Label();
            this.teamNameTxt10 = new System.Windows.Forms.Label();
            this.teamNameTxt9 = new System.Windows.Forms.Label();
            this.teamNameTxt8 = new System.Windows.Forms.Label();
            this.teamNameTxt7 = new System.Windows.Forms.Label();
            this.teamNameTxt4 = new System.Windows.Forms.Label();
            this.teamNameTxt3 = new System.Windows.Forms.Label();
            this.teamNameTxt2 = new System.Windows.Forms.Label();
            this.teamNameTxt1 = new System.Windows.Forms.Label();
            this.teamNameTxt5 = new System.Windows.Forms.Label();
            this.teamNameTxt6 = new System.Windows.Forms.Label();
            this.pictureTeam4 = new System.Windows.Forms.PictureBox();
            this.pictureTeam3 = new System.Windows.Forms.PictureBox();
            this.pictureTeam2 = new System.Windows.Forms.PictureBox();
            this.pictureTeam1 = new System.Windows.Forms.PictureBox();
            this.pictureTeam5 = new System.Windows.Forms.PictureBox();
            this.pictureTeam6 = new System.Windows.Forms.PictureBox();
            this.pictureTeam12 = new System.Windows.Forms.PictureBox();
            this.pictureTeam11 = new System.Windows.Forms.PictureBox();
            this.pictureTeam10 = new System.Windows.Forms.PictureBox();
            this.pictureTeam9 = new System.Windows.Forms.PictureBox();
            this.pictureTeam8 = new System.Windows.Forms.PictureBox();
            this.pictureTeam7 = new System.Windows.Forms.PictureBox();
            this.categoryBtn1 = new System.Windows.Forms.PictureBox();
            this.categoryBtn2 = new System.Windows.Forms.PictureBox();
            this.categoryBtn3 = new System.Windows.Forms.PictureBox();
            this.categoryBtn4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn1c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn2c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn3c4 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c1 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c2 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c3 = new System.Windows.Forms.PictureBox();
            this.trackSelectBtn4c4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsTeam4
            // 
            this.pointsTeam4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam4.AutoSize = true;
            this.pointsTeam4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam4.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam4.ForeColor = System.Drawing.Color.White;
            this.pointsTeam4.Location = new System.Drawing.Point(1710, 956);
            this.pointsTeam4.Name = "pointsTeam4";
            this.pointsTeam4.Size = new System.Drawing.Size(92, 37);
            this.pointsTeam4.TabIndex = 115;
            this.pointsTeam4.Text = "label1";
            this.pointsTeam4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam3
            // 
            this.pointsTeam3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam3.AutoSize = true;
            this.pointsTeam3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam3.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam3.ForeColor = System.Drawing.Color.White;
            this.pointsTeam3.Location = new System.Drawing.Point(1710, 779);
            this.pointsTeam3.Name = "pointsTeam3";
            this.pointsTeam3.Size = new System.Drawing.Size(92, 37);
            this.pointsTeam3.TabIndex = 114;
            this.pointsTeam3.Text = "label4";
            this.pointsTeam3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam2
            // 
            this.pointsTeam2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam2.AutoSize = true;
            this.pointsTeam2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam2.ForeColor = System.Drawing.Color.White;
            this.pointsTeam2.Location = new System.Drawing.Point(1710, 603);
            this.pointsTeam2.Name = "pointsTeam2";
            this.pointsTeam2.Size = new System.Drawing.Size(92, 37);
            this.pointsTeam2.TabIndex = 113;
            this.pointsTeam2.Text = "label1";
            this.pointsTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam1
            // 
            this.pointsTeam1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam1.AutoSize = true;
            this.pointsTeam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam1.ForeColor = System.Drawing.Color.White;
            this.pointsTeam1.Location = new System.Drawing.Point(1710, 428);
            this.pointsTeam1.Name = "pointsTeam1";
            this.pointsTeam1.Size = new System.Drawing.Size(92, 37);
            this.pointsTeam1.TabIndex = 112;
            this.pointsTeam1.Text = "label1";
            this.pointsTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam5
            // 
            this.pointsTeam5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam5.AutoSize = true;
            this.pointsTeam5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam5.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam5.ForeColor = System.Drawing.Color.White;
            this.pointsTeam5.Location = new System.Drawing.Point(1710, 252);
            this.pointsTeam5.Name = "pointsTeam5";
            this.pointsTeam5.Size = new System.Drawing.Size(92, 37);
            this.pointsTeam5.TabIndex = 111;
            this.pointsTeam5.Text = "label1";
            this.pointsTeam5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam6
            // 
            this.pointsTeam6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pointsTeam6.AutoSize = true;
            this.pointsTeam6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam6.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam6.ForeColor = System.Drawing.Color.White;
            this.pointsTeam6.Location = new System.Drawing.Point(1710, 76);
            this.pointsTeam6.Name = "pointsTeam6";
            this.pointsTeam6.Size = new System.Drawing.Size(92, 37);
            this.pointsTeam6.TabIndex = 110;
            this.pointsTeam6.Text = "label1";
            this.pointsTeam6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsTeam12
            // 
            this.pointsTeam12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam12.AutoSize = true;
            this.pointsTeam12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam12.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam12.ForeColor = System.Drawing.Color.White;
            this.pointsTeam12.Location = new System.Drawing.Point(111, 956);
            this.pointsTeam12.Name = "pointsTeam12";
            this.pointsTeam12.Size = new System.Drawing.Size(92, 37);
            this.pointsTeam12.TabIndex = 109;
            this.pointsTeam12.Text = "label6";
            this.pointsTeam12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam11
            // 
            this.pointsTeam11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam11.AutoSize = true;
            this.pointsTeam11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam11.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam11.ForeColor = System.Drawing.Color.White;
            this.pointsTeam11.Location = new System.Drawing.Point(111, 779);
            this.pointsTeam11.Name = "pointsTeam11";
            this.pointsTeam11.Size = new System.Drawing.Size(92, 37);
            this.pointsTeam11.TabIndex = 108;
            this.pointsTeam11.Text = "label5";
            this.pointsTeam11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam10
            // 
            this.pointsTeam10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam10.AutoSize = true;
            this.pointsTeam10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam10.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam10.ForeColor = System.Drawing.Color.White;
            this.pointsTeam10.Location = new System.Drawing.Point(111, 603);
            this.pointsTeam10.Name = "pointsTeam10";
            this.pointsTeam10.Size = new System.Drawing.Size(92, 37);
            this.pointsTeam10.TabIndex = 107;
            this.pointsTeam10.Text = "label4";
            this.pointsTeam10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam9
            // 
            this.pointsTeam9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam9.AutoSize = true;
            this.pointsTeam9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam9.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam9.ForeColor = System.Drawing.Color.White;
            this.pointsTeam9.Location = new System.Drawing.Point(111, 428);
            this.pointsTeam9.Name = "pointsTeam9";
            this.pointsTeam9.Size = new System.Drawing.Size(92, 37);
            this.pointsTeam9.TabIndex = 106;
            this.pointsTeam9.Text = "label3";
            this.pointsTeam9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam8
            // 
            this.pointsTeam8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam8.AutoSize = true;
            this.pointsTeam8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam8.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam8.ForeColor = System.Drawing.Color.White;
            this.pointsTeam8.Location = new System.Drawing.Point(111, 252);
            this.pointsTeam8.Name = "pointsTeam8";
            this.pointsTeam8.Size = new System.Drawing.Size(92, 37);
            this.pointsTeam8.TabIndex = 105;
            this.pointsTeam8.Text = "label2";
            this.pointsTeam8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pointsTeam7
            // 
            this.pointsTeam7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pointsTeam7.AutoSize = true;
            this.pointsTeam7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.pointsTeam7.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsTeam7.ForeColor = System.Drawing.Color.White;
            this.pointsTeam7.Location = new System.Drawing.Point(111, 76);
            this.pointsTeam7.Name = "pointsTeam7";
            this.pointsTeam7.Size = new System.Drawing.Size(92, 37);
            this.pointsTeam7.TabIndex = 104;
            this.pointsTeam7.Text = "label1";
            this.pointsTeam7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt12
            // 
            this.teamNameTxt12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt12.AutoSize = true;
            this.teamNameTxt12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt12.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt12.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt12.Location = new System.Drawing.Point(12, 1005);
            this.teamNameTxt12.Name = "teamNameTxt12";
            this.teamNameTxt12.Size = new System.Drawing.Size(32, 37);
            this.teamNameTxt12.TabIndex = 103;
            this.teamNameTxt12.Text = "0";
            this.teamNameTxt12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt11
            // 
            this.teamNameTxt11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt11.AutoSize = true;
            this.teamNameTxt11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt11.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt11.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt11.Location = new System.Drawing.Point(12, 829);
            this.teamNameTxt11.Name = "teamNameTxt11";
            this.teamNameTxt11.Size = new System.Drawing.Size(32, 37);
            this.teamNameTxt11.TabIndex = 102;
            this.teamNameTxt11.Text = "0";
            this.teamNameTxt11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt10
            // 
            this.teamNameTxt10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt10.AutoSize = true;
            this.teamNameTxt10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt10.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt10.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt10.Location = new System.Drawing.Point(12, 652);
            this.teamNameTxt10.Name = "teamNameTxt10";
            this.teamNameTxt10.Size = new System.Drawing.Size(32, 37);
            this.teamNameTxt10.TabIndex = 101;
            this.teamNameTxt10.Text = "0";
            this.teamNameTxt10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt9
            // 
            this.teamNameTxt9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt9.AutoSize = true;
            this.teamNameTxt9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt9.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt9.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt9.Location = new System.Drawing.Point(12, 476);
            this.teamNameTxt9.Name = "teamNameTxt9";
            this.teamNameTxt9.Size = new System.Drawing.Size(32, 37);
            this.teamNameTxt9.TabIndex = 100;
            this.teamNameTxt9.Text = "0";
            this.teamNameTxt9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt8
            // 
            this.teamNameTxt8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt8.AutoSize = true;
            this.teamNameTxt8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt8.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt8.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt8.Location = new System.Drawing.Point(12, 301);
            this.teamNameTxt8.Name = "teamNameTxt8";
            this.teamNameTxt8.Size = new System.Drawing.Size(32, 37);
            this.teamNameTxt8.TabIndex = 99;
            this.teamNameTxt8.Text = "0";
            this.teamNameTxt8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt7
            // 
            this.teamNameTxt7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teamNameTxt7.AutoSize = true;
            this.teamNameTxt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt7.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt7.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt7.Location = new System.Drawing.Point(12, 122);
            this.teamNameTxt7.Name = "teamNameTxt7";
            this.teamNameTxt7.Size = new System.Drawing.Size(32, 37);
            this.teamNameTxt7.TabIndex = 98;
            this.teamNameTxt7.Text = "0";
            this.teamNameTxt7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teamNameTxt4
            // 
            this.teamNameTxt4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt4.AutoSize = true;
            this.teamNameTxt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt4.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt4.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt4.Location = new System.Drawing.Point(1680, 1005);
            this.teamNameTxt4.Name = "teamNameTxt4";
            this.teamNameTxt4.Size = new System.Drawing.Size(32, 37);
            this.teamNameTxt4.TabIndex = 97;
            this.teamNameTxt4.Text = "0";
            this.teamNameTxt4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt3
            // 
            this.teamNameTxt3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt3.AutoSize = true;
            this.teamNameTxt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt3.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt3.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt3.Location = new System.Drawing.Point(1680, 829);
            this.teamNameTxt3.Name = "teamNameTxt3";
            this.teamNameTxt3.Size = new System.Drawing.Size(32, 37);
            this.teamNameTxt3.TabIndex = 96;
            this.teamNameTxt3.Text = "0";
            this.teamNameTxt3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt2
            // 
            this.teamNameTxt2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt2.AutoSize = true;
            this.teamNameTxt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt2.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt2.Location = new System.Drawing.Point(1680, 652);
            this.teamNameTxt2.Name = "teamNameTxt2";
            this.teamNameTxt2.Size = new System.Drawing.Size(32, 37);
            this.teamNameTxt2.TabIndex = 95;
            this.teamNameTxt2.Text = "0";
            this.teamNameTxt2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt1
            // 
            this.teamNameTxt1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt1.AutoSize = true;
            this.teamNameTxt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt1.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt1.Location = new System.Drawing.Point(1680, 476);
            this.teamNameTxt1.Name = "teamNameTxt1";
            this.teamNameTxt1.Size = new System.Drawing.Size(32, 37);
            this.teamNameTxt1.TabIndex = 94;
            this.teamNameTxt1.Text = "0";
            this.teamNameTxt1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt5
            // 
            this.teamNameTxt5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt5.AutoSize = true;
            this.teamNameTxt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt5.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt5.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt5.Location = new System.Drawing.Point(1680, 301);
            this.teamNameTxt5.Name = "teamNameTxt5";
            this.teamNameTxt5.Size = new System.Drawing.Size(32, 37);
            this.teamNameTxt5.TabIndex = 93;
            this.teamNameTxt5.Text = "0";
            this.teamNameTxt5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamNameTxt6
            // 
            this.teamNameTxt6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.teamNameTxt6.AutoSize = true;
            this.teamNameTxt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(32)))), ((int)(((byte)(129)))));
            this.teamNameTxt6.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNameTxt6.ForeColor = System.Drawing.Color.White;
            this.teamNameTxt6.Location = new System.Drawing.Point(1680, 122);
            this.teamNameTxt6.Name = "teamNameTxt6";
            this.teamNameTxt6.Size = new System.Drawing.Size(32, 37);
            this.teamNameTxt6.TabIndex = 92;
            this.teamNameTxt6.Text = "0";
            this.teamNameTxt6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureTeam4
            // 
            this.pictureTeam4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam4.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam4.BackgroundImage")));
            this.pictureTeam4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam4.Location = new System.Drawing.Point(1664, 892);
            this.pictureTeam4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam4.Name = "pictureTeam4";
            this.pictureTeam4.Size = new System.Drawing.Size(255, 170);
            this.pictureTeam4.TabIndex = 71;
            this.pictureTeam4.TabStop = false;
            // 
            // pictureTeam3
            // 
            this.pictureTeam3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam3.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam3.BackgroundImage")));
            this.pictureTeam3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam3.Location = new System.Drawing.Point(1664, 716);
            this.pictureTeam3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam3.Name = "pictureTeam3";
            this.pictureTeam3.Size = new System.Drawing.Size(255, 170);
            this.pictureTeam3.TabIndex = 70;
            this.pictureTeam3.TabStop = false;
            // 
            // pictureTeam2
            // 
            this.pictureTeam2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam2.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam2.BackgroundImage")));
            this.pictureTeam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam2.Location = new System.Drawing.Point(1664, 540);
            this.pictureTeam2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam2.Name = "pictureTeam2";
            this.pictureTeam2.Size = new System.Drawing.Size(255, 170);
            this.pictureTeam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTeam2.TabIndex = 69;
            this.pictureTeam2.TabStop = false;
            // 
            // pictureTeam1
            // 
            this.pictureTeam1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam1.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam1.BackgroundImage")));
            this.pictureTeam1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam1.Location = new System.Drawing.Point(1664, 364);
            this.pictureTeam1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam1.Name = "pictureTeam1";
            this.pictureTeam1.Size = new System.Drawing.Size(255, 170);
            this.pictureTeam1.TabIndex = 68;
            this.pictureTeam1.TabStop = false;
            // 
            // pictureTeam5
            // 
            this.pictureTeam5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam5.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam5.BackgroundImage")));
            this.pictureTeam5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam5.Location = new System.Drawing.Point(1664, 188);
            this.pictureTeam5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam5.Name = "pictureTeam5";
            this.pictureTeam5.Size = new System.Drawing.Size(255, 170);
            this.pictureTeam5.TabIndex = 67;
            this.pictureTeam5.TabStop = false;
            // 
            // pictureTeam6
            // 
            this.pictureTeam6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureTeam6.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam6.BackgroundImage")));
            this.pictureTeam6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam6.Location = new System.Drawing.Point(1664, 12);
            this.pictureTeam6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureTeam6.Name = "pictureTeam6";
            this.pictureTeam6.Size = new System.Drawing.Size(255, 170);
            this.pictureTeam6.TabIndex = 66;
            this.pictureTeam6.TabStop = false;
            // 
            // pictureTeam12
            // 
            this.pictureTeam12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam12.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam12.BackgroundImage")));
            this.pictureTeam12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam12.Location = new System.Drawing.Point(0, 892);
            this.pictureTeam12.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pictureTeam12.Name = "pictureTeam12";
            this.pictureTeam12.Size = new System.Drawing.Size(255, 170);
            this.pictureTeam12.TabIndex = 65;
            this.pictureTeam12.TabStop = false;
            // 
            // pictureTeam11
            // 
            this.pictureTeam11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam11.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam11.BackgroundImage")));
            this.pictureTeam11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam11.Location = new System.Drawing.Point(0, 716);
            this.pictureTeam11.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pictureTeam11.Name = "pictureTeam11";
            this.pictureTeam11.Size = new System.Drawing.Size(255, 170);
            this.pictureTeam11.TabIndex = 64;
            this.pictureTeam11.TabStop = false;
            // 
            // pictureTeam10
            // 
            this.pictureTeam10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam10.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam10.BackgroundImage")));
            this.pictureTeam10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam10.Location = new System.Drawing.Point(0, 540);
            this.pictureTeam10.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pictureTeam10.Name = "pictureTeam10";
            this.pictureTeam10.Size = new System.Drawing.Size(255, 170);
            this.pictureTeam10.TabIndex = 63;
            this.pictureTeam10.TabStop = false;
            // 
            // pictureTeam9
            // 
            this.pictureTeam9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam9.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam9.BackgroundImage")));
            this.pictureTeam9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam9.Location = new System.Drawing.Point(0, 364);
            this.pictureTeam9.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pictureTeam9.Name = "pictureTeam9";
            this.pictureTeam9.Size = new System.Drawing.Size(255, 170);
            this.pictureTeam9.TabIndex = 62;
            this.pictureTeam9.TabStop = false;
            // 
            // pictureTeam8
            // 
            this.pictureTeam8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam8.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureTeam8.BackgroundImage")));
            this.pictureTeam8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam8.Location = new System.Drawing.Point(0, 188);
            this.pictureTeam8.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pictureTeam8.Name = "pictureTeam8";
            this.pictureTeam8.Size = new System.Drawing.Size(255, 170);
            this.pictureTeam8.TabIndex = 61;
            this.pictureTeam8.TabStop = false;
            // 
            // pictureTeam7
            // 
            this.pictureTeam7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureTeam7.BackColor = System.Drawing.Color.Transparent;
            this.pictureTeam7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTeam7.Image = ((System.Drawing.Image)(resources.GetObject("pictureTeam7.Image")));
            this.pictureTeam7.Location = new System.Drawing.Point(0, 12);
            this.pictureTeam7.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pictureTeam7.Name = "pictureTeam7";
            this.pictureTeam7.Size = new System.Drawing.Size(255, 170);
            this.pictureTeam7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTeam7.TabIndex = 60;
            this.pictureTeam7.TabStop = false;
            // 
            // categoryBtn1
            // 
            this.categoryBtn1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn1.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn1.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn1.Image")));
            this.categoryBtn1.Location = new System.Drawing.Point(293, 428);
            this.categoryBtn1.Margin = new System.Windows.Forms.Padding(3, 3, 11, 3);
            this.categoryBtn1.Name = "categoryBtn1";
            this.categoryBtn1.Size = new System.Drawing.Size(467, 150);
            this.categoryBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn1.TabIndex = 72;
            this.categoryBtn1.TabStop = false;
            // 
            // categoryBtn2
            // 
            this.categoryBtn2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn2.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn2.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn2.Image")));
            this.categoryBtn2.Location = new System.Drawing.Point(293, 585);
            this.categoryBtn2.Margin = new System.Windows.Forms.Padding(3, 3, 11, 3);
            this.categoryBtn2.Name = "categoryBtn2";
            this.categoryBtn2.Size = new System.Drawing.Size(467, 150);
            this.categoryBtn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn2.TabIndex = 73;
            this.categoryBtn2.TabStop = false;
            // 
            // categoryBtn3
            // 
            this.categoryBtn3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn3.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn3.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn3.Image")));
            this.categoryBtn3.Location = new System.Drawing.Point(293, 741);
            this.categoryBtn3.Margin = new System.Windows.Forms.Padding(3, 3, 11, 3);
            this.categoryBtn3.Name = "categoryBtn3";
            this.categoryBtn3.Size = new System.Drawing.Size(467, 150);
            this.categoryBtn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn3.TabIndex = 74;
            this.categoryBtn3.TabStop = false;
            // 
            // categoryBtn4
            // 
            this.categoryBtn4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.categoryBtn4.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn4.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn4.Image")));
            this.categoryBtn4.Location = new System.Drawing.Point(293, 896);
            this.categoryBtn4.Margin = new System.Windows.Forms.Padding(3, 3, 11, 3);
            this.categoryBtn4.Name = "categoryBtn4";
            this.categoryBtn4.Size = new System.Drawing.Size(467, 150);
            this.categoryBtn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.categoryBtn4.TabIndex = 75;
            this.categoryBtn4.TabStop = false;
            // 
            // trackSelectBtn1c1
            // 
            this.trackSelectBtn1c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c1.Image")));
            this.trackSelectBtn1c1.Location = new System.Drawing.Point(774, 428);
            this.trackSelectBtn1c1.Name = "trackSelectBtn1c1";
            this.trackSelectBtn1c1.Size = new System.Drawing.Size(212, 150);
            this.trackSelectBtn1c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c1.TabIndex = 76;
            this.trackSelectBtn1c1.TabStop = false;
            // 
            // trackSelectBtn1c2
            // 
            this.trackSelectBtn1c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c2.Image")));
            this.trackSelectBtn1c2.Location = new System.Drawing.Point(992, 428);
            this.trackSelectBtn1c2.Name = "trackSelectBtn1c2";
            this.trackSelectBtn1c2.Size = new System.Drawing.Size(212, 150);
            this.trackSelectBtn1c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c2.TabIndex = 77;
            this.trackSelectBtn1c2.TabStop = false;
            // 
            // trackSelectBtn1c3
            // 
            this.trackSelectBtn1c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c3.Image")));
            this.trackSelectBtn1c3.Location = new System.Drawing.Point(1210, 428);
            this.trackSelectBtn1c3.Name = "trackSelectBtn1c3";
            this.trackSelectBtn1c3.Size = new System.Drawing.Size(212, 150);
            this.trackSelectBtn1c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c3.TabIndex = 78;
            this.trackSelectBtn1c3.TabStop = false;
            // 
            // trackSelectBtn1c4
            // 
            this.trackSelectBtn1c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn1c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn1c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn1c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn1c4.Image")));
            this.trackSelectBtn1c4.Location = new System.Drawing.Point(1428, 428);
            this.trackSelectBtn1c4.Name = "trackSelectBtn1c4";
            this.trackSelectBtn1c4.Size = new System.Drawing.Size(212, 150);
            this.trackSelectBtn1c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn1c4.TabIndex = 79;
            this.trackSelectBtn1c4.TabStop = false;
            // 
            // trackSelectBtn2c1
            // 
            this.trackSelectBtn2c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c1.Image")));
            this.trackSelectBtn2c1.Location = new System.Drawing.Point(774, 585);
            this.trackSelectBtn2c1.Name = "trackSelectBtn2c1";
            this.trackSelectBtn2c1.Size = new System.Drawing.Size(212, 150);
            this.trackSelectBtn2c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c1.TabIndex = 80;
            this.trackSelectBtn2c1.TabStop = false;
            // 
            // trackSelectBtn2c2
            // 
            this.trackSelectBtn2c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c2.Image")));
            this.trackSelectBtn2c2.Location = new System.Drawing.Point(992, 585);
            this.trackSelectBtn2c2.Name = "trackSelectBtn2c2";
            this.trackSelectBtn2c2.Size = new System.Drawing.Size(212, 150);
            this.trackSelectBtn2c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c2.TabIndex = 81;
            this.trackSelectBtn2c2.TabStop = false;
            // 
            // trackSelectBtn2c3
            // 
            this.trackSelectBtn2c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c3.Image")));
            this.trackSelectBtn2c3.Location = new System.Drawing.Point(1210, 585);
            this.trackSelectBtn2c3.Name = "trackSelectBtn2c3";
            this.trackSelectBtn2c3.Size = new System.Drawing.Size(212, 150);
            this.trackSelectBtn2c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c3.TabIndex = 82;
            this.trackSelectBtn2c3.TabStop = false;
            // 
            // trackSelectBtn2c4
            // 
            this.trackSelectBtn2c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn2c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn2c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn2c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn2c4.Image")));
            this.trackSelectBtn2c4.Location = new System.Drawing.Point(1428, 585);
            this.trackSelectBtn2c4.Name = "trackSelectBtn2c4";
            this.trackSelectBtn2c4.Size = new System.Drawing.Size(212, 150);
            this.trackSelectBtn2c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn2c4.TabIndex = 83;
            this.trackSelectBtn2c4.TabStop = false;
            // 
            // trackSelectBtn3c1
            // 
            this.trackSelectBtn3c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c1.BackgroundImage")));
            this.trackSelectBtn3c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c1.Image")));
            this.trackSelectBtn3c1.Location = new System.Drawing.Point(774, 741);
            this.trackSelectBtn3c1.Name = "trackSelectBtn3c1";
            this.trackSelectBtn3c1.Size = new System.Drawing.Size(212, 150);
            this.trackSelectBtn3c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c1.TabIndex = 84;
            this.trackSelectBtn3c1.TabStop = false;
            // 
            // trackSelectBtn3c2
            // 
            this.trackSelectBtn3c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c2.Image")));
            this.trackSelectBtn3c2.Location = new System.Drawing.Point(992, 741);
            this.trackSelectBtn3c2.Name = "trackSelectBtn3c2";
            this.trackSelectBtn3c2.Size = new System.Drawing.Size(212, 150);
            this.trackSelectBtn3c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c2.TabIndex = 85;
            this.trackSelectBtn3c2.TabStop = false;
            // 
            // trackSelectBtn3c3
            // 
            this.trackSelectBtn3c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c3.Image")));
            this.trackSelectBtn3c3.Location = new System.Drawing.Point(1210, 741);
            this.trackSelectBtn3c3.Name = "trackSelectBtn3c3";
            this.trackSelectBtn3c3.Size = new System.Drawing.Size(212, 150);
            this.trackSelectBtn3c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c3.TabIndex = 86;
            this.trackSelectBtn3c3.TabStop = false;
            // 
            // trackSelectBtn3c4
            // 
            this.trackSelectBtn3c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn3c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn3c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn3c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn3c4.Image")));
            this.trackSelectBtn3c4.Location = new System.Drawing.Point(1428, 741);
            this.trackSelectBtn3c4.Name = "trackSelectBtn3c4";
            this.trackSelectBtn3c4.Size = new System.Drawing.Size(212, 150);
            this.trackSelectBtn3c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn3c4.TabIndex = 87;
            this.trackSelectBtn3c4.TabStop = false;
            // 
            // trackSelectBtn4c1
            // 
            this.trackSelectBtn4c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c1.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c1.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c1.Image")));
            this.trackSelectBtn4c1.Location = new System.Drawing.Point(774, 896);
            this.trackSelectBtn4c1.Name = "trackSelectBtn4c1";
            this.trackSelectBtn4c1.Size = new System.Drawing.Size(212, 150);
            this.trackSelectBtn4c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c1.TabIndex = 88;
            this.trackSelectBtn4c1.TabStop = false;
            // 
            // trackSelectBtn4c2
            // 
            this.trackSelectBtn4c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c2.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c2.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c2.Image")));
            this.trackSelectBtn4c2.Location = new System.Drawing.Point(992, 896);
            this.trackSelectBtn4c2.Name = "trackSelectBtn4c2";
            this.trackSelectBtn4c2.Size = new System.Drawing.Size(212, 150);
            this.trackSelectBtn4c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c2.TabIndex = 89;
            this.trackSelectBtn4c2.TabStop = false;
            // 
            // trackSelectBtn4c3
            // 
            this.trackSelectBtn4c3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c3.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c3.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c3.Image")));
            this.trackSelectBtn4c3.Location = new System.Drawing.Point(1210, 896);
            this.trackSelectBtn4c3.Name = "trackSelectBtn4c3";
            this.trackSelectBtn4c3.Size = new System.Drawing.Size(212, 150);
            this.trackSelectBtn4c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c3.TabIndex = 90;
            this.trackSelectBtn4c3.TabStop = false;
            // 
            // trackSelectBtn4c4
            // 
            this.trackSelectBtn4c4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackSelectBtn4c4.BackColor = System.Drawing.Color.Transparent;
            this.trackSelectBtn4c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackSelectBtn4c4.Image = ((System.Drawing.Image)(resources.GetObject("trackSelectBtn4c4.Image")));
            this.trackSelectBtn4c4.Location = new System.Drawing.Point(1428, 896);
            this.trackSelectBtn4c4.Name = "trackSelectBtn4c4";
            this.trackSelectBtn4c4.Size = new System.Drawing.Size(212, 150);
            this.trackSelectBtn4c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackSelectBtn4c4.TabIndex = 91;
            this.trackSelectBtn4c4.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(426, -5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(1067, 427);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 116;
            this.pictureBoxLogo.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(970, 122);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(111, 61);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // GameVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pointsTeam4);
            this.Controls.Add(this.pointsTeam3);
            this.Controls.Add(this.pointsTeam2);
            this.Controls.Add(this.pointsTeam1);
            this.Controls.Add(this.pointsTeam5);
            this.Controls.Add(this.pointsTeam6);
            this.Controls.Add(this.pointsTeam12);
            this.Controls.Add(this.pointsTeam11);
            this.Controls.Add(this.pointsTeam10);
            this.Controls.Add(this.pointsTeam9);
            this.Controls.Add(this.pointsTeam8);
            this.Controls.Add(this.pointsTeam7);
            this.Controls.Add(this.teamNameTxt12);
            this.Controls.Add(this.teamNameTxt11);
            this.Controls.Add(this.teamNameTxt10);
            this.Controls.Add(this.teamNameTxt9);
            this.Controls.Add(this.teamNameTxt8);
            this.Controls.Add(this.teamNameTxt7);
            this.Controls.Add(this.teamNameTxt4);
            this.Controls.Add(this.teamNameTxt3);
            this.Controls.Add(this.teamNameTxt2);
            this.Controls.Add(this.teamNameTxt1);
            this.Controls.Add(this.teamNameTxt5);
            this.Controls.Add(this.teamNameTxt6);
            this.Controls.Add(this.trackSelectBtn4c4);
            this.Controls.Add(this.trackSelectBtn4c3);
            this.Controls.Add(this.trackSelectBtn4c2);
            this.Controls.Add(this.trackSelectBtn4c1);
            this.Controls.Add(this.trackSelectBtn3c4);
            this.Controls.Add(this.trackSelectBtn3c3);
            this.Controls.Add(this.trackSelectBtn3c2);
            this.Controls.Add(this.trackSelectBtn3c1);
            this.Controls.Add(this.trackSelectBtn2c4);
            this.Controls.Add(this.trackSelectBtn2c3);
            this.Controls.Add(this.trackSelectBtn2c2);
            this.Controls.Add(this.trackSelectBtn2c1);
            this.Controls.Add(this.trackSelectBtn1c4);
            this.Controls.Add(this.trackSelectBtn1c3);
            this.Controls.Add(this.trackSelectBtn1c2);
            this.Controls.Add(this.trackSelectBtn1c1);
            this.Controls.Add(this.categoryBtn4);
            this.Controls.Add(this.categoryBtn3);
            this.Controls.Add(this.categoryBtn2);
            this.Controls.Add(this.categoryBtn1);
            this.Controls.Add(this.pictureTeam4);
            this.Controls.Add(this.pictureTeam3);
            this.Controls.Add(this.pictureTeam2);
            this.Controls.Add(this.pictureTeam1);
            this.Controls.Add(this.pictureTeam5);
            this.Controls.Add(this.pictureTeam6);
            this.Controls.Add(this.pictureTeam12);
            this.Controls.Add(this.pictureTeam11);
            this.Controls.Add(this.pictureTeam10);
            this.Controls.Add(this.pictureTeam9);
            this.Controls.Add(this.pictureTeam8);
            this.Controls.Add(this.pictureTeam7);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameVision";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GameVision";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GameVision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBtn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn1c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn2c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn3c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSelectBtn4c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}
