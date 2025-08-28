using NUnit.Framework;
using System.Linq;
using QoderEditor;
using Unity.CodeEditor;

namespace QoderEditor.Tests
{
    [TestFixture]
    public class QoderDiscoveryTests
    {
        private QoderDiscovery _discovery;

        [SetUp]
        public void SetUp()
        {
            _discovery = new QoderDiscovery();
        }

        [Test]
        public void PathCallback_ReturnsArray()
        {
            var installations = _discovery.PathCallback();
            Assert.IsNotNull(installations);
            Assert.IsInstanceOf<CodeEditor.Installation[]>(installations);
        }

        [Test]
        public void PathCallback_ConsistentResults()
        {
            var first = _discovery.PathCallback();
            var second = _discovery.PathCallback();
            
            Assert.AreEqual(first.Length, second.Length);
            
            for (int i = 0; i < first.Length; i++)
            {
                Assert.AreEqual(first[i].Path, second[i].Path);
                Assert.AreEqual(first[i].Name, second[i].Name);
            }
        }

        [Test]
        public void Installation_HasValidName()
        {
            var installations = _discovery.PathCallback();
            
            foreach (var installation in installations)
            {
                Assert.IsNotNull(installation.Name);
                Assert.IsTrue(installation.Name.Contains("Qoder"));
            }
        }

        [Test]
        public void Installation_HasValidPath()
        {
            var installations = _discovery.PathCallback();
            
            foreach (var installation in installations)
            {
                Assert.IsNotNull(installation.Path);
                Assert.IsNotEmpty(installation.Path);
            }
        }
    }
}