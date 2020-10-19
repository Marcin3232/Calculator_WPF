# Calculator_WPF

Simple calculator for WPF desktop applications, something like a widget. The calculator allows you to perform simple actions, also on negative numbers and decimals.

# Technologies

 - C#
 - WPF
 
 # Usage
 - Clone this repository
 - Open a Microsoft Visual Studio, compile a program.
 - Or open a folder with project and ``` Calculator -> bin -> Debug -> Calculator.exe ``` and play the .exe file to run ready application.
 
 # Example
 
 <p align="center">
  <img  src="https://github.com/Marcin3232/Calculator_WPF/blob/master/ImageToReadme/r1.PNG">
</p>

 <p align="center">
  <img  src="https://github.com/Marcin3232/Calculator_WPF/blob/master/ImageToReadme/r2.PNG">
</p>

# Documentation
One function performs the operation of the numeric buttons. Gets string length values, the name of the sticky name has a constant name, incrementing by the number it represents.


```
            var button = sender as Button;
            var currentNumber = button.Name[button.Name.Length - 1];
            Text_current_operation.Text += currentNumber.ToString();

```

 The "C" button clears all data.
 
 ```
             Text_result.Text = string.Empty;
             Text_current_operation.Text = string.Empty;
            
 ```
 
 The operation button, first check that the string does not contain any operational character. If not, it adds the given character to the sign. If you had added an operand in front of the value, the program will throw a zero and you can continue to compute.
 
 ```
             if (operation.containSign(Text_current_operation.Text) == true)
            {
                Text_result.Text = operation.Result(Text_current_operation.Text).ToString();
                Text_current_operation.Text = Text_result.Text + "/";
            }
            else
            {
                Text_current_operation.Text += "/";
            }
 
 ```
 
 Class ``` Operation.cs ``` its task is to perform calculations and check what character is in the string, if unsuccessful it returns zero. it also includes a function that checks for the occurrence of operator characters.
 
 ```
 public double Result(string currentOperation)
        {
            try
            {
            switch (currentOperation)
            {
                case string c when c.Contains('+'):
                    {
                        var element = currentOperation.Split('+');
                        return result = double.Parse(element[0]) + double.Parse(element[1]);                      
                    }
                case string c when c.Contains('-'):
                    {
                        var element = currentOperation.Split('-');
                        return result = double.Parse(element[0]) - double.Parse(element[1]);
                    }
                case string c when c.Contains('*'):
                    {
                        var element = currentOperation.Split('*');
                        return result = double.Parse(element[0]) * double.Parse(element[1]);
                    }
                case string c when c.Contains('/'):
                    {
                        var element = currentOperation.Split('/');
                        return result = double.Parse(element[0]) / double.Parse(element[1]);
                    }
                case string c when c.Contains('%'):
                    {
                        var element = currentOperation.Split('%');
                        if (element[1] == "")
                        {
                            return result = double.Parse(element[0]) / 100;
                        }
                        else
                        {
                            return result = double.Parse(element[0]) / 100 * double.Parse(element[1]);
                        }
                    }
                default:
                    {
                        return 0;
                    }
            }
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
            }
            return 0;            
        }
        
 ```
checking the occurrence operator

```
        public bool containSign(string currentOperation)
        {
                return currentOperation.Contains('+') || currentOperation.Contains('-') 
                || currentOperation.Contains('%') || currentOperation.Contains('/') 
                || currentOperation.Contains('*');             
        }

```
 
 
# Possibilities for further development

- adding more views, with new functionalities such as a scientific calculator, currency converter

# License
MIT License
```

Copyright (c) [2020] [Calculator WPF]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

```
