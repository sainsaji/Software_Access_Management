CREATE TABLE roles(
    role_id INT PRIMARY KEY IDENTITY(1,1),
    role_name VARCHAR(25)
);

CREATE TABLE software (
    soft_id INT PRIMARY KEY IDENTITY(1,1),
    soft_name VARCHAR(10)
);

CREATE TABLE users (
    id INT AUTO_INCREMENT,
    user_name VARCHAR(50) NOT NULL,
    password VARCHAR(255) NOT NULL,
    role_id INT,
    name VARCHAR(30),
    email VARCHAR(30),
    phone_number VARCHAR(30),
    address VARCHAR(30),
    manager_assigned VARCHAR(7),
    PRIMARY KEY (id,user_name),
    FOREIGN KEY (role_id) REFERENCES roles(role_id) ON DELETE CASCADE
);


insert into users values(0,"Admin","$2a$11$3f5r2mzl.QBV18gsdivNX.jgQgCaNI4VzGsUub/FTEKY5ehB9Dl1q",1,"Admin","admin@gmail.com",1234567898,"bangalore",false);

CREATE TABLE softwareAssigned (
    softAssignedId INT PRIMARY KEY IDENTITY(1,1),
    user_id INT,
    soft_ids INT,
    FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE,
    FOREIGN KEY (soft_ids) REFERENCES software(soft_id) ON DELETE CASCADE
);



CREATE TABLE managerAssigned(
    rel_id INT PRIMARY KEY AUTO_INCREMENT,
    manager_id INT NOT NULL,
    users_id INT NOT NULL,
    FOREIGN KEY (manager_id) REFERENCES users(id) ON DELETE CASCADE,
    FOREIGN KEY (users_id) REFERENCES users(id) ON DELETE CASCADE
);

CREATE TABLE request_table (
    request_id INT PRIMARY KEY AUTO_INCREMENT,
    user_id INT,
    approval_manager VARCHAR(10),
    approval_admin VARCHAR(10),
    req_status VARCHAR(10),
    software_id INT,
    FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE,
    FOREIGN KEY (software_id) REFERENCES software(soft_id) ON DELETE CASCADE
);


CREATE TABLE request_list_table (
    req_id INT PRIMARY KEY IDENTITY(1,1),
    request_id INT,
    software_id INT,
    FOREIGN KEY (request_id) REFERENCES request_table(request_id),
    FOREIGN KEY (software_id) REFERENCES software(soft_id)
);
