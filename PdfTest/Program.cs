
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

FontManager.RegisterFont(File.OpenRead("cruft.ttf"));
var doc = Document.Create(doc =>
    doc.Page(page =>
    {
        page.Size(PageSizes.A4);
        page.Margin(2,Unit.Centimetre);
        page.Header().Text("Test").FontFamily("Cruft").FontSize(72f);
    }));

doc.GeneratePdf("test.pdf");
            