﻿using System.Collections.Generic;
using System.IO;

namespace ReverseMarkdown
{
    public static class StringUtils
    {
        public static string Chomp(this string content)
        {
            return content.Trim().TrimEnd('\r', '\n');
        }

        public static IEnumerable<string> ReadLines(this string content)
        {
            string line;
            using (var sr = new StringReader(content))
                while ((line = sr.ReadLine()) != null)
                    yield return line;
        }
    }
}
