﻿using FizzBuzz.Entities;

var list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

var list2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
var exercise = new GoodBoy(list2);
var res = exercise.ReplaceNumbers();

res.ForEach(x => Console.WriteLine(x));


