using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Scores", menuName = "Scores", order = 10)]
public class Score : ScriptableObject
{
    public int[] PlayerScore = new int[10];

    private void OnEnable()
    {
        hideFlags = HideFlags.DontUnloadUnusedAsset;
    }
}

