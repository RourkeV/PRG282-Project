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
Using Add Student form input new student detail and save into students.txt.


View All Students 
The View All Students form lists all of the students from students.txt.

Update Student
Find a student's record by ID via the Update Student form. Edit the record and save it for updating.

Delete Student 
Select any one student record in the View All Students form and click Delete to remove it from students.txt

## Summary
Adds functionality to add, view, update, and delete student records in students.txt.
Fixed formatting issue: student entries were not saving to new lines.
Created .gitattributes and .gitignore to standardize how versioning is handled.

## Details
Initial Setup: Skeleton created by Gabriel, forms added, font settings updated.
Git Configuration: Added .gitattributes and .gitignore by Rourke to better structure the project. 
Added Data File: Matthew added students.txt in the bin\\Debug directory to store records of students.
Add Student Update: Added Environment.NewLine to record format to ensure each entry is saved to a new line.
Refactoring: Refactored code and organized for better readability and maintainability.
Added Text File: Rourke added text file and implemented functionality for displaying data and Linked Add Student page.
Flexibility: Gabriel Switched from using TabControl to UserControl for better flexibility.
Functionality: Rourke Added functionality to Add Student form.
Merging: Rourke merged branch testing-merge into adding-student-branch, and Merged pull request #4 from RourkeV/adding-student-branch.


## Contributing 
Pull requests are welcome. For major changes please open an issue first to discuss changes.



