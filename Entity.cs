using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Stardust {
    class Entity {
        protected Texture2D texture;
        protected Vector2 position;

        public void Update() {
            position.X += 0.1f;
        }
        public void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
