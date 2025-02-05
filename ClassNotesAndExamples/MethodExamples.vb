Option Explicit On
Option Strict On

Module MethodExamples

    Sub Main()
        Dim myLuckyNumber As Integer = 7
        'Console.WriteLine("Hello from Sub Main")
        'Console.WriteLine($"My lucky number is {myLuckyNumber}")
        'Console.WriteLine()
        'MyOtherSub()
        'Console.WriteLine()
        'Sandwich(myLuckyNumber)
        'Marine(myLuckyNumber)
        'Console.WriteLine("Hello from Sub Main")
        'Console.WriteLine($"My lucky number is {myLuckyNumber}")
        'Console.WriteLine()

        'Console.WriteLine(MyActuallLuckyNumber())
        'Console.WriteLine(SumOf(5, 7))

        Randomize(DateTime.Now.Millisecond)
        For i = 1 To 100
            Console.WriteLine(RandomNumber() & "%")
        Next
    End Sub

    'Sub Examples
    Sub MyOtherSub()
        Dim myLuckyNumber As Integer = 5
        Console.WriteLine("Hello from My Other Sub")
        Console.WriteLine($"My lucky number is {myLuckyNumber}")
        Console.WriteLine()


    End Sub

    Sub Sandwich(ByVal myLuckyNumber As Integer)
        myLuckyNumber += 5
        Console.WriteLine("Hello from Sub Sandwich")
        Console.WriteLine($"My lucky number is {myLuckyNumber}")
        Console.WriteLine()
    End Sub

    Sub Marine(ByRef myLuckyNumber As Integer)
        myLuckyNumber += 7
        Console.WriteLine("Hello from Sub Marine")
        Console.WriteLine($"My lucky number is {myLuckyNumber}")
        Console.WriteLine()
    End Sub

    'function examples
    Function MyActuallLuckyNumber() As Integer
        Return 77
    End Function

    Function SumOf(firstNumber As Integer, secondNumber As Integer) As Integer
        Dim result As Integer
        result = firstNumber + secondNumber
        Return result
    End Function

    Function RandomNumber() As Integer
        Dim myRandomNumber As Integer

        Randomize()
        myRandomNumber = CInt(Rnd() * 100)
        Return myRandomNumber
    End Function


End Module
