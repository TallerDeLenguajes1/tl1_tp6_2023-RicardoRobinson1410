// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("Valor de a:"+a);
Console.WriteLine("Valor de b:"+b);*/
float num;
Console.WriteLine("Ingrese el nunmero que desea invertir:");
string? b=Console.ReadLine();
bool anda=float.TryParse(b,out num);
if(anda)
    {
        if(num>0)
        {
            num=1/num;
            Console.WriteLine("Numero invertido: "+num);
        }
    }