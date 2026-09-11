using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudPlayerDebuffDetailItem : MonoBehaviour
{
	public Color[] Colors;

	public UISprite Icon;

	public UILabel Name;

	public UILabel Desc;

	public Vector3 DescDownPos;

	public Vector3 DescUpPoc;

	private ulong m_Id;

	public void SetSpeicalBuffData(BuffShowTipsData data, int colorIndex)
	{
	}

	public void SetChildBuffData(ResourceID res, string desc, int colorIndex)
	{
	}

	public void SetData(ulong skillID, int colorIndex, COOFONGLAIB debuffType = COOFONGLAIB.EDeBuffType_PlayerSkill)
	{
	}

	private void SetSkill(ulong id)
	{
	}

	private void SetDebuff(ulong deBuffID, COOFONGLAIB deBuffType)
	{
	}

	private void SetBuff(ulong buffHUDUID)
	{
	}

	public int GetContentHeight()
	{
		return 0;
	}
}
