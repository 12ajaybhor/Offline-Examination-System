CREATE DATABASE IF NOT EXISTS offline_exam_system;
USE offline_exam_system;

-- Users Table (Admin & Students)
CREATE TABLE IF NOT EXISTS Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL, -- Storing plain text for simplicity in this demo, but should be hashed
    FullName VARCHAR(100),
    ProfileImage LONGBLOB, -- Store image as binary
    Role ENUM('Admin', 'Student') NOT NULL,
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Exams Table
CREATE TABLE IF NOT EXISTS Exams (
    ExamID INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(100) NOT NULL,
    Description TEXT,
    DurationMinutes INT NOT NULL,
    PassingScore INT NOT NULL,
    IsActive BOOLEAN DEFAULT TRUE,
    CreatedBy INT,
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserID)
);

-- Questions Table
CREATE TABLE IF NOT EXISTS Questions (
    QuestionID INT AUTO_INCREMENT PRIMARY KEY,
    ExamID INT,
    QuestionText TEXT NOT NULL,
    OptionA VARCHAR(255) NOT NULL,
    OptionB VARCHAR(255) NOT NULL,
    OptionC VARCHAR(255) NOT NULL,
    OptionD VARCHAR(255) NOT NULL,
    CorrectOption CHAR(1) NOT NULL, -- 'A', 'B', 'C', or 'D'
    Marks INT DEFAULT 1,
    FOREIGN KEY (ExamID) REFERENCES Exams(ExamID) ON DELETE CASCADE
);

-- Results Table (Stores the final score of a student for an exam)
CREATE TABLE IF NOT EXISTS Results (
    ResultID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT,
    ExamID INT,
    Score INT,
    TotalMarks INT,
    Percentage DECIMAL(5,2),
    TakenAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
);

-- Default Admin User
-- Username: admin, Password: admin123(plain)
INSERT IGNORE INTO Users (Username, PasswordHash, FullName, Role) 
VALUES ('admin', 'admin123', 'System Administrator', 'Admin');
