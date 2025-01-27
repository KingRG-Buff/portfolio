# 💊 Pharmaceutical Clinical Trial Management Database

Welcome to the **Pharmaceutical Clinical Trial Management Database** project, a database solution designed as prood of concept to streamline clinical trial operations for a mock pharmaceutical company. This project ensures data integrity, supports regulatory compliance, and enables efficient management of clinical trials involving patients, medications, and hospitals.

---

## 🕹️ **How to Use**
1. The database tracks and manages critical entities, including:
   - Patients
   - Medications
   - Hospitals/Clinics
   - Prescriptions
   - Regulatory information
2. SQL scripts are provided to:
   - Create tables for entities and relationships.
   - Insert records for patient, trial, and medication data.
   - Run queries to retrieve valuable insights, such as trial outcomes and compliance reports.
3. Use the provided SQL scripts to:
   - Initialize the database.
   - Populate it with sample data.
   - Execute queries to generate reports.

---

## ⚙️ **Features**
- **Enhanced Entity-Relationship Diagram (EERD)**:
  - Designed and normalized to 3rd Normal Form (3NF) for optimal data integrity and efficiency.
- **Regulatory Compliance**:
  - Includes a regulatory information management table to ensure adherence to FDA standards and streamline audits.
- **SQL Implementation**:
  - Scripts to create and manage relationships between key entities.
  - Advanced SQL queries for tracking trial outcomes and compliance.
- **Data Integrity**:
  - Enforces referential integrity constraints to avoid data inconsistencies.
  - Supports clean, accurate data for reliable reporting.
- **Streamlined Reporting**:
  - Queries generate insights into trial outcomes, medication efficacy, and patient demographics.

---

## 🏗️ **Implementation Details**
### **Database Design**
- **Core Entities**:
  - **Patients**: Tracks demographic and contact information.
  - **Medications**: Includes details like dosage, expiration, and batch number.
  - **Hospitals/Clinics**: Stores clinic contact information and administrative data.
  - **Prescriptions**: Links patients, clinics, and medications.
  - **Regulatory Data**: Tracks compliance details like regulation type and issue dates.
- **Relationships**:
  - A single patient can participate in multiple trials.
  - Each trial involves one hospital, one regulation, and one medication.
  - Prescriptions are linked to both trial medications and placebo data.

### **SQL Scripts**
- **Table Creation**:
  - Implements tables for all entities and relationships.
  - Enforces primary and foreign key constraints.
- **Sample Data**:
  - Provides records for patients, medications, trials, and regulatory data.
- **Queries**:
  - Retrieve patient data by location or demographics.
  - Identify active clinical trials and associated hospitals.
  - Generate reports on trial outcomes and compliance.

---

## 📋 **Sample Output**
```text
1. List of Patients:
+------------------+----------------+---------+
| Patient Name     | City           | Age     |
+------------------+----------------+---------+
| Homer Simpson    | Springfield    | 67      |
| Lisa Simpson     | Springfield    | 42      |
| Marge Simpson    | Springfield    | 68      |
+------------------+----------------+---------+

2. Active Trials by Hospital:
+-------------------+-------------------+----------------+
| Trial ID          | Hospital Name     | Regulation ID  |
+-------------------+-------------------+----------------+
| T001              | Saint Mary's      | 0000-R001      |
| T002              | City Health       | 0000-R004      |
+-------------------+-------------------+----------------+

3. Medications and Usage:
+--------------------+--------------------+---------------+
| Medication Name    | Dosage             | Frequency     |
+--------------------+--------------------+---------------+
| Amoxicillin        | 500mg              | Twice daily   |
| Ibuprofen          | 200mg              | Once daily    |
+--------------------+--------------------+---------------+
```

---

## 💻 **Technologies Used**
- **MySQL**: Database design, creation, and management.  
- **EERD**: Enhanced Entity-Relationship Diagram for efficient schema design.  
- **SQL Queries**: Complex queries for data retrieval and reporting.  
- **Normalization**: Achieved 3NF to ensure data integrity.  

---

## ✨ **Future Enhancements**
- Expand the schema to support multi-national trials and cross-border data management.  
- Automate data entry using form-based input systems.  
- Integrate dashboards for real-time clinical trial tracking and analytics.  
- Implement advanced user roles and permissions for security.  

---

## 📧 **Contact**
For questions or feedback, feel free to reach out:  
📧 [rgarcia.pm@icloud.com](mailto:rgarcia.pm@icloud.com)  
🔗 [LinkedIn Profile](https://www.linkedin.com/in/rg-garcia)  
