using StringManager.Domain.Enums;

namespace StringManager.Domain
{
    public class StringManagerParam
    {
        public string StringToConverter { get; set; }
        public ConverterTypeEnum ConverterType { get; set; }
        public bool SplitPerLine { get; set; }
        public string StartWith { get; set; }
        public string EndWith { get; set; }
    }
}
