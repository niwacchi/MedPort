using iTextSharp.text;
using iTextSharp.text.pdf;

namespace MedPort.Commons
{
    public class PdfHeaderFooterPage : PdfPageEventHelper
    {
        public void OnEnPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);

            PdfContentByte contentByte = writer.DirectContent;
            string pageNo = writer.PageNumber.ToString();
            Rectangle pageSize = document.PageSize;

            // ヘッダ出力
            contentByte.BeginText();
            contentByte.SetFontAndSize(HeaderFooterBaseFont(), 8);
            contentByte.SetTextMatrix(pageSize.GetLeft(40), pageSize.GetTop(30));
            contentByte.ShowTextAligned(Element.ALIGN_RIGHT, "ヘッダ", pageSize.Width - 20, pageSize.GetTop(30),0);
            contentByte.EndText();

            // フッタ出力
            contentByte.BeginText();
            contentByte.SetTextMatrix(pageSize.GetLeft(40),pageSize.GetBottom(30));
            contentByte.ShowTextAligned(Element.ALIGN_CENTER, pageNo, pageSize.Width / 2, pageSize.GetBottom(30),0);
            contentByte.EndText();
        }

        /// <summary>
        /// デフォルトフォント設定
        /// </summary>
        /// <returns></returns>
        private BaseFont HeaderFooterBaseFont()
        {
            BaseFont baseFont = BaseFont.CreateFont(
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software")
                    .OpenSubKey("Microsoft")
                    .OpenSubKey("Windows")
                    .OpenSubKey("CurrentVersion")
                    .OpenSubKey("Explorer")
                    .OpenSubKey("Shell Folders")
                    .GetValue("Fonts").ToString() + "\\msgothic.ttc,1",
                    BaseFont.IDENTITY_H,BaseFont.EMBEDDED);

            return baseFont;
        }
    }
}
