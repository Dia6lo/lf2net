﻿using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace LF2Net
{
    class BasicAnimation
    {
        private BasicSpriteAtlas atlas;
        private IEnumerator<int> frames;

        private int delay = 7;
        private int currentTime;

        public Texture2D CurrentFrame
        {
            get
            {
                return atlas[frames.Current];
            }
        }

        public BasicAnimation(BasicSpriteAtlas atlas, IEnumerable<int> frames)
        {
            this.atlas = atlas;
            this.frames = frames.GetEnumerator();
            this.frames.MoveNext();
            ResetAnimation();
        }

        public void Update()
        {
            currentTime++;
            if (currentTime < delay)
                return;
            currentTime = 0;
            if (!frames.MoveNext())
                ResetAnimation();
        }

        void ResetAnimation()
        {
            frames.Reset();
            frames.MoveNext();
        }
    }
}
