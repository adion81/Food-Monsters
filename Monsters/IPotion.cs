namespace PocketMonsters.Monsters
{
    public interface IPotion
    {
        string Name {get;set;}
        
        void Use(Monster target);
    }
}