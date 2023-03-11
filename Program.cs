using System.Linq;

string[] strTestArray = new string[8]{"tree","kolobok", "words", "yes", "me", "add", "one", "bear"};
string[] strArray;
string text = string.Empty;

//===================================================================================================
// функция принимает строку из слов, разделенных запятыми и возвращает массив из этих слов,
string[] InputStringArray(string textArg) //  включающий в себя слова, содержащие 3 и менее буквы                                   
                                    
{
    var data = textArg.Split(",") 
                .Select(e => e = e.Replace(" ", string.Empty))
               // .Where(e => e.Length <= 3)                                                                    
                .ToArray(); 

    return data;
}

//===================================================================================================
/*string fromArrayToString(string[] array) // функция преобразует массив в строку, вставляя запятые как разделитель между слов
{
    string str = string.Empty;
    for(int i = 0; i < array.Length; i++)
    {
        str = str + "," + array[i];
    }
   // Console.WriteLine(str);
    return str;
}
*/

//===================================================================================================
//Функция выводит в консоль строковый массив
void printArray(string[] arr)
{
    string strPrint = string.Empty;

    
        for(int i = 0; i < arr.Length; i++)
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
    int currPos = 0;
    
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <=3) 
        {
            tempArr[currPos] = arr[i];
            currPos++;   
        }
    }

    string[] arrThreeAndLess = new string[currPos];
    for(int i = 0; i < currPos; i++)
    {
        arrThreeAndLess[i] = tempArr[i];
    }

    return arrThreeAndLess;
}

void pauseText()
{
    Console.WriteLine();
    Console.WriteLine("Нажмите клавишу Enter для продолжения...");
    Console.ReadLine();
    Console.WriteLine();
}

void mainMenu()
{
    string userChoice = string.Empty;
    bool getOut = false;

    

    while (getOut != true)
    {
        Console.Clear();

        Console.WriteLine("Для работы программы необходим массив строковых переменных,");
        Console.WriteLine("варианты формирования массива:");
        Console.WriteLine();
        Console.WriteLine("1. Воспользоваться тестовым массивом, имеющимся в программе");
        Console.WriteLine("2. Ввести свой набор слов вручную");
        Console.WriteLine();
        Console.WriteLine("Введите выбранный вариант (цифра '1' либо цифра '2') либо 'q' ('Q') для выхода из программы.");
        Console.WriteLine();

        userChoice = string.Empty;
        userChoice = Console.ReadLine();

        switch(userChoice)
        {
            case "1":
            {
                userChoice = string.Empty;
                Console.WriteLine();
                Console.WriteLine("Исходный массив:");
                printArray(strTestArray);
                Console.WriteLine();
                strArray = toThreeAndLess(strTestArray);
                Console.WriteLine("Новый массив, отвечающий требованиям:");
                printArray(strArray);

                pauseText();

                break;
            }

            case "2":
            {
                Console.WriteLine("Введите массив элементов строкового типа.");
                Console.WriteLine("Для упрощения задачи достаточно ввести массив как строку, разделяя слова-элементы запятыми");
                Console.WriteLine("Программа сама сформирует из них массив. Итак, Ваша строка: ");
                Console.WriteLine();

                text = Console.ReadLine();

                strArray = InputStringArray(text);
                Console.WriteLine();
                Console.WriteLine("Введенная строка преобразована в массив: ");
                printArray(strArray);
                Console.WriteLine();

                
                strArray = toThreeAndLess(strArray);

                if(strArray.Length > 0)
                {
                    Console.WriteLine("Новый массив, отвечающий требованиям:");
                    printArray(strArray);
                }
                else
                {
                    Console.WriteLine("Введенный массив не содержит отвечающих условиям значений.");
                }

                pauseText();
                break;
            }

            case "q":
            {
                Console.WriteLine("Программа завершает работу. Всего доброго!");
                getOut = true;
                break;
            }
        
            case "Q":
            {
                Console.WriteLine("Программа завершает работу. Всего доброго!");
                getOut = true;
                break;
            }

            default:
            {
                Console.WriteLine("Ошибочный ввод, попробуйте ввести еще раз:");
                pauseText();
                break;
            }
        }
    }
    Console.WriteLine();
    Console.Clear();

        
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
    printArray(strArray);
    Console.WriteLine();

    Console.WriteLine("Полученный массив:");
    printArray(toThreeAndLess(InputStringArray((text))));
}

mainMenu();
