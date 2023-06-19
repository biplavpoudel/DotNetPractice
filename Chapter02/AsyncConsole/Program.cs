HttpClient client = new();    //target-typed new
HttpResponseMessage response = await client.GetAsync("https://apple.com");
WriteLine("Apple's homepage has {0:N0} bytes.", response.Content.Headers.ContentLength);