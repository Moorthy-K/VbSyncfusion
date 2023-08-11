Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Graphics

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Create a new PDF document.
        Dim document As New PdfDocument()
        'Set the page size.
        document.PageSettings.Size = PdfPageSize.A4
        'Add a page to the document
        Dim page As PdfPage = document.Pages.Add()

        'Create PDF graphics for the page.
        Dim graphics As PdfGraphics = page.Graphics
        'Set the font.
        Dim font As PdfFont = New PdfStandardFont(PdfFontFamily.Helvetica, 20)
        'Draw the text.
        graphics.DrawString("Hello World!!!", font, PdfBrushes.Black, New PointF(0, 0))

        'Save the document.
        document.Save("Output.pdf")
        'Close the document.
        document.Close(True)
    End Sub
End Class
