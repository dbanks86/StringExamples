using System;

namespace StringUtility
{
    public class StringExamples
    {
        /// <summary>
        /// Reverses text
        /// </summary>
        /// <param name="text">String to be reversed</param>
        public string ReverseString(string text)
        {
            if (string.IsNullOrEmpty(text)) throw new InvalidOperationException();

            var textAsCharArray = text.ToCharArray();

            //loops iterations stop at half point of array since two values are being switched during each loop iteration
            for (int i = 0; i < textAsCharArray.Length / 2; i++)
            {
                char firstValue = textAsCharArray[i];
                char secondValue = textAsCharArray[textAsCharArray.Length - i - 1];

                textAsCharArray[i] = secondValue;
                textAsCharArray[text.Length - i - 1] = firstValue;
            }

            return new string(textAsCharArray);
        }

        /// <summary>
        /// Reverses text by word (based on separation by spaces)
        /// </summary>
        /// <param name="text">Text to be reversed by spaces</param>
        public string ReverseStringByWord(string text)
        {
            if (String.IsNullOrWhiteSpace(text)) throw new InvalidOperationException("Text cannot be null, empty, or only consist of spaces");

            var textSplit = text.Split(' ');

            //loops iterations stop at half point of split array since two values are being switched during each loop iteration
            for (int i = 0; i < textSplit.Length / 2; i++)
            {
                string firstValue = textSplit[i];
                string secondValue = textSplit[textSplit.Length - i - 1];

                textSplit[i] = secondValue;
                textSplit[textSplit.Length - i - 1] = firstValue;
            }

            return String.Join(" ", textSplit);
        }
    }
}
