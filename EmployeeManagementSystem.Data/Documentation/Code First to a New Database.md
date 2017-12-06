# Entity Framework Code First to a New Database

> [Source](https://msdn.microsoft.com/en-us/library/jj193542%28v=vs.113%29.aspx?f=255&MSPPError=-2147217396)

This video and step-by-step walk-through provide an introduction to Code First development targeting a new database. This scenario includes targeting a database that doesn’t exist and Code First will create, or an empty database that Code First will add new tables too. Code First allows you to define your model using C# or VB.Net classes. Additional configuration can optionally be performed using attributes on your classes and properties or by using a fluent API.

[See the video that accompanies this step-by-step walk-through.](https://msdn.microsoft.com/en-us/library/jj572366(v=vs.113).aspx)

## Pre-Requisites
You will need to have Visual Studio 2010 or Visual Studio 2012 installed to complete this walkthrough.
If you are using Visual Studio 2010, you will also need to have [NuGet](http://visualstudiogallery.msdn.microsoft.com/27077b70-9dad-4c64-adcf-c7cf6bc9970c) installed.

### 1. Create the Application
To keep things simple we’re going to build a basic console application that uses Code First to perform data access.
 - Open Visual Studio
 - File -> New -> Project…
 - Select Windows from the left menu and Console Application
 - Enter CodeFirstNewDatabaseSample as the name
 - Select OK
### 2. Create the Model
Let’s define a very simple model using classes. We’re just defining them in the Program.cs file but in a real world application you would split your classes out into separate files and potentially a separate project.
Below the Program class definition in Program.cs add the following two classes.

```c#
public class Blog 
{ 
    public int BlogId { get; set; } 
    public string Name { get; set; } 
 
    public virtual List<Post> Posts { get; set; } 
} 
 
public class Post 
{ 
    public int PostId { get; set; } 
    public string Title { get; set; } 
    public string Content { get; set; } 
 
    public int BlogId { get; set; } 
    public virtual Blog Blog { get; set; } 
}
```
You’ll notice that we’re making the two navigation properties (Blog.Posts and Post.Blog) virtual. This enables the Lazy Loading feature of Entity Framework. Lazy Loading means that the contents of these properties will be automatically loaded from the database when you try to access them.

### 3. Create a Context
Now it’s time to define a derived context, which represents a session with the database, allowing us to query and save data. We define a context that derives from System.Data.Entity.DbContext and exposes a typed `DbSet<TEntity>` for each class in our model.
We’re now starting to use types from the Entity Framework so we need to add the EntityFramework NuGet package.
 - **Project –> Manage NuGet Packages…** Note: If you don’t have the **Manage NuGet Packages…** option you should [install the latest version of NuGet](http://visualstudiogallery.msdn.microsoft.com/27077b70-9dad-4c64-adcf-c7cf6bc9970c)
 - Select the **Online** tab
 - Select the **EntityFramework** package
 - Click **Install**

 Add a using statement for System.Data.Entity at the top of Program.cs.
 ```c#
 using System.Data.Entity;
 ```
 Below the Post class in Program.cs add the following derived context.
 ```c#
public class BloggingContext : DbContext 
{ 
    public DbSet<Blog> Blogs { get; set; } 
    public DbSet<Post> Posts { get; set; } 
}
 ```
 Here is a complete listing of what Program.cs should now contain.
 ```c#
 using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Data.Entity; 
 
namespace CodeFirstNewDatabaseSample 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
        } 
    } 
 
    public class Blog 
    { 
        public int BlogId { get; set; } 
        public string Name { get; set; } 
 
        public virtual List<Post> Posts { get; set; } 
    } 
 
    public class Post 
    { 
        public int PostId { get; set; } 
        public string Title { get; set; } 
        public string Content { get; set; } 
 
        public int BlogId { get; set; } 
        public virtual Blog Blog { get; set; } 
    } 
 
    public class BloggingContext : DbContext 
    { 
        public DbSet<Blog> Blogs { get; set; } 
        public DbSet<Post> Posts { get; set; } 
    } 
}
```
That is all the code we need to start storing and retrieving data. Obviously there is quite a bit going on behind the scenes and we’ll take a look at that in a moment but first let’s see it in action.
### 4. Reading & Writing Data
Implement the Main method in Program.cs as shown below. This code creates a new instance of our context and then uses it to insert a new Blog. Then it uses a LINQ query to retrieve all Blogs from the database ordered alphabetically by Title.
```c#
class Program 
{ 
    static void Main(string[] args) 
    { 
        using (var db = new BloggingContext()) 
        { 
            // Create and save a new Blog 
            Console.Write("Enter a name for a new Blog: "); 
            var name = Console.ReadLine(); 
 
            var blog = new Blog { Name = name }; 
            db.Blogs.Add(blog); 
            db.SaveChanges(); 
 
            // Display all Blogs from the database 
            var query = from b in db.Blogs 
                        orderby b.Name 
                        select b; 
 
            Console.WriteLine("All blogs in the database:"); 
            foreach (var item in query) 
            { 
                Console.WriteLine(item.Name); 
            } 
 
            Console.WriteLine("Press any key to exit..."); 
            Console.ReadKey(); 
        } 
    } 
}
```
You can now run the application and test it out.
```
Enter a name for a new Blog: ADO.NET Blog
All blogs in the database:
ADO.NET Blog
Press any key to exit...
```