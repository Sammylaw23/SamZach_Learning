using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamZach.Learning
{
    internal class StringIndexer
    {
        /// <summary>
        /// Question 1:
        //Given a string "value" and a string "str"
        //1. Write a function that returns the string before "str" in "value"
        /// </summary>
        /// <returns></returns>
        public static string GetTextBeforeSpecifiedString(string sentence, string str)
        {
            //I will not be able to return the appropriate message if string is null or empty
            //_ = (!string.IsNullOrEmpty(sentence) && !string.IsNullOrEmpty(str)) ? (!sentence.Contains(str)) ? $"{sentence} does not contain {str}" : "It contains" : "One of the input is null or empty";

            if (string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(str)) return "One of the input is null or empty";
            if (!sentence.Contains(str)) return $"{sentence} does not contain {str}";
            int strStartPosition = sentence.IndexOf(str);
            if (strStartPosition == 0) return $"There is nothing before {str} in {sentence}";
            return sentence.Remove(strStartPosition).Trim();
        }

        /// <summary>
        ///Write a function that returns the string after "str" in "value"

        /// </summary>
        /// <param name="sentence"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetTextAfterSpecifiedString(string sentence, string str)
        {
            if (!sentence.Contains(str)) return $"{sentence} does not contain {str}";
            int strStartPosition = sentence.IndexOf(str);
            int strLength = str.Length;
            int strLengthFromLeft = strStartPosition + strLength;
            int sentenceLength = sentence.Length;
            if (strLengthFromLeft == sentenceLength) return $"There is nothing after {str} in {sentence}";
            return sentence.Substring(strLengthFromLeft, sentenceLength - strLengthFromLeft).Trim();
        }

        /// <summary>
        /// Write a function that returns the string between "str1" and "str2"  from string "value"
        /// </summary>
        /// <param name="sentence"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetTextBetweenSpecifiedStrings(string sentence, string str1, string str2)
        {
            //check if both strings are present
            //sam o Sam2
            if (string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2)) return "One of the inputs is null or empty";
            if (!sentence.Contains(str1) || !sentence.Contains(str2)) return $"{sentence} does not contain either {str1} or {str2}";
            int positionOfLastLetterInFirstString = sentence.IndexOf(str1) + str1.Length - 1;
            int positionOfFirstLetterInSecondString = sentence.IndexOf(str2);

            //What if str1 and str2 are the same?
            if (str1.Equals(str2))
                positionOfFirstLetterInSecondString = sentence.IndexOf(str2, positionOfLastLetterInFirstString);

            string tempSentence = sentence.Replace(" ", "");
            if (tempSentence.IndexOf(str1) + str1.Length == tempSentence.IndexOf(str2)) return $"There is nothing between {str1} and {str2} in {sentence}";

            sentence = sentence.Remove(positionOfFirstLetterInSecondString);
            sentence = sentence.Substring(positionOfLastLetterInFirstString + 1);

            return sentence;
        }






        #region RawToKeepSafe

        ///// <summary>
        ///// Question 1:
        ////Given a string "value" and a string "str"
        ////1. Write a function that returns the string before "str" in "value"
        ///// </summary>
        ///// <returns></returns>
        //public static string GetTextBeforeSpecifiedString(string sentence, string str)
        //{
        //    if (string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(str))
        //        return "One of the input is null or empty";
        //    if (!sentence.Contains(str))
        //        return $"{sentence} does not contain {str}";

        //    int strStartPosition = sentence.IndexOf(str);

        //    if (strStartPosition == 0)
        //        return $"There is nothing before {str} in {sentence}";

        //    sentence = sentence.Remove(strStartPosition).Trim();
        //    return sentence;
        //}

        ///// <summary>
        /////Write a function that returns the string after "str" in "value"

        ///// </summary>
        ///// <param name="sentence"></param>
        ///// <param name="str"></param>
        ///// <returns></returns>
        //public static string GetTextAfterSpecifiedString(string sentence, string str)
        //{
        //    if (string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(str))
        //        return "One of the input is null or empty";
        //    if (!sentence.Contains(str))
        //        return $"{sentence} does not contain {str}";

        //    int strStartPosition = sentence.IndexOf(str);
        //    int strLength = str.Length;
        //    int strLengthFromLeft = strStartPosition + strLength;

        //    if (strLengthFromLeft == sentence.Length)
        //        return $"There is nothing after {str} in {sentence}";

        //    sentence = sentence.Substring(strLengthFromLeft, sentence.Length - strLengthFromLeft).Trim();

        //    return sentence;
        //}

        ///// <summary>
        ///// Write a function that returns the string between "str1" and "str2"  from string "value"
        ///// </summary>
        ///// <param name="sentence"></param>
        ///// <param name="str"></param>
        ///// <returns></returns>
        //public static string GetTextBetweenSpecifiedStrings(string sentence, string str1, string str2)
        //{
        //    //check if both strings are present
        //    //sam o Sam2

        //    //What if str1 and str2 are the same?

        //    if (string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
        //        return "One of the inputs is null or empty";
        //    if (!sentence.Contains(str1) || !sentence.Contains(str2))
        //        return $"{sentence} does not contain either {str1} or {str2}";

        //    int positionOfLastLetterInFirstString = sentence.IndexOf(str1) + str1.Length - 1;
        //    int positionOfFirstLetterInSecondString = sentence.IndexOf(str2);

        //    if (str1.Equals(str2))
        //        positionOfFirstLetterInSecondString = sentence.IndexOf(str2, positionOfLastLetterInFirstString);

        //    string tempSentence = sentence.Replace(" ", "");
        //    if (tempSentence.IndexOf(str1) + str1.Length == tempSentence.IndexOf(str2))
        //        return $"There is nothing between {str1} and {str2} in {sentence}";

        //    sentence = sentence.Remove(positionOfFirstLetterInSecondString);
        //    sentence = sentence.Substring(positionOfLastLetterInFirstString + 1);

        //    return sentence;
        //}
        #endregion


    }
}
