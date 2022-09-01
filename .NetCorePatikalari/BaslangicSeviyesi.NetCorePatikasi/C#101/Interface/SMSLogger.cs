using System;

namespace Interface
{
  public class SMSLogger:ILogger
  {
    public void WriteLog()
    {
      Console.WriteLine("SMS olarak log yazar.");
    }
  }
}