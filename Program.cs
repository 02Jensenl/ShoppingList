using System;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int selectedItem = 0;
            int selection = 0;
            int tempArrayIndex = 0;
            bool newSelection = false;
            string[] shoppingList = new string[10];
            shoppingList[0] = "Eggs";
            shoppingList[1] = "Bread";


            while (!newSelection)
            {
                Console.WriteLine("Shopping List");
                Console.Write("\n1. Add new Item" +
                    "\n2. Edit Item" +
                    "\n3. Remove Item" +
                    "\n4. View All Items" +
                    "\n5. Exit" +
                    "\n");
                selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    //add
                    case 1:
                        for (int i = 0; i < shoppingList.Length; i++)
                        {
                            if (shoppingList[i] == null)
                            {
                                Console.WriteLine("Add a new item");
                                shoppingList[i] = Console.ReadLine();
                                break;
                            }
                            Console.WriteLine();
                        }
                        break;

                    //edit
                    case 2:                      
                        Console.WriteLine("Which item would you like to change? Select item 1-10: ");
                        selectedItem = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please input a new item that will override the selected item");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{shoppingList[selectedItem - 1]}");
                        Console.ResetColor();
                        Console.Write(": ");

                        shoppingList[selectedItem - 1] = Console.ReadLine();
                        Console.WriteLine();
                        break;

                     //remove
                    case 3:
                        Console.Write("\nWhich item do you want to remove? Select item 1-10: ");
                        selectedItem = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{shoppingList[selectedItem - 1]} was removed");
                        shoppingList[selectedItem - 1] = null;

                        string[] tempArray = new string[shoppingList.Length];
                       

                        for (int i = 0; i < shoppingList.Length; i++)                       
                        {
                            if (shoppingList[i] != null)
                            {
                                tempArray[tempArrayIndex] = shoppingList[i];
                                tempArrayIndex++;
                            }
                        }

                        Array.Copy(tempArray, shoppingList, tempArray.Length);
                        Console.WriteLine();
                        break;

                        //view
                    case 4:
                        Console.WriteLine("Curent shopping list: ");
                        for (int i = 0; i < shoppingList.Length; i++)
                        {
                            if (shoppingList[i] != null)
                            {
                                Console.WriteLine($" {i + 1} {shoppingList[i]}");
                            }
                        }
                        Console.WriteLine();
                       
                        break;
                        //Exit
                    case 5:
                        newSelection = true;
                        break;

                    default:
                        Console.WriteLine("Error. Incorrect Selection");
                        break;
                }
            }


        }
    }
}
