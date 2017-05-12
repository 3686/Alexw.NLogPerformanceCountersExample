using System.Timers;
using NLog;

namespace Alexw.NLogPerformanceCounters.ExampleService
{
    public class Service
    {
        readonly Timer _timer;
        private readonly ILogger _logger = LogManager.GetCurrentClassLogger();
        public Service()
        {
            _timer = new Timer(1000) { AutoReset = true };
            _timer.Elapsed += (sender, eventArgs) => _logger.Info("This is an info log message");
        }
        public void Start() { _timer.Start(); }
        public void Stop() { _timer.Stop(); }
    }
}
