using UnityEngine;


public class CardAsset : ScriptableObject
{
	[SerializeField]
	private string name;

	[SerializeField]
	private int actions;

	[SerializeField]
	private int cards;

	[SerializeField]
	private CardBehaviourAsset behaviourAsset;

	public string Name => name;
	public int Actions => actions;
	public int Cards => cards;
	public System.Action Behaviour => behaviourAsset.GetExecutableBehaviour();
}
