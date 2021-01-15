Module Operators1
    'Sean Gingerich
    'RCET0265
    'Spring 2021
    'First Assignment
    'https://github.com/gingsean5/SMG-VS-S21
    Sub Main()
        Console.WriteLine(2 + 2)
        Console.WriteLine(9 - 2)
        Console.WriteLine(5 * 2)
        Console.WriteLine(5 ^ 2)

        Console.WriteLine(18 / 6) 'Regular Division
        Console.WriteLine(18 / 6) 'Integer only Division
        Console.WriteLine(18 Mod 6) 'Just the remainder

        Console.WriteLine("banana" & " apples") '& and + both work as concatenate but & is more right
        Console.WriteLine("banana" + "5")

        Console.WriteLine(4 > 3)
        Console.WriteLine(4 < 3)
        Console.WriteLine(4 = 3)
        Console.WriteLine(3 <> 3)

        Console.WriteLine("B" > "AAA") 'Compares ascii values of characters one at a time B>A

        Console.ReadLine()
    End Sub

End Module
