using org.matheval.Common;
using System;
using System.Collections.Generic;


namespace org.matheval.Functions
{
    public class datetimeFunction : IFunction
    {
        public List<FunctionDef> GetInfo()
        {
            return new List<FunctionDef>
            {
                new FunctionDef(Afe_Common.Const_Datetime, new System.Type[] { typeof(int), typeof(int), typeof(int) }, typeof(DateTime), 3)
            };
        }

        public object Execute(Dictionary<string, object> args, ExpressionContext dc)
        {
            if (!args.ContainsKey("1") || !args.ContainsKey("2") || !args.ContainsKey("3"))
            {
                throw new Exception("Missing parameters for DATETIME function.");
            }

            int year = Convert.ToInt32(args["1"]);
            int month = Convert.ToInt32(args["2"]);
            int day = Convert.ToInt32(args["3"]);
            return new DateTime(year, month, day);
        }   
    }
}
