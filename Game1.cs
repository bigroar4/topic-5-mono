using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace topic_5_mono
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        Texture2D onepieceintro, luffybody, luffyoutro,luffysecond, luffyhand;
        Rectangle luffyhandrect, luffybodyrect,luffysecondrect;
        Vector2 luffyhandspeed , luffybodyspeed, luffysecondspeed; 
        SpriteFont font;

        Texture2D LuffyIntro;

        MouseState MouseState;

        Random Number;

        Rectangle introluffy;
        enum Screen
        {
            Intro,
            LuffyScreen
        }
        Screen screen;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            screen = Screen.Intro;

            introluffy = new Rectangle(0, 0,_graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight);
            luffyoutro = new Rectangle(0, 0, _graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight);
            luffyhandrect = new Rectangle(300,0,100,100);
            luffyhandspeed = new Vector2(3, 3);
            luffybodyrect = new Rectangle(300, 100, 50, 50);
            luffybodyspeed = new Vector2(0, 0);
            luffysecondrect = new Rectangle(400,300,100,100);
            luffysecondspeed = new Vector2(0,0);


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            onepieceintro = Content.Load<Texture2D>("onepieceintro");
            luffyoutro = Content.Load<Texture2D>("onepieceoutro");
            luffysecond = Content.Load<Texture2D>("luffysecondgood");
            luffybody = Content.Load<Texture2D>("luffybody");
            luffyhand = Content.Load<Texture2D>("luffyhand");





            font = Content.Load<SpriteFont>("fontwords");




            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            MouseState = Mouse.GetState();






            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            if (screen == Screen.Intro)
            {
                _spriteBatch.Draw(onepieceintro, introluffy, Color.White);
                _spriteBatch.DrawString(font, "left click to get punched ", new Vector2(30, 20), Color.Black);
            }
            else
            {

                Number.Next(1, 51);
            }









            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}