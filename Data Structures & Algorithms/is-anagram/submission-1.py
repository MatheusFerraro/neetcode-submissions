class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        counts = {}

        if len(s) != len(t):
            return False

        for cha in s:
            counts[cha] = counts.get(cha, 0) + 1

        for cha in t:
            if cha not in counts or counts[cha] == 0:
                return False
            
            counts[cha] -= 1
            
        return True