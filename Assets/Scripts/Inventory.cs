using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public GameObject invPanel;


    [Header("Inventory Size")]
    public bool[] isFull;
    public GameObject[] slots;

    public TMP_Text invText;


    public int Ore;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        showhideInventory();

        updateInventory();
    }

    public void showhideInventory()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if(!invPanel.activeSelf)
            {
                invPanel.SetActive(true);
            }    
            else
            {
                invPanel.SetActive(false);
            }
        }
    }

    public void updateInventory()
    {
        invText.text = "" + Ore + ;
    }


}
