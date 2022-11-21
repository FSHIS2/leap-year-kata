namespace LeapYear {
    public class LeapYear {

        public static bool IsLeap(int year) {
            if (IsDivisibleBy400(year)) return true;
            if (IsDivisibleBy4(year) && !IsDivisibleBy100(year)) return true;
            return false;
        }

        public static bool IsDivisibleBy4(int year) {
            return year % 4 == 0;
        }

        public static bool IsDivisibleBy100(int year) {
            return year % 100 == 0;
        }

        public static bool IsDivisibleBy400(int year) {
            return year % 400 == 0;
        }

    }
}