﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Library : IEnumerable<Book>
{
    private SortedSet<Book> books;

    public Library(params Book[] books)
    {
        this.books = new SortedSet<Book>(books);
    }


    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(this.books.ToList());
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private class LibraryIterator : IEnumerator<Book>
    {
        private  IReadOnlyList<Book> books;
        private int currentIndex;

        public LibraryIterator(IReadOnlyList<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }
        public bool MoveNext()
        {
            return ++this.currentIndex < this.books.Count;
        }

        public void Reset()
        {
            this.currentIndex = -1;
        }

        public Book Current => this.books[this.currentIndex];

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {

        }
    }
}
