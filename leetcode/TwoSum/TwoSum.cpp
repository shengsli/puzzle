#include <vector>
#include <unordered_map>
#include <string>
#include <iostream>

class Solution {
public:
    // Approach 1: brute force
    vector<int> twoSumBruteForce(vector<int>& nums, int target) {
        int sum=0;
        for (int i=0; i<nums.size(); ++i) {
            for (int j=i+1; j<nums.size(); j++) {
                if (nums[i]+nums[j]==target) {
                    return {i,j};
                }
            }
        }
        throw std::invalid_argument("No two sum solution");
    }
    
    // Approach 2: 2-pass hash table
    // key is number, value is index
    vector<int> twoSum2PassHashMap(vector<int>& nums, int target) {
        unordered_map<int, int> map;
        vector<int> result;
        for (int i=0; i<nums.size(); ++i) {//first pass
            map.insert({nums[i],i});
        }
        for (int i=0; i<nums.size(); ++i) {//second pass
            int numToFind = target - nums[i];
            auto temp = map.find(numToFind);
            if (temp != map.end() && temp->second != i) {
                return {map[numToFind], i};
            }
        }
        throw std::invalid_argument("No two sum solution");
    }
    
    // Approach 3: 1-pass hash table
	std::vector<int> twoSum1PassHashMap(std::vector<int>& nums, int target) {
		std::unordered_map<int, int> map;
		std::vector<int> result;
        for (int i=0; i<nums.size(); ++i) {
            int numToFind = target - nums[i];
            if (map.find(numToFind) != map.end()) {
                return {map[numToFind],i};
            }
            map[nums[i]] = i;
        }
        throw std::invalid_argument("No two sum solution");
    }
};

int main (int argc, char *argv[]) {
	Solution s = Solution();
	std::vector<int> vec = {2,7,11,15};
	int target = 9;
	std::vector<int> output = s.twoSumBruteForce(vec, target);
	for (auto el : output) {
		std::cout << el << ",";
	}

	/**
	/* io  
     */
	// std::string line;
	// std::string inputArr;
	// int target;
	// std::cin >> inputArr;
	// std::cin >> target;

}
