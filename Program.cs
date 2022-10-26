//Michelle reviewed on 10/25 
//Working but no replay option yet



//Angelica Ayala
//10/24/22
//Mini Challenge #7- Reverse
//-------Description--------
//Created a reverse int and reverse string
//Declared the data type and variable/ empty string
//Told user what is going to happen with the user input
//Created a for loop to declare the new variable
//In the for loop the user input will be reversed.
//print


//Reviewed by:
//Date:
//Review

int reverseNumb = 0;
int remainder;

Console.WriteLine("Enter a number to reverse.");
int numb1 = Convert.ToInt32(Console.ReadLine());

for(; numb1 > 0; numb1 = numb1 / 10)
{
    remainder = numb1 % 10;
    
    reverseNumb = (reverseNumb * 10) + remainder;
}

Console.WriteLine("Reverse number is; " + reverseNumb);
    



//-------String---------------------
//Declaring the reverseWOrd as an empthy string
string reverseWord = ""; //empth string and not a null

//Telling the user what is going to happen
Console.WriteLine("Enter a word to reverse.");
string Word = Console.ReadLine();


//within the for loop we are declaring the new variable called i and setting it to the new variable Word. We are starting at the end of the string -1. i-- is now counting backwards until it reaches its end point.

for( int i = Word.Length - 1; i >= 0; i--)

{
    reverseWord += Word[i];

//or Console.WriteLine
    
}
//print/output


Console.WriteLine("Reverse word is;" + reverseWord);