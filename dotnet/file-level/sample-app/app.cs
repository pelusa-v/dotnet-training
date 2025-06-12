#:package StackExchange.Redis@2.6.122

using StackExchange.Redis;

// var redisConn = ConnectionMultiplexer.Connect(configOptions);
var redisConn = await ConnectionMultiplexer.ConnectAsync("localhost:6379");
var db = redisConn.GetDatabase();

db.StringSet("sampleKey", "sampleValue");

var sampleValue = await db.StringGetAsync("sampleKey");
Console.WriteLine($"The value of 'sampleKey' is: {sampleValue}");