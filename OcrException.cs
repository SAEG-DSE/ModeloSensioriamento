using System;
using System.Runtime.Serialization;

namespace journeyofcode.Images.OnenoteOCR
{
    [Serializable]
    public class OcrException
        : Exception
    {
        public OcrException()
            : this("Erro Geral durante o processo de OCR.")
        {
            
        }

        public OcrException(string message) : base(message)
        {
        }

        public OcrException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OcrException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}