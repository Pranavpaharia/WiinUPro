﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using NintrollerLib;

namespace WiinUPro
{
    [JsonObject]
    public class DevicePrefs
    {
        public string deviceId;
        public string defaultProfile;
        public string nickname;
        public string icon;
        public bool autoConnect;
        public Dictionary<string, string> calibrationFiles = new Dictionary<string, string>();

        public void Copy(DevicePrefs other)
        {
            if (deviceId != other.deviceId) return;

            defaultProfile = other.defaultProfile;
            nickname = other.nickname;
            icon = other.icon;
            autoConnect = other.autoConnect;
            calibrationFiles.Clear();
            foreach (var calibration in other.calibrationFiles)
            {
                calibrationFiles.Add(calibration.Key, calibration.Value);
            }
        }
    }
}
