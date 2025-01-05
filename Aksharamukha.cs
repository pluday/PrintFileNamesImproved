using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime; // Add this for Python.NET

namespace PrintFileNames
{
    public class Aksharamukha
    {
        public static string ConvertIASTtoKannada(string text)
        {
            string result = string.Empty;

            try
            {
                // Initialize Python runtime (only needs to be done once in your application)
                if (!PythonEngine.IsInitialized)
                {
                    PythonEngine.Initialize();
                }

                // Acquire the Python Global Interpreter Lock (GIL)
                using (Py.GIL())
                {
                    // Import the Aksharamukha Python library
                    dynamic aksharamukha = Py.Import("aksharamukha.transliterate");

                    // Access the transliteration process function
                    dynamic process = aksharamukha.Process;

                    // Perform transliteration from IAST to Kannada
                    result = process("IAST", "Kannada", text).ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while transliterating: {ex.Message}");
            }

            return result;
        }
    }
}
