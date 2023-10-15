using System;
using System.Drawing;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace TemaaEGC
{
    internal class Game : GameWindow
    {
        private Vector2 objectPosition;
        private Vector2 mousePosition;

        public Game() : base(800, 600)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.DarkViolet);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            // Momentan aplicația nu face nimic!
            base.OnUpdateFrame(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(Color.MidnightBlue);
            GL.Vertex2(objectPosition + new Vector2(-1.0f, 1.0f));
            GL.Color3(Color.SpringGreen);
            GL.Vertex2(objectPosition + new Vector2(-1.0f, -1.0f));
            GL.Color3(Color.Ivory);
            GL.Vertex2(objectPosition + new Vector2(1.0f, -1.0f));
            GL.Color3(Color.PeachPuff);
            GL.Vertex2(objectPosition + new Vector2(1.0f, 1.0f));

            GL.End();

            this.SwapBuffers();
        }


        protected override void OnKeyDown(KeyboardKeyEventArgs e)
        {
            if (e.Key == Key.A)
            {
                objectPosition.X -= 0.1f;
            }
            else if (e.Key == Key.D)
            {
                objectPosition.X += 0.1f;
            }
            else if(e.Key==Key.W)
            {
                objectPosition.Y += 0.1f;
            }
            else if(e.Key==Key.S)
            {
                objectPosition.Y -= 0.1f;
            }
        }

        protected override void OnMouseMove(MouseMoveEventArgs e)
        {
            // Actualizați poziția mouse-ului
            mousePosition = new Vector2(e.X, e.Y);
        }

        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            if (e.Button == MouseButton.Left)
            {
                     objectPosition = new Vector2(
                    (mousePosition.X / Width) * 10.0f - 5.0f,
                    -((mousePosition.Y / Height) * 10.0f - 5.0f)
                );
            }
        }

        static void Main(string[] args)
        {
            using (Game example = new Game())
            {
                example.Run(30.0, 0.0);
            }
        }
    }
}
