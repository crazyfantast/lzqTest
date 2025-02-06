using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 十大经典算法
{
    /// <summary>
    /// 通用方法类
    /// </summary>
    public class CreatData
    {
        public Task task;
        public delegate List<int> 排序方法(List<int> data);
        public void ImplementationMethod(Action action)
        {
            if (task != null && task.Status == TaskStatus.Running)
            {
                Console.WriteLine("执行中");
                return;
            }
            task = Task.Factory.StartNew(() =>
            {
                action();
            });
        }
        public List<int> GetData(int count, int mix = 0, int max = 10000)
        {
            Console.WriteLine("开始生成数据");
            Random random = new Random();
            List<int> data = new List<int>();
            for (int i = 0; i < count; i++)
            {
                int value = random.Next(mix, max);
                data.Add(value);
                Console.Write(value+" ");
                Thread.Sleep(20);//防止数据重复
            }
            return data;
        }
        public void SubFun(List<int> data, 排序方法 fun, out long time)
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.Write("\r\n");
            stopwatch.Restart();
            stopwatch.Start();
            data = fun.Invoke(data);
            stopwatch.Stop();
            Console.WriteLine("排序后");
            for (int i = 0; i < data.Count; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.Write("\r\n");
            time = stopwatch.ElapsedTicks;
        }
    }
}
