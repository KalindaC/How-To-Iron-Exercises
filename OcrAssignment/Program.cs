using IronOcr;

var ocr = new IronTesseract();

using(var input = new OcrInput())
{
    input.AddImage("C:/Users/kalin/source/repos/IronicAssignments/OcrAssignment/Assets/Images/img_5037.jpg");
    //input.AddPdf("book_page.pdf");

    OcrResult result = ocr.Read(input);
    string text = result.Text;
    result.SaveAsSearchablePdf("book_page.pdf")
}