﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    partial class Program
    {
        public void TacheLongueBloquante_TaskDelay(int dureeMs = 3000)
        {
            TimeLog("Begin - tache");

            Task.Delay(dureeMs);

            TimeLog("End - tache");
        }

        [InMenu]
        public void Exec_TacheLongueBloquante_TaskDelay()
        {
            TimeLog("Begin - caller");

            TacheLongueBloquante_TaskDelay();

            TimeLog("End - caller");
        }
    }
}