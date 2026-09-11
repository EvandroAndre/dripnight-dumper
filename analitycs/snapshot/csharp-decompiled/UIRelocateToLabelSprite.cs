using UnityEngine;

public class UIRelocateToLabelSprite : MonoBehaviour
{
	public enum RelocateUpdate
	{
		AtStart,
		InUpdate
	}

	private RelocateUpdate UpdateMode;

	private UILabel toLabel;

	private string spriteString;

	private int locateSpriteIndex;

	private GameObject visibleObj;

	private UIWidget target;

	private string lastText;

	public UILabel ToLabel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int LocateSpriteIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public GameObject Obj => null;

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
