// See https://aka.ms/new-console-template for more information
using oop_sample_2;



var percy = new ThirstyHuman("Percy");

// case 1:
var bottle = new WaterSource(1500);
var glass = new Glass(200);

percy.Drink(bottle, glass);


// case 2:
var faucet = new WaterSource(true);
var mug = new Mug(500);

percy.Drink(faucet, mug);