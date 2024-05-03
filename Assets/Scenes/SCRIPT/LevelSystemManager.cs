using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LevelsUnlockedsystem
{
    public class LevelSystemManager  : MonoBehaviour
    {
        private static LevelSystemManager instance;
        [SerializeField]
        private leveldata leveldata;
     
        public static LevelSystemManager Instance { get => instance; }
        public leveldata LevelData { get => leveldata; }
        private int currentLevel;
        public int CurrentLevel { get => currentLevel; set => currentLevel = value; }



        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {

                Destroy(gameObject);
            }
        }

    }
   
 
    

    [System.Serializable]
    public class leveldata
    {
        public int lastunlocked = 0;
        public Levelitem[] levelitemarray;
    }
    [System.Serializable ] 
    public class Levelitem{
        public bool unlocked;
        public int starAchived;
    }
}