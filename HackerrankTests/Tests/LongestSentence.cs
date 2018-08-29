using Xunit;

namespace PractiseHackerrank
{
    public class LongestSentence
    {
        [Theory]
        [InlineData(" hello world.biggest sentence is this one.nop!")]
        [InlineData(" hello world.biggest sentence is this one..nop!")]
        public void Test(string text)
        {
            /*
             * The string has sentenses, separated by [.], [!] or [?]
             * Return the sentence that has the most words, separated by single space
             */

            var result = BiggestSentenceD(text);

            Assert.Equal(5, result);
        }

        private int BiggestSentenceD(string text)
        {
            var sentences = text.Split(new char[] { '.', '!', '?' });
            var biggestSentence = 0;

            foreach(var sentence in sentences)
            {
                var words = sentence.Split(' ');

                var tempCount = 0;

                foreach(var word in words)
                {
                    if (!string.IsNullOrEmpty(word))
                    {
                        tempCount++;
                    }
                }

                if(tempCount > biggestSentence)
                {
                    biggestSentence = tempCount;
                }
            }

            return biggestSentence;
        }
    }
}
