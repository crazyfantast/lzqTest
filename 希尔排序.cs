using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十大经典算法
{
    public class 希尔排序 : CreatData, IUse
    {
        public void Use()
        {
            var data = GetData(100);
            SubFun(data, ShellSort, out long time);
            Console.WriteLine("用时"+time);
        }
        private List<int> ShellSort(List<int> data)
        {
            int len = data.Count,temp,ga = 1;
            while (ga < len / 5)
            {          //动态定义间隔序列
                ga = ga * 5 + 1;
            }

            for (var gap= ga; gap > 0; gap = gap / 5)
            {
                for (var i = gap; i < len; i++)
                {
                    temp = data[i];
                    int jj = 0;
                    for (int j = i - gap; j >= 0 && data[j] > temp; j -= gap)
                    {
                        data[j + gap] = data[j];
                        jj = j;
                    }
                    data[jj + gap] = temp;
                }
            }
            return data;
        }
    }
}
