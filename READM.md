# Book Class

## Overview
The `Book` class represents a book with properties such as title, author, year of publication, availability status, and condition. It provides functionality for checking out and returning books, with built-in validation for property values.

## Features
- Stores book information including title, author, year published, availability, and condition.
- Enforces validation for title and author.
- Supports book conditions: `New`, `Good`, `Worn`, and `Damaged`.
- Allows books to be checked out and returned.

## Class Properties

### `Title` (string?)
- Must contain at least one letter or digit.
- Defaults to `"Invalid Title"` if the provided value is invalid.

### `Author` (string?)
- Cannot contain numeric digits.
- Must contain at least one letter.
- Defaults to `"Invalid Author Name"` if the provided value is invalid.

### `YearPublished` (int)
- Must be greater than or equal to 1900.
- Defaults to `0` if an invalid value is provided.

### `IsAvailable` (bool)
- Indicates whether the book is available for checkout.
- Can only be modified internally.

### `Condition` (string?)
- Accepts only predefined values: `New`, `Good`, `Worn`, and `Damaged`.
- Defaults to `"Unknown"` if an invalid value is provided.

## Class Methods

### `CheckOut()`
- Marks the book as unavailable if it is currently available.
- Displays a message indicating success or failure.

### `ReturnBook()`
- Marks the book as available if it is currently checked out.
- Displays a message indicating success or failure.

## Usage Example
```csharp
using System;

namespace Book
{
    class Program
    {
        static void Main()
        {
            Book myBook = new Book("C# Programming", "John Doe", 2020, "New");
            Console.WriteLine($"Title: {myBook.Title}, Author: {myBook.Author}, Year: {myBook.YearPublished}, Condition: {myBook.Condition}, Available: {myBook.IsAvailable}");
            
            myBook.CheckOut();
            myBook.ReturnBook();
        }
    }
}
```