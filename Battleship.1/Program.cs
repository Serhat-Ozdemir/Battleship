using System;

namespace Battleship._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ax = 0, Ay = 0, Bx = 0, By = 0, Cx = 0, Cy = 0; //for coordinates
            int choice = 0; //for menu selection
            int Ynumber = 12; //for coordinate's number
            double AB = 0, AC = 0, BC = 0; //for size of the ship
            double perimeter = 0, area = 0, u = 0; //for perimeter and area of the ship
            double CosA = 0, CosB = 0, CosC = 0, AngleA = 0, AngleB = 0, AngleC = 0; //for angles of the ship
            double Axmedian = 0, Aymedian = 0, Bxmedian = 0, Bymedian = 0, Cxmedian = 0, Cymedian = 0; //for median points
            double Xcentroid = 0, Ycentroid = 0; //for centroid of the ship
            double bisector = 0, x = 0; //for bisector length
            double in_circle_r = 0, in_circle_area = 0; //for inscribed circle are
            double circle_R = 0, circum_circle_area = 0; //for circumscribed circle
            double X_size_A = 0, X_size_B = 0, X_size_C = 0, X_u = 0, XAB_perimeter = 0, XAC_perimeter = 0, XBC_perimeter = 0, X_area = 0, XAB_area = 0, XAC_area = 0, XBC_area = 0, X_area_round = 0, area_round = 0; //for shot control
            int Rx = 0, Ry = 0; //for random shoot
            int tempX = 0, tempY = 0; //the last cursor position
            string player_name = "", nazan_name = "Nazan Kaya", elif_name = "Elif Polat", sibel_name = "Sibel Arslan"; //for player name
            double player_score = 0, temp_score = 0; //for player score
            int nazan_score = 60, elif_score = 24, sibel_score = 10; //for high score table



            Console.WriteLine("\n\t - MENU -\n1 – Enter ship location \n2 – Ship info \n3 – Shoot at the ship \n4 – Show high score table \n5 – Exit \n6 – Advantages of our game");

            while (choice != 5)// for make the menu in a loop
            {
                Console.Write("\nPLEASE SELECT FROM THE OPTIONS OF THE MENU: ");
                choice = Convert.ToInt32(Console.ReadLine()); //choose option from menu
                while (choice < 1 || choice > 6) //menu control
                {
                    Console.WriteLine("Please enter the number between 1 and 6");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                switch (choice)
                {
                    case 1:

                        if (Ax != 0) //location cannot be entered twice.
                        {
                            Console.WriteLine("You have already entered the location, you cannot enter it again.");
                        }
                        else
                        {
                            Console.WriteLine("Please enter the location of the ship:");
                            Console.Write("Ax: "); //Ax coordinate input
                            Ax = Convert.ToInt32(Console.ReadLine());
                            while (Ax < 1 || Ax > 30) //coordinate control
                            {
                                Console.Write("Warning! Please enter the location between 1 and 30 \nAx: ");
                                Ax = Convert.ToInt32(Console.ReadLine());
                            }

                            Console.Write("Ay: "); //Ay coordinate input
                            Ay = Convert.ToInt32(Console.ReadLine());
                            while (Ay < 1 || Ay > 12)//coordinate control
                            {
                                Console.Write("Warning! Please enter the location between 1 and 12 \nAy: ");
                                Ay = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("A: (" + Ax + "," + Ay + ")");

                            Console.Write("\nBx: "); //Bx coordinate input
                            Bx = Convert.ToInt32(Console.ReadLine());
                            while (Bx < 1 || Bx > 30)//coordinate control
                            {
                                Console.Write("Warning! Please enter the location between 1 and 30 \nBx: ");
                                Bx = Convert.ToInt32(Console.ReadLine());
                            }

                            Console.Write("By: "); //By coordinate input
                            By = Convert.ToInt32(Console.ReadLine());
                            if (Ax == Bx) //triangle control
                            {
                                while (Ay == By || By < 1 || By > 12) //triangle control (if the x's are the same, the y's must be different)
                                {
                                    if (Ay == By)
                                    {
                                        Console.Write("Warning! You cannot enter the same coordinate as A\nBy: ");
                                    }
                                    else if (By < 1 || By > 12)
                                    {
                                        Console.Write("Warning! Please enter the location between 1 and 12 \nBy: ");
                                    }
                                    By = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            while (By < 1 || By > 12) //coordinate control
                            {
                                Console.Write("Warning! Please enter the location between 1 and 12 \nBy: ");
                                By = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("B: (" + Bx + "," + By + ")");


                            Console.Write("\nCx: "); //Cx coordinate input
                            Cx = Convert.ToInt32(Console.ReadLine());
                            while (Ax == Cx && Bx == Cx) //triangle control
                            {
                                Console.Write("Warning! You cannot enter the same coordinate as A or B \nCx: ");
                                Cx = Convert.ToInt32(Console.ReadLine());
                                while (Cx < 1 || Cx > 30) //coordinate control
                                {
                                    Console.Write("Warning! Please enter the location between 1 and 30 \nCx: ");
                                    Cx = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            while (Cx < 1 || Cx > 30) //coordinate control
                            {
                                Console.Write("Warning! Please enter the location between 1 and 30 \nCx: ");
                                Cx = Convert.ToInt32(Console.ReadLine());
                            }

                            Console.Write("Cy: "); //Cy coordinate input
                            Cy = Convert.ToInt32(Console.ReadLine());
                            while (Ay == Cy && By == Cy) //triangle control
                            {
                                Console.Write("Warning! You cannot enter the same coordinate as A or B \nCy: ");
                                Cy = Convert.ToInt32(Console.ReadLine());
                                while (Cy < 1 || Cy > 12) //coordinate control
                                {
                                    Console.Write("Warning! Please enter the location between 1 and 12 \nCy: ");
                                    Cy = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            while (Cy < 1 || Cy > 12) //coordinate control
                            {
                                Console.Write("Warning! Please enter the location between 1 and 12 \nCy: ");
                                Cy = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("C: (" + Cx + "," + Cy + ")");

                            //The size of the ship
                            AB = (Math.Sqrt(((Ax - Bx) * (Ax - Bx)) + ((Ay - By) * (Ay - By))));
                            AC = (Math.Sqrt(((Ax - Cx) * (Ax - Cx)) + ((Ay - Cy) * (Ay - Cy))));
                            BC = (Math.Sqrt(((Cx - Bx) * (Cx - Bx)) + ((Cy - By) * (Cy - By))));

                            //The perimeter of the ship
                            perimeter = AB + AC + BC;

                            //The area of the ship
                            u = perimeter / 2;
                            area = Math.Sqrt(u * (u - AB) * (u - AC) * (u - BC));

                            //The angles of the ship
                            CosA = (Math.Acos((AC * AC + AB * AB - BC * BC) / (2 * AC * AB)));
                            AngleA = (CosA * 180) / Math.PI;
                            CosB = (Math.Acos((BC * BC + AB * AB - AC * AC) / (2 * BC * AB)));
                            AngleB = (CosB * 180) / Math.PI;
                            CosC = (Math.Acos((AC * AC + BC * BC - AB * AB) / (2 * BC * AC)));
                            AngleC = (CosC * 180) / Math.PI;

                            //The median points
                            Axmedian = (Bx + Cx) / 2;
                            Aymedian = (By + Cy) / 2;
                            Bxmedian = (Ax + Cx) / 2;
                            Bymedian = (Ay + Cy) / 2;
                            Cxmedian = (Ax + Bx) / 2;
                            Cymedian = (Ay + By) / 2;

                            //The centroid of the ship
                            Xcentroid = (Ax + Bx + Cx) / 3;
                            Ycentroid = (Ay + By + Cy) / 3;

                            //Bisector length
                            x = (BC * AB) / (AC + AB);
                            bisector = (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(AB, 2) - (2 * x * AB * Math.Cos(CosB))));

                            //The area of the inscribed circle
                            in_circle_r = area / u;
                            in_circle_area = Math.PI * (Math.Pow(in_circle_r, 2)); //pi.r2

                            //The area of circumscribed circle
                            circle_R = (AB * BC * AC) / (4 * area);
                            circum_circle_area = Math.PI * (Math.Pow(circle_R, 2));


                            if (AngleA == 0 || AngleB == 0 || AngleC == 0) //triangle control
                            {
                                Console.WriteLine("\nWarning! It could not be created because the triangle has an angle of 0.\nPlease press any key to go to the menu");
                                Console.ReadKey();
                                choice = 0;
                                Ax = 0; Bx = 0; Cx = 0; Ay = 0; By = 0; Cy = 0; //If a wrong triangle is entered, the values are reset so that it can be re-entered.
                            }
                            else if (area == 0)
                            {
                                Console.WriteLine("\nWarning! It could not be created because the triangle has an area of 0.\nPlease press any key to go to the menu");
                                Console.ReadKey();
                                choice = 0;
                                Ax = 0; Bx = 0; Cx = 0; Ay = 0; By = 0; Cy = 0; //If a wrong triangle is entered, the values are reset so that it can be re-entered.
                            }
                            else
                            {
                                Console.Clear();

                                for (int i = 0; i < 12; i++) //draws the coordinate system
                                {
                                    Console.SetCursorPosition(0, i);
                                    if (Ynumber >= 10)
                                    {
                                        Console.WriteLine(Ynumber + "|");
                                    }
                                    else if (Ynumber <= 9)
                                    {
                                        Console.WriteLine("0" + Ynumber + "|");
                                    }
                                    Ynumber -= 1;
                                }
                                Console.WriteLine("  +");
                                for (int j = 3; j < 33; j++)
                                {
                                    Console.SetCursorPosition(j, 12);
                                    Console.Write("-");
                                }
                                Console.Write("\n");
                                Console.Write("   ");
                                for (int k = 0; k < 3; k++)
                                {
                                    for (int Xnumber = 1; Xnumber < 10; Xnumber++)
                                    {
                                        Console.Write(Xnumber);
                                    }
                                    Console.Write("0");
                                }
                                Console.Write("\n");

                                Console.SetCursorPosition(Ax + 2, 12 - Ay);
                                Console.WriteLine("A");
                                Console.SetCursorPosition(Bx + 2, 12 - By);
                                Console.WriteLine("B");
                                Console.SetCursorPosition(Cx + 2, 12 - Cy);
                                Console.WriteLine("C");
                                Console.SetCursorPosition(0, 15); //puts the cursor down

                                Console.WriteLine("\n\t - MENU -\n1 – Enter ship location \n2 – Ship info \n3 – Shoot at the ship \n4 – Show high score table \n5 – Exit \n6 – Advantages of our game:");
                            }
                        }
                        break;


                    case 2: //ship info from menu

                        if (Ax == 0) //coordinate control
                        {
                            Console.WriteLine("You cannot get ship information without entering the location. Please return entering the location.");
                        }
                        else
                        {
                            Console.WriteLine($"The size of the ship: AB={AB:.00}, AC={AC:.00}, BC={BC:.00}");
                            Console.WriteLine($"The perimeter of the ship: {perimeter:.00}");
                            Console.WriteLine($"The area of the ship: {area:.00}");
                            Console.WriteLine($"The angles of the ship: A={AngleA:.00}, B={AngleB:.00}, C={AngleC:.00}");
                            Console.WriteLine($"The median points: ({Axmedian:.0} , {Aymedian:.0}) ({Bxmedian:.0} , {Bymedian:.0}) ({Cxmedian:.0} , {Cymedian:.0})");
                            Console.WriteLine($"The centroid of the ship: ({Xcentroid:.00} , {Ycentroid:.00})");
                            Console.WriteLine($"The bisector length: ({ bisector:.00})");
                            Console.WriteLine($"The area of the inscribed circle: ({in_circle_area:.00})");
                            Console.WriteLine($"The area of circumscribed circle: ({circum_circle_area:.00})");


                            //The type of the ship
                            if (AB == AC && AB == BC)
                            {
                                Console.WriteLine("The ship is Equilateral (Acute Angled)");
                            }
                            else if (AB == AC || AB == BC || BC == AC)
                            {
                                if (AngleA > 90 || AngleB > 90 || AngleC > 90)
                                {
                                    Console.WriteLine("The ship is Isosceles (Obtuse-angled)");
                                }
                                else if (AngleA == 90 || AngleB == 90 || AngleC == 90)
                                {
                                    Console.WriteLine("The ship is Isosceles (Right-angled)");
                                }
                                else if (AngleA < 90 && AngleB < 90 && AngleC < 90)
                                {
                                    Console.WriteLine("The ship is Isosceles (Acute-angled)");
                                }
                            }
                            else if (AB != AC && AB != BC && AC != BC)
                            {
                                if (AngleA > 90 || AngleB > 90 || AngleC > 90)
                                {
                                    Console.WriteLine("The ship is Scalene (Obtuse-angled)");
                                }
                                else if (AngleA == 90 || AngleB == 90 || AngleC == 90)
                                {
                                    Console.WriteLine("The ship is Scalene (Right-angled)");
                                }
                                else if (AngleA < 90 && AngleB < 90 && AngleC < 90)
                                {
                                    Console.WriteLine("The ship is Scalene (Acute-angled)");
                                }
                            }
                        }
                        break;



                    case 3: //shoot from menu

                        if (Ax == 0)//coordinate control
                        {
                            Console.WriteLine("You cannot shoot without entering the location. Please return entering the location.");
                        }
                        else
                        {
                            Random shootX = new Random();
                            Rx = shootX.Next(1, 31);
                            Random shootY = new Random();
                            Ry = shootY.Next(1, 13);
                            Console.WriteLine("\nShoot: (" + Rx + "," + Ry + ")");

                            //to reposition the cursor
                            tempX = Console.CursorLeft;
                            tempY = Console.CursorTop;

                            //the distance between the shot and the points
                            X_size_A = (Math.Sqrt((Math.Pow(Ax - Rx, 2)) + (Math.Pow(Ay - Ry, 2))));
                            X_size_B = (Math.Sqrt((Math.Pow(Bx - Rx, 2)) + (Math.Pow(By - Ry, 2))));
                            X_size_C = (Math.Sqrt((Math.Pow(Cx - Rx, 2)) + (Math.Pow(Cy - Ry, 2))));

                            XAB_perimeter = (AB + X_size_A + X_size_B); //XAB triangle area
                            X_u = XAB_perimeter / 2;
                            XAB_area = (Math.Sqrt(X_u * (X_u - AB) * (X_u - X_size_A) * (X_u - X_size_B)));

                            XAC_perimeter = (AC + X_size_A + X_size_C); //XAB triangle area
                            X_u = XAC_perimeter / 2;
                            XAC_area = (Math.Sqrt(X_u * (X_u - AC) * (X_u - X_size_A) * (X_u - X_size_C)));

                            XBC_perimeter = (BC + X_size_B + X_size_C); //XAB triangle area
                            X_u = XBC_perimeter / 2;
                            XBC_area = (Math.Sqrt(X_u * (X_u - BC) * (X_u - X_size_B) * (X_u - X_size_C)));

                            X_area = XAB_area + XAC_area + XBC_area; //total area of 3 triangles

                            //converts to integers to avoid errors
                            X_area_round = Math.Round(X_area, 2);
                            area_round = Math.Round(area, 2);

                            //check if the ship sank
                            if (X_area_round <= area_round)
                            {
                                Console.SetCursorPosition(Rx + 2, 12 - Ry);
                                Console.WriteLine("X", Console.ForegroundColor = ConsoleColor.Red);
                                Console.ForegroundColor = ConsoleColor.White; //to restore the color
                                Console.SetCursorPosition(tempX, tempY); //to reposition the cursor
                                Console.WriteLine("\nYour ship sank! Total score is 0\nYou lost! GAME OVER!!");
                                player_score = 0;
                                choice = 5;
                            }
                            else if (X_area > area)
                            {
                                Console.SetCursorPosition(Rx + 2, 12 - Ry);
                                Console.WriteLine("X", Console.ForegroundColor = ConsoleColor.Green);
                                Console.ForegroundColor = ConsoleColor.White; //to restore the color
                                Console.SetCursorPosition(tempX, tempY); //to reposition the cursor
                                temp_score = area;
                                Console.Write("\nYour ship survived! Your score is " + temp_score + "\nEnter your name: ");
                                player_name = Console.ReadLine();
                                while (player_name.Length > 40)
                                {
                                    Console.Write("Please enter a name of less than 40 characters\nEnter your name: ");
                                    player_name = Console.ReadLine();
                                }
                                player_score = player_score + temp_score;
                                Console.WriteLine("\nName: " + player_name + "\nScore: " + temp_score + "\tYour total score: " + player_score);

                            }
                        }
                        break;



                    case 4: //high score table

                        if (Rx == 0) //can't look at the scoreboard if no shot has been taken
                        {
                            Console.WriteLine("You haven't shot yet, please shoot first.");
                        }
                        else
                        {
                            Console.WriteLine("\nHIGH SCORE TABLE\nName\t\t\t\t\tScore");
                            tempX = Console.CursorLeft + 40; //for display scores regularly
                            tempY = Console.CursorTop;       //for display scores regularly
                            if (player_score == 0)
                            {
                                Console.WriteLine("{0}\t\t\t\t{1}\n{2}\t\t\t\t{3}\n{4}\t\t\t\t{5}", nazan_name, nazan_score, elif_name, elif_score, sibel_name, sibel_score);
                            }
                            else if (player_score > nazan_score)
                            {
                                Console.Write(player_name);
                                Console.SetCursorPosition(tempX, tempY); //for display scores regularly
                                Console.WriteLine("{0}\n{1}\t\t\t\t{2}\n{3}\t\t\t\t{4}", player_score, nazan_name, nazan_score, elif_name, elif_score);
                            }
                            else if (player_score > elif_score && player_score <= nazan_score)
                            {
                                Console.WriteLine("{0}\t\t\t\t{1}\n{2}", nazan_name, nazan_score, player_name);
                                Console.SetCursorPosition(tempX, tempY + 1); //for display scores regularly
                                Console.WriteLine("{0}\n{1}\t\t\t\t{2}", player_score, elif_name, elif_score);
                            }
                            else if (player_score <= elif_score)
                            {
                                Console.WriteLine("{0}\t\t\t\t{1}\n{2}\t\t\t\t{3}\n{4}", nazan_name, nazan_score, elif_name, elif_score, player_name, player_score);
                                Console.SetCursorPosition(tempX, tempY + 2); //for display scores regularly
                                Console.WriteLine(player_score);
                            }
                        }
                        break;


                    case 5: //exit

                        Console.WriteLine("Please press any key to exit");
                        Console.ReadKey();
                        //Environment.Exit(0);
                        break;

                    case 6:
                        Console.WriteLine("Advantages of our game:");
                        Console.WriteLine("1- Locations cannot be entered except between 1-30 on the x-axis and 1-12 on the y-axis.");
                        Console.WriteLine("2- We direct the user to enter the coordinates incorrectly, never enter the wrong triangle.");
                        Console.WriteLine("3- If it happens, the wrong triangle input that we missed while entering the coordinates," +
                            "\nis definitely caught in the codes below and cannot continue the game.");
                        Console.WriteLine("4- If you don't enter location, you can't get ship info, you can't shoot, you can't see high score");
                        Console.WriteLine("5- You can only enter a location once.");
                        Console.WriteLine("6- If you shoot more than 1, your points will be collected, but you are taking a risk with this." +
                            "\nIf your ship is hit, all points will be reset.");
                        Console.WriteLine("7- If the ship is hit, the firing point will appear red, if not, green.");
                        Console.WriteLine("8- Regardless of the long or short name, the high score looks neat and aesthetically pleasing.");
                        Console.WriteLine("9- Entering names on high score is limited to 40 characters");
                        Console.WriteLine("10- You can see your advantages by clicking 6 in the menu.");
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
