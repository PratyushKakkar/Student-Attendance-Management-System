using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Project Name
namespace Software_Engineering
{
     //Class 'AttendanceRecord'
     public class AttendanceRecord
     {
          // Data Members
          public DateTime Date { get; set; }
          public string Time { get; set; }
          public string ClassName { get; set; }
          public string StudentName { get; set; }
          public string Status { get; set; }                               //"Present", "Absent", "Late"
          public string Justification { get; set; }                     //Reason for Updating Record

          // Constructor
          public AttendanceRecord(DateTime date, string time, string className, string studentName, string status)
          {
               Date = date;
               Time = time;
               ClassName = className;
               StudentName = studentName;
               //Checking if Status is Valid
               if (IsValidStatus(status))
                    Status = status;
               else
               {
                    Status = "Absent";  // Default to "Absent" if invalid status is provided
                    Console.WriteLine("Invalid status provided. Defaulting to 'Absent'.");
               }
               Justification = string.Empty;           // Default value when NOT Updating Record
          }

          // Validation for Status
          private bool IsValidStatus(string status)
          {
               //Return true if the status is one of the valid values
               return (status == "Present" || status == "Absent" || status == "Late");
          }

          // Method to Update Attendance Status with Validation
          public void UpdateRecord(string newStatus, string justification = "")
          {
               // Check if the new status is valid
               if (!IsValidStatus(newStatus))
               {
                    Console.WriteLine("Invalid status. Status must be 'Present', 'Absent', or 'Late'.");
                    return;
               }

               // Check if status is being updated to the same value
               if (newStatus == Status)
               {
                    Console.WriteLine("Status is already set to this value. No update needed.");
                    return;
               }

               Status = newStatus;

               // Check justification length (max 50 characters)
               if (justification.Length > 50)
               {
                    Console.WriteLine("Justification is too long. Maximum allowed length is 50 characters.");
                    return;
               }

               // Check if justification is alphanumeric (no special characters)
               // Check if justification contains only alphabets and punctuation (no numbers)
               if (!Regex.IsMatch(justification, @"^[a-zA-Z\s\p{P}]*$"))
               {
                    Console.WriteLine("Justification can only contain letters, spaces, and punctuation (no numbers).");
                    return;
               }

               Justification = justification;
          }

          // Method to Display Attendance Record
          public void DisplayRecord()
          {
               Console.WriteLine($"Date: {Date.ToShortDateString()}, Time: {Time}, Class: {ClassName}, " +
                                 $"Student: {StudentName}, Status: {Status}, Justification: {Justification}");
          }






          //(NOT PART OF THE PROGRAM)
          //Main method to Test the Class if run
          public static void Main(string[] args)
          {
               // Creating a new AttendanceRecord instance
               AttendanceRecord record1 = new AttendanceRecord(DateTime.Now, "10:00 AM", "Math 101", "John Doe", "Present");

               // Display the record
               record1.DisplayRecord();

               // Updating the record (e.g., late with a reason)
               record1.UpdateRecord("Late", "Traffic delay");

               // Display the updated record
               record1.DisplayRecord();

               Console.ReadLine();
          }
     }
}

