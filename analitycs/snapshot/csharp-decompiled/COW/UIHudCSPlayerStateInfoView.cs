using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSPlayerStateInfoView : MonoBehaviour
{
	public UISprite StateAlive;

	public UISprite StateKnockDown;

	public UISprite StateDead;

	private VisualInstanceHolder m_Holder;

	private ResourceID m_ResourceEffectID;

	public void Init(ResourceID resEffectID)
	{
	}

	public void SetTeammateState(ETeammateState nextState)
	{
	}

	public void HideTeammateStates()
	{
	}
}
