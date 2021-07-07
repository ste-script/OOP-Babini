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
}