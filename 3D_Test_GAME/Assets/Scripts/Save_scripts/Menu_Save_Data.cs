using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaveData
{
    [System.Serializable]
    public class Menu_Save
    {
        public int Run_Forward ;
        public int Run_Left ;
        public int Run_Back ;
        public int Run_Right;
        public int Attack_1 ;
        public int Attack_2 ;
        public int Attack_3 ;

        public bool isFull_screen;
        public int ResolutionIndex;
        public int QualityIndex;

       public Menu_Save()
        {
            Run_Forward= (int)KeyCode.W ;
            Run_Left= (int)KeyCode.A;
            Run_Back= (int)KeyCode.S;
            Run_Right = (int)KeyCode.D;
            Attack_1 = (int)KeyCode.Mouse0;
            Attack_2= (int)KeyCode.Mouse1;
            Attack_3 = (int)KeyCode.G;

            isFull_screen = true;
            ResolutionIndex = 0;
            QualityIndex = 0;
        }

    }
}