using Microsoft.Xna.Framework.Input;

namespace Stardust {
    static class Input {

        // Holds current input state
        private static KeyboardState keyboard;
        private static MouseState mouse;

        // Holds old input state
        private static KeyboardState oldKeyboard;
        private static MouseState oldMouse;

        /// <summary>
        /// Saves old state and polls for new input.
        /// </summary>
        public static void GetInput() {
            oldKeyboard = keyboard;
            oldMouse = mouse;

            keyboard = Keyboard.GetState();
            mouse = Mouse.GetState();
        }

        /// <summary>
        /// Checks if the key has just been pressed.
        /// </summary>
        /// <param name="key">Key to check.</param>
        public static bool OnPressed(Keys key) {
            return oldKeyboard.IsKeyUp(key) && keyboard.IsKeyDown(key);
        }
    }
}
