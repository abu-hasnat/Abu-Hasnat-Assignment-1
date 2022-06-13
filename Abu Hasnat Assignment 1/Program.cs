
//int changes = 0;

//Console.WriteLine("Please enter the amount of money you want to enter");
//int customerMoney = int.Parse(Console.ReadLine());
//Console.WriteLine(customerMoney);

//Console.WriteLine("Please enter the value of your item");
//int itemValue = int.Parse(Console.ReadLine());
//Console.WriteLine(itemValue);



//Dictionary<int, int> vendingMachine(Dictionary<int, int> money)  // accpets money given by the customer and the price of the product
//{
//    money.Add(customerMoney, itemValue);


//    foreach (KeyValuePair<int, int> kvp in money)  // calculate the change
//    {
//        if (kvp.Key > kvp.Value)
//        {
//            Console.WriteLine("you donot have sufficient funds");
//        }
//        else if (kvp.Key == kvp.Value)
//        {
//            Console.WriteLine("Thank you for your purchase");
//        }
//        else if (kvp.Value < kvp.Key)
//        {
//            changes = kvp.Key - kvp.Value;
//        }
//    }
//    Dictionary<int, int> myChanges = new Dictionary<int, int>();




//    if (changes >= 100)  // calculates of the amount of money to be returned
//    {
//        int newChanges = changes - 100;
//        changes = newChanges;
//        myChanges.Add(100, 1);
//        if (changes >= 50)
//        {
//            newChanges = changes - 50;
//            changes = newChanges;
//            myChanges.Add(50, 1);
//            if (changes >= 20)
//            {
//                newChanges = changes - 20;
//                changes = newChanges;
//                myChanges.Add(20, 1);
//                if (changes >= 10)
//                {
//                    newChanges = changes - 10;
//                    changes = newChanges;
//                    myChanges.Add(10, 1);
//                    if (changes >= 10)
//                    {
//                        newChanges = changes - 10;
//                        changes = newChanges;
//                        myChanges.Add(10, 1);
//                        if (changes >= 5)
//                        {
//                            newChanges = changes - 5;
//                            changes = newChanges;
//                            myChanges.Add(5, 1);
//                            if (changes >= 2)
//                            {
//                                newChanges = changes - 2;
//                                changes = newChanges;
//                                myChanges.Add(2, 1);
//                                if (changes >= 1)
//                                {
//                                    newChanges = changes - 1;
//                                    changes = newChanges;
//                                    myChanges.Add(1, 1);
//                                }
//                            }
//                        }
//                    }
//                }
//            }
//        }
//    }


//    return myChanges;
//}

//incomplete

//No 2A


Console.WriteLine("Please enter your word");

String myString = Console.ReadLine().ToUpper();
String words = myFunction();

String myFunction()
{
   
    char[] chars = myString.ToCharArray();
    String finalString = String.Empty;
    int repetition = 1;
    int i = 0;
    while( i+1 < chars.Length)
    {
        if (chars[i] == chars[i + 1])
        {
            repetition++;
            i++;

            if(repetition == 2)
            {
                finalString += chars[i].ToString();
            }
        }
        else
        {
            if(repetition > 2)
            {
                finalString += repetition.ToString();
            }
            else
            {
                finalString += chars[i].ToString();
            }
            repetition = 1;
            i++;
        }
        
    }

    if(repetition <= 2)
    {
        finalString += chars[chars.Length-1].ToString();
    }
    else
    {
        finalString += repetition.ToString();
    }
    Console.WriteLine(finalString);
    return finalString;

}

Console.WriteLine(words);

//No 2B  (Uno reverse 2A)

String reverseFunction()
{
    String newString = String.Empty;
    int i = 0;

    while (i < myString.Length)
    {
        char c = myString[i];

        if (Char.IsDigit(c))
        {
            int repeatNum = (int)Char.GetNumericValue(c);
            char prevChar = myString[i - 1];
            int j = 0;

            while (j < repeatNum - 1)
            {
                newString += prevChar.ToString();
                j++;
            }
        }

        else
        {
            newString += c.ToString();
        }
        i++;
    }

    return newString;
}