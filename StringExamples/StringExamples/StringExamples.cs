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
    }
}
