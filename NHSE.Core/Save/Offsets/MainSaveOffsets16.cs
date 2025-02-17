﻿namespace NHSE.Core
{
    /// <summary>
    /// <inheritdoc cref="MainSaveOffsets"/>
    /// </summary>
    public class MainSaveOffsets16 : MainSaveOffsets
    {
        #region GSaveLand
        public const int GSaveLandStart = 0x110;
        public override int Animal => GSaveLandStart + 0x10;

        public override int LandMyDesign => GSaveLandStart + 0x1e2600;
        public override int PatternsPRO => LandMyDesign + (PatternCount * DesignPattern.SIZE);
        public override int PatternFlag => PatternsPRO + (PatternCount * DesignPatternPRO.SIZE);
        public override int PatternTailor => PatternFlag + DesignPattern.SIZE;

        public const int GSaveWeather = GSaveLandStart + 0x1e23B0;
        public override int WeatherArea => GSaveWeather + 0x14; // Hemisphere
        public override int WeatherRandSeed => GSaveWeather + 0x18;

        public override int EventFlagLand => GSaveLandStart + 0x20c40c;

        // GSaveMainField
        public const int GSaveMainFieldStart = GSaveLandStart + 0x20cc0c;
        public override int FieldItem => GSaveMainFieldStart + 0x00000;
        public override int LandMakingMap => GSaveMainFieldStart + 0xAAA00;
        public override int MainFieldStructure => GSaveMainFieldStart + 0xCF600;
        public override int OutsideField => GSaveMainFieldStart + 0xCF998;
        public override int MyDesignMap => GSaveMainFieldStart + 0xCFA34;

        public override int PlayerHouseList => GSaveLandStart + 0x2e7638;
        public override int NpcHouseList => GSaveLandStart + 0x419638;

        public const int GSaveShop = GSaveLandStart + 0x41a880;
        public override int ShopKabu => GSaveShop + 0x2be0; // part of shop; tailor increased size
        public override int Museum => GSaveLandStart + 0x41d9d4;
        public override int Visitor => GSaveLandStart + 0x420dd8;
        public override int SaveFg => GSaveLandStart + 0x421008;
        public override int BulletinBoard => GSaveLandStart + 0x421950;
        public override int AirportThemeColor => GSaveLandStart + 0x502558;
        #endregion

        #region GSaveLandOther
        public const int GSaveLandOtherStart = 0x5062b0;

        public override int LostItemBox => GSaveLandOtherStart + 0x61a4f0;
        public override int LastSavedTime => GSaveLandOtherStart + 0x61ed88;
        #endregion

        public override int VillagerSize => Villager2.SIZE;
        public override IVillager ReadVillager(byte[] data) => new Villager2(data);

        public override int VillagerHouseSize => VillagerHouse1.SIZE;
        public override IVillagerHouse ReadVillagerHouse(byte[] data) => new VillagerHouse1(data);

        public override int PlayerHouseSize => PlayerHouse1.SIZE;
        public override IPlayerHouse ReadPlayerHouse(byte[] data) => new PlayerHouse1(data);
        public override int PlayerRoomSize => PlayerRoom1.SIZE;
        public override IPlayerRoom ReadPlayerRoom(byte[] data) => new PlayerRoom1(data);
    }
}
