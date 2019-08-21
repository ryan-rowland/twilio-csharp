/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.FlexApi.V1;

namespace Twilio.Tests.Rest.FlexApi.V1
{

    [TestFixture]
    public class ChannelTest : TwilioTest
    {
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.FlexApi,
                "/v1/Channels",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ChannelResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://flex-api.twilio.com/v1/Channels?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://flex-api.twilio.com/v1/Channels?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"flex_chat_channels\"},\"flex_chat_channels\": [{\"flex_flow_sid\": \"FOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"task_sid\": \"WTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"user_sid\": \"USaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2016-08-01T22:10:40Z\",\"date_updated\": \"2016-08-01T22:10:40Z\",\"url\": \"https://flex-api.twilio.com/v1/Channels/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}]}"
                                     ));

            var response = ChannelResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://flex-api.twilio.com/v1/Channels?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://flex-api.twilio.com/v1/Channels?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"flex_chat_channels\"},\"flex_chat_channels\": []}"
                                     ));

            var response = ChannelResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.FlexApi,
                "/v1/Channels/CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ChannelResource.Fetch("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"flex_flow_sid\": \"FOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"task_sid\": \"WTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"user_sid\": \"USaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2016-08-01T22:10:40Z\",\"date_updated\": \"2016-08-01T22:10:40Z\",\"url\": \"https://flex-api.twilio.com/v1/Channels/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = ChannelResource.Fetch("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.FlexApi,
                "/v1/Channels",
                ""
            );
            request.AddPostParam("FlexFlowSid", Serialize("FOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"));
            request.AddPostParam("Identity", Serialize("identity"));
            request.AddPostParam("ChatUserFriendlyName", Serialize("chat_user_friendly_name"));
            request.AddPostParam("ChatFriendlyName", Serialize("chat_friendly_name"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ChannelResource.Create("FOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "chat_user_friendly_name", "chat_friendly_name", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"flex_flow_sid\": \"FOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"task_sid\": \"WTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"user_sid\": \"USaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2016-08-01T22:10:40Z\",\"date_updated\": \"2016-08-01T22:10:40Z\",\"url\": \"https://flex-api.twilio.com/v1/Channels/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = ChannelResource.Create("FOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "chat_user_friendly_name", "chat_friendly_name", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.FlexApi,
                "/v1/Channels/CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ChannelResource.Delete("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = ChannelResource.Delete("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}