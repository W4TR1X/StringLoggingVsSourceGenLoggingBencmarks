using BenchmarkDotNet.Running;
using Logging.Benchmarks;

//var lb = new LoggingBenchmarks();

//lb.DefaultLogger_Logging_DisabledLogLevel(); // Loglevel yüzünden devredışı
//lb.DefaultLogger_Logging_EnabledLogLevel();

//lb.SourceGen_Logging_DisabledLogLevel(); // Loglevel yüzünden devredışı
//lb.SourceGen_Logging_EnabledLogLevel();

BenchmarkRunner.Run<LoggingBenchmarks>();