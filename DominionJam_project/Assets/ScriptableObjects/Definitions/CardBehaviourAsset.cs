using UnityEngine;

public abstract class CardBehaviourAsset : ScriptableObject
{
	public abstract System.Action GetExecutableBehaviour();
}
