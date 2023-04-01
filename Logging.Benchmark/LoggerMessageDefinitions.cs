using Microsoft.Extensions.Logging;

namespace Logging.Benchmark;

public static partial class LoggerMessageDefinitions
{
    [LoggerMessage(EventId = 1000, Level = LogLevel.Information, Message = "Send info message to {Id}:{Name} {Surname}")]
    public static partial void SendInfoMessage(this ILogger logger, int id, string name, string surname);

    // SkipEnabledCheck = true kullanımı sourcegen kod üretiminde logger.IsEnabled(LogLevel) kontrolünü kaldırır
    // Level kesinlikle kullanılacaksa kullanılmalı. Örnek: Warning, Error
    [LoggerMessage(EventId = 1001, Level = LogLevel.Warning, Message = "Send warning message to {Id}:{Name} {Surname}", SkipEnabledCheck = true)]
    public static partial void SendWarningMessage(this ILogger logger, int id, string name, string surname);
}
