class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        
        ind = {}
        
        for i, num in enumerate(nums):
            nex = target - num

            if nex in ind:
                return [ind[nex], i]
        
            ind[num] = i
