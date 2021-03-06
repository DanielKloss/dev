﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabeticalOrderChecker
{
    public class AlphabeticalOrder
    {
        private AlphabeticalOrder(string value)
        {
            Value = value;
        }
        public string Value { get; set; }

        public static AlphabeticalOrder InOrder { get { return new AlphabeticalOrder("In Order"); } }
        public static AlphabeticalOrder NotInOrder { get { return new AlphabeticalOrder("Not In Order"); } }
        public static AlphabeticalOrder ReverseOrder { get { return new AlphabeticalOrder("Reverse Order"); } }
    }

    public static class Checker
    {
        public static AlphabeticalOrder CheckWord(string input)
        {
            if (String.Concat(input.ToCharArray().OrderByDescending(c => c)) == input)
            {
                return AlphabeticalOrder.ReverseOrder;
            }
            else if (String.Concat(input.ToCharArray().OrderBy(c => c)) == input)
            {
                return AlphabeticalOrder.InOrder;
            }
            else
            {
                return AlphabeticalOrder.NotInOrder;
            };
        }
    }
}
