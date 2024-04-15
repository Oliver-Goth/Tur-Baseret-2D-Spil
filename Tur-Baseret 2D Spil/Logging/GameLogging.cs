using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Logging
{
    // Implementation of the IGameLogging interface for logging game events.
    public class GameLogging : IGameLogging
    {
        // Trace source for logging.
        private TraceSource traceSource = new TraceSource("Tur-Baseret 2D Spil");

        // Text writer for writing logs to a file.
        private TextWriterTraceListener textWriter;

        // Singleton instance of the GameLogging class.
        private static GameLogging? instance;

        // Singleton pattern implementation to ensure only one instance of GameLogging exists.
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

        // Private constructor to prevent external instantiation.
        private GameLogging()
        {
            // Set the trace switch to log all events.
            traceSource.Switch = new SourceSwitch("GameLogging", "All");

            // Initialize a text writer trace listener to write logs to a file.
            textWriter = new TextWriterTraceListener(new StreamWriter("logOutput.txt") { AutoFlush = true });

            // Add the text writer trace listener to the trace source listeners.
            traceSource.Listeners.Add(textWriter);
        }

        // Writes an error message to the log.
        public void WriteErrorToText(string error)
        {
            traceSource.TraceEvent(TraceEventType.Error, 150, error);
        }

        // Writes an information message to the log.
        public void WriteInformationToText(string writeToTxt)
        {
            traceSource.TraceEvent(TraceEventType.Information, 150, writeToTxt);
        }

        // Writes a warning message to the log.
        public void WriteWarningToText(string warning)
        {
            traceSource.TraceEvent(TraceEventType.Warning, 100, warning);
        }
    }
}
