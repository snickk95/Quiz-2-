using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace TransactionRecordApp.Entities
{
    /// <summary>
    /// This class represents the columns in the Transaction table in the DB
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// this corresponds with the table PK and will work as an auto number
        /// since it's an int
        /// </summary>
        public int TransactionId { get; set; }


        [Required(ErrorMessage = "Please enter a Ticker Symbol")]
        public string? TickerSymbol { get; set; }


        [Required(ErrorMessage = "Please enter the Company Name")]
        public string? CompanyName { get; set; }


        [Required(ErrorMessage = "Please enter the quantity of shares")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a whole number greater than zero")]
        public int? Quantity { get; set; }

        //required double value for the share price
        [Required(ErrorMessage = "share price is required")]
        [Range(0.0, double.MaxValue, ErrorMessage = "Price cannot be lowwer then 0")]
        public double? sharePrice { get; set; }
        
        [ReadOnly(true)]//make the gross val read only
        public double? grossVal { get
            {
                //logic for any errors that could happen for a calculation and exceptions thrown for edge cases 
                if (Quantity == null)
                {
                    throw new ArgumentException("Quantity is null unable to calculate gross value");
                  
                }
                else if (sharePrice == null)
                {
                    throw new ArgumentException("share price is null unable to calculate gross value");
                }
                else
                {
                    return Quantity * sharePrice;
                }

            } }
    }
}
