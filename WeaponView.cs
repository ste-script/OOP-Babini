namespace OOP_Babini
{
    public class WeaponView

    {

        public Weapon Weapon { get; }

        public Texture Texture { get; }



        public WeaponView(Weapon weapon, Texture texture)
        {
            this.Weapon = weapon;
            this.Texture = texture;
        }

    }
}
