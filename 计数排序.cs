using System.Collections.Generic;

namespace 十大经典算法
{
    public class 计数排序 : CreatData, IUse
    {

        public void Use()
        {
            var data = GetData(100);
            SubFun(data, CountingSort,out long time);
            System.Console.WriteLine("用时"+time);
        }
        private List<int> CountingSort(List<int> data)
        {
            if (data.Count == 0) return data;
            int min = data[0];
            int max = min;
            foreach (int number in data)
            {
                if (number > max)
                {
                    max = number;
                }
                else if (number < min)
                {
                    min = number;
                }
            }
            int[] counting = new int[max - min + 1];
            for (int i = 0; i < data.Count; i++)
            {
                counting[data[i] - min] += 1;
            }
            int index = -1;
            for (int i = 0; i < counting.Length; i++)
            {
                for (int j = 0; j < counting[i]; j++)
                {
                    index++;
                    data[index] = i + min;
                }
            }
            return data;
        }
    }
}