/*
 * Done by:
 * Student Name: David Hrytsenok
 * Student Group: B-121-24-1-SE
 * Lab 1.1 C++
 */

#include "StringHandler.h"
#include <iostream>

using namespace std;

int main() {
  string input;
  cout << "Enter a string: ";
  cin >> input; // Read user input

  StringHandler handler(input);

  // Output the results
  cout << "Original string: " << handler.getValue() << endl;
  cout << "String length: " << handler.getLength() << endl;
  cout << "Sorted (descending): " << handler.getSortedDescending() << endl;

  return 0;
}