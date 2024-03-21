
int[] intArray = new int[3];

int[] secondIntArray = new int[] {4, 5, 6};

Array.Resize(ref intArray, 5);


Console.WriteLine("====Lists====");

List<int> integerList = new List<int>(); //an empty list
Console.WriteLine($"integer list count : {integerList.Count}");
integerList.Add(5);
integerList.Add(66);
integerList.Add(-700);

Console.WriteLine($"integer list count : {integerList.Count}");


integerList.Remove(66);

Console.WriteLine($"integer list count : {integerList.Count}");

foreach(int i in integerList)
{
    Console.WriteLine(i);
}

integerList.RemoveAt(0);

Console.WriteLine("afterremove");

foreach(int i in integerList)
{
    Console.WriteLine(i);
}

List<string> secondList = new List<string> { "sadds", "dsadasd", "fsferfesf", "dsadadas" };
secondList.RemoveAt(2);

Console.WriteLine("secondList");

foreach (string s in secondList)
{
    Console.WriteLine(s);
}

Console.WriteLine(secondList[2]);

//dictonary

Console.WriteLine("====Dictonary====");

Dictionary<int, string> productsInMarket = new Dictionary<int, string>();



productsInMarket.Add(111, "Milk");
productsInMarket.Add(222, "Bread");
productsInMarket.Add(333, "Chocoilate");

foreach (KeyValuePair<int, string> item in productsInMarket)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}
bool product222exist = productsInMarket.ContainsKey(222);

if (product222exist)
{ 
Console.WriteLine($"Product with code 222 is {productsInMarket[222]}");
}

//foreach (var item in productsInMarket) // we cam use this so we wont use Keyvaluepar
//{
//}


Console.WriteLine("====Queue====");

Queue<int> integerQueue = new Queue<int>();

integerQueue.Enqueue(200);//add 200 at the end to the queue
integerQueue.Enqueue(3200);
integerQueue.Enqueue(-700);
integerQueue.Enqueue(32134);
integerQueue.Enqueue(4324434);
integerQueue.Enqueue(432423554);
integerQueue.Enqueue(-98890);

foreach (int integer in integerQueue)
{
    Console.WriteLine(integer);
}

//get a member in a queue

//if we want just to see the memeber we will use Pick

//if we want to take out a member Dequeue

int fristMember = integerQueue.Dequeue();   
Console.WriteLine($"number of members are{integerQueue.Count}");

foreach (int integer in integerQueue)
{
    Console.WriteLine(integer);
}

int valueOfFirstMember = integerQueue.Peek();

foreach (int integer in integerQueue)
{
    Console.WriteLine(integer);
}

Console.WriteLine(valueOfFirstMember);


Console.WriteLine("====Stack====");

Stack<string> stringStack = new Stack<string>();

stringStack.Push("C#");
stringStack.Push("JS");
stringStack.Push("Java");
stringStack.Push("Python");
foreach (string language in stringStack)
{
    Console.WriteLine($"{language}");
}

string lastMember = stringStack.Pop();
foreach (string language in stringStack)
{
    Console.WriteLine($"{language}");
}

string valuesOfLastMemebr = stringStack.Peek();

foreach(string language in stringStack)
{
    Console.WriteLine($"{language}");
}