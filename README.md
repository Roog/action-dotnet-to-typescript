# GitHub Action dotnet to TypeScript

## Tapper

First, add the following packages to your project. Tapper.Analyzer is optional, but recommended.

```sh
dotnet add package Tapper.Attributes
dotnet add package Tapper.Analyzer (optional, but recommended.)
```

Next, apply the [TranspilationSource] Attribute to the C# type definition.

```c#
using Tapper;

namespace SampleNamespace;

[TranspilationSource] // <- Add attribute!
public class SampleType
{
    public List<int>? List { get; }
    public int Value { get; }
    public Guid Id { get; }
    public DateTime DateTime { get; }
}
```

