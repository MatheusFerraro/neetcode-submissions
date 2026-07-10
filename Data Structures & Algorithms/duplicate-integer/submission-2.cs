public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> n = new HashSet<int>();
        
        foreach(int num in nums){
        if(!n.Add(num)){
            return true;
        }
        }
        return false;
    }
}