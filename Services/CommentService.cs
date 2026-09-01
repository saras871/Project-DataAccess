namespace Services;
using Microsoft.Extensions.Logging;
using DbRepos;
using Models;
public class CommentService : ICommentService
{
  private readonly CommentDbRepos _repo = null;
    private readonly ILogger<CommentService> _logger = null;

    public CommentService(CommentDbRepos repo)
    {
        _repo = repo;
    }
    public CommentService(CommentDbRepos repo, ILogger<CommentService> logger) : this(repo)
    {
        _logger = logger;
    }
}