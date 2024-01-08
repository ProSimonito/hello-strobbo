# Hello Strobbo

_Learn the operators and techniques used to perform string formatting and basic math operations on numeric data._

## Exercise

<ul>
    <li>Say hello to all companies in our Console Application</li>
    <ul>
      <li>For each company, write <code>Hello</code> and the name of the company to the console.</li>
      <li>Now, add a rating to the company. Use the <code>Random()</code> class to generate a rating between 1 and 10 for each company and add it to the console output.</li>
      <li>(optional) calculate the average of all ratings. The company with the best average wins a prize: the average rating amount multiplied by 100. Write this number to the console as currency in Danish krones.</li>
    </ul>
    <li>Add NuGet package <code>Humanizer</code> as a dependency.</li>
    <ul>
      <li>"Humanize" the StrobboHeadline and StrobboSummary and write it to the console.</li>
      <li>Use the <code>Humanizer</code> package to write the company rating as words to the console.</li>
    </ul>
    <li>Remove the <code>Humanizer</code> dependency directly from the project file.</li>
</ul>

## Resources

- https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0
- https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.average?view=net-8.0
- https://learn.microsoft.com/en-us/dotnet/api/system.decimal.tostring?view=net-8.0
- https://github.com/Humanizr/Humanizer
