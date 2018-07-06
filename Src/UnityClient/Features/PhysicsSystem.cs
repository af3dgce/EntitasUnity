﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entitas;
using Entitas.Component;

namespace UnityClient
{
    public class PhysicsSystem : IInitializeSystem, IExecuteSystem
    {
        public PhysicsSystem(Contexts contexts)
        {
            m_Context = contexts.game;
            m_World = new Jitter.World(new Jitter.Collision.CollisionSystemSAP());
        }
        public void Initialize()
        {

            m_Context.GetGroup(GameMatcher.Physics).OnEntityAdded += PhysicsSystem_OnEntityAdded;
            m_Context.GetGroup(GameMatcher.Physics).OnEntityRemoved += PhysicsSystem_OnEntityRemoved;

            Jitter.Collision.Shapes.BoxShape shape = new Jitter.Collision.Shapes.BoxShape(new Util.Vector3(300, 1, 300));
            Jitter.Dynamics.RigidBody rigid = new Jitter.Dynamics.RigidBody(shape);
            rigid.Position = new Util.Vector3(0, -1.5f, 0);
            rigid.LinearVelocity = Util.Vector3.zero;
            rigid.IsStatic = true;
            rigid.Tag = false;
            m_World.AddBody(rigid);
        }

        public void Execute()
        {
            m_World.Step(m_Context.timeInfo.DeltaTime, false);
        }

        private void PhysicsSystem_OnEntityAdded(IGroup<GameEntity> group, GameEntity entity, int index, IComponent component)
        {
            PhysicsComponent physics = component as PhysicsComponent;
            if(null != physics)
            {
                m_World.AddBody(physics.Rigid);
            }
        }
        private void PhysicsSystem_OnEntityRemoved(IGroup<GameEntity> group, GameEntity entity, int index, IComponent component)
        {
            throw new NotImplementedException();
        }

        private readonly GameContext m_Context;

        private readonly Jitter.World m_World;
    }
}
