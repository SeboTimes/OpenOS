using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

using OpenOS.Source.ShellMode;

namespace OpenOS
{
    public class Kernel : Sys.Kernel
    {
        private Shell shell;

        protected override void BeforeRun()
        {
            shell = new Shell();
        }

        protected override void Run()
        {
            shell.handleInput();
        }
    }
}
