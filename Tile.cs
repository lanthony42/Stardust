using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Stardust {
    class Tile : Entity {
        
        public Tile(ContentManager content, Vector2 position, string text) {
            texture = content.Load<Texture2D>(text);
            this.position = position;
        }
    }
}
