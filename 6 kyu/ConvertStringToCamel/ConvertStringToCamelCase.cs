using System.Text;
using System.Globalization;

public class ConvertStringToCamelCase
{
  public static string ToCamelCase(string text)
  {
    if (string.IsNullOrEmpty(text))
    {
      return text;
    }

    var result = new StringBuilder();
    var words = text.Split(new char[] { '-', '_' });

    var isFirstUpperCase = char.IsUpper(text[0]);

    for (int i = 0; i < words.Length; i++)
    {
      if (i == 0 && !isFirstUpperCase)
      {
        result.Append(words[i].ToLower());
      }
      else
      {
        var word = words[i];
        var updatedWord = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word.ToLower());
        result.Append(updatedWord);
      }
    }

    return result.ToString();
  }
}