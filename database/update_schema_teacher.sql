USE offline_exam_system;

-- Update the Role column to include 'Teacher'
ALTER TABLE Users MODIFY COLUMN Role ENUM('Admin', 'Student', 'Teacher') NOT NULL;

-- Insert a default Teacher for testing
-- Username: teacher, Password: teacher123
INSERT IGNORE INTO Users (Username, PasswordHash, FullName, Role) 
VALUES ('teacher', 'teacher123', 'Default Teacher', 'Teacher');
