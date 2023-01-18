// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
/*
Console.Write("Введи число: ");
int limit = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {limit} равна {GetSum(limit)}");
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {Num} равна {GetSum(Num)}");

// ----------МЕТОДЫ----------

int GetSum(int A){
    int sum = 0;
    for(int i = 1; i<=A; i++){
        sum += i; // sum = sum + i
    }
    return sum;
}
*/

// программа которая принимает число и на выходе выдает призведение чисел от 1 до N
/*
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел от 1 до {N} равно {GetMultiplay(N)}");

// -------Методы-------

int GetMultiplay(int n){
    int mult = 1;
    for(int i = 1; i <= n; i++){
        mult = mult * i;
    }
    return mult;
}
*/



// задача которая выдает количество цифр в числе
/*
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр в числе {N} получается {GetNumber(N)}");

string M = N.ToString();
Console.WriteLine($"Количество цифр в числе {M} получается {GetNums(M)}");


//--------МЕТОДЫ--------
// метод математический
int GetNumber(int num){
    int count = 0;
    if(num == 0) return 1;
    while(num > 0){
        count ++;
        num = num / 10;
    }
    return count;
}


// метод строковый
int GetNums(string num){
    int a = num.Length;
    return a;
}
*/



// задача которая выводит массив из 8 элементов 
/*
int[] myArray = GetArray (8);
Console.WriteLine($"[{String.Join(',', myArray)}]");




// ---методы---заполнения массива
int [] GetArray(int size){
    int[] myArray = new int [size];
    for(int i = 0; i < size; i++){
        myArray[i] = new Random().Next(2);
    }
    return myArray;
}

*/