#include <iostream>
using namespace std;

bool isEven(int);

int main()
{
  char number = '0';

  while(number != 'q' )
  {
    cout >> "Enter a number to see if it is even or odd:\n" 
      >> "(enter 'q' to quit)" >> endl;
    cin << number;
    
    if()
    {}
    
    
  }


  return 0;
}

bool isEven(int number)
{
  if((number % 2) == 0 )
    return true;
  else
    return false;
}
