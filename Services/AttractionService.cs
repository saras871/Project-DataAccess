namespace Services;
using Microsoft.Extensions.Logging;
using DbRepos;
using Models;
public class AttractionService : IAttractionService
{
  private readonly AttractionDbRepos _repo = null;
    private readonly ILogger<AttractionService> _logger = null;

    public AttractionService(AttractionDbRepos repo)
    {
        _repo = repo;
    }
    public AttractionService(AttractionDbRepos repo, ILogger<AttractionService> logger) : this(repo)
    {
        _logger = logger;
    }
}