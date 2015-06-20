﻿using Microsoft.Xna.Framework;

namespace Lf2datConverter.dat.Convenient
{
    class ReflectiveShield: Interaction, IHittableInteraction, IDamagingInteraction, IMovementProducingElement
    {
        public int Fall;
        public int VRest { get; set; }
        public int Injury { get; set; }
        public Vector3 VelocityDelta { get; set; }
    }
}
