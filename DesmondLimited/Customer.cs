// using System;
// using System.Collections.Generic;
// namespace DesmondLimited
// {
//     public class Customer
//     {
//         public string Name { get; set; }
//         private decimal principalAmount;
//         private decimal interestRate;
//         private int time;
//         public ClientInfo(string name, decimal principalAmount, decimal interestRate, int time)
//         {
//             Name = name;
//             PrincipalAmount = principalAmount;
//             InterestRate = interestRate;
//             Time = time;
//         }
//         public int Time
//         {
//             get { return time; }
//             set { 
//                 if(value > 0)
//                 {
//                     time = value; 
//                 }
//                 }
//         }
        
//         public decimal InterestRate
//         {
//             get { return interestRate; }
//             set { 
//                 if(value > 0)
//                 {
//                     interestRate = value;
//                 }
//                 }
//         }
        
//         public decimal PrincipalAmount
//         {
//             get { return principalAmount; }
//             set { 
//                 if(value > 0){
//                     principalAmount = value;
//                 }
//                 }
//         }

//         public decimal SimpleInterest()
//         {
//             return (PrincipalAmount * InterestRate * Time)/100;
//         }

//         public decimal CompoundInterest()
//         {
//             return PrincipalAmount * Math.Pow((1 + InterestRate), Time);
//         }

//         public override string ToString()
//         {
//             return $"{Name} {PrincipalAmount} {InterestRate}\n==================\nSimple Interest: {SimpleInterest}\nCompound Interest: {CompoundInterest}\n==================";
//         }
//     }
// }