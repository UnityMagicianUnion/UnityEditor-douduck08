using UnityEngine;
using UnityEditor;

public class ShortCutLockInspector {

    [MenuItem ("Edit/Lock2 %l")]
    public static void Lock () {
        ActiveEditorTracker.sharedTracker.isLocked = !ActiveEditorTracker.sharedTracker.isLocked;
        ActiveEditorTracker.sharedTracker.ForceRebuild ();
    }

    [MenuItem ("Edit/Lock %l", true)]
    public static bool Valid () {
        return ActiveEditorTracker.sharedTracker.activeEditors.Length != 0;
    }
}
