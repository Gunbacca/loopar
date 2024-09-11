/*int tal = 1;
while(tal <=20)
{

Console.WriteLine(tal);
tal++;
}
*/

/*Console.Write("säg ett nummer mellan 1-100 ");
int tal = int.Parse(Console.ReadLine());
while(tal<=101){
    Console.WriteLine(tal);
    tal++;
}*/

/*for(int i=1;i<=20;i++)
{
    Console.WriteLine(i);
}
*/



int antaltal;
double summa = 0, input;
Console.Write("Atal tal som ska matas in?");
antaltal = Convert.ToInt32(Console.ReadLine());
for (int i=1; i<= antaltal; i++)
{
    Console.Write("Skriv värde" + i +": ");
    input = Convert.ToDouble(Console.ReadLine());
    summa=summa + input;
}
Console.WriteLine("Medelvärdet är:" + (summa / antaltal));
Console.WriteLine("Minsta värdet är: " + smallestvalue);
Console.WriteLine("Minsta värdet är: " + biggestvalue);
