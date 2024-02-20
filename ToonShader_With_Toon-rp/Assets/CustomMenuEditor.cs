#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public class CustomMenuEditor : Editor
{
    [MenuItem("PlayerPrefs/Reset All")]
    private static void Something()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("All PlayerPrefs data is deleted.");
    }
}

#endif

