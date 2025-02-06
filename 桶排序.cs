using System;
using System.Collections.Generic;

namespace 十大经典算法
{
    public class 桶排序 : CreatData, IUse
    {
        public void Use()
        {
            var data = GetData(100);
            SubFun(data, BucketSort, out long time);
            Console.WriteLine("用时"+ time);
        }
        public List<int> BucketSort(List<int> array)
        {
            int max = 0;
            for (int i = 0; i < array.Count; i++)
            {
                max = max > array[i] ? max : array[i];
            }
            max += 1;
            return BucketSort(array, max);
        }
        public List<int> BucketSort(List<int> array, int bucketNum)
        {
            //创建bucket时，在二维中增加一组标识位，其中bucket[x, 0]表示这一维所包含的数字的个数
            //通过这样的技巧可以少写很多代码
            int[,] bucket = new int[bucketNum, array.Count + 1];
            foreach (var num in array)
            {
                bucket[num, (int)++bucket[num, 0]] = num;
            }
            //为桶里的每一行使用插入排序
            for (int j = 0; j < bucketNum; j++)
            {
                //为桶里的行创建新的数组后使用插入排序
                int[] insertion = new int[bucket[j, 0]];
                for (int k = 0; k < insertion.Length; k++)
                {
                    insertion[k] = bucket[j, k + 1];
                }
                //插入排序
                StraightInsertionSort(insertion);
                //把排好序的结果回写到桶里
                for (int k = 0; k < insertion.Length; k++)
                {
                    bucket[j, k + 1] = insertion[k];
                }
            }
            //将所有桶里的数据回写到原数组中
            for (int count = 0, j = 0; j < bucketNum; j++)
            {
                for (int k = 1; k <= bucket[j, 0]; k++)
                {
                    array[count++] = bucket[j, k];
                }
            }
            return array;
        }
        public void StraightInsertionSort(int[] array)
        {
            //插入排序
            for (int i = 1; i < array.Length; i++)
            {
                int sentinel = array[i];
                int j = i - 1;
                while (j >= 0 && sentinel < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = sentinel;
            }
        }
    }
}