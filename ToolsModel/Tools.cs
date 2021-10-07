using System;


namespace ToolsModel{
    public class Tools{
        public string Get_DataRow(){
            string[] data = new string[]{"測試","GIT","功能"};
            string result = "";
            foreach(string str in data){
                result += str;
            }
            return result;
        }
    }
}