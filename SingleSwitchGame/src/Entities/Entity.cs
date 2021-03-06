﻿using System;
using SFML.Graphics;
using SFML.Window;

namespace SingleSwitchGame
{
    class Entity : DisplayObject
    {
        protected Game Game;
        public dynamic Model;

        public Entity(Game Game, dynamic model = null)
        {
            this.Game = Game;

            if (model != null)
            {
                Model = model;
                AddChild(Model);
            }
            
            Init();
        }
        public virtual void Init()
        {
            Game.AddToUpdateList(this);
        }
        public virtual void Deinit()
        {
            Game.RemoveFromUpdateList(this);
        }

        public override void OnRemoved()
        {
            base.OnRemoved();
            Deinit();
        }

        public virtual void Update(float dt) { }
        
    }
}
