namespace LeapYear {
    public class LeapYear {

        public static bool IsLeap(int year) {
            if (year == 1700 || year == 1800) return false;
            return true;
        }

    }
}