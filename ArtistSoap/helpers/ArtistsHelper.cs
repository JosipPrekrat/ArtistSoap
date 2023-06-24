using ArtistSoap.models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace ArtistSoap.helpers
{
    public static class ArtistsHelper
    {

        //Konffigurirat ip adresu
        private static RestClient client = new RestClient(new RestClientOptions("http://192.168.1.37:8080"));

        public static string getXmlArtists()
        {
            var req = new RestRequest("artists");
            return client.Get(req).Content;
        }

        public static void createLocalXml(string path, string artistsXml)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(artistsXml);
                sw.Flush();
            }
        }

    }
}