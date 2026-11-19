using System;
using System.Collections.Generic;
using System.Text;

namespace OwnVoca.CS
{
    public class WordData
    {
        public readonly string _word;
        public string[]? meaning;
        public string[]? hintMeaning;
        public readonly int _idx;
        public readonly ushort _level;
        public WordData(ushort level,int idx, string word)
        {
            _level = level;
            _idx = idx;
            _word = word;
        }
        public void InitWordData()
        {
            if (meaning == null) return;
            List<string> hintm = new List<string>();

            foreach (string m in meaning)
            {
                if (m.Length <= 1) continue;

                string rm = m.Replace(" ", "");
                string hm = new string('#', rm.Length);
                int randomIdx = Random.Shared.Next(rm.Length);
                char[] hc = hm.ToCharArray();
                hc[randomIdx] = rm.ToCharArray()[randomIdx];
                
                hintm.Add(new string(hc));
            }

            hintMeaning = hintm.ToArray();

        }
        public bool IsSimilar(string s)
        {
            if (meaning == null) return false; 
            foreach (string m in meaning)
            {
                if (m.Replace(" ", "").Contains(s)) return true;
            }
            return false;
        }
        public bool IsAnswer(string s)
        {
            if(meaning == null) return false;

            foreach (string m in meaning)
            {
                if (m.Replace(" ", "") == s) return true;
            }
            return false;
        }
    }
}
