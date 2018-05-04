Module Module1

    Sub Main()
        Console.WriteLine("Calculette")

        'Variable pour les chiffres
        Dim Numéro, Numéro2 As Integer
        'Variable pour les opérateurs
        Dim Op As String

        'Lis le premier numéro
        Console.WriteLine("Veuillez entré un numéro")
        Numéro = Console.ReadLine()
        'Lis l'opérateur
        Console.WriteLine("Veuillez entré un opérateur")
        Op = Console.ReadLine()
        'Lis le deuxième numéro
        Console.WriteLine("Veuillez entré un autre numéro")
        Numéro2 = Console.ReadLine()

        'Gére le type d'opérateur et affiche le calcul et le résultat
        Console.WriteLine("Le résultat : ")
        Select Case Op
            Case "+"
                Console.Write(Numéro & Op & Numéro2 & "=" & Numéro + Numéro2)
            Case "*"
                Console.Write(Numéro & Op & Numéro2 & "=" & Numéro * Numéro2)
            Case "-"
                Console.Write(Numéro & Op & Numéro2 & "=" & Numéro - Numéro2)
            Case "/"
                Console.Write(Numéro & Op & Numéro2 & "=" & Numéro / Numéro2)
        End Select

        'Permet de maintenir la console ouverte
        Console.Read()
    End Sub

End Module
