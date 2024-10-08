# Loose Coupling

The script provides loose coupling approach to sending mail.It includes a functionality like send mail.It utilizes the concept of loose coupling,inheritance, polymorphism

## Table of Contents

- [Features](#features)
- [Code Structure](#code-structure)
- [How to use it](#how-to-use-it)
- [Author](#author)
  
## Features

- **Send Email**: Allows users to send email through mail services(Gmail,Hotmail...etc)
- **Polymorphism**: Demonstrates polymorphic behavior by using different mail services for sending users text.
- **Loose Coupling**: Utilizes loosed relationships between objects not to depend on just one mail service but all services

## How to use it

1. **Compile and Run**: Compile the script and execute the compiled program to interact with the Loose coupling project
2. **Follow Console**: Follow the screen to see your used mail services
3. **Provide Information**: Provide the required information such as send to whom,what text to send
4. **Receive Notifications**: Upon completion of each operation, the user will receive message by  a mail service 

 ## Code Structure
 
- **Program.cs**: Main entry point of the application containing the `Main` method.
- **Dependency.cs**: Here tight coupling applied,not ideal code
- **InDependency.cs**: Here loose coupling applied,ideal code
  
## Author

- Rustem Cabrayilov - https://github.com/RustemCabrayilov
