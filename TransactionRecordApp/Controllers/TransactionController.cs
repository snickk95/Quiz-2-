using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TransactionRecordApp.Entities;

namespace TransactionRecordApp.Controllers
{
    /// <summary>
    /// Controls the Add, Edit and Delete functions
    /// </summary>
    public class TransactionController : Controller
    {
        private TransactionDbContext _DbContext;
        public TransactionController (TransactionDbContext context)
        {
            _DbContext = context;
        }

        public IActionResult List()
        {
            //query to list all by company name
            List<Transaction> transactions= _DbContext.Transactions.OrderBy(m => m.CompanyName).ToList();

            //return to the model
            return View(transactions);
        }
    }
}
