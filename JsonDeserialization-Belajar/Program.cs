using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace JsonDeserialization_Belajar
{
    class Program
    {
        static void Main(string[] args)
        {
            var request = WebRequest.Create("http://echo.jsontest.com/name/AgungSetiawan/email/com.agungsetiawan@gmail.com/job/SoftwareEngineer");
            var response = request.GetResponse();

            Person person = null;

            using (var stream = response.GetResponseStream())
            {
                var serializer = new DataContractJsonSerializer(typeof(Person));
                person = (Person)serializer.ReadObject(stream);
            }

            Console.WriteLine("{0}, {1}, {2}",person.Name,person.Email,person.Job);



            Person p = new Person();
            p.Name = "A Name";
            p.Email = "An Email";
            p.Job = "A Job";

            var memoryStream = new MemoryStream();
            var ser = new DataContractJsonSerializer(typeof(Person));

            ser.WriteObject(memoryStream, p);
            memoryStream.Position = 0;

            StreamReader streamReader = new StreamReader(memoryStream);
            Console.WriteLine(streamReader.ReadToEnd());

            Console.ReadLine();
        }
    }
}
