public class Algorithms
{
    public static void MoveZerosFinal(int[] numbers)
    {
        int arrayLength = numbers.Length;
        int startPointer = 0;
        int endPointer = numbers.Length - 1;

        while (startPointer < endPointer)
        {
            var currentStartPointerValue = numbers[startPointer];
            var currenteEndPointerValue = numbers[endPointer];

            if (currentStartPointerValue == 0 && currenteEndPointerValue != 0)
            {
                if (numbers[startPointer + 1] < currenteEndPointerValue)
                {
                    var nextStartPointerValue = numbers[startPointer + 1];

                    numbers[startPointer] = nextStartPointerValue;
                    numbers[startPointer + 1] = currenteEndPointerValue;
                    numbers[endPointer] = currentStartPointerValue;

                    startPointer++;
                    endPointer--;
                }
                else
                {
                    var previousStartPointerValue = numbers[startPointer - 1];

                    numbers[startPointer] = previousStartPointerValue;
                    numbers[startPointer - 1] = currenteEndPointerValue;
                    numbers[endPointer] = currentStartPointerValue;

                    startPointer++;
                    endPointer--;
                }
            }
            else
            {
                startPointer++;
            }
        }
    }

    public static void InvertString(char[] text)
    {
        int left = 0;
        int right = text.Length - 1;
        while (left < right)
        {
            var leftVal = text[left];
            var rightVal = text[right];

            text[left] = rightVal;
            text[right] = leftVal;

            left++;
            right--;
        }
    }

    public static void SortColors(int[] colors)
    {
        // PASADA: [2,0,1]
        // PASADA: [1,0,2]
        int start = 0,
            final = colors.Length - 1; // 0

        while (final > start)
        {
            var currentStart = colors[start]; // 1
            var currentFinal = colors[final]; // 0

            if (currentStart > currentFinal)
            {
                colors[start] = currentFinal;
                colors[final] = currentStart;
                final--;
            }
            else if (currentStart == currentFinal) // Blue color
            {
                var currentPreviousVal = colors[final - 1];

                if (currentPreviousVal < currentStart)
                {
                    colors[start] = currentPreviousVal;
                    colors[final - 1] = currentStart;
                    final--;
                }
            }
            else
            {
                start++;
            }
        }

        for (int i = 0; i < colors.Length; i++)
        {
            Console.Write(colors[i]);
            Console.Write("|");
        }
        Console.WriteLine(Environment.NewLine);
    }

    public static void InvertVowels(string text)
    {
        var builder = new char[text.Length];
        const string vowels = "aeiouAEIOU";

        var left = 0;
        var right = text.Length - 1;
        var count = 0;
        while (text.Length != count)
        {
            var leftVal = text[left];
            var rightVal = text[right];

            if (vowels.Contains(leftVal) && vowels.Contains(rightVal))
            {
                builder[right] = leftVal;
                builder[left] = rightVal;

                right--;
                left++;
            }

            if (!vowels.Contains(leftVal))
            {
                builder[left] = leftVal;
                left++;
            }

            if (!vowels.Contains(rightVal))
            {
                builder[right] = rightVal;
                right--;
            }
            count++;
        }
    }

    public static int[] CuadradosOrdenados(int[] numeros)
    {
        var newArray = new int[numeros.Length];
        var p1 = 0;
        var p2 = numeros.Length - 1;
        var asignado = numeros.Length - 1;

        while (asignado >= 0)
        {
            var p1Val = Math.Pow(numeros[p1], 2);
            var p2Val = Math.Pow(numeros[p2], 2);

            if (p1Val > p2Val)
            {
                newArray[asignado] = (int)p1Val;
                p1++;
            }

            if (p1Val <= p2Val)
            {
                newArray[asignado] = (int)p2Val;
                p2--;
            }

            asignado--;
        }

        return newArray;
    }

    public static bool EsPalindromoValido(string frase)
    {

        //abca -> eliminando c tengo aba

        var left = 0;
        var right = frase.Length - 1;

        while (right > left)
        {
            if (frase[right] != frase[left])
                return ValidarPalindromo(left + 1, right) || ValidarPalindromo(left, right - 1);

            right--;
            left++;
        }

        bool ValidarPalindromo(int p1, int p2)
        {
            if (p1 > p2) return true;

            if (frase[p1] != frase[p2]) return false;

            return true;
        }

        return true;
    }
}