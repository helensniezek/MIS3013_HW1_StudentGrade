﻿// MIS3013 HW1 
// Student Grade
//
string outMesStr = "What is your first name? ";
Console.Write(outMesStr);
string stuFirstNameStr=Console.ReadLine();

outMesStr = "What is your last name? ";
Console.Write(outMesStr);
string stuLastNameStr=Console.ReadLine();

outMesStr = "What is your student ID? ";
Console.Write(outMesStr);
string stuIDStr=Console.ReadLine();

outMesStr = "What is the overall percentage for the homework? ";
Console.Write(outMesStr);
string homeworkStr=Console.ReadLine();
double homeworkDbl=Convert.ToDouble(homeworkStr);

outMesStr = "What is the overall percentage for the exercises? ";
Console.Write(outMesStr);
string exerciseStr=Console.ReadLine();
double exerciseDbl=Convert.ToDouble(exerciseStr);

outMesStr = "What is the overall percentage for the exam? ";
Console.Write(outMesStr);
string examStr=Console.ReadLine();
double examDbl=Convert.ToDouble(examStr);

double finalDbl = homeworkDbl *0.24+exerciseDbl*0.4+examDbl*0.36;

// finalDbl = finalDbl / 100;
outMesStr = string.Format($"{stuFirstNameStr} {stuLastNameStr} ({stuIDStr}): {finalDbl/100:P2}");
Console.Write(outMesStr);





Console.ReadLine();