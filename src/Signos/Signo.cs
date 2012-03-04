using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Signos
{
    public class Signo
    {
        public string ObterNomeSigno(DateTime data)
        {

            if ((data.Month == 3 & data.Day >= 21)
                |(data.Month == 4 & data.Day <= 20))
            {
                return "Aries";
            }

            if ((data.Month == 4 & data.Day >= 21)
                | (data.Month == 5 & data.Day <= 21))
            {
                return "Touro";
            }

            if ((data.Month == 5 & data.Day >= 22)
               | (data.Month == 6 & data.Day <= 21))
            {
                return "Gemeos";
            }

            if ((data.Month == 9 & data.Day >= 24)
               | (data.Month == 10 & data.Day <= 23))
            {
                return "Libra";
            }

            if ((data.Month == 10 & data.Day >= 24)
               | (data.Month == 11 & data.Day <= 23))
            {
                return "Escorpiao";
            }

            if ((data.Month == 1 & data.Day >= 21)
              | (data.Month == 2 & data.Day <= 19))
            {
                return "Aquario";
            }

            if ((data.Month == 8 & data.Day >= 24)
              | (data.Month == 9 & data.Day <= 23))
            {
                return "Virgem";
            }

            if ((data.Month == 12 & data.Day >= 22)
              | (data.Month == 01 & data.Day <= 20))
            {
                return "Capricornio";
            }

            if ((data.Month == 11 & data.Day >= 23)
             | (data.Month == 12 & data.Day <= 21))
            {
                return "Sagitario";
            }

            if ((data.Month == 2 & data.Day >= 20)
                | (data.Month == 3 & data.Day <= 20))
            {
                return "Peixes";
            }

            if ((data.Month == 2 & data.Day >= 20)
                | (data.Month == 3 & data.Day <= 20))
            {
                return "Leão";
            }

            return "Cancer";
        }
    }
}
