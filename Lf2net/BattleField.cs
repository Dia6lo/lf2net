﻿using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LF2Net
{
	public class BattleField
	{
		private List<Character> characters = new List<Character>();
		private List<Player> players = new List<Player>(); 
		private Texture2D floor;

		public Rectangle Bounds
		{
			get { return floor.Bounds; }
		}

		public int Width
		{
			get { return floor.Width; }
		}

		public int Height
		{
			get { return floor.Height; }
		}

		public BattleField(Texture2D floor)
		{
			this.floor = floor;
		}

		public void AddCharacter(Character character)
		{
			characters.Add(character);
			character.BattleField = this;
		}

		public void AddPlayer(Player player)
		{
			players.Add(player);
		}

		public void Update()
		{
			foreach (var player in players)
			{
				player.HandleControls();
			}
			foreach (var character in characters)
			{
				character.Update();
			}
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			var floorOrigin = new Vector2(0, spriteBatch.GraphicsDevice.Viewport.Height - Height);
			spriteBatch.Begin();
			spriteBatch.Draw(floor, floorOrigin);
			spriteBatch.End();
			foreach (var character in characters)
			{
				character.Draw(spriteBatch, floorOrigin);
			}
		}
	}
}
