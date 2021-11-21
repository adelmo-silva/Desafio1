{
    Console.Write("Informe o primeiro valor: ");
    double n1 = double.Parse(Console.ReadLine());
    Console.Write("Informe uma operação: ");
    string op = Console.ReadLine();
    
    if (op != "+" )
    {
        if (op != "-")
        {
            if (op != "*")
            {
                if (op != "/")
                {
                    Console.WriteLine("Error!");
                    Console.WriteLine("Escolha uma das seguintes operações: + , - , * , / ");
                    op = Console.ReadLine();
                }
            }
        }
    }

    Console.Write("Informe o segundo valor: ");
    double n2 = double.Parse(Console.ReadLine());
    double result = 0;

    switch(op)
    {
        case "+": 
                    result = n1 + n2;
                    Console.Write("O resultado é " + result);                    
            break;

        case "-":
                    result = n1 - n2;
                    Console.Write("O resultado é " + result);
            break;

        case "*":
                    result = n1 * n2;
                    Console.Write("O resultado é " + result);
            break;
        
        case "/":
                    result = n1 / n2;
                    Console.Write("O resultado é " + result);
            break;

        default:
                    Console.Write("Error!");
            break;   
    }
}