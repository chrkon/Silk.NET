// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkRenderingFlags")]
    public enum RenderingFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ContentsSecondaryCommandBuffersBit\"")]
        [NativeName("Name", "VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT")]
        RenderingContentsSecondaryCommandBuffersBit = 1,
        [Obsolete("Deprecated in favour of \"ContentsSecondaryCommandBuffersBitKhr\"")]
        [NativeName("Name", "VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT_KHR")]
        RenderingContentsSecondaryCommandBuffersBitKhr = 1,
        [Obsolete("Deprecated in favour of \"SuspendingBit\"")]
        [NativeName("Name", "VK_RENDERING_SUSPENDING_BIT")]
        RenderingSuspendingBit = 2,
        [Obsolete("Deprecated in favour of \"SuspendingBitKhr\"")]
        [NativeName("Name", "VK_RENDERING_SUSPENDING_BIT_KHR")]
        RenderingSuspendingBitKhr = 2,
        [Obsolete("Deprecated in favour of \"ResumingBit\"")]
        [NativeName("Name", "VK_RENDERING_RESUMING_BIT")]
        RenderingResumingBit = 4,
        [Obsolete("Deprecated in favour of \"ResumingBitKhr\"")]
        [NativeName("Name", "VK_RENDERING_RESUMING_BIT_KHR")]
        RenderingResumingBitKhr = 4,
        [Obsolete("Deprecated in favour of \"Reserved3BitExt\"")]
        [NativeName("Name", "VK_RENDERING_RESERVED_3_BIT_EXT")]
        RenderingReserved3BitExt = 8,
        [NativeName("Name", "VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT")]
        ContentsSecondaryCommandBuffersBit = 1,
        [NativeName("Name", "VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT_KHR")]
        ContentsSecondaryCommandBuffersBitKhr = 1,
        [NativeName("Name", "VK_RENDERING_SUSPENDING_BIT")]
        SuspendingBit = 2,
        [NativeName("Name", "VK_RENDERING_SUSPENDING_BIT_KHR")]
        SuspendingBitKhr = 2,
        [NativeName("Name", "VK_RENDERING_RESUMING_BIT")]
        ResumingBit = 4,
        [NativeName("Name", "VK_RENDERING_RESUMING_BIT_KHR")]
        ResumingBitKhr = 4,
        [NativeName("Name", "VK_RENDERING_RESERVED_3_BIT_EXT")]
        Reserved3BitExt = 8,
    }
}
