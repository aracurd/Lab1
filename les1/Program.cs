using System;

namespace les1
{
    public class Program
    {

        private static void Main(string[] args)
        {
            //1

            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //2

            //for (int i = 100; i <= 200; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //3

            //for (int i = 200; i >= 100; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //4

            //for (int i = 0; i < 50; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //    continue;
            //}

            //5

            //var res = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    res += i;

            //}
            //WriteLine(res);

            //6

            //var res = 1;
            //for (int i = 1; i <= 10; i++)
            //{
            //    res *= i;

            //}
            //WriteLine(res);

            //7

            //string val = ReadLine();
            //foreach (var i in val)
            //{
            //    Write($"{i} ");
            //}

            //8

            //var num = 32.596.ToString().Split(',');

            //WriteLine(num[0]);
            //WriteLine(num[1]);

            //9

            //string val = ReadLine();
            //var sum = 0;
            //for (int i = 0; i < val.Length; i++)
            //{
            //    int num =  val[i];
            //    sum += num;
            //}
            //WriteLine(sum);


            //10
            //var value = ReadLine()?.ToCharArray();
            //Array.Reverse(value);
            //WriteLine(new string(value));

            //10

            //var val = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    val[i] = i;
            //}
            //foreach (var i in val)
            //    Write(i+" ");
            //var count = int.Parse(ReadLine());
            //var nCount = new int[count];

            //11

            //    string[] inputs = ReadLine()?.Split(' ');
            //    nCount = inputs?.Where(s => !String.IsNullOrWhiteSpace(s)).Select(int.Parse).ToArray();

            //foreach (var i in nCount)
            //    Write(i + " ");

            //13

            //var count = int.Parse(ReadLine());
            //var nCount = new int[count];
            //string[] inputs = ReadLine()?.Split(' ');
            //    nCount = inputs?.Where(s => !String.IsNullOrWhiteSpace(s)).Select(int.Parse).ToArray();
            //var summ = nCount.Sum();
            //WriteLine(summ);

            //12

            //var count = int.Parse(ReadLine());
            //var nCount = new int[count];
            //string[] inputs = ReadLine()?.Split(' ');
            //nCount = inputs?.Where(s => !String.IsNullOrWhiteSpace(s)).Select(int.Parse).ToArray();
            //int summ = 1;
            //foreach (var i in nCount)
            //    summ *= i;

            //13

            //var count = int.Parse(ReadLine());
            //var nCount = new int[count];
            //string[] inputs = ReadLine()?.Split(' ');
            //nCount = inputs?.Where(s => !String.IsNullOrWhiteSpace(s)).Select(int.Parse).ToArray();
            //WriteLine(nCount.Min());

            //14
            //var count = int.Parse(ReadLine());
            //var nCount = new int[count];
            //string[] inputs = ReadLine()?.Split(' ');
            //nCount = inputs?.Where(s => !String.IsNullOrWhiteSpace(s)).Select(int.Parse).ToArray();
            //WriteLine(nCount.Max());


            //15
            //var count = int.Parse(ReadLine());
            //var nCount = new int[count];
            //string[] inputs = ReadLine()?.Split(' ');
            //nCount = inputs?.Where(s => !String.IsNullOrWhiteSpace(s)).Select(int.Parse).ToArray();
            //var summ = nCount.Sum();
            //WriteLine(summ/nCount.Length);

            //16

            //var count = int.Parse(ReadLine());
            //var nCount = new int[count];
            //string[] inputs = ReadLine()?.Split(' ');
            //nCount = inputs?.Where(s => !String.IsNullOrWhiteSpace(s)).Select(int.Parse).ToArray();
            //Array.Sort(nCount);
            //var temp = nCount[count-1];
            //nCount[count-1] = nCount[0];
            //nCount[0] = temp;
            //foreach (var i in nCount)
            //    Write(i);


            //17

            //string[] inputs = ReadLine()?.Split(' ');
            //var first = inputs?.Where(s => !String.IsNullOrWhiteSpace(s)).Select(int.Parse).ToArray();
            //string[] input2 = ReadLine()?.Split(' ');
            //var second = input2?.Where(s => !String.IsNullOrWhiteSpace(s)).Select(int.Parse).ToArray();

            //if (first.Length != second.Length)
            //{
            //    Write("не равны");
            //    ReadLine();
            //    return;
            //}

            //for (int i = 0; i < first.Length; i++)
            //{
            //    if (first[i] != second[i])
            //    {
            //        Write("не равны");
            //        ReadLine();
            //        return;
            //    }

            //}
            //Write("равны");

            //18
            //string[] inputs = ReadLine()?.Split(' ');
            //var nCount = inputs?.Where(s => !String.IsNullOrWhiteSpace(s)).Select(int.Parse).ToArray();

            //for (int i = 0; i < nCount.Length; i++)
            //{
            //    nCount[i] = nCount[i] * 2;
            //}

            //foreach (var i in nCount)
            //Write(i+" ");

            //19

            //var mainValue = ReadLine().Split('.');
            //var argValue = ReadLine();

            //List<string> temp = new List<string>();
            //temp = mainValue.ToList();

            //for (int i = 0; i < temp.Count; i++)
            //{
            //    if (temp[i].Contains(argValue))
            //    {
            //        WriteLine(temp[i]);
            //        WriteLine(i);
            //    }
            //}


            //20
            //var mainValue = ReadLine().Split(' ');
            //var argValue = ReadLine();

            //List<string> temp = new List<string>();
            //temp = mainValue.ToList();

            //for (int i = 0; i < temp.Count; i++)
            //{
            //    if (temp[i].Contains(argValue))
            //    {
            //        temp.RemoveAt(i);
            //    }
            //}
            //foreach (var t in temp)
            //{
            //    Write(t+" ");
            //}




            //21
            //var count = int.Parse(ReadLine());
            //var random = new Random();
            //var RundomNumber = new int[count];
            //for (var i = 0; i < RundomNumber.Length; i++)
            //{
            //    bool contais;
            //    int next;
            //    do
            //    {
            //        next = random.Next(10);
            //        contais = false;
            //        for (var j = 0; j < i; j++)
            //        {
            //            var n = RundomNumber[j];
            //            if (n != next) continue;
            //            contais = true;
            //            break;
            //        }
            //    } while (contais);
            //    RundomNumber[i] = next;
            //}

            //foreach (var r in RundomNumber)
            //        Write(r+" ");
            //Array.Sort(RundomNumber);
            //WriteLine();
            //foreach (var r in RundomNumber)
            //    Write(r + " ");


            //22
            //var card = new Card() {CardNimber = "10", CardSuit = "red"};
            //var card2 = new Card() { CardNimber = "King", CardSuit = "Black" };

            Console.ReadLine();


        }



    }
}