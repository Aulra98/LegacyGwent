using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("24017")]//狼人
	public class Werewolf : CardEffect
	{//接触“满月”后获得7点增益。 免疫。
		public Werewolf(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}