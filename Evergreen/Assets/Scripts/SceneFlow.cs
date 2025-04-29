using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SceneFlow : MonoBehaviour
{
    public TMP_Text leavesCount;
    public int currentLeaves;
    int initialLeaves;

    void Awake()
    {
        initialLeaves = FindObjectsOfType<Leaf>().Length;
    }

    
    void Update()
    {
        currentLeaves = initialLeaves - FindObjectsOfType<Leaf>().Length;
        leavesCount.text = $"{currentLeaves} / {initialLeaves}";
    }

    public bool AllCollected()
    {
        if(currentLeaves == initialLeaves)
        {
            return true;
        }
        return false;
    }
}
