using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
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

namespace StartEnd
{
    public partial class Form1 : Form
    {
        List<Subtitle> subtitles = new List<Subtitle>();
        TimeSpan StartTime = new TimeSpan();
        TimeSpan EndTime = new TimeSpan();
        public Form1()
        {
            InitializeComponent();
        }

        #region Pro
        void UpdateTime(object sender)
        {
            int x = Convert.ToInt32(((Button)sender).Text);
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += TimeSpan.FromSeconds(x).TotalSeconds;

            lbl_Time.Text = TimeSpan.FromSeconds(axWindowsMediaPlayer1.Ctlcontrols.currentPosition).ToString();
        }
        string Reformat(string txt)
        {
            txt = txt.Replace("<font face=\"comic sans ms\">", "");
            txt = txt.Replace("</font>", "");
            txt = txt.Replace("<i>", "");
            txt = txt.Replace("</i>", "");
            txt = txt.Replace("- ", " ");
            txt = txt.Replace("?", "");
            txt = txt.Replace("!", "");
            txt = txt.Replace(", ", " ");
            txt = txt.Replace(".", "");
            txt = txt.Replace("<i>", "");
            txt = txt.Replace("</i>", "");
            txt = txt.Replace("-", "");
            txt = txt.Replace(" '", " ");

            return txt;
        }
        void FillSubtitles(string text)
        {
            text = text.ToLower();
            text = Reformat(text);

            string[] MovieContentList = text.Split(new[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.None);

            subtitles.Clear();
            foreach (var subtitle in MovieContentList)
            {
                if (subtitle.Trim() == "") continue;
                string[] line = subtitle.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                string[] time = line[1].Split(' ');
                string txt = line[2] + ((line.Length > 3) ? " " + line[3] : "");

                try
                {
                    subtitles.Add(new Subtitle
                    {
                        Index = line[0],
                        Text = txt,
                        StartTime = TimeSpan.Parse(time[0].Replace(",", ".")).ToString(),
                        EndtTime = TimeSpan.Parse(time[2].Replace(",", ".")).ToString()
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("FillSubtitles Error");
                }

            }
        }
        async Task CutClip(DataGridViewRow dr)
        {
            System.IO.Directory.CreateDirectory(@"D:\Clips\" + txt_Search.Text.Trim() + @"\");

            using (var engine = new Engine())
            {
                var inputFile = new MediaFile { Filename = dr.Cells["col_Movie"].Value.ToString() };
                engine.GetMetadata(inputFile);
                var outputName = @$"D:\Clips\{txt_Search.Text.Trim()}\";
                var outputExtension = ".mp4";
                
                double startTime = TimeSpan.Parse(dr.Cells["col_StartTime"].Value.ToString()).TotalMilliseconds;
                double duration = TimeSpan.Parse(dr.Cells["col_EndTime"].Value.ToString()).TotalMilliseconds - startTime;

                var options = new ConversionOptions();
                var outputFile = new MediaFile(outputName + dr.Cells["col_Cat"].Value.ToString() + "_" + dr.Cells["col_Text"].Value.ToString() + "_" + Guid.NewGuid() + outputExtension);

                options.CutMedia(TimeSpan.FromMilliseconds(startTime), TimeSpan.FromMilliseconds(duration));
                engine.Convert(inputFile, outputFile, options);

                MessageBox.Show("Finished");
            }
        }
        #endregion
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lst_Start.Items.Count - lst_End.Items.Count == 1)
                {
                    lst_End.Items.Add(lbl_Time.Text);
                }
                else if (lst_Start.Items.Count == lst_End.Items.Count)
                {
                    lst_End.Items[lst_End.Items.Count - 1] = lbl_Time.Text;
                }

                lst_End.SelectedIndex = lst_End.Items.Count - 1;
            }
            else if (e.KeyCode == Keys.Space)
            {
                if(lst_Start.Items.Count == lst_End.Items.Count)
                {
                    lst_Start.Items.Add(lbl_Time.Text);
                }
                else if (lst_Start.Items.Count - lst_End.Items.Count == 1)
                {
                    lst_Start.Items[lst_Start.Items.Count-1]=lbl_Time.Text;
                }
                lst_Start.SelectedIndex = lst_Start.Items.Count - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = TimeSpan.FromSeconds(axWindowsMediaPlayer1.Ctlcontrols.currentPosition).ToString();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            lbl_Time.Text = TimeSpan.FromSeconds(axWindowsMediaPlayer1.Ctlcontrols.currentPosition).ToString();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if(btn_Play.Text == "Play")
            {
                btn_Play.Text = "Pause";
                timer1.Start();
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                btn_Play.Text = "Play";
                timer1.Stop();
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
        }

        private void btn_Add1_Click(object sender, EventArgs e)
        {
            UpdateTime(sender);
        }

        private void btn_Add5_Click(object sender, EventArgs e)
        {
            UpdateTime(sender);
        }

        private void btn_Sub1_Click(object sender, EventArgs e)
        {
            UpdateTime(sender);
        }

        private void btn_Sub5_Click(object sender, EventArgs e)
        {
            UpdateTime(sender);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateTime(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateTime(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateTime(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateTime(sender);
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            using (var engine = new Engine())
            {
                openFileDialog.ShowDialog();
                string file = openFileDialog.FileName;
                var inputFile = new MediaFile { Filename = file };
                engine.GetMetadata(inputFile);
                var outputName = @"D:\output\";
                var outputExtension = ".mp4";
                double Duration = 0;
                double currentPosition = 0;

                int xx = 1;
                for (int i = 0; i < lst_Start.Items.Count; i++)
                {
                    currentPosition = TimeSpan.Parse(lst_Start.Items[i].ToString()).TotalSeconds;
                    Duration = TimeSpan.Parse(lst_End.Items[i].ToString()).TotalSeconds - currentPosition;

                    var options = new ConversionOptions();
                    var outputFile = new MediaFile(outputName + (xx).ToString("0000") + outputExtension);
                    xx++;

                    options.CutMedia(TimeSpan.FromSeconds(currentPosition), TimeSpan.FromSeconds(Duration));

                    engine.Convert(inputFile, outputFile, options);

                    lst_Start.Items.RemoveAt(i);
                    lst_End.Items.RemoveAt(i);
                    i--;
                }

                MessageBox.Show("Finished");
            }
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            axWindowsMediaPlayer1.URL = openFileDialog.FileName;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lst_Start.Items.Clear();
            lst_End.Items.Clear();
        }

        private void btn_SetSubtitles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            string text = File.ReadAllText(openFileDialog.FileName);
            text = text.ToLower();
            text = Reformat(text);

            string[] MovieContentList = text.Split(new[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.None);

            subtitles.Clear();
            foreach (var subtitle in MovieContentList)
            {
                if (subtitle.Trim() == "") continue;
                string[] line = subtitle.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                string[] time = line[1].Split(' ');
                string txt = line[2] + ((line.Length > 3) ? " " + line[3] : "");

                subtitles.Add(new Subtitle
                {
                    Index = line[0],
                    Text = txt,
                    StartTime = TimeSpan.Parse(time[0].Replace(",", ".")).ToString(),
                    EndtTime = TimeSpan.Parse(time[2].Replace(",", ".")).ToString()
                });
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (subtitles.Count > 0)
            {
                var ss = subtitles.FirstOrDefault(x =>
                TimeSpan.Parse(x.StartTime).TotalSeconds <= axWindowsMediaPlayer1.Ctlcontrols.currentPosition &&
                TimeSpan.Parse(x.EndtTime).TotalSeconds > axWindowsMediaPlayer1.Ctlcontrols.currentPosition);

                lbl_Subtitle.Text = (ss != null)? ss.Text : string.Empty;
                if(axWindowsMediaPlayer1.Ctlcontrols.currentPosition > EndTime.TotalSeconds) axWindowsMediaPlayer1.Ctlcontrols.currentPosition = StartTime.TotalSeconds;
            }
        }

        private void btn_MoveSubtitles_Click(object sender, EventArgs e)
        {
            foreach (var subtitle in subtitles)
            {
                lst_Start.Items.Add(subtitle.StartTime);
                lst_End.Items.Add(subtitle.EndtTime);
            }
        }

        private void btn_Compress_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.ShowDialog();
            //string fileName = openFileDialog.FileName;

            string[] files = { };
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    files = Directory.GetFiles(fbd.SelectedPath);
                    MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }

            foreach (var file in files)
            {
                var inputFile = new MediaFile { Filename = file };
                var outputFile = new MediaFile { Filename = @$"D:\output2\{Path.GetFileName(file)}" };

                var conversionOptions = new ConversionOptions
                {
                    VideoAspectRatio = VideoAspectRatio.R16_10,
                    VideoSize = VideoSize.Cga,
                    AudioSampleRate = AudioSampleRate.Hz22050
                };

                lbl_CompressCount.Text = $"{Array.IndexOf(files, file)+1}/{files.Length}";

                using (var engine = new Engine())
                {
                    engine.Convert(inputFile, outputFile, conversionOptions);
                }
            }  
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgv_SearchResult.Rows.Clear();
            string[] filesindirectory = Directory.GetDirectories("D:\\Movies");
            foreach (var path in filesindirectory)
            {
                DirectoryInfo d = new DirectoryInfo(path);

                foreach (var file in d.GetFiles("*.srt"))
                {
                    string text = File.ReadAllText(file.FullName);
                    text = text.ToLower();
                    text = Reformat(text);

                    string[] MovieContentList = text.Split(new[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.None);

                    foreach (var subtitle in MovieContentList)
                    {
                        if (subtitle.Trim() == "") continue;

                        string[] line = subtitle.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                        string[] time = line[1].Split(' ');
                        string txt = line[2] + ((line.Length > 3) ? " " + line[3] : "");

                        if (txt.Contains(txt_Search.Text.Trim()))
                        {
                            string movie = d.GetFiles("*.mp4").FirstOrDefault().FullName;
                            dgv_SearchResult.Rows.Add
                                (movie, file.FullName, txt, 
                                "-1000", "-100", time[0].Replace(",", "."), "+100", "+1000", 
                                "-1000", "-100", time[2].Replace("," , "."), "+100", "+1000", 
                                "Delete", "Watch", 1, "Cut");
                        }
                    }
                }
            }
            lbl_ResultCount.Text = dgv_SearchResult.RowCount.ToString();
        }

        private void dgv_SearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dgv_SearchResult.CurrentCell;

            if (cell.OwningColumn.Name == "col_Watch")
            {
                if (axWindowsMediaPlayer1.URL == dgv_SearchResult.Rows[cell.RowIndex].Cells["col_Movie"].Value.ToString())
                {
                    axWindowsMediaPlayer1.Ctlcontrols.currentPosition = TimeSpan.Parse(dgv_SearchResult.Rows[cell.RowIndex].Cells["col_StartTime"].Value.ToString()).TotalSeconds;
                    StartTime = TimeSpan.Parse(dgv_SearchResult.Rows[cell.RowIndex].Cells["col_StartTime"].Value.ToString());
                    EndTime = TimeSpan.Parse(dgv_SearchResult.Rows[cell.RowIndex].Cells["col_EndTime"].Value.ToString());
                    return;
                }
                lbl_Movie.Text = dgv_SearchResult.Rows[cell.RowIndex].Cells["col_Movie"].Value.ToString();
                axWindowsMediaPlayer1.URL = dgv_SearchResult.Rows[cell.RowIndex].Cells["col_Movie"].Value.ToString();
                btn_Play_Click(null, null);
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = TimeSpan.Parse(dgv_SearchResult.Rows[cell.RowIndex].Cells["col_StartTime"].Value.ToString()).TotalSeconds;
                string txt = File.ReadAllText(dgv_SearchResult.Rows[cell.RowIndex].Cells["col_Subtitles"].Value.ToString());
                FillSubtitles(txt);
            }
            else if(cell.OwningColumn.Name == "col_StartMin100")
            {
                dgv_SearchResult.Rows[cell.RowIndex].Cells["col_StartTime"].Value = TimeSpan.Parse(dgv_SearchResult.Rows[cell.RowIndex].Cells["col_StartTime"].Value.ToString()) - TimeSpan.FromMilliseconds(100);
            }
            else if (cell.OwningColumn.Name == "col_StartMin1000")
            {
                dgv_SearchResult.Rows[cell.RowIndex].Cells["col_StartTime"].Value = TimeSpan.Parse(dgv_SearchResult.Rows[cell.RowIndex].Cells["col_StartTime"].Value.ToString()) - TimeSpan.FromMilliseconds(1000);
            }
            else if (cell.OwningColumn.Name == "col_StartAdd100")
            {
                dgv_SearchResult.Rows[cell.RowIndex].Cells["col_StartTime"].Value = TimeSpan.Parse(dgv_SearchResult.Rows[cell.RowIndex].Cells["col_StartTime"].Value.ToString()) + TimeSpan.FromMilliseconds(100);
            }
            else if (cell.OwningColumn.Name == "col_StartAdd1000")
            {
                dgv_SearchResult.Rows[cell.RowIndex].Cells["col_StartTime"].Value = TimeSpan.Parse(dgv_SearchResult.Rows[cell.RowIndex].Cells["col_StartTime"].Value.ToString()) + TimeSpan.FromMilliseconds(1000);
            }
            else if (cell.OwningColumn.Name == "col_EndMin100")
            {
                dgv_SearchResult.Rows[cell.RowIndex].Cells["col_EndTime"].Value = TimeSpan.Parse(dgv_SearchResult.Rows[cell.RowIndex].Cells["col_EndTime"].Value.ToString()) - TimeSpan.FromMilliseconds(100);
            }
            else if (cell.OwningColumn.Name == "col_EndMin1000")
            {
                dgv_SearchResult.Rows[cell.RowIndex].Cells["col_EndTime"].Value = TimeSpan.Parse(dgv_SearchResult.Rows[cell.RowIndex].Cells["col_EndTime"].Value.ToString()) - TimeSpan.FromMilliseconds(1000);
            }
            else if (cell.OwningColumn.Name == "col_EndAdd100")
            {
                dgv_SearchResult.Rows[cell.RowIndex].Cells["col_EndTime"].Value = TimeSpan.Parse(dgv_SearchResult.Rows[cell.RowIndex].Cells["col_EndTime"].Value.ToString()) + TimeSpan.FromMilliseconds(100);
            }
            else if (cell.OwningColumn.Name == "col_EndAdd1000")
            {
                dgv_SearchResult.Rows[cell.RowIndex].Cells["col_EndTime"].Value = TimeSpan.Parse(dgv_SearchResult.Rows[cell.RowIndex].Cells["col_EndTime"].Value.ToString()) + TimeSpan.FromMilliseconds(1000);
            }
            else if (cell.OwningColumn.Name == "col_Delete")
            {
                dgv_SearchResult.Rows.RemoveAt(cell.RowIndex);
                lbl_ResultCount.Text = dgv_SearchResult.RowCount.ToString();
            }
            if (cell.OwningColumn.Name == "col_Cut")
            {
                CutClip(dgv_SearchResult.CurrentRow);
                dgv_SearchResult.Rows.RemoveAt(cell.RowIndex);
                lbl_ResultCount.Text = dgv_SearchResult.RowCount.ToString();
            }
            if (cell.RowIndex != -1)
            {
                StartTime = TimeSpan.Parse(dgv_SearchResult.Rows[cell.RowIndex].Cells["col_StartTime"].Value.ToString());
                EndTime = TimeSpan.Parse(dgv_SearchResult.Rows[cell.RowIndex].Cells["col_EndTime"].Value.ToString());
            }
        }
    }
}
