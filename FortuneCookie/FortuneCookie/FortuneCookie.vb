Module FortuneCookie

    Sub Main()
        Dim cookie As Integer
        Randomize()
            cookie = RandomNumber()
            If cookie = 0 Then
                Console.WriteLine("You will give this assignment full points.")
            ElseIf cookie = 1 Then
                Console.WriteLine("Give a man purpose and the ability to achieve it, and he will crawl over broken glass with a smile.")
            ElseIf cookie = 2 Then
                Console.WriteLine("To climb a mountain takes a great effort, but the view is often better higher up.")
            ElseIf cookie = 3 Then
                Console.WriteLine("The higher they fly, the harder they fall.")
            ElseIf cookie = 4 Then
                Console.WriteLine("Cut out soda from your diet. Seriously. It's something small that can make a big difference later on.")
            ElseIf cookie = 5 Then
                Console.WriteLine("Originality triumphs over plagerism")
            ElseIf cookie = 6 Then
                Console.WriteLine("Do not be afraid to ask questions.")
            ElseIf cookie = 7 Then
                Console.WriteLine("You got to try new things and fail. If you're not failing, then you're never going to win because you can't win unless you try.")
            ElseIf cookie = 8 Then
                Console.WriteLine("Take care of yourself before taking care of others.")
            ElseIf cookie = 9 Then
                Console.WriteLine("Everything is temporary. So take everything as a blessing.")
            ElseIf cookie = 10 Then
                Console.WriteLine("Good things take time.")
            Else
                Console.WriteLine("Your fortune is beyond my understanding")
            End If
    End Sub




    Function RandomNumber() As Integer
        Dim myRandomNumber As Integer

        Randomize()
        myRandomNumber = CInt(Rnd() * 10)
        Return myRandomNumber
    End Function
End Module
