// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Razor;
using MonoDevelop.Core;

namespace Microsoft.VisualStudio.Mac.LanguageServices.Razor
{
    internal class VisualStudioErrorReporter : ErrorReporter
    {
        public override void ReportError(Exception exception)
        {
            if (exception == null)
            {
                return;
            }

            LoggingService.LogError("Razor Language Service error encountered.", exception);
        }

        public override void ReportError(Exception exception, Project project)
        {
            if (exception == null)
            {
                return;
            }

            LoggingService.LogError($"Razor Language Service error encountered from project '{project?.Name}'.", exception);
        }
    }
}
