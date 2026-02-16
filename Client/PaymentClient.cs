namespace MicroservicesSample.Client
{
    public class PaymentClient
    {
        private readonly HttpClient _httpClient;

        public PaymentClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> ProcessPayment(decimal amount)
        {
            var response = await _httpClient.PostAsync(
                $"https://localhost:7220/payment?amount={amount}",
                null);

            return response.IsSuccessStatusCode;
        }
    }

}
