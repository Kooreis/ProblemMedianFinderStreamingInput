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