using System;
using System.Collections.Generic;

public class KannadaLetterConverter
{
    public static readonly Dictionary<string, string> kannadaToRomanIastMap = new()
    {
        {"ಅ", "a"}, {"ಆ", "aa"}, {"ಇ", "i"}, {"ಈ", "ii"}, {"ಉ", "u"},
        {"ಊ", "uu"}, {"ಋ", "ru"}, {"ೠ", "ruu"}, {"ಎ", "e"}, {"ಏ", "ee"},
        {"ಐ", "ai"}, {"ಒ", "o"}, {"ಓ", "oo"}, {"ಔ", "au"},

        {"ಕ", "ka"}, {"ಖ", "kha"}, {"ಗ", "ga"}, {"ಘ", "gha"}, {"ಙ", "nga"},
        {"ಚ", "cha"}, {"ಛ", "chha"}, {"ಜ", "ja"}, {"ಝ", "jha"}, {"ಞ", "nya"},
        {"ಟ", "ta"}, {"ಠ", "tha"}, {"ಡ", "da"}, {"ಢ", "dha"}, {"ಣ", "na"},
        {"ತ", "ta"}, {"ಥ", "tha"}, {"ದ", "da"}, {"ಧ", "dha"}, {"ನ", "na"},
        {"ಪ", "pa"}, {"ಫ", "pha"}, {"ಬ", "ba"}, {"ಭ", "bha"}, {"ಮ", "ma"},
        {"ಯ", "ya"}, {"ರ", "ra"}, {"ಲ", "la"}, {"ವ", "va"}, {"ಶ", "sha"},
        {"ಷ", "sha"}, {"ಸ", "sa"}, {"ಹ", "ha"}, {"ಳ", "la"}, {"ಕ್ಷ", "ksha"},
        {"ಜ್ಞ", "gya"},

        {"೦", "0"}, {"೧", "1"}, {"೨", "2"}, {"೩", "3"}, {"೪", "4"},
        {"೫", "5"}, {"೬", "6"}, {"೭", "7"}, {"೮", "8"}, {"೯", "9"}
    };

    public static readonly Dictionary<string, string> romanIastToKannadaMap = new()
    {
        {"a", "ಅ"}, {"aa", "ಆ"}, {"i", "ಇ"}, {"ii", "ಈ"}, {"u", "ಉ"},
        {"uu", "ಊ"}, {"ru", "ಋ"}, {"ruu", "ೠ"}, {"e", "ಎ"}, {"ee", "ಏ"},
        {"ai", "ಐ"}, {"o", "ಒ"}, {"oo", "ಓ"}, {"au", "ಔ"},

        {"ka", "ಕ"}, {"kha", "ಖ"}, {"ga", "ಗ"}, {"gha", "ಘ"}, {"nga", "ಙ"},
        {"cha", "ಚ"}, {"chha", "ಛ"}, {"ja", "ಜ"}, {"jha", "ಝ"}, {"nya", "ಞ"},
        {"ta", "ಟ"}, {"tha", "ಠ"}, {"da", "ಡ"}, {"dha", "ಢ"}, {"na", "ಣ"},
        {"ta", "ತ"}, {"tha", "ಥ"}, {"da", "ದ"}, {"dha", "ಧ"}, {"na", "ನ"},
        {"pa", "ಪ"}, {"pha", "ಫ"}, {"ba", "ಬ"}, {"bha", "ಭ"}, {"ma", "ಮ"},
        {"ya", "ಯ"}, {"ra", "ರ"}, {"la", "ಲ"}, {"va", "ವ"}, {"sha", "ಶ"},
        {"sha", "ಷ"}, {"sa", "ಸ"}, {"ha", "ಹ"}, {"la", "ಳ"}, {"ksha", "ಕ್ಷ"},
        {"gya", "ಜ್ಞ"},

        {"0", "೦"}, {"1", "೧"}, {"2", "೨"}, {"3", "೩"}, {"4", "೪"},
        {"5", "೫"}, {"6", "೬"}, {"7", "೭"}, {"8", "೮"}, {"9", "೯"}
    };

    public static string GetRootAlphabetFromRomanIast(string romanIastLetter)
    {
        if (romanIastToKannadaMap.ContainsKey(romanIastLetter))
        {
            return romanIastToKannadaMap[romanIastLetter];
        }

        return " "; // Return a space if the mapping is not found.
    }
}
