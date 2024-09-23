using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

using XNA_RPG_textMapEditor.Scene;
using XNA_RPG_textMapEditor.Enemy;
using XNA_RPG_textMapEditor.Core;
using XNA_RPG_textMapEditor.Helper;
using XNA_RPG_textMapEditor.Controller;
using XNA_RPG_textMapEditor.Level.World1;
///
/// XNA_RPG textMapEditor engine duoc viet boi HuyetSat - Xvna.forumb.biz
/// Moi cap nhat hay thac mac � kien ve engine xin li�n he tai: xvna.forumb.biz hoac thanh_vinh648@yahoo.com
/// Engine ho�n to�n free v� n� cho ph�p c�c ban ph�t trien RPG mot c�ch de d�ng!
/// Yeu cau ghi ro~ nguon goc engine va tac gia khi ban phat trien game ca nhan bang engine nay!
/// Ch�n th�nh cam on ban d� quan t�m su dung engine n�y!
///
namespace XNA_RPG_textMapEditor
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class Bar : Microsoft.Xna.Framework.DrawableGameComponent
    {
        Rectangle source = new Rectangle(0, 0, 300, 20);
        public string Label;
        public Vector2 Position;
        public Texture2D live, lost;
        public int remain, Max;
        //service:
        SpriteBatch sBatch;

        public Bar(Game game,Texture2D live,Texture2D lost,String lb)
            : base(game)
        {
            this.Label = lb;
            this.live = live;
            this.lost = lost;
            // lay services tu` RPG game
            sBatch = (SpriteBatch)Game.Services.GetService(typeof(SpriteBatch)) as SpriteBatch;
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            

            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
          
            sBatch.Draw(lost, Position, source, Color.White);
            sBatch.Draw(live, Position, new Rectangle(0,0,300*(int)remain/Max,20), Color.White);
            base.Draw(gameTime);
        }
    }
}