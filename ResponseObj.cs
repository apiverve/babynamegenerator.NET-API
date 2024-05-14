using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class names
{
    [JsonProperty("firstName")]
    public string firstName { get; set; }

    [JsonProperty("middleName")]
    public string middleName { get; set; }

    [JsonProperty("fullName")]
    public string fullName { get; set; }

}

public class data
{
    [JsonProperty("count")]
    public int count { get; set; }

    [JsonProperty("names")]
    public names[] names { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
