namespace Password;

public class Password
{

    static char[] symbols = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')' };

    public static string CheckPassword(string x)
    {
        int count = 0;

        if (x.Any(char.IsUpper))
        {
            count++;
        }

        if (x.Any(char.IsLower))
        {
            count++;
        }

        if (x.Any(char.IsNumber))
        {
            count++;
        }

        if (x.Any(c => symbols.Contains(c)))
        {
            count++;
        }

        if (x.Length >= 8)
        {
            count++;
        }

        switch (count)
        {
            case 0:
                return "INELIGABLE";
            case 1:
                return "WEAK";
            case 2 or 3:
                return "MEDIUM";
            case 4:
                return "STRONG";
            default:
                return "INELIGABLE";
        }
    }
}
