

int a = 5;
int b = 7;
int c = 3;
bool flag = false;

if ((a > b) && (b < c) && (flag = true))
{

    Console.WriteLine("a is bigger than b");

    if ((c < a) || ( b > a) && (c != a))
    {
        bool flag2 = true;

        Console.WriteLine("c is less than a");
        if( b == a)
        {
            flag2 = true;
            Console.WriteLine("b equals a");
        }
    } else
    {
        flag = true;
        Console.WriteLine("c greater than a");
    }

    flag2 = false; // does not work

    if( !flag )
    {
        // if flag is no true
    }
}

flag2 = false; // does not work

a = 7;
bool numberIsEven = true;


switch (a)
{
    case 10:
        a += 3;
        Console.WriteLine("a is 10");
        break;
    case 11:
        a *= 4;
        Console.WriteLine("a is 11");
        break;
    default:
        a %= 2;
        if (a == 1)
        {
            numberIsEven = false;
            Console.WriteLine("a is odd");
        } else
        {
            numberIsEven = true;
            Console.WriteLine("a is even");
        }

        Console.WriteLine("a is not 10 or 11");
        break;
}

Console.WriteLine("a is {0}", a);

if (a == 10)
{
    Console.WriteLine("a is 10");
}
else
{
    if( a == 11)
    {
        Console.WriteLine("a is 11");
    }
    else
    {
        Console.WriteLine("a is not 10 or 11");
    }
}