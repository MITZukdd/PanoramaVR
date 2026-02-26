using System;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

//  This script defines a menu item in the unity editor that allows you to embed the panoramavr package and make it writable
public class EmbedPackageHelper : Editor
{
    static string targetPackage = "com.mitz.panoramavr";
    static EmbedRequest embedRequest;

    [MenuItem("Tools/Embed PanoramaVR Package")]
    static void EmbedPackage()
    {
        Debug.Log($"Starting the embedding process for package: {targetPackage}");
        embedRequest = Client.Embed(targetPackage);
        EditorApplication.update += TrackProgress; 
    }

    static void TrackProgress()
    {
        if (embedRequest.IsCompleted)
        {
            // Check the status of the request
            if (embedRequest.Status == StatusCode.Success)
            {
                Debug.Log($"Successfully embedded {targetPackage} package: {embedRequest.Result.packageId}");
            }
            else if (embedRequest.Status >= StatusCode.Failure)
            {
                Debug.LogError($"Failed to embed {targetPackage} package: {embedRequest.Error.message}");
            }

            // Stop tracking the progress
            EditorApplication.update -= TrackProgress;
        }
    }

}
