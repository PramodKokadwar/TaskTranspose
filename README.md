
# TaskTranspose
This is a C# console application that transposes a table stored in a CSV file. The application reads a CSV file, transposes its data, and writes the transposed data to a new CSV file.

## Prerequisites
.NET Framework or .NET Core installed on your machine.
### Usage
1. Clone or download this repository to your local machine.

2. Open the project in your preferred C# development environment (e.g., Visual Studio).

3. Build the project to ensure all dependencies are resolved.

4. Update the pathToFile variable in the Main method of the Transpose class to specify the directory path where your input CSV file is located.

5. Run the Transpose.cs file.

6. The application will search for a CSV file in the specified directory.

7. If a file is found, the application transposes the data and saves the transposed table to a new CSV file.

8. The output file is saved in the same directory as the input file, with the suffix "_transposed" appended to the filename.

9. If no file is found, the application displays a message indicating that no file was found in the specified directory.

If an exception occurs during the execution, an error message will be displayed with the details of the exception.

## Example
Suppose you have a CSV file named input.csv located in the directory C:\Users\pramodkokadwar\source\repos\TaskTranspose\TaskTranspose\files\. After running the application, it will transpose the table data and save it to a new CSV file named input_transposed.csv in the same directory.

## Note
* The application assumes that the input file is in CSV format, with semicolon (;) as the delimiter.

* Make sure the directory path specified in the pathToFile variable is correct and accessible.

* If you encounter any issues or have any questions, please feel free to contact the author.

Author
Created by Pramod Kokadwar.
