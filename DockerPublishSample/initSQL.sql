CREATE DATABASE School
GO
USE School
GO

CREATE TABLE Students (
  id INT IDENTITY(1,1) PRIMARY KEY,
  name VARCHAR(100),
  age INTEGER
);

INSERT INTO Students (name, age) VALUES
  ('Mkyong', 40),
  ('Ali', 28),
  ('Teoh', 18);

  SELECT * FROM Students