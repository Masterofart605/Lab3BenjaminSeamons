string end = "";
 
 
 
 
//While Loop
while(true){
    end = "";
    int number = 0;
    while (true){
        try{
            Console.WriteLine("Please Input a Number Between 10 and 99");
            end=Console.ReadLine();
            if(end == "exit"){
                break;
            }
            number = Convert.ToInt32(end);
            if (number>=10 && number <=99){
                break;
            }else{
                Console.WriteLine("Im Sorry that number is eather too big or too small");
            }
        }catch{
            Console.WriteLine("Im Sorry Please Try Again");
        }
    }
    if(end == "exit"){
        Console.BackgroundColor=ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("Thank you so much for playing my game!");
        break;
    }
    if(number % 23 == 0){
        Console.BackgroundColor=ConsoleColor.Green;
        Console.Clear();
    }else{
        Console.BackgroundColor=ConsoleColor.Red;
        Console.Clear();
    }
}
 
 
end = "";
 
 
//Do While Loop
do{
int number = 0;
    while (true){
        try{
            Console.WriteLine("Please Input a Number Between 10 and 99");
            end=Console.ReadLine();
            if(end == "exit"){
                break;
            }
            number = Convert.ToInt32(end);
            if (number>=10 && number <=99){
                break;
            }else{
                Console.WriteLine("Im Sorry that number is eather too big or too small");
            }
        }catch{
            Console.WriteLine("I think this is not a number");
        }
    }
    if(number % 34 == 0){
        Console.BackgroundColor=ConsoleColor.Green;
        Console.Clear();
    }else{
        Console.BackgroundColor=ConsoleColor.Red;
        Console.Clear();
    }
 
    if(end == "exit"){
        Console.BackgroundColor=ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("Thank you so much for playing my game!");
    }
}while(end != "exit");
 
 
//For loop
 
for(int x = 1; x <= 5; x++){
int number = 0;
    while (true){
        try{
            Console.WriteLine("Please Input a Number Between 10 and 99");
            end=Console.ReadLine();
            if(end == "exit"){
                break;
            }
            number = Convert.ToInt32(end);
            if (number>=10 && number <=99){
                break;
            }else{
                Console.WriteLine("Im Sorry that number is eather too big or too small");
            }
        }catch{
            Console.WriteLine("I think this is not a number");
        }
    }
    if(number % 33 == 0){
        Console.BackgroundColor=ConsoleColor.Green;
        Console.Clear();
    }else{
        Console.BackgroundColor=ConsoleColor.Red;
        Console.Clear();
    }
 
    if(end == "exit" || x == 5){
        Console.BackgroundColor=ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("Thank you so much for playing my game!");
        break;
    }
}
 
 
int choise = 5;
while (choise != 0){
    int number1 = 0;
    int number2 = 0;
    int result;
    try{
        Console.WriteLine(" ");
        Console.WriteLine("Please choose, do you want to:");
        Console.WriteLine("1:Add");
        Console.WriteLine("2:Subtract");
        Console.WriteLine("3:Multiply");
        Console.WriteLine("4:Divide");
        Console.WriteLine("0:Exit");
        choise = Convert.ToInt32(Console.ReadLine());
        if(choise == 0){
            break;
        }
        Console.WriteLine("Thank you, now give me the first number");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Now give me the second number");
        number2 = Convert.ToInt32(Console.ReadLine());
 
    }catch{
        Console.WriteLine("Please press a number key");
    }
 
    switch(choise){
        case 1:
        result = number1 + number2;
        Console.WriteLine($"The Result is {result}");
        break;
        case 2:
        result = number1 - number2;
        Console.WriteLine($"The Result is {result}");
        break;
        case 3:
        result = number1 * number2;
        Console.WriteLine($"The Result is {result}");
        break;
        case 4:
        result = number1 / number2;
        Console.WriteLine($"The Result is {result}");
        break;
        case 0:
        choise = 0;
        break;
        default:
        break;
    }
}
