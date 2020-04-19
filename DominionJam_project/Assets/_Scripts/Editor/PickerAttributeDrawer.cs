using System;
using UnityEngine;
using UnityEditor;
using System.Reflection;

[CustomPropertyDrawer(typeof(PickerAttribute))]
public class PickerAttributeDrawer : PropertyDrawer
{
    private PickerAttribute picker;

	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
		EditorGUI.BeginProperty(position, label, property);
        picker = (PickerAttribute)attribute;

        handlePropType(property);

        property.serializedObject.ApplyModifiedProperties();
        EditorGUI.EndProperty();
	}

    private void handlePropType(Rect position, SerializedProperty prop, GUIContent label)
    {
        switch(prop.propertyType)
        {
            //case SerializedPropertyType.ObjectReference:
            //    setObjectRef(prop);
            //    break;
            //case SerializedPropertyType.String:
            //    setStringRef(prop);
            //    break;
            case SerializedPropertyType.Generic:
                setGenericRef(position, prop, label);
                break;
        }
    }

    private void setObjectRef(SerializedProperty prop)
    {

    }

    private void setStringRef(SerializedProperty prop)
    {

    }

    private void setGenericRef(Rect position, SerializedProperty prop, GUIContent label)
    {
        FieldInfo field = picker.Type.GetField(prop.propertyPath);
        if (field != null)
        {
            object value = field.GetValue(prop.serializedObject);
        }

        prop.serializedObject.Update();
        EditorGUI.BeginChangeCheck();
        string newObjectPath = EditorGUI.ObjectField(position, picker.Type.Name, prop.serializedObject.targetObject, picker.Type, false);

        if (EditorGUI.EndChangeCheck())
        {
            string newPath = AssetDatabase.GetAssetPath(newObject);
            prop.objectReferenceValue = getAsset(newObject, newPath);
        }
    }

    private T getAsset<T>(T instance, string path) where T : UnityEngine.Object
    {
        return AssetDatabase.LoadAssetAtPath<T>(path);
    }

//	object oldObject = property.objectReferenceValue;
//        if (oldObject == null)
//        {
//            oldObject = property.stringValue;
//        }
//        property.serializedObject.Update();
//        EditorGUI.BeginChangeCheck();
//        object newObject = EditorGUI.ObjectField(position, picker.Type.Name, oldObject, picker.Type, false);
//
//        if (EditorGUI.EndChangeCheck())
//        {
//            string newPath = AssetDatabase.GetAssetPath(newObject);
//            property.objectReferenceValue = getAsset(newObject, newPath);
//        }
//
}
