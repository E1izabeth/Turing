using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace turing
{
    public partial class MainForm : Form
    {
        private string _alphabet = "S012";

        public struct Cell
        {
            public string value;
            public int index;

            public Cell(string value, int index)
            {
                this.value = value;
                this.index = index;
            }
        }

        private const int _columnSize = 30;
        private const int _beginTapeIndex = -5;        

        public List<Cell> item = new List<Cell>();
        protected int _head = 0;
        protected int _begn = _beginTapeIndex;
        protected string _emp = "S";
        protected int _globalCond = 1;
        protected int _condsCount = 4;
        
        public MainForm()
        {
            InitializeComponent();
        }

        

        public void LentaPrint(int begin, int head)
        {
            tape.ColumnCount = tape.Width / _columnSize;
            tape.RowCount = 2;
            int konc = begin + tape.ColumnCount;
            for (int i = 0; i < tape.ColumnCount; i++)
            {                               
                tape.Columns[i].Width = _columnSize;
                tape.Rows[0].Cells[i].ReadOnly = true;         
                tape.Rows[0].Cells[i].Value = begin + i;
                tape.Rows[0].Cells[i].Style.BackColor = Color.MintCream;               
                tape.Rows[1].Cells[i].Style.BackColor = Color.White;

                if ((begin + i) == head)
                {
                    tape.Rows[0].Cells[i].Style.BackColor = Color.CadetBlue;
                    tape.Rows[1].Cells[i].Style.BackColor = Color.CadetBlue;
                }

                var simb = GetValue(begin + i);
                if (simb != null)
                    tape.Rows[1].Cells[i].Value = simb;
                else
                {
                    AddData ("S", begin + i);
                    tape.Rows[1].Cells[i].Value = "S";
                }
            }

            for (int i = 0; i < tape.Rows.Count; i++)
                tape.Rows[i].Height = tape.Height / 2 - 2;

        }

        public void ProgramPrint()
        {
            Program.ColumnCount = _alphabet.Length;
            var col = Program.ColumnCount;
            Program.RowCount = _condsCount;

            int colSize = (Program.Width - Program.RowHeadersWidth-2) / col;
            int rowSize = (Program.Height - Program.ColumnHeadersHeight-2) / _condsCount;

            for (int i = 0; i < Program.Columns.Count; i++)
            {
                Program.Columns[i].HeaderText = _alphabet[i].ToString();
                Program.Columns[i].Width = colSize;
                Program.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;


            }

            
            for (int i = 0; i < Program.Rows.Count; i++)
            {
                Program.Rows[i].HeaderCell.Value = "q" + (i+1);
                Program.Rows[i].Height = rowSize;
            }
                
        }

        protected void MainFormLoad(object sender, EventArgs e)
        {
            ProgramPrint();
            LentaPrint(_begn, _head);
            ClearLog_Click(null, null);
        }

        private void TapeResize(object sender, EventArgs e)
        {
            LentaPrint(_begn, _head);
        }

        private void ProgramResize(object sender, EventArgs e)
        {
            ProgramPrint();
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            _head++;
            _begn++;
            tape.ClearSelection();
            LentaPrint(_begn, _head);
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            _head--;
            _begn--;
            tape.ClearSelection();
            LentaPrint(_begn, _head);
        }

        private void ProgramCell_ValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = Program.CurrentCell.RowIndex;
            int y = Program.CurrentCell.ColumnIndex;

            var cell = Program.Rows[x].Cells[y];                
            var cValue = (string)cell.Value;
                if (cValue == null) return;
            
            if (!(cValue.Length == 0 || cValue.Length == 4))
                { cell.Value = ""; return; }   

        }

        private void TapeCell_ValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x != 1) return;
            int y = e.ColumnIndex;

            var cell = tape.Rows[x].Cells[y];
            var cValue = (string)cell.Value;

            if (cValue == null) cValue = "S";
            if (cValue.Length > 1) cell.Value = "S";
                else
                if (!_alphabet.Contains(cValue)) cell.Value = "S";

            AddData (cValue, _begn + y);
        }

        public void AddData(string value, int index)
        {

            int memInd = -1;
            for (int i = 0; i < item.Count - 1; i++)
                if (item[i].index == index)
                {
                    memInd = i;
                    break;
                }

            if (memInd > -1 && item[memInd].value != value)
                item[memInd] = new Cell(value, index); 
            else
                item.Add(new Cell(value, index));
        }

        public string GetValue(int index)
        {
            foreach (var i in item)
             if (i.index == index)
               return i.value;

            return null;
        }
        
        private void ByStep_Click(object sender, EventArgs e)
        {
            tape.Enabled = false;
            Program.Enabled = false;
            subCol.Enabled = false;
            addRow.Enabled = false;
            SubQ.Enabled = false;
            AddQ.Enabled = false;
            Step();           
        }

        public void PrintLog(string comand)
        {
            String text = numCmd.Text + ") [" + comand + "] ";
            if (Int32.Parse(numCmd.Text) < 10) text = " " + text;
            for (int i = _head - 5; i < _head + 7; i++)
            {
                if (i == _head) text += $"[{GetValue(i)}]";
                    else text += GetValue(i);
            }        
            log.Items.Add (text);
            LogReview();
        }

        void LogReview()
        {
            int visibleItems = log.ClientSize.Height / log.ItemHeight;
            var padding = 3;
            var atEnd = log.TopIndex >= Math.Max(log.Items.Count - visibleItems - padding, 0);
            if (atEnd)
                log.TopIndex = Math.Max(log.Items.Count - visibleItems, 0);
        }

        private void ClearLog_Click(object sender, EventArgs e)
        {
            log.Items.Clear();
            log.Items.Add("log :");
        }

        public bool Step()
        {
            if (_globalCond == 0)
            {
                _globalCond = 1;
                tape.Enabled = true;
                Program.Enabled = true;
                subCol.Enabled = true;
                addRow.Enabled = true;
                SubQ.Enabled = true;
                AddQ.Enabled = true;
                log.Items.Add("--- Программа завершена(Q0)--- ");
                numCmd.Text = "0";
                return false;
            }

            var cVl = GetValue(_head)[0];
            int indSim = _alphabet.IndexOf(cVl);

            if (indSim < 0)
            {
                _globalCond = 1;
                tape.Enabled = true;
                Program.Enabled = true;
                subCol.Enabled = true;
                addRow.Enabled = true;
                SubQ.Enabled = true;
                AddQ.Enabled = true;
                log.Items.Add("--- Некорректный ввод--- ");
                numCmd.Text = "0";
                return false;
            }

            var comand = (string)Program[indSim, _globalCond-1].Value;

            Program.CurrentCell = Program[indSim, _globalCond - 1];

            if (comand == null)
            {
                tape.Enabled = true;
                Program.Enabled = true;
                subCol.Enabled = true;
                addRow.Enabled = true;
                SubQ.Enabled = true;
                AddQ.Enabled = true;
                log.Items.Add("Отсутствует команда!");
                return false;
            }

            if (!ParseComand(comand, out int cond, out string simb, out string move))
            {
                tape.Enabled = true;
                Program.Enabled = true;
                subCol.Enabled = true;
                addRow.Enabled = true;
                SubQ.Enabled = true;
                AddQ.Enabled = true;
                log.Items.Add("Неизвестная команда!");
                return false; 
            }
            else
            {
                AddData(simb, _head);
                if (move == "R" || move == ">") ButtonRight_Click(null, null);
                if (move == "L" || move == "<") ButtonLeft_Click(null, null);
                _globalCond = cond;
            }

            numCmd.Text = (Int32.Parse(numCmd.Text)+1).ToString();
            PrintLog(comand);
            return true;
        }

        public bool ParseComand(string comand, out int cond, out string simb, out string move)
        {
            cond = 0; simb = ""; move = "";

            if (comand.Length != 4) return false;

            if (!(comand[0] == 'q' || comand[0] == 'Q')) return false;

            var condsString = comand[1].ToString();
                if (!int.TryParse(condsString, out cond) || cond > _condsCount)
                    return false;

            simb = comand[2].ToString();
                if (!_alphabet.Contains(simb))
                    return false;
            
            move = "RCLrcl";
                if (!move.Contains(comand[3]))
                    return false;
                else move = comand[3].ToString();

            return true;       
        }

        private void ToEnd_Click(object sender, EventArgs e)
        {
            tape.Enabled = false;
            Program.Enabled = false;
            subCol.Enabled = false;
            addRow.Enabled = false;
            SubQ.Enabled = false;
            AddQ.Enabled = false;
            //numCmd.Text = "0";
            bool check;
            do
            {
                check = Step();                                
            } while (Int32.Parse(numCmd.Text) <= maxCmd.Value - 1 && check && check == true);

            if (numCmd.Text == maxCmd.Value.ToString())
            {
                tape.Enabled = true;
                Program.Enabled = true;
                subCol.Enabled = true;
                addRow.Enabled = true;
                SubQ.Enabled = true;
                AddQ.Enabled = true;
                log.Items.Add("Выполнено запланированное");
                log.Items.Add("количество команд!");
            }
            else
            if (check)
            {
                tape.Enabled = true;
                Program.Enabled = true;
                subCol.Enabled = true;
                addRow.Enabled = true;
                SubQ.Enabled = true;
                AddQ.Enabled = true;
                //log.Items.Add("---Программа завершена (Q0)---");
            }

            numCmd.Text = "0";
        }

        private void Test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _globalCond = 1;
            _head = 0;
            _begn = -5;
            _condsCount = 3;
            _alphabet = "S012";

            item.Clear();
            AddData("0", 0);
            AddData("0", 1);
            AddData("1", 2);
            AddData("1", 3);
            AddData("2", 4);
            AddData("2", 5);
            AddData("1", 6);
            AddData("1", 7);
            AddData("0", 8);

            MainFormLoad(null, null);
            Program[0, 0].Value = "q01L";
            Program[1, 0].Value = "q31R";
            Program[2, 0].Value = "q12R";
            Program[3, 0].Value = "q30R";
            Program[0, 1].Value = "q02C";
            Program[1, 1].Value = "q22R";
            Program[2, 1].Value = "q10R";
            Program[3, 1].Value = "q21R";
            Program[0, 2].Value = "q00R";
            Program[1, 2].Value = "q22L";
            Program[2, 2].Value = "q32C";
            Program[3, 2].Value = "q12L";
            ProgramResize(null, null);
            numCmd.Text = "0";
        }

        private void Test2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _globalCond = 1;
            _head = 0;
            _begn = -5;
            _condsCount = 3;
            _alphabet = "S012";

            item.Clear();
            AddData("0", 0);
            AddData("1", 1);
            AddData("2", 2);
            AddData("0", 3);
            AddData("1", 4);
            AddData("2", 5);
            AddData("0", 6);
            AddData("1", 7);
            AddData("2", 8);

            MainFormLoad(null, null);

            Program[0, 0].Value = "q01L";
            Program[1, 0].Value = "q31R";
            Program[2, 0].Value = "q12R";
            Program[3, 0].Value = "q30R";
            Program[0, 1].Value = "q02C";
            Program[1, 1].Value = "q22R";
            Program[2, 1].Value = "q10R";
            Program[3, 1].Value = "q21R";
            Program[0, 2].Value = "q00R";
            Program[1, 2].Value = "q22L";
            Program[2, 2].Value = "q32C";
            Program[3, 2].Value = "q12L";
            numCmd.Text = "0";

        }

        private void Test3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _globalCond = 1;
            _head = 0;
            _begn = -5;
            _condsCount = 3;
            _alphabet = "S012";

            item.Clear();
            AddData("0", 0);
            AddData("0", 1);
            AddData("1", 2);
            AddData("1", 3);
            AddData("2", 4);
            AddData("2", 5);
            AddData("1", 6);
            AddData("1", 7);
            AddData("0", 8);

            MainFormLoad(null, null);

            Program[0, 0].Value = "q01L";
            Program[1, 0].Value = "q31R";
            Program[2, 0].Value = "q12R";
            Program[3, 0].Value = "q30R";
            Program[0, 1].Value = "q22C";
            Program[1, 1].Value = "q22R";
            Program[2, 1].Value = "q10R";
            Program[3, 1].Value = "q21R";
            Program[0, 2].Value = "q00R";
            Program[1, 2].Value = "q22L";
            Program[2, 2].Value = "q32C";
            Program[3, 2].Value = "q12L";
            numCmd.Text = "0";
        }

        private void Test4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _globalCond = 1;
            _head = 0;
            _begn = -5;
            _condsCount = 3;
            _alphabet = "S012";

            item.Clear();
            AddData("0", 0);
            AddData("0", 1);
            AddData("1", 2);
            AddData("1", 3);
            AddData("2", 4);
            AddData("2", 5);
            AddData("1", 6);
            AddData("1", 7);
            AddData("0", 8);

            MainFormLoad(null, null);

            Program[0, 0].Value = "q01L";
            Program[1, 0].Value = "q31R";
            Program[2, 0].Value = "q12R";
            Program[3, 0].Value = "q30R";
            Program[0, 1].Value = "q20L";
            Program[1, 1].Value = "q22R";
            Program[2, 1].Value = "q10R";
            Program[3, 1].Value = "q21R";
            Program[0, 2].Value = "q00R";
            Program[1, 2].Value = "q22L";
            Program[2, 2].Value = "q32C";
            Program[3, 2].Value = "q12L";
            numCmd.Text = "0";
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CleanLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearLog_Click(null, null);
        }
        
        private void AddQ_Click(object sender, EventArgs e)
        {
            if (_condsCount < 6)
            {
                this._condsCount++;
                ProgramPrint();
            }
             
        }

        private void SubQ_Click(object sender, EventArgs e)
        {
            if (_condsCount > 2)
            {
                this._condsCount--;
                ProgramPrint();
            }               
        }

        private void MaxCmd_ValueChanged(object sender, EventArgs e)
        {
            if (maxCmd.Value <= Int32.Parse(numCmd.Text))
                numCmd.Text = (maxCmd.Value - 1).ToString();
        }

        private void NumCmd_ValueChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(numCmd.Text) >= maxCmd.Value)
                maxCmd.Value = Int32.Parse(numCmd.Text) + 1;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            _globalCond = 1;
            _head = 0;
            _begn = -5;
            _condsCount = 3;
            numCmd.Text = "0";
            item.Clear();
            AddData("0", 0);
            AddData("0", 1);
            AddData("1", 2);
            AddData("1", 3);
            AddData("2", 4);
            AddData("2", 5);
            AddData("1", 6);
            AddData("1", 7);
            AddData("0", 8);

            OpenFileDialog dlg = new OpenFileDialog {
                FileName = "",
                DefaultExt = ".txt",
                Multiselect = false,
                Title = "Load ",
                InitialDirectory = @"D:\",
                Filter = "Text files (.txt)|*.txt"
            };
            if (dlg.ShowDialog() == DialogResult.OK ? true : false)
            {
                string filename = dlg.FileName;
                var lines = File.ReadAllLines(filename);
                var length = lines.Count();
                while (lines.ElementAt(length - 1) == "") { --length; }
                _alphabet = lines[0];
                var tape = lines[1].Split(' ');
                for (int i = 0; i < tape.Length; i++)
                {
                    AddData(tape[i], i);
                }

                _condsCount = length - 2;
                Program.RowCount = _condsCount;
                Program.ColumnCount = _alphabet.Length;
                for (int i = 2; i < length; i++)
                {
                    var arr = lines[i].Split(' ');
                    for (int j = 0; j < arr.Length; j++)
                    {
                        Program[j, i - 2].Value = arr[j];
                    }
                }
                MainFormLoad(null, null);
            }
        }

        private void SubCol_Click(object sender, EventArgs e)
        {
            if (_alphabet.Length > 2)
            {
                _alphabet = _alphabet.Remove(_alphabet.Length - 1);
                ProgramPrint();
            }
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            if (_alphabet == "S")
            {
                _alphabet = "S1";
            }
            else if (_alphabet.Length < 6)
            {
                _alphabet = $"{_alphabet}{Int32.Parse(_alphabet.ElementAt(_alphabet.Length - 1).ToString()) + 1}";
            }
            ProgramPrint();
        }
    }
}
