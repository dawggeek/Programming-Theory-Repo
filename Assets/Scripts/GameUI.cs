using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI playerName;

    // Start is called before the first frame update
    void Start()
    {
        playerName.text = PersistenceManager.Instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
