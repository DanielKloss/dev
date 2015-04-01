using System.Collections.Generic;
using System.Linq;

namespace Dice
{
    public class SymbolicDiceFace
    {
        public int Value;
        public string Name;
        public string ImageUrl;

        public SymbolicDiceFace(int value, string name, string imageUrl)
        {
            Value = value;
            Name = name;
            ImageUrl = imageUrl;
        }
    }

    public class SymbolicDice : Dice
    {
        public SymbolicDice(List<SymbolicDiceFace> faces): base(faces)
        {
        }

        public override void Roll()
        {
            if (!Held)
            {
                Value = Random.Next(1, Faces.Count() + 1);
            }
        }

        public string GetSymbolicDiceFace()
        {
            return Faces[Value].Name;
        }
    }
}
