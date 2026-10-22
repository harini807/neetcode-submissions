public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> hashMap = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++){
            if(hashMap.ContainsKey(nums[i])){
                hashMap[nums[i]]++;
            }
            else{
                hashMap[nums[i]] = 1;
            }
        }
        var sorted = hashMap.OrderByDescending(x => x.Value).ToList();

        // 3. Take the top k numbers
        int[] result = sorted.Take(k).Select(x => x.Key).ToArray();

        return result;
    }
}
