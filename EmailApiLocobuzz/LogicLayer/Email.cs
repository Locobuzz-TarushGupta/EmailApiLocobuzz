using Mailjet.Client;
using Mailjet.Client.Resources;
using System;
using Newtonsoft.Json.Linq;
using System.ComponentModel.Design.Serialization;

namespace EmailApiLocobuzz.LogicLayer
{
    public class Email
    {
        //   CODE FOR TEMPLATE
        /*

        public static async Task<string> RunAsync()
        {
           MailjetClient client = new MailjetClient("API_PUBLIC_KEY", "API_PRIVATE_KEY")
{
    Version = ApiVersion.V3_1,
};

MailjetRequest request = new MailjetRequest
{
    Resource = SendV31.Resource,
}
.Property(Send.Messages, new JArray {
    new JObject {
        {
            "From", new JObject {
                {"Email", "sender@example.com"},
                {"Name", "Sender Name"},
            }
        },
        {
            "To", new JArray {
                new JObject {
                    {"Email", "recipient@example.com"},
                    {"Name", "Recipient Name"},
                }
            }
        },
        {
            "TemplateID", 123456
        },
        {
            "TemplateLanguage", true
        },
        {
            "Subject", "Test Email using Template"
        },
        {
            "Variables", new JObject {
                {"name", "John Doe"}
            }
        }
    }
});

MailjetResponse response = await client.PostAsync(request);

if (response.IsSuccessStatusCode)
{
    Console.WriteLine("Email sent successfully");
}
else
{
    Console.WriteLine("Error sending email: {0}", response.GetData());
}
        }
        */

        public static async Task RunAsync()
        {
            MailjetClient client = new MailjetClient("API_PUBLIC_KEY", "API_PRIVATE_KEY");
            MailjetRequest request = new MailjetRequest
            {
                Resource = SendV31.Resource,
            }
             .Property(Send.Messages, new JArray {
     new JObject {
      {
       "From",
       new JObject {
        {"Email", "tarush.gupta@locobuzz.com"},
        {"Name", "Tarush"}
       }
      }, {
       "To",
       new JArray {
        new JObject {
         {
          "Email",
          "tarush.gupta@locobuzz.com"
         }, {
          "Name",
          "Tarush"
         }
        }
       }
      }, {
       "Subject",
       "Greetings from Mailjet."
      }, {
       "TextPart",
       "My first Mailjet email"
      }, {
       "HTMLPart",
       "<h3>Dear passenger 1, welcome to <a href='https://www.mailjet.com/'>Mailjet</a>!</h3><br />May the delivery force be with you!"
      }, {
       "CustomID",
       "AppGettingStartedTest"
      }
     }
             });
            MailjetResponse response = await client.PostAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(string.Format("Total: {0}, Count: {1}\n", response.GetTotal(), response.GetCount()));
                Console.WriteLine(response.GetData());
            }
            else
            {
                Console.WriteLine(string.Format("StatusCode: {0}\n", response.StatusCode));
                Console.WriteLine(string.Format("ErrorInfo: {0}\n", response.GetErrorInfo()));
                Console.WriteLine(response.GetData());
                Console.WriteLine(string.Format("ErrorMessage: {0}\n", response.GetErrorMessage()));
            }
        }


    };
}
