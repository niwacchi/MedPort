using System.Collections.Generic;
using System.IO;

namespace MedPort.Commons
{
    public class FileSearch
    {
        public List<string> GetPdfList(string rootDir, string patientId)
        {
            List<string> ret = new List<string>();

            if(Directory.Exists(rootDir))
            {
                foreach(string file in Directory.GetFiles(rootDir, "*.pdf", SearchOption.AllDirectories))
                {
                    ret.Add(file);
                }
            }

            return ret;
        }
    }
}
