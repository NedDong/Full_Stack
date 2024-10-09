// See https://aka.ms/new-console-template for more information


using HW3Color;

Color ball1Color = new Color(255,255,255);
Ball ball1 = new Ball(5,ball1Color,0);

ball1.Throw();
ball1.Throw();

Console.WriteLine(ball1.getTimesThrown());

ball1.Pop();
ball1.Throw();

Console.WriteLine(ball1.getTimesThrown());