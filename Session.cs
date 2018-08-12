using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using DocumentFormat.OpenXml.Packaging;
using System.IO;

namespace Klinik3
{
    public class Session
    {
        public static string Username;
        public static string Fullname;
        public static string Level;
        public static string Current_QID;
    }
    public class Test
    {
        //public static void TestOXML()
        //{
        //    var document = @"d:\A.docx";
        //    using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(document, true))
        //    {
        //        string docText = null;
        //        using (StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
        //        {
        //            docText = sr.ReadToEnd();
        //        }


        //        docText = docText.Replace("{test}", "Hi Everyone!");

        //        using (StreamWriter sw = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
        //        {
        //            sw.Write(docText);
        //        }
        //    }
        //}
    }


    public static class RTFHelper
    {
        public static void Replace(System.Windows.Forms.RichTextBox rtfbox, string findit, string replace)
        {

            var indx = rtfbox.Find(findit);
            if (indx != -1)
            {
                rtfbox.Select(indx, findit.Length);

                if (rtfbox.SelectedText != "")
                    rtfbox.SelectedText = replace;
            }
        }
    }

    

    public class QStatus
    {
        /// <summary>
        /// Waiting for treatment from doctor
        /// </summary>
        public const string QueueDoctor = "QD";
        /// <summary>
        /// Waiting for Medical/Payment
        /// </summary>
        public const string QueuePayment = "QP";
        /// <summary>
        /// Ended/inactive
        /// </summary>
        public const string QueueEnded = "QE";
        public const string InTreatment = "IT";

        public static string[] sqllist = new string[] {
        "select * from PAYTYPEnDATE",
        "select * from PAYTYPEnMONTH",
        };

    }

    
}
