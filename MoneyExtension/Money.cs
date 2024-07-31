using System.Runtime;

namespace MoneyExtension;
public static class Money
{
    
  public static int ToCents(this decimal  amount )
  {
    if ( amount < 0 )
        return 0;

        var text = amount.ToString("N2")
        .Replace(",", "")
        .Replace(".", "");

        if(string.IsNullOrEmpty(text))
         return 0;

        // quando usamos uma variavel _ a descartamos logo depois
        _ = int.TryParse(text, out var result);
         return result;
  }
}
