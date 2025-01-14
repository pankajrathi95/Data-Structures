/*
#941 - https://leetcode.com/problems/valid-mountain-array/
Given an array of integers arr, return true if and only if it is a valid mountain array.

Recall that arr is a mountain array if and only if:

arr.length >= 3
There exists some i with 0 < i < arr.length - 1 such that:
arr[0] < arr[1] < ... < arr[i - 1] < A[i]
arr[i] > arr[i + 1] > ... > arr[arr.length - 1]

 

Example 1:

Input: arr = [2,1]
Output: false
Example 2:

Input: arr = [3,5,5]
Output: false
Example 3:

Input: arr = [0,3,2,1]
Output: true
 

Constraints:

1 <= arr.length <= 104
0 <= arr[i] <= 104

   Hide Hint #1  
It's very easy to keep track of a monotonically increasing or decreasing ordering of elements. 
You just need to be able to determine the start of the valley in the mountain and from that point onwards, 
it should be a valley i.e. no mini-hills after that. Use this information in regards to the values in the array
 and you will be able to come up with a straightforward solution.
*/

public class ValidMountainArray
{
    public bool IsValidMountainArray(int[] arr)
    {
        if (arr.Length <= 2)
        {
            return false;
        }

        int index = 0;
        while (index + 1 < arr.Length && arr[index] < arr[index + 1])
        {
            index++;
        }

        if (index == 0 || index == arr.Length - 1)
        {
            return false;
        }

        while (index + 1 < arr.Length)
        {
            if (arr[index] <= arr[index++ + 1])
            {
                return false;
            }
        }


        return true;
    }
}