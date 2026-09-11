using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelCloseFriendSharedSkill : UIBaseModel, IUIModelDataChangeObserver
{
	private struct RequestParams
	{
		public bool Force;

		public uint HttpOp;
	}

	public const uint PropID_RequestSharedSkillsSuccess = 1u;

	private Action<HttpErrorCode, object> m_ResponseDelegate;

	private HashSet<uint> m_SharedSkills;

	private ulong m_LastRequestTimeStamp;

	private const int RequestCoolDown = 10;

	private bool m_FeatureSwitch;

	private RequestParams? m_RequestParamsCache;

	public bool HasGetSharedSkills;

	public HashSet<uint> SharedSkills => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public void SetFeatureSwitch(BuddySkillSettingDesc buddySkillSettingDesc)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void RequestSharedSkills(bool force = false, uint httpOp = 0u)
	{
	}

	private void RequestSharedSkillsInternal(bool force = false, uint httpOp = 0u)
	{
	}

	private void RequestSharedSkillsResponse(HttpErrorCode errorCode, object res)
	{
	}

	private void RequestCloseFriendName()
	{
	}

	public bool CloseFriendCanShareSkill()
	{
		return false;
	}

	public string GetCloseFriendName()
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
