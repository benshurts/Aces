using UnityEngine;

[CreateAssetMenu(menuName = "Games/Gamemode")]
public class GamemodeData : ScriptableObject
{
    public string levelName = "Name of Scene";
    public string gamemodeName = "Name of Gamemode";
    public byte maxPlayers = 6;
    public string[] teamNames;
    
}
