# Methods and Classes

_Demonstrate your ability to develop a console app that relies on classes and methods with different parameters and return values._

## Scenario

Suppose you're the owner of a karting circuit, Contoso Karting. You must regularly coordinate visits and organize the karts. You decide to write an application that helps you plan group visits.
The application divides a large group into smaller groups and assigns them to a set of karts they can race with. They will rotate groups after each race so everyone can drive different karts. You decide to randomize the kart order so that each race is unique.

Take a moment to consider the design specification:

<ul>
    <li>For each visiting group, perform the following tasks</li>
    <ul>
        <li>Randomize the karts</li>
        <li>Assign the karts to the correct number of groups</li>
        <li>Print the group name</li>
        <li>Print the kart groups</li>
    </ul>
</ul>

## Exercise

To get started, you'll focus on writing the pseudo-code.

<ul>
    <li>The first task is to randomize the karts. Create a pseudo-code method: <code>// RandomizeKarts();</code></li>
    <li>Next, create a pseudo-code method to assign the groups: <code>// AssignGroups();</code></li>
    <li>You can easily print the group name using: <code>Console.WriteLine("Strobbo");</code></li>
    <li>Lastly, you'll need to print the assigned groups: <code>// PrintGroup(group);</code></li>
    <ul>
        <li>Notice that you added a parameter to this method. Take a moment to consider where you can initialize the <code>group</code> argument in your pseudo-code.</li>
    </ul>
    <li>Run the console app with the commented pseudo-code to ensure there are no issues and to verify that the company name is displayed.</li>
</ul>

Now that we've expressed our intentions through the means of methods, let's get started with it's implementations.

<ul>
    <li>Create the method that randomizes the elements of an array. For this method you don't need any input parameters since you'll use the existing <code>Karts</code> variable.</li>
    <li>Uncomment the call to <code>RandomizeKarts()</code> by removing the starting <code>// </code> characters</li>
    <li>Set a breakpoint in your method and run the application to step through your method to verify if your method produces the desired effect.</li>
</ul>

Observant developers will notice that it's rather inconvenient to start your application whenever you feel like debugging, so let's extract this method into a separate Class.

<ul>
    <li>Create a Class named: <code>KartingCircuit</code></li>
    <li>Refactor the code so the <code>RandomizeKarts()</code> method is moved to the newly created class.</li>
    <li>Now write a unit test to assert the outcome of your method. (this implies you'll have to refactor your method's signature and class input parameters)</li>
    <li>(optional) try to implement the remaining methods as well, where the <code>AssignGroups(int groups = 6)</code> method returns a 2D array <code>string[,]</code> of karts.</li>
</ul>

## Resources

- https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
- https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes
- https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes
- https://stackoverflow.com/questions/108819/best-way-to-randomize-an-array-with-net
- https://learn.microsoft.com/en-us/dotnet/api/system.random.shuffle?view=net-8.0
- https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays
