# Diagrams Description

This document provides an overview of the diagrams included in the **Project Planning Document Part 1.pdf** and **Project Planning Document Part 2.pdf** for the **Student Attendance Management System (SAMS)** project.

---

## **1. Sequence Diagrams**

### **Sequence Diagram for Use Story: US FR02**
This diagram illustrates the process of a student logging into the system and viewing their attendance records. It shows the interaction between the following components:
- **StudentView**: The interface where the student interacts.
- **UserController**: Handles user authentication and login.
- **AttendanceController**: Manages the retrieval of attendance data.
- **AttendanceReport**: Generates attendance reports.
- **Database**: Stores and retrieves attendance data.

The sequence includes:
1. The student initiates the login process.
2. The system validates the credentials.
3. The student requests attendance data.
4. The system retrieves and displays the attendance records.

---

### **Sequence Diagram for Use Story: US FR03**
This diagram depicts how an administrator updates or designates class schedules. It shows the interaction between:
- **AdminView**: The interface where the administrator interacts.
- **ScheduleController**: Manages the scheduling logic.
- **Database**: Stores and retrieves schedule data.

The sequence includes:
1. The administrator logs in and requests to update the schedule.
2. The system validates the request and updates the schedule.
3. The updated schedule is saved in the database and made available to all users.

---

## **2. State Machine Diagram**

### **State Machine Diagram for Class ‘Student’**
This diagram represents the flow of a student logging into the system and viewing their attendance records. It includes the following states:
- **Idle**: The student is not logged in.
- **Authenticating**: The system validates the student's credentials.
- **Logged In**: The student successfully logs in.
- **Requesting Attendance Data**: The student requests their attendance records.
- **View Attendance Data**: The system displays the attendance data.
- **Error State**: Handles errors during login or data retrieval.

The diagram also includes transitions between states, such as:
- Successful login transitions to "Logged In."
- Failed login transitions to "Error State."
- Successful data retrieval transitions to "View Attendance Data."

---

## **3. Use Case Diagram**

### **Use Case Diagram**
This diagram outlines the interactions between different users (students, teachers, administrators) and the system. It includes the following use cases:
- **Mark Attendance**: Teachers mark students as "Present" or "Absent."
- **Generate Reports**: Students, teachers, and administrators generate attendance reports.
- **Update Schedule**: Administrators update class schedules.
- **View Attendance**: Students view their attendance records.
- **Add Users**: Administrators add students and teachers to the system.

The diagram provides a high-level overview of the system's functionality from the perspective of each user role.

---

## **4. Class Diagram**

### **Class Diagram**
This diagram shows the structure of the system's classes and their relationships. Key classes include:
- **User**: Base class for `Student`, `Teacher`, and `Administrator`.
- **AttendanceRecord**: Tracks attendance data (date, class, status).
- **Schedule**: Manages class schedules.
- **AttendanceReport**: Generates attendance summaries.
- **Controller Classes**: Handle user interactions and logic (e.g., `UserController`, `AttendanceController`, `ScheduleController`).

The diagram also shows relationships between classes, such as inheritance (e.g., `Student`, `Teacher`, and `Administrator` inherit from `User`) and associations (e.g., `AttendanceRecord` is associated with `Class`).
