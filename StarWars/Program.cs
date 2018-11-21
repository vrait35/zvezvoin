using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Newtonsoft.Json;
using Resources;

namespace StarWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 2;            
            StarWarsResponse starWarsResponse = new StarWarsResponse();
            int index = 3;
            List<People> peoples;
            List<People> peoples= starWarsResponse.Planet(index,peoples);




            //WebRequest planets = WebRequest.Create($"https://swapi.co/api/planets/{count}/");
            //WebResponse responsePlanet = planets.GetResponse();

            //WriteLine(planets);

            //Stream streamPlanet = responsePlanet.GetResponseStream();
            //StreamReader readerPlanet = new StreamReader(streamPlanet);
            //var resultPlanet = readerPlanet.ReadToEnd();

            //List<People> peoplesInPlanet = new List<People>();

            //Planet objectPlanet = JsonConvert.DeserializeObject<Planet>(resultPlanet);

            //if (objectPlanet.Residents.Count > 0)
            //{
            //    foreach (var item in objectPlanet.Residents)
            //    {
            //        WebRequest request = WebRequest.Create(item);
            //        WebResponse response = request.GetResponse();

            //        Stream stream = responsePlanet.GetResponseStream();
            //        StreamReader reader = new StreamReader(stream);
            //        var result = reader.ReadToEnd();

            //        People people = JsonConvert.DeserializeObject<People>(result);
            //        peoplesInPlanet.Add(people);
            //    }
            //}





            /////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////

            //WebRequest peopls = WebRequest.Create($"https://swapi.co/api/people/{count}/");
            //WebResponse responsePeopls = peopls.GetResponse();

            //Stream streamPeople = responsePeopls.GetResponseStream();
            //StreamReader readerPeople = new StreamReader(streamPeople);
            //var resultPeople = readerPeople.ReadToEnd();

            //People pl = JsonConvert.DeserializeObject<People>(resultPeople);



            ///////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////

            //WebRequest starships = WebRequest.Create($"https://swapi.co/api/planets/{count}/");
            //WebResponse responseStarships = starships.GetResponse();

            //Stream streamStarship = responseStarships.GetResponseStream();
            //StreamReader readerStarship = new StreamReader(streamStarship);
            //var resultStarship = readerStarship.ReadToEnd();

            //List<People> peoplesInStarship = new List<People>();

            //Starships objectStarship = JsonConvert.DeserializeObject<Starships>(resultStarship);

            //if (objectStarship.Pilots.Count > 0)
            //{
            //    foreach (var item in objectStarship.Pilots)
            //    {
            //        WebRequest request = WebRequest.Create(item);
            //        WebResponse response = request.GetResponse();

            //        Stream stream = response.GetResponseStream();
            //        StreamReader reader = new StreamReader(stream);
            //        var result = reader.ReadToEnd();

            //        People people = JsonConvert.DeserializeObject<People>(result);
            //        peoplesInStarship.Add(people);
            //    }
            //}


            ReadLine();
        }
    }
}
