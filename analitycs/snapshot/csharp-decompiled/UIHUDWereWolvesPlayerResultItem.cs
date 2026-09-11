using COW.GamePlay;
using UnityEngine;

public class UIHUDWereWolvesPlayerResultItem : MonoBehaviour
{
	public UILabel IndexLabel;

	public UISprite IndexBg;

	public UISprite PetIcon;

	public UILabel NameLabel;

	public UISprite KillOrTaskSprite;

	public UILabel KillOrTaskCount;

	public GameObject OtherPlayerRoot;

	public UIButton AddFriendeBtn;

	public UISprite AddFriendSprite;

	public UIButton ThumbUPBtn;

	public UISprite ThumbUPSprite;

	public GameObject IsDeadRoot;

	public GameObject SelfColorBg;

	public UISprite IconBg1;

	public UISprite IconBg2;

	public GameObject Mic;

	private bool m_IsInited;

	private ulong m_UserID;

	private string m_LockRegion;

	private bool m_IsThumbUP;

	public bool IsThumbUp => false;

	public void InitShowData(ulong userID, BHGGAEEHJCO playerID, string nickName, int roleColorIndex, bool isDead, bool isWolf, int taskOrKillCount, string lockRegion)
	{
	}

	private void SetFriendBtnState()
	{
	}

	private void SetPetIcon(int colorIndex)
	{
	}

	private void OnAddFriend()
	{
	}

	private void OnThumbUp()
	{
	}

	public void SetMicActive(bool isActive)
	{
	}
}
