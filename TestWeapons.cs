using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP_Babini.Tests
{
    /// <summary>
    /// Test WeaponView
    /// </summary>
    [TestClass()]
    public class TestWeaponView
    {
        private static readonly Weapon weapon = new Weapon();
        private static readonly Texture texture = new Texture();
        private readonly WeaponView weaponView = new WeaponView(weapon, texture);

        [TestMethod()]
        public void TestWeaponViewWeapon()
        {
            Assert.AreEqual(weaponView.Weapon, weapon);
        }

        [TestMethod()]
        public void TestWeaponViewTexture()
        {
            Assert.AreEqual(weaponView.Texture, texture);
        }
    }
    /// <summary>
    /// Test WeaponViewFactory
    /// </summary>
    [TestClass()]
    public class TestWeaponViewFactory
    {

        [TestMethod()]
        public void TestWeaponViewFactoryWeaponLevel()
        {
            WeaponView w = WeaponViewFactory.CreateRandomWeaponView(Maps.MAP_2);
            Assert.IsNotNull(w.Weapon);
            Assert.IsNotNull(w.Texture);
        }

        [TestMethod()]
        public void TestWeaponViewFactoryPlayerWeapon()
        {
            WeaponView w = WeaponViewFactory.CreatePlayerWeaponView();
            Assert.IsNotNull(w.Weapon);
            Assert.IsNotNull(w.Texture);
        }
    }
}