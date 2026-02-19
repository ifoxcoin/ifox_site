using ifox_site.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ifox_site.Services
{
    public class BlogService
    {
        private readonly IWebHostEnvironment _env;

        public BlogService(IWebHostEnvironment env)
        {
            _env = env;
        }

        private string FilePath =>
            Path.Combine(_env.WebRootPath, "blogdata", "blogs.json");

        public List<BlogViewModel> GetAll()
        {
            var json = File.ReadAllText(FilePath);

            return JsonSerializer.Deserialize<List<BlogViewModel>>(json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
        }


        public BlogViewModel GetBySlug(string slug)
        {
            return GetAll().FirstOrDefault(x => x.Slug == slug);
        }
    }
}
