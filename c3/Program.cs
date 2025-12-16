using System;
class natural{
    static void Main(){
        int n,sum=0;
        Console.WriteLine("Enter a number:");
        n=int.Parse(Console.ReadLine());
        if (n<=0){
            Console.WriteLine("the number is not natural");
            return;
        }
        else
        {
            
            
            for(int i=1;i<=n;i++){
                sum=sum+i;
            }
            Console.WriteLine("The sum of natural numbers upto "+n+" is: "+sum);
        }    
    }
}