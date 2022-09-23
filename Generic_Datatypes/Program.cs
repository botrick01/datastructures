// See https://aka.ms/new-console-template for more information
using Generic_Datatypes;
GenericList<int> list = new GenericList<int>();
list.Add(1);
var output = list.Get();
Console.WriteLine(output[0]);