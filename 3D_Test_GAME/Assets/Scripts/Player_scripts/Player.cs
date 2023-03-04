using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public const string saveKey = "Player_Save_Data";

    public static float health_max;
    public static float health;
  //  public static float position_x;
  //  public static float position_y;
  //  public static float positios_z;
    public static Transform transform;

    private void Start()
    {
        transform = GetComponent<Transform>();
        Load();
    }

    public void Save_Player()
    {
        SaveManager.Save(saveKey, GetSaveSnapshot());
    }
   
    private SavePlayerData.Player_Save GetSaveSnapshot()
    {
        var data = new SavePlayerData.Player_Save()
        {
            Health = health,
            Health_max = health_max,
            /*Position_x=position_x,
            Position_y=position_y,
            Positios_z=positios_z,*/
            Position_x = transform.position.x,
            Position_y = transform.position.y,
            Positios_z = transform.position.z,

        };
        return data;
    }
   
    private void Load()
    {
        var data = SaveManager.Load<SavePlayerData.Player_Save>(saveKey);
        health = data.Health;
        health_max = data.Health_max;
        /*position_x= data.Position_x;
        position_y= data.Position_y;
        positios_z= data.Positios_z;
        transform.position = new Vector3( position_x,position_y,positios_z);*/
        transform.position = new Vector3(data.Position_x,data.Position_y,data.Positios_z);
    }

}
