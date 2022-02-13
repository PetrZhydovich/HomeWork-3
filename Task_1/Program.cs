//  Задать номер четверти, показать диапазоны для возможных координат

int GetRandomNumber()
{
    int randomNumb = new Random().Next(1,5);
    return randomNumb;
}
void Coordinati(int chet) 
{
    if(chet == 1)
        Console.WriteLine("для этой четверти возможны координаты Из диапазона x>0,y>0");
    else if(chet == 2)
        Console.WriteLine ("для этой четверти возможны координаты Из диапазона x<0,y>0");
    else if(chet == 3)
        Console.WriteLine ("для этой четверти возможны координаты Из диапазона x<0,y<0");
    else if(chet == 4)
        Console.WriteLine ("для этой четверти возможны координаты Из диапазона x>0,y<0"); 

}

int chetvert = GetRandomNumber();
Console.WriteLine($"номер четверти: {chetvert}");
Coordinati(chetvert); 