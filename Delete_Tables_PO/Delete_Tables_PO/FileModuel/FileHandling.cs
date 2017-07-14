using System.IO;

namespace Delete_Tables_PO.FileModuel
{
    class FileHandling
    {
        #region Method
        // Write file
        public static void WriteFile(string[] strs, string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            if (strs.Length != 0)
            {
                foreach (var str in strs)
                {
                    if (!string.IsNullOrEmpty(str) && !string.IsNullOrWhiteSpace(str))
                    {
                        sw.WriteLine(str);
                    }
                }
            }
            sw.Close();
        }

        // Read file
        public static string[] ReadFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            return lines;
        }
        #endregion
    }
}
