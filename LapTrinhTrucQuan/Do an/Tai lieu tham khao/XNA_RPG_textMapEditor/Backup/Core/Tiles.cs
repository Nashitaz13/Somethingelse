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

using XNA_RPG_textMapEditor.Controller;
using XNA_RPG_textMapEditor.Helper;
///
/// XNA_RPG textMapEditor engine duoc viet boi HuyetSat - Xvna.forumb.biz
/// Moi cap nhat hay thac mac � kien ve engine xin li�n he tai: xvna.forumb.biz hoac thanh_vinh648@yahoo.com
/// Engine ho�n to�n free v� n� cho ph�p c�c ban ph�t trien RPG mot c�ch de d�ng!
/// Yeu cau ghi ro~ nguon goc engine va tac gia khi ban phat trien game ca nhan bang engine nay!
/// Ch�n th�nh cam an ban d� quan t�m su dung engine n�y!
///
namespace XNA_RPG_textMapEditor.Core
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class Tiles : Microsoft.Xna.Framework.DrawableGameComponent
    {
        //co nhieu` texture khac nhau cho tile khac nhau
        List<Texture2D> texture;
        public Vector2 Position { get; set; }
        public Rectangle Rec { get; set; }
        SpriteBatch sBatch;
        int active = 0;
        public Tiles(Game game,List<Texture2D> text)
            : base(game)
        {
            sBatch = (SpriteBatch)Game.Services.GetService(typeof(SpriteBatch));
            texture = text;
            //lay ngau nhien tile
            active = RDHelper.GetRandomInt(texture.Count - 1);
            // TODO: Construct any child components here
        }
        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {

            Rec = new Rectangle((int)Position.X, (int)Position.Y, 50, 50);

            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here

            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            
            //draw tile
            sBatch.Draw(texture[active], Rec, Color.White);
            base.Draw(gameTime);
        }
    }
}