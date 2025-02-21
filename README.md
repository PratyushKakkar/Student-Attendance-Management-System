# Student Attendance Management System (SAMS)

## Overview

This repository contains the project files for the **Student Attendance Management System (SAMS)**, developed as part of the **Software Engineering** module (B7IS127) for the academic year 2024-2025. The system is designed to automate and streamline the process of tracking and managing student attendance in educational institutions. It provides a user-friendly interface for teachers, students, and administrators to record, view, and manage attendance data efficiently.

This project focuses primarily on the **Planning and Software Engineering aspects** of system development. It includes detailed documentation on system architecture, requirements analysis, lifecycle models, and design patterns, as well as implementation and testing strategies. The goal is to demonstrate a structured approach to software engineering, from initial planning to the development of a functional prototype.

The project is divided into two main parts:
1. **Project Planning Document Part 1.pdf**: Contains the architectural design, sequence diagrams, state machine diagrams, and unit test designs for the system.
2. **Project Planning Document Part 2.pdf**: Includes the project vision, requirements specification, lifecycle model analysis, initial domain models, and release plans.
3. **Implementation Testing**: Contains the C# code implementation of the system, generated using Visual Studio 2022.
4. **Diagrams:**
  a. *Use-Case Diagram*
  b. *Class Diagram*
  c. *State Chart Diagram*
  d. *Sequence Diagrams*

## Key Features

### Architectural Pattern
The system follows the **Model-View-Controller (MVC)** architectural pattern, which separates the application into three main components:
- **Model**: Manages the data and business logic (e.g., `User`, `AttendanceRecord`, `Class`, `Schedule`).
- **View**: Handles the presentation layer (e.g., `StudentView`, `TeacherView`, `AdminView`).
- **Controller**: Manages user input and coordinates between the Model and View (e.g., `UserController`, `AttendanceController`, `ScheduleController`).

### Lifecycle Model
The project uses the **Incremental Development** lifecycle model, which allows for the system to be developed in manageable phases, ensuring stability and control over the development process. This approach enables the team to deliver functional components incrementally, allowing for early feedback and continuous improvement.
