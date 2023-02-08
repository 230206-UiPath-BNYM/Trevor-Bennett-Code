Imports System

Module Program
    Sub Main(args As String())
        gameLoop("flamingo")
        
    End Sub

    Sub gameLoop(word as String)
    ' while loop that keeps the game going until win or loss condition
        dim mistakes as Integer = 6
        dim mysWord as String = word
        dim unfoundLetters as String = mysWord
        dim guesses as String = ""
        dim p = placeholders(mysWord)
        Console.WriteLine(p)
        Console.WriteLine("Enter a letter to guess: ")
        while mistakes > 0 and unfoundLetters.Length > 0
            dim curGuess as string = Console.ReadLine()
            if checkWord(mysWord, curGuess) Then
                unfoundLetters = unfoundLetters.Replace(curGuess, "")
                guesses += curGuess
            else
                mistakes -= 1
                Console.WriteLine(Chr(13) & "Bad guess. You have " & mistakes & " mistakes left.")
            end if
            for each l in mysWord
                if guesses.Contains(l) Then
                    Console.Write(l)
                else
                    Console.Write("_")
                end if
            Next
        end while
        if mistakes < 1 Then
            Console.WriteLine(Chr(13) & "You guessed wrong too many times. You lost!")
        else
            Console.WriteLine(Chr(13) & "Congratulations, you filled in the word!")
        end if
        
    End Sub

    Function checkWord(word as String, guess as String) as Boolean
        if word.contains(guess) Then
            return true
        else
            return false
        end if
    end Function

    Function placeholders(word as String) as String
        dim thisStr as String = ""
        for each letter in word
            thisStr = thisStr & "_"
        Next
        return thisStr
    end Function

End Module
