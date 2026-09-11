using System.Collections.Generic;
using proto;

namespace COW;

internal class AutoTaskClaimMailRewards : AutoPopupTask
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public UIModelMail modelMail;
	}

	private sealed class _003C_003Ec__DisplayClass2_1
	{
		public MailInfo info;

		public _003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals1;

		internal void _003CDo_003Eb__0()
		{
		}
	}

	private List<GiftRewardPopupData> m_giftRewardPopupData;

	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public override bool Do()
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}
}
