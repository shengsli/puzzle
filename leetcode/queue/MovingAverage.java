import java.util.*;

class MovingAverage {
	private Queue<Integer> q;
	private int sum;
	private int size;

    /** Initialize your data structure here. */
    public MovingAverage(int size) {
		q = new LinkedList<Integer>();
		this.size = size;
    }
    
    public double next(int val) {
		if (q.size() == size) {
			sum -= q.remove();
		}
        q.offer(val);
		sum += val;
		return (double) sum / q.size();
    }

	public static void main(String[] args) {
		MovingAverage obj = new MovingAverage(3);
		System.out.println(obj.next(1));
		System.out.println(obj.next(10));
		System.out.println(obj.next(3));
		System.out.println(obj.next(5));
	}
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.next(val);
 */
