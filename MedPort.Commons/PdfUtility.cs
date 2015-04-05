using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace MedPort.Commons
{
    public class PdfUtility
    {
        public PdfUtility(){}

        public void CreatePdf(string pdfName)
        {
            // iTextドキュメント設定
            Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
            PdfWriter iPdfWriter = PdfWriter.GetInstance(doc, new FileStream(pdfName, FileMode.Create));

            Rectangle pageSize = doc.PageSize;
            iPdfWriter.SetBoxSize("art", new Rectangle(36, 50, pageSize.Width - 50, pageSize.Height - 50));

            // フォント設定
            Font font = new Font(DefaultBaseFont(), 12, Font.NORMAL);
            Font fontRed = new Font(DefaultBaseFont(), 12, Font.NORMAL, BaseColor.RED);

            // ヘッダ / フッタ設定
            PdfHeaderFooterPage events = new PdfHeaderFooterPage();
            iPdfWriter.PageEvent = events;

            // 出力開始
            doc.Open();

            // 出力ファイルに説明を付与
            doc.AddAuthor("作成者");
            doc.AddSubject("iTextサンプル");

            // 要素を追加
            doc.Add(new Paragraph("おはよう", font));
            doc.Add(new Paragraph("おはよう", fontRed));

            // 出力終了
            doc.Close();

        }

        public void DrawLine()
        {
        }




        /// <summary>
        /// デフォルトフォント設定
        /// </summary>
        /// <returns></returns>
        private BaseFont DefaultBaseFont()
        {
            //BaseFont baseFont = BaseFont.CreateFont(
            //    Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software")
            //        .OpenSubKey("Microsoft")
            //        .OpenSubKey("Windows")
            //        .OpenSubKey("CurrentVersion")
            //        .OpenSubKey("Explorer")
            //        .OpenSubKey("Shell Folders")
            //        .GetValue("Fonts").ToString() + "\\msgothic.ttc,1",
            //        BaseFont.IDENTITY_H,BaseFont.EMBEDDED);

            BaseFont baseFont = BaseFont.CreateFont("C:\\windows\\fonts\\msgothic.ttc,1",BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            return baseFont;
        }
    }
}
