using System;
namespace PunkOS.System.Manger
{

        public abstract class Font
        {

            public int fontSize = 5;

            public abstract int[] getChar(char c);

        }

    }
