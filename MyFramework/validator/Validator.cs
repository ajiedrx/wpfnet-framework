namespace Velacro.Validator {
    public class Validator : IValidator
    {
        private MyRegex regex;

        public static Validator STRING_VALIDATION = new Validator(new MyRegex("[^a-zA-Z]"));
        public static Validator NUMBER_VALIDATION = new Validator(new MyRegex("[^0-9]+"));
        public static Validator EMAIL_VALIDATON = new Validator(new MyRegex("^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+[.])+[a-z]{2,5}$"));

        private Validator(MyRegex _regex) { this.regex = _regex; }
            
        public MyRegex getMyRegex() {
            return this.regex;
        }
    }
}
