using System;
using System.Collections.Generic;

public class MedianFinder
{
    private SortedSet<Tuple<int, int>> maxHeap = new SortedSet<Tuple<int, int>>();
    private SortedSet<Tuple<int, int>> minHeap = new SortedSet<Tuple<int, int>>();
    private int count = 0;
}