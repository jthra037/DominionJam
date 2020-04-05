using UnityEngine;

[CreateAssetMenu(fileName = "CardAsset", menuName = "Cards/CardAsset", order = 1)]
public class CardAsset : ScriptableObject
{
	[SerializeField]
	private string name;

	[SerializeField]
	private int actions;

	[SerializeField]
	private int cards;

	[SerializeField]
	private Sprite cardFront;

	[SerializeField]
	private CardBehaviourAsset behaviourAsset;

	public string Name => name;
	public int Actions => actions;
	public int Cards => cards;

	public Sprite CardFront => cardFront;
	public System.Action Behaviour => behaviourAsset.GetExecutableBehaviour();
}
