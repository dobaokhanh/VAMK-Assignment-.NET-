# VAMK-Assignment-C#
> This repository handles the assignments in the course Windows Programming in VAMK
## Table of contents
* [Assignment 1](#Assignment-1)

### Assignment 1 
Write an application in C# which reads the information of customers and their flights from the standard input device and allows searching flight and customer information. It should be possible to find out whether a customer or a collection of customers are on the same flight. It should also be possible to find out on how many flights a customer is. When a flight information is searched the application must print the information of customer's flight too. Define seperate classes for customer and flight information. The attributes for the customer class should be name, id, and collection of flights ids. Define constructor and a method which returns the customer's and his/her flight's info. The attributes for the flight should be id, origin, destination, and date.
    
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
