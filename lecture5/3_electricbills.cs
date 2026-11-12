/// Description: Reads in a series of electric meters (in kilowatt-hours) from
/// a data file (terminating at -999) and displays the electric bills according to:
///  7 cents per kilowatt hour for the first 2000 hours, 
///  5 cents/kwh for the next 8000 hours, and 
///  4 cents for all kwh over 10000 hours.
using static System.Console;
using System.IO;

