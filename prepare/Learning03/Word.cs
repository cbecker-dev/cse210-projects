using System;
using System.Linq;

namespace ScriptureMemorizer
{
    class Word
    {
        private readonly string _text;
        private bool _isHidden;

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        public void Hide() => _isHidden = true;
        public bool IsHidden => _isHidden;

        public string DisplayText()
        {
            if (!_isHidden) return _text;

            bool lettersOrDigits = _text.Any(char.IsLetterOrDigit);
            return lettersOrDigits ? new string('_', _text.Length) : _text;
        }
    }
}