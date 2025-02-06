using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 十大经典算法
{
    public class 冒泡排序 : CreatData, IUse
    {
        public void Use()
        {
            long usetime1 = 0, usetime2 = 0, usetime3 = 0;
            var data1 = GetData(100);
            var data2 = GetData(100);
            var data3 = GetData(100);

            SubFun(data1, BubbleSort1, out usetime1);
            SubFun(data2, BubbleSort2, out usetime2);
            SubFun(data3, BubbleSort3, out usetime3);
            Console.WriteLine("bubbleSort1方法用时" + usetime1);
            Console.WriteLine("bubbleSort2方法用时" + usetime2);
            Console.WriteLine("bubbleSort3方法用时" + usetime3);
        }
        public List<int> BubbleSort1(List<int> vs)
        {
            for (var i = 0; i < vs.Count; i++)
            {
                for (var j = 0; j < vs.Count - 1 - i; j++)
                {
                    if (vs[j] > vs[j + 1])
                    {        //相邻元素两两对比
                        var temp = vs[j + 1];        //元素交换
                        vs[j + 1] = vs[j];
                        vs[j] = temp;
                    }
                }
            }
            return vs;
        }
        public List<int> BubbleSort2(List<int> vs)
        {
            var i = vs.Count - 1;  //初始时,最后位置保持不变
            while (i > 0)
            {
                var pos = 0; //每趟开始时,无记录交换
                for (var j = 0; j < i; j++)
                    if (vs[j] > vs[j + 1])
                    {
                        pos = j; //记录交换的位置
                        var tmp = vs[j]; vs[j] = vs[j + 1]; vs[j + 1] = tmp;
                    }
                i = pos; //为下一趟排序作准备
            }
            return vs;
        }
        public List<int> BubbleSort3(List<int> arr)
        {
            var low = 0;
            var high = arr.Count - 1; //设置变量的初始值
            int tmp, j;
            while (low < high)
            {
                for (j = low; j < high; ++j) //正向冒泡,找到最大者
                    if (arr[j] > arr[j + 1])
                    {
                        tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                --high;                 //修改high值, 前移一位
                for (j = high; j > low; --j) //反向冒泡,找到最小者
                    if (arr[j] < arr[low])
                    {
                        tmp = arr[j];
                        arr[j] = arr[low];
                        arr[low] = tmp;
                    }
                ++low;
            }
            return arr;
        }
    }
}
