using System;
using UnityEngine;


public class PickerAttribute : PropertyAttribute
{
	public Type Type;

	public PickerAttribute(Type type)
	{
		Type = type;
	}
}
