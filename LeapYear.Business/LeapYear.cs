namespace LeapYear {
    public class LeapYear {

        public static bool IsLeap(int year) {
            if (year % 400 == 0) return true;
            if (year % 4 == 0) return true;
            return false;
        }

    }
}