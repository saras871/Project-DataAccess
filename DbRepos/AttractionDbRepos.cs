namespace DbRepos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DbModels;
using Models;
using DbContext;
public class AttractionDbRepos
{
    private ILogger<AttractionDbRepos> _logger;
    private readonly MainDbContext _dbContext;

    public AttractionDbRepos(ILogger<AttractionDbRepos> logger, MainDbContext context)
    {
        _logger = logger;
        _dbContext = context;
    }
}