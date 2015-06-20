﻿using Microsoft.Xna.Framework;

namespace Lf2datConverter.dat.Convenient
{
    class HealBall: Interaction, IDamagingInteraction, IMovementProducingElement
    {
        public int Injury { get; set; }
        public Vector3 VelocityDelta { get; set; }
    }
}
