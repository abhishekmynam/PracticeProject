using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class Wordladder
    {
        public int ladderLength(String beginWord, String endWord, List<String> wordList)
        {
            wordList.Add(endWord);
            Queue<String> queue = new Queue<String>();
            queue.Enqueue(beginWord);
            int level = 0;
            while (queue.Count()!=0)
            {
                int size = queue.Count();
                for (int i = 0; i < size; i++)
                {
                    String cur = queue.Dequeue();
                    if (cur==endWord) { return level + 1; }
                    for (int j = 0; j < cur.Count(); j++)
                    {
                        char[] word = cur.ToArray();
                        for (char ch = 'a'; ch < 'z'; ch++)
                        {
                            word[j] = ch;
                            String check = new String(word);
                            if (!(check==cur) && wordList.Contains(check))
                            {
                                queue.Enqueue(check);
                                wordList.Remove(check);
                            }
                        }
                    }
                }
                level++;
            }
            return 0;
        }
    }
}
