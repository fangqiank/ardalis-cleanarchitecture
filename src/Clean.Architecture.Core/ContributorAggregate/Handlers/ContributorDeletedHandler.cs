using Clean.Architecture.Core.ContributorAggregate.Events;
using Clean.Architecture.Core.Interfaces;

namespace Clean.Architecture.Core.ContributorAggregate.Handlers;

public class ContributorDeletedHandler(ILogger<ContributorDeletedHandler> logger,
  IEmailSender emailSender) : INotificationHandler<ContributorDeletedEvent>
{
  // TODO: Replace with configurable email addresses for production use
  private const string NotificationRecipient = "to@test.com";
  private const string NotificationSender = "from@test.com";

  public async ValueTask Handle(ContributorDeletedEvent domainEvent, CancellationToken cancellationToken)
  {
    logger.LogInformation("Handling Contributed Deleted event for {contributorId}", domainEvent.ContributorId);

    await emailSender.SendEmailAsync(NotificationRecipient,
                                     NotificationSender,
                                     "Contributor Deleted",
                                     $"Contributor with id {domainEvent.ContributorId} was deleted.");
  }
}
