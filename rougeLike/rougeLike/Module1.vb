Module Module1
    Dim landscapeSizeY As Integer 'Theese variables are used to store the size of the grid.
    Dim landscapeSizeX As Integer
    Dim gridArray(5, 5) As Integer

    Dim colour01 As Integer 'Theese varibles are used to store a reference number for the colours. 
    Dim colour02 As Integer
    Dim colour03 As Integer
    Dim colour04 As Integer
    Dim colour05 As Integer

    Dim colourChoose As Integer
    Sub Main()
        Dim userInput As Integer
        Console.WriteLine("Do you want to see different variations or just one?")
        Console.WriteLine("1 = just one | 2 = terrian loop")
        userInput = Console.ReadLine()

        If userInput = 2 Then
            terrianLoop()
        End If

        procedurealGenerationNumbers()
        displayTerrian()

        Console.ReadLine()
    End Sub
    Sub procedurealGenerationNumbers()
        'Generate the lanscape size.
        'Generate the colour pallete.

        Dim randomNumber As New Random()

        landscapeSizeY = randomNumber.Next(0, 20) 'This generates a number to be used for get the size of the grid. 
        landscapeSizeX = randomNumber.Next(0, 20)
        ReDim gridArray(landscapeSizeY, landscapeSizeX)

        colour01 = randomNumber.Next(0, 6) 'This genereates a number to reference a colour for the colour pallete. 
        colour02 = randomNumber.Next(0, 6)
        colour03 = randomNumber.Next(0, 6)
        colour04 = randomNumber.Next(0, 6)
        colour05 = randomNumber.Next(0, 6)

        If colour01 = colour02 Or colour01 = colour03 Then 'Just making sure no two variables are the same. 
            colour01 = randomNumber.Next(0, 6)
        ElseIf colour02 = colour01 Or colour02 = colour03 Then
            colour02 = randomNumber.Next(0, 6)
        ElseIf colour03 = colour01 Or colour03 = colour02 Then
            colour03 = randomNumber.Next(0, 6)
        End If
    End Sub
    Sub terrianLoop() 'Just a way to see all of the different kind of grids we can get.
        Dim continueGeneration As Boolean = True
        While continueGeneration = True 'This loop is just to test to see the different variations I can get for the grid. 
            procedurealGenerationNumbers()
            displayTerrian()
            'The code below is just used as a timer until the next grid is generated and is used as a seperator for the grids. 
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
    End Sub
    Sub displayTerrian()
        Dim randomNumber As New Random()
        Dim colourChoice As Integer

        For y = 0 To landscapeSizeY
            For x = 0 To landscapeSizeX
                colourChoice = randomNumber.Next(0, 5) 'This allows the program to pick different colours of the three colours we have created. 
                gridArray(y, x) = colourChoice
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
                ElseIf colourChoice = 4 Then
                    If colour04 = 1 Then
                        Console.ForegroundColor = ConsoleColor.Blue
                    ElseIf colour04 = 2 Then
                        Console.ForegroundColor = ConsoleColor.Green
                    ElseIf colour04 = 3 Then
                        Console.ForegroundColor = ConsoleColor.Red
                    ElseIf colour04 = 4 Then
                        Console.ForegroundColor = ConsoleColor.Yellow
                    ElseIf colour04 = 5 Then
                        Console.ForegroundColor = ConsoleColor.White
                    ElseIf colour04 = 6 Then
                        Console.ForegroundColor = ConsoleColor.Magenta
                    End If
                ElseIf colourChoice = 5 Then
                    If colour05 = 1 Then
                        Console.ForegroundColor = ConsoleColor.Blue
                    ElseIf colour05 = 2 Then
                        Console.ForegroundColor = ConsoleColor.Green
                    ElseIf colour05 = 3 Then
                        Console.ForegroundColor = ConsoleColor.Red
                    ElseIf colour05 = 4 Then
                        Console.ForegroundColor = ConsoleColor.Yellow
                    ElseIf colour05 = 5 Then
                        Console.ForegroundColor = ConsoleColor.White
                    ElseIf colour05 = 6 Then
                        Console.ForegroundColor = ConsoleColor.Magenta
                    End If
                End If
                Console.Write("[ ]")
                System.Threading.Thread.Sleep(1)
            Next
            Console.WriteLine() 'This allows the grid to go onto the next line to prevent the grid from being all on one line. 
        Next
        displayNumberArray()
    End Sub
    Sub displayNumberArray()
        For y = 0 To landscapeSizeY
            For x = 0 To landscapeSizeX
                Console.ForegroundColor = ConsoleColor.DarkGray
                Console.Write("[" & gridArray(y, x) & "]")
            Next
            Console.WriteLine()
        Next
    End Sub
End Module