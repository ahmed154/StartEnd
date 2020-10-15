namespace StartEnd
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Play = new System.Windows.Forms.Button();
            this.lst_Start = new System.Windows.Forms.ListBox();
            this.lst_End = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Add1 = new System.Windows.Forms.Button();
            this.btn_Add5 = new System.Windows.Forms.Button();
            this.btn_Sub1 = new System.Windows.Forms.Button();
            this.btn_Sub5 = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_Set = new System.Windows.Forms.Button();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_SetSubtitles = new System.Windows.Forms.Button();
            this.lbl_Subtitle = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btn_MoveSubtitles = new System.Windows.Forms.Button();
            this.btn_Compress = new System.Windows.Forms.Button();
            this.lbl_CompressCount = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_SearchResult = new System.Windows.Forms.DataGridView();
            this.lbl_ResultCount = new System.Windows.Forms.Label();
            this.lbl_Movie = new System.Windows.Forms.Label();
            this.col_Movie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Subtitles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StartMin1000 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_StartMin100 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StartAdd100 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_StartAdd1000 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_EndMin1000 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_EndMin100 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_EndAdd100 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_EndAdd1000 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_Watch = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Cut = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(177, 85);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(50, 23);
            this.btn_Play.TabIndex = 1;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // lst_Start
            // 
            this.lst_Start.FormattingEnabled = true;
            this.lst_Start.Location = new System.Drawing.Point(12, 366);
            this.lst_Start.Name = "lst_Start";
            this.lst_Start.Size = new System.Drawing.Size(172, 147);
            this.lst_Start.TabIndex = 2;
            // 
            // lst_End
            // 
            this.lst_End.FormattingEnabled = true;
            this.lst_End.Location = new System.Drawing.Point(190, 366);
            this.lst_End.Name = "lst_End";
            this.lst_End.Size = new System.Drawing.Size(172, 147);
            this.lst_End.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(123, 85);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(50, 23);
            this.btn_Stop.TabIndex = 4;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Add1
            // 
            this.btn_Add1.Location = new System.Drawing.Point(276, 66);
            this.btn_Add1.Name = "btn_Add1";
            this.btn_Add1.Size = new System.Drawing.Size(40, 40);
            this.btn_Add1.TabIndex = 5;
            this.btn_Add1.Text = "+1";
            this.btn_Add1.UseVisualStyleBackColor = true;
            this.btn_Add1.Click += new System.EventHandler(this.btn_Add1_Click);
            // 
            // btn_Add5
            // 
            this.btn_Add5.Location = new System.Drawing.Point(322, 66);
            this.btn_Add5.Name = "btn_Add5";
            this.btn_Add5.Size = new System.Drawing.Size(40, 40);
            this.btn_Add5.TabIndex = 6;
            this.btn_Add5.Text = "+5";
            this.btn_Add5.UseVisualStyleBackColor = true;
            this.btn_Add5.Click += new System.EventHandler(this.btn_Add5_Click);
            // 
            // btn_Sub1
            // 
            this.btn_Sub1.Location = new System.Drawing.Point(58, 66);
            this.btn_Sub1.Name = "btn_Sub1";
            this.btn_Sub1.Size = new System.Drawing.Size(40, 40);
            this.btn_Sub1.TabIndex = 7;
            this.btn_Sub1.Text = "-1";
            this.btn_Sub1.UseVisualStyleBackColor = true;
            this.btn_Sub1.Click += new System.EventHandler(this.btn_Sub1_Click);
            // 
            // btn_Sub5
            // 
            this.btn_Sub5.Location = new System.Drawing.Point(12, 66);
            this.btn_Sub5.Name = "btn_Sub5";
            this.btn_Sub5.Size = new System.Drawing.Size(40, 40);
            this.btn_Sub5.TabIndex = 8;
            this.btn_Sub5.Text = "-5";
            this.btn_Sub5.UseVisualStyleBackColor = true;
            this.btn_Sub5.Click += new System.EventHandler(this.btn_Sub5_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(396, 129);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(119, 23);
            this.btn_Run.TabIndex = 9;
            this.btn_Run.Text = "Devide All Movie";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "+20";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "+60";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(58, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 12;
            this.button3.Text = "-20";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 13;
            this.button4.Text = "-60";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(813, 32);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(675, 427);
            this.axWindowsMediaPlayer1.TabIndex = 14;
            // 
            // btn_Set
            // 
            this.btn_Set.Location = new System.Drawing.Point(440, 19);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(75, 23);
            this.btn_Set.TabIndex = 15;
            this.btn_Set.Text = "Set";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
            // 
            // lbl_Time
            // 
            this.lbl_Time.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbl_Time.Location = new System.Drawing.Point(12, 19);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(350, 33);
            this.lbl_Time.TabIndex = 0;
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(152, 129);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_SetSubtitles
            // 
            this.btn_SetSubtitles.Location = new System.Drawing.Point(440, 48);
            this.btn_SetSubtitles.Name = "btn_SetSubtitles";
            this.btn_SetSubtitles.Size = new System.Drawing.Size(75, 23);
            this.btn_SetSubtitles.TabIndex = 17;
            this.btn_SetSubtitles.Text = "Set Subtitles";
            this.btn_SetSubtitles.UseVisualStyleBackColor = true;
            this.btn_SetSubtitles.Click += new System.EventHandler(this.btn_SetSubtitles_Click);
            // 
            // lbl_Subtitle
            // 
            this.lbl_Subtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Subtitle.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbl_Subtitle.Location = new System.Drawing.Point(813, 462);
            this.lbl_Subtitle.Name = "lbl_Subtitle";
            this.lbl_Subtitle.Size = new System.Drawing.Size(675, 75);
            this.lbl_Subtitle.TabIndex = 18;
            this.lbl_Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btn_MoveSubtitles
            // 
            this.btn_MoveSubtitles.Location = new System.Drawing.Point(440, 77);
            this.btn_MoveSubtitles.Name = "btn_MoveSubtitles";
            this.btn_MoveSubtitles.Size = new System.Drawing.Size(75, 23);
            this.btn_MoveSubtitles.TabIndex = 19;
            this.btn_MoveSubtitles.Text = "<- Subtitles";
            this.btn_MoveSubtitles.UseVisualStyleBackColor = true;
            this.btn_MoveSubtitles.Click += new System.EventHandler(this.btn_MoveSubtitles_Click);
            // 
            // btn_Compress
            // 
            this.btn_Compress.Location = new System.Drawing.Point(396, 158);
            this.btn_Compress.Name = "btn_Compress";
            this.btn_Compress.Size = new System.Drawing.Size(119, 23);
            this.btn_Compress.TabIndex = 20;
            this.btn_Compress.Text = "Compress";
            this.btn_Compress.UseVisualStyleBackColor = true;
            this.btn_Compress.Click += new System.EventHandler(this.btn_Compress_Click);
            // 
            // lbl_CompressCount
            // 
            this.lbl_CompressCount.Location = new System.Drawing.Point(375, 184);
            this.lbl_CompressCount.Name = "lbl_CompressCount";
            this.lbl_CompressCount.Size = new System.Drawing.Size(78, 23);
            this.lbl_CompressCount.TabIndex = 21;
            this.lbl_CompressCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(12, 161);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(264, 20);
            this.txt_Search.TabIndex = 22;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(287, 159);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 23;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_SearchResult
            // 
            this.dgv_SearchResult.AllowUserToAddRows = false;
            this.dgv_SearchResult.AllowUserToDeleteRows = false;
            this.dgv_SearchResult.AllowUserToResizeRows = false;
            this.dgv_SearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Movie,
            this.col_Subtitles,
            this.col_Text,
            this.col_StartMin1000,
            this.col_StartMin100,
            this.col_StartTime,
            this.col_StartAdd100,
            this.col_StartAdd1000,
            this.col_EndMin1000,
            this.col_EndMin100,
            this.col_EndTime,
            this.col_EndAdd100,
            this.col_EndAdd1000,
            this.col_Delete,
            this.col_Watch,
            this.col_Cat,
            this.col_Cut});
            this.dgv_SearchResult.Location = new System.Drawing.Point(13, 188);
            this.dgv_SearchResult.MultiSelect = false;
            this.dgv_SearchResult.Name = "dgv_SearchResult";
            this.dgv_SearchResult.RowHeadersVisible = false;
            this.dgv_SearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SearchResult.Size = new System.Drawing.Size(795, 173);
            this.dgv_SearchResult.TabIndex = 24;
            this.dgv_SearchResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SearchResult_CellClick);
            // 
            // lbl_ResultCount
            // 
            this.lbl_ResultCount.AutoSize = true;
            this.lbl_ResultCount.Location = new System.Drawing.Point(739, 169);
            this.lbl_ResultCount.Name = "lbl_ResultCount";
            this.lbl_ResultCount.Size = new System.Drawing.Size(69, 13);
            this.lbl_ResultCount.TabIndex = 25;
            this.lbl_ResultCount.Text = "Result Count";
            // 
            // lbl_Movie
            // 
            this.lbl_Movie.AutoSize = true;
            this.lbl_Movie.Location = new System.Drawing.Point(816, 16);
            this.lbl_Movie.Name = "lbl_Movie";
            this.lbl_Movie.Size = new System.Drawing.Size(35, 13);
            this.lbl_Movie.TabIndex = 26;
            this.lbl_Movie.Text = "Movie";
            // 
            // col_Movie
            // 
            this.col_Movie.HeaderText = "Movie";
            this.col_Movie.Name = "col_Movie";
            this.col_Movie.Visible = false;
            // 
            // col_Subtitles
            // 
            this.col_Subtitles.HeaderText = "Subtitles";
            this.col_Subtitles.Name = "col_Subtitles";
            this.col_Subtitles.Visible = false;
            // 
            // col_Text
            // 
            this.col_Text.HeaderText = "Text";
            this.col_Text.Name = "col_Text";
            this.col_Text.Visible = false;
            // 
            // col_StartMin1000
            // 
            this.col_StartMin1000.HeaderText = "-1000";
            this.col_StartMin1000.Name = "col_StartMin1000";
            this.col_StartMin1000.Text = "-1000";
            this.col_StartMin1000.Width = 50;
            // 
            // col_StartMin100
            // 
            this.col_StartMin100.HeaderText = "-100";
            this.col_StartMin100.Name = "col_StartMin100";
            this.col_StartMin100.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_StartMin100.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_StartMin100.Text = "-100";
            this.col_StartMin100.Width = 50;
            // 
            // col_StartTime
            // 
            this.col_StartTime.HeaderText = "Start";
            this.col_StartTime.Name = "col_StartTime";
            this.col_StartTime.Width = 70;
            // 
            // col_StartAdd100
            // 
            this.col_StartAdd100.HeaderText = "+100";
            this.col_StartAdd100.Name = "col_StartAdd100";
            this.col_StartAdd100.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_StartAdd100.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_StartAdd100.Text = "+100";
            this.col_StartAdd100.Width = 50;
            // 
            // col_StartAdd1000
            // 
            this.col_StartAdd1000.HeaderText = "+1000";
            this.col_StartAdd1000.Name = "col_StartAdd1000";
            this.col_StartAdd1000.Text = "+1000";
            this.col_StartAdd1000.Width = 50;
            // 
            // col_EndMin1000
            // 
            this.col_EndMin1000.HeaderText = "-1000";
            this.col_EndMin1000.Name = "col_EndMin1000";
            this.col_EndMin1000.Width = 50;
            // 
            // col_EndMin100
            // 
            this.col_EndMin100.HeaderText = "-100";
            this.col_EndMin100.Name = "col_EndMin100";
            this.col_EndMin100.Width = 50;
            // 
            // col_EndTime
            // 
            this.col_EndTime.HeaderText = "End";
            this.col_EndTime.Name = "col_EndTime";
            this.col_EndTime.Width = 70;
            // 
            // col_EndAdd100
            // 
            this.col_EndAdd100.HeaderText = "+100";
            this.col_EndAdd100.Name = "col_EndAdd100";
            this.col_EndAdd100.Width = 50;
            // 
            // col_EndAdd1000
            // 
            this.col_EndAdd1000.HeaderText = "+1000";
            this.col_EndAdd1000.Name = "col_EndAdd1000";
            this.col_EndAdd1000.Width = 50;
            // 
            // col_Delete
            // 
            this.col_Delete.HeaderText = "Delete";
            this.col_Delete.Name = "col_Delete";
            this.col_Delete.Width = 50;
            // 
            // col_Watch
            // 
            this.col_Watch.HeaderText = "Watch";
            this.col_Watch.Name = "col_Watch";
            this.col_Watch.Width = 50;
            // 
            // col_Cat
            // 
            this.col_Cat.HeaderText = "Cat";
            this.col_Cat.Name = "col_Cat";
            this.col_Cat.Width = 50;
            // 
            // col_Cut
            // 
            this.col_Cut.HeaderText = "Cut";
            this.col_Cut.Name = "col_Cut";
            this.col_Cut.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 546);
            this.Controls.Add(this.lbl_Movie);
            this.Controls.Add(this.lbl_ResultCount);
            this.Controls.Add(this.dgv_SearchResult);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.lbl_CompressCount);
            this.Controls.Add(this.btn_Compress);
            this.Controls.Add(this.btn_MoveSubtitles);
            this.Controls.Add(this.lbl_Subtitle);
            this.Controls.Add(this.btn_SetSubtitles);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Set);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.btn_Sub5);
            this.Controls.Add(this.btn_Sub1);
            this.Controls.Add(this.btn_Add5);
            this.Controls.Add(this.btn_Add1);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.lst_End);
            this.Controls.Add(this.lst_Start);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.lbl_Time);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.ListBox lst_Start;
        private System.Windows.Forms.ListBox lst_End;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Add1;
        private System.Windows.Forms.Button btn_Add5;
        private System.Windows.Forms.Button btn_Sub1;
        private System.Windows.Forms.Button btn_Sub5;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_SetSubtitles;
        private System.Windows.Forms.Label lbl_Subtitle;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_MoveSubtitles;
        private System.Windows.Forms.Button btn_Compress;
        private System.Windows.Forms.Label lbl_CompressCount;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_SearchResult;
        private System.Windows.Forms.Label lbl_ResultCount;
        private System.Windows.Forms.Label lbl_Movie;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Movie;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Subtitles;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Text;
        private System.Windows.Forms.DataGridViewButtonColumn col_StartMin1000;
        private System.Windows.Forms.DataGridViewButtonColumn col_StartMin100;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StartTime;
        private System.Windows.Forms.DataGridViewButtonColumn col_StartAdd100;
        private System.Windows.Forms.DataGridViewButtonColumn col_StartAdd1000;
        private System.Windows.Forms.DataGridViewButtonColumn col_EndMin1000;
        private System.Windows.Forms.DataGridViewButtonColumn col_EndMin100;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_EndTime;
        private System.Windows.Forms.DataGridViewButtonColumn col_EndAdd100;
        private System.Windows.Forms.DataGridViewButtonColumn col_EndAdd1000;
        private System.Windows.Forms.DataGridViewButtonColumn col_Delete;
        private System.Windows.Forms.DataGridViewButtonColumn col_Watch;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Cat;
        private System.Windows.Forms.DataGridViewButtonColumn col_Cut;
    }
}

