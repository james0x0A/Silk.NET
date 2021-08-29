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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    public static class OesViewportArrayOverloads
    {
        public static unsafe void DepthRangeArray(this OesViewportArray thisApi, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.DepthRangeArray(first, count, in v.GetPinnableReference());
        }

        public static unsafe void GetFloat(this OesViewportArray thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<float> data)
        {
            // SpanOverloader
            thisApi.GetFloat(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetFloat(this OesViewportArray thisApi, [Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<float> data)
        {
            // SpanOverloader
            thisApi.GetFloat(target, index, out data.GetPinnableReference());
        }

        public static unsafe void ScissorArray(this OesViewportArray thisApi, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.ScissorArray(first, count, in v.GetPinnableReference());
        }

        public static unsafe void ScissorIndexed(this OesViewportArray thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.ScissorIndexed(index, in v.GetPinnableReference());
        }

        public static unsafe void ViewportArray(this OesViewportArray thisApi, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ViewportArray(first, count, in v.GetPinnableReference());
        }

        public static unsafe void ViewportIndexed(this OesViewportArray thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ViewportIndexed(index, in v.GetPinnableReference());
        }

    }
}
