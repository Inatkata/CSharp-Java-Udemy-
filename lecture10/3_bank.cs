/// Description: Maintains a checkbook register and reports the initial 
/// and final account balances after a series of transactions read in from
/// an external data file with four transaction codes:
/// C => Check (subtracts amount from balance OR 10 if balance is insufficient)
/// D => Deposit (adds to balance)
/// S => Service Charge (subtracts amount from balance)
/// E => End of file (should not be processed)
/// All other transaction codes are illegal and do not affect the balance.
using static System.Console;
using System.Diagnostics;
