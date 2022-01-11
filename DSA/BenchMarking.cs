using BenchmarkDotNet.Attributes;

using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class BenchMarking
    {
        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public string StringConcat(string original, string tag)
        {
            original = original + tag;
            return original;
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public string StringIncrement(string original, string tag)
        {
            original += tag;
            return original;
        }

        public IEnumerable<object[]> Data()
        {
            yield return new object[] { "Hari", "Krishna" };
        }
    }
}
