***Flight Booking System with Unit Testing***
This repository demonstrates a simple flight booking system with functionality for seat management. The project includes domain logic for managing flight bookings and uses FluentAssertions and Xunit for unit testing.

**Features**
**Flight Booking Logic:** A Flight class to manage seat availability and bookings.
**Unit Testing:** Verifies that booking reduces the available seat count using Xunit and FluentAssertions.
![Screenshot 2025-01-11 172744](https://github.com/user-attachments/assets/8624d1bf-9613-4e3f-bfcd-a8cdb3eb643e)

**Key Methods:**

**Constructor:** Initializes the flight with a specified seat capacity.
**Book:** Takes the passenger's email and the number of seats to book, then reduces the available seats accordingly.

![Screenshot 2025-01-11 172921](https://github.com/user-attachments/assets/d5bd9ebb-a758-4e28-9652-60bf7ba1f4b8)

**Test Details:**

Initializes a flight with a seat capacity of 3.
Books 1 seat for a passenger.
Asserts that the remaining seats are reduced to 2.
Uses **FluentAssertions** for clean, expressive assertions.

**Prerequisites**
.NET SDK
Xunit and FluentAssertions NuGet packages

**Future Enhancements**
**Add validations to prevent overbooking.**
**Expand functionality to handle multiple flights and passengers.**
**Implement additional booking rules, such as cancellations or seat holds.**
