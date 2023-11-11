using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.butSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lvideos = new System.Windows.Forms.Label();
            this.lviews = new System.Windows.Forms.Label();
            this.lsubs = new System.Windows.Forms.Label();
            this.videos = new System.Windows.Forms.Label();
            this.views = new System.Windows.Forms.Label();
            this.subs = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vidos1 = new System.Windows.Forms.PictureBox();
            this.vidos2 = new System.Windows.Forms.PictureBox();
            this.vidos3 = new System.Windows.Forms.PictureBox();
            this.vname1 = new System.Windows.Forms.Label();
            this.vname2 = new System.Windows.Forms.Label();
            this.vname3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidos3)).BeginInit();
            this.SuspendLayout();
            // 
            // butSearch
            // 
            this.butSearch.Image = ((System.Drawing.Image)(resources.GetObject("butSearch.Image")));
            this.butSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSearch.Location = new System.Drawing.Point(317, 29);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(67, 31);
            this.butSearch.TabIndex = 0;
            this.butSearch.Text = "Поиск";
            this.butSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(50, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(50, 70);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.vname2);
            this.splitContainer1.Panel2.Controls.Add(this.vname3);
            this.splitContainer1.Panel2.Controls.Add(this.vname1);
            this.splitContainer1.Panel2.Controls.Add(this.vidos3);
            this.splitContainer1.Panel2.Controls.Add(this.vidos2);
            this.splitContainer1.Panel2.Controls.Add(this.vidos1);
            this.splitContainer1.Panel2.Controls.Add(this.lvideos);
            this.splitContainer1.Panel2.Controls.Add(this.lviews);
            this.splitContainer1.Panel2.Controls.Add(this.lsubs);
            this.splitContainer1.Panel2.Controls.Add(this.videos);
            this.splitContainer1.Panel2.Controls.Add(this.views);
            this.splitContainer1.Panel2.Controls.Add(this.subs);
            this.splitContainer1.Panel2.Controls.Add(this.lname);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(843, 413);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 403);
            this.listBox1.TabIndex = 1;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // lvideos
            // 
            this.lvideos.AutoSize = true;
            this.lvideos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvideos.Location = new System.Drawing.Point(93, 173);
            this.lvideos.Name = "lvideos";
            this.lvideos.Size = new System.Drawing.Size(0, 19);
            this.lvideos.TabIndex = 3;
            this.lvideos.Visible = false;
            // 
            // lviews
            // 
            this.lviews.AutoSize = true;
            this.lviews.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lviews.Location = new System.Drawing.Point(374, 127);
            this.lviews.Name = "lviews";
            this.lviews.Size = new System.Drawing.Size(0, 19);
            this.lviews.TabIndex = 3;
            this.lviews.Visible = false;
            // 
            // lsubs
            // 
            this.lsubs.AutoSize = true;
            this.lsubs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lsubs.Location = new System.Drawing.Point(279, 89);
            this.lsubs.Name = "lsubs";
            this.lsubs.Size = new System.Drawing.Size(0, 19);
            this.lsubs.TabIndex = 3;
            this.lsubs.Visible = false;
            // 
            // videos
            // 
            this.videos.AutoSize = true;
            this.videos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.videos.Location = new System.Drawing.Point(17, 173);
            this.videos.Name = "videos";
            this.videos.Size = new System.Drawing.Size(76, 20);
            this.videos.TabIndex = 2;
            this.videos.Text = "Видосы :";
            this.videos.Visible = false;
            // 
            // views
            // 
            this.views.AutoSize = true;
            this.views.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.views.Location = new System.Drawing.Point(160, 127);
            this.views.Name = "views";
            this.views.Size = new System.Drawing.Size(214, 20);
            this.views.TabIndex = 2;
            this.views.Text = "Общее кол-во просмотров:";
            this.views.Visible = false;
            // 
            // subs
            // 
            this.subs.AutoSize = true;
            this.subs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subs.Location = new System.Drawing.Point(160, 89);
            this.subs.Name = "subs";
            this.subs.Size = new System.Drawing.Size(119, 20);
            this.subs.TabIndex = 2;
            this.subs.Text = "Подписчиков: ";
            this.subs.Visible = false;
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lname.Location = new System.Drawing.Point(160, 36);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(159, 29);
            this.lname.TabIndex = 1;
            this.lname.Text = "Channel Name";
            this.lname.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "img";
            this.columnHeader1.Width = 38;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "name";
            this.columnHeader2.Width = 150;
            // 
            // vidos1
            // 
            this.vidos1.Location = new System.Drawing.Point(40, 196);
            this.vidos1.Name = "vidos1";
            this.vidos1.Size = new System.Drawing.Size(160, 80);
            this.vidos1.TabIndex = 4;
            this.vidos1.TabStop = false;
            this.vidos1.Visible = false;
            // 
            // vidos2
            // 
            this.vidos2.Location = new System.Drawing.Point(360, 196);
            this.vidos2.Name = "vidos2";
            this.vidos2.Size = new System.Drawing.Size(160, 80);
            this.vidos2.TabIndex = 4;
            this.vidos2.TabStop = false;
            this.vidos2.Visible = false;
            // 
            // vidos3
            // 
            this.vidos3.Location = new System.Drawing.Point(40, 295);
            this.vidos3.Name = "vidos3";
            this.vidos3.Size = new System.Drawing.Size(160, 80);
            this.vidos3.TabIndex = 4;
            this.vidos3.TabStop = false;
            this.vidos3.Visible = false;
            // 
            // vname1
            // 
            this.vname1.Location = new System.Drawing.Point(37, 279);
            this.vname1.Name = "vname1";
            this.vname1.Size = new System.Drawing.Size(242, 13);
            this.vname1.TabIndex = 5;
            this.vname1.Text = "label1";
            this.vname1.Visible = false;
            // 
            // vname2
            // 
            this.vname2.Location = new System.Drawing.Point(357, 279);
            this.vname2.Name = "vname2";
            this.vname2.Size = new System.Drawing.Size(229, 13);
            this.vname2.TabIndex = 5;
            this.vname2.Text = "label1";
            this.vname2.Visible = false;
            // 
            // vname3
            // 
            this.vname3.Location = new System.Drawing.Point(37, 378);
            this.vname3.Name = "vname3";
            this.vname3.Size = new System.Drawing.Size(242, 13);
            this.vname3.TabIndex = 5;
            this.vname3.Text = "label1";
            this.vname3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 495);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidos3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private ListBox listBox1;
        private Label lvideos;
        private Label lviews;
        private Label lsubs;
        private Label videos;
        private Label views;
        private Label subs;
        private Label lname;
        private PictureBox pictureBox1;
        private PictureBox vidos1;
        private Label vname2;
        private Label vname3;
        private Label vname1;
        private PictureBox vidos3;
        private PictureBox vidos2;
    }
}

