Here is a Python console application that implements a median finder for streaming input. It uses the heapq library to maintain two heaps, one for the lower half of the numbers and one for the upper half. The median is then either the maximum of the lower half, the minimum of the upper half, or the average of the two, depending on the number of elements.

```python
import heapq

class MedianFinder:
    def __init__(self):
        self.heaps = [], []

    def add_num(self, num):
        small, large = self.heaps
        heapq.heappush(small, -heapq.heappushpop(large, num))
        if len(large) < len(small):
            heapq.heappush(large, -heapq.heappop(small))

    def find_median(self):
        small, large = self.heaps
        if len(large) > len(small):
            return float(large[0])
        return (large[0] - small[0]) / 2.0

def main():
    mf = MedianFinder()
    while True:
        num = input("Enter a number (or 'q' to quit): ")
        if num == 'q':
            break
        mf.add_num(int(num))
        print("Current median: ", mf.find_median())

if __name__ == "__main__":
    main()
```

This console application continuously accepts numbers from the user, adds them to the median finder, and then prints the current median. The user can quit the application by entering 'q'.