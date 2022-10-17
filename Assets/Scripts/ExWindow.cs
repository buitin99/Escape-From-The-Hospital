using UnityEngine;
using UnityEditor;

public class ExWindow : EditorWindow
{
    [MenuItem("Window/Ex")]
    public static void ShowWindow()
    {
        GetWindow<ExWindow>();
    }
    void OnGUI() 
    {
        GUILayout.Label("label",EditorStyles.boldLabel);

        // my
    }

}
