using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.DesignPatterns.Creational
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.
    public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }
    // The Concrete Builder classes follow the Builder interface and provide
    // specific implementations of the building steps. Your program may have
    // several variations of Builders, implemented differently.
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new();

        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public ConcreteBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _product = new Product();
        }

        // All production steps work with the same product instance.
        public void BuildPartA()
        {
            _product.Add("PartA1");
        }

        public void BuildPartB()
        {
            _product.Add("PartB1");
        }

        public void BuildPartC()
        {
            _product.Add("PartC1");
        }

        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public Product GetProduct()
        {
            Product result = _product;

            Reset();

            return result;
        }
    }
    // It makes sense to use the Builder pattern only when your products are
    // quite complex and require extensive configuration.
    //
    // Unlike in other creational patterns, different concrete builders can
    // produce unrelated products. In other words, results of various builders
    // may not always follow the same interface.
    public class Product
    {
        private readonly List<object> _parts = new();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < _parts.Count; i++)
            {
                str += _parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }
    }

    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // The Director can construct several product variations using the same
        // building steps.
        public void BuildMinimalViableProduct()
        {
            _builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }
    }







    //How do you implement a C# Builder pattern? Real-world code example in C#//
    interface IBlogPostBuilder
    {
        void AddTitle(string title);
        void AddContent(string body);
        void AddAuthor(string author);
        void AddDate(DateTime date);
        void AddCategory(string category);
        void AddTags(IEnumerable<string> tags);
        void AddMetadataTitle(string title);
        void AddMetadataDescription(string description);
        BlogPostSettings Build();
    }
    class BlogPostSettings
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public IList<string> Categories { get; set; }
        public IList<string> Tags { get; set; }
        public string MetaDescription { get; set; }
        public string MetadataTitle { get; set; }
    }
    class BlogPostBuilder : IBlogPostBuilder
    {
        private BlogPostSettings _blogPostSettings = new BlogPostSettings();

        public BlogPostBuilder()
        {
            _blogPostSettings.Categories = new List<string>();
            _blogPostSettings.Tags = new List<string>();
        }

        public void AddTitle(string title)
        {
            _blogPostSettings.Title = title;
        }

        public void AddContent(string body)
        {
            _blogPostSettings.Content = body;
        }

        public void AddAuthor(string author)
        {
            _blogPostSettings.Author = author;
        }

        public void AddDate(DateTime date)
        {
            _blogPostSettings.Date = date;
        }

        public void AddCategory(string category)
        {
            _blogPostSettings.Categories.Add(category);
        }

        public void AddTags(IEnumerable<string> tags)
        {
            _blogPostSettings.Tags = tags.ToList();
        }

        public void AddMetadataTitle(string title)
        {
            _blogPostSettings.MetadataTitle = title;
        }

        public void AddMetadataDescription(string description)
        {
            _blogPostSettings.MetaDescription = description;
        }

        public BlogPostSettings Build()
        {
            return _blogPostSettings;
        }
    }

}