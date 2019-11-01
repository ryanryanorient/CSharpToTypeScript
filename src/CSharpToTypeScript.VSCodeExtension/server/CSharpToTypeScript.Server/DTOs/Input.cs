using CSharpToTypeScript.Core.Options;

namespace CSharpToTypeScript.Server.DTOs
{
    public class Input
    {
        public string Code { get; set; }
        public bool UseTabs { get; set; }
        public int? TabSize { get; set; }
        public bool Export { get; set; }
        public DateOutputType ConvertDatesTo { get; set; }
        public NullableOutputType ConvertNullablesTo { get; set; }
        public bool ToCamelCase { get; set; }

        public CodeConversionOptions MapToCodeConversionOptions()
            => new CodeConversionOptions(Export, UseTabs, TabSize, ConvertDatesTo, ConvertNullablesTo, ToCamelCase);
    }
}