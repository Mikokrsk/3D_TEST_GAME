using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SavePlayerData
{
    [System.Serializable]
    public class Player_Save
    {
        public  float Health_max;
        public float Health;
        public float Position_x;
        public float Position_y;
        public float Positios_z;

        public Player_Save()
        {
             Health_max = 100;
             Health = 80;
             Position_x = 1f;
             Position_y = 1f;
             Positios_z = 1f;
        }

    }
}