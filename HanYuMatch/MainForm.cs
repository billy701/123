using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanYuMatch
{
    public partial class MainForm : Form
    {
        private string Path = @"D:\HanYu\HanYuMatch.txt";
        private TimeSpan Time;
        private Graphics gra;
        
        public MainForm()
        {
            InitializeComponent();
            Timer1.Tick += Time_Tick;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.GetData();
            int a = CenterPanel.Width;
            int b = CenterPanel.Height;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.White, 0, ButtonBorderStyle.None, Color.Black, 0, ButtonBorderStyle.None, Color.Black, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid);
            ControlPaint.DrawBorder(this.panel2.CreateGraphics(), this.panel2.ClientRectangle, Color.LightGray, 1, ButtonBorderStyle.Solid, Color.Black, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.None);
            ControlPaint.DrawBorder(this.panel3.CreateGraphics(), this.panel3.ClientRectangle, Color.LightGray, 1, ButtonBorderStyle.Solid, Color.LightGray, 1, ButtonBorderStyle.Solid, Color.Black, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid);
            ControlPaint.DrawBorder(this.panel4.CreateGraphics(), this.panel4.ClientRectangle, Color.LightGray, 1, ButtonBorderStyle.Solid, Color.Black, 0, ButtonBorderStyle.None, Color.Black, 0, ButtonBorderStyle.None, Color.LightGray, 1, ButtonBorderStyle.Solid);
            ControlPaint.DrawBorder(this.panel5.CreateGraphics(), this.panel5.ClientRectangle, Color.LightGray, 1, ButtonBorderStyle.Solid, Color.Black, 0, ButtonBorderStyle.None, Color.Black, 1, ButtonBorderStyle.None, Color.Black, 1, ButtonBorderStyle.None);
            ControlPaint.DrawBorder(this.CenterPanel.CreateGraphics(), this.CenterPanel.ClientRectangle, Color.LightGray, 1, ButtonBorderStyle.Solid, Color.LightGray, 1, ButtonBorderStyle.Solid, Color.LightGray, 1, ButtonBorderStyle.Solid, Color.LightGray, 1, ButtonBorderStyle.Solid);
        }
        /// <summary>
        /// 设置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetButton_Click(object sender, EventArgs e)
        {
            var Frm = new SetIntiial();
            Frm.SaveEvent += UpdateData;
            Frm.ShowDialog();
        }
        private void UpdateData(Set entity)
        {
            if (entity != null)
            {
                Title.Text = entity.Title;
                textBox1.Text = entity.Count.ToString();
                TimeShow.Text = entity.Time.ToString();
                this.Time = entity.Time;
            }

        }
        private void GetData()
        {
            using(var stream =new FileStream(Path,FileMode.OpenOrCreate))
            {
                if (stream.Length!=0)
                {
                    BinaryFormatter fm = new BinaryFormatter();
                    var entity = fm.Deserialize(stream) as Set;
                    stream.Close();
                    this.UpdateData(entity);
                }
            }
        }

        private void Sumbit_Btn_Click(object sender, EventArgs e)
        {
            Timer1.Start();
        }
        void Time_Tick(object sender, EventArgs e)
        {
            TimeShow.Text = (this.Time-=new TimeSpan(0, 0, 1)).ToString();
        }
        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {
            Square.PaintSquare(this.CenterPanel, e.Graphics);
        }
    }
}
