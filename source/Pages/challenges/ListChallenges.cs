using Newtonsoft.Json;
public class ListChallenges
{
    public List<Challenge> challenges { get; private set; } = new List<Challenge>();

    public ListChallenges(string filePathChallenges)
    {
        try
        {
            string content = Helper.ReadFileContent(filePathChallenges);
            this.challenges = JsonConvert.DeserializeObject<List<Challenge>>(content);
        }
        catch (Exception e)
        {
            this.challenges = null;
        }
    }
}
