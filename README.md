# Methods and Classes

_Demonstrate your ability to develop a console app that relies on classes and methods with different parameters and return values._

## Scenario

Suppose you're the owner of a karting circuit, Contoso Karting. You must regularly coordinate visits from different companies and organize the karts. You decide to write an application that helps you plan group visits.
The application divides visiting companies into smaller groups and assigns them to a set of karts they can race with. They will rotate groups after each race so everyone can drive different karts. You decide to randomize the kart order so that each race is unique.

Take a moment to consider the design specification:

<ul>
    <li>There will be three visiting companies</li>
    <ul>
        <li>SD Worx has six visiting groups (the default number)</li>
        <li>Protime has three visiting groups</li>
        <li>Strobbo has two visiting groups</li>
    </ul>
</ul>

<ul>
    <li>For each visiting group, perform the following tasks</li>
    <ul>
        <li>Randomize the karts</li>
        <li>Assign the karts to the correct number of groups</li>
        <li>Print the company name</li>
        <li>Print the kart groups</li>
    </ul>
</ul>

## Exercise

To get started, you'll focus on writing the pseudo-code for just one visiting company. When you figure out the code for one company, you can easily apply the same logic to the others.

<ul>
    <li>The first task is to randomize the karts. Create a pseudo-code method: <code>// RandomizeKarts();</code></li>
    <li>Next, create a pseudo-code method to assign the karts: <code>// AssignKarts();</code></li>
    <li>You can easily print the company name using: <code>Console.WriteLine("SD Worx");</code></li>
    <li>Lastly, you'll need to print the kart groups: <code>PrintGroup(group);</code></li>
    <ul>
        <li>Notice that you added a parameter to this method. Take a moment to consider where you can initialize the <code>group</code> argument in your pseudo-code.</li>
    </ul>
    <!-- <li>Say hello to all companies in our Console Application</li>
    <ul>
      <li>For each company, write <code>Hello</code> and the name of the company to the console. Use <u>String Interpolation</u>.</li>
      <li>Now, add a rating to the company. Use the <code>Random()</code> class to generate a rating between 1 and 10 for each company and add it to the console output.</li>
      <li>(optional) calculate the average of all ratings. The company with the best average wins a prize: the average rating amount multiplied by 100. Write this number to the console as currency in Danish krones.</li>
    </ul>
    <li>Add NuGet package <code>Humanizer</code> as a dependency.</li>
    <ul>
      <li>"Humanize" the StrobboHeadline and StrobboSummary and write it to the console.</li>
      <li>Use the <code>Humanizer</code> package to write the company rating as words to the console.</li>
    </ul>
    <li>Remove the <code>Humanizer</code> dependency directly from the project file.</li> -->
</ul>

## Resources

<!--
- https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
- https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0
- https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.average?view=net-8.0
- https://learn.microsoft.com/en-us/dotnet/api/system.decimal.tostring?view=net-8.0
- https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#CFormatString
- https://github.com/Humanizr/Humanizer -->
