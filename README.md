## C#-Development
- Here are basically five basic commands used in console applications.
    1. **Write and WriteLine** - So when these codes are executed, we cannot see the cursors true place, because when we press any key display, it will close.
        
        ```csharp
        // Write
        Console.Write(”Hello”);
        Console.Write(”What is your name”);
        
        // WriteLine
        Console.WriteLine(”Hello”); 
        Console.WriteLine(”What is your name”);
        ```
        
    2. **ReadKey -** So we can use the read key command to see the next character. If you use the read key command, you can press one key before the display is closed. And when we use his command, we can see where where the cursor is.
        
        ```csharp
        Console.WriteLine("hello");
        Console.WriteLine("what is your name");
        Console.ReadKey();
        ```
        
    3. **Read & ReadLine-** So here the read and read lied commands are used to retrieve the data that the user will write on the screen.
        
        ```csharp
        // ReadLine Data Type
        Console.WriteLine("What is your Name");
        string name = Console.Readline();
        Console.WriteLine(name + "welcome to our lesson");
        Console.ReadKey();
        
        // Read Data Type
        Console.WriteLine("What is your name");
        int asciiCode = Console.Read();
        Console.WriteLine(asciiCode);
        Console.ReadKey();
        ```
