using proto;
using tcp;

namespace COW;

public class RoomParams
{
	public uint configID;

	public uint group;

	public uint member;

	public uint spectator;

	public uint levellimit;

	public string name;

	public string code;

	public bool enableSpectate;

	public uint roomType;

	public uint visualStyle;

	public uint setting;

	public uint setting2;

	public uint setting3;

	public bool emulatorCheck;

	public bool contestantRoleCheck;

	public bool roomDataInherit;

	public string workshopCode;

	public long workshopUpldateTime;

	public uint workshopSrc;

	public uint ugcScene;

	public byte[] customParams;

	public bool afkPunish;

	public bool soloActiveSkill;

	public int scoreVisible;

	public int OBSwitchSeatEnable;

	public bool enable_score_board;

	public bool show_win;

	public tcp.ERoom.Class room_class;

	public byte[] roomPreviewSettings;

	public bool enableLimitedEventGameplay;

	public bool enable_skill_bp;

	public proto.EInventory.ItemSubType limitedCardType;
}
