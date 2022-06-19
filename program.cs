// See https://aka.ms/new-console-template for more information
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_payroll_using_threads
{
Console.WriteLine("Employee Payroll using Threads");

string[] words = CreateWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");

Console.WriteLine("Size of array after splitting the content: " + words.Length);

#region ParallelTasks

Parallel.Invoke(() =>

{

    Console.WriteLine("Begin first task...");

    GetLongestWord(words);

},// close 1st action

() =>

{

    Console.WriteLine("Begin second task...");

    GetMostCommonWords(words);

},

() =>

{

    Console.WriteLine("Begin third task...");

    GetMostCommonWords(words);

}// close third action

);// close parallel.invoke

#endregion

//Console.ReadKey();


