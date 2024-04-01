//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] Array(){
    Console.Write("Введите количество строк, которые хотите ввести: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] stringarray = new string[n];
    for (int i = 0; i < n; i++){
        Console.Write("Введите строку №{0}:\r\n    ", i + 1);
        stringarray[i] = Console.ReadLine();
        }
    for (int i = 0; i < n; i++){
        Console.WriteLine(stringarray[i]);
    }
    return stringarray;
}
