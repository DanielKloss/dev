using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Domain
{
    public class Day4
    {
        public long MineAdventCoins(string key, int numberOfZeros)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                long count = 0;
                string stringToConvert = key + count;

                while (!ConvertToMD5(md5Hash, stringToConvert, numberOfZeros))
                {
                    count++;
                    stringToConvert = key + count;
                }
                return count;
            }
        }

        private bool ConvertToMD5(MD5 md5, string stringToConvert, int numberOfZeros)
        {
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(stringToConvert));

            long half = numberOfZeros / 2;
            //  first, check the whole bytes.
            for (int i = 0; i < half; i++)
                if (data[i] != 0)
                    return false;

            // do we need another half a byte?
            if (numberOfZeros % 2 == 1)
            {
                if (data[half] > 0x0f)
                    return false;
            }
            return true;
        }
    }
}
