// Напишите программу, которая на вход число N и выдает таблицу кубов чисел от 1 до N

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

string Cube(int N) {
    int index = 1;

    while(index <= N) {
       int i = index*index*index;
       Console.Write(i + " ");
       index++;
    }
    Console.WriteLine();
    return "Done!";
}

Console.WriteLine(Cube(N));
