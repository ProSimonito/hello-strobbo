# Create a web API with ASP.NET Core controllers

_ASP.NET Core supports two approaches to creating APIs: a controller-based approach and minimal APIs. Controllers in an API project are classes that derive from ControllerBase. Minimal APIs define endpoints with logical handlers in lambdas or methods._

## Exercise

<ul>
    <li>Create a web API project named: <code>Strobbo.WebApi</code></li>
    <ul>
        <li>Don't use any authentication type</li>
        <li>Make sure the bottom checkbox is checked to <code>Use controllers</code></li>
    </ul>
    <li>Take your time to get familiar with the generated files and set the newly created project as your startup project.</li>
    <li>Build and run the application. You will notice an example endpoint.</li>
    <ul>
        <li>Use Swagger to trigger a GET request.</li>
        <li>Use the http file to trigger a GET request.</li>
    </ul>
</ul>

Before we start to implement a new web API, you need to have a data store on which you can perform operations. In this exercise, we'll use a simple local in-memory caching service. In a real-world application, you'd consider using a database.


<ul>
    <li>Create a new folder in the WebApi project: <code>Models</code></li>
    <li>Move the file <code>Sushi.cs</code> to this folder and adjust it's namespace</li>
    <li>Create a new folder in the WebApi project: <code>Services</code></li>
    <li>Move the file <code>SushiService.cs</code> to this folder and adjust it's namespace</li>
    <li>The build succeeds with no warnings. If the build fails, check the output for troubleshooting information.</li>
</ul>

Now we'll add a new controller for our Sushi service

<ul>
    <li>Add a new controller in the Controller folder named: <code>SushiController</code>. Make sure to create an API controller, and not an MVC controller</li>
    <li>Now implement the following requests</li>
    <ul>
        <li>GET all action</li>
        <li>GET by Id action. Return a Not Found when not present in the in-memory caching service.</li>
        <li>POST action. Create a new sushi item.</li>
        <li>PUT action. Update an existing sushi item.</li>
        <li>DELETE action. Delete an existing sushi item.</li>
    </ul>
    <li>(optional) Create an interface for the service and use dependency injection to inject the service into your controller.</li>
</ul>

## Resources

- https://learn.microsoft.com/en-us/aspnet/core/fundamentals/apis?view=aspnetcore-8.0
- https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio
- https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/dependency-injection?view=aspnetcore-8.0
