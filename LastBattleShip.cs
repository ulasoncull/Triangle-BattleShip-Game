using System;


namespace BattleShip
{
    class Program
    {
        static double PI = 3.1415926;
        static int xA;
        static int yA;
        static int xB;
        static int yB;
        static int xC;
        static int yC;
        static double score;
        static string nameOfPlayer1 = "Sümeyye Başkan";
        static string nameOfPlayer2 = "Onur Özmen";
        static string nameOfPlayer3 = "Şahin Öztürk";
        static double scoreOfPlayer1 = 130.00;
        static double scoreOfPlayer2 = 81.00;
        static double scoreOfPlayer3 = 40.00;
        static Random Bullet = new Random();
        static int xS;
        static int yS;
        static string nameOfPlayer;
        static double lenghtOfSideA;
        static double lenghtOfSideB;
        static double lenghtOfSideC;
        static double ThePerimeterOfTheship;
        static double halfTheCircumferenceOfTheShip;
        static double theAreaOfTheShip;


        static void Main(string[] args)
        {


            for (int i = 0; i < 6;)
            {

                if (i == 0)
                {

                    Console.WriteLine(@"
                -MENU - 
PLEASE SELECT FROM THE OPTIONS BELOW:
1 – Enter ship location

2 – Ship info

3 – Shoot at the ship

4 – Show high score table

5 – Exit

");
                    bool isValid = true;
                    do
                    {

                        if (!isValid)
                        {
                            Console.WriteLine("Please enter number around 1-5");
                        }
                        isValid = Int32.TryParse(Console.ReadLine(), out i);

                    } while (i < 1 || i > 5);

                }
                else if (i == 1)
                {
                    Console.Clear();

                    int k = 1;
                    xA = 0;
                    xB = 0;
                    xC = 0;
                    yA = 0;
                    yB = 0;
                    yC = 0;



                    do
                    {
                        Console.WriteLine("Please enter the location of the ship:");
                        do
                        {

                            if (xA == 0)
                                Console.WriteLine("Please enter the x coordinate of corner A of the ship");
                            else if (xA > 30 || xA < 1)
                                Console.WriteLine("Please select valid points");
                            Int32.TryParse(Console.ReadLine(), out xA);


                        } while (xA > 30 || xA < 1);
                        do
                        {

                            if (yA == 0)
                                Console.WriteLine("Please enter the y coordinate of corner A of the ship");
                            else if (yA > 12 || yA < 1)
                                Console.WriteLine("Please select valid points");
                            Int32.TryParse(Console.ReadLine(), out yA);


                        } while (yA > 12 || yA < 1);

                        do
                        {
                            if (xB == 0)
                                Console.WriteLine("Please enter the x coordinate of corner B of the ship");
                            else if (xB > 30 || xB < 1)
                                Console.WriteLine("Please select valid points");
                            Int32.TryParse(Console.ReadLine(), out xB);

                        } while (xB > 30 || xB < 1);
                        do
                        {
                            if (yB == 0)
                                Console.WriteLine("Please enter the y coordinate of corner B of the ship");
                            else if (yB > 12 || yB < 1)
                                Console.WriteLine("Please select valid points");
                            Int32.TryParse(Console.ReadLine(), out yB);

                        } while (yB > 12 || yB < 1);

                        do
                        {
                            if (xC == 0)
                                Console.WriteLine("Please enter the x coordinate of corner C of the ship");
                            else if (xC > 30 || xC < 1)
                                Console.WriteLine("Please select valid points");
                            Int32.TryParse(Console.ReadLine(), out xC);

                        } while (xC > 30 || xC < 1);
                        do
                        {
                            if (yC == 0)
                                Console.WriteLine("Please enter the y coordinate of corner C of the ship");
                            else if (yC > 12 || yC < 1)
                                Console.WriteLine("Please select valid points");
                            Int32.TryParse(Console.ReadLine(), out yC);

                        } while (yC > 12 || yC < 1);

                        lenghtOfSideA = Math.Sqrt(Math.Pow((yC - yB), 2) + Math.Pow((xC - xB), 2)); //Calculates the length of side A.
                        lenghtOfSideB = Math.Sqrt(Math.Pow((yC - yA), 2) + Math.Pow((xC - xA), 2)); //Calculates the length of side B.
                        lenghtOfSideC = Math.Sqrt(Math.Pow((yB - yA), 2) + Math.Pow((xB - xA), 2)); //Calculates the length of side C.
                        ThePerimeterOfTheship = lenghtOfSideA + lenghtOfSideB + lenghtOfSideC; //Calculates the perimeter of the ship.
                        halfTheCircumferenceOfTheShip = ThePerimeterOfTheship / 2; //Calculates half of the perimeter of the ship.
                        theAreaOfTheShip = Math.Sqrt(halfTheCircumferenceOfTheShip * (halfTheCircumferenceOfTheShip - lenghtOfSideA) * (halfTheCircumferenceOfTheShip - lenghtOfSideB)
* (halfTheCircumferenceOfTheShip - lenghtOfSideC)); //Calculates the area of ​​the ship.
                        lenghtOfSideA = Math.Sqrt(Math.Pow((yC - yB), 2) + Math.Pow((xC - xB), 2)); //Calculates the length of side A.
                        lenghtOfSideB = Math.Sqrt(Math.Pow((yC - yA), 2) + Math.Pow((xC - xA), 2)); //Calculates the length of side B.
                        lenghtOfSideC = Math.Sqrt(Math.Pow((yB - yA), 2) + Math.Pow((xB - xA), 2)); //Calculates the length of side C.


                        if (theAreaOfTheShip == 0)
                        {
                            Console.WriteLine("Cannot form a triangle with these coordinates. Please select valid points." + theAreaOfTheShip);
                            i = 0;
                            xA = 0;
                            xB = 0;
                            xC = 0;
                            yA = 0;
                            yB = 0;
                            yC = 0;
                        }
                        else
                        {
                            k = 2;
                        }
                        



                    } while (k == 1);

                    Console.Clear();



                    Console.WriteLine("A: (" + xA + ", " + yA + ")");
                    Console.WriteLine("B: (" + xB + ", " + yB + ")");
                    Console.WriteLine("C: (" + xC + ", " + yC + ")\n");
                    Console.WriteLine(@"   12|
   11| 
   10|  
    9| 
    8|
    7|
    6|
    5|
    4|
    3|
    2|
    1|
     +------------------------------
      123456789012345678901234567890");

                    Console.SetCursorPosition(xA + 5, Console.CursorTop - 2 - yA);  //Moves the cursor to the coordinates of point A in the coordinate plane.
                    Console.Write("A");
                    Console.SetCursorPosition(xB + 5, Console.CursorTop - yB + yA); //Moves the cursor to the coordinates of point B in the coordinate plane.
                    Console.Write("B");
                    Console.SetCursorPosition(xC + 5, Console.CursorTop - yC + yB); //Moves the cursor to the coordinates of point C in the coordinate plane.
                    Console.Write("C");

                    Console.SetCursorPosition(0, Console.CursorTop + yC + 2); //Moves the cursor to the last line.
                    i = 0;
                }
                else if (i == 2)
                {
                    Console.Clear();

                    if (xA != 0 && yA != 0 && xB != 0 && yB != 0 && xC != 0 && yC != 0)
                    {

                        Console.WriteLine("\nSHIP INFO");
                        lenghtOfSideA = Math.Sqrt(Math.Pow((yC - yB), 2) + Math.Pow((xC - xB), 2)); //Calculates the length of side A.
                        lenghtOfSideB = Math.Sqrt(Math.Pow((yC - yA), 2) + Math.Pow((xC - xA), 2)); //Calculates the length of side B.
                        lenghtOfSideC = Math.Sqrt(Math.Pow((yB - yA), 2) + Math.Pow((xB - xA), 2)); //Calculates the length of side C.
                        Console.WriteLine("The size of the ship:" + "a = " + lenghtOfSideA + " b = " + lenghtOfSideB + " c = " + lenghtOfSideC);
                        ThePerimeterOfTheship = lenghtOfSideA + lenghtOfSideB + lenghtOfSideC; //Calculates the perimeter of the ship.
                        Console.WriteLine("The perimeter of the ship : " + ThePerimeterOfTheship);
                        halfTheCircumferenceOfTheShip = ThePerimeterOfTheship / 2; //Calculates half of the perimeter of the ship.
                        theAreaOfTheShip = Math.Sqrt(halfTheCircumferenceOfTheShip * (halfTheCircumferenceOfTheShip - lenghtOfSideA) * (halfTheCircumferenceOfTheShip - lenghtOfSideB)
                       * (halfTheCircumferenceOfTheShip - lenghtOfSideC)); //Calculates the area of ​​the ship.
                        Console.WriteLine("The area of the ship : " + theAreaOfTheShip);
                        double degreeOfAAngle = Math.Acos(((lenghtOfSideB * lenghtOfSideB) + (lenghtOfSideC * lenghtOfSideC) - (lenghtOfSideA * lenghtOfSideA)) / (2 * lenghtOfSideB * lenghtOfSideC)) * 180 / PI; //Calculates the angle of corner A.            
                        double degreeOfBAngle = Math.Acos(((lenghtOfSideA * lenghtOfSideA) + (lenghtOfSideC * lenghtOfSideC) - (lenghtOfSideB * lenghtOfSideB)) / (2 * lenghtOfSideA * lenghtOfSideC)) * 180 / PI; //Calculates the angle of corner B.
                        double degreeOfCAngle = Math.Acos(((lenghtOfSideB * lenghtOfSideB) + (lenghtOfSideA * lenghtOfSideA) - (lenghtOfSideC * lenghtOfSideC)) / (2 * lenghtOfSideB * lenghtOfSideA)) * 180 / PI; //Calculates the angle of corner C.
                        Console.WriteLine("The angles of the ship: A = " + degreeOfAAngle + " B = " + degreeOfBAngle + "C = " + degreeOfCAngle);
                        double xTheMidpointOfAB = (xA + xB) / 2;
                        double yTheMidpointOfAB = (yA + yB) / 2;
                        double xTheMidpointOfAC = (xA + xC) / 2;
                        double yTheMidpointOfAC = (yA + yC) / 2;
                        double xTheMidpointOfBC = (xB + xC) / 2;
                        double yTheMidpointOfBC = (yB + yC) / 2;
                        Console.WriteLine("The median points: AB(" + xTheMidpointOfAB + "," + yTheMidpointOfAB + ") "
                        + "AC(" + xTheMidpointOfAC + "," + yTheMidpointOfAC + ") " + "BC(" + xTheMidpointOfBC + "," + yTheMidpointOfBC + ") "); //Prints the coordinates of the midpoints of the sides.
                        double xTheCentroidOfTheShip = (xA + xB + xC) / 3;
                        double yTheCentroidOfTheShip = (yA + yB + yC) / 3;
                        Console.WriteLine("The centroid of the ship: (" + xTheCentroidOfTheShip + "," + yTheCentroidOfTheShip + ")"); //Prints the coordinates of the centroid of the triangle.

                        double S;
                        S = (lenghtOfSideA + lenghtOfSideB + lenghtOfSideC) / 2;

                        double IC;
                        IC = PI * Math.Pow((Math.Sqrt(((S - lenghtOfSideA) * (S - lenghtOfSideB) * (S - lenghtOfSideC)) / S)), 2);
                        Console.WriteLine("The Area Of Inscribed Cricle :" + IC);

                        double R;
                        R = (lenghtOfSideA * lenghtOfSideB * lenghtOfSideC) / Math.Sqrt((lenghtOfSideA + lenghtOfSideB + lenghtOfSideC) * (lenghtOfSideA + lenghtOfSideB - lenghtOfSideC) * (lenghtOfSideB + lenghtOfSideC - lenghtOfSideA) * (lenghtOfSideA + lenghtOfSideC - lenghtOfSideB));
                        double CC;
                        CC = PI * Math.Pow((R), 2);
                        Console.WriteLine("The Area Of Circumscribed Circle:" + CC);

                        double LB;
                        LB = (2 * Math.Sqrt(lenghtOfSideB * lenghtOfSideC * S * (S - lenghtOfSideA))) / (lenghtOfSideB + lenghtOfSideC);
                        Console.WriteLine("The Length of the Bisector: " + LB);

                        if (degreeOfAAngle > 90 || degreeOfBAngle > 90 || degreeOfCAngle > 90)
                            Console.WriteLine("The type of the ship: Isosceles :Obtuse-angel");
                        else if (degreeOfAAngle == 90 || degreeOfBAngle == 90 || degreeOfCAngle == 90)
                            Console.WriteLine("The type of the ship: Isosceles :Right-angel");

                        else
                            Console.WriteLine("The type of the ship: Isosceles :Acute-angled");


                        i = 0;
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("\nPlease enter the ship's location first!\n");
                        i = 0;
                    }
                }
                else if (i == 3)
                {
                    Console.Clear();

                    if (xA != 0 && yA != 0 && xB != 0 && yB != 0 && xC != 0 && yC != 0)
                    {

                        xS = Bullet.Next(1, 31);
                        yS = Bullet.Next(1, 13);
                        Console.WriteLine(@"   12|
   11| 
   10|  
    9| 
    8|
    7|
    6|
    5|
    4|
    3|
    2|
    1|
     +------------------------------
      123456789012345678901234567890");

                        Console.SetCursorPosition(xA + 5, Console.CursorTop - 2 - yA);  //Moves the cursor to the coordinates of point A in the coordinate plane.
                        Console.Write("A");
                        Console.SetCursorPosition(xB + 5, Console.CursorTop - yB + yA); //Moves the cursor to the coordinates of point B in the coordinate plane.
                        Console.Write("B");
                        Console.SetCursorPosition(xC + 5, Console.CursorTop - yC + yB); //Moves the cursor to the coordinates of point C in the coordinate plane.
                        Console.Write("C");
                        Console.SetCursorPosition(xS + 5, Console.CursorTop - yS + yC);
                        Console.WriteLine("X");
                        Console.SetCursorPosition(0, Console.CursorTop + yS + 2); //Moves the cursor to the last line.


                        double lenghtOfSideA = Math.Sqrt(Math.Pow((yC - yB), 2) + Math.Pow((xC - xB), 2)); //Calculates the length of side A.
                        double lenghtOfSideB = Math.Sqrt(Math.Pow((yC - yA), 2) + Math.Pow((xC - xA), 2)); //Calculates the length of side B.
                        double lenghtOfSideC = Math.Sqrt(Math.Pow((yB - yA), 2) + Math.Pow((xB - xA), 2)); //Calculates the length of side C.
                        double ThePerimeterOfTheship = lenghtOfSideA + lenghtOfSideB + lenghtOfSideC; //Calculates the perimeter of the ship.
                        double halfTheCircumferenceOfTheShip = ThePerimeterOfTheship / 2; //Calculates half of the perimeter of the ship.


                        double theAreaOfTheShip = Math.Sqrt(halfTheCircumferenceOfTheShip * (halfTheCircumferenceOfTheShip - lenghtOfSideA) * (halfTheCircumferenceOfTheShip - lenghtOfSideB) * (halfTheCircumferenceOfTheShip - lenghtOfSideC)); //Calculates the area of ​​the ship.

                        double areaOfXAB = Math.Abs((((Convert.ToDouble(xA) * Convert.ToDouble(yB)) + (Convert.ToDouble(xB) * Convert.ToDouble(yS)) + (Convert.ToDouble(xS) * Convert.ToDouble(yA)) - ((Convert.ToDouble(xB) * Convert.ToDouble(yA)) + (Convert.ToDouble(xS) * Convert.ToDouble(yB)) + (Convert.ToDouble(xA) * Convert.ToDouble(yS))))) / 2.00);
                        double areaOfXAC = Math.Abs((((Convert.ToDouble(xA) * Convert.ToDouble(yC)) + (Convert.ToDouble(xC) * Convert.ToDouble(yS)) + (Convert.ToDouble(xS) * Convert.ToDouble(yA)) - ((Convert.ToDouble(xC) * Convert.ToDouble(yA)) + (Convert.ToDouble(xS) * Convert.ToDouble(yC)) + (Convert.ToDouble(xA) * Convert.ToDouble(yS))))) / 2.00);
                        double areaOfXCB = Math.Abs((((Convert.ToDouble(xC) * Convert.ToDouble(yB)) + (Convert.ToDouble(xB) * Convert.ToDouble(yS)) + (Convert.ToDouble(xS) * Convert.ToDouble(yC)) - ((Convert.ToDouble(xB) * Convert.ToDouble(yC)) + (Convert.ToDouble(xS) * Convert.ToDouble(yB)) + (Convert.ToDouble(xC) * Convert.ToDouble(yS))))) / 2.00);

                        if (areaOfXAB + areaOfXAC + areaOfXCB == Math.Round(theAreaOfTheShip, 1))
                        {
                            Console.WriteLine(@"Your ship sank!!
Your score: 0");
                            score = 0;
                            xA = 0;
                            xB = 0;
                            xC = 0;
                            yA = 0;
                            yB = 0;
                            yC = 0;

                            i = 0;

                        }
                        else
                        {
                            score = Math.Round(theAreaOfTheShip, 1);
                            Console.WriteLine("Congrulations! Your ship survived. Your score = " + score);
                            if (score >= 40)
                            {
                                Console.WriteLine("Please enter your name:");
                                nameOfPlayer = Console.ReadLine();
                            }

                            xA = 0;
                            xB = 0;
                            xC = 0;
                            yA = 0;
                            yB = 0;
                            yC = 0;

                            i = 0;
                        }




                        i = 0;
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("\nPlease enter the ship's location first!\n");
                        i = 0;
                    }
                }
                else if (i == 4)
                {
                    Console.Clear();

                    if (xS == 0 && yS == 0)
                    {
                        Console.WriteLine("High Score Table:");
                        Console.WriteLine(nameOfPlayer1 + "=" + scoreOfPlayer1);
                        Console.WriteLine(nameOfPlayer2 + "=" + scoreOfPlayer2);
                        Console.WriteLine(nameOfPlayer3 + "=" + scoreOfPlayer3);
                        i = 0;
                    }
                    else if (score >= 40 && score < 81)
                    {
                        Console.WriteLine("High Score Table:");
                        Console.WriteLine(nameOfPlayer1 + "=" + scoreOfPlayer1);
                        Console.WriteLine(nameOfPlayer2 + "=" + scoreOfPlayer2);
                        Console.WriteLine(nameOfPlayer + "=" + score);
                        i = 0;
                    }
                    else if (score >= 81 && score < 130)
                    {
                        Console.WriteLine("High Score Table:");
                        Console.WriteLine(nameOfPlayer1 + "=" + scoreOfPlayer1);
                        Console.WriteLine(nameOfPlayer + "=" + score);
                        Console.WriteLine(nameOfPlayer2 + "=" + scoreOfPlayer2);
                        i = 0;
                    }
                    else if (score < 40)
                    {
                        Console.WriteLine("High Score Table:");
                        Console.WriteLine(nameOfPlayer1 + "=" + scoreOfPlayer1);
                        Console.WriteLine(nameOfPlayer2 + "=" + scoreOfPlayer2);
                        Console.WriteLine(nameOfPlayer3 + "=" + scoreOfPlayer3);
                        i = 0;
                    }
                    else if (score >= 130)
                    {
                        Console.WriteLine("High Score Table:");
                        Console.WriteLine(nameOfPlayer + "=" + score);
                        Console.WriteLine(nameOfPlayer2 + "=" + scoreOfPlayer2);
                        Console.WriteLine(nameOfPlayer3 + "=" + scoreOfPlayer3);
                        i = 0;
                    }
                }
                else if (i == 5)
                {
                    Console.Clear();

                    Console.WriteLine(@"Are you sure you want to exit game ?
             (Y)/(N)");
                    string inputOfExit = Console.ReadLine();
                    if (inputOfExit == "Y" || inputOfExit == "y")
                    {
                        Environment.Exit(0);
                    }
                    else if (inputOfExit == "n" || inputOfExit == "N")
                    {
                        i = 0;
                    }
                    else
                    {
                        Console.WriteLine("Please enter only Y and N");
                    }

                }
            }









            Console.Read();




        }
    }
}