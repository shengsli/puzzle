import java.util.Map;
import java.util.HashMap;

class Solution {
	/**
	 * Solution 1: brute force
	 */
    public int[] twoSumBruteForce(int[] nums, int target) {
        for (int i = 0; i < nums.length; i++) {
            for (int j = i + 1; j < nums.length; j++) {
                if (nums[j] == target - nums[i]) {
                    return new int[] { i, j };
                }
            }
        }
        throw new IllegalArgumentException("No two sum solution");
    }
 
	/**
	 * Solution 2: 2-pass hash table 
     */
	public int[] twoSum2PassHashMap(int[] nums, int target) {
        Map<Integer, Integer> map = new HashMap<>();
        for (int i = 0; i < nums.length; i++) {
            map.put(nums[i], i);
        }
        for (int i = 0; i < nums.length; i++) {
            int complement = target - nums[i];
            if (map.containsKey(complement) && map.get(complement) != i) {
                return new int[] { i, map.get(complement) };
            }
        }
        throw new IllegalArgumentException("No two sum solution");
    }

	/**
	 * Solution 3: 1-pass hash table 
     */
    public int[] twoSum1PassHashMap(int[] nums, int target) {
        Map<Integer, Integer> map = new HashMap<>();
        for (int i = 0; i < nums.length; i++) {
            int complement = target - nums[i];
            if (map.containsKey(complement)) {
                return new int[] { map.get(complement), i };
            }
            map.put(nums[i], i);
        }
        throw new IllegalArgumentException("No two sum solution");
    }

	public static void main(String[] args) {
		Solution s = new Solution();
		String line;
		int arr[] = {2,7,11,15};
		int target = 9;
		int output[] = s.twoSum2PassHashMap(arr,target);
		for (int i=0; i<output.length; ++i) {
		    System.out.println(output[i] + ",");
		}
	}
}
