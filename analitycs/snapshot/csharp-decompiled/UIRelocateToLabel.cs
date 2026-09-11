using UnityEngine;

public class UIRelocateToLabel : MonoBehaviour
{
	public enum RelocateUpdate
	{
		AtStart,
		InUpdate
	}

	public enum RelocatePosition
	{
		ToLeft,
		ToRight
	}

	private RelocateUpdate UpdateMode;

	private RelocatePosition LocatePosition;

	private UILabel toLabel;

	private UIWidget target;

	private string lastText;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdatePosition()
	{
	}
}
