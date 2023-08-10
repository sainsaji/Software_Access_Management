CREATE TABLE roles(
    role_id INT PRIMARY KEY IDENTITY(1,1),
    role_name VARCHAR(25)
);

CREATE TABLE software (
    soft_id INT PRIMARY KEY IDENTITY(1,1),
    soft_name VARCHAR(10)
);

CREATE TABLE users (
    id INT PRIMARY KEY IDENTITY(1,1),
    user_name VARCHAR(50) NOT NULL,
    password VARCHAR(255) NOT NULL,
    role_id INT,
    name VARCHAR(30),
    email VARCHAR(30),
    phone_number VARCHAR(30),
    address VARCHAR(30),
    FOREIGN KEY (role_id) REFERENCES roles(role_id)
);



CREATE TABLE softwareAssigned (
    softAssignedId INT PRIMARY KEY IDENTITY(1,1),
    user_id INT,
    soft_ids INT,
    FOREIGN KEY (user_id) REFERENCES users(id),
    FOREIGN KEY (soft_ids) REFERENCES software(soft_id)
);



CREATE TABLE managerAssigned(
    rel_id INT PRIMARY KEY IDENTITY(1,1),
    manager_id INT NOT NULL,
    users_id INT NOT NULL,
    FOREIGN KEY (manager_id) REFERENCES users(id),
    FOREIGN KEY (users_id) REFERENCES users(id)
);

CREATE TABLE request_table (
    request_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT,
    approval_manager VARCHAR(10),
    approval_admin VARCHAR(10),
    req_status VARCHAR(10),
    FOREIGN KEY (user_id) REFERENCES users(id)
);

CREATE TABLE request_list_table (
    req_id INT PRIMARY KEY IDENTITY(1,1),
    request_id INT,
    software_id INT,
    FOREIGN KEY (request_id) REFERENCES request_table(request_id),
    FOREIGN KEY (software_id) REFERENCES software(soft_id)
);
