public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> s1 = new Dictionary<char, int>();
        Dictionary<char, int> s2 = new Dictionary<char, int>();

        foreach (char c in s) {
            s1[c] = s1.GetValueOrDefault(c, 0) + 1;
        }
        foreach (char c in t) {
            s2[c] = s2.GetValueOrDefault(c, 0) + 1;
        }

        foreach (KeyValuePair<char, int> entry in s1) {
            if (!s2.ContainsKey(entry.Key) || !Equals(entry.Value, s2[entry.Key])) {
                return false;
            }
        }

        return true;
    }
}