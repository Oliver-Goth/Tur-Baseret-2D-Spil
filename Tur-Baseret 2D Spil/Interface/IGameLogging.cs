using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil.Interface
{
    // Interface for logging game events.
    public interface IGameLogging
    {
        // Writes information to the log.
        void WriteInformationToText(string information);

        // Writes a warning to the log.
        void WriteWarningToText(string warning);

        // Writes an error to the log.
        void WriteErrorToText(string error);
    }
}
