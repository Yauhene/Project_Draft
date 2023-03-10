using System.Linq;

string[] strTestArray = new string[8]{"tree","kolobok", "words", "yes", "me", "add", "one", "bear"};
string[] strArray;
string text = "tree, kolobok, words, Yes, me, add, one, bear" ;
//===================================================================================================
string[] InputStringArray(string text) // функция принимает строку из слов, разделенных запятыми
                                    // и возвращает массив из этих слов, включающий в себя 
                                    // слова, содержащие 3 и менее буквы
{
    //Console.WriteLine(text);

    var data = text.Split(",") 
                .Select(e => e = e.Replace(" ", string.Empty))
               // .Where(e => e.Length <= 3)                                                                    
                .ToArray(); 

    return data;
}

//===================================================================================================
string fromArrayToString(string[] array) // функция преобразует массив в строку, вставляя запятые как разделитель между слов
{
    string str = string.Empty;
    for(int i = 0; i < array.Length; i++)
    {
        str = str + "," + array[i];
    }
   // Console.WriteLine(str);
    return str;
}

//===================================================================================================
//Функция распечатывает строковый массив
void printArray(string[] arr, int len)
{
    string strPrint = string.Empty;
    for(int i = 0; i < len; i++)
    {
        strPrint = strPrint + arr[i] + ", ";
        
    }
    Console.WriteLine(strPrint);
}

//===================================================================================================
// Функция возвращает новый строковый массив со строками из введенного массива длиной 3 и менее букв
string[] toThreeAndLess(string[] arr)
{
    int tempArrLength = arr.Length;
    string[] tempArr = new string[arr.Length];
    //int correctCount = 0;
    int currPos = 0;
    //Console.WriteLine($"arr.Length = {arr.Length}");
    for(int i = 0; i < arr.Length; i++)
    {

        if (arr[i].Length <=3) 
        {
            tempArr[currPos] = arr[i];
            currPos++;
           
        }

        //Console.WriteLine($"i = {i}, currPos = {currPos}, arr[i] = {arr[i]}, tempArr[currPos] = {tempArr[currPos]}");
        //Console.ReadLine();
        
    }

    //Console.WriteLine($"currPos = {currPos}, tempArr.Length = {tempArr.Length}");
    //Console.ReadLine();

    //printArray(tempArr, tempArr.Length);
    //correctCount = currPos;
    //Console.WriteLine($"tempArr.Length = {tempArr.Length}, correctCount = {correctCount}");
    

    string[] arrThreeAndLess = new string[currPos];
    for(int i = 0; i < currPos; i++)
    {
       //Console.WriteLine($"i = {i}, arrThreeAndLess[i] = {arrThreeAndLess[i]}, tempArr[i] = {tempArr[i]}");
        arrThreeAndLess[i] = tempArr[i];
    }

    return arrThreeAndLess;
}

void generalMethod()
{
    string userChoice = string.Empty;

    Console.WriteLine("Для работы программы необходим массив строковых переменных,");
    Console.WriteLine("варианты формирования массива:");
    Console.WriteLine();
    Console.WriteLine("1. Воспользоваться тестовым массивом, имеющимся в программе");
    Console.WriteLine("2. Ввести свой набор слов вручную");
    Console.WriteLine();
    Console.WriteLine("Введите выбранный вариант (цифра '1' либо цифра '2')");

    userChoice = Console.ReadLine();

    
    switch(userChoice)
    {
        case "1":
        {

            break;
        }

        case "2":
        {

            break;
        }


    }
    
}

void Test()
{
    // strArray = ThreeAndLess(text);
    // for (int i = 0; i < strArray.Length; i++)
    // {
    //     Console.WriteLine(strArray[i]);
    // }

    // for (int i = 0; i < strTestArray.Length; i++)
    // {
    //     Console.WriteLine(strTestArray[i]);
    // }

    // Console.WriteLine("Изначальный массив:");
    // printArray(strTestArray, strTestArray.Length);
    // Console.WriteLine();

    // strArray = toThreeAndLess(strTestArray);


    // Console.WriteLine("Полученный массив:");
    // printArray(toThreeAndLess(strArray), strArray.Length);
    Console.WriteLine("Ведите массив слов просто перечислив их через запятую");
    text = Console.ReadLine();
    Console.WriteLine();

    strArray = InputStringArray(text);
    Console.WriteLine("Изначальный массив::");
    printArray(strArray, strArray.Length);
    Console.WriteLine();

    Console.WriteLine("Полученный массив:");
    printArray(toThreeAndLess(InputStringArray((text))),toThreeAndLess(InputStringArray((text))).Length);
}

Test();
