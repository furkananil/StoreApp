using System;
using System.Text.Json;
using Microsoft.AspNetCore.Session;

namespace StoreApp.Web.Helpers;

public static class SessionExtensions
{
    public static void SetJson(this ISession session, string key, object value)
    {
        session.SetString(key, JsonSerializer.Serialize(value)); // object to json
    }

    public static T? GetJson<T>(this ISession session, string key)
    {
        var sessionData = session.GetString(key); // json
        
        return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData); // json to object
    }
}
