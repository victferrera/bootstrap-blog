﻿using Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Models
{
    public class ListarPostsViewModelPaginated<Post> : List<Post>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public ListarPostsViewModelPaginated(List<Post> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

        public static async Task<ListarPostsViewModelPaginated<Post>> CreateAsync(IQueryable<Post> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new ListarPostsViewModelPaginated<Post>(items, count, pageIndex, pageSize);
        }
    }
}
