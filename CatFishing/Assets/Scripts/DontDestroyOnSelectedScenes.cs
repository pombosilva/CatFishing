using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyOnSelectedScenes : MonoBehaviour {
    
    public List<string> sceneNames;
    public string instanceName;

    private void Start() {
        DontDestroyOnLoad(this.gameObject);

        // subscribe to the scene load callback
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        // delete any potential duplicates that might be in the scene already, keeping only this one 
        CheckForDuplicateInstances();

        // check if this object should be deleted based on the input scene names given 
        CheckIfSceneInList();
    }

    void CheckForDuplicateInstances() {
        // cache all objects containing this component
        DontDestroyOnSelectedScenes[] collection = FindObjectsOfType<DontDestroyOnSelectedScenes>();

        // iterate through the objects with this component, deleting those with matching identifiers
        foreach (DontDestroyOnSelectedScenes obj in collection)
            if(obj == this) // avoid deleting the object running this check
                if (obj.instanceName == instanceName)
                    Destroy(obj.gameObject, 1f);
    }

    void CheckIfSceneInList() {
        string currentScene = SceneManager.GetActiveScene().name;

        if (!sceneNames.Contains(currentScene)) {
            // unsubscribe to the scene load callback
            SceneManager.sceneLoaded -= OnSceneLoaded;
            DestroyImmediate(this.gameObject);
        }
    }
}