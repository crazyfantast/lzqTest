using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十大经典算法
{
    public class 插入排序 : CreatData, IUse
    {
        public void Use()
        {
            var data1 = GetData(100);
            var data2 = GetData(100);
            SubFun(data1, InsertionSort,out long time1);
            SubFun(data2, BinaryInsertionSort, out long time2);
            Console.WriteLine("insertionSort用时 "+ time1);
            Console.WriteLine("binaryInsertionSort用时 " + time2);

        }
        public List<int> InsertionSort(List<int> data)
        {
            for (var i = 1; i < data.Count; i++)
            {
                var key = data[i];
                var j = i - 1;
                while (j >= 0 && data[j] > key)
                {
                    data[j + 1] = data[j];
                    j--;
                }
                data[j + 1] = key;
            }
            return data;
        }
        public List<int> BinaryInsertionSort(List<int> data)
        {
            for (var i = 1; i < data.Count; i++)
            {
                int key = data[i], left = 0, right = i - 1;
                while (left <= right)
                {
                    var middle = (left + right) / 2;
                    if (key < data[middle])
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }
                for (var j = i - 1; j >= left; j--)
                {
                    data[j + 1] = data[j];
                }
                data[left] = key;
            }
            return data;
        }

    }
}
