Module Module1
    Dim landscapeSizeY As Integer 'Theese variables are used to store the size of the grid.
    Dim landscapeSizeX As Integer

    Dim colour01 As Integer 'Theese varibles are used to store a reference number for the colours. 
    Dim colour02 As Integer
    Dim colour03 As Integer

    Dim colourChoose As Integer
    Sub Main()
        Dim continueGeneration As Boolean = True
        While continueGeneration = True
            procedurealGenerationNumbers()
            displayTerrian()
            System.Threading.Thread.Sleep(100)
            Console.Write("#")
            System.Threading.Thread.Sleep(100)
            Console.Write("#")
            System.Threading.Thread.Sleep(100)
            Console.Write("#")
            System.Threading.Thread.Sleep(100)
            Console.Write("#")
            System.Threading.Thread.Sleep(100)
            Console.Write("#")
            Console.WriteLine()
            Console.WriteLine("_________________________________________________________")
        End While
        Console.ReadLine()
    End Sub
    Sub procedurealGenerationNumbers()
        'Generate the lanscape size
        'Generate the colour pallete

        Dim randomNumber As New Random()

        landscapeSizeY = randomNumber.Next(0, 10) 'This generates a number to be used for get the size of the grid. 
        landscapeSizeX = randomNumber.Next(0, 10)

        colour01 = randomNumber.Next(0, 6) 'This genereates a number to reference a colour for the colour pallete. 
        colour02 = randomNumber.Next(0, 6)
        colour03 = randomNumber.Next(0, 6)

        If colour01 = colour02 Or colour01 = colour03 Then
            colour01 = randomNumber.Next(0, 6)
        ElseIf colour02 = colour01 Or colour02 = colour03 Then
            colour02 = randomNumber.Next(0, 6)
        ElseIf colour03 = colour01 Or colour03 = colour02 Then
            colour03 = randomNumber.Next(0, 6)
        End If
    End Sub
    Sub displayTerrian()
        Dim randomNumber As New Random()
        Dim colourChoice As Integer
        For y = 0 To landscapeSizeY
            For x = 0 To landscapeSizeX
                colourChoice = randomNumber.Next(0, 3)
                If colourChoice = 1 Then
                    If colour01 = 1 Then
                        Console.ForegroundColor = ConsoleColor.Blue
                    ElseIf colour01 = 2 Then
                        Console.ForegroundColor = ConsoleColor.Green
                    ElseIf colour01 = 3 Then
                        Console.ForegroundColor = ConsoleColor.Red
                    ElseIf colour01 = 4 Then
                        Console.ForegroundColor = ConsoleColor.Yellow
                    ElseIf colour01 = 5 Then
                        Console.ForegroundColor = ConsoleColor.White
                    ElseIf colour01 = 6 Then
                        Console.ForegroundColor = ConsoleColor.Magenta
                    End If
                ElseIf colourChoice = 2 Then
                    If colour02 = 1 Then
                        Console.ForegroundColor = ConsoleColor.Blue
                    ElseIf colour02 = 2 Then
                        Console.ForegroundColor = ConsoleColor.Green
                    ElseIf colour02 = 3 Then
                        Console.ForegroundColor = ConsoleColor.Red
                    ElseIf colour02 = 4 Then
                        Console.ForegroundColor = ConsoleColor.Yellow
                    ElseIf colour02 = 5 Then
                        Console.ForegroundColor = ConsoleColor.White
                    ElseIf colour02 = 6 Then
                        Console.ForegroundColor = ConsoleColor.Magenta
                    End If
                ElseIf colourChoice = 3 Then
                    If colour03 = 1 Then
                        Console.ForegroundColor = ConsoleColor.Blue
                    ElseIf colour03 = 2 Then
                        Console.ForegroundColor = ConsoleColor.Green
                    ElseIf colour03 = 3 Then
                        Console.ForegroundColor = ConsoleColor.Red
                    ElseIf colour03 = 4 Then
                        Console.ForegroundColor = ConsoleColor.Yellow
                    ElseIf colour03 = 5 Then
                        Console.ForegroundColor = ConsoleColor.White
                    ElseIf colour03 = 6 Then
                        Console.ForegroundColor = ConsoleColor.Magenta
                    End If
                End If
                Console.Write("[ ]")
                System.Threading.Thread.Sleep(1)
            Next
            Console.WriteLine()
        Next
    End Sub
End Module
