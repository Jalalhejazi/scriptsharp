﻿// RuntimeTest.cs
// Script#/Tests/Runtime
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptSharp.Testing;

namespace Runtime.Tests.Core {

    public abstract class RuntimeTest {

        private static readonly WebTest _webTest;
        private static readonly string[] _scripts = new string[] {
            "ss.js", "ss.min.js", "ssloader.js", "ssloader.min.js"
        };
        private static readonly string[] _codeFiles = new string[] {
            "OOP.cs"
        };

        private const int _port = 3976;

        private TestContext _context;

        static RuntimeTest() {
            string assemblyPath = typeof(RuntimeTest).Assembly.GetModules()[0].FullyQualifiedName;
            string binDirectory = Path.GetFullPath(Path.Combine(assemblyPath, "..\\..\\..\\..\\..\\bin\\Debug\\"));

            string webRoot = Path.GetFullPath(Path.Combine(assemblyPath, "..\\..\\..\\..\\TestSite\\"));
            string scriptsDirectory = Path.Combine(webRoot, "Scripts");
            string codeDirectory = Path.Combine(webRoot, "Code");

            Directory.CreateDirectory(scriptsDirectory);
            foreach (string script in _scripts) {
                File.Copy(Path.Combine(binDirectory, script), Path.Combine(scriptsDirectory, script), overwrite: true);
            }

            string mscorlibPath = Path.Combine(binDirectory, "mscorlib.dll");
            foreach (string codeFile in _codeFiles) {
                string script = Path.GetFileNameWithoutExtension(codeFile) + Path.ChangeExtension(".cs", ".js");

                Compilation compilation = new Compilation(Path.Combine(scriptsDirectory, script));
                compilation.AddReference(mscorlibPath)
                           .AddSource(Path.Combine(codeDirectory, codeFile))
                           .Execute();
            }

            _webTest = new WebTest();
            _webTest.StartWebServer(webRoot, _port);
        }

        public TestContext TestContext {
            get {
                return _context;
            }
            set {
                _context = value;
            }
        }

        protected void RunTest(string url) {
            Uri testUri = _webTest.GetTestUri(url);

            WebTestResult result = _webTest.RunTest(testUri, WebBrowser.Chrome);
            Assert.IsTrue(result.Succeeded, "Log:\r\n" + result.Log);
        }
    }
}