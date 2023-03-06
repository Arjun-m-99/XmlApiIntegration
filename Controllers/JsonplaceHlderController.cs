using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RezLiveApis.Models;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Twilio.TwiML;

namespace RezLiveApis.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    
    public class JsonplaceHlderController : ControllerBase
    {
        [HttpGet("/posts")]
        public IActionResult GetPosts()
        {
            try
            {
                HttpClient client= new HttpClient();
                client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("/posts").Result;

                if (response.IsSuccessStatusCode)
                {
                    return Ok(response.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    return BadRequest(response.Content);
                }
               
            }catch(Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpGet("/Traveler")]
        public async Task<ActionResult> GetHolidays()
        {
            try
            {
                HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri("http://restapi.adequateshop.com/api");
                client.BaseAddress = new Uri("http://restapi.adequateshop.com/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

                HttpResponseMessage response = await client.GetAsync("Traveler");
                //HttpResponseMessage response = await client.GetAsync("http://restapi.adequateshop.com/api/Traveler");

//                var xml = @"
//<Invoice>
//    <Timestamp>1/1/2017 00:01</Timestamp>
//    <CustNumber>12345</CustNumber>
//    <AcctNumber>54321</AcctNumber>
//</Invoice>";
                XmlDocument doc = new XmlDocument();
                //doc.LoadXml(response.ToString());
                //var json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.None, true);

                if (response.IsSuccessStatusCode)
                {

                    return Ok(response.Content.ReadAsStringAsync().Result);
                    //return Ok(xml);
                }
                else
                {
                    return BadRequest(response.Content);
                    //return BadRequest(xml);
                }

            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpPost("/findHotel")]
        public async Task<ActionResult> findHotel(HotelFindRequest findHotel)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Accept", "application/xml");
                //var request = new HttpRequestMessage(HttpMethod.Post, "http://test.xmlhub.com/testpanel.php/action/findhotel");
                string xml = "";
                XmlSerializer serializer = new XmlSerializer(typeof(HotelFindRequest));
                await using (var stringWriter = new Utf8StringWriter())
                {
                    await using (XmlWriter writer = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Async = true }))
                    {
                        serializer.Serialize(writer, findHotel);
                        xml = stringWriter.ToString(); // Your XML
                    }
                }

                HttpContent body = new StringContent(xml, Encoding.UTF8, "application/xml");
                var response = client.PostAsync("http://test.xmlhub.com/testpanel.php/action/findhotel", body).Result;
                
                if (response.IsSuccessStatusCode)
                {

                    var content = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(content))
                    {
                        // Deserializing Response from XML to Object
                        XmlSerializer responseserializer = new XmlSerializer(typeof(HotelFindRequest));
                        using (StringReader reader = new StringReader(content))
                        {
                            var responsesong = (HotelFindRequest)responseserializer.Deserialize(reader);
                            return Ok(responsesong);
                        }
                        return BadRequest(responseserializer);
                    }

                    return Ok(response.Content.ReadAsStringAsync().Result);
                    //return Ok(xml);
                }
                else
                {
                    return BadRequest(response.Content);
                }

            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }


    }
}
