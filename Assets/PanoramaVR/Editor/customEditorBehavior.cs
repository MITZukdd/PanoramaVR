using UnityEditor;
using UnityEngine;

public class ToggleVisibilityEditor : Editor
{
    [MenuItem("Tools/Toggle Visibility _I")] // Shortcut: I
    private static void ToggleVisibility()
    {
        if (Selection.activeGameObject != null)
        {
            GameObject selectedObject = Selection.activeGameObject;
            selectedObject.SetActive(!selectedObject.activeSelf);
        }
        else
        {
            Debug.LogWarning("No GameObject selected!");
        }
    }
}

public class PrintGameObjectDistance : Editor
{
    [MenuItem("Tools/Print Game Object Distance _U")] // Shortcut: U
    private static void PrintDistance()
    {
        var mc = GameObject.Find("Viewpoint");
        var go = Selection.activeGameObject;
        var dist = Vector3.Distance(mc.transform.position, go.transform.position);
        Debug.Log(dist);
    }
}

public class PrintGameObjectName : Editor
{
    [MenuItem("Tools/Print Game Object Name _B")] // Shortcut: U
    private static void PrintName()
    {
        var go = Selection.activeGameObject;
        Debug.Log(go.name);
    }
}

public class MoveCloserToViewPoint : Editor
{
    [MenuItem("Tools/Move Closer to ViewPoint _G")] // Shortcut: G
    private static void MoveCloser()
    {
        GameObject go = Selection.activeGameObject;
        GameObject viewPoint = GameObject.Find("Viewpoint");
        Vector3 direction = (go.transform.position - viewPoint.transform.position).normalized;
        float targetDistance = 2.1f;

        // make it reversible if moved by accident
        Undo.RecordObject(go.transform, "Move to 2 Units from ViewPoint");

        go.transform.position = viewPoint.transform.position + direction * targetDistance;

        

        // make gamobject face the viewpoint
        go.transform.LookAt(viewPoint.transform);
        go.transform.Rotate(0, 180, 0);

        Debug.Log($"Moved {go.name} closer to ViewPoint");
    }
}