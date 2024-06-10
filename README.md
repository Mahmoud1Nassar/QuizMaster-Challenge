# QuizMaster Challenge
QuizMaster Challenge is a console-based quiz application designed to test your general knowledge with a series of questions. The application features robust input validation and exception handling to ensure a smooth and error-free user experience.

## Features
- **General Knowledge Questions**: The quiz contains a variety of questions across different topics to challenge your knowledge.
- **Input Validation**: Ensures that the user inputs valid answers and handles empty or invalid inputs gracefully.
- **Exception Handling**: Catches and manages unexpected errors to prevent the application from crashing.
- **User Feedback**: Provides immediate feedback for incorrect answers and displays the correct answer.

## How to Use
1. **Start the Application**: Run the program to start the quiz.
2. **Answer the Questions**: You will be presented with a series of questions. Type your answer and press Enter.
3. **Receive Feedback**: After submitting an answer, you will be informed whether your answer was correct. If incorrect, the correct answer will be displayed.
4. **View Your Score**: At the end of the quiz, your total score will be displayed.

## Handling Problems

### Input Validation
The application ensures that the user provides a valid input for each question. If the input is invalid (e.g., empty or null), the user will be prompted to enter their answer again until a valid input is received.

### Exception Handling
The application includes comprehensive exception handling to catch and manage unexpected errors. This prevents the application from crashing and provides the user with a clear message about the issue.

## Example Usage
1. **Start the Quiz**:
Welcome to QuizMaster Challenge!

markdown
Copy code

2. **Answering Questions**:
What is the capital of France?
(User input: "paris")

Who wrote the play 'Romeo and Juliet'?
(User input: "shakespeare")

...

markdown
Copy code

3. **Invalid Input Handling**:
What is the capital of France?
(User input: "")

Invalid input: Input cannot be empty. Please try again.
(User input: "paris")

markdown
Copy code

4. **Quiz Completion**:
You scored 8 out of 10.

markdown
Copy code

## Code Structure
- `Quiz.cs`: Contains the main logic for the quiz, including question handling, input validation, and exception management.
- `Program.cs`: Entry point of the application that initiates the quiz.

