// Собрать строку с числами от a до b, a <= b
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

// Собрать строку с числами от a до b - 1, a <= b
string NumbersRecMinusOne(int a, int b)
{
    if (a < b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}
Console.WriteLine(NumbersRec(1, 10));
Console.WriteLine(NumbersRecMinusOne(1, 10));

// Собрать строку с числами от a до b, a >= b
string NumbersRecReverse(int a, int b)
{
    if (a <= b) return NumbersRecReverse(a + 1, b) + $"{a} ";
    else return String.Empty;
}
Console.WriteLine(NumbersRecReverse(1, 10));

// Найти сумму чисел от 1 до n\
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumRec(10));

// Факториал числа
int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialRec(10));

// Вычислить a в степени n
int PowerRec(int a, int n)
{
    // return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerRec(2, 10));
Console.WriteLine(PowerRecMath(2, 10));

// Перебор слов
// В некотором машинном алфавите имеются четыре буквы
// "а", "и", "с", "в". Покажите все слова, состоящие из 
// Т букв, которые можно построить из букв этого алфавита.
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        System.Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("abcd", new char[5]);