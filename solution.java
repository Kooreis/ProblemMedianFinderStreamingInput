public void addNum(int num) {
        low.offer(num);
        high.offer(low.poll());
        if (low.size() < high.size()) {
            low.offer(high.poll());
        }
    }