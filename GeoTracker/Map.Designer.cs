namespace GeoTracker
{
    partial class Map
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnZoom = new Button();
            btnZoom2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            SuspendLayout();
            // 
            // btnZoom
            // 
            btnZoom.Anchor = AnchorStyles.None;
            btnZoom.Location = new Point(317, 898);
            btnZoom.Name = "btnZoom";
            btnZoom.Size = new Size(75, 23);
            btnZoom.TabIndex = 1;
            btnZoom.Text = "Zoom in";
            btnZoom.UseVisualStyleBackColor = true;
            btnZoom.Click += btnZoom_Click;
            // 
            // btnZoom2
            // 
            btnZoom2.Anchor = AnchorStyles.None;
            btnZoom2.Location = new Point(317, 948);
            btnZoom2.Name = "btnZoom2";
            btnZoom2.Size = new Size(75, 23);
            btnZoom2.TabIndex = 2;
            btnZoom2.Text = "Zoom out";
            btnZoom2.UseVisualStyleBackColor = true;
            btnZoom2.Click += btnZoom2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(68, 865);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 3;
            label1.Text = "User";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(127, 857);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(127, 899);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(127, 945);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 23);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(48, 907);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 8;
            label3.Text = "Latitude";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(33, 948);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 9;
            label4.Text = "Longtitude";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // gMapControl1
            // 
            gMapControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(3, 12);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 2;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(1897, 818);
            gMapControl1.TabIndex = 10;
            gMapControl1.Zoom = 0D;
            gMapControl1.OnMarkerClick += gMapControl1_OnMarkerClick;
            // 
            // Map
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(gMapControl1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnZoom2);
            Controls.Add(btnZoom);
            Name = "Map";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Map_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnZoom;
        private Button btnZoom2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}
