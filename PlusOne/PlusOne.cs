/*
Given a non-empty array of digits representing a non-negative integer, increment one to the integer.
The digits are stored such that the most significant digit is at the head of the list, and each element in the array contains a single digit.
You may assume the integer does not contain any leading zero, except the number 0 itself.
Example 1:
Input: [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
*/

public class Solution {
    public int[] PlusOne(int[] digits) {
        
        digits[digits.Length - 1] += 1;
        for(int i = digits.Length - 1; i > 0; i--){
            if(digits[i] == 10){
                digits[i] = 0;
                digits[i - 1] += 1;
            }
            else
                break;
        }
        if(digits[0] == 10){
            int[] new_digits = new int[digits.Length + 1];
            new_digits[0] = 1;
            digits[0] = 0;
            for(int i = 1; i < digits.Length; i ++){
                new_digits[i] = digits[i];
            }
            return new_digits;
        }
        
        return digits;
    }
}
