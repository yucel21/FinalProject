﻿using log4net.Layout;
using Newtonsoft.Json;
using System.IO;
using log4net.Core;

namespace Core.CrossCuttingConcerns.Logging.Log4Net.Layouts
{
    public class JsonLayout : LayoutSkeleton
    {
        public override void ActivateOptions()
        {

        }

        public override void Format(TextWriter writer, LoggingEvent loggingEvent)
        {
            var logEvent = new SerializableLogEvent(loggingEvent);
            var json = JsonConvert.SerializeObject(logEvent, Formatting.Indented);
            writer.WriteLine(json);
        }
    }
}
