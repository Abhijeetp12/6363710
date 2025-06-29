using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory pdfFactory = new PdfDocumentFactory();
            IDocument pdfDocument = pdfFactory.CreateDocument();
            pdfDocument.Open();

            DocumentFactory wordFactory = new WordDocumentFactory();
            IDocument wordDocument = wordFactory.CreateDocument();
            wordDocument.Open();

            DocumentFactory excelFactory = new ExcelDocumentFactory();
            IDocument excelDocument = excelFactory.CreateDocument();
            excelDocument.Open();
        }
    }
}