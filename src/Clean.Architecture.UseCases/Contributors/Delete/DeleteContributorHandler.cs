using Clean.Architecture.Core.Interfaces;

namespace Clean.Architecture.UseCases.Contributors.Delete;

public class DeleteContributorHandler(IDeleteContributorService _deleteContributorService)
  : ICommandHandler<DeleteContributorCommand, Result>
{
  public async ValueTask<Result> Handle(DeleteContributorCommand request, CancellationToken cancellationToken) =>
    await _deleteContributorService.DeleteContributor(request.ContributorId);
}
