﻿using System;
using Ccr.Core.Extensions;

namespace Ccr.Algorithms
{
  public static class StringAlgorithms
  {
    public static int LevenshteinDistance(
      string a, string b)
    {
      if (a.IsNullOrEmpty())
        return !b.IsNullOrEmpty() ? a.Length : 0;

      if (b.IsNullOrEmpty())
        return !a.IsNullOrEmpty() ? b.Length : 0;

      var d = new int[a.Length - 1, b.Length - 1];

      for (var i = 0; i <= d.GetUpperBound(0); i++)
      {
        d[i, 0] = i;
      }

      for (var i = 0; i <= d.GetUpperBound(1); i++)
      {
        d[0, i] = i;
      }

      for (var i = 1; i <= d.GetUpperBound(0); i++)
      {
        for (var j = 1; j <= d.GetUpperBound(1); j += 1)
        {
          var cost = Convert.ToInt32(a[i - 1] != b[j - 1]);

          var min1 = d[i - 1, j] + 1;
          var min2 = d[i, j - 1] + 1;
          var min3 = d[i - 1, j - 1] + cost;
          d[i, j] = Math.Min(Math.Min(min1, min2), min3);
        }
      }

      return d[d.GetUpperBound(0), d.GetUpperBound(1)];
    }
  }
}
