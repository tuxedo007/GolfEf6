#region Directives
using System;
using System.ComponentModel;
using System.Reflection;
#endregion

namespace Golf.Entities.Enumerations
{
    #region Game Settings

    public enum TournamentCategoryEnum
    {
        [Description("N/A")]
        Na = 0,
        [Description("FedEx Cup Playoff")]
        Playoff = 1,
        [Description("Major tournament")]
        Major = 2,
        [Description("World Golf Championship")]
        Wgc = 3,
        [Description("FedEx Cup Standard")]
        FecStandard = 4,
        [Description("FedEx Cup Minor")]
        FecMinor = 5,
        [Description("Non-sanctioned event")] // "Non FedEx Cup (Other)"
        NonFec = 6
    }
    
    public enum WindConditionEnum
    {
        [Description("N/A")]
        Na = 0,
        [Description("No Wind")]
        None = 1,
        [Description("Breezy")]
        Breezy = 2,
        [Description("Gusty")]
        Gusty = 3,
        [Description("Windy")]
        Windy = 4
    }

    public enum PinLocationEnum
    {
        [Description("N/A")]
        Na = 0,
        [Description("Easy")]
        Easy = 1,
        [Description("Moderate")]
        Moderate = 2,
        [Description("Difficult")]
        Difficult = 3,
        [Description("Custom")]
        Custom = 4
    }

    #endregion

    #region Putting & Shot enums
    public enum ShotLieEmum
    {
        [Description("N/A")]
        Na = 0,
        [Description("Fairway")]
        Fairway = 1,
        [Description("Sand")]
        Sand = 2,
        [Description("Rough")]
        Rough = 3,
        [Description("Green fringe")]
        Fringe = 4,
        [Description("First cut")]
        FirstCut = 5,
        [Description("Deep rough")]
        DeepRough = 6,
        [Description("Tall grass")]
        TallGrass = 7,
        [Description("Pine straw")]
        Straw = 8,
        [Description("Cedar chips")]
        CedarChip = 9,
        [Description("Shallow water")]
        Water = 10,
        [Description("Cart path")]
        CartPath = 11,
        [Description("Desert")]
        Desert = 12,
        [Description("Dirt")]
        Dirt = 13,
        [Description("Mud")]
        Mud = 14,
        [Description("Rock")]
        Rock = 15,
        [Description("Tee shot")]
        Tee = 16,
        [Description("Other")]
        Other = 17
    }

    public enum ClubEnum
    {
        [Description("1 Iron")] I1 = 1,
        [Description("2 Iron")] I2 = 2,
        [Description("3 Iron")] I3 = 3,
        [Description("4 Iron")] I4 = 4,
        [Description("5 Iron")] I5 = 5,
        [Description("6 Iron")] I6 = 6,
        [Description("7 Iron")] I7 = 7,
        [Description("8 Iron")] I8 = 8,
        [Description("9 Iron")] I9 = 9,
        [Description("Pitching Wedge")] Pw = 10,
        [Description("Pitching Wedge (Chip)")] PwC = 11,
        [Description("Sand Wedge")] Sw = 12,
        [Description("Sand Wedge (Explode)")] SwE = 13,
        [Description("Sand Wedge (Pick)")] SwP = 14,
        [Description("Lofting Wedge")] Lw = 15,
        [Description("Lofting Wedge (Flop)")] LwF = 16,
        [Description("Driver")] W1 = 17, //16
        [Description("2 Wood")] W2 = 18,
        [Description("3 Wood")] W3 = 19,  //18
        [Description("4 Wood")] W4 = 20,
        [Description("5 Wood")] W5 = 21
    }

    public enum GreenSpeedEnum
    {
        [Description("N/A")]
        Na = 0,
        [Description("Slow")]
        Slow = 1,
        [Description("Medium")]
        Medium = 2,
        [Description("Fast")]
        Fast = 3,
        [Description("Slow (Challenging)")]
        SlowChallenge = 4,
        [Description("Medium (Challenging)")]
        MediumChallenge = 5,
        [Description("Fast (Challenging)")]
        FastChallenge = 6,
        [Description("Course Specified")]
        CourseSpecific = 7
    }

    public enum GreenHardnessEnum
    {
        [Description("N/A")]
        Na = 0,
        [Description("Slow")]
        Slow = 1,
        [Description("Medium")]
        Medium = 2,
        [Description("Fast")]
        Fast = 3,
        [Description("Slow (Challenging)")]
        SlowChallenge = 4,
        [Description("Medium (Challenging)")]
        MediumChallenge = 5,
        [Description("Fast (Challenging)")]
        FastChallenge = 6,
        [Description("Course Specified")]
        CourseSpecific = 7
    }

