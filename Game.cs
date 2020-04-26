using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Stardust {
    public class Game : Microsoft.Xna.Framework.Game {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private Map map;
        public static Texture2D t;

        double ups, fps = 0.0;


        public Game() {
            graphics = new GraphicsDeviceManager(this);
            graphics.IsFullScreen = false;

            // Windows actions
            Window.Title = "Stardust!";
            Window.AllowUserResizing = true;
            IsMouseVisible = true;

            Content.RootDirectory = "Content";
            System.Console.Out.WriteLine(this.IsFixedTimeStep);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize() {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent() {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            map = new Map(this.Content);
            t = Content.Load<Texture2D>("0");
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime) {
            Input.GetInput();

            // TODO: Add your update logic here
            map.Update();

            System.Console.Out.WriteLine(1/(gameTime.TotalGameTime.TotalSeconds-ups) + " ups");
            ups = gameTime.TotalGameTime.TotalSeconds;
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin(/*sortMode: SpriteSortMode.Texture, */samplerState: SamplerState.PointClamp, transformMatrix: Matrix.CreateScale(2.0f));
            map.Draw(spriteBatch);
            spriteBatch.End();

            System.Console.Out.WriteLine(1 / (gameTime.TotalGameTime.TotalSeconds - fps) + " fps");
            fps = gameTime.TotalGameTime.TotalSeconds;

            base.Draw(gameTime);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent() {
            // TODO: Unload any non ContentManager content here
        }
    }
}
