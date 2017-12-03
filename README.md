# C-Final-Project-Library-System

Final DB Project Summary

In our project we will be creating a Library Book Database. The tables will consist the following: Book, Member, Employee, Transactions. Using these tables each book will either be checked in, or checked out. If it is checked out it will be assigned to a library member and an employee (who checked it out). There will be a null value in the library member and employee id columns of the Transactions table if the book is not checked out. See ERD.

Visually, there will be a Main Splash form that will link to a form corresponding to each of the tables (Book, Member, Employee). On each of the forms there will be stock sort/query buttons (Sort by checked out, sort by publishing dates, etc.). Near the bottom there will be a parametrized search fields for specific user specified searches.

Validation will occur in seperate methods or on focus out of textbox (in CheckInCheckOut form).
