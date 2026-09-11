using GCommon;
using UnityEngine;

namespace COW;

public class UIHudRoutePlanningMapMarkerView : UIBaseView
{
	public UISprite WaypointArrowIcon;

	public UISprite EndpointIcon;

	public Transform PointingStateIconsGroup;

	public UISprite NextWaypointLine;

	public UIWidget RootWidget;

	public UISprite WaypointArrowIconColorBg;

	public UISprite EndpointIconColorBg1;

	public UISprite EndpointIconBg2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
