using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudSkillEffectCountingController : UIBaseController
{
	public const uint VISIBILITY_STATE_LIVE = 1073741824u;

	private UIHudSkillEffectCountingView m_View;

	private HBLKLJHFJDK m_ActiveSkill;

	private bool m_AlwaysKeep;

	private int m_Index;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void TriggerActiveSkill(HBLKLJHFJDK newActiveSkill)
	{
	}

	public bool GetAlwayKeep()
	{
		return false;
	}

	public void StopActiveSkill()
	{
	}

	private void Update()
	{
	}

	private void OnClick()
	{
	}

	private void OnUpdateSkillIcon(object[] param)
	{
	}

	private void OnLocalPlayerDead(object[] param)
	{
	}

	public void SetIndex(int index)
	{
	}

	private void OnAddLocalPlayer(object[] param)
	{
	}

	public uint GetSkillId()
	{
		return 0u;
	}

	public ResourceID GetIcon()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
