using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十大经典算法
{
    public class 选择排序 : CreatData, IUse
    {

        public void Use()
        {
            var data = GetData(100);
            SubFun(data, SelectionSort, out long time);
            Console.WriteLine("用时" + time);
        }
        public List<int> SelectionSort(List<int> arr)
        {
            var len = arr.Count;
            int minIndex, temp;
            for (var i = 0; i < len - 1; i++)
            {
                minIndex = i;
                for (var j = i + 1; j < len; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {     //寻找最小的数
                        minIndex = j;                 //将最小数的索引保存
                    }
                }
                temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            return arr;
        }
    }
}
