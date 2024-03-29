# TestDome C# Sample Answers
Sample answers to public C# sample questions at:<p>
* https://www.testdome.com/d/c-sharp-interview-questions/18

## Comments
* _07_10001_Prime_ asks to get the n-th prime.  This answer 'cheats' by loading an ordered list
of primes off disk.  A 'conventional' answer would use a [Sieve of Eratosthenes](https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes).
  * Note that prime numbers have been found well in excess of the 10000-th prime and are 'well known'
    ie there is no real need to compute them as someone has already done that.  The problem then reduces
    to a simple lookup.
* performance of _Sorted Search_ algorithm could be improved by implementing a binary search
  but I felt there was not sufficient time to do this
* read requirements for _Decorator Stream_ question were a bit unclear
* _Two Sum_ answer fails the performance test.
  _FindTwoSum2_ is an [alternative implementation](https://stackoverflow.com/questions/36506164/find-two-sum-function-in-c-sharp) which does not.
* _Platformer_ answer fails the performance test for large platforms.  This probably due to removing items from a List`.
_Platformer2_ is another implementation which will probably pass the performance test.
* If you're doing the test for real, make sure you have a real IDE eg Visual Studio,
  to hand.  The web IDE is only really/barely suitable for the sample questions.
  It doesn't have a debugger, IntelliSense, refactoring or any other productivity features.
 
## Bonus Sample
Someone asked me to code a [bubble sort](./BubbleTea/Program.cs)!
_Hello?  The 90s called, wants their programming test back!_
