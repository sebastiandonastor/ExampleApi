using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleApi.Models
{
    [Validator (typeof (QuoteValidator))]
    public class Quote
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public DateTime? createdAt { get; set; }

    }

     public class QuoteValidator: AbstractValidator<Quote>
    {
        public QuoteValidator()
        {
            RuleFor(q => q.Title)
                .NotEmpty()
                .Length(4, 40);

            RuleFor(q => q.Type)
                .NotEmpty()
                .Length(5, 15);


        }
    }
}