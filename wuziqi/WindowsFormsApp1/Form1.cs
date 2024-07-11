using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        /*字段*/
        int gameon = 0;//0代表未开始，1代表已开始，2代表一方获胜 3代表游戏暂停    
        List<Point> pointslist = new List<Point>(15 * 15);//列表用于记录绘图需要的落子像素坐标
        int[,] pointsarray = new int[15, 15];//二维数组用于记录棋盘位置落子属性，0，1，2代表 无子，黑子，白子
        int second = 30;//每次倒计时30秒
        int fupanon = 0;//复盘是否启动 
        List<Point> fupanlist = new List<Point>(15 * 15);//复盘时使用的的列表 
        int f = 0;//复盘list的长度     
        Point mouse;//鼠标光标
        SoundPlayer bgm = new SoundPlayer(@"..\..\Resources\bgm.wav");//音乐文件

        /*方法*/          
        //基本功能（棋盘 落子 计时 胜负）
        public Form1()
        {
            InitializeComponent();
        }
        public bool Judgewin(int a, int b)// 判断从该点开始右，下，右下，右上四个方向是否连成五子
        {
            if (a >= 0 && a <= 10 && b >= 0 && b <= 14)//向右判断
            {
                for (int i = 0; i < 4; i++)
                {
                    if (pointsarray[a + i, b] != pointsarray[a + i + 1, b])
                    {
                        break;
                    }
                    if (i == 3 && pointsarray[a, b] != 0)
                    {
                        return true;
                    }
                }
            }
            if (b >= 0 && b <= 10 && a >= 0 && a <= 14)//向下判断
            {
                for (int i = 0; i < 4; i++)
                {
                    if (pointsarray[a, b + i] != pointsarray[a, b + i + 1])
                    {
                        break;
                    }
                    if (i == 3 && pointsarray[a, b] != 0)
                    {
                        return true;
                    }
                }
            }
            if (a >= 0 && a <= 10 && b >= 0 && b <= 10)//向右下判断
            {
                for (int i = 0; i < 4; i++)
                {
                    if (pointsarray[a + i, b + i] != pointsarray[a + i + 1, b + i + 1])
                    {
                        break;
                    }
                    if (i == 3 && pointsarray[a, b] != 0)
                    {
                        return true;
                    }
                }
            }
            if (a >= 0 && a <= 10 && b >= 4 && b <= 14)//向右上判断
            {
                for (int i = 0; i < 4; i++)
                {
                    if (pointsarray[a + i, b - i] != pointsarray[a + i + 1, b - i - 1])
                    {
                        break;
                    }
                    if (i == 3 && pointsarray[a, b] != 0)
                    {
                        return true;
                    }
                }
            }
            return false;//未连成五子
        }                      
        private void pictureBox1_Paint(object sender, PaintEventArgs e)//在picturebox中绘图
        {
            Graphics g = e.Graphics;
            Pen blackpen = new Pen(Color.Black, 1);
            Pen redpen = new Pen(Color.Red, 1);
            SolidBrush blackbrush = new SolidBrush(Color.Black);
            SolidBrush whitebrush = new SolidBrush(Color.White);
            for (int i = 0; i < 15; i++)//绘制棋盘 从25 25开始50为间距横竖十五条线
            {
                g.DrawLine(blackpen, 25 + 50 * i, 25, 25 + 50 * i, 25 + 14 * 50);//竖线
                g.DrawLine(blackpen, 25, 25 + 50 * i, 25 + 14 * 50, 25 + 50 * i);//横线
            }
            g.FillEllipse(blackbrush,25+50*7-5,25+50*7-5,10,10);//天元
            g.FillEllipse(blackbrush, 25 + 50 * 3 - 5, 25 + 50 * 11 - 5, 10, 10);//天元
            g.FillEllipse(blackbrush, 25 + 50 * 3 - 5, 25 + 50 * 3 - 5, 10, 10);//星
            g.FillEllipse(blackbrush, 25 + 50 * 11 - 5, 25 + 50 * 11 - 5, 10, 10);//星
            g.FillEllipse(blackbrush, 25 + 50 *11 - 5, 25 + 50 * 3 - 5, 10, 10);//星
            if (fupanon == 0)//下棋中
            {
                if (mouse.X != 0)//绘制跟随鼠标的红色方框
                {
                    g.DrawRectangle(redpen,-10+ mouse.X,-10+ mouse.Y, 20, 20);
                }
    
                for (int i = 0; i < pointslist.Count; i++)//绘制落子 半径为35的圆
                {
                    if (i % 2 == 0)
                    {
                        g.FillEllipse(blackbrush, 25 - 35 / 2 + pointslist[i].X * 50, 25 - 35/2 + pointslist[i].Y * 50, 35, 35);
                        g.DrawString((i+1).ToString(),label1.Font,whitebrush, pointslist[i].X * 50+20,   pointslist[i].Y * 50+20);
                    }
                    else
                    {
                        g.FillEllipse(whitebrush, 25 - 35 / 2 + pointslist[i].X * 50, 25 - 35 / 2 + pointslist[i].Y * 50, 35, 35);
                        g.DrawString((i+1).ToString(), label1.Font, blackbrush, pointslist[i].X * 50 + 20, pointslist[i].Y * 50 + 20);
                    }
                }
            }
            if (fupanon == 1)//复盘中
            {
                for (int i = 0; i < fupanlist.Count; i++)//绘制落子 半径为35的圆
                {
                    if (i % 2 == 0)
                    {
                        g.FillEllipse(blackbrush, 25 - 35 / 2 + fupanlist[i].X * 50, 25 - 35 / 2 + fupanlist[i].Y * 50, 35, 35);
                        g.DrawString((i + 1).ToString(), label1.Font, whitebrush, fupanlist[i].X * 50 + 20,fupanlist[i].Y * 50 + 20);
                    }
                    else
                    {
                        g.FillEllipse(whitebrush, 25 - 35 / 2 + fupanlist[i].X * 50, 25 - 35 / 2 + fupanlist[i].Y * 50, 35, 35);
                        g.DrawString((i + 1).ToString(), label1.Font, blackbrush, fupanlist[i].X * 50 + 20, fupanlist[i].Y * 50 + 20);
                    }
                }
            }
        }
        private void 棋盘_MouseDown(object sender, MouseEventArgs e)//在picturebox中点击后 记录落子 绘图 判断胜负
        {
            if (gameon == 0)//游戏未开始
            {
                MessageBox.Show("请点击左上角开始游戏");
            }
            if (gameon == 1)
            {
                int x = (int)((e.X - 25) / 50.0 + 0.5);//点击位置矫正后落子的相对x坐标
                int y = (int)((e.Y - 25) / 50.0 + 0.5);//点击位置矫正后落子的相对y坐标
                if (e.X >= 25 && e.X <= 725 && e.Y >= 25 && e.Y <= 725)//落子在棋盘范围内
                {
                    Point adjustpoint = new Point(x, y);//校正的落子相对坐标
                    if (!pointslist.Contains(adjustpoint))//是否重复落子
                    {
                        pointslist.Add(adjustpoint);
                        if (pointslist.Count % 2 == 0)//落子为白子
                        {
                            label2.Text = "黑子回合";
                            pointsarray[x, y] = 2;
                        }
                        else//落子为黑子
                        {
                            label2.Text = "白子回合";
                            pointsarray[x, y] = 1;
                        }
                        label1.Text = '(' + Convert.ToString(x) + ',' + Convert.ToString(y) + ')';
                        label3.BackColor = Color.White;
                        pictureBox1.ImageLocation = @"..\..\Resources\1.jpg";
                        second = 30;
                        timer1.Start();
                        棋盘.Invalidate();//绘图
                        for (int i = -4; i <= 0; i++) //判断胜负
                        {
                            if (Judgewin(x + i, y) || Judgewin(x, y + i) || Judgewin(x + i, y + i) || Judgewin(x + i, y - i))
                            {
                                gameon = 2;
                                timer1.Stop();
                                label2.Text = "游戏结束";
                                if (pointsarray[x, y] == 1)
                                {
                                    pictureBox1.ImageLocation = @"..\..\Resources\2.jpg";
                                    MessageBox.Show("黑子获胜！");
                                }
                                if (pointsarray[x, y] == 2)
                                {
                                    pictureBox1.ImageLocation = @"..\..\Resources\3.jpg";
                                    MessageBox.Show("白子获胜！");
                                }
                                break;
                            }
                        }
                    }
                }
                
            }
        }
        private void timer1_Tick(object sender, EventArgs e)//游戏倒计时
        {
            second--;
            label3.Text = Convert.ToString(second);          
            if (second <= 10)
            {
                label3.BackColor = Color.Red;
            }
            if (second == 0)
            {
                gameon = 2;
                timer1.Stop();
                label2.Text = "游戏结束";
                if (pointslist.Count % 2 == 0)
                {
                    pictureBox1.ImageLocation = @"..\..\Resources\3.jpg";
                    label3.BackColor = Color.White;
                    mouse.X = 0;
                    棋盘.Invalidate();
                    MessageBox.Show("计时结束，白子胜利！");
                }
                else
                {
                    pictureBox1.ImageLocation = @"..\..\Resources\2.jpg";
                    label3.BackColor = Color.White;
                    mouse.X = 0;
                    棋盘.Invalidate();
                    MessageBox.Show("计时结束，黑子胜利！");
                }
            }
        }
        private void 棋盘_MouseMove(object sender, MouseEventArgs e)//鼠标光标确认落子位置
        {
            if (gameon == 1 && e.X >= 25 && e.X <= 725 && e.Y >= 25 && e.Y <= 725)
            {
                mouse.X = 25 + (int)((e.X - 25) / 50.0 + 0.5) * 50;
                mouse.Y = 25 + (int)((e.Y - 25) / 50.0 + 0.5) * 50;
            
            }
            else
            {
                mouse.X = 0;
                mouse.Y = 0;
            }   
            棋盘.Invalidate();

        }
        //菜单功能
        private void 五子棋ToolStripMenuItem_Click(object sender, EventArgs e)//启动键
        {
            if (gameon == 0)
            {
                gameon = 1;
                timer1.Start();
            }
        }
        private void 暂停WToolStripMenuItem_Click(object sender, EventArgs e)//暂停、继续键
        {
            if (gameon == 1)
            {
                gameon = 3;
                timer1.Stop();
                暂停WToolStripMenuItem.Text = "继续游戏&S";
            }
            else if (暂停WToolStripMenuItem.Text == "继续游戏&S"&&gameon==3)
            {
                gameon = 1;
                timer1.Start();
                暂停WToolStripMenuItem.Text = "暂停游戏&S";
            }
        }
        private void 悔棋ToolStripMenuItem_Click(object sender, EventArgs e)//悔棋功能
        {
            if (pointslist.Count >= 1)
            {
                pointsarray[pointslist[pointslist.Count - 1].X, pointslist[pointslist.Count - 1].Y] = 0;
                pointslist.RemoveAt(pointslist.Count - 1);
                second = 30;
                gameon = 1;
                if (pointslist.Count % 2 == 0) label2.Text = "黑子回合";
                else label2.Text = "白子回合";
                label3.BackColor = Color.White;
                pictureBox1.ImageLocation = @"..\..\Resources\1.jpg";
                timer1.Start();
                棋盘.Invalidate();
            }
            else
            {
                MessageBox.Show("落子可悔棋，人生无重来");
            }
        }
        private void 重置棋盘ToolStripMenuItem_Click(object sender, EventArgs e)//重置棋盘
        {
            if ( MessageBox.Show("确认重置棋盘？", "提示", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < 15; i++)//重置数组
                {
                    for (int j = 0; j < 15; j++)
                        pointsarray[i, j] = 0;
                }
                pointslist.RemoveRange(0, pointslist.Count);//重置列表
                label2.Text = "黑子先手";
                暂停WToolStripMenuItem.Text = "暂停游戏&S";
                label1.Text = "落子记录";
                label3.Text = "倒计时：";
                label3.BackColor = Color.White;
                pictureBox1.ImageLocation = @"2.jpg";
                timer1.Stop();
                gameon = 0;
                second = 30;
                棋盘.Invalidate();
            }
        }
        private void 复盘ToolStripMenuItem_Click(object sender, EventArgs e)//复盘启动器
        {
            if (fupanon == 0 && gameon == 2)
            {
                fupanon = 1;
                timer2.Start();
            }
        }       
        private void timer2_Tick(object sender, EventArgs e)//复盘计时器
        {
            label3.Text = "复盘中...";
            if (fupanlist.Count < pointslist.Count)
            {
                fupanlist.Add(pointslist[f]);
                label1.Text = Convert.ToString('('+fupanlist[f].X) + ',' + Convert.ToString(fupanlist[f].Y+')');
                f++;
                棋盘.Invalidate();
            }
            else
            {
                timer2.Stop();
                label3.Text = "复盘结束";
                MessageBox.Show("复盘结束!");
                f = 0;
                fupanlist.RemoveRange(0, fupanlist.Count);
                fupanon = 0;
            }
        }
        private void 保存当前棋盘ToolStripMenuItem1_Click(object sender, EventArgs e)//保存文件
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "五子棋棋盘 | *.wzq";
            if (save.ShowDialog() == DialogResult.OK)
            {
                timer1.Stop();
                wuziqi mytest = new wuziqi();
                mytest.gameon0 = gameon;
                mytest.pointslist0 = pointslist;
                mytest.pointsarray0 = pointsarray;
                mytest.label2text = label2.Text;
                FileStream fs = new FileStream(save.FileName, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, mytest); //将对象myTest序列化后存入文件saveFileDialog1.FileName
                fs.Close();
                MessageBox.Show("保存成功！");
            }           
        }
        private void 打开棋盘文件ToolStripMenuItem_Click(object sender, EventArgs e)//打开文件
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "五子棋棋盘 | *.wzq";
            if (fupanon==0&& open.ShowDialog() == DialogResult.OK)
            {
                wuziqi mytest = new wuziqi();
                FileStream fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                mytest = (wuziqi)bf.Deserialize(fs); //将文件内容反序列化为对象
                fs.Close();
                if (mytest.gameon0 == 2) gameon = 2;
                else gameon = 1;
                pointsarray = mytest.pointsarray0;
                pointslist = mytest.pointslist0;
                label2.Text = mytest.label2text;
                label3.Text = "请落子";
                label3.BackColor = Color.White;
               暂停WToolStripMenuItem.Text = "暂停游戏&S";
                pictureBox1.ImageLocation = @"2.jpg";
                timer1.Stop();
                second = 30;
                棋盘.Invalidate();
            }
        }
        private void 换色ToolStripMenuItem_Click(object sender, EventArgs e)//更改棋盘颜色
        {
            ColorDialog color = new ColorDialog();
            if(color.ShowDialog()==DialogResult.OK)   棋盘.BackColor = color.Color;
        }      
        private void 播放音乐ToolStripMenuItem_Click(object sender, EventArgs e)//播放音乐
        {
            bgm.PlayLooping();
        }
        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)//关闭音乐
        {
            bgm.Stop();
        }

        
    }
  
    [Serializable]   public class wuziqi//记录五子棋棋盘数据的类
    {
        public int gameon0 ;
        public List<Point> pointslist0 = new List<Point>(15 * 15);
        public int[,] pointsarray0 = new int[15, 15];
        public string label2text;
    }
}