    public enum WindDirectionEnum
    {
        [Description("0° At back")]
        Degree0 = 0,
        [Description("22.5°")]
        Degree22 = 1,
        [Description("45°")]
        Degree45 = 2,
        [Description("67.5°")]
        Degree67 = 3,
        [Description("90° To right")]
        Degree90 = 4,
        [Description("112.5°")]
        Degree112 = 5,
        [Description("135°")]
        Degree135 = 6,
        [Description("157.5°")]
        Degree157 = 7,
        [Description("180° In face")]
        Degree180 = 8,
        [Description("202.5°")]
        Degree202 = 9,
        [Description("225°")]
        Degree225 = 10,
        [Description("247.5°")]
        Degree247 = 11,
        [Description("270° To left")]
        Degree270 = 12,
        [Description("292.5°")]
        Degree292 = 13,
        [Description("315°")]
        Degree315 = 14,
        [Description("337.5°")]
        Degree337 = 15
    }
    #endregion (Putt & Shot enums)

    #region Field Value enums [FUTURE: might make a table with image of flag?]

    public enum CountryEnum
    {
        [Description("Other")] Other = 0,
        [Description("Australia")] Australia = 1,
        [Description("Argentina")] Argentina = 2,
        [Description("Austria")] Austria = 3,
        [Description("Bangladesh")] Bangladesh = 4,
        [Description("Belgium")] Belgium = 5,
        [Description("Brazil")] Brazil = 6,
        [Description("Canada")] Canada = 7,
        [Description("Chile")] Chile = 8,
        [Description("China")] China = 9,
        [Description("Chinese Taipei")] ChineseTaipei = 10,
        [Description("Colombia")] Colombia = 11,
        [Description("Costa Rica")] CostaRica = 12,
        [Description("Denmark")] Denmark = 13,
        [Description("England")] England = 14,
        [Description("Fiji")] Fiji = 15,
        [Description("Finland")] Finland = 16,
        [Description("France")] France = 17,
        [Description("Germany")] Germany = 18,
        [Description("India")] India = 19,
        [Description("Ireland")] Ireland = 20,
        [Description("Italy")] Italy = 21,
        [Description("Japan")] Japan = 22,
        [Description("Korea, Republic of")] NorthKorea = 23,
        [Description("Malaysia")] Malaysia = 24,
        [Description("Mexico")] Mexico = 25,
        [Description("Netherlands")] Netherlands = 26,
        [Description("New Zealand")] NewZealand = 27,
        [Description("Northern Ireland")] NorthernIreland = 28,
        [Description("Paraguay")] Paraguay = 29,
        [Description("Philippines")] Philippines = 30,
        [Description("Portugal")] Portugal = 31,
        [Description("Puerto Rico")] PuertoRico = 32,
        [Description("Scotland")] Scotland = 33,
        [Description("Singapore")] Singapore = 34,
        [Description("South Africa")] SouthAfrica = 35,
        [Description("South Korea")] SouthKorea = 36,
        [Description("Spain")] Spain = 37,
        [Description("Sweden")] Sweden = 38,
        [Description("Thailand")] Thailand = 39,
        [Description("United States")] UnitedStates = 40,
        [Description("Venezuela")] Venezuela = 41,
        [Description("Bolivia")] Bolivia = 42,
        [Description("Wales")] Wales = 43,
        [Description("Zimbabwe")] Zimbabwe = 44

        //[Description("0° At back")]
        //Degree0 = 45,
        //[Description("22.5°")]
        //Degree22 = 46,
        //[Description("45°")]
        //Degree45 = 47,
        //[Description("67.5°")]
        //Degree67 = 48,
        //[Description("90° To right")]
        //Degree90 = 49,
        //[Description("112.5°")]
        //Degree112 = 50,
        //[Description("135°")]
        //Degree136 = 51,
        //[Description("158.5°")]
        //Degree158 = 52,
        //[Description("180° In face")]
        //Degree180 = 53,
        //[Description("202.5°")]
        //Degree202 = 54,
        //[Description("225°")]
        //Degree225 = 55,
        //[Description("247.5°")]
        //Degree247 = 56,
        //[Description("270° To left")]
        //Degree270 = 57,
        //[Description("292.5°")]
        //Degree292 = 58,
        //[Description("315°")]
        //Degree315 = 59,
        //[Description("337.5°")]
        //Degree337 = 60
    }

    #endregion (Field Value enums)

    #region Enum Helpers
    public class GuitarSetEnumerations
    {
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes =
               (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
                //if (attributes != null && attributes.Length > 0)          
                return attributes[0].Description;
            return value.ToString();
        }

        public static string GetEnumDescription<TEnum>(int value)
        {
            return GetEnumDescription((Enum)(object)((TEnum)(object)value)); // ugly, but works } 
        }
    }

    //public class SetSongType
    //{
    //    public string Description { get; set; }
    //    public SetSongTypeEnum SetTypeEnum { get; set; }
    //}

    public static class Enum<T>
    {
        public static string Description(T value)
        {
            DescriptionAttribute[] da =
               (DescriptionAttribute[])
               (typeof(T).GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false));
            return da.Length > 0 ? da[0].Description : value.ToString();
        }
    }
    #endregion Enum Helpers
}
