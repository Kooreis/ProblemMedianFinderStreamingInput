# Question: How do you implement a median finder that supports streaming input? C# Summary

The C# program implements a median finder for streaming input. It uses a class called `MedianFinder` which maintains two heaps, a max heap and a min heap, to keep track of the lower and higher halves of the input respectively. The `AddNum` method adds a new number to the appropriate heap based on its value and the current state of the heaps. If the heaps become unbalanced after the addition (i.e., the difference in their sizes is more than 1), the method rebalances them by moving the maximum element from the max heap to the min heap or vice versa. The `FindMedian` method calculates and returns the median of the input. If the total number of elements is odd, the median is the maximum element of the max heap. If the total number of elements is even, the median is the average of the maximum element of the max heap and the minimum element of the min heap. The `Main` method demonstrates the usage of the `MedianFinder` class by adding numbers to it and printing the median after each addition.

---

# Python Differences

The Python version of the solution uses a similar approach to the C# version, but there are some differences due to the language features and standard libraries of Python.

1. Use of Heaps: Both versions use two heaps to keep track of the lower and higher halves of the input. However, the Python version uses the heapq module from Python's standard library, which provides an implementation of heaps using regular lists. The C# version uses SortedSet, which is a balanced binary search tree, not a heap. 

2. Tuple: In the C# version, each element in the heaps is a Tuple<int, int> where the first element is the number and the second element is a count used to handle duplicate numbers. In the Python version, there's no need for this because heapq can handle duplicates.

3. Adding Numbers: In the Python version, the heapq.heappushpop function is used to push the number onto the large heap and then pop and return the smallest element. This is equivalent to adding the number to the heap and then removing the smallest element. The negative of this element is then pushed onto the small heap. This is a more concise way of doing what the C# version does with multiple lines of code.

4. Finding the Median: The Python version checks if the large heap is larger than the small heap, and if so, returns the smallest element of the large heap as the median. Otherwise, it returns the average of the smallest element of the large heap and the negative of the largest element of the small heap. The C# version does something similar, but it checks if the two heaps are the same size, and if so, returns the average of the maximum element of the maxHeap and the minimum element of the minHeap.

5. User Input: The Python version includes a main function that continuously accepts numbers from the user, adds them to the median finder, and then prints the current median. The user can quit the application by entering 'q'. The C# version doesn't have this feature; it simply adds a few numbers to the median finder and then prints the median.

---

# Java Differences

The Java version of the solution uses two priority queues to keep track of the lower and higher halves of the input numbers, while the C# version uses two sorted sets. The priority queue in Java is similar to the heap data structure, and it automatically orders its elements according to their natural ordering or a specified comparator. In this case, the lower half priority queue is ordered in descending order, and the higher half priority queue is ordered in ascending order.

In the Java version, when a number is added, it is first offered to the lower half priority queue, then the highest number from the lower half is polled and offered to the higher half priority queue. If the size of the lower half is less than the size of the higher half, the smallest number from the higher half is polled and offered to the lower half. This ensures that the lower half always contains the median(s).

In the C# version, when a number is added, it is added to the appropriate sorted set based on whether it is less than the maximum number in the maxHeap. Then, if the sizes of the heaps are unbalanced, the maximum or minimum number is removed from one heap and added to the other.

The method for finding the median is the same in both versions: if the sizes of the lower and higher halves are equal, the median is the average of the maximum number from the lower half and the minimum number from the higher half; otherwise, the median is the maximum number from the lower half.

The Java version uses a while loop to continuously prompt the user for input, while the C# version only adds a few specific numbers and then ends. The Java version also uses a Scanner for user input, while the C# version does not require user input.

In terms of language features, the C# version uses Tuples to store the numbers and their indices, while the Java version does not need to store the indices because the PriorityQueue automatically orders its elements. The C# version also uses the SortedSet class, which does not have a direct equivalent in Java.

---
