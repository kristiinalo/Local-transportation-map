using System;

//namespace Sample
{
    class Test
    {
 //       public static void Main(string[] args)
        {
  //          Console.WriteLine("C# is cool");
        }
    }
}


// Declare url

var url = "https://transport.tallinn.ee/gps.txt";

// Optional: Specify request options
var options = new Utils.WebRequest.Options()
{
    UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:88.0) Gecko/20100101 Firefox/88.0",
    Headers = new System.Net.WebHeaderCollection() {
        {"key", "value"}
    }
};

// Execute a get request at the following url
var response = await Utils.WebRequest.GetAsync(url);

// Display the status code and response body
Console.WriteLine($@"
    Status: {(int)response.Result.StatusCode} - {response.Result.StatusDescription}
    Bytes Received: {response.Bytes.Length}
    Body: {response.Body}
");
