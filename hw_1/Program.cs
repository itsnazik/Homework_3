// Напишите программу, котрая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число: ");
int val = Convert.ToInt32(Console.ReadLine());

int GetFirst (int val) {
    int first = val / 10000;
    return first;
}
int GetSecond (int val) {
    int second = (val / 1000) % 10;
    return second;
}
int GetThird (int val) {
    int third = (val / 100) % 10;
    return third;
}
int GetFourth (int val) {
    int fourth = val % 100 / 10;
    return fourth;
}
int GetFifth (int val) {
    int fifth = val % 10;
    return fifth;
}
    int a = GetFirst(val);
    int b = GetSecond(val);
    int c = GetThird(val);
    int d = GetFourth(val);
    int e = GetFifth(val);

int Palindrome(int a, int b, int c, int d, int e, int val) {
    if(a == e && b == d) {
        Console.WriteLine("Да, число является палиндромом!");
    }
    else {
        Console.WriteLine("Нет, число не является палиндромом!");
    }
    return 0;
}

if (val > 9999 && val < 100000) {
    Console.WriteLine(Palindrome(a, b, c, d, e, val));
}
else {
    Console.WriteLine("Введите корректное число!");
}
