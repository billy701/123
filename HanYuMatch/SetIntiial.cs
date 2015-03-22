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
    public partial class SetIntiial : Form
    {
        private string Path = @"D:\HanYu\HanYuMatch.txt";
        public delegate void Save(Set entity);
        public event Save SaveEvent;
        public SetIntiial()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
         }

        private void SetIntiial_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal; 
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            var entity = new Set
            {
                Count = Convert.ToInt32(Count.Text),
                Time = new TimeSpan(Time.Value.Hour,Time.Value.Minute,Time.Value.Second),
                Title = Title.Text
            };
            using (var Stream = new FileStream(Path,FileMode.OpenOrCreate))
            {
                BinaryFormatter fm = new BinaryFormatter();
                fm.Serialize(Stream, entity);
                Stream.Flush();
                Stream.Close();
            }
            if(SaveEvent!=null)
            SaveEvent(entity);
            this.Close();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
