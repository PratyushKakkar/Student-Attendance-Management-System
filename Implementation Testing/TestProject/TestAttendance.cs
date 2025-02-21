using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_Engineering;

namespace TestProject
{
     [TestClass]
     public class AttendanceRecordTests
     {
          [TestMethod]
          public void TestValidStatusPresent()
          {
               // Arrange
               var attendanceRecord = new AttendanceRecord(DateTime.Now, "9:00 AM", "Math 101", "John Doe", "Present");

               // Act & Assert
               Assert.AreEqual("Present", attendanceRecord.Status);
          }

          [TestMethod]
          public void TestValidStatusAbsent()
          {
               // Arrange
               var attendanceRecord = new AttendanceRecord(DateTime.Now, "9:00 AM", "Math 101", "John Doe", "Absent");

               // Act & Assert
               Assert.AreEqual("Absent", attendanceRecord.Status);
          }

          [TestMethod]
          public void TestInvalidStatus()
          {
               // Arrange
               var attendanceRecord = new AttendanceRecord(DateTime.Now, "9:00 AM", "Math 101", "John Doe", "On Time");

               // Act & Assert
               Assert.AreEqual("Absent", attendanceRecord.Status); // Since the default status is "Absent"
          }

          [TestMethod]
          public void TestJustificationRequiredForAbsentOrLate()
          {
               // Arrange
               var attendanceRecord = new AttendanceRecord(DateTime.Now, "9:00 AM", "Math 101", "John Doe", "Absent");

               // Act
               attendanceRecord.UpdateRecord("Absent", ""); // Empty justification should be rejected

               // Assert
               Assert.AreEqual("", attendanceRecord.Justification); // Justification should remain empty
          }

          [TestMethod]
          public void TestJustificationLengthLimit()
          {
               // Arrange
               var attendanceRecord = new AttendanceRecord(DateTime.Now, "9:00 AM", "Math 101", "John Doe", "Absent");

               // Act
               string longJustification = new string('A', 51); // 51 characters (exceeding the limit)
               attendanceRecord.UpdateRecord("Absent", longJustification);

               // Assert
               Assert.AreEqual("", attendanceRecord.Justification); // Justification should not be updated
          }

          [TestMethod]
          public void TestValidJustification()
          {
               // Arrange
               var attendanceRecord = new AttendanceRecord(DateTime.Now, "9:00 AM", "Math 101", "John Doe", "Present");

               // Act
               attendanceRecord.UpdateRecord("Absent", "Sick due to flu."); // Valid justification

               // Assert
               Assert.AreEqual("Sick due to flu.", attendanceRecord.Justification); // Justification should be updated
          }

          [TestMethod]
          public void TestJustificationWithNumbers()
          {
               // Arrange
               var attendanceRecord = new AttendanceRecord(DateTime.Now, "9:00 AM", "Math 101", "John Doe", "Present");

               // Act
               attendanceRecord.UpdateRecord("Late", "Sick for 3 days!"); // Justification contains numbers

               // Assert
               Assert.AreEqual("", attendanceRecord.Justification); // Justification should be rejected because of numbers
          }

          [TestMethod]
          public void TestStatusChangeToSameValue()
          {
               // Arrange
               var attendanceRecord = new AttendanceRecord(DateTime.Now, "9:00 AM", "Math 101", "John Doe", "Present");

               // Act
               attendanceRecord.UpdateRecord("Present", ""); // Trying to update to the same status

               // Assert
               Assert.AreEqual("Present", attendanceRecord.Status); // Status should not change
          }
     }
}

