using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FlowControlHomework
{
    [TestClass]
    public class FlowControlHomework
    {
        [TestMethod]
        public void IfFundementals() // THE GOAL IS TO CHANGE THE FLOW TO REACH ALL THE PASSING STATEMENTS AND TO FIX COMPILATION ISSUES
        {
            bool changeFlow = true; // assign me so I can reach the assert true in my flow of execution
            if (changeFlow)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

            bool changeFlow2 = true; // assign me so I can reach the assert true in my flow of execution
            if (changeFlow2)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

            bool changeFlow3 = false; // assign me so I can reach line 38 in my flow of execution
            if (changeFlow3)
            {
                //  Change the flow with the same variable (reassign the variable so I can reach line 38);

                if (changeFlow3 == false)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            else
            {
                Assert.IsTrue(false);
            }

            bool changeFlow4 = false; // assign me so I can reach the assert true in my flow of execution
            bool nextChangeFlow = true; // assign me so I can reach the assert true in my flow of execution
            if (changeFlow4)
            {
                Assert.IsTrue(false);
            }
            else if (nextChangeFlow)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

            bool changeFlow5 = false; // assign me so I can reach the assert true in my flow of execution
            bool nextChangeFlow2 = false; // assign me so I can reach the assert true in my flow of execution
            if (changeFlow5)
            {
                Assert.IsTrue(false);
            }
            else if (nextChangeFlow2)
            {
                Assert.IsTrue(false);
            }
            else
            {
                Assert.IsTrue(true);
            }

            
        
                      
           }
        }


        //[TestMethod]
        //public void IfWithOperators()
        //{
        //    //This section is testing that you know what these operators do, provide operands to reach the pass statements.
        //    //     you can do this in may ways as long as you prove operands in the appropriate place.
        //    int myNum = 8;
        //    int yourNum = 6;
        //    int sumNum = 8;
        //    bool withOp = true;
        //    bool withOp2 = false;


        //    if (myNum == yourNum)
        //    {
        //        Console.WriteLine(true);
        //        Assert.IsTrue(true);
        //    }
        //    else
        //    {
        //        Console.WriteLine(false);
        //        Assert.IsTrue(false);
        //    }

        //    if (myNum != sumNum)
        //    {
        //        Console.WriteLine(true);
        //        Assert.IsTrue(true);
        //    }
        //    else
        //    {
        //        Console.WriteLine(false);
        //        Assert.IsTrue(false);
        //    }

        //    if ( myNum < sumNum )
        //    {
        //        Console.WriteLine(true);
        //        Assert.IsTrue(true);
        //    }
        //    else
        //    {
        //        Console.WriteLine(false);
        //        Assert.IsTrue(false);
        //    }

        //    if ( sumNum > myNum)
        //    {
        //        Console.WriteLine(true);
        //        Assert.IsTrue(true);
        //    }
        //    else
        //    {
        //        Console.WriteLine(false);
        //        Assert.IsTrue(false);
        //    }

        //    if (myNum <= yourNum)
        //    {
        //        Console.WriteLine(true);
        //        Assert.IsTrue(true);
        //    }
        //    else
        //    {
        //        Console.WriteLine(false);
        //        Assert.IsTrue(false);
        //    }

        //    if (sumNum >= myNum + yourNum)
        //    {
        //        Console.WriteLine(true);
        //        Assert.IsTrue(true);
        //    }
        //    else
        //    {
        //        Console.WriteLine(false);
        //        Assert.IsTrue(false);
        //    }

        //    if (!withOp)
        //    {
        //        Console.WriteLine(true);
        //        Assert.IsTrue(true);
        //    }
        //    else
        //    {
        //        Console.WriteLine(false);
        //        Assert.IsTrue(false);
        //    }

        //    if (!!withOp2)
        //    {
        //        Console.WriteLine(true);
        //        Assert.IsTrue(true);
        //    }
        //    else
        //    {
        //        Console.WriteLine(false);
        //        Assert.IsTrue(false);
        //    }

        //    if ((myNum == yourNum) && (sumNum == myNum + yourNum))
        //    {
        //        Console.WriteLine(true);
        //        Assert.IsTrue(true);
        //    }
        //    else
        //    {
        //        Console.WriteLine(false);
        //        Assert.IsTrue(false);
        //    }

        //    if ((yourNum == sumNum) || ( myNum == yourNum))
        //    {
        //        Console.WriteLine(true);
        //        Assert.IsTrue(true);
        //    }
        //    else
        //    {
        //        Console.WriteLine(false);
        //        Assert.IsTrue(false);
        //    }  
            
        //    int inRange = 27; // Set this value to pass BOTH the range checks, do not reassign it.
        //    if (inRange > 5 && inRange < 10)
        //    {
        //        if (inRange > 5 && inRange < 7)
        //        {
        //            Console.Write(true);
        //            Assert.IsTrue(true);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(false);
        //        Assert.IsTrue(false);
        //    }
        //}

        //[TestMethod]
        //public void Switch()
        //{
        //    int number = 1;  //Assign me so I cause the next switch to pass.
        //    switch (number)
        //    {
        //        case 1:
        //            Console.WriteLine(1);
        //            Assert.IsTrue(false);
        //            break;
        //        case 2:
        //            Console.WriteLine(2);
        //            Assert.IsTrue(false);
        //            break;
        //        case 3:
        //            Console.WriteLine(3);
        //            Assert.IsTrue(false);
        //            break;
        //        case 4:
        //            Console.WriteLine(4);
        //            Assert.IsTrue(false);
        //            break;
        //        case 5:
        //            Console.WriteLine(5);
        //            Assert.IsTrue(false);
        //            break;
        //        case 6:
        //            Console.WriteLine(6);
        //            Assert.IsTrue(false);
        //            break;
        //        case 7:
        //            Console.WriteLine(7);
        //            Assert.IsTrue(true);
        //            break;
        //        default:
        //            Assert.IsTrue(false);
        //            break;
        //    }
            
            
            
        //    number = 16; //Assign me so I cause the next switch to pass.
        //    switch (number)
        //    {
        //        case 15:
        //            Console.WriteLine(false);
        //            Assert.IsTrue(false);
        //            break;
        //        case 26:
        //            Console.WriteLine(true);
        //            Assert.IsTrue(true);
        //            break;
        //        default:
        //            Console.WriteLine(false);
        //            Assert.IsTrue(false);
        //            break;
        //    }
            
            
            
        //    number = 26; //Assign me so I cause the next switch to pass.
        //    switch (number)
        //    {
        //        case 15:
        //            Console.WriteLine(false);
        //            Assert.IsTrue(false);
        //            break;
        //        case 26:
        //            Console.WriteLine(false);
        //            Assert.IsTrue(false);
        //            break;
        //        default:
        //            Console.WriteLine(true);
        //            Assert.IsTrue(true);
        //            break;
        //    }
            
            
            
        //    // These have compilation issues, not logic errors. Uncomment and fix them.
        //    /*
        //    string usersChoice = "a";
        //    switch (usersChoice) // Fix me so I compile
        //    {
        //        case "a" ;
        //            Assert.IsTrue(true);
        //            break;
        //        case "b" ;
        //            Assert.IsTrue(false);
        //            break;
        //        case "c" ;
        //            Assert.IsTrue(true);
        //            break;
        //            default;
        //            Assert.IsTrue(false);
        //            break;
        //    }

        //    switch (usersChoice) // Fix me so I compile
        //    {
        //        case "a":
        //            Assert.IsTrue(true);
        //        case "b":
        //            Assert.IsTrue(false);
        //        case "c":
        //            Assert.IsTrue(false);
        //        default:
        //            Assert.IsTrue(false);
        //    }
            
        //    switch (usersChoice) // Fix me so I compile
        //    { 
        //        "a":
        //            Assert.IsTrue(true);
        //            break;
        //        "b":
        //            Assert.IsTrue(false);
        //            break;
        //        "c":
        //            Assert.IsTrue(true);
        //            break;
        //        default:
        //            Assert.IsTrue(false);
        //            break;
        //    }
        //    */
        //}


        //[TestMethod]
        //public void Loops()
        //{
        //    int max = 12; // set me correctly so i reach the line that sets passed.
        //    bool passed = false;
        //    for (int i = 0; i <= max; i++)
        //    {
        //        Console.WriteLine(true);
        //        // DONT BE ALARMED, you dont need brackets if its only a single statement you want to execute. Im just exposing you to this because programmers do it.
        //        // But this is not a good practice, especially for a beginner.
        //        if (i == 15) passed = true;
        //    }
        //    Assert.IsTrue(passed);
            
            
            
        //   int max2 = 17;
        //    // You need to do something special to get to the line that sets passed = true.
        //    // Some restrictions:
        //    // Don't change anything with the passed variable.
        //    // Dont change anything in the block, only change the for statement.
        //    // Don't change the initialization (int i = 0) in the for statement.
        //    // hint: you don't always need to increment by 1.
        //    // This one is tough, take your time.
        //    passed = false;
        //    for (int i = 0; i <= max2; i++)   // Change this line (but not the 'int i = 0' part)
        //    {
        //        bool isOdd = !((i % 2) == 0); // notice how the variable name explains the expression? 
        //        if (isOdd)
        //        {
        //            // if you reach here test will fail. 
        //            Console.WriteLine(true);
        //            Assert.IsTrue(false);
        //        }

        //        if (i == 16) passed = true; // This statement has to run for the test to pass.
        //    }
        //    Assert.IsTrue(passed);  // Don't change this line.

        //    // break out of the loop after the test passes at least once, there are a couple ways do to this
        //    int counter = 0;  // Change me to get in.
        //    int passedCounter = 0;  // Don't change me.
        //    while (counter > 1 && counter < 10)
        //    {
        //        passedCounter++;
        //        Console.WriteLine(true);
        //        Assert.IsTrue(true);
        //        Console.WriteLine("IM STUCK IN HERE");
        //        if (counter == 10)
        //        {
        //            break;
        //        }
        //    }
        //    Assert.IsTrue(passedCounter >= 1);  // Don't change this line.
            
            
        //    // Fix this loop so the passed = true line executes at least once AND the test doesn't go on forever.
        //    passed = false;
        //    int count = 0;
        //    do
        //    {
        //        if (count > 0)
        //        {
        //            Console.WriteLine(true);
        //            passed = true;
        //        }
                
        //    } while ( count < 10);
        //    Assert.IsTrue(passed);
            
        //}
    //}
}
