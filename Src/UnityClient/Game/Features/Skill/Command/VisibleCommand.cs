﻿using System;
using ScriptableData;
using ScriptableSystem;

namespace SkillCommands
{
    internal class VisibleCommand : AbstractCommand
    {
        protected override void Load(CallData callData)
        {
            int num = callData.GetParamNum();
            if(num > 0)
            {
                m_Visible = bool.Parse(callData.GetParamId(0));
            }
        }
        protected override ExecResult ExecCommand(Instance instance, long delta)
        {
            GameEntity obj = instance.Target as GameEntity;
            if (null == obj)
                return ExecResult.Finished;
            if (!obj.hasView)
                return ExecResult.Finished;

            obj.view.Value.SetVisible(m_Visible);

            return ExecResult.Finished;
        }

        private bool m_Visible = true;
    }
}
