using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 十大经典算法
{
    public partial class Form1 : Form
    {
        冒泡排序 冒泡;
        选择排序 选择;
        插入排序 插入;
        希尔排序 希尔;
        归并排序 归并;
        快速排序 快速;
        堆排序 堆;
        计数排序 计数;
        桶排序 桶;
        基数排序 基数;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            冒泡 = Implement(冒泡);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            选择 = Implement(选择);
        }
        /// <summary>
        /// 执行
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        private T Implement<T>(T t)
        {
            Console.Clear();
            if (t==null)
            {
                t = System.Activator.CreateInstance<T>();
            }
            ((CreatData)(object)t).ImplementationMethod(((IUse)t).Use);
            return t;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            插入 = Implement(插入);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            希尔 = Implement(希尔);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            归并 = Implement(归并);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            快速 = Implement(快速);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            堆 = Implement(堆);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            计数 = Implement(计数);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            桶= Implement(桶);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            基数 = Implement(基数);
        }
    }
}
