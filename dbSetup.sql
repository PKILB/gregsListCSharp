CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS houses(
  id INT AUTO_INCREMENT PRIMARY Key,
  bedrooms INT NOT Null DEFAULT 1,
  bathrooms INT NOT NULL DEFAULT 1,
  levels INT NOT NULL DEFAULT 1,
  imgUrl VARCHAR(200),
  year INT NOT NULL DEFAULT 2025,
  price DOUBLE NOT NULL DEFAULT 1.00,
  description TEXT
)default charset utf8 COMMENT '';
DROP table IF EXISTS houses;

CREATE TABLE IF NOT EXISTS jobs(
  id INT AUTO_INCREMENT PRIMARY Key,
  wage INT NOT Null DEFAULT 100,
  hours INT NOT NULL DEFAULT 40,
  imgUrl VARCHAR(200),
  description TEXT
)default charset utf8 COMMENT '';
DROP table IF EXISTS jobs;