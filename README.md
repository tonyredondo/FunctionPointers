# FunctionPointers
FunctionPointers as common delegates replacement


### Benchmark between Action delegate and ActionPointer struct

```ini
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.630 (2004/?/20H1)
Intel Core i7-1068NG7 CPU 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
```
|                   Method |        Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |------------:|----------:|----------:|-------:|------:|------:|----------:|
|        CreateNewDelegate | 226.3956 ns | 1.0971 ns | 0.9161 ns | 0.0153 |     - |     - |      64 B |
|   CreateNewActionPointer |  15.1463 ns | 0.0810 ns | 0.0758 ns |      - |     - |     - |         - |
|        DelegateBenchmark |   1.7033 ns | 0.0221 ns | 0.0207 ns |      - |     - |     - |         - |
| FunctionPointerBenchmark |   0.8401 ns | 0.0106 ns | 0.0099 ns |      - |     - |     - |         - |


### Benchmark between Action{object} delegate and ActionPointer{object} struct

```
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.630 (2004/?/20H1)
Intel Core i7-1068NG7 CPU 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
```

|                   Method |        Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |------------:|----------:|----------:|-------:|------:|------:|----------:|
|        CreateNewDelegate | 294.1316 ns | 0.8335 ns | 0.7389 ns | 0.0153 |     - |     - |      64 B |
|   CreateNewActionPointer |  15.3587 ns | 0.0804 ns | 0.0752 ns |      - |     - |     - |         - |
|        DelegateBenchmark |   1.4036 ns | 0.0062 ns | 0.0049 ns |      - |     - |     - |         - |
| FunctionPointerBenchmark |   0.8367 ns | 0.0125 ns | 0.0111 ns |      - |     - |     - |         - |
