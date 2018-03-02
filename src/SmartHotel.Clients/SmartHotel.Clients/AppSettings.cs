﻿using Plugin.Settings;
using Plugin.Settings.Abstractions;
using SmartHotel.Clients.Core.Extensions;
using SmartHotel.Clients.Core.Models;

namespace SmartHotel.Clients.Core
{
    public static class AppSettings
    {
        // Endpoints
        private const string DefaultBookingEndpoint = "http://sh360services-public.eastus2.cloudapp.azure.com/bookings-api/";
        private const string DefaultHotelsEndpoint = "http://sh360services-public.eastus2.cloudapp.azure.com/hotels-api/";
        private const string DefaultSuggestionsEndpoint = "http://sh360services-public.eastus2.cloudapp.azure.com/suggestions-api/";
        private const string DefaultNotificationsEndpoint = "http://sh360services-public.eastus2.cloudapp.azure.com/notifications-api/";
        private const string DefaultSettingsFileUrl = "http://sh360services-public.eastus2.cloudapp.azure.com/configuration-api/cfg/public-http";
        private const string DefaultImagesBaseUri = "http://sh360imgpublic.blob.core.windows.net/";

        // Mobile Center
        private const string DefaultMobileCenterAnalyticsAndroid = "f4754bd4-1edf-4bd8-83cd-b9f6539293da";
        private const string DefaultMobileCenterAnalyticsIos = "f3584cf1-6c12-465e-9511-d8db225bd340";
        private const string DefaultMobileCenterAnalyticsWindows = "fd822e0c-f6fd-446c-846c-622c3c229006";

        // Maps
        private const string DefaultBingMapsApiKey = "9D6ZuqeGpcfZ9PVYR1BQ~ofsY_N_KDywcNM-Y0Io5aA~AvqaBtSnHxFfX7flAqux2Q6eYSIreLwDxnswabgPlEOXmoEXXt6u1O6In0hqICy8";
        public const string DefaultFallbackMapsLocation = "40.762246 -73.986943";

        // Bots
        private const string DefaultSkypeBotId = "897f3818-8da3-4d23-a613-9a0f9555f2ea";
        private const string DefaultFacebookBotId = "120799875283148";

        // B2c
        public const string B2cAuthority = "https://login.microsoftonline.com/";
        public const string DefaultB2cPolicy = "B2C_1_SignUpInPolicy";
        public const string DefaultB2cClientId = "b3cfbe11-ac36-4dcb-af16-8656ee286dcc";
        public const string DefaultB2cTenant = "smarthotel360.onmicrosoft.com";

        // Booking 
        private const bool DefaultHasBooking = false;

        // Fakes
        private const bool DefaultUseFakes = false;

        private static ISettings Settings => CrossSettings.Current;

        // Azure B2C settings
        public static string B2cClientId
        {
            get => Settings.GetValueOrDefault(nameof(B2cClientId), DefaultB2cClientId);

            set => Settings.AddOrUpdateValue(nameof(B2cClientId), value);
        }

        public static string B2cTenant
        {
            get => Settings.GetValueOrDefault(nameof(B2cTenant), DefaultB2cTenant);

            set => Settings.AddOrUpdateValue(nameof(B2cTenant), value);
        }

        public static string B2cPolicy
        {
            get => Settings.GetValueOrDefault(nameof(B2cPolicy), DefaultB2cPolicy);

            set => Settings.AddOrUpdateValue(nameof(B2cPolicy), value);
        }
        

        // API Endpoints
        public static string BookingEndpoint
        {
            get => Settings.GetValueOrDefault(nameof(BookingEndpoint), DefaultBookingEndpoint);

            set => Settings.AddOrUpdateValue(nameof(BookingEndpoint), value);
        }

        public static string HotelsEndpoint
        {
            get => Settings.GetValueOrDefault(nameof(HotelsEndpoint), DefaultHotelsEndpoint);

            set => Settings.AddOrUpdateValue(nameof(HotelsEndpoint), value);
        }

        public static string SuggestionsEndpoint
        {
            get => Settings.GetValueOrDefault(nameof(SuggestionsEndpoint), DefaultSuggestionsEndpoint);

            set => Settings.AddOrUpdateValue(nameof(SuggestionsEndpoint), value);
        }

        public static string NotificationsEndpoint
        {
            get => Settings.GetValueOrDefault(nameof(NotificationsEndpoint), DefaultNotificationsEndpoint);

            set => Settings.AddOrUpdateValue(nameof(NotificationsEndpoint), value);
        }

        public static string ImagesBaseUri
        {
            get => Settings.GetValueOrDefault(nameof(ImagesBaseUri), DefaultImagesBaseUri);

            set => Settings.AddOrUpdateValue(nameof(ImagesBaseUri), value);
        }

        public static string SkypeBotId
        {
            get => Settings.GetValueOrDefault(nameof(SkypeBotId), DefaultSkypeBotId);

            set => Settings.AddOrUpdateValue(nameof(SkypeBotId), value);
        }

        public static string FacebookBotId
        {
            get => Settings.GetValueOrDefault(nameof(FacebookBotId), DefaultFacebookBotId);

            set => Settings.AddOrUpdateValue(nameof(FacebookBotId), value);
        }

        // Other settings
        public static string BingMapsApiKey
        {
            get => Settings.GetValueOrDefault(nameof(BingMapsApiKey), DefaultBingMapsApiKey);

            set => Settings.AddOrUpdateValue(nameof(BingMapsApiKey), value);
        }

        public static string SettingsFileUrl
        {
            get => Settings.GetValueOrDefault(nameof(SettingsFileUrl), DefaultSettingsFileUrl);

            set => Settings.AddOrUpdateValue(nameof(SettingsFileUrl), value);
        }

        public static string FallbackMapsLocation
        {
            get => Settings.GetValueOrDefault(nameof(FallbackMapsLocation), DefaultFallbackMapsLocation);

            set => Settings.AddOrUpdateValue(nameof(FallbackMapsLocation), value);
        }

        public static User User
        {
            get => Settings.GetValueOrDefault(nameof(User), default(User));

            set => Settings.AddOrUpdateValue(nameof(User), value);
        }

        public static string MobileCenterAnalyticsAndroid
        {
            get => Settings.GetValueOrDefault(nameof(MobileCenterAnalyticsAndroid), DefaultMobileCenterAnalyticsAndroid);

            set => Settings.AddOrUpdateValue(nameof(MobileCenterAnalyticsAndroid), value);
        }

        public static string MobileCenterAnalyticsIos
        {
            get => Settings.GetValueOrDefault(nameof(MobileCenterAnalyticsIos), DefaultMobileCenterAnalyticsIos);

            set => Settings.AddOrUpdateValue(nameof(MobileCenterAnalyticsIos), value);
        }

        public static string MobileCenterAnalyticsWindows
        {
            get => Settings.GetValueOrDefault(nameof(MobileCenterAnalyticsWindows), DefaultMobileCenterAnalyticsWindows);

            set => Settings.AddOrUpdateValue(nameof(MobileCenterAnalyticsWindows), value);
        }

        public static bool UseFakes
        {
            get => Settings.GetValueOrDefault(nameof(UseFakes), DefaultUseFakes);

            set => Settings.AddOrUpdateValue(nameof(UseFakes), value);
        }

        public static bool HasBooking
        {
            get => Settings.GetValueOrDefault(nameof(HasBooking), DefaultHasBooking);

            set => Settings.AddOrUpdateValue(nameof(HasBooking), value);
        }

        public static void RemoveUserData()
        {
            Settings.Remove(nameof(User));
        }
    }
}