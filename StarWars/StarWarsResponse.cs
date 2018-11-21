using Newtonsoft.Json;
using Resources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    public class StarWarsResponse
    {

        public Planet Planet(int index)
        {

            try
            {
                WebRequest planets = WebRequest.Create($"https://swapi.co/api/planets/{index}/");
                WebResponse responsePlanet = planets.GetResponse();

                Stream streamPlanet = responsePlanet.GetResponseStream();
                StreamReader readerPlanet = new StreamReader(streamPlanet);
                var resultPlanet = readerPlanet.ReadToEnd();

                List<People> peoplesInPlanet = new List<People>();

                Planet objectPlanet = JsonConvert.DeserializeObject<Planet>(resultPlanet);

                if (objectPlanet.Residents.Count > 0)
                {
                    foreach (var item in objectPlanet.Residents)
                    {
                        WebRequest request = WebRequest.Create(item);
                        WebResponse response = request.GetResponse();

                        Stream stream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(stream);
                        var result = reader.ReadToEnd();

                        People people = JsonConvert.DeserializeObject<People>(result);
                        peoplesInPlanet.Add(people);
                    }
                }

                return objectPlanet;
            }
            catch (WebException ex) when (ex.Response != null)
            {
                return null ;
            }
        }


        public People People(int index)
        {
            try
            {
                WebRequest peopls = WebRequest.Create($"https://swapi.co/api/people/{index}/");
                WebResponse responsePeopls = peopls.GetResponse();

                Stream streamPeople = responsePeopls.GetResponseStream();
                StreamReader readerPeople = new StreamReader(streamPeople);
                var resultPeople = readerPeople.ReadToEnd();

                People pl = JsonConvert.DeserializeObject<People>(resultPeople);

                return pl;
            }
            catch (WebException ex) when (ex.Response != null)
            {
                return null;
            }            
        }


        public Starships Starship(int index)
        {

            try
            {
                WebRequest starships = WebRequest.Create($"https://swapi.co/api/planets/{index}/");
                WebResponse responseStarships = starships.GetResponse();

                Stream streamStarship = responseStarships.GetResponseStream();
                StreamReader readerStarship = new StreamReader(streamStarship);
                var resultStarship = readerStarship.ReadToEnd();

                List<People> peoplesInStarship = new List<People>();

                Starships objectStarship = JsonConvert.DeserializeObject<Starships>(resultStarship);

                if (objectStarship.Pilots.Count > 0)
                {
                    foreach (var item in objectStarship.Pilots)
                    {
                        WebRequest request = WebRequest.Create(item);
                        WebResponse response = request.GetResponse();

                        Stream stream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(stream);
                        var result = reader.ReadToEnd();

                        People people = JsonConvert.DeserializeObject<People>(result);
                        peoplesInStarship.Add(people);
                    }
                }

                return objectStarship;
            }
            catch (WebException ex) when (ex.Response != null)
            {
                return null;
            }


        }


    }
}
