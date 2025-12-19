using System.Security.Cryptography.X509Certificates;

namespace DependencyInjectionPatternNotePad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpellCheckerFactor factory = new SpellCheckerFactor();
            ISpellChecker somechecker = factory.GetSpellChecker("sp");
            Notepad notepad = new Notepad(somechecker);
            notepad.Cut();
            notepad.SpellChek();

            HindiSpellChecker hindichecker = new HindiSpellChecker();
            Notepad forhindi = new Notepad(hindichecker);
            forhindi.Cut();
            forhindi.SpellChek();
        }
    }
    public class Notepad
    {
        private ISpellChecker _checker;
        public Notepad(ISpellChecker cheker)
        {
            SpellCheckerFactor factory = new SpellCheckerFactor();
            if(cheker == null)
            {
                _checker = factory.GetSpellChecker("en");
            }
            else
            {
                _checker = cheker;
            } 
        }

        public void Cut()
        {
            Console.WriteLine("Text cut done");
        }

        public void Copy()
        {
            Console.WriteLine("Text copy done ");
        }
        public void Paste()
        {
            Console.WriteLine("Text Paste done ");
        }
        public void SpellChek()
        {
            _checker.DospellCheck();
        }
    }
    
    public class SpellCheckerFactor
    {
        ISpellChecker _somechecker = null;
        public ISpellChecker GetSpellChecker(string lang)
        {
            switch (lang)
            {
                case "en":
                    _somechecker = new EnglishSpellChecker();
                    break;

                case "gr":
                    _somechecker = new GermanSpellChecker();
                    break;

                case "sp":
                    _somechecker = new SpanishSpellChecker();
                    break;

                default:
                    _somechecker = new EnglishSpellChecker();
                    break;
            }
            return _somechecker;
        }
    }
    public interface ISpellChecker
    {
        void DospellCheck();
    }
    public class EnglishSpellChecker: ISpellChecker
    {
        public void DospellCheck()
        {
            Console.WriteLine("Speck Check done for English Text");
        }
    }

    public class GermanSpellChecker : ISpellChecker
    {
        public void DospellCheck()
        {
            Console.WriteLine("Speck Check done for German Text");
        }
    }

    public class SpanishSpellChecker : ISpellChecker
    {
        public void DospellCheck()
        {
            Console.WriteLine("Speck Check done for Spanish Text");
        }
    }

    public class HindiSpellChecker : ISpellChecker
    {
        public void DospellCheck()
        {
            Console.WriteLine("Speck Check done for Hindi Text");
        }
    }
}