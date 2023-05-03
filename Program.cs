// See https://aka.ms/new-console-template for more information
// Algorithms.InvertString(new char[] { 'h', 'e', 'l', 'l', 'o' });
// Console.WriteLine(Environment.NewLine);
// Algorithms.InvertString(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' });

//Algorithms.SortColors(new int[] { 2, 0, 2, 1, 1, 0 });
// Algorithms.InvertVowels("hola");
// Console.WriteLine(Environment.NewLine);
// Algorithms.InvertVowels("leetcode");

// var array = Algorithms.CuadradosOrdenados(new int[] { -7, -3, 2, 3, 11 });
// foreach (var item in array)
// {
//     Console.WriteLine(item);
// }


// Console.WriteLine(Algorithms.EsPalindromoValido("aba"));
// Console.WriteLine(Algorithms.EsPalindromoValido("abca"));
// Console.WriteLine(Algorithms.EsPalindromoValido("ana"));
// Console.WriteLine(Algorithms.EsPalindromoValido("radar"));
// Console.WriteLine(Algorithms.EsPalindromoValido("somos"));
// Console.WriteLine(Algorithms.EsPalindromoValido("luis"));


// Console.WriteLine(VentanaDeslizante.LongestSubStringWithoutRepeat("abcabcbb"));
// Console.WriteLine(VentanaDeslizante.LongestSubStringWithoutRepeat("jdkafnlcdsalkxcmpoiuytfccv"));

//Console.WriteLine(BinarySearch.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0));
//Console.WriteLine(BinarySearch.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3));

int[,] matriz = new int[,] {
    { 1, 3, 5, 7 },
    { 10, 11, 16, 20 },
    { 23, 30, 34, 60 }
};
Console.WriteLine(Binary2DSearch.Search(matriz, 3));
Console.WriteLine(Binary2DSearch.Search(matriz, 12));
Console.WriteLine(Binary2DSearch.Search(matriz, 60));