﻿using System.Collections.Generic;
using java.util;

namespace JavaToCSharp
{
    public static class IKVMHelpers
    {
        public static List<T> ToList<T>(this java.util.List list)
        {
            if (list == null)
                return null;

            var newList = new List<T>();

            for (int i = 0; i < list.size(); i++)
            {
                newList.Add((T)list.get(i));
            }

            return newList;
        }

        public static IEnumerable<T> AsEnumerable<T>(this java.util.List list)
        {
            if (list == null)
                yield break;

            for (int i = 0; i < list.size(); i++)
            {
                yield return (T)list.get(i);
            }
        }

        public static bool HasFlag(this int value, int flag)
        {
            return (value & flag) != 0;
        }

        public static bool HasFlag<T>(this EnumSet values, T flag)
        {
            return values.contains(flag);
        }
    }
}
