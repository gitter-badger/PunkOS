﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PunkOS.System.Manger;

namespace PunkOS
{
  public class BaseFont : Font
  {
    public override int[] getChar(char c)
    {

      if (c == 'A')
      {
        return new int[]{
                    0, 0, 1, 0, 0,
                    0, 1, 0, 1, 0,
                    1, 0, 0, 0, 1,
                    1, 1, 1, 1, 1,
                    1, 0, 0, 0, 1,
                };
      }
      else if (c == 'B')
      {
        return new int[]{
                    1, 1, 1, 0, 0,
                    1, 0, 0, 1, 0,
                    1, 1, 1, 0, 0,
                    1, 0, 0, 1, 0,
                    1, 1, 1, 0, 0,
                };
      }
      else if (c == 'C')
      {
        return new int[]{
                    1, 1, 1, 1, 1,
                    1, 0, 0, 0, 0,
                    1, 0, 0, 0, 0,
                    1, 0, 0, 0, 0,
                    1, 1, 1, 1, 1,
                };
      }
      else if (c == 'D')
      {
        return new int[]{
                    1, 1, 1, 0, 0,
                    1, 0, 0, 1, 0,
                    1, 0, 0, 1, 0,
                    1, 0, 0, 1, 0,
                    1, 1, 1, 0, 0,
                };
      }
      else if (c == 'E')
      {
        return new int[]{
                    1, 1, 1, 1, 0,
                    1, 0, 0, 0, 0,
                    1, 1, 1, 1, 0,
                    1, 0, 0, 0, 0,
                    1, 1, 1, 1, 0,
                };
      }
      else if (c == 'F')
      {
        return new int[]{
                    1, 1, 1, 1, 1,
                    1, 0, 0, 0, 0,
                    1, 1, 1, 0, 0,
                    1, 0, 0, 0, 0,
                    1, 0, 0, 0, 0,
                };
      }
      else if (c == 'G')
      {
        return new int[]{
                    1, 1, 1, 1, 1,
                    1, 0, 0, 0, 0,
                    1, 0, 1, 1, 1,
                    1, 0, 0, 1, 0,
                    1, 1, 1, 1, 0,
                };
      }
      else if (c == 'H')
      {
        return new int[]{
                    1, 0, 0, 0, 1,
                    1, 0, 0, 0, 1,
                    1, 1, 1, 1, 1,
                    1, 0, 0, 0, 1,
                    1, 0, 0, 0, 1,
                };
      }
      else if (c == 'I')
      {
        return new int[]{
                    1, 1, 1, 1, 1,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    1, 1, 1, 1, 1,
                };
      }
      else if (c == 'J')
      {
        return new int[]{
                    1, 1, 1, 1, 1,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    1, 1, 1, 0, 0,
                };
      }
      else if (c == 'K')
      {
        return new int[]{
                    1, 0, 0, 1, 0,
                    1, 0, 1, 0, 0,
                    1, 1, 0, 0, 0,
                    1, 0, 1, 0, 0,
                    1, 0, 0, 1, 0,
                };
      }
      else if (c == 'L')
      {
        return new int[]{
                    1, 0, 0, 0, 0,
                    1, 0, 0, 0, 0,
                    1, 0, 0, 0, 0,
                    1, 0, 0, 0, 0,
                    1, 1, 1, 1, 1,
                };
      }
      else if (c == 'M')
      {
        return new int[]{
                    1, 0, 0, 0, 1,
                    1, 1, 0, 1, 1,
                    1, 0, 1, 0, 1,
                    1, 0, 0, 0, 1,
                    1, 0, 0, 0, 1,
                };
      }
      else if (c == 'N')
      {
        return new int[]{
                    1, 0, 0, 0, 1,
                    1, 1, 0, 0, 1,
                    1, 0, 1, 0, 1,
                    1, 0, 0, 1, 1,
                    1, 0, 0, 0, 1,
                };
      }
      else if (c == 'O')
      {
        return new int[]{
                    1, 1, 1, 1, 1,
                    1, 0, 0, 0, 1,
                    1, 0, 0, 0, 1,
                    1, 0, 0, 0, 1,
                    1, 1, 1, 1, 1,
                };
      }
      else if (c == 'P')
      {
        return new int[]{
                    1, 1, 1, 1, 0,
                    1, 0, 0, 1, 0,
                    1, 1, 1, 1, 0,
                    1, 0, 0, 0, 0,
                    1, 0, 0, 0, 0,
                };
      }
      else if (c == 'Q')
      {
        return new int[]{
                    1, 1, 1, 1, 0,
                    1, 0, 0, 1, 0,
                    1, 0, 0, 1, 0,
                    1, 1, 1, 1, 0,
                    0, 0, 0, 0, 1,
                };
      }
      else if (c == 'R')
      {
        return new int[]{
                    1, 1, 1, 1, 0,
                    1, 0, 0, 1, 0,
                    1, 1, 1, 1, 0,
                    1, 0, 0, 1, 0,
                    1, 0, 0, 0, 1,
                };
      }
      else if (c == 'S')
      {
        return new int[]{
                    0, 1, 1, 1, 1,
                    1, 0, 0, 0, 0,
                    1, 1, 1, 1, 1,
                    0, 0, 0, 0, 1,
                    1, 1, 1, 1, 0,
                };
      }
      else if (c == 'T')
      {
        return new int[]{
                    1, 1, 1, 1, 1,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                };
      }
      else if (c == 'U')
      {
        return new int[]{
                    1, 0, 0, 0, 1,
                    1, 0, 0, 0, 1,
                    1, 0, 0, 0, 1,
                    1, 0, 0, 0, 1,
                    1, 1, 1, 1, 1,
                };
      }
      else if (c == 'V')
      {
        return new int[]{
                    1, 0, 0, 0, 1,
                    1, 0, 0, 0, 1,
                    1, 0, 0, 0, 1,
                    0, 1, 0, 1, 0,
                    0, 0, 1, 0, 0,
                };
      }
      else if (c == 'W')
      {
        return new int[]{
                    1, 0, 0, 0, 1,
                    1, 0, 0, 0, 1,
                    1, 0, 0, 0, 1,
                    1, 0, 1, 0, 1,
                    0, 1, 0, 1, 0,
                };
      }
      else if (c == 'X')
      {
        return new int[]{
                    1, 0, 0, 0, 1,
                    0, 1, 0, 1, 0,
                    0, 0, 1, 0, 0,
                    0, 1, 0, 1, 0,
                    1, 0, 0, 0, 1,
                };
      }
      else if (c == 'Y')
      {
        return new int[]{
                    1, 0, 0, 0, 1,
                    0, 1, 0, 1, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                };
      }
      else if (c == 'Z')
      {
        return new int[]{
                    1, 1, 1, 1, 1,
                    0, 0, 0, 1, 0,
                    0, 0, 1, 0, 0,
                    0, 1, 0, 0, 0,
                    1, 1, 1, 1, 1,
                };
      }
      else if (c == '1')
      {
        return new int[]{
                    0, 0, 1, 0, 0,
                    0, 1, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    1, 1, 1, 1, 1,
                };
      }
      else if (c == '2')
      {
        return new int[]{
                    1, 1, 1, 1, 1,
                    0, 0, 0, 1, 0,
                    0, 1, 1, 0, 0,
                    1, 0, 0, 0, 0,
                    1, 1, 1, 1, 1,
                };
      }
      else if (c == '3')
      {
        return new int[]{
                    0, 1, 1, 1, 1,
                    0, 0, 0, 0, 1,
                    0, 0, 1, 1, 0,
                    0, 0, 0, 0, 1,
                    0, 1, 1, 1, 1,
                };
      }
      else if (c == '4')
      {
        return new int[]{
                    1, 0, 0, 0, 0,
                    1, 0, 0, 0, 0,
                    1, 0, 0, 1, 0,
                    1, 1, 1, 1, 1,
                    0, 0, 0, 1, 0,
                };
      }
      else if (c == '5')
      {
        return new int[]{
                    1, 1, 1, 1, 0,
                    1, 0, 0, 0, 0,
                    1, 1, 1, 0, 0,
                    0, 0, 0, 1, 0,
                    1, 1, 1, 0, 0,
                };
      }
      else if (c == '6')
      {
        return new int[]{
                    1, 1, 1, 1, 0,
                    1, 0, 0, 0, 0,
                    1, 1, 1, 1, 0,
                    1, 0, 0, 1, 0,
                    1, 1, 1, 1, 0,
                };
      }
      else if (c == '7')
      {
        return new int[]{
                    1, 1, 1, 1, 1,
                    0, 0, 0, 1, 0,
                    0, 0, 1, 0, 0,
                    0, 1, 0, 0, 0,
                    1, 0, 0, 0, 0,
                };
      }
      else if (c == '8')
      {
        return new int[]{
                    1, 1, 1, 1, 1,
                    1, 0, 0, 0, 1,
                    1, 1, 1, 1, 1,
                    1, 0, 0, 0, 1,
                    1, 1, 1, 1, 1,
                };
      }
      else if (c == '9')
      {
        return new int[]{
                    1, 1, 1, 1, 1,
                    1, 0, 0, 0, 1,
                    1, 1, 1, 1, 1,
                    0, 0, 0, 0, 1,
                    0, 0, 0, 0, 1,
                };
      }
      else if (c == '0')
      {
        return new int[]{
                    1, 1, 1, 1, 1,
                    1, 0, 0, 1, 1,
                    1, 0, 1, 0, 1,
                    1, 1, 0, 0, 1,
                    1, 1, 1, 1, 1,
                };
      }
      else if (c == '.')
      {
        return new int[]{
                    0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0,
                    0, 0, 1, 0, 0,
                };

      }
      else if (c == '/')
      {
        return new int[]{
                    0, 0, 0, 0, 1,
                    0, 0, 0, 1, 0,
                    0, 0, 1, 0, 0,
                    0, 1, 0, 0, 0,
                    1, 0, 0, 0, 0,
                };

      }
      else if (c == '|')
      {
        return new int[]{
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                };

      }
      else if (c == '<')
      {
        return new int[]{
                    0, 0, 0, 1, 0,
                    0, 0, 1, 0, 0,
                    0, 1, 0, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 0, 1, 0,
                };

      }
      else if (c == '>')
      {
        return new int[]{
                    0, 1, 0, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 0, 1, 0,
                    0, 0, 1, 0, 0,
                    0, 1, 0, 0, 0,
                };

      }
      else if (c == '=')
      {
        return new int[]{
                    0, 0, 0, 0, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 0, 0, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 0, 0, 0,
                };

      }
      else if (c == '+')
      {
        return new int[]{
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    1, 1, 1, 1, 1,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                };

      }
      else if (c == '-')
      {
        return new int[]{
                    0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0,
                };

      }
      else if (c == ',')
      {
        return new int[]{
                    0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 1, 0, 0, 0,
                };

      }
      else if (c == '%')
      {
        return new int[]{
                    1, 0, 0, 0, 1,
                    0, 0, 0, 1, 0,
                    0, 0, 1, 0, 0,
                    0, 1, 0, 0, 0,
                    1, 0, 0, 0, 1,
                };

      }
      else
      {
        return new int[]{
                    0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0,
                };
      }
      //1258
    }
  }
}
