using BenchmarkDotNet.Running;
using DotNet.Async;
using DotNet.DesignPatterns.Creational;

#region Async

//var results = BenchmarkRunner.Run<ThreadTasks>();
//ThreadTasks test = new ThreadTasks();

//var test2 = await test.GetWebsitesAsync();
//var test3 = test.GetWebsitesSync();

//var test4 = test.GetWebsiteContentParallel3();
//var test5 = test.GetWebsiteContentParallel10();

//foreach (var item in test4) 
//{
//    Console.WriteLine(item.Length);
//};

#endregion Async

#region LINQ

//var linq = new LinqPlays();
//linq.Play();

#endregion LINQ

#region DesignPatterns

#region Singleton

//var numbers = Enumerable.Range(0, 10);
//Parallel.ForEach(numbers, i =>
//{
//    //Console.WriteLine("Task {0}:", i);
//    var vm = Singleton.Instance;
//    vm.RegisterVote();
//});
//Console.WriteLine("Total Votes: {0}", Singleton.Instance.TotalVotes);

#endregion #region Singleton

#region Builder


//// The client code creates a builder object, passes it to the
//// director and then initiates the construction process. The end
//// result is retrieved from the builder object.
//var director = new Director();
//var builder = new ConcreteBuilder();
//director.Builder = builder;

//Console.WriteLine("Standard basic product:");
//director.BuildMinimalViableProduct();
//Console.WriteLine(builder.GetProduct().ListParts());

//Console.WriteLine("Standard full featured product:");
//director.BuildFullFeaturedProduct();
//Console.WriteLine(builder.GetProduct().ListParts());

//// Remember, the Builder pattern can be used without a Director
//// class.
//Console.WriteLine("Custom product:");
//builder.BuildPartA();
//builder.BuildPartC();
//Console.Write(builder.GetProduct().ListParts());

//--------------------------------- Another approach -------------------------------//

//var blogPostBuilder = new BlogPostBuilder();

//blogPostBuilder.AddTitle("My First Blog Post");
//blogPostBuilder.AddContent("This is my first blog post");
//blogPostBuilder.AddAuthor("John Doe");
//blogPostBuilder.AddDate(DateTime.Now);
//blogPostBuilder.AddCategory("C#");
//blogPostBuilder.AddCategory("Programming");

//var blogPostSettings = blogPostBuilder.Build();

#endregion Builder

#region Prototype

//// When creating a new object is more costly then coppy one.
//// 10m * 10m matrix made for sudoku -> create prototypes first then clone them every time. 

//List<string> options = new(){"Sunroof", "Navigation", "Leather Seats"};

//Car car1 = new("Ford", "Mustang", 2022, options);
//Car? car2 = car1.Clone() as Car;

#endregion Prototype

#endregion #region DesignPatterns

var asd = 1;
