using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MCFunction_Compressor
{
    public partial class MainForm : Form
    {
        private Point mousePoint;

        string defaultCommand = "summon minecraft:falling_block ~ ~2 ~ {Motion:[0.0, 0.1, 0.0],BlockState:{Name:\"minecraft:stone\",Time:1,DropItem:false},Passengers:[{id:\"minecraft:snowball\",Passengers:[{id:\"minecraft:snowball\",Passengers:[{id:\"minecraft:falling_block\",BlockState:{Name:\"minecraft:stone\"},Time:1,DropItem:false%Command%}]}]}]}";
        string tempCommand = ",Passengers:[{id:\"minecraft:snowball\",Passengers:[{id:\"minecraft:snowball\",Passengers:[{id:\"minecraft:falling_block\",BlockState:{Name:\"minecraft:%CommandBlockType%command_block\",Properties:{facing:down}},Time:1,DropItem:false,TileEntityData:{auto:%Auto%,Command:\"%Command%\"}%NextCommand%}]}]}]";

        public MainForm()
        {
            InitializeComponent();
        }

        private void labelMinimize_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                double opacity = 1.00;
                while (opacity > 0)
                {
                    Opacity = opacity;
                    opacity -= 0.32;
                    System.Threading.Thread.Sleep(1);
                }
                WindowState = FormWindowState.Minimized;
                Opacity = 1.0;
            }
        }

        private void labelMinimize_MouseEnter(object sender, EventArgs e)
        {
            labelMinimize.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void labelMinimize_MouseLeave(object sender, EventArgs e)
        {
            labelMinimize.BackColor = Color.Transparent;
        }

        private void labelExit_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.BackColor = Color.Transparent;
        }

        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private void labelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Left += e.X - mousePoint.X;
                Top += e.Y - mousePoint.Y;
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ".mcfunctionファイル(*.mcfunction)|*.mcfunction";
            dialog.Title = "開く";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                labelURI.Text = dialog.FileName;
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (labelURI.Text != "")
            {
                try
                {
                    string line = "";
                    ArrayList al = new ArrayList();

                    using (StreamReader sr = new StreamReader(labelURI.Text))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith("#"))
                            {
                                al.Add(line);
                            }
                        }
                    }

                    al.Reverse();
                    line = defaultCommand.Replace("%Command%", tempCommand.Replace("%CommandBlockType%", checkBoxAutoRemove.Checked ? "" : "chain_").Replace("%Auto%", "0b").Replace("%Command%", "fill ~ ~-1 ~ ~ ~" + al.Count + " ~ air"));
                    for (int a = 0; a < al.Count; a++)
                    {
                        if ((a + 1) == al.Count)
                        {
                            string auto = checkBox.Checked ? "1b" : "0b";
                            string type = comboBox.Text == "インパルス" ? "" : "repeating_";
                            line = line.Replace("%NextCommand%", tempCommand.Replace("%Command%", (string)al[a]).Replace("%Auto%", auto).Replace("%CommandBlockType%", type));
                        } else
                        {
                            line = line.Replace("%NextCommand%", tempCommand.Replace("%Command%", (string)al[a]).Replace("%Auto%", "1b").Replace("%CommandBlockType%", "chain_"));
                        }
                    }
                    textBoxResult.Text = line.Replace("%NextCommand%", "");
                }
                catch (Exception) {}
            }
        }

        private void buttonClipBoard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxResult.Text);
        }
    }
}
