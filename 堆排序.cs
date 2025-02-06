using System.Collections.Generic;

namespace 十大经典算法
{
    public class 堆排序 : CreatData, IUse
    {
        public void Use()
        {
            var data = GetData(100);
            SubFun(data, HeapSort,out long time);
            System.Console.WriteLine("用时"+ time);
        }
        private List<int> HeapSort(List<int> data)
        {
            int heapSize = data.Count, temp;
            for (var i = heapSize / 2 - 1; i >= 0; i--)
            {
                Heapify(data, i, heapSize);
            }

            //堆排序
            for (var j = heapSize - 1; j >= 1; j--)
            {
                temp = data[0];
                data[0] = data[j];
                data[j] = temp;
                Heapify(data, 0, --heapSize);
            }
            return data;
        }
        private List<int> Heapify(List<int> data,int x,int len)
        {
            int l = 2 * x + 1, r = 2 * x + 2, largest = x, temp;
            if (l < len && data[l] > data[largest])
            {
                largest = l;
            }
            if (r < len && data[r] > data[largest])
            {
                largest = r;
            }
            if (largest != x)
            {
                temp = data[x];
                data[x] = data[largest];
                data[largest] = temp;
                Heapify(data, largest, len);
            }
            return data;
        }

    }
}