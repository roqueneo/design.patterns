namespace factory.method
{
    public abstract class Car
    {
        protected Car(string type)
        {
            _type = type;
        }

        private readonly string _type; 

        public string Type 
        { 
            get
            {
                return _type;
            } 
        }
        
    }
}