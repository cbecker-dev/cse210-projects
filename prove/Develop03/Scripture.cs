using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public sealed class Scripture
    {
        private readonly Reference _reference;
        private readonly List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = Tokenize(text).Select(t => new Word(t)).ToList();
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

        public string Render()
        {
            var text = string.Join(" ", _words.Select(w => w.DisplayText()));
            return $"{_reference}\n{text}";
        }

        private static IEnumerable<string> Tokenize(string text)
        {
            var separators = new[] { ' ', '\t', '\n', '\r' };
            return text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }

        private static bool IsPunctuationOnly(Word w)
        {
            var t = w.DisplayText();
            return t.All(ch => !char.IsLetterOrDigit(ch));
        }
    }
}