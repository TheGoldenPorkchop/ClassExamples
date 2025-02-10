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
        MultiDimentionalArrays()
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
        students(14, 0) = 90
        students(14, 1) = 95
        students(14, 2) = 99

        Console.WriteLine("")
    End Sub

End Module
