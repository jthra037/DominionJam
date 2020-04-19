using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CardImportWindow : EditorWindow
{
    // Add menu named "My Window" to the Window menu
    [MenuItem("Window/Card Importer")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        CardImportWindow window = (CardImportWindow)GetWindow(typeof(CardImportWindow));
        window.Show();
    }

    //private void OnGUI()
    //{
    //    GUILayout.
    //}
}
