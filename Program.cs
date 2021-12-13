using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
           Program ab1= new Program();
           ab1.lowerToUpper(); 

        }
    public void reseverAString()
    {
        Console.WriteLine("Enter the string which you want to reverse :");
        string abili= Console.ReadLine();
        char[] ab = abili.ToCharArray();
        for(int i=abili.Length-1;i>=0;i--)
        {
            Console.Write(ab[i]);
        }

    }

    public void swapNumber()
    {
        int a=43,b=984;
        int temp = b;
        b=a;
        a=temp;
        Console.WriteLine($" A value is {a} \n B value is {b}");

    }
    public void reseverANumber()
    {
        Console.WriteLine("Enter the number which you want to reverse:");
        String ab=null;
        ab=Console.ReadLine();
        int a=Convert.ToInt32(ab);
        int temp=0;
        while(a!=0)
        {
            temp=temp*10;
            temp=temp+a%10;
            a=a/10;  

        }
        Console.WriteLine($"Original number is {ab} \nReversed Number is {temp}");
    }

    public void Triangle()
    {
        for(int i=1;i<=5;i++)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public void lengthOfTheString()
    {
        string str = "Hello World";
        char[] chars = str.ToCharArray();
        int total= 0;
        foreach (var item in chars)
        {
            total++;
        }
        Console.WriteLine(total);
    }

    public void largeNumberOfTheArray()
    {
        int[] abb= new int[] {32423,234324,453425,24,343254,5233,32432,3,14,22,23,25325325,3532,353253,3,53};
        int temp=abb[0];
        for(int i=0;i<abb.Length;i++)
        {
            if(abb[i]>temp)
            {
                temp=abb[i];
            }
            
        }
        Console.WriteLine($"The largest number in the array {abb} : {temp}");

    }

    public void reseverWord()
    {
        string str = "This world full of people with ability";
        string[] word = str.Split();
        foreach (var item in word)
        {
            Console.Write(item+" ");
        }
        foreach (var item in word)
        {
            char[] temp = item.ToCharArray();
            for(int i=temp.Length-1;i>=0;i--)
            {
                Console.Write(temp[i]);
            }
            Console.Write(" ");
        }
    }
    public void numbeOfVowel()
    {
        string str = "This world full of people with ability";
        char[] ch = str.ToCharArray();
        int vowel=0;
        for(int i=0;i<ch.Length;i++)
        {
            if(ch[i]=='a' || ch[i]=='e'|| ch[i]=='i'|| ch[i]=='o'|| ch[i]=='u')
            {
                vowel++;
            }
        }
        Console.WriteLine($@" The given string are ({str}) and total number of vowel are : {vowel} ");
    }

    public void lowerToUpper()
    {
        string str= "Geere";
        
        Console.WriteLine($@" The capital string are : {str.ToLower()}");
    }



    }
}