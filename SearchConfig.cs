using Newtonsoft.Json;
using System;

//using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
//using System.Text.Json.Serialization;

public class Rootobject
{
    public LogSearchConfig LogSearchConfig { get; set; }

    public override string ToString()
    {
        return string.Format(@"Searching for '{0}' in  {2}", LogSearchConfig.StringToSearch, Environment.NewLine, LogSearchConfig.LogPath);
    }
}

public class LogSearchConfig
{
   // [JsonProperty(Required = Required.Always)]
   [JsonInclude]
    public string LogPath { get; set; }

    //[JsonProperty(Required = Required.Always)]
    [JsonInclude]
    public string TextFileExtenstion { get; set; }

    //[JsonProperty(Required = Required.DisallowNull)]
    public string StringToSearch { get; set; }

    public object FileContents { get; private set; }
}
