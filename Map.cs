using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics;

using System.Collections.Generic;

namespace Stardust {

    class Map {
        private const int MAP_WIDTH = 768;
        private const int MAP_HEIGHT = 160;

        private Tile[,] world;

        // Flyweight magics



        public Map(ContentManager content) {
            world = new Tile[MAP_WIDTH, MAP_HEIGHT];

            for(int x = 0; x < MAP_WIDTH; ++x) {
                for (int y = 0; y < MAP_HEIGHT; ++y) {
                    world[x, y] = new Tile(content, new Vector2(x * 16, y * 16), x==0?"2":"0");
                }
            }
        }

        public Tile[] getTiles(Rectangle rectangle) {
            List<Tile> list = new List<Tile>();
            

            return list.ToArray(); ;
        }


        public void Update() {
            for (int x = 0; x < MAP_WIDTH; ++x) {
                for (int y = 0; y < MAP_HEIGHT; ++y) {
                    world[x, y].Update();
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch) {
            for (int x = 0; x < MAP_WIDTH; ++x) {
                for (int y = 0; y < MAP_HEIGHT; ++y) {
                    world[x, y].Draw(spriteBatch);
                    //spriteBatch.Draw(Game.t, new Vector2(x * 16, y * 16), Color.White);
                }
            }
        }
    }
}
