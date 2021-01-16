namespace singleton
{
    public class Singleton
    {

        protected Singleton() 
        { 
            Message = "I'm a singleton";
        }

        private static Singleton _instance = null;

        public static Singleton Instance 
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();
                
                return _instance;
            }
        }

        public string Message = "";

    }
}