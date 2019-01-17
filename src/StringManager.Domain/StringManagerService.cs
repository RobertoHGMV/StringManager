using StringManager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

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
            var strUpper = GetStringUpper(StringToConverter);
            var strLower = GetStringLower(strUpper);
            var strFirstUp = GetStringFistUpper(strLower);
            var strStart = InserInStart(strFirstUp);
            var strEnd = InserInEnd(strStart);
            var strPerLine = GetStringPerLine(strEnd);

            return strPerLine;
        }

        private string JoinStrings(IList<string> strings)
        {
            var newString = string.Empty;

            foreach (var str in strings)
                newString += $"{str} ";

            return newString;
        }

        private string[] GetStringsSplit(string str)
        {
            return Regex.Split(str, @"\s+");
        }

        private string InserInStart(string strToInsertInStart)
        {
            if (string.IsNullOrEmpty(StartWith))
                return strToInsertInStart;

            var strings = GetStringsSplit(strToInsertInStart);
            foreach (var str in strings)
            {
                if (string.IsNullOrEmpty(str)) continue;

                var breackOrSpace = strings.Last() == str ? string.Empty : GetBreakOrSpace(str, strToInsertInStart);
                var strJoin = $"{StartWith}{str}{breackOrSpace}";
                strToInsertInStart = strToInsertInStart.Replace($"{str}{breackOrSpace}", strJoin);
            }

            return strToInsertInStart;
        }

        private string InserInEnd(string strToInsertInEnd)
        {
            if (string.IsNullOrEmpty(StartWith))
                return strToInsertInEnd;

            var strings = GetStringsSplit(strToInsertInEnd);
            foreach (var str in strings)
            {
                if (string.IsNullOrEmpty(str)) continue;

                var breackOrSpace = strings.Last() == str ? string.Empty : GetBreakOrSpace(str, strToInsertInEnd);
                var strJoin = $"{str}{EndWith}{breackOrSpace}";
                strToInsertInEnd = strToInsertInEnd.Replace($"{str}{breackOrSpace}", strJoin);
            }

            return strToInsertInEnd;
        }

        private string GetStringPerLine(string stringToBreak)
        {
            if (!SplitPerLine)
                return stringToBreak;

            var strings = GetStringsSplit(stringToBreak);
            var newString = string.Empty;
            foreach (var str in strings)
                newString += $"{str}{Environment.NewLine}";

            return newString;
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
            if (ConverterTypeEnum.FirstUpper.Equals(ConverterType))
                return new CultureInfo("pt-BR", true).TextInfo.ToTitleCase(str.ToLower());

            return str;
        }

        private string GetBreakOrSpace(string currentStr, string fullStr)
        {
            return fullStr.Contains($"{currentStr}\t") ? "\t" : "\r";
        }
    }
}
