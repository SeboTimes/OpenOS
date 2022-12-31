using System;
using System.Collections.Generic;

using Sys = Cosmos.System;
using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;

namespace OpenOS.Source
{
    internal class FS
    {
        public FS()
        {
            CosmosVFS fs = new CosmosVFS();
            VFSManager.RegisterVFS(fs);

            List<Disk> disks = fs.GetDisks();
            
            foreach (Disk disk in disks)
            {
                disk.DisplayInformation();
            }
        }
    }
}
