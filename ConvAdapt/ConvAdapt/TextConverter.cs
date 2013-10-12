using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConvAdapt
{
    enum Action
    {
        One,
        Two,
        Ignore
    }

    static class TextConverter
    {
        public static string ApplyCamelCase(string text, bool lowerText, Action underscoreAtStartAction, Action firstLetterAction)
        {
            text = CapitalizeLetterAfterUnderscoreAndRemoveUnderscore(text);
            if (lowerText)
                text = text.ToLower();
            text = ChangeCaseSensitivityOfFirstLetter(text, firstLetterAction);
            text = ApplyUnderscoreAtStart(text, underscoreAtStartAction);
            return text;
        }

        public static string CapitalizeLetterAfterUnderscoreAndRemoveUnderscore(string text)
        {
            return Regex.Replace(text, @"._[A-Za-z]", delegate(Match match)
            {
                string s = match.ToString();
                return s[0] + char.ToUpper(s[2]).ToString();
            });
        }

        public static string ApplyUnderscoreCase(string text, bool capitalizeLetterAfterUnderscore, bool lowerText, Action underscoreAtStartAction, Action firstLetterAction)
        {
            if (capitalizeLetterAfterUnderscore)
                text = CapitalizeLetterAfterUnderscore(text);
            text = InsertUnderscoresBeforeCapitalizedLetters(text);
            if (lowerText)
                text = text.ToLower();
            text = ChangeCaseSensitivityOfFirstLetter(text, firstLetterAction);
            text = ApplyUnderscoreAtStart(text, underscoreAtStartAction);
            return text;
        }

        public static string ChangeCaseSensitivityOfFirstLetter(string text, Action action)
        {
            for (int i = 0; i < text.Length; i++)
                if (char.IsLetter(text[i]))
                {
                    var temp = text.ToCharArray();
                    if (action == Action.One) //Capitalize
                        temp[i] = char.ToUpper(temp[i]);
                    else if (action == Action.Two) //Lower
                        temp[i] = char.ToLower(temp[i]);
                    return new String(temp);
                }
            return text;
        }

        public static string ApplyUnderscoreAtStart(string text, Action action)
        {
            if (text.Length > 0)
            {
                if (action == Action.One && text[0] != '_')
                    return "_" + text;
                else if (action == Action.Two && text[0] == '_')
                    return text.Substring(1);
            }
            return text;
        }

        public static string InsertUnderscoresBeforeCapitalizedLetters(string text)
        {
            return Regex.Replace(text, @"[^_][A-Z]", delegate(Match match)
            {
                string s = match.ToString();
                return s[0] + "_" + s[1];
            });
        }

        public static string CapitalizeLetterAfterUnderscore(string text)
        {
            return Regex.Replace(text, @"_[a-z]", delegate(Match match)
            {
                string s = match.ToString();
                return s[0] + char.ToUpper(s[1]).ToString();
            });
        }
    }
}
