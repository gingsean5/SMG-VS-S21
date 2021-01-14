Module Operators1

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

        Console.WriteLine("B" > "AAA")

        Console.ReadLine()
    End Sub

End Module
