// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using WorldWarMuseumMorse;

Console.WriteLine("Morse coded documents");
var words = WordList.GetWords();
var decodeTwoPointer = new DecodeMorseTwoPointers(words);

var result = decodeTwoPointer.Decode("--.--.---.......-.---.-.-.-..-.....--..-....-.-----..-");


result.ForEach(x => Console.WriteLine(x));