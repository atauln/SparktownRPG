Module Module1

    Sub Main()
        Console.ForegroundColor = ConsoleColor.DarkYellow
        Console.WriteLine("Welcome to SPARKTOWN RPG!")
        Console.WriteLine("What is your name?")
        Dim UserName = Console.ReadLine()
        Console.WriteLine("Welcome, " + UserName)
        Wait(1.5)
        Console.WriteLine("Let me tell you the story of the kingdom of SPARKLAND")
        Wait(1.5)
    End Sub

    Sub Wait(time)
        Threading.Thread.Sleep(time * 1000)
    End Sub
End Module
