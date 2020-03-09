namespace FriendLetter.Models
{
  public class LetterVariable
  {
    public string Recipient { get; set; }
    public string Sender { get; set; }

    public string Location { get; set; }
    public string Souvenir { get; set; }
    public static string TestRecipient { get; set; } = "LEIlaniiii";
    public static string GetTestRecipient()
    {
      return TestRecipient;
    }
  }

}