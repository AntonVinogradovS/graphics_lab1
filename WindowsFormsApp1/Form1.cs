using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Load += Form1_Load;
        }
        Bin bin = new Bin();
        bool loaded = false;
        View view = new View();
        public int currentLayer = 0;
        public bool needReload = false;
        private void InitializeComponent()
        {
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glControl2 = new OpenTK.GLControl();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(852, 28);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // glControl2
            // 
            this.glControl2.BackColor = System.Drawing.Color.Black;
            this.glControl2.Location = new System.Drawing.Point(86, 64);
            this.glControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glControl2.Name = "glControl2";
            this.glControl2.Size = new System.Drawing.Size(394, 255);
            this.glControl2.TabIndex = 1;
            this.glControl2.VSync = false;
            this.glControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl2_Paint);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(72, 345);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(537, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(737, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Quads";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(737, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Texture";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(737, 90);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(88, 20);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "QuadStrip";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(538, 151);
            this.trackBar2.Maximum = 1000;
            this.trackBar2.Minimum = -1000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(272, 56);
            this.trackBar2.TabIndex = 6;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(538, 236);
            this.trackBar3.Maximum = 2000;
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(267, 56);
            this.trackBar3.TabIndex = 7;
            this.trackBar3.Value = 1;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "минимум";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "максимум";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(405, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(852, 413);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.glControl2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip3;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                bin.readBIN(str);
                //trackBar1.Minimum = 0;
                trackBar1.Maximum = Bin.Z - 1;
                trackBar1.Value = currentLayer;
                trackBar1.Refresh();
                view.SetupView(glControl2.Width, glControl2.Height);
                loaded = true;
                glControl2.Invalidate();
            }
        }

        private void glControl2_Paint(object sender, PaintEventArgs e)
        {

            if (loaded)
            {

                if (radioButton1.Checked)
                    if (checkBox1.Checked)
                    {
                        view.DrawQuads(currentLayer, true);
                    }
                    else
                    {
                        view.DrawQuads(currentLayer, false);
                    }
                    else if (radioButton3.Checked)
                        view.DrawQuadstrip(currentLayer);

                    else
                    {
                        if (needReload)
                        {
                            view.generateTextureImage(currentLayer);
                            view.Load2DTexture();
                            needReload = false;
                        }
                        view.DrawTexture();

                    }
                glControl2.SwapBuffers();//загружает наш буффер в буффер экрана
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            currentLayer = trackBar1.Value;
            view.DrawQuads(currentLayer, checkBox1.Checked);
            needReload = true;
            glControl2.Invalidate();
        }
        void Application_Idle(object sender, EventArgs e)
        {
            while (glControl2.IsIdle)
            {
                displayFPS();
                glControl2.Invalidate();
            }
        }

        // чтобы Application.Idle работала автоматически
        /*private void Form1_Load(object sender, EventArgs e)
        {
            Application.Idle += Application_Idle;
        }*/

        int FrameCount;
        DateTime NextFPSUpdate = DateTime.Now.AddSeconds(1);
        void displayFPS()
        {
            if (DateTime.Now >= NextFPSUpdate)
            {
                this.Text = String.Format("CT Visualizer(fps={0})", FrameCount);
                NextFPSUpdate = DateTime.Now.AddSeconds(1);
                FrameCount = 0;
            }
            FrameCount++;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Application.Idle += Application_Idle;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            view.minimum = trackBar2.Value;
            needReload = true;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            view.window = trackBar3.Value;
            needReload = true;
        }
    }
}
