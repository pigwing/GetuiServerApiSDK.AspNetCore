using System;
using System.Collections.Generic;
using System.Text;
using GetuiServerApiSDK.AspNetCore.RequestModels;

namespace GetuiServerApiSDK.AspNetCore.Clients
{
    public static class CommonMessageGenerator
    {
        private static CommonMessage PushSingleBase(string title = null, string body = null, string transmission = null)
        {

            CommonMessage commonMessage = new CommonMessage();
            if (string.IsNullOrEmpty(transmission))
            {
                commonMessage.PushMessage = new PushMessage()
                {
                    Notification = new Notification()
                    {
                        Title = title,
                        Body = body
                    },
                    Transmission = transmission
                };
            }
            else
            {
                commonMessage.PushMessage = new PushMessage()
                {
                    Transmission = transmission
                };
            }

            return commonMessage;
        }

        public static CommonMessage PushSingleClientIdNotificationBase(string clientId, string title, string body)
        {
            CommonMessage commonMessage = PushSingleBase(title, body, string.Empty);

            commonMessage.Audience = new Audience()
            {
                ClientId = new[] {clientId}
            };

            return commonMessage;
        }

        public static CommonMessage PushSingleClientIdTransmissionBase(string clientId, string transmission)
        {
            CommonMessage commonMessage = PushSingleBase(transmission: transmission);

            commonMessage.Audience = new Audience()
            {
                ClientId = new[] { clientId }
            };

            return commonMessage;
        }

        public static CommonMessage PushSingleAliasNotificationBase(string alias, string title, string body)
        {
            CommonMessage commonMessage = PushSingleBase(title, body, string.Empty);

            commonMessage.Audience = new Audience()
            {
                Alias = new []{alias}
            };

            return commonMessage;
        }

        public static CommonMessage PushSingleAliasTransmissionBase(string alias, string transmission)
        {
            CommonMessage commonMessage = PushSingleBase(transmission: transmission);

            commonMessage.Audience = new Audience()
            {
                Alias = new[] {alias}
            };

            return commonMessage;
        }
    }
}
