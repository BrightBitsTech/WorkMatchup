using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using webapi.Interfaces;
using Tesseract;
using Microsoft.ML;
using System.Linq;

namespace webapi.Services
{
    public class CVParserService : ICVParserService
    {
        private readonly HttpClient _httpClient;

        public CVParserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<(string FirstName, string LastName)> ExtractNameFromCVAsync(string cvUrl)
        {
            using var response = await _httpClient.GetAsync(cvUrl);
            await using var pdfStream = await response.Content.ReadAsStreamAsync();

            var pdfReader = new PdfReader(pdfStream);
            var pdfDocument = new PdfDocument(pdfReader);
            var nameRegex = new Regex(@"\b([A-Z][a-zęóąśłżźćń]+(?:-[A-Z][a-zęóąśłżźćń]+)?\s+)+([A-Z][a-zęóąśłżźćń]+(?:-[A-Z][a-zęóąśłżźćń]+)?\s+)+", RegexOptions.Multiline | RegexOptions.Compiled, TimeSpan.FromSeconds(1));

            var firstName = "";
            var lastName = "";

            for (int i = 1; i <= pdfDocument.GetNumberOfPages(); i++)
            {
                var pdfPage = pdfDocument.GetPage(i);
                var strategy = new SimpleTextExtractionStrategy();
                var content = PdfTextExtractor.GetTextFromPage(pdfPage, strategy);

                var match = nameRegex.Match(content);

                if (match.Success)
                {
                    firstName = match.Groups[1].Value.Trim();
                    lastName = match.Groups[2].Value.Trim();
                }
            }

            return (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName)) ? (firstName, lastName) : (null, null);
        }
    }
}
