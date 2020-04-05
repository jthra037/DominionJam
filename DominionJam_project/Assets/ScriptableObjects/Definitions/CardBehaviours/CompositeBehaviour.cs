using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CompositeBehaviour", menuName = "Cards/Behaviours/Composite", order = 1)]
public class CompositeBehaviour : CardBehaviourAsset
{
	[SerializeField]
	private CardBehaviourAsset[] internals;

	private Action _behaviour = null;

	private Action behaviour
	{
		get
		{
			if (_behaviour == null)
			{
				assembleBehaviours();
			}

			return _behaviour;
		}
	}

	public override Action GetExecutableBehaviour()
	{
		return behaviour;
	}

	private void assembleBehaviours()
	{
		foreach(CardBehaviourAsset cba in internals)
		{
			_behaviour += cba.GetExecutableBehaviour();
		}
	}
}
