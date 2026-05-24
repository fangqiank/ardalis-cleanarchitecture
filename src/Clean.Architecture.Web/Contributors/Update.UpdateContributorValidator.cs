using Clean.Architecture.Core.ContributorAggregate;
using FastEndpoints;
using FluentValidation;

namespace Clean.Architecture.Web.Contributors;

public class UpdateContributorValidator : Validator<UpdateContributorRequest>
{
  public UpdateContributorValidator()
  {
    RuleFor(x => x.Name)
      .NotEmpty()
      .WithMessage("Name is required.")
      .MinimumLength(2)
      .MaximumLength(ContributorName.MaxLength);
    RuleFor(x => x.ContributorId)
      .Must((args, contributorId) => args.Id == contributorId)
      .WithMessage("Route and body Ids must match; cannot update Id of an existing resource.");
  }
}
