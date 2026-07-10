public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int>map = new Dictionary <char,int>();
        foreach(var letter in s)
        {
            if(map.ContainsKey(letter))
            {
                map[letter]+= 1;
            }
            else{
                map[letter] = 1;
            }
        }
        foreach(var lett in t){
            if(map.ContainsKey(lett)){
                map[lett]--;
            }
        }
        foreach(var vpk in map){
            if(vpk.Value != 0){
                return false;
            }
        }
        return true;

    }
}
