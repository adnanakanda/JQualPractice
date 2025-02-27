using System.Text.Json.Serialization;

namespace Attributes
{
    internal class MyClass
    {
        List<int> numbers = new List<int> { 2, 4, 6, 8, 10 };
        //[AllowedValues("Hello", "Ignore")]
        [JsonIgnore]
        public string MyProperty { get; set; }
    }
}
