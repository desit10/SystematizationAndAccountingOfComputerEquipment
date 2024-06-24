using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace SystematizationAndAccountingOfComputerEquipment.Controls
{
    public partial class ControlFile : UserControl
    {
        private string filePath { get; set; }

        public ControlFile(string title, string filePath)
        {
            InitializeComponent();

            this.filePath = filePath;

            labelTitle.Text = title;
                                   
            toolTip.SetToolTip(pictureBox, "Нажмите ЛКМ для открытия  файла, ПКМ для удаления файла.");
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    Process.Start(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при открытии файла:\n" + ex.Message, "Ошибка");
                }
            }

            if (e.Button == MouseButtons.Right)
            {               
                if (MessageBox.Show("Удалить файл?", "Удаление файла", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Parent.Controls.Remove(this);
                    File.Delete(filePath);
                }             
            }

        }       
    }
}
