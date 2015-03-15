using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedPort.Commons;

namespace PdfViewer.Models
{
    public class Pdf
    {
        public List<string> path { get { return GetPdfList(); } }

        private List<string> GetPdfList()
        {
            FileSearch fileSearch = new FileSearch();
            return fileSearch.GetPdfList(ConfigurationUtiliy.GetConfigValue("PdfRootDir"), "");
        }
    }
}