using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_TextIconMarkShowController : UIHudNameBaseController
{
	private FollowCamera m_FollowCamera;

	private UIHUDUGC_TextIconMarkShowView m_View;

	private Vector3 m_BindWorldPosition;

	private UGCTextEntityRepItem m_TextData;

	private UGCIconEntityRepItem m_IconData;

	private UGCTransformRepItem m_TransformData;

	private int m_EntityType;

	private string m_EntityId;

	private bool m_Visible;

	private BaseLevelObject m_BindObject;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void SetViewData(string entityId, BaseLevelObject bindObj, int type)
	{
	}

	private Vector3 GetWidgetScale()
	{
		return default(Vector3);
	}

	private void ResetTextScale()
	{
	}

	private void OnFontSizeChanged(int value)
	{
	}

	private void OnTextWidthChanged(int value)
	{
	}

	private void OnTextHeightChanged(int value)
	{
	}

	private void OnFondOverFlowModChanged(int value)
	{
	}

	private void OnEntityDepthChanged(int value)
	{
	}

	private void OnHeightChanged(int value)
	{
	}

	private void OnWidthChanged(int value)
	{
	}

	private void OnRenderTypeChanged(int value)
	{
	}

	private void CalWidthHeight()
	{
	}

	private void OnLocalPositionChanged(Vector3 vector)
	{
	}

	private void OnIconColorChanged(int value)
	{
	}

	private void OnTextColorChanged(int value)
	{
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	protected override Vector2 GetWidgetBound()
	{
		return default(Vector2);
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedOptDistanceUpdate()
	{
		return false;
	}

	protected override void OnDistanceLabelChanged()
	{
	}

	private void OnTextChanged(string valueNew)
	{
	}

	private void OnIconTypeChanged(string valueNew)
	{
	}

	protected void SetVisible(bool value)
	{
	}

	protected override void UpdateNamePosition()
	{
	}

	protected bool GetVisibility()
	{
		return false;
	}

	private void _003COnIconTypeChanged_003Eb__38_0(UGCResourceUIAtlas atlasRes, string spriteName)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}

	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		return default(Vector2);
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedOptDistanceUpdate()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDistanceLabelChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateNamePosition()
	{
	}
}
