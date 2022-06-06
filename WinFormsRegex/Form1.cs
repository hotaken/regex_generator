using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsRegex.dgvRichTextBox;
using System.IO;
using Newtonsoft.Json;
using System.Threading;
using System.Text.RegularExpressions;

namespace WinFormsRegex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDgvExamples();
            InitializeDgvTest();
        }
        private void InitializeDgvExamples()
        {
            dgvExamples.Rows.Clear();
            dgvExamples.Columns.Clear();
            dgvExamples.RowTemplate.Height = 60;
            var rowIdColumn = new DataGridViewTextBoxColumn
            {
                Name = "id",
                HeaderText = @"id",
            };
            var rowTextColumn = new DataGridViewRichTextBoxColumn
            {
                Name = "text",
                HeaderText = @"text",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            };
            //rowIdColumn.Width = rowIdColumn.GetPreferredWidth(DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader, true);
            dgvExamples.Columns.AddRange(rowIdColumn, rowTextColumn);

        }
        private void InitializeDgvTest()
        {
            dgvTest.Rows.Clear();
            dgvTest.Columns.Clear();
            dgvTest.RowTemplate.Height = 60;
            var rowIdColumn = new DataGridViewTextBoxColumn
            {
                Name = "id",
                HeaderText = @"id",
            };
            var rowTextColumn = new DataGridViewRichTextBoxTestColumn
            {
                Name = "text",
                HeaderText = @"text",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            };
            //rowIdColumn.Width = rowIdColumn.GetPreferredWidth(DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader, true);
            dgvTest.Columns.AddRange(rowIdColumn, rowTextColumn);
        }

        private string exampleFilePath = string.Empty;
        string[] exampleTextLines;
        public Dataset exampleDataset;
        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "txt file(*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    exampleFilePath = ofd.FileName;
                    exampleTextLines = File.ReadAllLines(exampleFilePath);
                    dgvExamples.Rows.Clear();
                    for (int i = 0; i < exampleTextLines.Length; i++)
                    {
                        dgvExamples.Rows.Add(i, exampleTextLines[i]);
                    }
                    exampleDataset = new Dataset(exampleTextLines.Length);
                }
            }
        }
        private string exampleJsonFilePath = string.Empty;
        private void открытьРазметкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "json file(*.json)|*.json";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    exampleJsonFilePath = ofd.FileName;
                    exampleDataset = new Dataset(exampleJsonFilePath);
                    for (int i = 0; i < dgvExamples.Rows.Count - 1; i++) // - 1 empty line
                    {
                        dgvExamples.CurrentCell = dgvExamples[1, i];
                        dgvExamples.BeginEdit(true);
                        var cell = (DataGridViewRichTextBoxEditingControl)dgvExamples.EditingControl;
                        for (int j = 0; j < exampleDataset.data[i].Count; j++)
                        {
                            var example = exampleDataset.data[i][j];
                            cell.Select(example.start, example.end - example.start + 1);
                            cell.SelectionBackColor = Color.Yellow;
                        }

                        dgvExamples.EndEdit();
                    }
                    
                }
            }
        }

        private void сохранитьРазметкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();
            

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "json file(*.json)|*.json";
            sfd.AddExtension = true;
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            Stream stream;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if ((stream = sfd.OpenFile())!=null)
                {
                    using (StreamWriter sw = new StreamWriter(stream))
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, exampleDataset.data);
                    }
                    stream.Close();
                }
            }
        }

        private void btnStartAlgo_Click(object sender, EventArgs e)
        {
            progressBarAlgo.Minimum = 0;
            progressBarAlgo.Maximum = (int)numericCountEpochs.Value;
            progressBarAlgo.Value = 0;
            progressBarAlgo.Step = 1;
            Genetic gen_algo = new Genetic(
                epochs: (int)numericCountEpochs.Value, // 100
                population_size: (int)numericCountPopulation.Value, //200
                elitism_count: (int)numericCountElitism.Value, //50
                random_count: (int)numericCountRandom.Value, // 50
                maxdepth: 10,
                train: exampleDataset,
                input: exampleFilePath);

            List<double> precisionList, fscoreList;

            var ts = new CancellationTokenSource();
            CancellationToken ct = ts.Token;
            Task[] tasks = new Task[1];
            tasks[0] = Task.Factory.StartNew(() =>
            {
                gen_algo.Eval("../../../phones/output.txt",
                progressBarAlgo,
                labelEpoch,
                labelPrecision,
                labelFscore,
                labelRegularExpression
                );
            }, ct);
            Task.Factory.ContinueWhenAll(tasks, completed =>
            {
                textBoxRegex.Invoke((MethodInvoker)delegate
                {
                    textBoxRegex.Text = labelRegularExpression.Text;
                });
            });
            //gen_algo.Eval("../../../phones/output.txt", 
            //    progressBarAlgo, 
            //    labelEpoch, 
            //    labelPrecision, 
            //    labelFscore, 
            //    labelRegularExpression
            //);
        }


        private string testFilePath = string.Empty;
        string[] testTextLines;
        private string testJsonFilePath = string.Empty;
        public Dataset testDataset;
        private void открытьДокументToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "txt file(*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    testFilePath = ofd.FileName;
                    testTextLines = File.ReadAllLines(testFilePath);
                    dgvTest.Rows.Clear();
                    for (int i = 0; i < testTextLines.Length; i++)
                    {
                        dgvTest.Rows.Add(i, testTextLines[i]);
                    }
                    testDataset = new Dataset(testTextLines.Length);
                }
            }
        }

        private void сохранитьРазметкуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();


            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "json file(*.json)|*.json";
            sfd.AddExtension = true;
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            Stream stream;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if ((stream = sfd.OpenFile()) != null)
                {
                    using (StreamWriter sw = new StreamWriter(stream))
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, testDataset.data);
                    }
                    stream.Close();
                }
            }
        }

        private void открытьРазметкуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "json file(*.json)|*.json";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    testJsonFilePath = ofd.FileName;
                    testDataset = new Dataset(testJsonFilePath);
                    for (int i = 0; i < dgvTest.Rows.Count - 1; i++) // - 1 empty line
                    {
                        dgvTest.CurrentCell = dgvTest[1, i];
                        dgvTest.BeginEdit(true);
                        var cell = (DataGridViewRichTextBoxTestEditingControl)dgvTest.EditingControl;
                        for (int j = 0; j < testDataset.data[i].Count; j++)
                        {
                            var example = testDataset.data[i][j];
                            cell.Select(example.start, example.end - example.start + 1);
                            cell.SelectionBackColor = Color.Yellow;
                        }

                        dgvTest.EndEdit();
                    }

                }
            }
        }

        private void разметитьДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string regex = textBoxRegex.Text;
            for (int i = 0; i < dgvTest.Rows.Count - 1; i++)
            {
                dgvTest.CurrentCell = dgvTest[1, i];
                dgvTest.BeginEdit(true);
                var cell = (DataGridViewRichTextBoxTestEditingControl)dgvTest.EditingControl;
                var text = cell.Text;

                try
                {
                    Match match = Regex.Match(text, regex, RegexOptions.Multiline, TimeSpan.FromSeconds(2));
                    while (match.Success)
                    {
                        var start = match.Index;
                        var end = match.Index + match.Length - 1;
                        var value = match.Value;

                        cell.Select(start, end - start + 1);
                        cell.SelectionBackColor = Color.Yellow;
                        testDataset.data[i].Add(new FoundData(start, end, value, ""));
                        match = match.NextMatch();
                    }
                }
                catch
                {
                    Console.WriteLine("regex error");
                    return;
                }

                dgvTest.EndEdit();
            }
            
        }
    }
}
