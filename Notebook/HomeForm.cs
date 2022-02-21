using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
    }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Smile and use my notebook","My Notebook");
        }

        bool tbChange = false; //Переменная-индикатор, которая будет сообщать о том, что в документе произошли какие-либо изменения.
                               //Она потребуется для того, чтобы программа понимала, когда можно просто очистить элемент notebox,
                               //а когда нужно сперва предложить сохранить изменения в документе.
        
        string docPath = ""; //Переменная, в которую будем записывать путь открытого документа.

        private void notebox_TextChanged(object sender, EventArgs e)
        {
            tbChange = true; //если текст документа будет как-то изменяться, наша переменная-индикатор изменит свое значение на True
        }


        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед созданием нового?", "Создание документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.CreateFile(ref notebox, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.CreateFile(ref notebox, ref tbChange, ref docPath);
                    }
                }
                else if (message == DialogResult.No)
                {
                    FileWork.CreateFile(ref notebox, ref tbChange, ref docPath);
                }
            }
            else
            {
                FileWork.CreateFile(ref notebox, ref tbChange, ref docPath);
            }

        }

        private void новоеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед открытием нового?", "Открытие документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
                    }
                }
                else if (message == DialogResult.No)
                {
                    FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
                }
                else
                {
                    return;
                }
            }
            else
            {
                FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (docPath != "")
            {
                FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
            }
            else
            {
                FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument.Print();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка параметров печати.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();          
        }
    }
}
