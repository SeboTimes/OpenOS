using System;

using Sys = Cosmos.System;

using OpenOS.Source;

namespace OpenOS
{
    public class Kernel : Sys.Kernel
    {
        Shell shell;

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
