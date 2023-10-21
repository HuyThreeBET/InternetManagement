using System.IO;

namespace ManagementInternet.Function
{
    internal class Helper
    {
        public string transferPassword(string passwordFromDB)
        {
            string[] substrings = passwordFromDB.Split(' ');

            return substrings[0];
        }

        // Open file in to a filestream and read data in a byte array.
        public byte[] readFile(string path)
        {
            // Initialize byte array with a null value initially.
            byte[] data = null;

            // Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(path);
            long numBytes = fInfo.Length;

            // Open FileStream to read file
            FileStream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            // Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            // When you use BinaryReader, you need to supply number of bytes to read from file.
            // In this case we want to read entire file. So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);
            return data;
        }
    }
}
