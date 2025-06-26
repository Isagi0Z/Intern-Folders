USE StudentManagement;
GO

CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Age INT,
    Email VARCHAR(100) UNIQUE,
    EnrollmentDate DATE DEFAULT GETDATE()
);



