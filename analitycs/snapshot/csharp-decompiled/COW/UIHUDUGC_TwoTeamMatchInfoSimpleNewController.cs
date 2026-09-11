using COW.Gameplay.UGC;
using GCommon;

namespace COW;

public class UIHUDUGC_TwoTeamMatchInfoSimpleNewController : UIHUDUGC_InternalHudController
{
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public UISprite target;

		public string defaultSpriteName;

		internal void _003CUpdateIcon_003Eb__0(UGCResourceUIAtlas atlas, string spriteName)
		{
		}
	}

	private UIHUDUGC_TwoTeamMatchInfoSimpleNewView m_View;

	private UGCTwoTeamMatchInfoSimpleHudV2RepItem m_ViewData;

	private string m_DefaultAliveSpriteName;

	private string m_DefaultDeadSpriteName;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnLeftScoreChanged(int cur)
	{
	}

	private void OnRightScoreChanged(int cur)
	{
	}

	private void OnLeftAliveCountChanged(int cur)
	{
	}

	private void OnRightAliveCountChanged(int cur)
	{
	}

	private void OnLeftDeadCountChanged(int cur)
	{
	}

	private void OnRightDeadCountChanged(int cur)
	{
	}

	private void OnLeftAliveIconChanged(string cur)
	{
	}

	private void OnRightAliveIconChanged(string cur)
	{
	}

	private void OnLeftDeadIconChanged(string cur)
	{
	}

	private void OnRightDeadIconChanged(string cur)
	{
	}

	private void UpdateIcon(UISprite target, string iconResIdOrUUID, string defaultSpriteName)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
