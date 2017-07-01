﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox.ModAPI.Ingame
{
    public interface IMyProductionBlock
    {
        bool IsProducing { get; }
        event Action StartedProducing;
        event Action StoppedProducing;
        //bool CanUseBlueprint(Sandbox.Definitions.MyBlueprintDefinition blueprint);
        //void InsertQueueItemRequest(int idx, Sandbox.Definitions.MyBlueprintDefinition blueprint);
        //void InsertQueueItemRequest(int idx, Sandbox.Definitions.MyBlueprintDefinition blueprint, VRage.MyFixedPoint amount);
        bool IsQueueEmpty { get; }
        void MoveQueueItemRequest(uint queueItemId, int targetIdx);
        uint NextItemId { get; }
        //event Action<IMyProductionBlock> QueueChanged;
        void RemoveQueueItemRequest(int itemIdx);
    }
}
