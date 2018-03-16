using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB.ExtentionMethods;

namespace Kajal.Com
{
    public class GameMechanic
    {
        #region InitialConf
        private static GameMechanic _GameMechanic;

        public static GameMechanic GetInstance()
        {
            if (_GameMechanic == null)
                _GameMechanic = new GameMechanic();
            return _GameMechanic;
        }

        #endregion
        
        public IList<string> Sentences;
        public IDictionary<string, string> Words;

        private GameMechanic() {

            this.Sentences = GameData.Sentences;

            this.Words = GameData.Words;

        }

        public Com.GameWord NextWordPart(string GameCurrWord)
        {
            var model = new Com.GameWord();

            var wordDataParts = GameData.Words[GameCurrWord].Split('|');
                                  
            model.WordData = new List<WordObj>();

            WordObj wordObj = null;

            // [0] == Word, DisplayName
            wordObj = new WordObj();
            wordObj.Word = wordDataParts[0].Split(',')[0].TrimStart().TrimEnd();
            wordObj.DisplayName = wordDataParts[0].Split(',')[1].TrimStart().TrimEnd();
            model.WordData.Add(wordObj);
        
            // [1] == VideoCode
            model.VideoCode = wordDataParts[1].ToString().Trim();


            // [2] == Alternative Words [,]
            foreach (var item in wordDataParts[2].Split(','))
            {
                wordObj = new WordObj();
                wordObj.DisplayName = item.TrimStart().TrimEnd();
                wordObj.Word = item.TrimStart().TrimEnd();
                model.WordData.Add(wordObj);
            }

            model.WordData = model.WordData.Randomize().ToList();

            return model;
        }

        public List<string> GetRandomSentence()
        {
            return this.Sentences.Skip(new Random().Next(this.Sentences.Count)).ToList().Take(1).FirstOrDefault().Split(' ').ToList();
        }

        public bool CheckEndGame(List<string> GameCurrSentence, int GameCurrIndex)
        {
            return (GameCurrSentence.Count() - 1 <= GameCurrIndex);
        }

    }
}