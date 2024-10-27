Here is a C# console application that implements a median finder for streaming input. It uses two heaps to keep track of the lower and higher halves of the input.

```C#
using System;
using System.Collections.Generic;

public class MedianFinder
{
    private SortedSet<Tuple<int, int>> maxHeap = new SortedSet<Tuple<int, int>>();
    private SortedSet<Tuple<int, int>> minHeap = new SortedSet<Tuple<int, int>>();
    private int count = 0;

    public void AddNum(int num)
    {
        if (maxHeap.Count == 0 || num < maxHeap.Max.Item1)
        {
            maxHeap.Add(new Tuple<int, int>(num, count++));
        }
        else
        {
            minHeap.Add(new Tuple<int, int>(num, count++));
        }

        if (maxHeap.Count > minHeap.Count + 1)
        {
            var max = maxHeap.Max;
            maxHeap.Remove(max);
            minHeap.Add(max);
        }
        else if (minHeap.Count > maxHeap.Count)
        {
            var min = minHeap.Min;
            minHeap.Remove(min);
            maxHeap.Add(min);
        }
    }

    public double FindMedian()
    {
        if (maxHeap.Count == minHeap.Count)
        {
            return (maxHeap.Max.Item1 + minHeap.Min.Item1) / 2.0;
        }
        else
        {
            return maxHeap.Max.Item1;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MedianFinder mf = new MedianFinder();
        mf.AddNum(1);
        mf.AddNum(2);
        Console.WriteLine(mf.FindMedian());
        mf.AddNum(3);
        Console.WriteLine(mf.FindMedian());
    }
}
```

This program creates a `MedianFinder` object, adds numbers to it, and then prints the median after each addition. The `MedianFinder` class uses two heaps to keep track of the lower and higher halves of the input. When a new number is added, it is added to the appropriate heap, and then the heaps are rebalanced if necessary. The median is then either the maximum element of the lower heap (if the total number of elements is odd) or the average of the maximum element of the lower heap and the minimum element of the upper heap (if the total number of elements is even).