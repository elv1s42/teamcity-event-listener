﻿// ***********************************************************************
// Copyright (c) 2015 Charlie Poole
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

namespace NUnit.Engine.Listeners
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage("ReSharper", "UseNameofExpression")]
    public struct ServiceMessageAttr
    {
        public ServiceMessageAttr(string name, string value)
            : this()
        {
            if (name == null) throw new ArgumentNullException("name");
            if (value == null) throw new ArgumentNullException("value");

            Name = name;
            Value = value;
        }

        public string Value { get; private set; }

        public string Name { get; private set; }

        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public static class Names
        {
            public const string Name = "name";
            public const string FlowId = "flowId";
            public const string Message = "message";
            public const string Text = "text";
            public const string Out = "out";
            public const string TcTags = "tc:tags";
            public const string Parent = "parent";
            public const string CaptureStandardOutput = "captureStandardOutput";
            public const string Duration = "duration";
            public const string Details = "details";
            public const string TestName = "testName";
            public const string Type = "type";
            public const string Value = "value";            
        }
    }
}
