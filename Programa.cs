using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using journeyofcode.Images.OnenoteOCR;

namespace OcrToText
{
    class Programa
    {
        static void Main(string[] args)
        {
            var imagePath = args.FirstOrDefault();
            if (String.IsNullOrWhiteSpace(imagePath) || !File.Exists(args[0]))
            {
                Console.WriteLine("Passo: {0} [Caminho do Arquivo de Imagem]", Path.GetFileName(Assembly.GetAssembly(typeof(Program)).CodeBase));
                return;
            }

            Console.WriteLine("Execução do OCR para Arquivo " + imagePath);
            try
            {
                using (var ocrEngine = new OnenoteOcrEngine())
                using (var image = Image.FromFile(imagePath))
                {
                    var text = ocrEngine.Recognize(image);
                    if (text == null)
                        Console.WriteLine("Não reconhecido");
                    else
                        Console.WriteLine("Reconhecido: " + text);
                }
            }
            catch (OcrException ex)
            {
                Console.WriteLine("Excessão de OCR:\n" + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excessão Geral:\n" + ex);
            }

            Console.ReadLine();
        }
    }
}