using System;
using System.Collections.Generic;

namespace OOP_Babini
{
    public static class WeaponViewFactory
    {
        public class Weapons
        {
            public static readonly Weapons BASEBALL_BAT = new Weapons("Weapons/baseballBat.png", "Mazza da baseball", WeaponType.MELEE);
            public static readonly Weapons BRASS_KNUCKLES = new Weapons("Weapons/BrassKnuckles.png", "Tirapugni", WeaponType.MELEE);
            public static readonly Weapons HAMMER = new Weapons("Weapons/hammer.png", "Martello", WeaponType.MELEE);
            public static readonly Weapons KNIFE = new Weapons("Weapons/knife.png", "Coltello", WeaponType.MELEE);
            public static readonly Weapons PUNCH = new Weapons("Weapons/punch.png", "Pugno", WeaponType.MELEE);
            public static readonly Weapons REVOLVER = new Weapons("Weapons/Revolver.png", "Rivoltella", WeaponType.RANGED);

            public string TexturePath { get; }
            public string WeaponName { get; }
            public WeaponType Type { get; }

            public Weapons(string path, string name, WeaponType type)
            {
                this.TexturePath = path;
                this.WeaponName = name;
                this.Type = type;
            }
        }

        private static Random random = new Random();
        private static IList<Weapons> WeaponList = new List<Weapons>();

        private static Weapons GetRandomWeapon()
        {
            if (WeaponList.Count == 0)
            { 
                WeaponList.Add(Weapons.BASEBALL_BAT);
                WeaponList.Add(Weapons.BRASS_KNUCKLES);
                WeaponList.Add(Weapons.HAMMER);
                WeaponList.Add(Weapons.KNIFE);
                WeaponList.Add(Weapons.PUNCH);
                WeaponList.Add(Weapons.REVOLVER);
            }
            return WeaponList[random.Next(WeaponList.Count)];
        }

        public static WeaponView CreateRandomWeaponView(Maps map)
        {
            Weapons w = GetRandomWeapon();
            return new WeaponView(WeaponFactory.createRandomWeaponLevel(w.WeaponName, map, w.Type),
                    new Texture(w.TexturePath));
        }

        public static WeaponView CreatePlayerWeaponView()
        {
            Weapons w = Weapons.PUNCH;
            return new WeaponView(WeaponFactory.createRandomWeaponLevel(w.WeaponName, Maps.MAP_1, w.Type),
                    new Texture(w.TexturePath));
        }
    }
}
