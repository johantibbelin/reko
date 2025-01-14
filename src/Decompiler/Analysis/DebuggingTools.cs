#region License
/* 
 * Copyright (C) 1999-2023 John Källén.
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2, or (at your option)
 * any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; see the file COPYING.  If not, write to
 * the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
 */
#endregion

using Reko.Core;
using Reko.Core.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reko.Analysis
{
    public class DebuggingTools
    {
        private readonly Program program;
        private readonly IServiceProvider services;
        private readonly Dictionary<string, int> phaseNumbering;

        public DebuggingTools(Program program, IServiceProvider services)
        { 
            this.program = program;
            this.services = services;
            this.phaseNumbering = new Dictionary<string, int>();
        }

        [Conditional("DEBUG")]
        public void DumpWatchedProcedure(string phase, string caption, Procedure proc)
        {
            if (program.User.DebugTraceProcedures.Contains(proc.Name) ||
                proc.Name == "usb_device_info" ||
                proc.Name == "fn0002466C" ||
                proc.Name == "PM_CUSOR_DRAW_CreateSurfaceAndImgDecoding" ||
                false)
            {
                Debug.Print("// {0}: {1} ==================", proc.Name, caption);
                //MockGenerator.DumpMethod(proc);
                proc.Dump(true);
                var testSvc = services.GetService<ITestGenerationService>();
                if (testSvc is { })
                {
                    if (!this.phaseNumbering.TryGetValue(phase, out int n))
                    {
                        n = phaseNumbering.Count + 1;
                        phaseNumbering.Add(phase, n);
                    }
                    testSvc.ReportProcedure($"analysis_{n:00}_{phase}.txt", $"// {proc.Name} ===========", proc);
                }
            }
        }
    }
}
