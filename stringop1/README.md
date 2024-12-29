# String Operations in C#

This project demonstrates various string manipulation methods in C# through simple exercises. The program showcases operations such as reversing a string, removing spaces, replacing characters, finding characters in a string, creating substrings, and more.

## Overview

The program is structured as a single class `Program` containing multiple methods to perform operations on strings. The main focus is to provide simple examples to explore built-in string manipulation methods in C#.

## How to Run

1. Clone this repository.
2. Open the project in a C# IDE like Visual Studio.
3. Build and run the project.
4. Observe the output of each string operation in the console.

## Methods Summary

| **Method**        | **Description**                                                                   | **Example Input**           | **Example Output**                       |
| ----------------- | --------------------------------------------------------------------------------- | --------------------------- | ---------------------------------------- |
| `ReverseText`     | Reverses the given text.                                                          | `"hello world"`             | `"dlrow olleh"`                          |
| `RemoveSpaces`    | Removes all spaces from the given text.                                           | `"hello world"`             | `"helloworld"`                           |
| `ReplaceChar`     | Replaces all occurrences of a character with another character in the given text. | `('o', 'a', "hello world")` | `"hella warld"`                          |
| `CreateSinusText` | Creates a sinusoidal representation of the text characters.                       | `"hello"`                   | Sinusoidal styled output in the console. |
| `FindFirstChar`   | Finds the first occurrence of a character in the text and prints its index.       | `('l', "hello world")`      | `"Index: 2"`                             |
| `FindLastChar`    | Finds the last occurrence of a character in the text and prints its index.        | `('l', "hello world")`      | `"Index: 9"`                             |
| `FindAllChar`     | Counts all occurrences of a character in the text.                                | `('l', "hello world")`      | `"Count: 3"`                             |
| `CreateSubString` | Creates a substring starting from a specified character and of a given length.    | `('w', 5, "hello world")`   | `"world"`                                |
| `FindSubString`   | Searches for a substring within the text and indicates its existence.             | `("world", "hello world")`  | `"Substring exists."`                    |

## Example Usage

### Reversing Text

```csharp
string reversedText = ReverseText("hello world");
Console.WriteLine(reversedText); // Output: "dlrow olleh"
```

### Removing Spaces

```csharp
string noSpaceText = RemoveSpaces("hello world");
Console.WriteLine(noSpaceText); // Output: "helloworld"
```

### Finding First and Last Occurrences of a Character

```csharp
FindFirstChar('l', "hello world"); // Output: "Index: 2"
FindLastChar('l', "hello world");  // Output: "Index: 9"
```

### Creating Sinusoidal Text

```csharp
CreateSinusText("hello");
// Output:
//    H
//         E
//             L
//                  L
//                       O
```

### Searching Substrings

```csharp
FindSubString("world", "hello world");
// Output: "Substring exists."
FindSubString("planet", "hello world");
// Output: "Substring does not exist."
```

## Requirements

- .NET Core SDK
- IDE such as Visual Studio, Visual Studio Code, or Rider

## License

This project is licensed under the MIT License. Feel free to use, modify, and distribute this code.
