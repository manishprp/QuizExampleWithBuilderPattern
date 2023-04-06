namespace QuizWithBuilderPattern.Common
{
    public class AllInputVariables
    {
        public static AllInputVariables Instance;
        public static AllInputVariables GetInstance()
        {
            if(Instance!=null)
            return Instance;
            else return Instance = new AllInputVariables();
        }
        public string Name { get; set; }
        //public void InsertData(InputData inputDatas)
        //{
        //    switch(inputDatas.UiVariablesEnum)
        //    {
        //       case AllUiVariablesEnum.Name:
        //            Name = inputDatas.Input;
        //            break;
        //    }
        //}
        //public object OutputDat(AllUiVariablesEnum outputenum)
        //{
        //    switch (outputenum)
        //    {
        //        case AllUiVariablesEnum.Name:
        //            return Name;
        //            break;
        //            default: return null;
        //    }
        //}
    }
}
