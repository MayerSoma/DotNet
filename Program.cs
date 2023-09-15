using BenchmarkDotNet.Running;
using DotNet.Async;
using DotNet.DesignPatterns.Behavioral;
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

#region Design Patterns

#region Creational Patterns

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

#region Factory Method

//// Get the entire object back with one call, not like the builder
//// where u can adjust the object state before building it.

//ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

//if (cardDetails != null)
//{
//    Console.WriteLine("CardType : " + cardDetails.GetCardType());
//    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
//    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
//}
//else
//{
//    Console.Write("Invalid Card Type");
//}
//Console.ReadLine();

#endregion

#region Abstract Factory

#endregion Abstract Factory

#endregion Creational Patterns

#region Behavioral Patterns

#region Strategy

//SortedList studentRecords = new();

//studentRecords.Add("Samual");
//studentRecords.Add("Jimmy");
//studentRecords.Add("Sandra");
//studentRecords.Add("Vivek");
//studentRecords.Add("Anna");

//studentRecords.SetSortStrategy(new QuickSort());
//studentRecords.Sort();

//studentRecords.SetSortStrategy(new ShellSort());
//studentRecords.Sort();

//studentRecords.SetSortStrategy(new MergeSort());
//studentRecords.Sort();

#endregion Strategy

#region State

////The State pattern is a behavioral design pattern that allows an object
////to change its behavior when its internal state changes.

////The State pattern is useful when the behavior of an object depends on its
////state and needs to change dynamically when its state changes.


//var invoice = new Invoice(123, 1000m, "Software Dev Services 1");

//invoice.Pay();
//invoice.Refund();

//var invoice2 = new Invoice(1234, 1000m, "Software Dev Services 2");

//invoice2.Cancel();
//invoice2.Pay();

//var invoice3 = new Invoice(1235, 1000m, "Software Dev Services 3");

//invoice3.Refund();
//invoice3.Cancel();


//Console.WriteLine();

#endregion State

#region Iterator

//var months = new Months();

//// fiscal month start in Jan by default
//Console.WriteLine("Fiscal month start in January:");
//var iterator = months.CreateIterator();
//while (iterator.MoveNext())
//{
//    Console.Write($"{iterator.Current} ");
//}

//Console.WriteLine();

//// fiscal month start in April
//Console.WriteLine("Fiscal month start in April:");
//months.FiscalMonthStart = 4;

//iterator = months.CreateIterator();
//while (iterator.MoveNext())
//{
//    Console.Write($"{iterator.Current} ");
//}
//Console.WriteLine();

#endregion Iterator

#region Observer

//var stock = new Stock("ABC", 100m);

//// Create two observers Display & Logger
//var display = new Display(stock);
//var logger = new Logger(stock, "stock.txt");

//// Change the price, both display and logger
//// will be notified and updated
//stock.Price += 2;
//stock.Price -= 1;

//Console.ReadLine();

//// remove the logger from the observer list
//stock.Unsubscribe(logger);

//// Change the price, only the display is notified 
//// and updated
//stock.Price += 3;

//Console.ReadLine();

#endregion Observer

#endregion Behavioral Patterns

#endregion Design Patterns

var asd = 1;
