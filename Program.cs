using System;
using System.Threading.Tasks;
using Azure;
using Azure.AI.OpenAI;

namespace OneShotExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Substitua pela sua chave de API do Azure OpenAI
            string apiKey = "";
            string endpoint = "";

            var client = new OpenAIClient(new Uri(endpoint), new AzureKeyCredential(apiKey));

            // Exemplo "one shot"
            string prompt = "Era uma vez um pequeno robô chamado";

            // Gerar texto com base no prompt
            var completionOptions = new CompletionsOptions
            {
                Prompts = { prompt },
                MaxTokens = 50,
                Temperature = 0.7
            };

            var response = await client.GetCompletionsAsync("text-davinci-003", completionOptions);

            // Exibir o resultado
            Console.WriteLine(response.Value.Choices.Text);
            Console.Read();
        }
    }
}
