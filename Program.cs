// See https://aka.ms/new-console-template for more information
using QuizQuestions;

MultipleChoice xyz = new MultipleChoice("What is the capital of USA?", "1. NY \n2. Washington D.C",0);
/*
 * 1 New York\n
 * 2 Wash DC\n
 * 
 * 
 * correctAnswer = 2;
 * 
 * grade
 * 
 * quiz list <all of the questions>
 * quiz correctAnswerList <question.grade>
 * */
xyz.printQuestion();
//Console.WriteLine("/n" + xyz.Choices);

//write all of the unique queries
//firstQuery.AskQuestion();