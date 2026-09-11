using GCommon;
using UnityEngine;

namespace COW;

public class UIClanPrivilegeSharePreviewView : UIBaseView
{
	public UILabel Title;

	public UILabel ClanLevel;

	public GameObject ClanName;

	public GameObject ClanCertification;

	public UILabel ClanNameLabel;

	public UILabel ClanID;

	public UILabel ClanLocation;

	public UINetworkTexture PreviewIcon;

	public UILabel PreviewClanName;

	public GameObject ShareSponsoredContainer;

	public UILabel SponsoredLabel;

	public GameObject ShareCallsignPviot;

	public GameObject LeftOldSeat;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
