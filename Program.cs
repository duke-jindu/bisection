

//1.start

//2.Define function f(x)

//3.Choose initial guesses x1 and x2 such that f(x1)f(x2) < 0

//4.Choose Number Of Itrations (itl) (e).

//5. Calculate the mid-point (m) = (x1 + x2) / 2

//6.Calculate f(x1)f(m)

//  a. if f(x1)f(m) < 0 then x1 = x1 and x2 = m
//  b. if f(x1)f(m) > 0 then x1 = m and x2 = x2
//  c. if f(x1)f(m) = 0 then goto (8)


//7. if  f(m)  > e then goto (5) otherwise goto (8)

//8.Display (m) as root.

//9.Stop












//Console.WriteLine("Hello, World!");

float fx1, fx2, fx3;
int x1, x2;
//no tolerance declared
Console.Write("Enter Value for X1 :");
x1 = int.Parse(Console.ReadLine());//use float.Parse instead
fx1 = fx(x1);

Console.Write("Enter Value for X2 :");
x2 = int.Parse(Console.ReadLine());
fx2 = fx(x2);
//no check for fx1*fx2 < 0
Console.Write("Number Of Itrations = ");
int itre = int.Parse(Console.ReadLine());

int m = (x1 + x2) / 2;

fx3= fx(m);

int counter = 0;

while (Math.Abs(x1 - x2) > 0.01 || m != 0)//what type of condition is this?

{
    if (counter == itre)
    {
        break;
    }

    Console.Write("x1 = " + x1);
    Console.Write("x2 = " + x2);
    Console.Write("m = " + m);
    Console.Write("Fx1 = " + fx1);
    Console.Write("Fx2 = " + fx2);
    Console.WriteLine("Fx3 = " + fx3);
    counter = counter + 1;

    if (m == 0)//shouldn't you be checking whether fx is 0 or less than a tolerance value
    {
       Console.WriteLine("the root is" + m);
        break;
    }
    else if (fx1 * fx3 < 0)
    {
        x2 = m;
    }
    else
    {
        x1 = m;
    }
    m = (x1 + x2) / 2;
    fx1 = fx(x1);
    fx2 = fx(x2);
    fx3 = fx(m);
}
Console.WriteLine(m);
Console.WriteLine(counter);
Console.ReadLine();
 
    
 
 float fx(float x)
{
    x = ((float)Math.Pow(2*x , 3)) -  (2 * x) - 5;//your function is wrong again
    //why equate your result to x?
    //math.Pow(x,3)-8*x 
    return x;
}