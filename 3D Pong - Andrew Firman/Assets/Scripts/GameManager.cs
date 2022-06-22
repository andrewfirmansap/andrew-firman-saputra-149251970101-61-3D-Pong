using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int maxBallAmount;
    public List<GameObject> ballTemplateList;
    private List<GameObject> ballList;
    // Start is called before the first frame update
    void Start()
    {
        powerUpList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
