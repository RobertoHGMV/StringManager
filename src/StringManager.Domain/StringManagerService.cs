using StringManager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManager.Domain
{
    public class StringManagerService
    {
        public string StringToConverter { get; private set; }
        public ConverterTypeEnum ConverterType { get; private set; }
        public bool SplitPerLine { get; private set; }
        public string StartWith { get; private set; }
        public string EndWith { get; private set; }

        public StringManagerService(StringManagerParam stringManagerParam)
        {
            StringToConverter = stringManagerParam.StringToConverter;
            ConverterType = stringManagerParam.ConverterType;
            SplitPerLine = stringManagerParam.SplitPerLine;
            StartWith = stringManagerParam.StartWith;
            EndWith = stringManagerParam.EndWith;
        }

        public string GetNewString()
        {
            var newStr = GetStringUpper(StringToConverter);
            newStr = GetStringLower(StringToConverter);
            newStr = GetStringFistUpper(StringToConverter);

            var strSplit = GetStringsSplit(newStr);
            var strStart = InserInStart(strSplit);
            var strEnd = InserInEnd(strStart);
            var strPerLine = GetStringPerLine(strEnd);
            var strJoin = JoinStrings(strPerLine);

            return strJoin;
        }

        private string JoinStrings(IList<string> strings)
        {
            var newString = string.Empty;

            foreach (var str in strings)
                newString += str;

            return newString;
        }

        private IList<string> GetStringsSplit(string str)
        {
            return str.Split(' ');
        }

        private IList<string> InserInStart(IList<string> strings)
        {
            if (string.IsNullOrEmpty(StartWith))
                return strings.ToList();

            var newStrings = new List<string>();

            foreach (var str in strings)
                newStrings.Add(string.Join(StartWith, str));

            return newStrings;
        }

        private IList<string> InserInEnd(IList<string> strings)
        {
            if (string.IsNullOrEmpty(EndWith))
                return strings.ToList();

            var newStrings = new List<string>();

            foreach (var str in strings)
                newStrings.Add(string.Join(str, EndWith));

            return newStrings;
        }

        private IList<string> GetStringPerLine(IList<string> strings)
        {
            var newStrings = new List<string>();

            if (SplitPerLine)
            {
                foreach (var strSplit in strings)
                {
                    var strJoin = string.Join(strSplit, "\n");
                    newStrings.Add(strJoin);
                }

                return newStrings;
            }

            return newStrings;
        }

        private string GetStringUpper(string str)
        {
            if (ConverterTypeEnum.Upper.Equals(ConverterType))
                return str.ToUpper();

            return str;
        }

        private string GetStringLower(string str)
        {
            if (ConverterTypeEnum.Lower.Equals(ConverterType))
                return str.ToLower();

            return str;
        }

        private string GetStringFistUpper(string str)
        {
            var strLower = str.ToLower();

            if (ConverterTypeEnum.FirstUpper.Equals(ConverterType))
                return new CultureInfo("pt-BR", true).TextInfo.ToTitleCase(strLower);

            return str;
        }
    }
}
