// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.FB
{
    public static class FBSpatialEntityQueryOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySpacesFB(this FBSpatialEntityQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SpaceQueryInfoBaseHeaderFB* info, [Count(Count = 0)] Span<ulong> requestId)
        {
            // SpanOverloader
            return thisApi.QuerySpacesFB(session, info, ref requestId.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySpacesFB(this FBSpatialEntityQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SpaceQueryInfoBaseHeaderFB> info, [Count(Count = 0)] ulong* requestId)
        {
            // SpanOverloader
            return thisApi.QuerySpacesFB(session, in info.GetPinnableReference(), requestId);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySpacesFB(this FBSpatialEntityQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SpaceQueryInfoBaseHeaderFB> info, [Count(Count = 0)] Span<ulong> requestId)
        {
            // SpanOverloader
            return thisApi.QuerySpacesFB(session, in info.GetPinnableReference(), ref requestId.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RetrieveSpaceQueryResultsFB(this FBSpatialEntityQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong requestId, [Count(Count = 0)] Span<SpaceQueryResultsFB> results)
        {
            // SpanOverloader
            return thisApi.RetrieveSpaceQueryResultsFB(session, requestId, ref results.GetPinnableReference());
        }

    }
}

