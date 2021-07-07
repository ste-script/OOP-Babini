namespace OOP_Babini
{
    public class Weapon
    {
    }

    public class Texture
    {
        public Texture()
        {

        }
        public Texture(string texturePath)
        {
            TexturePath = texturePath;
        }

        public string TexturePath { get; }
    }
}