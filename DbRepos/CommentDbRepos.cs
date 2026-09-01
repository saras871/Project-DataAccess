namespace DbRepos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DbModels;
using Models;
using DbContext;
public class CommentDbRepos
{
    private ILogger<CommentDbRepos> _logger;
    private readonly MainDbContext _dbContext;

    public CommentDbRepos(ILogger<CommentDbRepos> logger, MainDbContext context)
    {
        _logger = logger;
        _dbContext = context;
    }
}