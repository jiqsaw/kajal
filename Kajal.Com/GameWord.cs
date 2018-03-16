using System.Collections.Generic;

namespace Kajal.Com
{
    public class GameWord
    {
        public IList<WordObj> WordData { get; set; }

        private string _videoRoot = "http://www.youtube.com/watch?v=";
        private string _videoCode;

        public string VideoCode
        {
            get { return _videoRoot + _videoCode; }
            set { _videoCode = value; }
        }

    }

    public class WordObj
    {
        public string Word { get; set; }
        public string DisplayName { get; set; }
    }
}