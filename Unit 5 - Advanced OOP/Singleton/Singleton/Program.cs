using Singleton;

string user = Singletonobj.getInstance();
Console.WriteLine(user);
test();



static void test()
{
    string user2 = Singletonobj.getInstance();
    Console.WriteLine(user2);
}