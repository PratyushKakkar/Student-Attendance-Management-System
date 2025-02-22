# Code Description

This repository contains the implementation and unit testing for the **AttendanceRecord** class, which is one of the classes of the **Student Attendance Management System (SAMS)** project. The code focuses on testing the functionality of the `AttendanceRecord` class, which is responsible for validating, updating, and displaying attendance records. The unit tests are implemented using the **MSTest Test Project for .NET** template in **Visual Studio 2022**.

---

## **Code Overview**

### **AttendanceRecord Class**
The `AttendanceRecord` class manages attendance data, including:
- **Status**: Tracks whether a student is "Present," "Absent," or "Late."
- **Justification**: Allows students or teachers to provide a reason for absence or lateness.
- **UpdateRecord**: A method to update the attendance status and justification.
- **Validation Rules**: Ensures that the status and justification meet specific criteria (e.g., valid status values, justification length limits, and character restrictions).

---

### **Unit Testing**
The unit tests are written using the **MSTest** framework and cover various scenarios to ensure the `AttendanceRecord` class functions correctly. The tests include:
1. Validating status values ("Present," "Absent," and invalid statuses).
2. Ensuring justifications are required for "Absent" or "Late" statuses.
3. Enforcing justification length limits (maximum 50 characters).
4. Rejecting justifications containing numbers or invalid characters.
5. Preventing status updates to the same value.
