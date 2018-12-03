using DemoTDCPadroes.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DemoTDCPadroes.Reconhecimento
{
    public class ComparadorDePadroes
    {
        private string _key;
        private string uri = "https://southcentralus.api.cognitive.microsoft.com/customvision/v1.1/Prediction/";
        private HttpClient _client;

        public ComparadorDePadroes(string key)
        {
            _key = key;
            _client = new HttpClient
            {
                BaseAddress = new Uri(uri)
            };

            _client.DefaultRequestHeaders.Add("Prediction-key", _key);
        }

        public ResultadoDoReconhecimento ReconhecerImagem(string projectId, string iterationId, FileStream imageStream)
        {
            using (var content = new ByteArrayContent(ToByteArray(imageStream)))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                var response = _client.PostAsync($"{projectId}/image?iterationId={iterationId}", content).Result;

                var result = response.Content.ReadAsStringAsync().Result;

                var tudoReconhecido = JsonConvert.DeserializeObject<ResultadoDoReconhecimento>(result);

                return tudoReconhecido;
            }
        }

        private byte[] ToByteArray(FileStream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}
