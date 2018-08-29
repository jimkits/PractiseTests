using Xunit;

namespace PractiseHackerrank
{
    public class LongestSentence
    {
        [Fact]
        public void Test()
        {
            /*
             * The string has sentenses, separated by [.], [!] or [?]
             * Return the sentence that has the most words, separated by single space
             */

            var result = BiggestSentense(" hello world. biggest sentence  is this one . nop! ");

            Assert.Equal(5, result);
        }

        private int BiggestSentense(string sentense)
        {
            // Split the sentense by . or !
            var sentencesArray = sentense.Split(' ');
            var sentencesLength = sentencesArray.Length;
            var wordCount = 0;
            var highestNumber = 0;

            for (int i = 0; i < sentencesLength; i++)
            {
                if (sentencesArray[i] != "" && sentencesArray[i] != ".")
                {
                    wordCount += 1;
                }

                //if (sentencesArray[i] == ".")
                //{
                //    wordCount -= 1;
                //}

                if (sentencesArray[i].Contains(".") || sentencesArray[i].Contains("!"))
                {
                    if (wordCount > highestNumber)
                    {
                        highestNumber = wordCount;
                        wordCount = 0;
                    }
                }
            }

            // return the number of words in the biggest sentence.

            return highestNumber;
        }
    }
}
