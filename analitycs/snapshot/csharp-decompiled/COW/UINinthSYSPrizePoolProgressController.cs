using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UINinthSYSPrizePoolProgressController : UIBaseController, UITable2.IUITable2Item
{
	public class NormalRewardBoxGo : UINinthSYSProgressRewardBoxGo
	{
		private GameObject m_NormalBoxIcon;

		private UINetworkTexture m_NormalBoxTexture;

		private GameObject m_OpenlBoxIcon;

		private UINetworkTexture m_OpenlBoxTexture;

		private GameObject m_IconUIFXTrans;

		private bool isNormal;

		private UIModelNinthSYS.IProgress m_ProgressData;

		public Vector3 GetWorldPos()
		{
			return default(Vector3);
		}

		public NormalRewardBoxGo(UIBigEventNormalProgressRewardBoxView view, int index)
			: base(null, 0)
		{
		}

		public void Init(UIModelNinthSYS.IProgress data)
		{
		}

		public override void Refersh()
		{
		}

		public override bool Refersh(uint val)
		{
			return false;
		}

		protected override void RefershView()
		{
		}

		public void _003C_003EiFixBaseProxy_RefershView()
		{
		}
	}

	private UINinthSYSPrizePoolProgressView m_View;

	private UIModelNinthSYS.ProgressAwardDesc m_ProgressAwardDesc;

	private UIModelNinthSYS m_ModelNinthSYS;

	private UIModelNinthSYS.IAwardPoolPreview m_AwardPoolPreview;

	private List<NormalRewardBoxGo> m_NormalRewardBoxGos;

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

	private void InitView()
	{
	}

	private void OnProgressBoxClick(int index, Vector3 position)
	{
	}

	public void SetAwardPoolPreview(UIModelNinthSYS.IAwardPoolPreview awardPoolPreview)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	private void OnProgressRewardItemClickCallback(int index, Vector3 position)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
