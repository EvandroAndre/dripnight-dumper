using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIBigEventNaviPopBaseController : UINaviPopController
{
	public virtual ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public virtual EActivity.SubType GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	public virtual UIModelBigEvent.EBigEventEntranceID GetEntranceId()
	{
		return UIModelBigEvent.EBigEventEntranceID.Main;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public void GoToV2Navigation(UINavigationUtil.UINavigationFrom from, uint gopos, string param = null, object extra = null)
	{
	}

	public void LogClick(string posfix)
	{
	}

	public void SetCdnTextureView(UINetworkTextureExt cdnTexture, int cndType)
	{
	}

	protected bool PlayAnim(Animation anim, string strAnim, out float length)
	{
		length = default(float);
		return false;
	}

	protected float GetAnimLength(Animation anim, string strAnim)
	{
		return 0f;
	}

	protected void SampleAnimation(Animation anim, string strAnim, float time)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
