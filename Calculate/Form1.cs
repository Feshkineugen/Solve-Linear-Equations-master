using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Iterative
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        bool isHide = true;

        private void MainForm_Load(object sender, EventArgs e)
        {

            txbInput.Text = System.Environment.CurrentDirectory + "\\input";
            txbOutput.Text = System.Environment.CurrentDirectory + "\\output";
            this.Height = this.Height - 240;
            foreach (var item in Enum.GetValues(typeof(GlobalVar.CalcMethods)))
            {
                cmbMethod.Items.Add(item);
            }
            cmbMethod.SelectedIndex = 0;

        }



        private void label4_Click(object sender, EventArgs e)
        {
            if (!isHide)
            {
                this.Height = this.Height - 240;
                isHide = true;
                label4.Text = "          ︾          ";
            }
            else
            {
                this.Height = this.Height + 240;
                isHide = false;
                label4.Text = "          ︽          ";
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgOpenFolder = new FolderBrowserDialog();
            dlgOpenFolder.Description = "Выберите папку для расчета";
            dlgOpenFolder.RootFolder = Environment.SpecialFolder.MyComputer;
            dlgOpenFolder.SelectedPath = Environment.CurrentDirectory;
            dlgOpenFolder.ShowNewFolderButton = true;
            DialogResult result = dlgOpenFolder.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                txbInput.Text = dlgOpenFolder.SelectedPath;
                log("Выберите путь, по которому хранится файл системы уравнений：" + txbInput.Text, GlobalVar.LogType.Info);
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgOpenFolder = new FolderBrowserDialog();
            dlgOpenFolder.Description = "Выберите папку вывода результата";
            dlgOpenFolder.RootFolder = Environment.SpecialFolder.MyComputer;
            dlgOpenFolder.SelectedPath = Environment.CurrentDirectory;
            dlgOpenFolder.ShowNewFolderButton = true;
            DialogResult result = dlgOpenFolder.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                txbOutput.Text = dlgOpenFolder.SelectedPath;
                log("Выберите путь, по которому хранится выходной файл решения системы уравнений：" + txbInput.Text, GlobalVar.LogType.Info);
            }

        }



        private int CalcSolution(GlobalVar.CalcMethods method, List<double[]> d, double[] solution)
        {
            int status = 0;
            int t = 0;
            int IterativeTimes = Convert.ToInt32(txbIterativeTimes.Text);
            double Epsilon = Convert.ToDouble(txbEpsilon.Text);
            if (method == GlobalVar.CalcMethods.Jacobi)
            {
                try
                {
                    status = solveLinearEqu.Jacobi(d, IterativeTimes, Epsilon, out t, solution);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            if (method == GlobalVar.CalcMethods.SOR)
            {
                double omega = Convert.ToDouble(txbOmega.Text);
                try
                {
                    status = solveLinearEqu.SOR(d, IterativeTimes, Epsilon, omega, out t, solution);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            if (method == GlobalVar.CalcMethods.Gauss_Seidel)
            {
                try
                {
                    status = solveLinearEqu.Gauss_Seidel(d, IterativeTimes, Epsilon, out t, solution);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            if (status == 1)
                throw new Exception("Количество итераций превышено, решения нет！");
            return t;
        }

        private void btnCalc_Click_1(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thread = new Thread(new ThreadStart(Run));
            thread.Start();
        }

        private void Run()
        {
            DirectoryInfo TheFolder = new DirectoryInfo(txbInput.Text);
            if (!TheFolder.Exists)
            {
                log(TheFolder.FullName + " Путь не существует!", GlobalVar.LogType.Error);
                Framework.MessageBoxUtil.ShowError(TheFolder.FullName + " Путь не существует!");
                return;
            }
            FileInfo[] files = TheFolder.GetFiles("*.txt");
            if (files.Length == 0)
            {
                log("Ошибка: Соответствующий текстовый файл не существует в папке！", GlobalVar.LogType.Error);
                return;
            }
            foreach (FileInfo file in files)
            {
                if (!file.Exists)
                    log(file.Name + " Файл не существует!", GlobalVar.LogType.Error);
                List<double[]> d = null;
                try
                {
                    d = readData(file.FullName);
                    log("Чтение файла：" + file.Name, GlobalVar.LogType.Info);
                    log(displayEqu(d), GlobalVar.LogType.Info);
                }
                catch (Exception ex)
                {
                    log(ex);
                    continue;
                }
                double[] solution = new double[d.Count];
                try
                {
                    int t = CalcSolution((GlobalVar.CalcMethods)Enum.Parse(typeof(GlobalVar.CalcMethods), cmbMethod.SelectedItem.ToString()), d, solution);
                    string str = null;
                    //Сохраняйте четыре знака после запятой
                    for (int i = 0; i < solution.Length; i++)
                    {
                        solution[i] = Math.Round(solution[i], 4);
                        str += solution[i] + "\r\n";
                    }
                    str += "Итерационный метод：" + cmbMethod.SelectedItem.ToString() + "\r\n";
                    str += "Количество итераций：" + t;
                    string outFile = txbOutput.Text + "\\" + file.Name.Split('.')[0] + "_solution" + file.Extension;
                    Write(str, outFile);
                    log(displaySolution(solution), GlobalVar.LogType.Info);
                    log("Количество итераций：" + t, GlobalVar.LogType.Info);
                }
                catch (Exception ex)
                {
                    log(ex);
                }

            }
        }


        private List<double[]> readData(string filePath)
        {

            StreamReader sr = new StreamReader(filePath, Encoding.Default);
            int lineNum = Convert.ToInt32(sr.ReadLine());
            if (lineNum == 0) throw new Exception("Ошибка：" + filePath + "Файл пуст！");
            List<double[]> result = new List<double[]>();
            for (int i = 0; i < lineNum; i++)
            {
                string str = sr.ReadLine();
                if (str == null)
                    throw new Exception("Ошибка：" + filePath + "Файл неполный!");
                string[] strArr = str.Split(',');
                if (strArr.Length != lineNum + 1)
                    throw new Exception("Ошибка：" + filePath + "(Добавлено：" + (i + 2) + ") Неправильное количество параметров！");
                double[] c = new double[lineNum + 1];
                for (int j = 0; j < lineNum + 1; j++)
                {
                    if (!double.TryParse(strArr[j], out c[j]))
                        throw new Exception("Ошибка ：" + filePath + "(Добавлены：" + (i + 2) + ") Hедопустимые символы！");
                }
                result.Add(c);
            }
            if (result.Count != lineNum)
                throw new Exception("Ошибка ：" + filePath + "Во время чтения файла возникло неизвестное исключение！");
            return result;
        }

        private void Write(string data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //Начать писать
            sw.Write(data);
            //Очистить буфер
            sw.Flush();
            //Закрыть поток
            sw.Close();
            fs.Close();
        }

        private void txbIterativeTimes_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void txbEpsilon_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;

            //Обработка десятичных знаков.
            if ((int)e.KeyChar == 46)                          //Десятичная точка
            {
                if (txbEpsilon.Text.Length <= 0)
                    e.Handled = true;   //Десятичная точка не может быть на первом месте
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(txbEpsilon.Text, out oldf);
                    b2 = float.TryParse(txbEpsilon.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void txbOmega_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;


            if ((int)e.KeyChar == 46)
            {
                if (txbOmega.Text.Length <= 0)
                    e.Handled = true;
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(txbOmega.Text, out oldf);
                    b2 = float.TryParse(txbOmega.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void log(Exception ex)
        {
            Framework.Logger.Error(ex);
            rtxbLog.SelectionColor = Color.Red;
            rtxbLog.AppendText("- - Error " + DateTime.Now.ToString() + " - -\r\n" + ex.Message.ToString() + "\r\n\r\n");
            rtxbLog.Select(rtxbLog.TextLength, 0);
            rtxbLog.ScrollToCaret();

        }
        private void log(string mess, GlobalVar.LogType type)
        {
            if (type == GlobalVar.LogType.Error)
            {
                Framework.Logger.Error(mess);
                rtxbLog.SelectionColor = Color.Red;
                rtxbLog.AppendText("- - Error " + DateTime.Now.ToString() + " - -\r\n" + mess + "\r\n\r\n");
                rtxbLog.Select(rtxbLog.TextLength, 0);
                rtxbLog.ScrollToCaret();
            }
            if (type == GlobalVar.LogType.Info)
            {
                Framework.Logger.Info(mess);
                rtxbLog.AppendText("- -  Info " + DateTime.Now.ToString() + " - -\r\n" + mess + "\r\n\r\n");
                rtxbLog.Select(rtxbLog.TextLength, 0);
                rtxbLog.ScrollToCaret();
            }
            if (type == GlobalVar.LogType.Warn)
            {
                Framework.Logger.Warn(mess);
                rtxbLog.AppendText("- -  Warn " + DateTime.Now.ToString() + " - -\r\n" + mess + "\r\n\r\n");
                rtxbLog.Select(rtxbLog.TextLength, 0);
                rtxbLog.ScrollToCaret();
            }
        }

        private string displayEqu(List<double[]> d)
        {
            string result = "Решение уравнения сводится к：\r\n";
            for (int i = 0; i < d.Count; i++)
            {
                double[] equ = d[i];
                result += (equ[0] == 1) ? "X0" : equ[0] + "X0";
                for (int j = 1; j < equ.Length - 1; j++)
                {
                    if (equ[j] < 0) result += equ[j] + "X" + j;
                    else if (equ[j] == 0) break;
                    else if (equ[j] == 1) result += "+X" + j;
                    else result += "+" + equ[j] + "X" + j;
                }
                result += "=" + equ[equ.Length - 1] + "\r\n";
            }
            return result;
        }
        private string displaySolution(double[] solution)
        {
            string result = "Решение системы уравнений：\r\n";
            for (int i = 0; i < solution.Length; i++)
            {
                result += "X" + i + "=" + solution[i] + "\r\n";
            }
            return result;
        }

        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMethod.SelectedItem.ToString() == GlobalVar.CalcMethods.SOR.ToString())
            {
                labOmega.Enabled = true;
                txbOmega.Enabled = true;
            }
            else
            {
                labOmega.Enabled = false;
                txbOmega.Enabled = false;
            }
        }

        private void OpenInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnInput_Click(sender, e);
        }

        private void OpenOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOutput_Click(sender, e);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Пожалуйста, подтвердите, нужно ли выходить из системы?", "Выход из системы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }






        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labOmega_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rtxbLog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
