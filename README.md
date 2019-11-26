# VAMK-Assignment-C#
> This repository handles the assignments in the course Windows Programming in VAMK
## Table of contents
* [Assignment 1](#Assignment-1)
* [Assignment_2](#Assignment-2)

### Assignment 1 
Write an application in C# which reads the information of customers and their flights from the standard input device and allows searching flight and customer information. It should be possible to find out whether a customer or a collection of customers are on the same flight. It should also be possible to find out on how many flights a customer is. When a flight information is searched the application must print the information of customer's flight too. Define seperate classes for customer and flight information. The attributes for the customer class should be name, id, and collection of flights ids. Define constructor and a method which returns the customer's and his/her flight's info. The attributes for the flight should be id, origin, destination, and date.

### Assignment 2

- Write an application in C# in which you define class concert to manage concert information. Relevant attributes for class concert are title, location, date, time and price. Define the necessary requirements and a method, which returns concert information as text. Define also the following operators for the class: 
	- < operator so that a concert objects is smaller than the other one if it's price is smaller 
	-  ++ and -- operators so that they would increase or decrease the concert price by 5 units  
In the main method of the application define a hash table and initialize it by five concert objects so that concert title works as the key and full concert information works as the correspondent value in the hash table. Print out the content of the hash table to the standard output device and use defined operators to test their functionality. 

- A program, in which you define class TextAnalyzer, whose attribute is a variable called text. Define necessary constructors and a method, which receives an uninitialized text variable as input and initializes it randomly with 50 characters and then returns the list of characters in ascending order with the number of times each character has been repeated. The program must print the generated text too.  

#### Features

1. Create a flight
2. Create a customer
3. Add customers to flight
4. Book flight for customer
5. Search flight
6. Search customer
7. Get all flight informations
8. Get all customer informations

#### Solutions
* DAO: Has two classes have static collections work as database for this assignment
* Entity: Customer.cs and Flight.cs
* Services: 
	- CustomerService: Handler the services provided for customer: Get customer informations, book flight for customers, search customer, and print out customer informations to the console
   	- FligtService: Handler the services provided for flight: Get flight informations, add customer to the flight, search flight, and print out the flight informations to the console.
* Util: utilities of this program
   	- Constants
   	- Validator
* Program
