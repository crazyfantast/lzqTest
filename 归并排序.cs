using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十大经典算法
{
    public class 归并排序 : CreatData, IUse
    {
        public void Use()
        {
            var data = GetData(33);
            SubFun(data, MergeSort,out long time);
            Console.WriteLine("用时"+ time);
        }
        public List<int> MergeSort(List<int> data)
        {
            var len = data.Count;
            if (len < 2)
            {
                return data;
            }
            int middle = len / 2;
            var left = data.GetRange(0, middle);
            var right = data.GetRange(middle, data.Count- middle);
            return Merge(MergeSort(left), MergeSort(right));
        }
        public List<int> Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
            return result;
        }
    }
}
