// See https://aka.ms/new-console-template for more information


using Interview_test;

List<int> numbers = new List<int>() { 1,4,4,5,6,7,8,9,0 };
int[] numbers2 = { 1, 2, 5, 6 };


var result = numbers.First(s => s == 3);


Console.WriteLine(result);