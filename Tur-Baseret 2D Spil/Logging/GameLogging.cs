using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Logging
{
    public class GameLogging : IGameLogging
    {
        private TraceSource traceSource = new TraceSource("Game Library");
        private TextWriterTraceListener textWriter;

        private static GameLogging? instance;

        public static GameLogging Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameLogging();
                }
                return instance;
            }
        }

        private GameLogging()
        {
            traceSource.Switch = new SourceSwitch("GameLogging", "All");
            textWriter = new TextWriterTraceListener(new StreamWriter("logOutput.txt") { AutoFlush = true });
            traceSource.Listeners.Add(textWriter);
        }

        public void WriteErrorToText(string error)
        {
            traceSource.TraceEvent(TraceEventType.Error, 150, error);
        }

        public void WriteInformationToText(string writeToTxt)
        {
            traceSource.TraceEvent(TraceEventType.Information, 150, writeToTxt);
        }

        public void WriteWarningToText(string warning)
        {
            traceSource.TraceEvent(TraceEventType.Warning, 100, warning);
        }
    }
}
