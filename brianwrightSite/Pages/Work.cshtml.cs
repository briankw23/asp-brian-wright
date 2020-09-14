using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using brianwrightSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Data;
using Dapper;
using System.Data.SQLite;

namespace brianwrightSite.Pages
{
    public class WorkModel : PageModel
    {
        private readonly string connectionString;

        public WorkModel(IConfiguration configuration)
        {
            connectionString = configuration.GetSection("ConnectionString:Default").Value;
        }

        public void OnGet()
        {
            GetAllResumeItems();
        }

        public List<Resume> GetAllResumeItems()
        {
            using IDbConnection connection = new SQLiteConnection(connectionString);
            
            connection.Open();

            List<Resume> result = connection.Query<Resume>(@"Select * from Resume").ToList();

            return result;
            
        }
    }
}