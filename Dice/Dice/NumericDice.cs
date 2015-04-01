namespace Dice
{
    public class NumericDice : Dice
    {
        public NumericDice(int sides) : base(sides)
        {
        }

        public override void Roll()
        {
            if (!Held)
            {
                Value = Random.Next(1, Sides + 1);
            }
        }
    }
}
