using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using TMPro;
using UnityEngine;

public class coincollider : MonoBehaviour
{
    // Start is called before the first frame update
    private  int coin=0;
    public TextMeshProUGUI cointext;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "coin")
        {
            coin++;
            cointext.text="Coin:" +coin.ToString();
            Debug.Log(coin);
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
