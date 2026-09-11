using UnityEngine;

namespace COW;

public class UIShootingGameRankingItem : MonoBehaviour
{
	public UILabel Rank;

	public UILabel PlayerName;

	public UILabel Score;

	public UILabel Timelabel;

	public UISprite BG;

	public float CreateTime;

	public void SetData(int rank, string nickName, uint score, float createTime, float delTime, bool needFormatTime)
	{
	}

	private void FormatTime(uint score)
	{
	}

	public void SetTimeTxt(float time)
	{
	}
}
