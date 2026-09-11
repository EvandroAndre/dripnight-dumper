using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UISPHudBuffItemView : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public UISPHudBuffItemView _003C_003E4__this;

		public COOFONGLAIB deBuffType;

		public uint level;

		public float leftTime;

		public float totalTime;

		internal void _003CSetDebuffData_003Eb__0()
		{
		}
	}

	public UISprite BuffIcon;

	public UISprite BuffBg;

	public UILabel NumLabel;

	public UILabel LevelLabel;

	public UISprite BuffCD;

	public Color[] Colors;

	public UILabel ChildBuffCountLabel;

	private Color m_BuffColor;

	private Color m_DeBuffColor;

	private bool m_IsBuff;

	private bool m_IsNum;

	private uint m_CDDelayCall;

	private const uint MAX_DEBUFF_DURATION = 99999999u;

	private MFHOLGEKNLI _003CBuffBevTypeID_003Ek__BackingField;

	private float m_TotalLife;

	private float m_CurrentLife;

	public MFHOLGEKNLI BuffBevTypeID
	{
		get
		{
			return _003CBuffBevTypeID_003Ek__BackingField;
		}
		set
		{
			_003CBuffBevTypeID_003Ek__BackingField = value;
		}
	}

	private void OnDestroy()
	{
	}

	public void SetBuffData(ResourceID buffIcon)
	{
	}

	public void SetBuffBevTypeID(MFHOLGEKNLI buffBevTypeID)
	{
	}

	public void UpdateBuffLifeTime(float duration)
	{
	}

	public void UpdateCDTime(float leftTime, float durationTime = 0f)
	{
	}

	public void UpdateLayers(uint level)
	{
	}

	public void UpdateChildCount(int count)
	{
	}

	private void UpdateCDProgress()
	{
	}

	private void Update()
	{
	}

	public void SetDebuffData(ulong deBuffID, COOFONGLAIB deBuffType, uint level, BHGGAEEHJCO playerID, float startTime, float endTime)
	{
	}

	public void SetDebuffNum(int num)
	{
	}

	public void SetBuffNum(int num)
	{
	}
}
