Random rnd = new Random();

int myRandiNum;

int randomSum = 0;

for(int i = 0; i  < 3; i++)
{

int myRandimNum = rnd.Next(0, 11);  //0 - 10 
   
    randomSum += myRandimNum;

Console.WriteLine($"My random number is: {myRandimNum}");

}

Console.WriteLine($"random sum total: {randomSum}");