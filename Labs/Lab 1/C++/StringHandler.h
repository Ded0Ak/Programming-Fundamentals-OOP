#pragma once
#include <string>

using namespace std;

class StringHandler {
private:
  string data;

public:
  StringHandler(const string &str);
  int getLength() const;
  string getSortedDescending() const;
  string getValue() const;
};