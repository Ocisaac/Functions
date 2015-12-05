# C# Functions
I created functional-programming-like functions in C#.

Functions can be partaily applyed, added, subtracted and compared.

I have also added a Chainer, which lets you chain functions togther, and a few other classes to help you work better with functions

This is the first library and code I publish and the first time I work with Github, and I hope I've done everything correctly.

# How to use the library

Here are some code examples - 

```sh
var get5 = new Function<int>( () => 5 ); //Creates a function that takes nothing and returns five

//Creates a function that takes i and adds 3 to it, without the need to specify the types in <> when the compiler can infer the types
var add = FunctionBuilder.GetFunction<int, int, int>((a, b) => a + b); 

var add3 = add.PartiallyApply(3); //Creates a function that is add with the fisrt parameter set always to 3

var get8 = get5.ChainWith(add3); // Chains get5's output with add3's input

var printMessage = FunctionActionBuilder( m => Console.WriteLine(m));

var eight = get8.Apply(); // returns 8

//INCORRECT 
var o = printMessage.Apply("Hey!"); // returns a null object

//CORRECT
printMessage.Apply("Hey!") // the null object is not used
```

Note that function addition is not the same as chaining, it is equivalent to delegate adding.
