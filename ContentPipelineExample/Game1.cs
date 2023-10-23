using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ContentPipelineExample
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont _spriteFont;
        private Conversation _convo;
        private double _convoTimer;
        private int _convoLine;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            _spriteFont = Content.Load<SpriteFont>("Arial");
            _convo = Content.Load<Conversation>("dialog");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            _convoTimer += gameTime.ElapsedGameTime.TotalSeconds;

            // Advance the conversation every 3 seconds
            if (_convoTimer > 3)
            {
                _convoLine++;
                _convoTimer -= 3;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            if (_convoLine < _convo.Lines.Length)
            {
                _spriteBatch.Begin();
                _spriteBatch.DrawString(_spriteFont, _convo.Lines[_convoLine].Text, new Vector2(200, 200), Color.White);
                _spriteBatch.End();
            }

            base.Draw(gameTime);
        }
    }
}