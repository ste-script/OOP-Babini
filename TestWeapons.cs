using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP_Babini.Tests
{
    [TestClass()]
    public class TestWeaponView
    {
        private static Weapon weapon = new Weapon();
        private static Texture texture = new Texture();
        private WeaponView weaponView = new WeaponView(weapon, texture);

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