using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaveData
{
    [System.Serializable]
    public class PlayerProfile
    {
        public int Run_Forward;
        public int Run_Left;
        public int Run_Back;
        public int Run_Right;
        public int Attack_1 ;
        public int Attack_2 ;
        public int Attack_3 ;

        //public int Run_Forward =(int)KeyCode.W;
        //public int Run_Left = (int)KeyCode.A;
        //public int Run_Back = (int)KeyCode.S;
        //public int Run_Right = (int)KeyCode.D;
        //public int Attack_1 = (int)KeyCode.Alpha1;
        //public int Attack_2 = (int)KeyCode.Alpha2;
        //public int Attack_3 = (int)KeyCode.Alpha3;

    }
}