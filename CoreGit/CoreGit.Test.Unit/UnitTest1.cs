
using NUnit.Framework;
using System.Diagnostics;

namespace RegisterTest
{
    public class Tests
    {
        RegisterLib.Register uut_;

        [SetUp]
        public void Setup()
        {
            uut_ = new RegisterLib.Register();
        }

        [Test]
        public void Test1()
        {
            Assert.That(
                ()=> uut_.AddItem(-1),
                Throws.TypeOf<System.ArgumentException>()
            );
        }

        [Test]
        public void Add_OneItem_ItemCountCorrect()
        {
            uut_.AddItem(5.0);
            Assert.That(uut_.NItems, Is.EqualTo(1));
        }

        [Test]
        public void Add_OneItem_TotalCorrect()
        {
            uut_.AddItem(5.5);
            Assert.That(uut_.Total, Is.EqualTo(5.5));
        }

        [Test]
        public void Add_TwoItems_CountIsCorrect()
        {
            uut_.AddItem(1.2);
            uut_.AddItem(2.6);
            Assert.That(uut_.NItems, Is.EqualTo(2));
        }

        [Test]
        public void Add_TwoItems_TotalIsCorrect()
        {
            uut_.AddItem(1.2);
            uut_.AddItem(2.6);
            Assert.That(uut_.Total, Is.EqualTo(3.8));
        }
    }
}