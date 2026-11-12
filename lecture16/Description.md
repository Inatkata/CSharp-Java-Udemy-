# Farm

## Description

 * Read from the data file: the first number represents the number of **hay bales** the farm currently has. It is followed by the cost of each hay bale.  
 * The next number is the number of **corncobs** the farm has, followed by the cost of each corncob.  
 * The data file will then provide the number of rows in the barn for **cows** and the number of pens in each row for cows stored in the file.
    - Each cow has a name, followed by a weight, followed by pounds of milk produced per day, followed by the number of hay bales eaten each day per cow, followed by the number of corncobs eaten each day per cow. 
 * The data file will then provide the number of rows in the barn for **horses** and the number of pens in each row, for horses stored in the data file.
    - Their name comes first, followed by their weight. This will be followed by the number of hay bales eaten each day, followed by the number of corncobs eaten each day, followed by the number of rides that horse gave and the cost per ride for that horse.  
 * Complete the super class, Animal, and then the sub classes, the Horse and Cow classes - be sure to create constructors for each of the classes. 
 * A pound of milk sells for $0.20.
 * The amount of money a cow makes is the money made for milk minus the cost of the feed for that animal for that day.
 * The amount of money a horse makes is the revenue from giving rides minus the cost of that animal's feed for that day.
 * When a horse gives its name, it always reports it twice.
 * The program should: 
    - report the day's income and the cumulative weight of all animals, 
    - determine if there is enough food to feed all the animals, 
    - report the cow location that makes the most money, and 
    - report the horse location that makes the least money.  
