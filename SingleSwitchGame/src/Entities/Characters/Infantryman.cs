﻿using SFML.Window;
using SFML.Graphics;
using System;

namespace SingleSwitchGame
{
    class Infantryman : Character
    {
        public Infantryman(Game Game)
            : base(Game, null)
        {
            Model = new CircleShape(4, 12);
            Model.FillColor = new Color(0, 0, 0, 0);
            Model.OutlineThickness = 2;
            AddChild(Model);
            Origin = new Vector2f(Model.Radius, Model.Radius);

            Collision = Model;

            HealthMax = 4000;
            Health = HealthMax;

            SpeedMax = 100.0f;
            Acc = 400.0f;
            //SpeedMax = 20.0f;
            //Acc = 80.0f;
            Friction = 1000.0f;

            SetAI(new InfantrymanAI());
        }

        public override void Update(float dt)
        {
            base.Update(dt);

            // Animations
        }
    }
}