using System.Collections.Generic;

namespace AgosWatchdog.Models
{
    public class ProcessList
    {
        private static ProcessList _instance;

        public static ProcessList GetInstance()
        {
            if (_instance == null)
                _instance = new ProcessList();

            return _instance;
        }

        public List<string> processPaths { get; set; }
    }
}