using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Providers
{
    public interface IPortfolioProvider
    {
        List<FileRecord> Files { get; }
    }

    public record FileRecord(string Src, string Title, string Alt, string Tags);

    public class PortfolioProvider : IPortfolioProvider, ITransientDependency
    {
        public PortfolioProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private string folder => Path.Combine(_configuration["ContentRoot"], @"images\portfolio\");

        public List<FileRecord> Files => _files.Select(
            x => new FileRecord(
                Src: x.Replace(folder, string.Empty),
                Title: "",
                Alt: "",
                Tags: GetRandomTags()))
            .ToList();

        private static List<string> _tags = new List<string> { ".pf-curtain-tracks", ".pf-curtain-poles", ".pf-curtains", ".pf-roman-blinds", ".pf-roller-blinds" };

        private static string GetRandomTags()
        {
            return _tags[RandomNumber(0, 5)].Replace(".", "");
        }

        public static int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private static readonly Random _random = new Random();
        private readonly IConfiguration _configuration;

        private string[] _files => Directory.GetFiles(folder);
    }
}
