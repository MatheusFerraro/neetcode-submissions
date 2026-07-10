public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> su = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];

            if(su.ContainsKey(difference))
            {
                return new int[] { su[difference], i };
            }
            else if(!su.ContainsKey(nums[i]))
            {
               su[nums[i]] = i;
            }
        }
        return new int [0];
    }
}
