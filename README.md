# Bencmarks

|                                 Method |      Mean |     Error |    StdDev |   Gen0 | Allocated |
|--------------------------------------- |----------:|----------:|----------:|-------:|----------:|
|  DefaultLogger_Logging_EnabledLogLevel | 72.925 ns | 0.7541 ns | 0.7054 ns | 0.0172 |      72 B |
| DefaultLogger_Logging_DisabledLogLevel | 70.691 ns | 1.1044 ns | 1.0847 ns | 0.0172 |      72 B |
|      SourceGen_Logging_EnabledLogLevel | 22.585 ns | 0.3362 ns | 0.3145 ns |      - |         - |
|     SourceGen_Logging_DisabledLogLevel |  3.292 ns | 0.0460 ns | 0.0431 ns |      - |         - |
