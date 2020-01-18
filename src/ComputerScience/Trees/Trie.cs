using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScience
{
    public class Trie
    {
        public TrieNode Root { get; private set; }

        public Trie(List<string> words)
        {
            Root = new TrieNode();

            foreach (var word in words)
            {
                Root.AddWord(word);
            }
        }

        public bool Contains(string prefix, bool exact)
        {
            prefix = prefix ?? string.Empty;

            TrieNode lastNode = Root;

            for (int i = 0; i < prefix.Length; i++)
            {
                lastNode = lastNode.GetChild(prefix[i]);
                if (lastNode == null)
                {
                    return false;
                }
            }
            return !exact || lastNode.Terminates;
        }

        public bool Contains(string prefix)
        {
            return Contains(prefix, false);
        }
    }
}
