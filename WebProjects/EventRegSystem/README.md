# 📅 Event Registration System for Career Services

Welcome to the **Event Registration System for Career Services**, a web-based application designed to simplify event management and improve student engagement for career services events at West Texas A&M University. This project streamlines the registration process, enforces eligibility requirements like resume reviews, and enhances event planning for staff.

---

## 🕹️ **How to Use**
1. **Student Login**:
   - Students log in and view a list of upcoming career events.
   - Events requiring resume reviews display a badge or icon.
2. **Eligibility Verification**:
   - Students must complete a **Resume Review Appointment** to register for certain events.
   - Attempting to register without meeting the prerequisite displays a warning:  
     *"Please complete a resume review before registering for this event."*
3. **Event Registration**:
   - Eligible students register for events via a simple form.
   - Students can view and cancel their registrations directly within the app.
4. **Resume Review Service**:
   - Career services staff update the **ResumeReviewed** status after reviewing resumes.
5. **Event Management**:
   - Staff can create, edit, and delete events.
   - View and export registration rosters for event planning (e.g., catering estimates).
6. **Event Day Management**:
   - Staff access attendee lists for efficient check-ins and tracking.

---

## ⚙️ **Features**
- **Student Registration**:
  - Students can register for events or cancel their registrations.
  - Displays events the student is registered for.
- **Resume Review Service**:
  - Staff can update student profiles to verify resume reviews.
- **Event Management**:
  - Staff can manage event details like name, date, location, and prerequisites.
  - View student rosters and sort attendees by name or resume review status.
- **Search and Sort**:
  - Search events by name or date.
  - Sort registered students by name or eligibility.
- **Dynamic Homepage**:
  - Built using **Bootstrap** with a carousel or card-based layout to display upcoming events and flyers.
  - Highlights events requiring resume reviews.

---

## 🏗️ **Implementation Details**
### **Entities and Relationships**
1. **Student**:
   - Properties: `StudentID`, `FirstName`, `LastName`, `Email`, `Major`, `GraduationYear`, `ResumeReviewed` (boolean).
   - Relationships: One-to-many with `EventRegistration`.
2. **EventRegistration**:
   - Properties: `RegistrationID`, `RegisteredDate`, `StudentID` (fk), `EventID` (fk).
   - Relationships: Many-to-one with `Student` and many-to-many with `Event`.
3. **Event**:
   - Properties: `EventID`, `EventName`, `EventDate`, `EventLocation`, `NeedResumeReview` (boolean), `Description`.
   - Relationships: Many-to-many with `EventRegistration`.

### **Technology Stack**
- **ASP.NET + EF CORE**:
  - Backend development and routing.
- **Bootstrap**:
  - Frontend design for responsive layouts.
- **SQL Database**:
  - Entity and relationship management.

---

## 📋 **Sample Output**
```text
1. Student Login:
Welcome to Career Services Event Registration!
Enter your credentials to access the event portal.

2. Event Listing:
Upcoming Events:
- Industry Career Fair [Resume Review Required]
- Technology Networking Night

3. Registration Attempt Without Eligibility:
"Please complete a resume review before registering for this event."

4. Successful Registration:
"Thank you for registering for the Technology Networking Night!"
```
---

## 💻 **Technologies Used**
- **ASP.NET + EF CORE**: Backend application framework.  
- **SQL Database**: Manages entities and relationships.  
- **Bootstrap**: Creates dynamic and responsive user interfaces.  

---

## ✨ **Future Enhancements**
- Integrate real-time notifications to remind students of upcoming events or missing prerequisites.  
- Add a dashboard for tracking event metrics (e.g., attendance rates, student engagement).  
- Enable Duo verification for enhanced security during student login.  
- Provide exportable reports for staff to analyze trends in event participation.  

---

## 📧 **Contact**
For questions or feedback, feel free to reach out:  
📧 [rgarcia.pm@icloud.com](mailto:rgarcia.pm@icloud.com)  
🔗 [LinkedIn Profile](https://www.linkedin.com/in/rg-garcia)  

