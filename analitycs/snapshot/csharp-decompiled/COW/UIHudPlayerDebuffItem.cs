using UnityEngine;
using message;

namespace COW;

public class UIHudPlayerDebuffItem : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public UIHudPlayerDebuffItem _003C_003E4__this;

		public COOFONGLAIB deBuffType;

		public uint level;

		public float leftTime;

		public float totalTime;

		internal void _003CSetData_003Eb__0()
		{
		}
	}

	public UISprite Icon;

	public UISprite CD;

	public UILabel BuffLevel;

	public UILabel AfterNum;

	private ulong m_DeBuffID;

	private uint m_CDDelayCall;

	private const uint MAX_DEBUFF_DURATION = 99999999u;

	public void SetData(ulong deBuffID, COOFONGLAIB deBuffType, uint level, float startTime, float endTime)
	{
	}

	public void SetNum(int num)
	{
	}

	private void OnDestroy()
	{
	}
}
