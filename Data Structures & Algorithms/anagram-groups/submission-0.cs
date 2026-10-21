public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> hashMap = new Dictionary<string, List<string>>();
        foreach(string word in strs){
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string sortedWord = new string(chars);
            
            if(hashMap.ContainsKey(sortedWord)){
                hashMap[sortedWord].Add(word);
            }
            else{
                hashMap[sortedWord] = new List<string>();
                hashMap[sortedWord].Add(word);
            }
        }
        return hashMap.Values
        .ToList();
    }
}
