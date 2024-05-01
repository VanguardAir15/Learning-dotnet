// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!\n");
Console.WriteLine("Hello ViperArcde15!\n");
var name="ViperArcde15";
Console.WriteLine("Hello "+name+"!\n");
var name2="ViperArcde15";
Console.WriteLine($"Hello {name2}!\n");
var name3="ViperArcde15";
Console.WriteLine($"Hello {name3.ToUpper()}!\n"); //name.ToUpper makes the name all caps
var names=new[]{"ViperArcde15", "Felipe", "Emilia"};
foreach(var name4 in names){
    Console.WriteLine($"Hello {name4.ToUpper()}!"); 
}
