// Generated from https://github.com/nuke-build/nuke/blob/master/build/specifications/VSTest.json

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Nuke.Common.Tools.VSTest
{
    /// <summary>
    ///   <p>VSTest.Console.exe is the command-line command that is used to run tests. You can specify several options in any order on the VSTest.Console.exe command line.</p>
    ///   <p>For more details, visit the <a href="https://msdn.microsoft.com/en-us/library/jj155796.aspx">official website</a>.</p>
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class VSTestTasks
    {
        /// <summary>
        ///   Path to the VSTest executable.
        /// </summary>
        public static string VSTestPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("VSTEST_EXE") ??
            ToolPathResolver.GetPackageExecutable("Microsoft.TestPlatform", "vstest.console.exe");
        public static Action<OutputType, string> VSTestLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   <p>VSTest.Console.exe is the command-line command that is used to run tests. You can specify several options in any order on the VSTest.Console.exe command line.</p>
        ///   <p>For more details, visit the <a href="https://msdn.microsoft.com/en-us/library/jj155796.aspx">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> VSTest(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(VSTestPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, VSTestLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>VSTest.Console.exe is the command-line command that is used to run tests. You can specify several options in any order on the VSTest.Console.exe command line.</p>
        ///   <p>For more details, visit the <a href="https://msdn.microsoft.com/en-us/library/jj155796.aspx">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;testAssemblies&gt;</c> via <see cref="VSTestSettings.TestAssemblies"/></li>
        ///     <li><c>/Diag</c> via <see cref="VSTestSettings.DiagnosticsFile"/></li>
        ///     <li><c>/EnableCodeCoverage</c> via <see cref="VSTestSettings.EnableCodeCoverage"/></li>
        ///     <li><c>/Framework</c> via <see cref="VSTestSettings.Framework"/></li>
        ///     <li><c>/InIsolation</c> via <see cref="VSTestSettings.InIsolation"/></li>
        ///     <li><c>/ListDiscoverers</c> via <see cref="VSTestSettings.ListDiscoverers"/></li>
        ///     <li><c>/ListExecutors</c> via <see cref="VSTestSettings.ListExecutors"/></li>
        ///     <li><c>/ListLoggers</c> via <see cref="VSTestSettings.ListLoggers"/></li>
        ///     <li><c>/ListSettingsProviders</c> via <see cref="VSTestSettings.ListSettingsProviders"/></li>
        ///     <li><c>/ListTests</c> via <see cref="VSTestSettings.ListTests"/></li>
        ///     <li><c>/Logger</c> via <see cref="VSTestSettings.Logger"/></li>
        ///     <li><c>/Parallel</c> via <see cref="VSTestSettings.Parallel"/></li>
        ///     <li><c>/Platform</c> via <see cref="VSTestSettings.Platform"/></li>
        ///     <li><c>/Settings</c> via <see cref="VSTestSettings.SettingsFile"/></li>
        ///     <li><c>/TestAdapterPath</c> via <see cref="VSTestSettings.TestAdapterPath"/></li>
        ///     <li><c>/TestCaseFilter</c> via <see cref="VSTestSettings.TestCaseFilters"/></li>
        ///     <li><c>/Tests</c> via <see cref="VSTestSettings.Tests"/></li>
        ///     <li><c>/UseVsixExtensions</c> via <see cref="VSTestSettings.UseVsixExtensions"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> VSTest(VSTestSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new VSTestSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>VSTest.Console.exe is the command-line command that is used to run tests. You can specify several options in any order on the VSTest.Console.exe command line.</p>
        ///   <p>For more details, visit the <a href="https://msdn.microsoft.com/en-us/library/jj155796.aspx">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;testAssemblies&gt;</c> via <see cref="VSTestSettings.TestAssemblies"/></li>
        ///     <li><c>/Diag</c> via <see cref="VSTestSettings.DiagnosticsFile"/></li>
        ///     <li><c>/EnableCodeCoverage</c> via <see cref="VSTestSettings.EnableCodeCoverage"/></li>
        ///     <li><c>/Framework</c> via <see cref="VSTestSettings.Framework"/></li>
        ///     <li><c>/InIsolation</c> via <see cref="VSTestSettings.InIsolation"/></li>
        ///     <li><c>/ListDiscoverers</c> via <see cref="VSTestSettings.ListDiscoverers"/></li>
        ///     <li><c>/ListExecutors</c> via <see cref="VSTestSettings.ListExecutors"/></li>
        ///     <li><c>/ListLoggers</c> via <see cref="VSTestSettings.ListLoggers"/></li>
        ///     <li><c>/ListSettingsProviders</c> via <see cref="VSTestSettings.ListSettingsProviders"/></li>
        ///     <li><c>/ListTests</c> via <see cref="VSTestSettings.ListTests"/></li>
        ///     <li><c>/Logger</c> via <see cref="VSTestSettings.Logger"/></li>
        ///     <li><c>/Parallel</c> via <see cref="VSTestSettings.Parallel"/></li>
        ///     <li><c>/Platform</c> via <see cref="VSTestSettings.Platform"/></li>
        ///     <li><c>/Settings</c> via <see cref="VSTestSettings.SettingsFile"/></li>
        ///     <li><c>/TestAdapterPath</c> via <see cref="VSTestSettings.TestAdapterPath"/></li>
        ///     <li><c>/TestCaseFilter</c> via <see cref="VSTestSettings.TestCaseFilters"/></li>
        ///     <li><c>/Tests</c> via <see cref="VSTestSettings.Tests"/></li>
        ///     <li><c>/UseVsixExtensions</c> via <see cref="VSTestSettings.UseVsixExtensions"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> VSTest(Configure<VSTestSettings> configurator)
        {
            return VSTest(configurator(new VSTestSettings()));
        }
        /// <summary>
        ///   <p>VSTest.Console.exe is the command-line command that is used to run tests. You can specify several options in any order on the VSTest.Console.exe command line.</p>
        ///   <p>For more details, visit the <a href="https://msdn.microsoft.com/en-us/library/jj155796.aspx">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;testAssemblies&gt;</c> via <see cref="VSTestSettings.TestAssemblies"/></li>
        ///     <li><c>/Diag</c> via <see cref="VSTestSettings.DiagnosticsFile"/></li>
        ///     <li><c>/EnableCodeCoverage</c> via <see cref="VSTestSettings.EnableCodeCoverage"/></li>
        ///     <li><c>/Framework</c> via <see cref="VSTestSettings.Framework"/></li>
        ///     <li><c>/InIsolation</c> via <see cref="VSTestSettings.InIsolation"/></li>
        ///     <li><c>/ListDiscoverers</c> via <see cref="VSTestSettings.ListDiscoverers"/></li>
        ///     <li><c>/ListExecutors</c> via <see cref="VSTestSettings.ListExecutors"/></li>
        ///     <li><c>/ListLoggers</c> via <see cref="VSTestSettings.ListLoggers"/></li>
        ///     <li><c>/ListSettingsProviders</c> via <see cref="VSTestSettings.ListSettingsProviders"/></li>
        ///     <li><c>/ListTests</c> via <see cref="VSTestSettings.ListTests"/></li>
        ///     <li><c>/Logger</c> via <see cref="VSTestSettings.Logger"/></li>
        ///     <li><c>/Parallel</c> via <see cref="VSTestSettings.Parallel"/></li>
        ///     <li><c>/Platform</c> via <see cref="VSTestSettings.Platform"/></li>
        ///     <li><c>/Settings</c> via <see cref="VSTestSettings.SettingsFile"/></li>
        ///     <li><c>/TestAdapterPath</c> via <see cref="VSTestSettings.TestAdapterPath"/></li>
        ///     <li><c>/TestCaseFilter</c> via <see cref="VSTestSettings.TestCaseFilters"/></li>
        ///     <li><c>/Tests</c> via <see cref="VSTestSettings.Tests"/></li>
        ///     <li><c>/UseVsixExtensions</c> via <see cref="VSTestSettings.UseVsixExtensions"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(VSTestSettings Settings, IReadOnlyCollection<Output> Output)> VSTest(CombinatorialConfigure<VSTestSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(VSTest, VSTestLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region VSTestSettings
    /// <summary>
    ///   Used within <see cref="VSTestTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class VSTestSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the VSTest executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? VSTestTasks.VSTestPath;
        public override Action<OutputType, string> CustomLogger => VSTestTasks.VSTestLogger;
        /// <summary>
        ///   Run tests from the specified files. Separate multiple test file names with spaces.
        /// </summary>
        public virtual IReadOnlyList<string> TestAssemblies => TestAssembliesInternal.AsReadOnly();
        internal List<string> TestAssembliesInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Run tests with additional settings such as data collectors.
        /// </summary>
        public virtual string SettingsFile { get; internal set; }
        /// <summary>
        ///   Run tests with names that match the provided values. To provide multiple values, separate them by commas.
        /// </summary>
        public virtual IReadOnlyList<string> Tests => TestsInternal.AsReadOnly();
        internal List<string> TestsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Specifies that the tests be executed in parallel. By default up to all available cores on the machine may be used. The number of cores to use can be configured by using a settings file.
        /// </summary>
        public virtual bool? Parallel { get; internal set; }
        /// <summary>
        ///   Enables data diagnostic adapter CodeCoverage in the test run.
        /// </summary>
        public virtual bool? EnableCodeCoverage { get; internal set; }
        /// <summary>
        ///   Runs the tests in an isolated process.
        /// </summary>
        public virtual bool? InIsolation { get; internal set; }
        /// <summary>
        ///   This makes vstest.console.exe process use or skip the VSIX extensions installed (if any) in the test run.
        /// </summary>
        public virtual bool? UseVsixExtensions { get; internal set; }
        /// <summary>
        ///   Forces the vstest.console.exe process to use custom test adapters from a specified path (if any) in the test run.
        /// </summary>
        public virtual string TestAdapterPath { get; internal set; }
        /// <summary>
        ///   Target platform architecture to be used for test execution.
        /// </summary>
        public virtual VsTestPlatform Platform { get; internal set; }
        /// <summary>
        ///   Target .NET Framework version to be used for test execution.
        /// </summary>
        public virtual VsTestFramework Framework { get; internal set; }
        /// <summary>
        ///   Run tests that match the given expression.<para/><c>&lt;Expression&gt;</c> is of the format <c>&lt;property&gt;=&lt;value&gt;[|&lt;Expression&gt;]</c>.<para/>The <c>/TestCaseFilter</c> command line option cannot be used with the <c>/Tests</c> command line option.<para/>For information about creating and using expressions, see <a href="https://github.com/Microsoft/vstest-docs/blob/master/docs/filter.md">TestCase filter</a>.
        /// </summary>
        public virtual IReadOnlyList<string> TestCaseFilters => TestCaseFiltersInternal.AsReadOnly();
        internal List<string> TestCaseFiltersInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Specify a logger for test results. Example: To log results into a Visual Studio Test Results File (TRX) use <c>/Logger:trx</c>.
        /// </summary>
        public virtual string Logger { get; internal set; }
        /// <summary>
        ///   Lists discovered tests from the given test container.
        /// </summary>
        public virtual string ListTests { get; internal set; }
        /// <summary>
        ///   Lists installed test discoverers.
        /// </summary>
        public virtual bool? ListDiscoverers { get; internal set; }
        /// <summary>
        ///   Lists installed test executors.
        /// </summary>
        public virtual bool? ListExecutors { get; internal set; }
        /// <summary>
        ///   Lists installed test loggers.
        /// </summary>
        public virtual bool? ListLoggers { get; internal set; }
        /// <summary>
        ///   Lists installed test settings providers.
        /// </summary>
        public virtual bool? ListSettingsProviders { get; internal set; }
        /// <summary>
        ///   Writes diagnostic trace logs to the specified file.
        /// </summary>
        public virtual string DiagnosticsFile { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("{value}", TestAssemblies)
              .Add("/Settings:{value}", SettingsFile)
              .Add("/Tests:{value}", Tests, separator: ',')
              .Add("/Parallel", Parallel)
              .Add("/EnableCodeCoverage", EnableCodeCoverage)
              .Add("/InIsolation", InIsolation)
              .Add("/UseVsixExtensions:{value}", UseVsixExtensions)
              .Add("/TestAdapterPath:{value}", TestAdapterPath)
              .Add("/Platform:{value}", Platform)
              .Add("/Framework:{value}", Framework)
              .Add("/TestCaseFilter:{value}", TestCaseFilters, separator: '|')
              .Add("/Logger:{value}", Logger)
              .Add("/ListTests:{value}", ListTests)
              .Add("/ListDiscoverers", ListDiscoverers)
              .Add("/ListExecutors", ListExecutors)
              .Add("/ListLoggers", ListLoggers)
              .Add("/ListSettingsProviders", ListSettingsProviders)
              .Add("/Diag:{value}", DiagnosticsFile);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region VSTestSettingsExtensions
    /// <summary>
    ///   Used within <see cref="VSTestTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class VSTestSettingsExtensions
    {
        #region TestAssemblies
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.TestAssemblies"/> to a new list</em></p>
        ///   <p>Run tests from the specified files. Separate multiple test file names with spaces.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetTestAssemblies(this VSTestSettings toolSettings, params string[] testAssemblies)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestAssembliesInternal = testAssemblies.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.TestAssemblies"/> to a new list</em></p>
        ///   <p>Run tests from the specified files. Separate multiple test file names with spaces.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetTestAssemblies(this VSTestSettings toolSettings, IEnumerable<string> testAssemblies)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestAssembliesInternal = testAssemblies.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="VSTestSettings.TestAssemblies"/></em></p>
        ///   <p>Run tests from the specified files. Separate multiple test file names with spaces.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings AddTestAssemblies(this VSTestSettings toolSettings, params string[] testAssemblies)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestAssembliesInternal.AddRange(testAssemblies);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="VSTestSettings.TestAssemblies"/></em></p>
        ///   <p>Run tests from the specified files. Separate multiple test file names with spaces.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings AddTestAssemblies(this VSTestSettings toolSettings, IEnumerable<string> testAssemblies)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestAssembliesInternal.AddRange(testAssemblies);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="VSTestSettings.TestAssemblies"/></em></p>
        ///   <p>Run tests from the specified files. Separate multiple test file names with spaces.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ClearTestAssemblies(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestAssembliesInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="VSTestSettings.TestAssemblies"/></em></p>
        ///   <p>Run tests from the specified files. Separate multiple test file names with spaces.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings RemoveTestAssemblies(this VSTestSettings toolSettings, params string[] testAssemblies)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(testAssemblies);
            toolSettings.TestAssembliesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="VSTestSettings.TestAssemblies"/></em></p>
        ///   <p>Run tests from the specified files. Separate multiple test file names with spaces.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings RemoveTestAssemblies(this VSTestSettings toolSettings, IEnumerable<string> testAssemblies)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(testAssemblies);
            toolSettings.TestAssembliesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region SettingsFile
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.SettingsFile"/></em></p>
        ///   <p>Run tests with additional settings such as data collectors.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetSettingsFile(this VSTestSettings toolSettings, string settingsFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingsFile = settingsFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="VSTestSettings.SettingsFile"/></em></p>
        ///   <p>Run tests with additional settings such as data collectors.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ResetSettingsFile(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingsFile = null;
            return toolSettings;
        }
        #endregion
        #region Tests
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.Tests"/> to a new list</em></p>
        ///   <p>Run tests with names that match the provided values. To provide multiple values, separate them by commas.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetTests(this VSTestSettings toolSettings, params string[] tests)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestsInternal = tests.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.Tests"/> to a new list</em></p>
        ///   <p>Run tests with names that match the provided values. To provide multiple values, separate them by commas.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetTests(this VSTestSettings toolSettings, IEnumerable<string> tests)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestsInternal = tests.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="VSTestSettings.Tests"/></em></p>
        ///   <p>Run tests with names that match the provided values. To provide multiple values, separate them by commas.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings AddTests(this VSTestSettings toolSettings, params string[] tests)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestsInternal.AddRange(tests);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="VSTestSettings.Tests"/></em></p>
        ///   <p>Run tests with names that match the provided values. To provide multiple values, separate them by commas.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings AddTests(this VSTestSettings toolSettings, IEnumerable<string> tests)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestsInternal.AddRange(tests);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="VSTestSettings.Tests"/></em></p>
        ///   <p>Run tests with names that match the provided values. To provide multiple values, separate them by commas.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ClearTests(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="VSTestSettings.Tests"/></em></p>
        ///   <p>Run tests with names that match the provided values. To provide multiple values, separate them by commas.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings RemoveTests(this VSTestSettings toolSettings, params string[] tests)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(tests);
            toolSettings.TestsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="VSTestSettings.Tests"/></em></p>
        ///   <p>Run tests with names that match the provided values. To provide multiple values, separate them by commas.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings RemoveTests(this VSTestSettings toolSettings, IEnumerable<string> tests)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(tests);
            toolSettings.TestsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Parallel
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.Parallel"/></em></p>
        ///   <p>Specifies that the tests be executed in parallel. By default up to all available cores on the machine may be used. The number of cores to use can be configured by using a settings file.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetParallel(this VSTestSettings toolSettings, bool? parallel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parallel = parallel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="VSTestSettings.Parallel"/></em></p>
        ///   <p>Specifies that the tests be executed in parallel. By default up to all available cores on the machine may be used. The number of cores to use can be configured by using a settings file.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ResetParallel(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parallel = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="VSTestSettings.Parallel"/></em></p>
        ///   <p>Specifies that the tests be executed in parallel. By default up to all available cores on the machine may be used. The number of cores to use can be configured by using a settings file.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings EnableParallel(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parallel = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="VSTestSettings.Parallel"/></em></p>
        ///   <p>Specifies that the tests be executed in parallel. By default up to all available cores on the machine may be used. The number of cores to use can be configured by using a settings file.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings DisableParallel(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parallel = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="VSTestSettings.Parallel"/></em></p>
        ///   <p>Specifies that the tests be executed in parallel. By default up to all available cores on the machine may be used. The number of cores to use can be configured by using a settings file.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ToggleParallel(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parallel = !toolSettings.Parallel;
            return toolSettings;
        }
        #endregion
        #region EnableCodeCoverage
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.EnableCodeCoverage"/></em></p>
        ///   <p>Enables data diagnostic adapter CodeCoverage in the test run.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetEnableCodeCoverage(this VSTestSettings toolSettings, bool? enableCodeCoverage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCodeCoverage = enableCodeCoverage;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="VSTestSettings.EnableCodeCoverage"/></em></p>
        ///   <p>Enables data diagnostic adapter CodeCoverage in the test run.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ResetEnableCodeCoverage(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCodeCoverage = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="VSTestSettings.EnableCodeCoverage"/></em></p>
        ///   <p>Enables data diagnostic adapter CodeCoverage in the test run.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings EnableEnableCodeCoverage(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCodeCoverage = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="VSTestSettings.EnableCodeCoverage"/></em></p>
        ///   <p>Enables data diagnostic adapter CodeCoverage in the test run.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings DisableEnableCodeCoverage(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCodeCoverage = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="VSTestSettings.EnableCodeCoverage"/></em></p>
        ///   <p>Enables data diagnostic adapter CodeCoverage in the test run.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ToggleEnableCodeCoverage(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCodeCoverage = !toolSettings.EnableCodeCoverage;
            return toolSettings;
        }
        #endregion
        #region InIsolation
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.InIsolation"/></em></p>
        ///   <p>Runs the tests in an isolated process.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetInIsolation(this VSTestSettings toolSettings, bool? inIsolation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InIsolation = inIsolation;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="VSTestSettings.InIsolation"/></em></p>
        ///   <p>Runs the tests in an isolated process.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ResetInIsolation(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InIsolation = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="VSTestSettings.InIsolation"/></em></p>
        ///   <p>Runs the tests in an isolated process.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings EnableInIsolation(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InIsolation = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="VSTestSettings.InIsolation"/></em></p>
        ///   <p>Runs the tests in an isolated process.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings DisableInIsolation(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InIsolation = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="VSTestSettings.InIsolation"/></em></p>
        ///   <p>Runs the tests in an isolated process.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ToggleInIsolation(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InIsolation = !toolSettings.InIsolation;
            return toolSettings;
        }
        #endregion
        #region UseVsixExtensions
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.UseVsixExtensions"/></em></p>
        ///   <p>This makes vstest.console.exe process use or skip the VSIX extensions installed (if any) in the test run.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetUseVsixExtensions(this VSTestSettings toolSettings, bool? useVsixExtensions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseVsixExtensions = useVsixExtensions;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="VSTestSettings.UseVsixExtensions"/></em></p>
        ///   <p>This makes vstest.console.exe process use or skip the VSIX extensions installed (if any) in the test run.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ResetUseVsixExtensions(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseVsixExtensions = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="VSTestSettings.UseVsixExtensions"/></em></p>
        ///   <p>This makes vstest.console.exe process use or skip the VSIX extensions installed (if any) in the test run.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings EnableUseVsixExtensions(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseVsixExtensions = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="VSTestSettings.UseVsixExtensions"/></em></p>
        ///   <p>This makes vstest.console.exe process use or skip the VSIX extensions installed (if any) in the test run.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings DisableUseVsixExtensions(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseVsixExtensions = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="VSTestSettings.UseVsixExtensions"/></em></p>
        ///   <p>This makes vstest.console.exe process use or skip the VSIX extensions installed (if any) in the test run.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ToggleUseVsixExtensions(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseVsixExtensions = !toolSettings.UseVsixExtensions;
            return toolSettings;
        }
        #endregion
        #region TestAdapterPath
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.TestAdapterPath"/></em></p>
        ///   <p>Forces the vstest.console.exe process to use custom test adapters from a specified path (if any) in the test run.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetTestAdapterPath(this VSTestSettings toolSettings, string testAdapterPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestAdapterPath = testAdapterPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="VSTestSettings.TestAdapterPath"/></em></p>
        ///   <p>Forces the vstest.console.exe process to use custom test adapters from a specified path (if any) in the test run.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ResetTestAdapterPath(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestAdapterPath = null;
            return toolSettings;
        }
        #endregion
        #region Platform
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.Platform"/></em></p>
        ///   <p>Target platform architecture to be used for test execution.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetPlatform(this VSTestSettings toolSettings, VsTestPlatform platform)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Platform = platform;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="VSTestSettings.Platform"/></em></p>
        ///   <p>Target platform architecture to be used for test execution.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ResetPlatform(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Platform = null;
            return toolSettings;
        }
        #endregion
        #region Framework
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.Framework"/></em></p>
        ///   <p>Target .NET Framework version to be used for test execution.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetFramework(this VSTestSettings toolSettings, VsTestFramework framework)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Framework = framework;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="VSTestSettings.Framework"/></em></p>
        ///   <p>Target .NET Framework version to be used for test execution.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ResetFramework(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Framework = null;
            return toolSettings;
        }
        #endregion
        #region TestCaseFilters
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.TestCaseFilters"/> to a new list</em></p>
        ///   <p>Run tests that match the given expression.<para/><c>&lt;Expression&gt;</c> is of the format <c>&lt;property&gt;=&lt;value&gt;[|&lt;Expression&gt;]</c>.<para/>The <c>/TestCaseFilter</c> command line option cannot be used with the <c>/Tests</c> command line option.<para/>For information about creating and using expressions, see <a href="https://github.com/Microsoft/vstest-docs/blob/master/docs/filter.md">TestCase filter</a>.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetTestCaseFilters(this VSTestSettings toolSettings, params string[] testCaseFilters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestCaseFiltersInternal = testCaseFilters.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.TestCaseFilters"/> to a new list</em></p>
        ///   <p>Run tests that match the given expression.<para/><c>&lt;Expression&gt;</c> is of the format <c>&lt;property&gt;=&lt;value&gt;[|&lt;Expression&gt;]</c>.<para/>The <c>/TestCaseFilter</c> command line option cannot be used with the <c>/Tests</c> command line option.<para/>For information about creating and using expressions, see <a href="https://github.com/Microsoft/vstest-docs/blob/master/docs/filter.md">TestCase filter</a>.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetTestCaseFilters(this VSTestSettings toolSettings, IEnumerable<string> testCaseFilters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestCaseFiltersInternal = testCaseFilters.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="VSTestSettings.TestCaseFilters"/></em></p>
        ///   <p>Run tests that match the given expression.<para/><c>&lt;Expression&gt;</c> is of the format <c>&lt;property&gt;=&lt;value&gt;[|&lt;Expression&gt;]</c>.<para/>The <c>/TestCaseFilter</c> command line option cannot be used with the <c>/Tests</c> command line option.<para/>For information about creating and using expressions, see <a href="https://github.com/Microsoft/vstest-docs/blob/master/docs/filter.md">TestCase filter</a>.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings AddTestCaseFilters(this VSTestSettings toolSettings, params string[] testCaseFilters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestCaseFiltersInternal.AddRange(testCaseFilters);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="VSTestSettings.TestCaseFilters"/></em></p>
        ///   <p>Run tests that match the given expression.<para/><c>&lt;Expression&gt;</c> is of the format <c>&lt;property&gt;=&lt;value&gt;[|&lt;Expression&gt;]</c>.<para/>The <c>/TestCaseFilter</c> command line option cannot be used with the <c>/Tests</c> command line option.<para/>For information about creating and using expressions, see <a href="https://github.com/Microsoft/vstest-docs/blob/master/docs/filter.md">TestCase filter</a>.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings AddTestCaseFilters(this VSTestSettings toolSettings, IEnumerable<string> testCaseFilters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestCaseFiltersInternal.AddRange(testCaseFilters);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="VSTestSettings.TestCaseFilters"/></em></p>
        ///   <p>Run tests that match the given expression.<para/><c>&lt;Expression&gt;</c> is of the format <c>&lt;property&gt;=&lt;value&gt;[|&lt;Expression&gt;]</c>.<para/>The <c>/TestCaseFilter</c> command line option cannot be used with the <c>/Tests</c> command line option.<para/>For information about creating and using expressions, see <a href="https://github.com/Microsoft/vstest-docs/blob/master/docs/filter.md">TestCase filter</a>.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ClearTestCaseFilters(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TestCaseFiltersInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="VSTestSettings.TestCaseFilters"/></em></p>
        ///   <p>Run tests that match the given expression.<para/><c>&lt;Expression&gt;</c> is of the format <c>&lt;property&gt;=&lt;value&gt;[|&lt;Expression&gt;]</c>.<para/>The <c>/TestCaseFilter</c> command line option cannot be used with the <c>/Tests</c> command line option.<para/>For information about creating and using expressions, see <a href="https://github.com/Microsoft/vstest-docs/blob/master/docs/filter.md">TestCase filter</a>.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings RemoveTestCaseFilters(this VSTestSettings toolSettings, params string[] testCaseFilters)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(testCaseFilters);
            toolSettings.TestCaseFiltersInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="VSTestSettings.TestCaseFilters"/></em></p>
        ///   <p>Run tests that match the given expression.<para/><c>&lt;Expression&gt;</c> is of the format <c>&lt;property&gt;=&lt;value&gt;[|&lt;Expression&gt;]</c>.<para/>The <c>/TestCaseFilter</c> command line option cannot be used with the <c>/Tests</c> command line option.<para/>For information about creating and using expressions, see <a href="https://github.com/Microsoft/vstest-docs/blob/master/docs/filter.md">TestCase filter</a>.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings RemoveTestCaseFilters(this VSTestSettings toolSettings, IEnumerable<string> testCaseFilters)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(testCaseFilters);
            toolSettings.TestCaseFiltersInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Logger
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.Logger"/></em></p>
        ///   <p>Specify a logger for test results. Example: To log results into a Visual Studio Test Results File (TRX) use <c>/Logger:trx</c>.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetLogger(this VSTestSettings toolSettings, string logger)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Logger = logger;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="VSTestSettings.Logger"/></em></p>
        ///   <p>Specify a logger for test results. Example: To log results into a Visual Studio Test Results File (TRX) use <c>/Logger:trx</c>.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ResetLogger(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Logger = null;
            return toolSettings;
        }
        #endregion
        #region ListTests
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.ListTests"/></em></p>
        ///   <p>Lists discovered tests from the given test container.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetListTests(this VSTestSettings toolSettings, string listTests)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListTests = listTests;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="VSTestSettings.ListTests"/></em></p>
        ///   <p>Lists discovered tests from the given test container.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ResetListTests(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListTests = null;
            return toolSettings;
        }
        #endregion
        #region ListDiscoverers
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.ListDiscoverers"/></em></p>
        ///   <p>Lists installed test discoverers.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetListDiscoverers(this VSTestSettings toolSettings, bool? listDiscoverers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListDiscoverers = listDiscoverers;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="VSTestSettings.ListDiscoverers"/></em></p>
        ///   <p>Lists installed test discoverers.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ResetListDiscoverers(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListDiscoverers = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="VSTestSettings.ListDiscoverers"/></em></p>
        ///   <p>Lists installed test discoverers.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings EnableListDiscoverers(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListDiscoverers = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="VSTestSettings.ListDiscoverers"/></em></p>
        ///   <p>Lists installed test discoverers.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings DisableListDiscoverers(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListDiscoverers = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="VSTestSettings.ListDiscoverers"/></em></p>
        ///   <p>Lists installed test discoverers.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ToggleListDiscoverers(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListDiscoverers = !toolSettings.ListDiscoverers;
            return toolSettings;
        }
        #endregion
        #region ListExecutors
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.ListExecutors"/></em></p>
        ///   <p>Lists installed test executors.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetListExecutors(this VSTestSettings toolSettings, bool? listExecutors)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListExecutors = listExecutors;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="VSTestSettings.ListExecutors"/></em></p>
        ///   <p>Lists installed test executors.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ResetListExecutors(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListExecutors = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="VSTestSettings.ListExecutors"/></em></p>
        ///   <p>Lists installed test executors.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings EnableListExecutors(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListExecutors = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="VSTestSettings.ListExecutors"/></em></p>
        ///   <p>Lists installed test executors.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings DisableListExecutors(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListExecutors = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="VSTestSettings.ListExecutors"/></em></p>
        ///   <p>Lists installed test executors.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ToggleListExecutors(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListExecutors = !toolSettings.ListExecutors;
            return toolSettings;
        }
        #endregion
        #region ListLoggers
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.ListLoggers"/></em></p>
        ///   <p>Lists installed test loggers.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetListLoggers(this VSTestSettings toolSettings, bool? listLoggers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListLoggers = listLoggers;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="VSTestSettings.ListLoggers"/></em></p>
        ///   <p>Lists installed test loggers.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ResetListLoggers(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListLoggers = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="VSTestSettings.ListLoggers"/></em></p>
        ///   <p>Lists installed test loggers.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings EnableListLoggers(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListLoggers = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="VSTestSettings.ListLoggers"/></em></p>
        ///   <p>Lists installed test loggers.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings DisableListLoggers(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListLoggers = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="VSTestSettings.ListLoggers"/></em></p>
        ///   <p>Lists installed test loggers.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ToggleListLoggers(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListLoggers = !toolSettings.ListLoggers;
            return toolSettings;
        }
        #endregion
        #region ListSettingsProviders
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.ListSettingsProviders"/></em></p>
        ///   <p>Lists installed test settings providers.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetListSettingsProviders(this VSTestSettings toolSettings, bool? listSettingsProviders)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListSettingsProviders = listSettingsProviders;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="VSTestSettings.ListSettingsProviders"/></em></p>
        ///   <p>Lists installed test settings providers.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ResetListSettingsProviders(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListSettingsProviders = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="VSTestSettings.ListSettingsProviders"/></em></p>
        ///   <p>Lists installed test settings providers.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings EnableListSettingsProviders(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListSettingsProviders = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="VSTestSettings.ListSettingsProviders"/></em></p>
        ///   <p>Lists installed test settings providers.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings DisableListSettingsProviders(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListSettingsProviders = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="VSTestSettings.ListSettingsProviders"/></em></p>
        ///   <p>Lists installed test settings providers.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ToggleListSettingsProviders(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListSettingsProviders = !toolSettings.ListSettingsProviders;
            return toolSettings;
        }
        #endregion
        #region DiagnosticsFile
        /// <summary>
        ///   <p><em>Sets <see cref="VSTestSettings.DiagnosticsFile"/></em></p>
        ///   <p>Writes diagnostic trace logs to the specified file.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings SetDiagnosticsFile(this VSTestSettings toolSettings, string diagnosticsFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiagnosticsFile = diagnosticsFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="VSTestSettings.DiagnosticsFile"/></em></p>
        ///   <p>Writes diagnostic trace logs to the specified file.</p>
        /// </summary>
        [Pure]
        public static VSTestSettings ResetDiagnosticsFile(this VSTestSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiagnosticsFile = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region VsTestPlatform
    /// <summary>
    ///   Used within <see cref="VSTestTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<VsTestPlatform>))]
    public partial class VsTestPlatform : Enumeration
    {
        public static VsTestPlatform x86 = (VsTestPlatform) "x86";
        public static VsTestPlatform x64 = (VsTestPlatform) "x64";
        public static VsTestPlatform ARM = (VsTestPlatform) "ARM";
        public static explicit operator VsTestPlatform(string value)
        {
            return new VsTestPlatform { Value = value };
        }
    }
    #endregion
    #region VsTestFramework
    /// <summary>
    ///   Used within <see cref="VSTestTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<VsTestFramework>))]
    public partial class VsTestFramework : Enumeration
    {
        public static VsTestFramework Framework35 = (VsTestFramework) "Framework35";
        public static VsTestFramework Framework40 = (VsTestFramework) "Framework40";
        public static VsTestFramework Framework45 = (VsTestFramework) "Framework45";
        public static explicit operator VsTestFramework(string value)
        {
            return new VsTestFramework { Value = value };
        }
    }
    #endregion
}
