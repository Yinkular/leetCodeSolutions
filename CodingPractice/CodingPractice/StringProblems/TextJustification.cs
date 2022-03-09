using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.StringProblems
{
    public static class TextJustification
    {
        public static IList<string> FullJustify(string[] words, int maxWidth)
        {
            IList<string> result = new List<string>();

            List<KeyValuePair<List<string>, int>> wordMapping = new List<KeyValuePair<List<string>,int>>();

            int currentLength = 0;
            List<string> wordsOnSameline = new List<string>();
            foreach (string word in words)
            {
                // go to new line if current word will allow line limit to be exceeded
                if ((currentLength + word.Length) > maxWidth)
                {
                    wordMapping.Add(new KeyValuePair<List<string>, int>(wordsOnSameline, currentLength-1));
                    wordsOnSameline = new List<string>();
                    currentLength = 0;
                }
                currentLength += (word.Length + 1);
                wordsOnSameline.Add(word);
            }
            if(wordsOnSameline.Count > 0)
            {
                wordMapping.Add(new KeyValuePair<List<string>, int>(wordsOnSameline, currentLength-1));
            }


            for(int i=0;i< wordMapping.Count;i++)
            {
                StringBuilder currentline = new StringBuilder();
                List<string> currentWOrds = wordMapping[i].Key;
                int length = wordMapping[i].Value;

                // calculate spaces for non last line
                if( i != wordMapping.Count-1 && currentWOrds.Count > 1)
                {
                    int diff = maxWidth - length;
                    int extraSpaces = diff / (currentWOrds.Count - 1);
                    int extraLeftSpace = diff % (currentWOrds.Count-1);

                    for(int j=0;j<currentWOrds.Count;j++)
                    {
                        currentline.Append(currentWOrds[j]);

                        if(j!=(currentWOrds.Count-1))
                        {
                            currentline.Append(' ');
                            currentline.Append(' ', extraSpaces);

                            if(extraLeftSpace > 0)
                            {
                                currentline.Append(' ', 1);
                                extraLeftSpace--;
                            }
                        }
                    }
                }
                else if(i != wordMapping.Count - 1 && currentWOrds.Count == 1)
                {
                    int diff = maxWidth - length;
                    currentline.Append(currentWOrds[0]);
                    currentline.Append(' ', diff);
                    
                }
                else
                {
                    int diff = maxWidth-length;
                    for(int j=0; j<currentWOrds.Count; j++)
                    {
                        currentline.Append(currentWOrds[j]);
                        if( j!=(currentWOrds.Count-1))
                        {
                            currentline.Append(' ');
                        }
                        else
                        {
                            currentline.Append(' ', diff);
                        }
                    }
                }

                result.Add(currentline.ToString());
            }

            return result;
        }
    }
}
