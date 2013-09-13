/*
 * Bad Apple（Windows Form版）
 * @author Ray Taylor Lin
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace BadAppleForWindowsForm
{
	public partial class MainForm : Form
	{
		private const int NUM_FRAME = 6517;
		private const int LINES_PER_FRAME = 35;
		private const string RESOURCE_FILE = "resource.dat";
        
        private static int playRate = 0;
        private static int playDelay = 0;
        

        private int drawCount = 0;
        private SoundPlayer sp = new SoundPlayer("bad apple.wav");
        private SolidBrush drawBrush = new SolidBrush(Color.White);
        private Graphics graphicsCanvas;
        
        private string strIntroduce = @"";
        private string[] textOutput = new string[NUM_FRAME];
		
        /// <summary>
        /// 构造方法
        /// </summary>
		public MainForm()
		{
			InitializeComponent();
//			this.lblIntroduce.Text = this.strIntroduce;
            this.ReadConfig();
            this.LoadResource();
		}
		
		/// <summary>
		/// 窗体加载事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Load(object sender, EventArgs e)
        {
			//加载绘制的画布
            this.graphicsCanvas = this.pbxCanvas.CreateGraphics();
            //开始播放Bad Apple
            this.PlayBadApple();
        }
		
		private void PlayBadApple()
        {
            this.drawCount = 0;
            Timer timer = new Timer();
            timer.Interval = playRate;
            timer.Tick += new EventHandler(timer_Tick);
            this.sp.Stop();
            this.sp.Play();
            System.Threading.Thread.Sleep(playDelay);
            timer.Start();
        }
		
		void timer_Tick(object sender, EventArgs e)
        {
            if (this.drawCount < NUM_FRAME)
            {
                Bitmap drawBitmap = new Bitmap(1024, 768);
                this.graphicsCanvas = Graphics.FromImage(drawBitmap);
                this.graphicsCanvas.DrawString(textOutput[this.drawCount], this.Font, this.drawBrush, 0f, 0f);
                this.pbxCanvas.Image = drawBitmap;
                this.drawCount++;
            }
            else
            {
                Timer timerSender = (Timer)sender;
                timerSender.Stop();
                Timer timerDelay = new Timer() { Interval = 5000 };
                timerDelay.Tick += new EventHandler((o, ea) => {
                    this.PlayBadApple();
                    timerDelay.Stop();
                });
                timerDelay.Start();
                
            }
        }
		
		/// <summary>
		/// 读取配置文件
		/// </summary>
		private void ReadConfig()
        {
            IniFileHelper iniFileHelper = new IniFileHelper(Environment.CurrentDirectory + @"\config.ini");
            playRate = Convert.ToInt32(iniFileHelper.IniReadValue("main", "PlayRate"));
            playDelay = Convert.ToInt32(iniFileHelper.IniReadValue("main", "PlayDelay"));
        }
		
		/// <summary>
		/// 读取资源文件
		/// </summary>
		private void LoadResource()
        {
			//初始化数组
            for (int i = 0; i < NUM_FRAME; i++)
            {
                textOutput[i] = "";
            }
            
            //读取字符串
            StreamReader sr = new StreamReader(RESOURCE_FILE);
            for (int i = 0; i < NUM_FRAME; i++)
            {
                for (int j = 0; j < LINES_PER_FRAME; j++)
                {
                    string tempStr=sr.ReadLine();
                    textOutput[i] += tempStr;
                    textOutput[i] += '\n';
                }
                sr.ReadLine();
                sr.ReadLine();
            }
            sr.Close();
            
            //读取音乐文件
            
            
            MessageBox.Show("Load completed!");
        }
	}
}
