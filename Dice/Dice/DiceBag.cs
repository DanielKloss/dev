using System.Collections.Generic;
using System.Linq;

namespace Dice
{
    public class DiceBag
    {
        private readonly List<Dice> _diceBag;

        public DiceBag(List<Dice> diceBag)
        {
            _diceBag = diceBag;
        }

        public void AddDice(Dice newDice)
        {
            _diceBag.Add(newDice);
        }

        public void RemoveDice(Dice diceToRemove)
        {
            _diceBag.Remove(diceToRemove);
        }

        public void RollAll()
        {
            foreach (Dice dice in _diceBag)
            {
                dice.Roll();
            }
        }

        public int SumValues()
        {
            return _diceBag.Sum(dice => dice.Value);
        }
    }
}
