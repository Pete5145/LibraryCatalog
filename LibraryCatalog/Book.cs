﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public bool CheckedOut { get; set; }

        public Book(string title, string author, int isbn, bool checkedOut)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            CheckedOut = checkedOut;
        }
    }
}
