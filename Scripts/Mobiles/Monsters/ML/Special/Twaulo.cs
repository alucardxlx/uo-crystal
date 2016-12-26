using System;
using Server.Engines.CannedEvil;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a corpse of Twaulo")]
    public class Twaulo : BaseChampion
    {
        [Constructable]
        public Twaulo()
            : base(AIType.AI_Melee)
        {
            Name = "Twaulo";
            Title = "of the Glade";
            Body = 101;
            BaseSoundID = 679;
            Hue = 0x455;

            SetStr(1751, 1950);
            SetDex(251, 450);
            SetInt(801, 1000);

            SetHits(7500);

            SetDamage(19, 24);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 65, 75);
            SetResistance(ResistanceType.Fire, 45, 55);
            SetResistance(ResistanceType.Cold, 50, 60);
            SetResistance(ResistanceType.Poison, 50, 60);
            SetResistance(ResistanceType.Energy, 50, 60);

            SetSkill(SkillName.EvalInt, 0); // Per Stratics?!?
            SetSkill(SkillName.Magery, 0); // Per Stratics?!?
            SetSkill(SkillName.Meditation, 0); // Per Stratics?!?
            SetSkill(SkillName.Anatomy, 95.1, 115.0);
            SetSkill(SkillName.Archery, 95.1, 100.0);
            SetSkill(SkillName.MagicResist, 50.3, 80.0);
            SetSkill(SkillName.Tactics, 90.1, 100.0);
            SetSkill(SkillName.Wrestling, 95.1, 100.0);

            Fame = 50000;
            Karma = 50000;

            VirtualArmor = 50;

            AddItem(new Bow());
            PackItem(new Arrow(Utility.RandomMinMax(500, 700)));
        }

        public Twaulo(Serial serial)
            : base(serial)
        {
        }

        public override ChampionSkullType SkullType
        {
            get { return ChampionSkullType.Pain; }
        }

        public override Type[] UniqueList
        {
            get { return new[] {typeof (Quell)}; }
        }

        public override Type[] SharedList
        {
            get { return new[] {typeof (TheMostKnowledgePerson), typeof (OblivionsNeedle)}; }
        }

        public override Type[] DecorativeList
        {
            get { return new[] {typeof (Pier), typeof (MonsterStatuette)}; }
        }

        public override MonsterStatuetteType[] StatueTypes
        {
            get { return new[] {MonsterStatuetteType.DreadHorn}; }
        }

        public override OppositionGroup OppositionGroup
        {
            get { return OppositionGroup.FeyAndUndead; }
        }

        public override bool Unprovokable
        {
            get { return true; }
        }

        public override Poison PoisonImmune
        {
            get { return Poison.Regular; }
        }

        public override int TreasureMapLevel
        {
            get { return 5; }
        }

        public override int Meat
        {
            get { return 1; }
        }

        public override int Hides
        {
            get { return 8; }
        }

        public override HideType HideType
        {
            get { return HideType.Spined; }
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.UltraRich, 2);
            AddLoot(LootPack.Average);
            AddLoot(LootPack.Gems);
        }

        public void SpawnPixies(Mobile target)
        {
            var map = Map;

            if (map == null)
                return;

            var newPixies = Utility.RandomMinMax(3, 6);

            for (var i = 0; i < newPixies; ++i)
            {
                var pixie = new Pixie();

                pixie.Team = Team;
                pixie.FightMode = FightMode.Closest;

                var validLocation = false;
                var loc = Location;

                for (var j = 0; !validLocation && j < 10; ++j)
                {
                    var x = X + Utility.Random(3) - 1;
                    var y = Y + Utility.Random(3) - 1;
                    var z = map.GetAverageZ(x, y);

                    if (validLocation = map.CanFit(x, y, Z, 16, false, false))
                        loc = new Point3D(x, y, Z);
                    else if (validLocation = map.CanFit(x, y, z, 16, false, false))
                        loc = new Point3D(x, y, z);
                }

                pixie.MoveToWorld(loc, map);
                pixie.Combatant = target;
            }
        }

        public override void AlterDamageScalarFrom(Mobile caster, ref double scalar)
        {
            if (0.1 >= Utility.RandomDouble())
                SpawnPixies(caster);
        }

        public override void OnGaveMeleeAttack(Mobile defender)
        {
            base.OnGaveMeleeAttack(defender);

            defender.Damage(Utility.Random(20, 10), this);
            defender.Stam -= Utility.Random(20, 10);
            defender.Mana -= Utility.Random(20, 10);
        }

        public override void OnGotMeleeAttack(Mobile attacker)
        {
            base.OnGotMeleeAttack(attacker);

            if (0.1 >= Utility.RandomDouble())
                SpawnPixies(attacker);
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadInt();
        }
    }
}