#region License
/* 
 * Copyright (C) 1999-2022 John Källén.
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

using Dock.Model.ReactiveUI.Controls;
using Reko.Core;
using Reko.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reko.UserInterfaces.AvaloniaUI.ViewModels.Documents
{
    public class ImageSegmentViewModel : Document, IWindowPane
    {
        public ImageSegmentViewModel(ImageSegment segment, Program program)
        {
            this.Segment = segment;
            this.Program = program;
        }

        public IWindowFrame? Frame { get; set; }


        public Program Program { get; }

        public ImageSegment Segment { get; }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public object CreateControl()
        {
            throw new NotImplementedException();
        }

        public void SetSite(IServiceProvider services)
        {
            throw new NotImplementedException();
        }
    }
}