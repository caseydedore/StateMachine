﻿
using StateMachineCore;
using System.Collections.Generic;

namespace StateMachineTesting
{
    public class TestBlackboard : Blackboard
    {
        public new Dictionary<string, object> Values => base.Values;
    }
}