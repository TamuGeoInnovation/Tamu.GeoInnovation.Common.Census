namespace USC.GISResearchLab.Common.Census
{
    public class FCCTypes
    {
        // FCCs for road types
        public static string[] HIGHWAY = new string[] { "A10", "A11", "A12", "A13", "A14", "A15", "A16", "A17", "A18" };
        public static string[] MAJOR_ROAD = new string[] { "A20", "A21", "A22", "A23", "A24", "A25", "A26", "A27", "A28" };
        public static string[] MINOR_ROAD = new string[] { "A30", "A31", "A32", "A33", "A34", "A35", "A36", "A37", "A38" };
        public static string[] LOCAL_ROAD = new string[] { "A40", "A41", "A42", "A43", "A44", "A45", "A46", "A47", "A48", "A60", "A61", "A62", "A70", "A71", "A72", "A73", "A74" };
        public static string[] RAMP = new string[] { "A63" };

        //' FCCs for ferry types
        public static string[] FERRY = new string[] { "A65", "A66", "A68", "A69" };

        //' FCCs for airport types
        public static string[] RUNWAY = new string[] { "D59" };
        public static string[] AIRPORT = new string[] { "D58" };

        //' FCCs for rail types
        public static string[] RAIL = new string[] { "B00", "B01", "B02", "B03", "B10", "B11", "B12", "B13", "B20", "B21", "B22", "B23" };

        //' FCCs for stadium types
        public static string[] STADIUM = new string[] { "D67" };

        //' FCCs for other landmark types
        public static string[] MILITARY = new string[] { "D10" };
        public static string[] CEMETERY = new string[] { "D82" };
        public static string[] GOLF_COURSE = new string[] { "D81" };
        public static string[] GOVERNMENT = new string[] { "D65" };
        public static string[] AMUSEMENT = new string[] { "D64" };
        public static string[] MALL = new string[] { "D61" };
        public static string[] HOSPITAL = new string[] { "D31" };
    }
}
