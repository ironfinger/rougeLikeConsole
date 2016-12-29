Module Module1
    Dim gameActive As Boolean = True 'This decides whether the game should continue or whether it shall stop. 
    Dim firstLoop As Boolean = True 'This is used in order to create the players location once. 

    Dim landscapeSizeY As Integer 'Theese variables are used to store the size of the grid.
    Dim landscapeSizeX As Integer
    Dim gridArray(5, 5) As Integer
    Dim playerArray(5, 5) As Integer

    Dim colour01 As Integer 'Theese varibles are used to store a reference number for the colours.
    Dim colour02 As Integer
    Dim colour03 As Integer
    Dim colour04 As Integer
    Dim colour05 As Integer

    Dim colourChoose As Integer

    Dim enemyAmount As Integer
    Dim enemyLocationY As Integer
    Dim enemyLocationX As Integer
    Dim maxEnemyAmount As Integer = 5
    Sub Main()
        Dim userInput As Integer
        Console.WriteLine("Do you want to see different variations or just one?")
        Console.WriteLine("1 = just one | 2 = terrian loop")
        Try 'This just makes sure that the program doesn't crash. 
            userInput = Console.ReadLine() 'To try catch and make your program more stable.
        Catch ex As Exception
            userInput = 1 'I just made the program run the game as normal to make sure that the program doesn't crash.
        End Try

        If userInput = 1 Then
            procedurealGenerationNumbers()
            displayTerrian()
            Console.WriteLine("Press Enter when your ready.")
            Console.ReadLine()
            gameLoop()
        ElseIf userInput = 2 Then
            terrianLoop()
        End If
    End Sub
    Sub gameLoop()
        While gameActive = True
            Console.Clear()
            reDrawGrid()
            playerMovement()
        End While
        Console.ReadLine()
    End Sub
    Sub procedurealGenerationNumbers()
        'Generate the lanscape size.
        'Generate the colour pallete.

        Dim randomNumber As New Random()

        landscapeSizeY = randomNumber.Next(0, 20) 'This generates a number to be used for get the size of the grid. 
        landscapeSizeX = randomNumber.Next(0, 20)
        ReDim gridArray(landscapeSizeY, landscapeSizeX)
        ReDim playerArray(landscapeSizeY, landscapeSizeX)

        colour01 = randomNumber.Next(1, 6) 'This genereates a number to reference a colour for the colour pallete. 
        colour02 = randomNumber.Next(1, 6)
        colour03 = randomNumber.Next(1, 6)
        colour04 = randomNumber.Next(1, 6)
        colour05 = randomNumber.Next(1, 6)

        If colour01 = colour02 Or colour01 = colour03 Or colour01 = colour04 Or colour01 = colour05 Then 'Just making sure no two variables are the same. 
            colour01 = randomNumber.Next(0, 6)
        ElseIf colour02 = colour01 Or colour02 = colour03 Or colour02 = colour04 Or colour02 = colour05 Then
            colour02 = randomNumber.Next(0, 6)
        ElseIf colour03 = colour01 Or colour03 = colour02 Or colour03 = colour04 Or colour03 = colour05 Then
            colour03 = randomNumber.Next(0, 6)
        ElseIf colour04 = colour01 Or colour04 = colour02 Or colour04 = colour03 Or colour04 = colour05 Then
            colour04 = randomNumber.Next(0, 6)
        End If

        'Generate enemies. 
        enemyAmount = randomNumber.Next(0, maxEnemyAmount)
        For i = 0 To enemyAmount
            enemyLocationY = randomNumber.Next(0, landscapeSizeY)
            enemyLocationX = randomNumber.Next(0, landscapeSizeX)
            playerArray(enemyLocationY, enemyLocationX) = 7
        Next
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
    Sub reDrawGrid()
        If firstLoop = True Then
            playerArray(0, 0) = 6
            firstLoop = False
        End If
        For y = 0 To landscapeSizeY
            For x = 0 To landscapeSizeX
                If gridArray(y, x) = 1 Then
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
                ElseIf gridArray(y, x) = 2 Then
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
                ElseIf gridArray(y, x) = 3 Then
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
                ElseIf gridArray(y, x) = 4 Then
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
                ElseIf gridArray(y, x) = 5 Then
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
                If playerArray(y, x) = 6 Then 'This if statement decides it the certain co-ordinate is a play or not. 
                    Console.ForegroundColor = ConsoleColor.Cyan
                    Console.Write("[0]")
                ElseIf playerArray(y, x) = 7 Then 'This else if decides if the certain co-ordinate is an enemy or not. 
                    Console.Write("[")
                    Console.ForegroundColor = ConsoleColor.DarkRed
                    Console.Write("0")
                    If gridArray(y, x) = 1 Then
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
                    ElseIf gridArray(y, x) = 2 Then
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
                    ElseIf gridArray(y, x) = 3 Then
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
                    ElseIf gridArray(y, x) = 4 Then
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
                    ElseIf gridArray(y, x) = 5 Then
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
                    Console.Write("]")
                Else 'If the co-ordinate isn't a player, then a blank cell will be drawn. 
                    Console.Write("[ ]")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub
    Sub playerMovement()
        Dim playerLocationFound As Boolean = False
        Console.WriteLine("-------------------")

        Dim userInput As ConsoleKeyInfo
        Dim didUserPressKey As Boolean = False
        Do
            userInput = Console.ReadKey(True)
            If userInput.Key = ConsoleKey.D Then 'Move Right
                While playerLocationFound = False
                    For y = 0 To landscapeSizeY
                        For x = 0 To landscapeSizeX
                            If playerArray(y, x) = 6 Then
                                playerArray(y, x) = 0 'This makes the players old co-ordinate equal to 0. 
                                x = x + 1 'This moves the co-ordinate to the right by 1.
                                Try
                                    playerArray(y, x) = 6 'This now makes the new co-ordinate equal to 6.
                                Catch ex As Exception
                                    x = x - 1
                                    playerArray(y, x) = 6
                                End Try
                                playerLocationFound = True 'This stops the while loop.
                            End If
                        Next
                    Next
                End While
                didUserPressKey = True
            ElseIf userInput.Key = ConsoleKey.A Then 'Move Left.
                While playerLocationFound = False
                    For y = 0 To landscapeSizeY
                        For x = 0 To landscapeSizeX
                            If playerArray(y, x) = 6 Then
                                playerArray(y, x) = 0 'This makes the players old co-ordinate equal to 0. 
                                x = x - 1 'This moves the co-ordinate to the right by 1.
                                Try
                                    playerArray(y, x) = 6
                                Catch ex As Exception
                                    x = x + 1
                                    playerArray(y, x) = 6
                                End Try
                                playerLocationFound = True 'This stops the while loop.
                            End If
                        Next
                    Next
                End While
                didUserPressKey = True
            ElseIf userInput.Key = ConsoleKey.S Then 'Move Down.
                While playerLocationFound = False
                    For y = 0 To landscapeSizeY
                        For x = 0 To landscapeSizeX
                            If playerArray(y, x) = 6 Then
                                playerArray(y, x) = 0 'This makes the players old co-ordinate equal to 0. 
                                y = y + 1 'This moves the co-ordinate to the right by 1. 
                                Try
                                    playerArray(y, x) = 6 'This now makes the new co-ordinate equal to 6.
                                Catch ex As Exception
                                    y = y - 1
                                    playerArray(y, x) = 6
                                End Try
                                playerLocationFound = True 'This stops the while loop.
                            End If
                        Next
                    Next
                End While
                didUserPressKey = True
            ElseIf userInput.Key = ConsoleKey.W Then 'Move Up.
                While playerLocationFound = False
                    For y = 0 To landscapeSizeY
                        For x = 0 To landscapeSizeX
                            If playerArray(y, x) = 6 Then
                                playerArray(y, x) = 0 'This makes the players old co-ordinate equal to 0. 
                                y = y - 1 'This moves the co-ordinate to the right by 1. 
                                Try
                                    playerArray(y, x) = 6 'This now makes the new co-ordinate equal to 6.
                                Catch ex As Exception
                                    y = y + 1
                                    playerArray(y, x) = 6
                                End Try
                                playerLocationFound = True 'This stops the while loop.
                            End If
                        Next
                    Next
                End While
                didUserPressKey = True
            End If
        Loop Until didUserPressKey = True
        System.Threading.Thread.Sleep(50) 'This helps to reduce the grid from flickering. 
    End Sub
End Module