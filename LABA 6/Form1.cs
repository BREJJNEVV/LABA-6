using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public interface IDialogService
        {
            void ShowMessage(string message);   // показ сообщения
            string FilePath { get; set; }   // путь к выбранному файлу
            bool OpenFileDialog();  // открытие файла
            bool SaveFileDialog();  // сохранение файла
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            openFileDialog1.OpenFile();
        }
    }
}
