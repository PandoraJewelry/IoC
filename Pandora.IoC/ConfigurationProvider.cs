// Copyright (c) PandoraJewelry. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Configuration;

namespace Pandora.IoC
{
    public class ConfigurationProvider : IConfigurationProvider
    {
        public string AppSetting(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            return ConfigurationManager.AppSettings[name];
        }

        public string ConnectionString(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            var conn = ConfigurationManager.ConnectionStrings[name];

            return conn == null ? null : conn.ConnectionString;
        }
    }
}
