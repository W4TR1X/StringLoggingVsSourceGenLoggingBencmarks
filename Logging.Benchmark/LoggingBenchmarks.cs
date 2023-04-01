using BenchmarkDotNet.Attributes;
using Logging.Benchmark;
using Microsoft.Extensions.Logging;

namespace Logging.Benchmarks;

[MemoryDiagnoser]
public class LoggingBenchmarks
{
    ILogger<LoggingBenchmarks> _logger;
    ILoggerFactory _factory;

    public LoggingBenchmarks()
    {
        _factory = LoggerFactory.Create(config =>
        {
            //config.AddConsole();
            config.SetMinimumLevel(LogLevel.Warning);
        });

        _logger = _factory.CreateLogger<LoggingBenchmarks>();
    }

    [Benchmark]
    public void DefaultLogger_Logging_EnabledLogLevel()
    {
        _logger.LogWarning("Send warning message to {Id}:{Name} {Surname}", 123, "John", "Doe");
    }

    [Benchmark]
    public void DefaultLogger_Logging_DisabledLogLevel()
    {
        _logger.LogInformation("Send info message to {Id}:{Name} {Surname}", 123, "John", "Doe");
    }

    [Benchmark]
    public void SourceGen_Logging_EnabledLogLevel()
    {
        _logger.SendWarningMessage(123, "John", "Doe");
    }

    [Benchmark]
    public void SourceGen_Logging_DisabledLogLevel()
    {
        _logger.SendInfoMessage(123, "John", "Doe");
    }
}
