using System;

namespace COW;

public class AutoTaskCSUnlockMatchReward : AutoPopupTask
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__2_0;

		internal CommonRewardItemInfo _003CDo_003Eb__2_0(BaseItemInfo item)
		{
			return null;
		}
	}

	private bool m_IsCSDone;

	private UnlockMatchRewardWndCfg m_CurrentCfg;

	public override bool Do()
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}

	public override int[] NeedHttpRequests()
	{
		return null;
	}

	private void OnUnlockRewardWndClose(object[] param)
	{
	}
}
