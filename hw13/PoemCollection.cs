

namespace hw13
{
    class PoemCollection
    {
        private List<Poem> _poems;
        public PoemCollection()
        {
            _poems = new List<Poem>();
        }

        public void AddPoem(Poem poem)
        {
            _poems.Add(poem);
        }
        public void RemovePoem(Poem poem)
        {
            _poems.Remove(poem);
        }

        public void UpdatePoem(Poem oldPoem, Poem newPoem)
        {
            int index = _poems.IndexOf(oldPoem);
            if (index != -1)
            {
                _poems[index] = newPoem;
            }
        }

        public List<Poem> SearchPoemsByName(string name)
        {
            return _poems.FindAll(poem => poem.Name == name);
        }

        public List<Poem> SearchPoemsByAuthorName(string name)
        {
            return _poems.FindAll(poem => poem.AuthorName == name);
        }

        public List<Poem> SearchPoemsByYear(int year)
        {
            return _poems.FindAll(poem => poem.WritingYear == year);
        }

        public List<Poem> SearchPoemsByText(string word)
        {
            return _poems.FindAll(poem => poem.PoemText.Contains(word));
        }
        public List<Poem> SearchPoemsByTheme(string theme)
        {
            return _poems.FindAll(poem => poem.Theme == theme);
        }

        public List<Poem> SearchPoemsByLenght(int len)
        {
            return _poems.FindAll(poem => Length(poem.PoemText) <= len);
        }

        private int Length(string poemText)
        {
            throw new NotImplementedException();
        }

        public void SavePoemsToFile(string filePath)
        {
            string res = _poems.ToString();
            File.AppendAllText(filePath, res);
        }
        public void LoadPoemsFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                var result = File.ReadAllText(filePath);
                Console.WriteLine(result);
            }
        }
    }
}
