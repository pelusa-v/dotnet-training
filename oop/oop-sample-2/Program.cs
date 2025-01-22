// See https://aka.ms/new-console-template for more information
using oop_sample_2;



// case 1:
var bottle = new Bottle(1500);
var bottleSource = new WaterSource(bottle);
var glass = new Glass(200);

var percy = new ThirstyHuman("Percy", bottleSource, glass);
percy.Drink();


// case 2:
var faucet = new WaterSource();
var mug = new Mug(500);
percy.GrabUtensils(faucet, mug);

percy.Drink();