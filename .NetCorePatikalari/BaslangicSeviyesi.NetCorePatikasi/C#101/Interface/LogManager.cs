using System;

namespace Interface
{
  public class LogManager:ILogger
  {
    public ILogger logger;

    public LogManager(ILogger logger)
    {
      this.logger = logger;
    }

    public void WriteLog()
    {
      logger.WriteLog();
    }
  }
}