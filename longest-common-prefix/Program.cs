namespace longest_common_prefix
{

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "") return "";
                }
            }
            return prefix;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            
            string[][] testCases = {
            new string[] { "flower", "flow", "flight" },
            new string[] { "dog", "racecar", "car" },
            new string[] { "interspecies", "interstellar", "interstate" },
            new string[] { "prefix", "prequel", "preference" },
            new string[] { "single" }
        };

            foreach (var strs in testCases)
            {
                string result = solution.LongestCommonPrefix(strs);
                Console.WriteLine($"The longest common prefix is: \"{result}\"");
            }
        }
    }
}
