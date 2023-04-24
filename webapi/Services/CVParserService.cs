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
            var strategy = new LocationTextExtractionStrategy();

            var pdfPage = pdfDocument.GetPage(1);
            var content2 = strategy.GetResultantText();
            var content = PdfTextExtractor.GetTextFromPage(pdfPage, strategy);
            var nameRegex = new Regex(@"\b(\p{Lu}\p{Ll}+)\s+(\p{Lu}\p{Ll}+)\b");
            var match = nameRegex.Match(content);

            if (match.Success)
            {
                return (match.Groups[1].Value, match.Groups[2].Value);
            }

            return (null, null);
        }
    }
}
