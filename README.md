# To-Do List

A simple To-Do List application where users can manage their tasks. The application allows users to add tasks, mark them as done, undo completed tasks, and delete tasks.

## Features

- **Add Tasks**: Use a form to input new tasks.
- **Ongoing Tasks Table**: Displays all tasks that are yet to be completed.
- **Completed Tasks Table**: Displays all tasks that have been marked as done.
- **Task Management Buttons**:
  - **Done**: Mark a task as completed.
  - **Undo**: Revert a task from completed to ongoing.
  - **Delete**: Remove a task from the list.

## Installation

To run this project locally, follow these steps:

1. **Clone the repository**:
    ```bash
    git clone https://github.com/your-username/todo-list.git
    cd todo-list
    ```

2. **Install the required NuGet packages**:
    - Microsoft.EntityFrameworkCore
    - Microsoft.EntityFrameworkCore.Design
    - Microsoft.EntityFrameworkCore.Tools
    - Microsoft.EntityFrameworkCore.SqlServer

   You can install these packages using the NuGet Package Manager in Visual Studio or through the NuGet CLI:
    ```bash
    dotnet add package Microsoft.EntityFrameworkCore
    dotnet add package Microsoft.EntityFrameworkCore.Design
    dotnet add package Microsoft.EntityFrameworkCore.Tools
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    ```

3. **Configure the database**:
   - Ensure you have SQL Server installed locally.
   - Update the appsettings.json file with your SQL Server connection string.

4. **Apply database migrations**:

   ```bash
   Copy code
   dotnet ef database update
   ```
5. **Run the application**:
   ```bash
   Copy code
   dotnet run
   ```



## Usage
  - Adding Tasks: Fill out the task title in the form and click "Submit" to add a new task.
  - Managing Tasks:
  - Done: Click the "Done" button next to a task to mark it as completed.
  - Undo: Click the "Undo" button next to a completed task to move it back to ongoing.
  - Delete: Click the "Delete" button to remove a task from the list.
## Contributing
   Contributions are welcome! Please follow these steps to contribute:

  1. Fork the repository.
  2. Create a new branch (git checkout -b feature/your-feature-name).
  3. Commit your changes (git commit -m 'Add your feature').
  4. Push to the branch (git push origin feature/your-feature-name).
  5. Open a Pull Request.

![image](https://github.com/user-attachments/assets/13046057-d32f-49e8-bac8-46b76e52cf6a)
