namespace DesmondLimitedCredit
{
    public class Customer
    {
public string Name { get; set; }
        private decimal principalAmount;
        private int interestRate;
        private int time;
        public Customer(string name, decimal principalAmount, int interestRate, int time)
        {
            Name = name;
            PrincipalAmount = principalAmount;
            InterestRate = interestRate;
            Time = time;
        }
        public int Time
        {
            get { return time; }
            set { 
                if(value > 0)
                {
                    time = value; 
                }
                }
        }
        
        public int InterestRate
        {
            get { return interestRate/100; }
            set { 
                if(value > 0)
                {
                    interestRate = value;
                }
                }
        }
        
        public decimal PrincipalAmount
        {
            get { return principalAmount; }
            set { 
                if(value > 0){
                    principalAmount = value;
                }
                }
        }
        public override string ToString()
        {
            return $"Name: {Name} Amount: {PrincipalAmount:C} Interest Rate: {InterestRate}% Time: {Time}years";
        }
    }
}