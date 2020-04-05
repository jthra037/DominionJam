using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IntegerExtensions
{
	public static bool IsBitSet(this int value, int bitId)
	{
		return ((1 << bitId) & value) == 0;
	}
}
