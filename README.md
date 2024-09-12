# JoinInLinq

I want to explain all kind of joins in this repository

# We do not have left outer join in Linq

we know, linq does not have builtin left outer join, so we must simulate the join.

# Simulation

we can simulation left outer join with 'GroupJoin' in this sample I clarify this subject

# How

How are we simulate left outer join with 'GroupJoin' ?
I want to explain this question.
This simulation is very simple but very useful, when we have 2 collection and need join them, join is important concept.

Imagine you have two collection like Student and Course, Every student has one or more course, and you want to show list of student courses and also show every student is who does not have any courses, so you must use left outer join.

# Output Sample

![Build Cart Api](https://github.com/nikravesh/JoinInLinq/blob/main/LeftouterJoinSimulation.Output/OutputSample/result.png)

# How To Run

This is a very sample console project, clone project and run by two way :
Open the project in Visual studio and press F5
or with .Net cli, open CMD and go to project folder and execute this command 'dotnet run' and press enter
