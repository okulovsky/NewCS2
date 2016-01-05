using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Compression;
using System.IO;

namespace S05
{

    class Program
    {
        public static void MainX()
        {
            var Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. ";
            for (int i = 0; i < 10; i++) Text += Text;
            var memoryStream = new MemoryStream();
            var compressedStream = new GZipStream(memoryStream, CompressionMode.Compress);
            var writer = new StreamWriter(compressedStream);
            writer.WriteLine(Text);
            writer.Close();

            Console.WriteLine("Начальная длина - {0}",Text.Length);
            var buffer = memoryStream.GetBuffer();
            Console.WriteLine("Длина после сжатия - {0}", buffer.Length);

            Console.WriteLine();

            for (int i = 0; i < 100; i++)
                Console.Write((char)buffer[i]);

            Console.WriteLine();

            memoryStream = new MemoryStream(buffer);
            var decompressedStream = new GZipStream(memoryStream, CompressionMode.Decompress);
            var reader = new StreamReader(decompressedStream);
            var line = reader.ReadLine();
            Console.WriteLine(line == Text ? "OK" : "FAIL");

        }

    }
}