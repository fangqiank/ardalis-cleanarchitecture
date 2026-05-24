namespace Clean.Architecture.Infrastructure.Email;

public class MailserverConfiguration()
{
  public string Hostname { get; set; } = "localhost";
  public int Port { get; set; } = 25;
  public bool UseSsl { get; set; } = false;
}
