﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plivo.API
{
    // Generic Models
    public class GenericResponse
    {
        public string message { get; set; }
        public string error { get; set; }
        public string api_id { get; set; }
    }

    public class Record
    {
        public string url { get; set; }
        public string message { get; set; }
        public string error { get; set; }
        public string api_id { get; set; }
    }

    // Account Models
    public class Account
    {
        public string city { get; set; }
        public string name { get; set; }
        public string cash_credits { get; set; }
        public string created { get; set; }
        public string enabled { get; set; }
        public string modified { get; set; }
        public string error { get; set; }
        public string api_id { get; set; }
        public string postpaid { get; set; }
        public string state { get; set; }
        public string address { get; set; }
        public string timezone { get; set; }
        public string auth_id { get; set; }
        public string resource_uri { get; set; }
    }

    public class SubAccountMeta
    {
        public object previous { get; set; }
        public int total_count { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
    }

    public class SubAccount
    {
        public string account { get; set; }
        public string name { get; set; }
        public string created { get; set; }
        public bool enabled { get; set; }
        public string modified { get; set; }
        public string auth_id { get; set; }
        public string resource_uri { get; set; }
        public string error { get; set; }
        public string api_id { get; set; }
    }

    public class SubAccountList
    {
        public SubAccountMeta meta { get; set; }
        public string error { get; set; }
        public string api_id { get; set; }
        public List<SubAccount> objects { get; set; }
    }

    // Application Models
    public class ApplicationMeta
    {
        public string previous { get; set; }
        public int total_count { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
    }

    public class Application
    {
        public string fallback_method { get; set; }
        public bool default_app { get; set; }
        public string app_name { get; set; }
        public string sub_account { get; set; }
        public bool production_app { get; set; }
        public bool enabled { get; set; }
        public string app_id { get; set; }
        public bool public_uri { get; set; }
        public string hangup_url { get; set; }
        public string sip_uri { get; set; }
        public string answer_url { get; set; }
        public string message_url { get; set; }
        public string resource_uri { get; set; }
        public string hangup_method { get; set; }
        public string message_method { get; set; }
        public string fallback_answer_url { get; set; }
        public string answer_method { get; set; }
    }

    public class ApplicationList
    {
        public ApplicationMeta meta { get; set; }
        public string error { get; set; }
        public string api_id { get; set; }
        public List<Application> objects { get; set; }
    }

    // Number Models
    public class NumberMeta
    {
        public string previous { get; set; }
        public int total_count { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
    }

    public class Number
    {
        public string region { get; set; }
        public bool voice_enabled { get; set; }
        public bool sms_enabled { get; set; }
        public bool fax_enabled { get; set; }
        public string number { get; set; }
        public string api_id { get; set; }
        public string voice_rate { get; set; }
        public string application { get; set; }
        public string sms_rate { get; set; }
        public string number_type { get; set; }
        public object sub_account { get; set; }
        public string added_on { get; set; }
        public string resource_uri { get; set; }
        public string group_id { get; set; }
        public string prefix { get; set; }
        public string rental_rate { get; set; }
        public string setup_rate { get; set; }
        public int stock { get; set; }
        [ObsoleteAttribute]
        public string country { get; set; }
        [ObsoleteAttribute]
        public int lata { get; set; }
        [ObsoleteAttribute("Use the attribute rental_rate instead")]
        public string monthly_rental_rate { get; set; }
    }

    public class NumberList
    {
        public NumberMeta meta { get; set; }
        public string api_id { get; set; }
        public string error { get; set; }
        public List<Number> objects { get; set; }
    }

    public class NumberStatus
    {
        public string number { get; set; }
        public string status { get; set; }
    }

    public class NumberResponse
    {
        public List<NumberStatus> numbers { get; set; }
        public string status { get; set; }
    }

    // Call Models
    public class Call
    {
        public string message { get; set; }
        public string request_uuid { get; set; }
        public string api_id { get; set; }
        public string error { get; set; }
    }

    public class LiveCall
    {
        public string direction { get; set; }
        public string from { get; set; }
        public string call_status { get; set; }
        public string api_id { get; set; }
        public string to { get; set; }
        public string caller_name { get; set; }
        public string call_uuid { get; set; }
        public string session_start { get; set; }
        public string error { get; set; }
    }

    public class LiveCallList
    {
        public string api_id { get; set; }
        public List<string> calls { get; set; }
        public string error { get; set; }
    }

    public class CDRMeta
    {
        public string previous { get; set; }
        public int total_count { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
    }

    public class CDR
    {
        public int bill_duration { get; set; }
        public string total_amount { get; set; }
        public string parent_call_uuid { get; set; }
        public string call_direction { get; set; }
        public string to_number { get; set; }
        public string total_rate { get; set; }
        public string from_number { get; set; }
        public string end_time { get; set; }
        public string call_uuid { get; set; }
        public string resource_uri { get; set; }
        public string error { get; set; }
        public string api_id { get; set; }
    }

    public class CDRList
    {
        public CDRMeta meta { get; set; }
        public string error { get; set; }
        public string api_id { get; set; }
        public List<CDR> objects { get; set; }
    }

    // Conference Models
    public class LiveConferenceList
    {
        public string error { get; set; }
        public string api_id { get; set; }
        public List<string> conferences { get; set; }
    }

    public class ConferenceMember
    {
        public string call_uuid { get; set; }
        public string caller_name { get; set; }
        public bool deaf { get; set; }
        public string direction { get; set; }
        public string from { get; set; }
        public string join_time { get; set; }
        public string member_id { get; set; }
        public bool muted { get; set; }
        public string to { get; set; }
    }

    public class Conference
    {
        public string error { get; set; }
        public string api_id { get; set; }
        public string conference_member_count { get; set; }
        public string conference_name { get; set; }
        public string conference_run_time { get; set; }
        public List<ConferenceMember> members { get; set; }
    }

    // Endpoint Models
    public class EndpointMeta
    {
        public string previous { get; set; }
        public int total_count { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
    }

    public class Endpoint
    {
        public string username { get; set; }
        public string sip_uri { get; set; }
        public string alias { get; set; }
        public string endpoint_id { get; set; }
        public string password { get; set; }
        public string resource_uri { get; set; }
        public string api_id { get; set; }
        public string error { get; set; }
    }

    public class EndpointList
    {
        public EndpointMeta meta { get; set; }
        public string error { get; set; }
        public string api_id { get; set; }
        public List<Endpoint> objects { get; set; }
    }

    // Message Models
    public class MessageResponse
    {
        public string message { get; set; }
        public List<string> message_uuid { get; set; }
        public string error { get; set; }
        public string api_id { get; set; }
    }

    public class MessageMeta
    {
        public string previous { get; set; }
        public int total_count { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
    }

    public class Message
    {
        public string cloud_rate { get; set; }
        public string carrier_rate { get; set; }
        public string message_direction { get; set; }
        public string to_number { get; set; }
        public string message_state { get; set; }
        public string total_amount { get; set; }
        public string from_number { get; set; }
        public string message_uuid { get; set; }
        public string message_time { get; set; }
        public string resource_uri { get; set; }
        public string message_type { get; set; }
    }

    public class MessageList
    {
        public MessageMeta meta { get; set; }
        public string api_id { get; set; }
        public List<Message> objects { get; set; }
    }
}