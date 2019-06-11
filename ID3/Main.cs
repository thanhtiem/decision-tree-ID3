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

namespace ID3
{
    public partial class Main : Form
    {
        List<Attribute> Attributes = new List<Attribute>();
        DecisionTreeID3 DTID3;
        List<List<string>> Examples = new List<List<string>>();
        int Height, Width = 0;

        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }



        private void btnnew_Click(object sender, EventArgs e)
        {
            rtxresult.Clear();
            dgvmain.Columns.Clear();
            btnRun.Enabled = false;
            Attributes.Clear();
            Width = 0;
            Bitmap imageDelete = new Bitmap(pbxpaint.Width, pbxpaint.Height);
            pbxpaint.Image = imageDelete;
        }

        private void btnlearn_Click(object sender, EventArgs e)
        {
            Examples.Clear();
            for (int i = 0; i < dgvmain.Rows.Count - 1; i++)
            {
                List<string> example = new List<string>();
                for (int j = 0; j < dgvmain.Columns.Count; j++)
                {
                    example.Add(dgvmain.Rows[i].Cells[j].Value.ToString().ToLower());
                }
                Examples.Add(example);
            }
            List<Attribute> at = new List<Attribute>();
            for (int i = 0; i < Attributes.Count; i++)
            {
                at.Add(Attributes[i]);
            }
            DTID3 = new DecisionTreeID3(Examples, at);
            DTID3.GetTree();
            Height = DTID3.Depth * 200;
            Width = DTID3.Tree.NumberLabel * 100;
            pbxpaint.Invalidate();
            rtxresult.Text = DTID3.Solution;
        }

        private void cbxc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pbxpaint_Paint(object sender, PaintEventArgs e)
        {
            if (Width > 0)
            {
                pbxpaint.Width = Width;
                pbxpaint.Height = Height;
                PaintTree(DTID3.Tree, e, 0, 50);
            }

        }

        private void PaintTree(TreeNode tree, PaintEventArgs e, int X, int Y)
        {

            int XStart = X;
            X = (tree.NumberLabel * 100 + 2 * X) / 2 - 50;
            if (tree.Attributes.Name.ToString() != "")
            {
                e.Graphics.FillRectangle(Brushes.Blue, X, Y, tree.Attributes.Name.Length * 15, 30);
                e.Graphics.DrawString(tree.Attributes.Name.ToString(), new Font("Arial", 20), Brushes.Red, new PointF(X, Y));
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Green, X + 25, Y, tree.Attributes.Label.Length * 20, 30);
                e.Graphics.DrawString(tree.Attributes.Label, new Font("Arial", 20), Brushes.Yellow, new PointF(X + 25, Y));
            }
            int XEndA;
            for (int i = 0; i < tree.Attributes.Value.Count; i++)
            {
                XEndA = tree.Childs[i].NumberLabel * 100 + XStart;
                int XA = (XStart + XEndA) / 2 - 50;
                e.Graphics.DrawLine(new Pen(Brushes.Black, 2), X + 50, Y + 30, XA + 50, Y + 100);
                e.Graphics.DrawString(tree.Attributes.Value[i].ToString(), new Font("Arial", 20), Brushes.Blue, new PointF(XA, Y + 100));
                e.Graphics.DrawLine(new Pen(Brushes.Black, 2), XA + 50, Y + 130, XA + 50, Y + 200);
                PaintTree(tree.Childs[i], e, XStart, Y + 200);
                XStart = XEndA;
            }
        }

        private void btnloaddata_Click(object sender, EventArgs e)
        {
            dgvmain.Columns.Clear();
            rtxresult.Clear();
            Attributes.Clear();
            OpenFileDialog OpenDiag = new OpenFileDialog();
            OpenDiag.InitialDirectory = Application.StartupPath;
            OpenDiag.DefaultExt = ".txt";
            OpenDiag.Filter = "Text documents (.txt)|*.txt";
            if (OpenDiag.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(OpenDiag.FileName);
                string line = "";
                if ((line = sr.ReadLine()) != null)
                {
                    string[] attributeName = line.Trim().ToLower().Split('\t').ToArray();

                    for (int i = 0; i < attributeName.Length - 1; i++)
                    {
                        Attribute temp = new Attribute();
                        temp.Name = attributeName[i];
                        Attributes.Add(temp);
                        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                        column.HeaderText = attributeName[i].ToUpper();
                        column.Name = attributeName[i].ToUpper();
                        dgvmain.Columns.Add(column);
                    }
                    DataGridViewTextBoxColumn columnend = new DataGridViewTextBoxColumn();
                    columnend.HeaderText = attributeName[attributeName.Length - 1].ToUpper();
                    columnend.Name = attributeName[attributeName.Length - 1].ToUpper();
                    dgvmain.Columns.Add(columnend);

                    btnRun.Enabled = true;
                }
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    string[] value = line.Trim().ToLower().Split('\t').ToArray();

                    DataGridViewRow dgvr = new DataGridViewRow();
                    for (int i = 0; i < value.Length - 1; i++)
                    {
                        Attributes[i].AddValue(value[i]);
                    }
                    string[] value2 = line.Trim().ToUpper().Split('\t').ToArray();
                    dgvmain.Rows.Add(value);
                }
                sr.Close();
            }
        }

        private void ID3_Load(object sender, EventArgs e)
        {
            btnRun.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
            frm.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
