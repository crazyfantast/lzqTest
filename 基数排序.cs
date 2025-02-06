using System;
using System.Collections.Generic;

namespace 十大经典算法
{
    public class 基数排序 : CreatData, IUse
    {
        public void Use()
        {
            var data = GetData(100);
            SubFun(data, RadixSort,out long time);
            Console.WriteLine("用时"+ time);
        }
        public List<int> RadixSort(List<int> data)
        {
            return RadixSort(data,10);
        }
        public List<int> RadixSort(List<int> data, int bucketNum)
        {
            int maxLength = MaxLength(data);
            //创建bucket时，在二维中增加一组标识位，其中bucket[x, 0]表示这一维所包含的数字的个数
            //通过这样的技巧可以少写很多代码
            int[,] bucket = new int[bucketNum, data.Count + 1];
            for (int i = 0; i < maxLength; i++)
            {
                foreach (var num in data)
                {
                    int bit = (int)(num / Math.Pow(10, i) % 10);
                    bucket[bit, ++bucket[bit, 0]] = num;
                }
                for (int count = 0, j = 0; j < bucketNum; j++)
                {
                    for (int k = 1; k <= bucket[j, 0]; k++)
                    {
                        data[count++] = bucket[j, k];
                    }
                }
                //最后要重置这个标识
                for (int j = 0; j < bucketNum; j++)
                {
                    bucket[j, 0] = 0;
                }
            }
            return data;
        }
        private int MaxLength(List<int> data)
        {
            if (data.Count == 0) return 0;
            int max = data[0];
            for (int i = 1; i < data.Count; i++)
            {
                if (data[i] > max) max = data[i];
            }
            int count = 0;
            while (max != 0)
            {
                max /= 10;
                count++;
            }
            return count;
        }

    }
}