using System.Collections.Generic;

namespace 十大经典算法
{
    public class 快速排序 : CreatData, IUse
    {
        public void Use()
        {
            var data1 = GetData(100);
            var data2 = GetData(100);
            SubFun(data1, QuickSort1,out long time1);
            SubFun(data1, QuickSort2,out long time2);
            System.Console.WriteLine("quickSort1用时"+ time1);
            System.Console.WriteLine("quickSort2用时"+ time2);
        }
        public List<int> QuickSort1(List<int> data)
        {
            int left = 0;
            int right = data.Count-1;
            return QuickSort1(data, left, right); ;
        }
        public List<int> QuickSort1(List<int> data,int left=0,int right=-1)
        {
            if (right==-1)
            {
                right = data.Count;
            }
            if (left < right)
            {
                int x = data[right], i = left - 1, temp;
                for (var j = left; j <= right; j++)
                {
                    if (data[j] <= x)
                    {
                        i++;
                        temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
                QuickSort1(data, left, i - 1);
                QuickSort1(data, i + 1, right);
            }
            return data;
        }
        public List<int> QuickSort2(List<int> data)
        {
            if (data.Count <= 1) { return data; }
            var pivotIndex = data.Count / 2;
            var pivot = data[pivotIndex];
            data.RemoveAt(pivotIndex);
            var left = new List<int>();
            var right = new List<int>();
            for (var i = 0; i < data.Count; i++)
            {
                if (data[i] < pivot)
                {
                    left.Add(data[i]);
                }
                else
                {
                    right.Add(data[i]);
                }
            }
            var list = QuickSort2(left);
            list.AddRange(QuickSort2(right));
            return list;
        }
    }
}