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
    public partial class ResultsVision : Form
    {
        public ResultsVision(List<Team> tmList)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();
            tableLayoutPanel1.BackgroundImage = Image.FromFile(@"media/interface/result.png");
            this.BackgroundImage = Image.FromFile(@"media/interface/stage.jpg");
            updateResult(tmList);
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\media\interface\stage.jpg");
        }



        void updateResult(List<Team> tmList)
        {
            tableLayoutPanel1.RowStyles.Clear();

            Screen[] sc;
            sc = Screen.AllScreens;
            int height;
            if (sc.Length > 1)
            {
                height = sc[1].Bounds.Size.Height;
            }
            else
            {
                MessageBox.Show("Второй монитор не найден!");
                return;
            }


            Label zaglushka = new Label();
            zaglushka.Text = " ";
            zaglushka.Font = new System.Drawing.Font("Arial Narrow", height / 32, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zaglushka.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            zaglushka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            zaglushka.AutoSize = true;
            zaglushka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            tableLayoutPanel1.Controls.Add(zaglushka, 0, 0);
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowCount++;

            Label textplace = new Label();
            textplace.Text = "Место";
            textplace.Font = new System.Drawing.Font("Arial Narrow", height / 32, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textplace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            textplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            textplace.AutoSize = true;
            textplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            Label textname = new Label();
            textname.Text = "Имя игрока";
            textname.Font = new System.Drawing.Font("Arial Narrow", height / 32, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            textname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            textname.AutoSize = true;
            textname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            Label textpoints = new Label();
            textpoints.Text = "Баллы";
            textpoints.Font = new System.Drawing.Font("Arial Narrow", height / 32, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textpoints.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            textpoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            textpoints.AutoSize = true;
            textpoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            tableLayoutPanel1.Controls.Add(textplace, 0, 1);
            tableLayoutPanel1.Controls.Add(textname, 1, 1);
            tableLayoutPanel1.Controls.Add(textpoints, 2, 1);
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowCount++;


            for (int i = 0; i < tmList.Count; i++)
            {
                Label place = new Label();
                place.Text = (i + 1).ToString();
                place.Font = new System.Drawing.Font("Arial Narrow", height / 32, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                place.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                place.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
                place.AutoSize = true;
                place.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


                Label name = new Label();
                name.Text = tmList[i].teamName;
                name.Font = new System.Drawing.Font("Arial Narrow", height / 32, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
                name.AutoSize = true;
                name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                Label points = new Label();
                points.Text = tmList[i].teamPoints.ToString();
                points.Font = new System.Drawing.Font("Arial Narrow", height / 32, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                points.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                points.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
                points.AutoSize = true;
                points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                //fontsize текущая высота height/32

                // (int)(tableLayoutPanel1.Height * 0.9 / tmList.Count);


                tableLayoutPanel1.Controls.Add(place, 0, i + 2);
                tableLayoutPanel1.Controls.Add(name, 1, i + 2);
                tableLayoutPanel1.Controls.Add(points, 2, i + 2);
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));

                tableLayoutPanel1.RowCount++;
                if (i == tmList.Count - 1)
                {
                    Label zaglushka2 = new Label();
                    zaglushka2.Text = " ";
                    zaglushka2.Font = new System.Drawing.Font("Arial Narrow", height / 32, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    zaglushka2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                    zaglushka2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
                    zaglushka2.AutoSize = true;
                    zaglushka2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    tableLayoutPanel1.Controls.Add(zaglushka, 0, i+3);
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                }

            }

            //tableLayoutPanel1.RowStyles[0].SizeType = SizeType.AutoSize;
            //tableLayoutPanel1.RowStyles[0].Height = tableLayoutPanel1.Height / (tmList.Count-1);

            for (int i = 0; i < tableLayoutPanel1.RowStyles.Count; i++)
            {
                tableLayoutPanel1.RowStyles[i].SizeType = SizeType.Percent;
                tableLayoutPanel1.RowStyles[i].Height = 100 / tableLayoutPanel1.RowStyles.Count;
            }

        }
    
    }
}
