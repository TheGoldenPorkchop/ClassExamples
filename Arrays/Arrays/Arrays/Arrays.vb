Option Strict On
Option Explicit On
'Angel Nava
'Spring 2025
'RCET2265
'Array
'Link
Imports System.Security.Cryptography.X509Certificates

Module Arrays

    Sub Main()
        'MultiDimentionalArrays()
        'TestRandomness()
        SplittingStringsIntoArray()
    End Sub

    Sub SimpleArrays()
        'array are cool
        Dim fruits(5) As String
        Dim names() As String = {"john", "jacob", "Jinklehieghmer", "Schmitt"}
        Dim jellyBeanCounts = New Integer() {1, 2, 3, 4, 69, 6}

        fruits(0) = "coconut"
        fruits(1) = "dragon fruit"

        'For i = 0 To 10
        'Console.WriteLine(names(i))
        'Next

        For i = LBound(names) To UBound(names)
            Console.WriteLine(names(i))
        Next

        'Console.WriteLine(names(3))
    End Sub

    Sub MultiDimentionalArrays()
        Dim students(14, 2) As Single
        Dim classes() As String = {"Math", "History", "Art"}
        Dim somethingElse(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
        Dim threeDimensionalArray(,,) As Integer = {{{1}, {2}, {3}}, {{4}, {5}, {6}}, {{7}, {8}, {9}}}

        students(14, 0) = 90
        students(14, 1) = 95
        students(14, 2) = 99

        Console.WriteLine("")
    End Sub

    Sub TestRandomness()
        Dim jellyBeanCounter(20) As Integer
        For i = 1 To 100000
            jellyBeanCounter(RandomNumberBetween(5, 16)) += 1
        Next
        Console.WriteLine("You did it. That's Everything")

        For i = LBound(jellyBeanCounter) To UBound(jellyBeanCounter)
            Console.WriteLine($"{CStr(i).PadLeft(4)} hit {CStr(jellyBeanCounter(i)).PadLeft(4)} times")
        Next

    End Sub

    Function RandomNumberBetween(min As Integer, max As Integer) As Integer
        Dim woag As Single
        max += 1 'ensures max is included for math dot floor
        Randomize()
        woag = Rnd()
        woag *= max - min
        woag += min

        'Return CInt(woag) 'bad randomness
        Return CInt(Int(woag)) 'max is only included if max is max plus one
        'Return CInt(Math.Ceiling(woag)) 'ok, but min not included
        'Return CInt(Math.Floor(woag)) 'ok, but max not included

    End Function

    Sub SplittingStringsIntoArray()
        Dim lotsOfFruits As String = "grape, coconut, dragon fruit, banana, tomato, honeydew, lime, guava, mango, strawberry, pear"
        Dim fruits() As String

        fruits = Split(lotsOfFruits, ",")
        For Each fruit In fruits
            Console.WriteLine(fruit)
        Next

    End Sub

End Module
