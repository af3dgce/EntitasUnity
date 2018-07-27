﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityDelegate;
using Entitas.Data;
using Util;

namespace UnityClient
{
    public sealed class UnityViewService : Service, IViewService
    {
        public UnityViewService(Contexts contexts): base(contexts)
        {
        }
        public void LoadAsset(GameEntity entity, uint resId, string asset)
        {
            var viewObject = ResourceSystem.NewObject(asset) as GameObject;
            if(null != viewObject)
            {
                var rigidbody = viewObject.GetComponent<IRigidbody>();
                if (null != rigidbody)
                    entity.AddPhysics(rigidbody, Vector3.zero);

                var view = viewObject.GetComponent<IView>();
                if(null != view)
                {
                    // add view;
                    entity.AddView(view);
                }
            }
            else
            {
                LogUtil.Error("GfxMoudle.Instantiate new object failed. Resource path is {0}.", asset);
            }
        }
        public void PlayAnimation(GameEntity entity, string animName)
        {
            if(entity.hasView)
                entity.view.Value.PlayAnimation(animName);
        }
        public void CrossFadeAnimation(GameEntity entity, string animName, float fadeLength = 0.3f)
        {
            if(entity.hasView)
                entity.view.Value.CrossFadeAnimation(animName, 0.3f);
        }
    }
}