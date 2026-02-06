USE offline_exam_system;

-- Run this if you already have the database created to add the new column
ALTER TABLE Users ADD COLUMN ProfileImage LONGBLOB;
