'Author: Jeremiah Kerzic
'Creation Date: 7/5/21
'Program Function: Determines whether any given input is a palindrome.
Module Program
    Sub Main()
        'Variables
        Dim Input As String
        Dim Palindrome As Boolean = True
        Dim Index As Integer = 1

        'Get Input
        Console.Write("This program determines whether any input is a palindrome." & vbCrLf &
                          "Enter a string: ")

        Input = Console.ReadLine()

        'Check if input is the same
        Do
            If Not GetChar(Input, Index) = GetChar(Input, Input.Length - Index + 1) Then
                Palindrome = False
                Exit Do
            End If
            Index += 1
        Loop While Index <= Input.Length / 2

        'Display results
        If Palindrome Then
            Console.WriteLine(Input & " is a palindrome.")
        Else
            Console.WriteLine(Input & " is not a palindrome.")
        End If
        Console.WriteLine("Press any key to exit. ")
        Console.ReadKey()
    End Sub
End Module
