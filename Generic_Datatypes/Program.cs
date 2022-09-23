// See https://aka.ms/new-console-template for more information
using Generic_Datatypes;
class Program
{
    static void Main(string[] args)
    {
        var itemStore = new ItemStore<int, double, string>();
        itemStore.Value1 = 5;
        itemStore.Value2 = 4.5;
        itemStore.Value3 = "2";

        var summe = 6 + itemStore.Value1;

        GenericList<string> list = new GenericList<string>();
        list.Add("1");
        var output = list.Get();
        Console.WriteLine(output[0]);
    }
}
class ItemStore<TValueType1, TValueType2, TValueType3>
{
    public TValueType1 Value1 { get; set; }
    public TValueType2 Value2 { get; set; }
    public TValueType3 Value3 { get; set; }
}