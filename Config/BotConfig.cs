using Newtonsoft.Json;

namespace DiscordBotTemplateNet8.Config
{
    internal class BotConfig
    {
        public string DiscordBotToken { get; set; }
        public string DiscordBotPrefix { get; set; }

        public async Task ReadJSON()
        {
            using (StreamReader sr = new StreamReader($"{AppDomain.CurrentDomain.BaseDirectory}/config.json"))
            {
                string json = await sr.ReadToEndAsync();
                JSONStruct obj = JsonConvert.DeserializeObject<JSONStruct>(json);

                this.DiscordBotToken = obj.token;
                this.DiscordBotPrefix = obj.prefix;
            }
        }
    }
    internal sealed class JSONStruct
    {
        public string token { get; set; }
        public string prefix { get; set; }
    }
}
