using System;
-100, 101);
                if (m2[i, j] < minV) { minV = m2[i, j]; minR = i; minC = j; }
                if (m2[i, j] > maxV) { maxV = m2[i, j]; maxR = i; maxC = j; }
            }
        }

        bool countFlag = false;
        int sumBetween = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if ((i == minR && j == minC) || (i == maxR && j == maxC))
                {
                    countFlag = !countFlag;
                    continue;
                }
                if (countFlag) sumBetween += m2[i, j];
            }
        }
        Console.WriteLine($"Min: {minV}, Max: {maxV}, Sum between min and max: {sumBetween}");


        ////////////
        string text3 = "Hello";
        int shift3 = 3;
        string enc3 = "";
        foreach (char c in text3)
        {
            char baseChar = char.IsUpper(c) ? 'A' : 'a';
            if (char.IsLetter(c))
                enc3 += (char)(((c + shift3 - baseChar) % 26) + baseChar);
            else
                enc3 += c;
        }
        Console.WriteLine($"Before: {text3}, After: {enc3}");


        //////////
        double[,] matA = { { 1, 2 }, { 3, 4 } };
        double scalar = 2.0;
        Console.WriteLine("Matrix A multiplied by scalar 2:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++) Console.Write((matA[i, j] * scalar) + " ");
            Console.WriteLine();
        }


        ///////////
        string expr = "10 + 5 - 3";
        string[] parts = expr.Split(' ');
        int res5 = int.Parse(parts[0]);
        for (int i = 1; i < parts.Length; i += 2)
        {
            if (parts[i] == "+") res5 += int.Parse(parts[i + 1]);
            else if (parts[i] == "-") res5 -= int.Parse(parts[i + 1]);
        }

        Console.WriteLine($"Expression '{expr}' = {res5}");


        ///////////
        string text6 = "today is a good day for walking. i will try to walk near the sea";
        char[] chars6 = text6.ToCharArray();
        if (chars6.Length > 0 && chars6[0] >= 'a' && chars6[0] <= 'z')
            chars6[0] = (char)(chars6[0] - 32);

        for (int i = 0; i < chars6.Length - 1; i++)
        {
            if (chars6[i] == '.' && chars6[i + 1] == ' ')
            {
                int next = i + 2;
                if (next < chars6.Length && chars6[next] >= 'a' && chars6[next] <= 'z')
                    chars6[next] = (char)(chars6[next] - 32);
            }
        }
        Console.WriteLine(new string(chars6));


        /////////
        string text7 = "To die: to sleep; To die, to sleep";
        string target = "die";
        int replacements = 0;
        string updated = text7.Replace(target, "***");
        int index = text7.IndexOf(target);
        while (index != -1)
        {
            replacements++;
            index = text7.IndexOf(target, index + target.Length);
        }
        Console.WriteLine(updated);
        Console.WriteLine($"Replacements: {replacements}");


        ////////
        Console.WriteLine("\nTask 8 and 9");
        string cliText = args.Length > 0 ? args[0] : "Test";
        int cliShift = args.Length > 1 ? int.Parse(args[1]) : 3;
        Console.WriteLine($"CLI text: {cliText}, shift: {cliShift}");
    }
}
