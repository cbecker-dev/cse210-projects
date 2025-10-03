using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace ScriptureMemorizer
{
    class ScriptureMemorizer
    {
        private readonly Reference _reference;
        private readonly List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = Tokenized(text).Select(text => new Word.(text)).ToList();
        }

        public bool AllWordsHidden => _words.All(w => w.IsHidden || IsPunctuationOnly(w));

        public void HideRandomWords(int count, Random rng)
        {
            var candidates = _words
                .Where(w => !w.IsHidden && !IsPunctuationOnly(w))
                .ToList();

            count = Math.Min(count, candidates.Count);

            for (int i = 0; i < count; i++)
            {
                int idx = rng.Next(candidates.Count);
                candidates[idx].Hide();
                candidates.RemoveAt(idx);
                if (candidates.Count == 0) break;
            }
        }
    }
}