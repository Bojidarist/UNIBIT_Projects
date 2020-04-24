namespace ProgrammingCourseWork
{
    public class SingletonRestoraunt
    {
        private static Restoraunt restoraunt;

        public static Restoraunt Instance
        {
            get
            {
                if (restoraunt == null)
                {
                    restoraunt = new Restoraunt();
                }
                return restoraunt;
            }
        }
    }
}
