// Copyright (c) PandoraJewelry. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Pandora.IoC
{
    public interface IConfigurationProvider
    {
        string AppSetting(string name);
        string ConnectionString(string name);
    }
}
