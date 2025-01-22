// See https://aka.ms/new-console-template for more information
using oop_sample_1;



// Project: Human wants to drink water
var glass = new Glass(200);
var bottle = new WaterSource();

var person = new Human("John");
person.DrinkWater(bottle, glass);