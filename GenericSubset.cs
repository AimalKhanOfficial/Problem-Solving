public class GenericSubset<T>
    {
        public List<T> FindAllPossibleCombinations<T>(T alphabet)
        {
            char[] list = alphabet.ToString().ToCharArray();
            List<T> superSet = new List<T>();
            var res = "";
            for (var i = 0; i < list.Length; i++)
            {
                superSet.Add((T)Convert.ChangeType(list[i], typeof(T)));
                res += list[i];
                if (i + 1 == list.Length) break;
                for (var j = i + 1; j < list.Length; j++)
                {
                    superSet.Add((T)Convert.ChangeType(list[i] + "" + list[j], typeof(T)));
                }
            }
            superSet.Add((T)Convert.ChangeType(res, typeof(T)));
            return superSet;
        }

        public List<T> FindAllPossibleCombinations<T>(T[] list)
        {
            List<T> superSet = new List<T>();
            var res = "";
            for (var i = 0; i < list.Length; i++)
            {
                superSet.Add(list[i]);
                res += list[i];
                if (i + 1 == list.Length) break;
                for (var j = i + 1; j < list.Length; j++)
                {
                    superSet.Add((T)Convert.ChangeType(list[i] + "" + list[j], typeof(T)));
                }
            }
            superSet.Add((T)Convert.ChangeType(res, typeof(T)));
            return superSet;
        }

        //public static List<int> FindAllPossibleCombinations(int[] list)
        //{
        //    List<int> superSet = new List<int>();
        //    superSet.Add(0);
        //    superSet.AddRange(list);
        //    for (var i = 0; i < list.Length; i++)
        //    {
        //        if (i + 1 == list.Length) break; 
        //        for (var j = i + 1; j < list.Length; j++)
        //        {
        //            superSet.Add(Convert.ToInt32(list.GetValue(i) + "" + list.GetValue(j)));
        //        }
        //    }
        //    var result = string.Join("", list.Select(a => a.ToString()).ToArray());
        //    superSet.Add(Convert.ToInt32(result));
        //    return superSet;
        //}
    }