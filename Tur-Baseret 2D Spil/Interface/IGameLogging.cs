﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil.Interface
{
    public interface IGameLogging
    {
        void WriteInformationToText(string informaton);
        void WriteWarningToText(string warning);
        void WriteErrorToText(string error);
    }
}