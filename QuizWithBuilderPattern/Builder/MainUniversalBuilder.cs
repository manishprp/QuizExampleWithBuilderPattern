using QuizWithBuilderPattern.Common;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace QuizWithBuilderPattern.Builder
{
    public class MainUniversalBuilder<T> 
    {
        //public static MainUniversalBuilder Instance;
        //public static MainUniversalBuilder GetInstance() { 
        //    if(Instance==null)
        //    return Instance = new MainUniversalBuilder(); 
        //    else return Instance;
        //}
        //public string name;
        public AllInputVariables AllInputVariables = AllInputVariables.GetInstance();

        //private List<InputData> _userInputAtributes = new ();
        //private List<AllUiVariablesEnum> _userInputToExtract = new ();
        //public MainUniversalBuilder StoreUserInput(Type type,string input, AllUiVariablesEnum variableenum) 
        //{
        //    var dict = new InputData();
        //    dict.Type = type; dict.Input = input.ToString(); dict.UiVariablesEnum = variableenum;
        //   _userInputAtributes.Add(dict);
        //    return this;
        //}
        public MainUniversalBuilder<T> StoreUserInput<K>(string propertyName, K value)
        {
            //if (_allInputVariables == null)
            //{
            //    _allInputVariables = AllInputVariables.GetInstance();
            //}
            var property = typeof(AllInputVariables).GetProperty(propertyName);
            if (property != null && property.CanWrite)
            {
                property.SetValue(AllInputVariables, value);
            }
            return this;
        }
        public MainUniversalBuilder<T> Execute()
        {
            //if(_userInputAtributes.Any())
            //{
            //    foreach(var atribute in _userInputAtributes)
            //    {
            //        _allInputVariables.InsertData(atribute);
            //    }
            //}
            //if(_userInputToExtract.Any())
            //{
            //    foreach(var dataenum in _userInputToExtract)
            //    {
            //        name = (String)_allInputVariables.OutputDat(dataenum);
            //    }
            //}
            
            //_userInputToExtract.Clear();
            //_userInputAtributes.Clear();
            return this;
        }

        //public MainUniversalBuilder<T> ExtractStoredInput(string propertyName="")
        //{
        //    var property = typeof(AllInputVariables).GetProperty(propertyName);
        //    if (property != null && property.CanRead)
        //    {
        //        //=(String)property.GetValue(_allInputVariables, null);
        //        //property.SetValue(_allInputVariables, value);
        //    }
        //    //_userInputToExtract.Add(variableenum);
        //    return this;
        //}
    }
}
