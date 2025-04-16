//  HttpClientExtensions
//  ----------------------------------------------
//  Following extensions inlcudes extension methods for HttpClient. 
//  ----------------------------------------------
//  Created: 2018-08-21
//  Created by: Mikael Ekroth (mikael.kl.ekroth@gmail.com)
//
//  Copyright 2018  
using System.Net.Http;
using MultiSearch.Library.Models;
using Newtonsoft.Json;

namespace MultiSearch.Library.Extensions
{
    public static class HttpClientExtensions
    {
        /// <summary>
        /// Get deserialized response from http respense content.
        /// </summary>
        /// <returns>Deserialized object of defined type</returns>
        /// <param name="client">Client to handle the reqeust</param>
        /// <param name="url">URL to call.</param>
        /// <param name="error">Http response error.</param>
        /// <typeparam name="T">Type to deserialied to.</typeparam>
        public static T Get<T>(this HttpClient client, string url, out HttpError error)
        {
            var httpResponse = client.GetAsync(url).Result;
            var httpResponseContent = httpResponse.Content.ReadAsStringAsync().Result;
            error = null;

            if (httpResponse.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(httpResponseContent);
            }

            error = new HttpError
            {
                StatusCode = (int) httpResponse.StatusCode,
                Reason = httpResponse.ReasonPhrase,
                RawContent = httpResponseContent
            };
            return default(T);
        }
    }
}
