using System;
using Tapper;

namespace text_poc
{
    [TranspilationSource]
    public class EmptyClass
	{
        public List<int>? List { get; }
        public int Value { get; }
        public Guid Id { get; }
        public DateTime DateTime { get; }

        public EmptyClass()
		{

		}
	}
}

