﻿using System;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using System.Linq;
using System.Collections.Generic;

namespace Linq2OData.Client.Provider.Writers
{
    internal static class StringWriterModule
    {
        internal static void RegisterWriters(ODataExpressionConverterSettings settings)
        {
            settings.RegisterMethod<string>(nameof(string.Contains));
            settings.RegisterMethod<string>(nameof(string.EndsWith));
            settings.RegisterMethod<string>(nameof(string.StartsWith));
            settings.RegisterMethod<string>(nameof(string.IndexOf));
            settings.RegisterMethod<string>(nameof(string.ToLower));
            settings.RegisterMethod<string>(nameof(string.ToLowerInvariant), "tolower");
            settings.RegisterMethod<string>(nameof(string.ToUpper));
            settings.RegisterMethod<string>(nameof(string.ToUpperInvariant), "toupper");
            settings.RegisterMethod<string>(nameof(string.Trim));

            settings.RegisterMember<string>(nameof(string.Length));

            settings.RegisterValueWriter<string>(x => $"'{x}'");
        }
    }
}