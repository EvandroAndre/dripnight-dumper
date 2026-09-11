using UnityEngine;

namespace COW;

public class SpectatorAirDropObject : MonoBehaviour
{
	private const uint AIRDROP_COLOR_ACTIVE = 4290380031u;

	private const uint AIRDROP_COLOR_DISACTIVE = 2812782591u;

	public UISprite AirDropSprite;

	public UILabel IndexLadel;

	public UIButton GotoBtn;

	private Vector3 m_Pos;

	private int m_Index;

	private bool m_IsActive;

	public bool Active
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Vector3 Scale
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 Position
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public void SetIndex(int index)
	{
	}

	public void SetPostion(Vector3 pos)
	{
	}

	private void OnGotoClick()
	{
	}
}
