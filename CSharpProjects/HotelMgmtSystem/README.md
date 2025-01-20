# 🏨 Buff Hotel Management System

Welcome to **Buff Hotel Management System**, a C# console application designed to streamline hotel operations. This project demonstrates proof of concept for the management of hotel rooms, including check-ins, check-outs, and room availability, while ensuring a user-friendly experience.

---

## 🕹️ **How to Use**
- Launch the application in the terminal.
- Log in using the hardcoded credentials:  
  **Username:** `alice`  
  **Password:** `alice123`
- After logging in, navigate through the menu to:
  - View available rooms.
  - Check in guests.
  - View reserved rooms.
  - Check out guests.
  - Log out of the system.

---

## ⚙️ **Features**
- **User Authentication**: Secure login with predefined credentials.  
- **Room Availability**: View all rooms available for booking, with their capacity.  
- **Check-In Process**: Assign rooms based on the number of guests, capturing customer details like name and email.  
- **Reserved Rooms View**: Display all booked rooms with associated customer details.  
- **Check-Out Process**: Clear reservations and make rooms available for future bookings.  
- **Dynamic Menu**: Intuitive navigation with real-time updates to room statuses.

---

## 🏗️ **Implementation Details**
### **Room Class**
- Represents each hotel room.
- Tracks room number, capacity, availability, and customer information.  

### **Program Class**
- **Initialization**: Preloads hotel room data with predefined capacities.  
- **Menu Navigation**: Displays options and handles user inputs.  
- **Room Management**: Implements logic for booking, viewing, and releasing rooms.  
- **Authentication**: Validates user credentials before granting access.

---

## 📋 **Sample Output**
```text
-----CIDM2315 Final Project: Raul Garcia-----
-----Welcome to Buff Hotel-----

==> Please enter username:
alice
==> Please enter password:
alice123

==> Login successful!

** Welcome User alice! **

********************
==> Please select:
1. Show Available Rooms
2. Check-In
3. Show Reserved Rooms
4. Check-Out
5. Log Out
********************

==> Input Number of People:
3
Suitable rooms:
Room 106, Capacity: 3
Room 107, Capacity: 3
Room 108, Capacity: 3
Room 109, Capacity: 3

==> Input the room number for check-in:
106
==> Input customer name:
John Doe
==> Input customer email:
john.doe@example.com
==> Check-in Successful! John Doe assigned to Room 106.
```

---

## 💻 **Technologies Used**
- **C#**: Core programming language.  
- **.NET Console Application**: Provides a terminal-based user interface.

---

## ✨ **Future Enhancements**
- Integrate a database for persistent room and customer data storage.  
- Add a graphical user interface (GUI) for improved usability.  
- Include advanced search and filtering options for room selection.  
- Implement multi-user access with role-based permissions.

---

## 📧 **Contact**
For questions or feedback, feel free to reach out:  
📧 [rgarcia.pm@icloud.com](mailto:rgarcia.pm@icloud.com)  
🔗 [LinkedIn Profile](https://www.linkedin.com/in/rg-garcia)
