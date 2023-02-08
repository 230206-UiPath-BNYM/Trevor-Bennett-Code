Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hellow Orld!")
        dim greeting as String = "hey"

        guessingGame(1)
        guessingGame(2)

        GuessingGame_v2()
    End Sub

    Sub guessingGame(guess as Integer)
        dim rnd as Random = new Random()
        dim mysteryNum as Integer = rnd.Next(1,2)
        if guess <> mysteryNum Then
            Console.WriteLine("Wrong guess :(")
        else
            Console.WriteLine("Correct!")
        end if
    End Sub

    Sub Counter(stopping_pt as Integer)
        dim start as Integer = 0
        while start < stopping_pt
            Console.WriteLine(start)
            start += 1
        end while

        for index as Integer = 0 to stopping_pt
            console.WriteLine(index)
        Next
    end Sub

    Sub GuessingGame_v2()
        dim rnd_int as Random = new Random()
        dim mysteryNum as Integer = rnd_int.Next(1,100)
        Console.WriteLine("Enter guess: ")
        dim guess as String = Console.ReadLine()
        dim guessNum as Integer = Integer.Parse(guess)
        while guessNum <> mysteryNum
            if guessNum < mysteryNum Then
                Console.WriteLine("You guessed low")
            else
                Console.WriteLine("You guessed high")
            End if
            Console.WriteLine("Guess again! .. ")
            guessNum = Integer.Parse(Console.ReadLine())
        end while
        Console.WriteLine("Congrats! You guessed right!")
    end Sub
End Module
