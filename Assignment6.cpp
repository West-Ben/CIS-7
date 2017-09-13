#include <iostream>
using namespace std;

bool isEven(int);

int main()
{
  int number = 0;
  char repeat = 'a';

  while(repeat != 'q' )
  {
    cout << "Enter a number to see if it is even or odd:\n" << endl;
    cin >> number;
    
    if(isEven(number))
          cout << "the number\t" << number << " is even." << endl; 
    else
          cout << "the number\t" << number << " is odd." << endl; 
    
    cout << "press enter to check another number or enter 'q' to quit" << endl;
    cin >> repeat;
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
