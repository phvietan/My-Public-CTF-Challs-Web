using Newtonsoft.Json;
public class Challenge
{
    [JsonProperty("id")]
    public int id { get; private set; } = -1;

    [JsonProperty("name")]

    public string name { get; private set; } = "";

    [JsonProperty("description")]
    public string description { get; private set; } = "";

    [JsonProperty("difficulty")]
    public int difficulty { get; private set; } = 0;

    [JsonProperty("icon")]
    public string icon { get; private set; } = "";

}
