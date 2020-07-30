/*
Given an array of integers, return indices of the two numbers such that they add up to a specific target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
Example:
Given nums = [2, 7, 11, 15], target = 9,
Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
*/

//Accepted 
/*
Runtime: 756 ms: Your runtime beats 10.25 % of csharp submissions.  (very bad)
Memory Usage: 30.3 MB: Your memory usage beats 99.50 % of csharp submissions.
*/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var Find = 0;
        int[] index = new int[2];
        
        for(int i = 0; i < nums.Length; i++){
            Find = target - nums[i];
            //if(Find < 0)
                //continue;
            if(Find == nums[i]){
                
                if(Array.LastIndexOf(nums, nums[i]) == i || Array.LastIndexOf(nums, nums[i]) < 0)
                    continue;
                
                index.SetValue(i, 0);
                index.SetValue(Array.LastIndexOf(nums, nums[i]), 1);
                break;
            }
            else{
                if(Array.IndexOf(nums, Find) < 0)
                    continue;
                
                index.SetValue(i, 0);
                index.SetValue(Array.IndexOf(nums, Find), 1);
                break;
            }    
        }
        return index;
    }
}
