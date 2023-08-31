# Software Access Management

## Project Description

The "Software Access Management" project aims to provide an efficient solution for managing software access within an organization. This project involves creating a database schema to handle various aspects of software access, user roles, and access requests.

## Database Schema

The project's database schema consists of several interconnected tables to manage different components of software access and user roles. The following tables are defined:

### `roles`

- `role_id` (INT): Primary key for roles table.
- `role_name` (VARCHAR(25)): Name of the user role.

### `software`

- `soft_id` (INT): Primary key for software table.
- `soft_name` (VARCHAR(10)): Name of the software.

### `users`

- `id` (INT): Primary key for users table.
- `user_name` (VARCHAR(50)): Username of the user (not nullable).
- `password` (VARCHAR(255)): User password (not nullable).
- `role_id` (INT): Foreign key referencing the roles table.
- `name` (VARCHAR(30)): Name of the user.
- `email` (VARCHAR(30)): Email address of the user.
- `phone_number` (VARCHAR(30)): Phone number of the user.
- `address` (VARCHAR(30)): Address of the user.
- Foreign key relationship: `role_id` references `roles(role_id)`.

### `softwareAssigned`

- `softAssignedId` (INT): Primary key for softwareAssigned table.
- `user_id` (INT): Foreign key referencing the users table.
- `soft_ids` (INT): Foreign key referencing the software table.
- Foreign key relationships: `user_id` references `users(id)`, `soft_ids` references `software(soft_id)`.

### `managerAssigned`

- `rel_id` (INT): Primary key for managerAssigned table.
- `manager_id` (INT): Foreign key referencing the users table (manager).
- `users_id` (INT): Foreign key referencing the users table (subordinate).
- Foreign key relationships: `manager_id` references `users(id)`, `users_id` references `users(id)`.

### `request_table`

- `request_id` (INT): Primary key for request_table.
- `user_id` (INT): Foreign key referencing the users table (requesting user).
- `approval_manager` (VARCHAR(10)): Approval status by manager.
- `approval_admin` (VARCHAR(10)): Approval status by admin.
- `req_status` (VARCHAR(10)): Request status.
- `software_id` (INT): Foreign key referencing the software table.
- Foreign key relationships: `user_id` references `users(id)`, `software_id` references `software(soft_id)`.

### `request_list_table`

- `req_id` (INT): Primary key for request_list_table.
- `request_id` (INT): Foreign key referencing the request_table.
- `software_id` (INT): Foreign key referencing the software table.
- Foreign key relationships: `request_id` references `request_table(request_id)`, `software_id` references `software(soft_id)`.

## Usage

This project's database schema serves as a foundation for managing software access within an organization. It allows for the management of user roles, software availability, user information, access requests, and their statuses. By interacting with this database, administrators can efficiently manage software access requests and permissions for various users.

## Contributing

Contributions to the "Software Access Management" project are welcome. If you would like to contribute, please follow the standard procedures for pull requests and issue tracking.

## License

This project is licensed under the [MIT License](LICENSE).
