using WorldWarMuseumMorse.Models;

namespace WorldWarMuseumMorse
{
    public class DecodeMorseTwoPointers
    {
        public Dictionary<string, string> MorseWords { get; set; }
        public Dictionary<char, string> DictLetters { get; set; }

        public DecodeMorseTwoPointers(List<string> words)
        {
            MorseWords = new Dictionary<string, string>();
            DictLetters = WorldWarMuseumMorse.DictLetters.GetDictLetters();
            CodeWordsToMorse(words);
        }

       

        public List<string> Decode(string sentence)
        {
            var grafWords = new List<GrafWords>();
            DecodeGroupedWords(sentence, grafWords);
            return ParseToSentence(grafWords);
        }

        private void CodeWordsToMorse(List<string> words)
        {
            HashSet<string> list = new HashSet<string>();
            words.ForEach(word => LettersToMorse(word));
        }

        private void LettersToMorse(string word)
        {
            var result = "";
            word.ToUpper().ToArray().ToList().ForEach(letter =>
            {
                result += DictLetters[letter];
            });
            MorseWords.Add(word, result);
        }

        private Dictionary<string, string> DecodeGroupedWords(string sentence, List<GrafWords> grafWords)
        {
            if(String.IsNullOrEmpty(sentence)) return new Dictionary<string, string>();
            var words = GetWordsByLetter(sentence[0]);
            words = words.Where(c => sentence.StartsWith(c.Value)).ToDictionary();
            foreach (var item in words)
            {
                var result = DecodeGroupedWords(sentence.Substring(item.Value.Length), grafWords);
                grafWords.Add(new GrafWords { Word = item.Key, NextWords = result.Keys.ToList() });
            }
            return words;
        }

        private Dictionary<string, string> GetWordsByLetter(char letter)
        {
            return MorseWords.Where(word => word.Value.StartsWith(letter)).ToDictionary();
        }

        private List<string> ParseToSentence(List<GrafWords> grafWords)
        {
            var result = new List<string>();
            grafWords.Where(word => word.NextWords.Count == 0).ToList()
                .ForEach(word => SearchBeforeWord(word.Word, grafWords, result));
            return result;
        }

        private void SearchBeforeWord(string word, List<GrafWords> grafWords, List<string> result)
        {
            var prevWords = grafWords.Where(w => w.NextWords.Contains(word)).Select(c => c.Word).ToList();
            prevWords.ForEach(prevWord =>
            {
                if (prevWord != null)
                {
                    if (result.Any(c => c.StartsWith(word)))
                        result.ForEach(c =>
                        {
                            if (c.StartsWith(word)) c = c.Insert(0, $"{prevWord} {word} ");
                        });
                    else
                    {
                        result.Add($"{prevWord} {word}");
                        SearchBeforeWord(prevWord, grafWords, result);
                    }
                }
            });
        }
    }
}
