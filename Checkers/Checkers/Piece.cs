
namespace Checkers
{
    public class Piece
    {
        public string colour { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public bool kinged { get; set; }

        public Piece(int X, int Y, string Colour)
        {
            colour = Colour;
            x = X;
            y = Y;
        }
    }
}
