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
            int hour = args.ContainsKey("4") ? Convert.ToInt32(args["4"]) : 0;
            int minute = args.ContainsKey("5") ? Convert.ToInt32(args["5"]) : 0;
            int second = args.ContainsKey("6") ? Convert.ToInt32(args["6"]) : 0;
            return new DateTime(year, month, day, hour, minute, second);
        }   
    }
}
