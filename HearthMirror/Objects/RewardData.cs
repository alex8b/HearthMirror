using HearthMirror.Enums;

namespace HearthMirror.Objects
{
	public class RewardData
	{
		public RewardType Type { get; }

		public RewardData(RewardType type)
		{
			Type = type;
		}
	}

	public class ArcaneDustRewardData : RewardData
	{
		public int Amount { get; }

		public ArcaneDustRewardData(int amount) : base(RewardType.ARCANE_DUST)
		{
			Amount = amount;
		}
	}

	public class BoosterPackRewardData : RewardData
	{
		public int Id { get; }
		public int Count { get; }

		public BoosterPackRewardData(int id, int count) : base(RewardType.BOOSTER_PACK)
		{
			Id = id;
			Count = count;
		}
	}

	public class CardRewardData : RewardData
	{
		public string Id { get; }
		public int Count { get; }
		public bool Premium { get; }

		public CardRewardData(string id, int count, bool premium) : base(RewardType.CARD)
		{
			Id = id;
			Count = count;
			Premium = premium;
		}
	}

	public class CardBackRewardData : RewardData
	{
		public int Id { get; }

		public CardBackRewardData(int id) : base(RewardType.CARD_BACK)
		{
			Id = id;
		}
	}

	public class ForgeTicketRewardData : RewardData
	{
		public int Quantity { get; }

		public ForgeTicketRewardData(int quantity) : base(RewardType.FORGE_TICKET)
		{
			Quantity = quantity;
		}
	}

	public class GoldRewardData : RewardData
	{
		public int Amount { get; }

		public GoldRewardData(int amount) : base(RewardType.GOLD)
		{
			Amount = amount;
		}
	}

	public class MountRewardData : RewardData
	{
		public int MountType { get; }

		public MountRewardData(int mountType) : base(RewardType.MOUNT)
		{
			MountType = mountType;
		}
	}
}