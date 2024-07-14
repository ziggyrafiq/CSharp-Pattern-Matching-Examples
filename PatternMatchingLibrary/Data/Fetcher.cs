using System.Net;

namespace PatternMatchingLibrary.Data;

public class Fetcher
{
    private readonly HttpClient _httpClient;

    public Fetcher(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    public async Task<string> FetchDataAsync(string url)
    {
        try
        {
            var response = await _httpClient.GetAsync(url);

            return response.StatusCode switch
            {
                HttpStatusCode.OK => await response.Content.ReadAsStringAsync(),
                HttpStatusCode.NotFound => throw new NotFoundException(),
                _ => throw new HttpRequestException($"Request failed with status code {response.StatusCode}")
            };
        }
        catch (HttpRequestException ex)
        {
            return $"HTTP Request Error: {ex.Message}";
        }
        catch (NotFoundException ex)
        {
            return $"Data Not Found Error: {ex.Message}";
        }
        catch (Exception ex)
        {
            return $"Error occurred: {ex.Message}";
        }
    }
}
