﻿namespace Marscore.Index.Core.Sync.SyncTasks
{
   public interface IBlockableItem
   {
      bool Blocked { get; set; }

      void Deplete();
   }
}
