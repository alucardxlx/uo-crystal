using System;
using Server.Mobiles;

namespace Server.Items
{
    public class SlayerGroup
    {
        static SlayerGroup()
        {
            var humanoid = new SlayerGroup();
            var undead = new SlayerGroup();
            var elemental = new SlayerGroup();
            var abyss = new SlayerGroup();
            var arachnid = new SlayerGroup();
            var reptilian = new SlayerGroup();
            var fey = new SlayerGroup();

            humanoid.Opposition = new[] {undead};
            humanoid.FoundOn = new[] {typeof (BoneKnight), typeof (Lich), typeof (LichLord)};
            humanoid.Super = new SlayerEntry(SlayerName.Repond, typeof (ArcticOgreLord), typeof (Cyclops),
                typeof (Ettin), typeof (EvilMage), typeof (EvilMageLord), typeof (FrostTroll), typeof (MeerCaptain),
                typeof (MeerEternal), typeof (MeerMage), typeof (MeerWarrior), typeof (Ogre), typeof (OgreLord),
                typeof (Orc), typeof (OrcBomber), typeof (OrcBrute), typeof (OrcCaptain), typeof (OrcChopper),
                typeof (OrcScout), typeof (OrcishLord), typeof (OrcishMage), typeof (Ratman), typeof (RatmanArcher),
                typeof (RatmanMage), typeof (SavageRider), typeof (SavageShaman), typeof (Savage), typeof (Titan),
                typeof (Troglodyte), typeof (Troll), /* Mondain's Legacy */ typeof (Troglodyte), typeof (MougGuur),
                typeof (Chiikkaha), typeof (Minotaur) /* ML End, SA begins */, typeof (Medusa),
                typeof (RakktaviRenowned), typeof (TikitaviRenowned), typeof (VitaviRenowned),
                typeof (EnslavedGoblinScout), typeof (EnslavedGoblinKeeper), typeof (EnslavedGreenGoblin),
                typeof (EnslavedGreenGoblinAlchemist), typeof (EnslavedGoblinMage), typeof (EnslavedGrayGoblin),
                typeof (GreenGoblinScout), typeof (GreenGoblinAlchemist), typeof (GreenGoblin), typeof (GrayGoblinMage),
                typeof (GrayGoblinKeeper), typeof (GrayGoblin), typeof (GreenGoblinAlchemistRenowned),
                typeof (GrayGoblinMageRenowned), typeof (Barracoon));
            humanoid.Entries = new[]
            {
                new SlayerEntry(SlayerName.OgreTrashing, typeof (Ogre), typeof (OgreLord), typeof (ArcticOgreLord)),
                new SlayerEntry(SlayerName.OrcSlaying, typeof (Orc), typeof (OrcBomber), typeof (OrcBrute),
                    typeof (OrcCaptain), typeof (OrcChopper), typeof (OrcScout), typeof (OrcishLord),
                    typeof (OrcishMage)),
                new SlayerEntry(SlayerName.TrollSlaughter, typeof (Troll), typeof (FrostTroll))
            };

            undead.Opposition = new[] {humanoid};
            undead.Super = new SlayerEntry(SlayerName.Silver, typeof (AncientLich), typeof (AncientLichRenowned),
                typeof (Bogle), typeof (BoneKnight), typeof (BoneMagi), /* typeof( DarkGuardian ), */
                typeof (DarknightCreeper), typeof (FleshGolem), typeof (Ghoul), typeof (GoreFiend), typeof (HellSteed),
                typeof (LadyOfTheSnow), typeof (Lich), typeof (LichLord), typeof (Mummy), typeof (PestilentBandage),
                typeof (Revenant), typeof (RevenantLion), typeof (RottingCorpse), typeof (Shade), typeof (ShadowKnight),
                typeof (SkeletalKnight), typeof (SkeletalMage), typeof (SkeletalMount), typeof (Skeleton),
                typeof (Spectre), typeof (Wraith), typeof (Zombie), /* Mondain's Legacy */ typeof (UnfrozenMummy),
                typeof (RedDeath), typeof (SirPatrick), typeof (LadyJennifyr), typeof (MasterMikael),
                typeof (MasterJonath), typeof (LadyMarai) /* ML End, SA Begins */, typeof (PrimevalLich),
                typeof (DreamWraith), typeof (UndeadGargoyle), typeof (UndeadGuardian), typeof (PutridUndeadGuardian));
            undead.Entries = new SlayerEntry[0];

            fey.Opposition = new[] {abyss};
            fey.Super = new SlayerEntry(SlayerName.Fey, typeof (Centaur), typeof (CuSidhe), typeof (EtherealWarrior),
                typeof (Kirin), typeof (LordOaks), typeof (Pixie), typeof (PixieRenowned), typeof (Silvani),
                typeof (Treefellow), typeof (Unicorn), typeof (Wisp), typeof (MLDryad), typeof (Satyr),
                /* Mondain's Legacy */ typeof (InsaneDryad), typeof (CorporealBrume), typeof (CrystalLatticeSeeker),
                typeof (LadyMelisande) /* End */, typeof (FeralTreefellow));
            fey.Entries = new SlayerEntry[0];

            elemental.Opposition = new[] {abyss};
            elemental.FoundOn = new[] {typeof (Balron), typeof (Daemon)};
            elemental.Super = new SlayerEntry(SlayerName.ElementalBan, typeof (ToxicElemental), typeof (AcidElemental),
                typeof (AcidElementalRenowned), typeof (FireElementalRenowned), typeof (AgapiteElemental),
                typeof (AirElemental), typeof (SummonedAirElemental), typeof (BloodElemental), typeof (BronzeElemental),
                typeof (CopperElemental), typeof (CrystalElemental), typeof (DullCopperElemental),
                typeof (EarthElemental), typeof (SummonedEarthElemental), typeof (Efreet), typeof (FireElemental),
                typeof (SummonedFireElemental), typeof (GoldenElemental), typeof (IceElemental), typeof (KazeKemono),
                typeof (PoisonElemental), typeof (RaiJu), typeof (SandVortex), typeof (ShadowIronElemental),
                typeof (SnowElemental), typeof (ValoriteElemental), typeof (VeriteElemental), typeof (WaterElemental),
                typeof (SummonedWaterElemental), typeof (Flurry), typeof (Mistral), typeof (Tempest));
            elemental.Entries = new[]
            {
                new SlayerEntry(SlayerName.BloodDrinking, typeof (BloodElemental)),
                new SlayerEntry(SlayerName.EarthShatter, typeof (AgapiteElemental), typeof (BronzeElemental),
                    typeof (CopperElemental), typeof (DullCopperElemental), typeof (EarthElemental),
                    typeof (SummonedEarthElemental), typeof (GoldenElemental), typeof (ShadowIronElemental),
                    typeof (ValoriteElemental), typeof (VeriteElemental)),
                new SlayerEntry(SlayerName.ElementalHealth, typeof (PoisonElemental)),
                new SlayerEntry(SlayerName.FlameDousing, typeof (FireElemental), typeof (FireElementalRenowned),
                    typeof (SummonedFireElemental)),
                new SlayerEntry(SlayerName.SummerWind, typeof (SnowElemental), typeof (IceElemental)),
                new SlayerEntry(SlayerName.Vacuum, typeof (AirElemental), typeof (SummonedAirElemental), typeof (Flurry),
                    typeof (Mistral), typeof (Tempest)),
                new SlayerEntry(SlayerName.WaterDissipation, typeof (WaterElemental), typeof (SummonedWaterElemental))
            };

            abyss.Opposition = new[] {elemental, fey};
            abyss.FoundOn = new[] {typeof (BloodElemental)};

            if (Core.AOS)
            {
                abyss.Super = new SlayerEntry(SlayerName.Exorcism, typeof (DevourerRenowned),
                    typeof (FireDaemonRenowned), typeof (AbysmalHorror), typeof (AbyssalInfernal), typeof (ArcaneDaemon),
                    typeof (Balron), typeof (BoneDemon), typeof (ChaosDaemon), typeof (Daemon), typeof (SummonedDaemon),
                    typeof (DemonKnight), typeof (Devourer), typeof (EnslavedGargoyle), typeof (FanDancer),
                    typeof (FireGargoyle), typeof (Gargoyle), typeof (GargoyleDestroyer), typeof (GargoyleEnforcer),
                    typeof (Gibberling), typeof (HordeMinion), typeof (IceFiend), typeof (Imp), typeof (Impaler),
                    typeof (Moloch), typeof (Oni), typeof (Ravager), typeof (Semidar), typeof (StoneGargoyle),
                    typeof (Succubus), typeof (TsukiWolf), /* Mondain's Legacy */ typeof (Szavetra),
                    typeof (CrystalDaemon) /* End */, typeof (SlasherOfVeils), typeof (GargoyleShade),
                    typeof (Putrefier));

                abyss.Entries = new[]
                {
                    // Daemon Dismissal & Balron Damnation have been removed and moved up to super slayer on OSI.
                    new SlayerEntry(SlayerName.GargoylesFoe, typeof (EnslavedGargoyle), typeof (FireGargoyle),
                        typeof (Gargoyle), typeof (GargoyleDestroyer), typeof (GargoyleEnforcer), typeof (StoneGargoyle),
                        typeof (GargoyleShade))
                };
            }
            else
            {
                abyss.Super = new SlayerEntry(SlayerName.Exorcism, typeof (AbysmalHorror), typeof (Balron),
                    typeof (BoneDemon), typeof (ChaosDaemon), typeof (Daemon), typeof (SummonedDaemon),
                    typeof (DemonKnight), typeof (Devourer), typeof (Gargoyle), typeof (FireGargoyle),
                    typeof (Gibberling), typeof (HordeMinion), typeof (IceFiend), typeof (Imp), typeof (Impaler),
                    typeof (Ravager), typeof (StoneGargoyle), typeof (ArcaneDaemon), typeof (EnslavedGargoyle),
                    typeof (GargoyleDestroyer), typeof (GargoyleEnforcer), typeof (Moloch));

                abyss.Entries = new[]
                {
                    new SlayerEntry(SlayerName.DaemonDismissal, typeof (AbysmalHorror), typeof (Balron),
                        typeof (BoneDemon), typeof (ChaosDaemon), typeof (Daemon), typeof (SummonedDaemon),
                        typeof (DemonKnight), typeof (Devourer), typeof (Gibberling), typeof (HordeMinion),
                        typeof (IceFiend), typeof (Imp), typeof (Impaler), typeof (Ravager), typeof (ArcaneDaemon),
                        typeof (Moloch)),
                    new SlayerEntry(SlayerName.GargoylesFoe, typeof (FireGargoyle), typeof (Gargoyle),
                        typeof (StoneGargoyle), typeof (EnslavedGargoyle), typeof (GargoyleDestroyer),
                        typeof (GargoyleEnforcer)),
                    new SlayerEntry(SlayerName.BalronDamnation, typeof (Balron))
                };
            }

            arachnid.Opposition = new[] {reptilian};
            arachnid.FoundOn = new[]
            {
                typeof (AncientWyrm), typeof (GreaterDragon), typeof (Dragon), typeof (OphidianMatriarch),
                typeof (ShadowWyrm)
            };
            arachnid.Super = new SlayerEntry(SlayerName.ArachnidDoom, typeof (DreadSpider), typeof (FrostSpider),
                typeof (GiantBlackWidow), typeof (GiantSpider), typeof (Mephitis), typeof (Scorpion),
                typeof (TerathanAvenger), typeof (TerathanDrone), typeof (TerathanMatriarch), typeof (TerathanWarrior),
                /* Mondain's Legacy */ typeof (Miasma), typeof (SpeckledScorpion), typeof (LadyLissith),
                typeof (LadySabrix), typeof (Virulent), typeof (Silk), typeof (Malefic) /* End */, typeof (Navrey),
                typeof (SentinelSpider), typeof (WolfSpider), typeof (TrapdoorSpider));
            arachnid.Entries = new[]
            {
                new SlayerEntry(SlayerName.ScorpionsBane, typeof (Scorpion), /* Mondain's Legacy */ typeof (Miasma),
                    typeof (SpeckledScorpion) /* End */),
                new SlayerEntry(SlayerName.SpidersDeath, typeof (DreadSpider), typeof (FrostSpider),
                    typeof (GiantBlackWidow), typeof (GiantSpider), typeof (Mephitis), /* Mondain's Legacy */
                    typeof (LadyLissith), typeof (LadySabrix), typeof (Virulent), typeof (Silk), typeof (Malefic)
                    /* End */, typeof (Navrey), typeof (SentinelSpider), typeof (WolfSpider), typeof (TrapdoorSpider)),
                new SlayerEntry(SlayerName.Terathan, typeof (TerathanAvenger), typeof (TerathanDrone),
                    typeof (TerathanMatriarch), typeof (TerathanWarrior))
            };

            reptilian.Opposition = new[] {arachnid};
            reptilian.FoundOn = new[] {typeof (TerathanAvenger), typeof (TerathanMatriarch)};
            reptilian.Super = new SlayerEntry(SlayerName.ReptilianDeath, typeof (SkeletalDragonRenowned),
                typeof (WyvernRenowned), typeof (AncientWyrm), typeof (DeepSeaSerpent), typeof (GreaterDragon),
                typeof (Dragon), typeof (Drake), typeof (GiantIceWorm), typeof (IceSerpent), typeof (GiantSerpent),
                typeof (Hiryu), typeof (IceSnake), typeof (JukaLord), typeof (JukaMage), typeof (JukaWarrior),
                typeof (LavaSerpent), typeof (LavaSnake), typeof (LesserHiryu), typeof (Lizardman),
                typeof (OphidianArchmage), typeof (OphidianKnight), typeof (OphidianMage), typeof (OphidianMatriarch),
                typeof (OphidianWarrior), typeof (Reptalon), typeof (SeaSerpent), typeof (Serado),
                typeof (SerpentineDragon), typeof (ShadowWyrm), typeof (SilverSerpent), typeof (SkeletalDragon),
                typeof (Snake), typeof (SwampDragon), typeof (WhiteWyrm), typeof (Wyvern), typeof (Yamandon),
                typeof (Hydra), typeof (CrystalHydra), typeof (CrystalSeaSerpent), typeof (Rend), typeof (Thrasher),
                typeof (Abscess), typeof (Grim), typeof (ChickenLizard), typeof (StygianDragon), typeof (FairyDragon), 
				typeof (Skree), typeof (Slith), typeof (StoneSlith), typeof (ToxicSlith), typeof (Raptor),
                typeof (Kepetch), typeof (KepetchAmbusher));
            reptilian.Entries = new[]
            {
                new SlayerEntry(SlayerName.DragonSlaying, typeof (SkeletalDragonRenowned), typeof (WyvernRenowned),
                    typeof (AncientWyrm), typeof (GreaterDragon), typeof (Dragon), typeof (Drake), typeof (Hiryu),
                    typeof (LesserHiryu), typeof (Reptalon), typeof (SerpentineDragon), typeof (ShadowWyrm),
                    typeof (SkeletalDragon), typeof (SwampDragon), typeof (WhiteWyrm), typeof (Wyvern), typeof (Hydra),
                    typeof (CrystalHydra), typeof (Rend), typeof (Abscess), typeof (Grim), typeof (StygianDragon),
                    typeof (FairyDragon)),
                new SlayerEntry(SlayerName.LizardmanSlaughter, typeof (Lizardman)),
                new SlayerEntry(SlayerName.Ophidian, typeof (OphidianArchmage), typeof (OphidianKnight),
                    typeof (OphidianMage), typeof (OphidianMatriarch), typeof (OphidianWarrior)),
                new SlayerEntry(SlayerName.SnakesBane, typeof (DeepSeaSerpent), typeof (GiantIceWorm),
                    typeof (GiantSerpent), typeof (IceSerpent), typeof (IceSnake), typeof (LavaSerpent),
                    typeof (LavaSnake), typeof (SeaSerpent), typeof (Serado), typeof (SilverSerpent), typeof (Snake),
                    typeof (Yamandon), typeof (CrystalSeaSerpent))
            };

            Groups = new[]
            {
                humanoid,
                undead,
                elemental,
                abyss,
                arachnid,
                reptilian,
                fey
            };

            TotalEntries = CompileEntries(Groups);
        }

