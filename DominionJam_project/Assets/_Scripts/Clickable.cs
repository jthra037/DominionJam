using UnityEngine;

public abstract class Clickable : MonoBehaviour
{
	private void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(0))
		{
			onClick();
		}
	}

	protected abstract void onClick();

}