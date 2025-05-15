using UnityEngine;

using UnityEditor;
using ImmerzaSDK.Settings;

[CustomPropertyDrawer(typeof(LaunchOptionValue))]
public class LaunchOptionsValueDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (property == null)
        {
            return;
        }

        SerializedProperty nameProp = property.FindPropertyRelative("name");
        SerializedProperty typeProp = property.FindPropertyRelative("type");
        SerializedProperty intProp = property.FindPropertyRelative("intValue");
        SerializedProperty floatProp = property.FindPropertyRelative("floatValue");
        SerializedProperty stringProp = property.FindPropertyRelative("stringValue");
        SerializedProperty boolProp = property.FindPropertyRelative("boolValue");

        float lineHeight = EditorGUIUtility.singleLineHeight;
        float spacing = 2.0f;
        Rect nameRect = new Rect(position.x, position.y, position.width, lineHeight);
        Rect typeRect = new Rect(position.x, position.y + lineHeight + spacing, position.width, lineHeight);
        Rect valueRect = new Rect(position.x, position.y + 2 * (lineHeight + spacing), position.width, lineHeight);

        EditorGUI.PropertyField(nameRect, nameProp, new GUIContent("Name"));
        EditorGUI.PropertyField(typeRect, typeProp, new GUIContent("Type"));

        switch ((LaunchOptionValueType)typeProp.enumValueIndex)
        {
            case LaunchOptionValueType.Int:
                EditorGUI.PropertyField(valueRect, intProp, new GUIContent("Value"));
                break;
            case LaunchOptionValueType.Float:
                EditorGUI.PropertyField(valueRect, floatProp, new GUIContent("Value"));
                break;
            case LaunchOptionValueType.String:
                EditorGUI.PropertyField(valueRect, stringProp, new GUIContent("Value"));
                break;
            case LaunchOptionValueType.Bool:
                EditorGUI.PropertyField(valueRect, boolProp, new GUIContent("Value"));
                break;
        }
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUIUtility.singleLineHeight * 3 + 4;
    }
}