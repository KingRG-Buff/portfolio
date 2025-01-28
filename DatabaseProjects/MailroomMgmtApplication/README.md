# 📦 Mailroom Management Application

Welcome to the **Mailroom Management Application**, a software solution designed to streamline mail and package handling for the fictional BuffTeks apartment complex. The diagrams purpose is to develop an application which improves efficiency for leasing office staff, reduces unclaimed package clutter, and notifies residents when their packages are ready for pickup.

---

## 🕹️ **How to Use**
1. **User Login**:
   - Leasing office staff logs in with a secure username and password.
2. **Package Delivery Process**:
   - Search for the resident's information within the application.
   - Select the correct resident and postal service agency (e.g., FedEx, USPS, UPS).
   - Confirm the information to add the package to the **Pending Area**.
   - Automatically send an email notification to the resident.
3. **Package Pickup Process**:
   - When the resident picks up their package, staff removes the record from the **Pending Area**.
4. **Unknown Packages**:
   - For packages addressed to non-residents, staff inputs the information into the **Unknown Area**.
   - The application tracks unknown packages for later return to the postal service.
5. **Package Record Retrieval**:
   - Retrieve a resident's package history by searching their name or unit number.

---

## ⚙️ **Features**
- **User Login**:
  - Secure access for leasing office staff.
- **Automated Notifications**:
  - Sends email notifications to residents when packages are delivered.
- **Package Tracking**:
  - Tracks package statuses (Pending, Picked Up, Unknown).
- **Unknown Package Management**:
  - Stores and manages information for non-resident packages.
- **Package History Retrieval**:
  - Allows staff to search and retrieve package history for a specific resident.

---

## 🏗️ **Implementation Details**
### **Use Case Diagram**
- Illustrates interactions between leasing agents and the mailroom system, including:
  - Logging in, adding packages, sending notifications, managing unknown packages, and retrieving package history.

### **Activity Diagram**
- Maps out the workflow:
  - Log in, search for resident information, add package details, send notifications, classify unknown packages, mark packages as picked up, and retrieve package history.

### **Class Diagram**
- **OfficeUser**:
  - Manages login, logout, resident verification, and package staging.
- **Resident**:
  - Tracks name, unit number, email, and package retrieval.
- **Package**:
  - Includes tracking number, status, owner, and delivery type.
- **UnknownPackage**:
  - Tracks recipient name, carrier, delivery date, and return status.
- **Notification**:
  - Handles recipient email and notification message.

### **Sequence Diagram**
- Depicts the flow from user login to package management and notifications, including unknown package handling and logout.

---

## 📋 **Sample Output**
```text
1. Resident Package Notification:
"Dear John Doe, your package from USPS has been delivered to the leasing office. Please pick it up at your earliest convenience."

2. Package History Retrieval:
Resident Name: Jane Smith  
Unit Number: 204  
Packages Delivered: 5  
Packages Picked Up: 4  
Pending Packages: 1  

3. Unknown Package Notification:
"Package addressed to 'Unknown Recipient' from FedEx has been logged. Status: Pending Return."
```
---

## 💻 **Technologies Used**
- **UML Diagrams**: Use Case, Activity, Class, and Sequence Diagrams for system design.  
- **Java or C# (Recommended)**: Implementation of system logic.  
- **Email API**: Sends notification emails to residents.  
- **MySQL/SQL Server**: Database for tracking package information and resident data.  

---

## ✨ **Future Enhancements**
- Add SMS notifications for residents in addition to email.  
- Implement multi-language support for notifications.  
- Integrate barcode scanning for quick package updates.  
- Develop a mobile app for residents to track and manage their packages.  

---

## 📧 **Contact**
For questions or feedback, feel free to reach out:  
📧 [rgarcia.pm@icloud.com](mailto:rgarcia.pm@icloud.com)  
🔗 [LinkedIn Profile](https://www.linkedin.com/in/rg-garcia)  
