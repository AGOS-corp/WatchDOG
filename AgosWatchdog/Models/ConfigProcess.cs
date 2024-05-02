using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace AgosWatchdog.Models
{
    public class ConfigProcess
    {
        private static string _processPathFile = AppDomain.CurrentDomain.BaseDirectory + "\\ProcessConfig.json";

        public ConfigProcess()
        {
            ReadJson();
        }
        
        public static void ReadJson()
        {
            if (File.Exists(_processPathFile))
            {
                var jsonData = File.ReadAllText(_processPathFile);
                var data = JsonConvert.DeserializeObject<dynamic>(jsonData);

                var _processList = JsonConvert.DeserializeObject<List<FileInfo>>(data["ProcessList"].ToString());
                GlobalData.fileInfoList = _processList;
            }

           
            // WriteJson(_processList);
        }

        public static void WriteJson(List<FileInfo> processList)
        {
            
            var jsonData = JsonConvert.SerializeObject(new { ProcessList = processList });
            File.WriteAllText(_processPathFile, jsonData);
        }
    }
}