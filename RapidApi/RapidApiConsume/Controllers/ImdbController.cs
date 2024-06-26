﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RapidApiConsume.Controllers
{
    public class ImdbController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ApiMovieViewModel> apiMovieViewModels = new List<ApiMovieViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get, //Methodun Türü
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"), //İstek yapılacak adres
                Headers =
    {
        { "X-RapidAPI-Key", "630ce9cc86msh271c60cffe62d5ep1b514djsn0fe292593744" }, //İlgili Api'ye istekte bulunurken kullanılacak key
        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },  //Api sağlayıcısının linki
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apiMovieViewModels = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
                return View(apiMovieViewModels);
            }
        }
    }
}
