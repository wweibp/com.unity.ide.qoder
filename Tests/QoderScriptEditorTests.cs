using System.IO;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using VSCodeEditor;
using System.Reflection;

namespace QoderEditor.Tests
{
    public class QoderScriptEditorTests
    {
        [Test]
        public void QoderScriptEditor_CanBeCreated()
        {
            var discovery = new QoderDiscovery();
            var projectGeneration = new ProjectGeneration(Directory.GetParent(Application.dataPath).FullName);
            var editor = new QoderScriptEditor(discovery, projectGeneration);
            Assert.NotNull(editor);
        }

        [Test]
        public void QoderScriptEditor_MetaFilesExcludedByDefault()
        {
            // 验证VSCode设置中的.meta文件默认被排除
            var projectGeneration = new ProjectGeneration(Directory.GetParent(Application.dataPath).FullName);
            var field = typeof(ProjectGeneration).GetField("k_SettingsJson", BindingFlags.NonPublic | BindingFlags.Static);
            var settingsJson = field.GetValue(null) as string;
            
            // 检查设置中.meta文件是否被设置为false（排除）
            Assert.IsTrue(settingsJson.Contains("\"**/*.meta\":false"), "Meta files should be excluded by default in VSCode settings");
        }

        [Test]
        public void QoderScriptEditor_SupportedFileNames_AreCorrect()
        {
            var discovery = new QoderDiscovery();
            var projectGeneration = new ProjectGeneration(Directory.GetParent(Application.dataPath).FullName);
            var editor = new QoderScriptEditor(discovery, projectGeneration);
            
            // 这里可以添加对支持的文件名的测试
            // 由于QoderScriptEditor中的k_SupportedFileNames是私有的，我们需要使用反射来访问
            var field = typeof(QoderScriptEditor).GetField("k_SupportedFileNames", BindingFlags.NonPublic | BindingFlags.Static);
            var supportedFileNames = field.GetValue(null) as string[];
            
            Assert.Contains("qoder.exe", supportedFileNames);
            Assert.Contains("qoder.app", supportedFileNames);
            Assert.Contains("qoder.cmd", supportedFileNames);
            Assert.Contains("qoder", supportedFileNames);
            Assert.Contains("Qoder.app", supportedFileNames);
            Assert.Contains("Qoder.exe", supportedFileNames);
        }
    }
}