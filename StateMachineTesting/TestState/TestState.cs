﻿
using StateMachineCore;

namespace StateMachineTesting
{
    public class TestState : State
    {
        public int UpdateIterations { get; protected set; }
        public int StartIterations { get; protected set; }
        public int EndIterations { get; protected set; }

        protected override void UpdateState() => ++UpdateIterations;

        public override void Start() => ++StartIterations;

        public override void End() => ++EndIterations;
    }
}
