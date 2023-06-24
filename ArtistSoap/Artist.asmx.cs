using ArtistSoap.helpers;
using ArtistSoap.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace ArtistSoap
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Artist : System.Web.Services.WebService
    {

        private const string XML_PATH = "C:\\Users\\Josip\\Desktop\\PPPK\\Movies_JosipPrekrat\\ArtistSoap\\ArtistSoap\\artists.xml";

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string FindByName(string name)
        {
            string artists = ArtistsHelper.getXmlArtists();
            ArtistsHelper.createLocalXml(XML_PATH, artists);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(artists);

            XmlNodeList nodes = doc.SelectNodes($"artists/artist[contains(./first_name, '{name}')]");
            StringBuilder sb = new StringBuilder();
            foreach (XmlNode node in nodes)
            {
                sb.AppendLine(node.OuterXml);
            }

            return sb.ToString();
        }

        [WebMethod]
        public string GetAll()
        {
            string artists = ArtistsHelper.getXmlArtists();
            ArtistsHelper.createLocalXml(XML_PATH, artists);
            return artists;
        }
    }
}
