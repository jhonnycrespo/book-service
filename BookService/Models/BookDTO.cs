using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Right now, our web API exposes the database entities to the client. The client receives 
// data that maps directly to your database tables. However, that's not always a good idea. Sometimes 
// you want to change the shape of the data that you send to client. For example, you might want to:

// Remove circular references (see previous section).
// Hide particular properties that clients are not supposed to view.
// Omit some properties in order to reduce payload size.
// Decouple your service layer from your database layer.

// To accomplish this, you can define a data transfer object (DTO). A DTO is an object that 
// defines how the data will be sent over the network.

namespace BookService.Models
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
    }
}

namespace BookService.Models
{
    public class BookDetailDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string AuthorName { get; set; }
        public string Genre { get; set; }
    }
}