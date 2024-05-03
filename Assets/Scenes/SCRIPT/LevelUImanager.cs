using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LevelsUnlockedsystem
{
    public class LevelUImanager : MonoBehaviour
    {
        [SerializeField] private GameObject levelbtnGridholder;
        [SerializeField] private Leveluiscript levelbtnprefab;
        public void Start()
        {
            initializeui();
        }
        public void initializeui()
        {
            Levelitem[] levelitemArray = LevelSystemManager.Instance.LevelData.levelitemarray;
            for (int i = 0; i < levelitemArray.Length; i++)
            {
                Leveluiscript levelbutton = Instantiate(levelbtnprefab,levelbtnGridholder.transform);
                levelbutton.Setlevelbutton(levelitemArray[i], i, i == LevelSystemManager.Instance.LevelData.lastunlocked);
                    
            }
        }


    }
}
