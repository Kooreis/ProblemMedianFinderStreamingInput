Here is a Java console application that implements a median finder for streaming input. It uses two priority queues to keep track of the lower and higher halves of the input numbers. The median is then either the maximum element of the lower half, the minimum element of the higher half, or the average of the two, depending on the total number of input numbers.

```java
import java.util.Collections;
import java.util.PriorityQueue;
import java.util.Scanner;

public class MedianFinder {
    private PriorityQueue<Integer> low = new PriorityQueue<>(Collections.reverseOrder());
    private PriorityQueue<Integer> high = new PriorityQueue<>();

    public void addNum(int num) {
        low.offer(num);
        high.offer(low.poll());
        if (low.size() < high.size()) {
            low.offer(high.poll());
        }
    }

    public double findMedian() {
        if (low.size() == high.size()) {
            return (low.peek() + high.peek()) / 2.0;
        } else {
            return low.peek();
        }
    }

    public static void main(String[] args) {
        MedianFinder mf = new MedianFinder();
        Scanner scanner = new Scanner(System.in);
        while (true) {
            System.out.println("Enter a number (or 'q' to quit):");
            String input = scanner.nextLine();
            if (input.equalsIgnoreCase("q")) {
                break;
            }
            mf.addNum(Integer.parseInt(input));
            System.out.println("Current median: " + mf.findMedian());
        }
        scanner.close();
    }
}
```

This console application continuously prompts the user to enter a number or 'q' to quit. After each number is entered, it adds the number to the median finder and prints the current median.