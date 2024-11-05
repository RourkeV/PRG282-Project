# Student Management System
Student Management System is a C# Windows Forms application for managing student records using a text file for data storage and GitHUb for version control.

## Installation
Clone the repository:
git clone <repository-url>
Open the solution in Visual Studio.
Build the project to ensure all dependencies are correctly set up.
Run the application.

## Usage
Add New Student
Use the Add Student form to input a new student's details and save them to students.txt.

View All Students 
The View All Students form displays a list of all students from students.txt.

Update Student
Search for a student by ID in the Update Student form, make changes, and save the updated record.

Delete Student 
In the View All Students form, select a student record and click Delete to remove it from students.txt

## Summary
Adds functionality to add, view, update, and delete student records in students.txt.
Fixes formatting issue where student entries were not saved on new lines.
Sets up .gitattributes and .gitignore for version control consistency.

## Details
Initial Setup: Gabriel created the project skeleton, added forms, and updated font settings.
Git Configuration: Rourke added .gitattributes and .gitignore for better project structure. 
Data File Addition: Matthew added students.txt in the bin\Debug directory for student record storage.
Add Student Update: Ensured that each entry saves on a new line by including Environment.NewLine in the record format.
Refactoring: Code was refactored and organizeds for clarity and maintainability.

## Contributing 
Pull requests are welcome. For major changes, please open an issue first to discuss the changes.



