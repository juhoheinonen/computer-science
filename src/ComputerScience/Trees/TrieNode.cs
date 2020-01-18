using System;
using System.Collections.Generic;

namespace ComputerScience
{
    public class TrieNode
    {
        private Dictionary<char, TrieNode> children;
        public bool Terminates { get; private set; } = false;
        public char Character { get; private set; }

        public TrieNode()
        {
            children = new Dictionary<char, TrieNode>();
        }

        public TrieNode(char character) : this()
        {
            this.Character = character;
        }

        public void AddWord(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return;
            }

            char firstChar = word[0];
            TrieNode child = GetChild(firstChar);
            if (child == null)
            {
                child = new TrieNode(firstChar);
                children[firstChar] = child;
            }

            if (word.Length > 1)
            {
                child.AddWord(word.Substring(1));
            }
            else
            {
                child.Terminates = true;
            }
        }

        public TrieNode GetChild(char c)
        {
            if (children.ContainsKey(c))
            {
                return children[c];
            }
            else
            {
                return null;
            }
        }
    }
}