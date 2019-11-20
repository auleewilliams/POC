using System;
using System.Collections.Generic;

namespace TestingStringFunctions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sources = new List<string>();
            sources.Add("MPBJ_WEB");
            sources.Add("INB_TD");
            sources.Add("MPBJ_INBFR");
            sources.Add("POS_PH");
            sources.Add("MPBJ_POSFO");
            sources.Add("OTM_TD");
            sources.Add("MPBJ_DMDEC");
            sources.Add("OZL");

            foreach (var source in sources)
            {
                Console.WriteLine(source);
            }

            var results = ReturnTransformedSources(sources);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        public static List<string> ReturnTransformedSources(List<string> source)
        {
            var listOfStrings = new List<string>();

            foreach (var item in source)
            {
                var transformed = item.Replace("_", string.Empty);

                if (transformed.Length > 5)
                {
                    transformed = transformed.Remove(5);
                }
                
                listOfStrings.Add(transformed);
            }

            return listOfStrings;
        }
    }
}
