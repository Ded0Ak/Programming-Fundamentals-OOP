#include "StringHandler.h"
#include <algorithm>

using namespace std;

// Constructor initializes the string
StringHandler::StringHandler(const string &str) : data(str) {}

// Returns the length of the string
int StringHandler::getLength() const { return data.length(); }

// Returns the string sorted in descending order
string StringHandler::getSortedDescending() const {
  string sortedStr = data;
  sort(sortedStr.rbegin(), sortedStr.rend()); // Sort in descending order
  return sortedStr;
}

// Returns the original string
string StringHandler::getValue() const { return data; }