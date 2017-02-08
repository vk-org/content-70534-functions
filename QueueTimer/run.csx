using System;

public static void Run(TimerInfo myTimer, out string outputQueueItem, TraceWriter log)
{
    log.Info($"C# Timer trigger function executed at: {DateTime.Now}");
    outputQueueItem = $"Message added {DateTime.Now.ToString("s")}";
}