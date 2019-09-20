using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace BasicSearchAppCSharp.Controllers
{
    public class PatientsController : ApiController
    {
        [Route("api/patients/search")]
        [HttpGet]
        public List<Patient> SearchPatients(string query)
        {
            Patient p1 = new Patient();
            p1.SetId(1000000L);
            p1.SetName("Mary TestPerson");
            List<string> docs = new List<string>();
            docs.Add("Patient Note:::6/20/2010:::" + Resource("Mary_1"));
            docs.Add("Patient Note:::6/20/2010:::" + Resource("Mary_2"));
            p1.SetDocuments(docs);

            Patient p2 = new Patient();
            p2.SetId(1000001L);
            p2.SetName("Joe TestPerson");
            List<string> docs2 = new List<string>();
            docs2.Add("Clinical Note:::4/6/2010:::" + Resource("Joe_1"));
            docs2.Add("Summary:::7/2/2010:::" + Resource("Joe_2"));
            p2.SetDocuments(docs2);

            Patient p3 = new Patient();
            p3.SetId(1000002L);
            p3.SetName("Sam TestPerson");
            List<string> docs3 = new List<string>();
            docs3.Add("Patient Note:::8/3/2012:::" + Resource("Sam_1"));
            p3.SetDocuments(docs3);

            List<Patient> results = new List<Patient>();
            results.Add(p1);
            results.Add(p2);
            results.Add(p3);

            return results;
        }

        private string Resource(string fileName)
        {
            StringBuilder fileContents = new StringBuilder();
            string path = @"c:\resources\documents\";

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(path + fileName + ".txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    string line = sr.ReadToEnd();
                    fileContents.AppendLine(line);
                }
            }
            catch (IOException e)
            {
                Debug.WriteLine("The file could not be read:");
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return fileContents.ToString();
        }

        public class Patient
        {
            private long id;
            private string name;
            private List<string> documents; // id ::: date ::: contents

            public Patient()
            {
                documents = new List<string>();
            }

            public static Patient create()
            {
                return new Patient();
            }

            public long GetId()
            {
                return id;
            }

            public void SetId(long id)
            {
                this.id = id;
            }

            public string GetName()
            {
                return name;
            }

            public void SetName(string name)
            {
                this.name = name;
            }

            public List<string> GetDocuments()
            {
                return documents;
            }

            public void SetDocuments(List<string> documents)
            {
                this.documents = documents;
            }

            public override string ToString()
            {
                string allDocuments = "\r\n";
                int count = 1;
                foreach(var doc in documents)
                {
                    allDocuments += ("===== Document" + count++ + " =====\r\n" + doc + "\r\n=====    END    =====\r\n");
                }
                return "Id: " + GetId() + "\r\nName: " + GetName() + "\r\nDocuments: " + allDocuments;
            }

        }
    }
}
