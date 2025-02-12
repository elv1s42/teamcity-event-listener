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
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;

    public struct ServiceMessage
    {
        private static readonly ServiceMessageAttr[] EmptyAttrs = new ServiceMessageAttr[0];

        public ServiceMessage(string name, params ServiceMessageAttr[] attributes)
            : this(name, (IList<ServiceMessageAttr>)attributes)
        {
        }

        public ServiceMessage(string name, IList<ServiceMessageAttr> attributes) : this()
        {
            if (name == null) throw new ArgumentNullException("name");
            if (attributes == null) throw new ArgumentNullException("attributes");

            Name = name;
            Value = string.Empty;
            Attributes = new ReadOnlyCollection<ServiceMessageAttr>(attributes);
        }

        public ServiceMessage(string name, string value) : this()
        {
            if (name == null) throw new ArgumentNullException("name");
            if (value == null) throw new ArgumentNullException("value");

            Name = name;
            Value = value;
            Attributes = EmptyAttrs;
        }

        public string Name { get; private set; }

        public string Value { get; private set; }

        public IEnumerable<ServiceMessageAttr> Attributes { get; private set; }

        public string Dump(string prefix)
        {
            var attributes = "";
            foreach (var serviceMessageAttr in Attributes)
            {
                attributes += "   { " + serviceMessageAttr.Name + ": " + serviceMessageAttr.Value + " }" +
                              Environment.NewLine;
            }

            return "MSG " + prefix + ":" + Environment.NewLine + "  Name: '" + Name + "', Value: '" + Value +
                   "', Attributes: " + Environment.NewLine + attributes;
        }

        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public static class Names
        {
            public const string TestStdOut = "testStdOut";
            public const string TestStdErr = "testStdErr";
            public const string TestSuiteStarted = "testSuiteStarted";
            public const string TestSuiteFinished = "testSuiteFinished";
            public const string FlowStarted = "flowStarted";
            public const string FlowFinished = "flowFinished";
            public const string TestStarted = "testStarted";
            public const string TestFinished = "testFinished";
            public const string TestFailed = "testFailed";
            public const string TestIgnored = "testIgnored";
            public const string Message = "message";
            public const string PublishArtifacts = "publishArtifacts";
            public const string TestMetadata = "testMetadata";
        }
    }
}