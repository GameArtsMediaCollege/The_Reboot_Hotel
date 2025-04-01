using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(Character_AI))]
public class BuildEditor : Editor
{
    Character_AI characterAI;


    public override void OnInspectorGUI()
    {
        Character_AI characterAI = target as Character_AI;

        if (GUILayout.Button("voeg Wander script toe"))
        {
            characterAI.addwander();
        }
        if (GUILayout.Button("voeg Actie (enkel) script toe"))
        {
            characterAI.addActionSingle();
        }
        if (GUILayout.Button("voeg Actie (geloopt) script toe"))
        {
            characterAI.addActionLoop();
        }
        if (GUILayout.Button("Voeg Interactie script toe"))
        {
            characterAI.addInteraction();
        }
    }
}
