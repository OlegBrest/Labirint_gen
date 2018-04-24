using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint_gen
{
    class Randomizer
    {
        string[] seed;
        Random[] rnd_array;

        // constructor
        public Randomizer(string sd)
        {
            seeding(sd);
        }

        //fill array by seed
        public void seeding(string sd)
        {
            int array_lenght = (int)Math.Ceiling((double)sd.Length / 4.0);
            if (array_lenght > 0)
            {
                this.rnd_array = new Random[array_lenght];
                this.seed = new string[array_lenght];
                int curr_arr = 0;
                for (int i = 0; i < sd.Length; i += 4)
                {
                    this.seed[curr_arr] = sd.Substring(i, (sd.Length - i) >= 4 ? 4 : sd.Length - i);
                    curr_arr++;
                }
                for (int i = 0; i < array_lenght; i++)
                {
                    this.rnd_array[i] = new Random(StrToInt(this.seed[i]));
                }
            }
            else
            {
                this.rnd_array = new Random[1];
                this.rnd_array[0] = new Random();
            }
        }

        // convert string value to integer
        public int StrToInt(string str)
        {
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                result += (int)(((char)str[i]) * Math.Pow(2, i*8));
            }
            return result;
        }

        // getting int from array randoms
        public int NextInt(int max_value)
        {
            int lenght = this.rnd_array.Length;
            int[] result = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                result[i] = this.rnd_array[i].Next(max_value);
            }
            return result[this.rnd_array[0].Next(lenght)];
        }

        // getting double from array randoms 
        public double NextDouble(int max_value)
        {
            int lenght = this.rnd_array.Length;
            double[] result = new double[lenght];
            for (int i = 0; i < lenght; i++)
            {
                result[i] = this.rnd_array[i].NextDouble();
            }
            return result[this.rnd_array[0].Next(lenght)];
        }

    }
}