        public static SlayerEntry[] TotalEntries { get; private set; }
        public static SlayerGroup[] Groups { get; private set; }
        public SlayerGroup[] Opposition { get; set; }
        public SlayerEntry Super { get; set; }
        public SlayerEntry[] Entries { get; set; }
        public Type[] FoundOn { get; set; }

        public static SlayerEntry GetEntryByName(SlayerName name)
        {
            var v = (int) name;

            if (v >= 0 && v < TotalEntries.Length)
                return TotalEntries[v];

            return null;
        }

        public static SlayerName GetLootSlayerType(Type type)
        {
            for (var i = 0; i < Groups.Length; ++i)
            {
                var group = Groups[i];
                var foundOn = group.FoundOn;

                var inGroup = false;

                for (var j = 0; foundOn != null && !inGroup && j < foundOn.Length; ++j)
                    inGroup = (foundOn[j] == type);

                if (inGroup)
                {
                    var index = Utility.Random(1 + group.Entries.Length);

                    if (index == 0)
                        return group.Super.Name;

                    return group.Entries[index - 1].Name;
                }
            }

            return SlayerName.Silver;
        }

        public bool OppositionSuperSlays(Mobile m)
        {
            for (var i = 0; i < Opposition.Length; i++)
            {
                if (Opposition[i].Super.Slays(m))
                    return true;
            }

            return false;
        }

        private static SlayerEntry[] CompileEntries(SlayerGroup[] groups)
        {
            var entries = new SlayerEntry[28];

            for (var i = 0; i < groups.Length; ++i)
            {
                var g = groups[i];

                g.Super.Group = g;

                entries[(int) g.Super.Name] = g.Super;

                for (var j = 0; j < g.Entries.Length; ++j)
                {
                    g.Entries[j].Group = g;
                    entries[(int) g.Entries[j].Name] = g.Entries[j];
                }
            }

            return entries;
        }
    }
}