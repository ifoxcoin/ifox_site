using ifox_site.Models;
using ifox_site.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

public class BlogController : Controller
{
    private readonly BlogService _blogService;

    public BlogController(BlogService blogService)
    {
        _blogService = blogService;
    }

    [Route("blog")]
    public IActionResult Index(int page = 1)
    {
        int pageSize = 9;

        var blogs = _blogService.GetAll()
                    .OrderByDescending(x => x.Date)
                    .ToList();

        var totalItems = blogs.Count();
        var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

        var pagedBlogs = blogs
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .Select(blog => new BlogViewModel
            {
                Title = blog.Title,
                Slug = blog.Slug,
                Image = blog.Image,
                ShortDescription = blog.ShortDescription,
                Date = blog.Date,
                HtmlFile = blog.HtmlFile
            }).ToList();

        ViewBag.CurrentPage = page;
        ViewBag.TotalPages = totalPages;

        return View(pagedBlogs);
    }


    [Route("blog/{slug}")]
    public IActionResult Details(string slug)
    {
        var blog = _blogService.GetBySlug(slug);

        if (blog == null)
            return NotFound();

        var vm = new BlogViewModel
        {
            Title = blog.Title,
            Slug = blog.Slug,
            Date = blog.Date,
            Author = blog.Author,
            Image = blog.Image,
            ShortDescription = blog.ShortDescription
        };

        return View(vm);
    }
}
