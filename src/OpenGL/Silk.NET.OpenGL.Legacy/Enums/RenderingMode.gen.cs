// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "RenderingMode")]
    public enum RenderingMode : int
    {
        [System.Obsolete]
        [NativeName("Name", "GL_RENDER")]
        Render = 0x1C00,
        [System.Obsolete]
        [NativeName("Name", "GL_FEEDBACK")]
        Feedback = 0x1C01,
        [System.Obsolete]
        [NativeName("Name", "GL_SELECT")]
        Select = 0x1C02,
    }
}
