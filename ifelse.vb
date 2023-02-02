Module Module1
    'Write a program to input a value, check and output a message, if the entered value is larger than 100?
    Sub Main()

        Dim x As Integer

        Console.WriteLine(" Enter a number : ")
        x = Console.ReadLine
        If x > 100 Then
            Console.WriteLine(" Entered Value is larger than 100")
        Else
            Console.WriteLine(" Entered Value is Smaller than 100")
        End If

        Console.ReadKey()

    End Sub

End Module
