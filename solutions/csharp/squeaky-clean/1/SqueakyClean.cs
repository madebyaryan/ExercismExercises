using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (string.IsNullOrEmpty(identifier))
        {
            return "";
        }
        if (identifier.Contains(" "))
        {
            identifier = identifier.Replace(" ", "_");
        }
        StringBuilder result = new StringBuilder();
        foreach (char c in identifier)
        {
            if (char.IsControl(c))
            {
                result.Append("CTRL");
            }
            else
            {
                result.Append(c);
            }
        }
        identifier = result.ToString();
        StringBuilder kebabToCamel = new StringBuilder();
        bool caseFlag = false;
        for (int i = 0; i < identifier.Length; i++)
        {
            char c = identifier[i];
            if (c == '-')
            {
                caseFlag = true;
            }
            else if (caseFlag)
            {
                kebabToCamel.Append(char.ToUpper(c));
                caseFlag = false;
            }
            else{
                kebabToCamel.Append(c);
            }
        }
        identifier = kebabToCamel.ToString();
        StringBuilder lettersOnly = new StringBuilder();
        foreach (char c in identifier)
        {
            bool isGreek = (c >= 'α' && c <= 'ω');
            if ((char.IsLetter(c) || c == '_') && !isGreek)
            {
                lettersOnly.Append(c);
            }
        }
        return lettersOnly.ToString();
    }
}
